using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using KTPO4310.Gainutdinov.Lib.src.LogAn;

namespace KTPO4310.Gainutdinov.Lib.src.LogAn
{
    public static class ExtensionManagerFactory
    {
        private static IExtensionManager customManager = null;
        public static IExtensionManager Create()
        {
            if (customManager != null)
            {
                return customManager;
            }
            return new FileExtensionManager();
        }
        ///<summary>Метод позволит тестам контролировать, 
        ///что возвращает фабрика</summary>
        ///<param name="mgr"></param>
        public static void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }
    }
}
