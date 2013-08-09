using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace GEXVOC.Core.Registro
{
    public static class Registro
    {
        static public string GetSetting(string key)
        {
            return GetSetting(Application.ProductName, key, "");
        }
        static public string GetSetting(string key,string sDefault)
        {
            return GetSetting(Application.ProductName, key, sDefault);
        }
        static public string GetSetting(string appName, string key, string sDefault)
        {

            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"Software\Coremain\" +
                                                              appName);
            string s = string.Empty;
            if (rk != null)
                s = (string)rk.GetValue(key);

            if (!string.IsNullOrEmpty(sDefault) && string.IsNullOrEmpty(s))            
                s = sDefault;
            
            return s;
        }

        static public void SaveSetting(string key, string value)
        {
            SaveSetting(Application.ProductName,key,value);
        }
        static public void SaveSetting(string appName, string key, string value)
        {           
            RegistryKey rk = Registry.LocalMachine.CreateSubKey(@"Software\Coremain\" +
                                                                appName);
            rk.SetValue(key, value);
        }
    }
}
