using System;

namespace OOPDemo
{
    class NOKIALUMIA:MobilePhone, IWIFI
    {
        #region Explicite Implementation
        //string IWIFI.StartWIFI()
        //{
        //    return "Startting WIFI Service";
        //}
        //string IWIFI.ConnectWIFI()
        //{
        //    return "Connecting Devices";
        //}
        //string IWIFI.StopWIFI()
        //{
        //    return "Stopping WIFI Service";
        //}
        #endregion

        #region Implicit Implementation
         public string StartWIFI()
        {
            return "Starting WIFI Service";
        }
        public string ConnectWIFI()
        {
            return "Connecting Devices";
        }
        public string StopWIFI()
        {
            return "Stopping WIFI Service";
        }
        #endregion
        public string PushMessage()
        {
            return "PushMessage() from NOKIALUMIA";
        }

    }
}
