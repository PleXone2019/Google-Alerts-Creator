using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BlueSoft;
using System.Reflection;
using System.Globalization;
using Microsoft.Win32;

namespace BlueSoft
{
    public partial class AdvWebBrowser : Form
    {
        #region Var proxy
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        private const string regKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        #endregion
        #region Var prevent browser download
        enum DOCDOWNLOADCTLFLAG
        {
            DLIMAGES = unchecked((int)0x00000010),
            VIDEOS = unchecked((int)0x00000020),
            BGSOUNDS = unchecked((int)0x00000040),
            NO_SCRIPTS = unchecked((int)0x00000080),
            NO_JAVA = unchecked((int)0x00000100),
            NO_RUNACTIVEXCTLS = unchecked((int)0x00000200),
            NO_DLACTIVEXCTLS = unchecked((int)0x00000400),
            DOWNLOADONLY = unchecked((int)0x00000800),
            NO_FRAMEDOWNLOAD = unchecked((int)0x00001000),
            RESYNCHRONIZE = unchecked((int)0x00002000),
            PRAGMA_NO_CACHE = unchecked((int)0x00004000),
            NO_BEHAVIORS = unchecked((int)0x00008000),
            NO_METACHARSET = unchecked((int)0x00010000),
            URL_ENCODING_DISABLE_UTF8 = unchecked((int)0x00020000),
            URL_ENCODING_ENABLE_UTF8 = unchecked((int)0x00040000),
            NOFRAMES = unchecked((int)0x00080000),
            FORCEOFFLINE = unchecked((int)0x10000000),
            NO_CLIENTPULL = unchecked((int)0x20000000),
            SILENT = unchecked((int)0x40000000),
            OFFLINEIFNOTCONNECTED = unchecked((int)0x80000000),
            OFFLINE = unchecked((int)0x80000000), //DLCTL_OFFLINEIFNOTCONNECTED

        }

        private bool _dl_image;
        private bool _dl_bgsound;
        private bool _dl_video;
        public bool DL_IMAGE
        {
            get { return _dl_image; }
            set {
                _dl_image = value;
                AllowDocDownlaod(DOCDOWNLOADCTLFLAG.DLIMAGES, _dl_image);
            }
        }
        public bool DL_BGSOUND
        {
            get { return _dl_bgsound; }
            set
            {
                _dl_bgsound = value;
                AllowDocDownlaod(DOCDOWNLOADCTLFLAG.BGSOUNDS, _dl_bgsound);
            }
        }
        public bool DL_VIDEO
        {
            get { return _dl_video; }
            set
            {
                _dl_video = value;
                AllowDocDownlaod(DOCDOWNLOADCTLFLAG.VIDEOS, _dl_video);
            }
        }
        #endregion

