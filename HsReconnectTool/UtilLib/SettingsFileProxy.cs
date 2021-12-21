using System;

namespace UtilLib
{
    public class SettingsFileProxy
    {
        private static SettingsFileProxy defaultInstance = new SettingsFileProxy();
        public event EventHandler PropertyChanged;


        public static SettingsFileProxy Default
        {
            get
            {
                return defaultInstance;
            }
        }
        public SettingsFileProxy()
        {            
            SettingsFile.Default.PropertyChanged += (s, e) => {
                if (PropertyChanged != null) 
                    PropertyChanged.Invoke(s, e);
            };
        }
        public bool FloatingReconnectButtonEnabled
        {
            get
            {
                return SettingsFile.Default.EnableDisconnectButton;
            }
            set
            {
                SettingsFile.Default.EnableDisconnectButton = value;
            }
        }
    }
}