        private DOCDOWNLOADCTLFLAG m_DLCtlFlags = 0;
        private AdvWebBrowser_ _webBrowser;
        public AdvWebBrowser()
        {
            InitializeComponent();
            _webBrowser = new AdvWebBrowser_();
            
            _webBrowser.Dock = DockStyle.Fill;
            _webBrowser.ScriptErrorsSuppressed = true;

            DL_IMAGE = !cbDlImage.Checked;
            DL_VIDEO = false;
            DL_BGSOUND = false;
            
            _webBrowser.DownloadControlFlags = (int)m_DLCtlFlags;
            Controls.Add(_webBrowser);
            
        }
        //-----------------------------------------------------------
        public bool ClickATag(string text, bool click_all = false)
        {
            bool flag = false;

            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("a");
            string _text = text.ToLower();
            foreach (HtmlElement e in hc)
            {
                if (e.InnerHtml == null)
                    continue;
                if (e.InnerHtml.ToLower().Contains(_text))
                {
                    flag = true;
                    e.InvokeMember("click");
                    if (!click_all)
                        return true;
                }
            }
            return flag;
        }
        //-----------------------------------------------------------
        public void ClickInputTag(string text, bool click_all = false)
        {

            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            string _text = text.ToLower();
            foreach (HtmlElement e in hc)
            {
                if (e.GetAttribute("value") == null)
                    continue;
                if (e.GetAttribute("value").ToLower().Contains(text))
                {
                    e.InvokeMember("click");
                    if (!click_all)
                        return;
                }
            }
        }
        //-----------------------------------------------------------
        public void ClickCheckBox(string name)
        {
            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            for (int i = 0; i < hc.Count; i++)
            {
                if (hc[i].GetAttribute("name") == name)
                    hc[i].SetAttribute("checked", "checked");
            }
        }
        //-----------------------------------------------------------
        public void EnterInputText(string name, string value, string att = "value")
        {
            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            for (int i = 0; i < hc.Count; i++)
            {
                if (hc[i].GetAttribute("name") == name)
                    hc[i].SetAttribute(att, value);
            }
        }
        //-----------------------------------------------------------
        public void SleepBrowser(int seconds = 2)
        {
            int l = 0;
            int _time = seconds * 1000;
            while (l < _time)
            {
                l++;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public void WaitCompleteLoaded(int seconds = 2)
        {
            int mili = seconds*1000;
            int count = 0;

            while (count <= mili)
            {
                if (!(_webBrowser.ReadyState != WebBrowserReadyState.Complete || _webBrowser.IsBusy))
                    break;
                count++;
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public void WaitCompleteLoadedText(string text_for_wait, int seconds = 2)
        {
            int mili = seconds*1000;
            int count = 0;

            while (true)
            {
                count++;
                System.Threading.Thread.Sleep(1);
                if (count >= mili)
                    break;
                if (_webBrowser.Document == null || _webBrowser.Document.Body == null)
                {
                    SleepBrowser(10);
                    count += 10;
                    continue;
                }
                string html = _webBrowser.Document.Body.InnerText;
                if (html == null)
                {
                    SleepBrowser(10);
                    count += 10;
                    continue;
                }

                if (html.Contains(text_for_wait))
                    break;
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public bool IsContainText(string text)
        {
            string html = GetSource();
            if (html.Contains(text))
                return true;
            return false;
        }
        //-----------------------------------------------------------
        public string GetSource()
        {
            return _webBrowser.Document.Body.InnerHtml;
        }
        //------------------------------------------------------------------
        public void GoTo(string url)
        {
            _webBrowser.Navigate(url);
        }
        //------------------------------------------------------------------
        private void AllowDocDownlaod(DOCDOWNLOADCTLFLAG flag, bool add)
        {
            if (add)
            {
                if ((m_DLCtlFlags & flag) == 0)
                    m_DLCtlFlags |= flag;
            }
            else
            {
                if ((m_DLCtlFlags & flag) != 0)
                    m_DLCtlFlags -= flag;
            }
            _webBrowser.DownloadControlFlags = (int)m_DLCtlFlags;
        }
        //------------------------------------------------------------------
        private void cbDlImage_CheckedChanged(object sender, EventArgs e)
        {
            DL_IMAGE = !cbDlImage.Checked;
        }
        //------------------------------------------------------------------
        #region Proxy function
        
        public void SetProxy(string proxy, string port)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(regKey, true);
            reg.SetValue("ProxyEnable", 1);
            reg.SetValue("ProxyServer", string.Format("{0}:{1}", proxy, port));
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
        public void DisableProxy()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(regKey, true);
            reg.SetValue("ProxyEnable", 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
        #endregion

        private class AdvWebBrowser_ : WebBrowser
        {
            private const int DISPID_AMBIENT_DLCONTROL = -5512;
            private int _downloadControlFlags;

            protected override WebBrowserSiteBase CreateWebBrowserSiteBase()
            {
                return new MyWebBrowserSite(this);
            }

            [DispId(DISPID_AMBIENT_DLCONTROL)]
            public int DownloadControlFlags
            {
                get
                {
                    return _downloadControlFlags;
                }
                set
                {
                    if (_downloadControlFlags == value)
                        return;

                    _downloadControlFlags = value;
                    IOleControl ctl = (IOleControl)ActiveXInstance;
                    ctl.OnAmbientPropertyChange(DISPID_AMBIENT_DLCONTROL);
                }
            }

            protected class MyWebBrowserSite : WebBrowserSite, IReflect
            {
                private Dictionary<int, PropertyInfo> _dispidCache;
                private AdvWebBrowser_ _host;

                public MyWebBrowserSite(AdvWebBrowser_ host)
                    : base(host)
                {
                    _host = host;
                }

                object IReflect.InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
                {
                    object ret = null;
                    // Check direct IDispatch call using a dispid (see http://msdn.microsoft.com/en-us/library/de3dhzwy.aspx)
                    const string dispidToken = "[DISPID=";
                    if (name.StartsWith(dispidToken))
                    {
                        int dispid = int.Parse(name.Substring(dispidToken.Length, name.Length - dispidToken.Length - 1));
                        if (_dispidCache == null)
                        {
                            // WebBrowser has many properties, so we build a dispid cache on it
                            _dispidCache = new Dictionary<int, PropertyInfo>();
                            foreach (PropertyInfo pi in _host.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                            {
                                if ((!pi.CanRead) || (pi.GetIndexParameters().Length > 0))
                                    continue;

                                object[] atts = pi.GetCustomAttributes(typeof(DispIdAttribute), true);
                                if ((atts != null) && (atts.Length > 0))
                                {
                                    DispIdAttribute da = (DispIdAttribute)atts[0];
                                    _dispidCache[da.Value] = pi;
                                }
                            }
                        }

                        PropertyInfo property;
                        if (_dispidCache.TryGetValue(dispid, out property))
                        {
                            ret = property.GetValue(_host, null);
                        }
                    }
                    return ret;
                }

                FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr)
                {
                    return GetType().GetFields(bindingAttr);
                }

                MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr)
                {
                    return GetType().GetMethods(bindingAttr);
                }

                PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr)
                {
                    return GetType().GetProperties(bindingAttr);
                }

                FieldInfo IReflect.GetField(string name, BindingFlags bindingAttr)
                {
                    throw new NotImplementedException();
                }

                MemberInfo[] IReflect.GetMember(string name, BindingFlags bindingAttr)
                {
                    throw new NotImplementedException();
                }

                MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr)
                {
                    throw new NotImplementedException();
                }

                MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr)
                {
                    throw new NotImplementedException();
                }

                MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
                {
                    throw new NotImplementedException();
                }

                PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
                {
                    throw new NotImplementedException();
                }

                PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr)
                {
                    throw new NotImplementedException();
                }

                Type IReflect.UnderlyingSystemType
                {
                    get { throw new NotImplementedException(); }
                }
            }

            [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
            internal interface IOleControl
            {
                void Reserved0();
                void Reserved1();
                void OnAmbientPropertyChange(int dispID);
                void Reserved2();
            }
        }
    }
}
