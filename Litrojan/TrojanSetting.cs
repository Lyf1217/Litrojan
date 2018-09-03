using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Litrojan
{
    internal class TrojanSetting : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _LaunchWithSys = false;
        private bool _MinimizeToTray = true;
        private bool _AutoRestartTrojan = true;
        private bool _EnableLogSave = true;
        private bool _DarkUITheme = false;

        public bool LaunchWithSys { get { return this._LaunchWithSys; } set { if (value != this._LaunchWithSys) { this._LaunchWithSys = value; NotifyPropertyChanged(); } } }
        public bool MinimizeToTray { get { return this._MinimizeToTray; } set { if (value != this._MinimizeToTray) { this._MinimizeToTray = value; NotifyPropertyChanged(); } } }
        public bool AutoRestartTrojan { get { return this._AutoRestartTrojan; } set { if (value != this._AutoRestartTrojan) { this._AutoRestartTrojan = value; NotifyPropertyChanged(); } } }
        public bool EnableLogSave { get { return this._EnableLogSave; } set { if (value != this._EnableLogSave) { this._EnableLogSave = value; NotifyPropertyChanged(); } } }
        public bool DarkUITheme { get { return this._DarkUITheme; } set { if (value != this._DarkUITheme) { this._DarkUITheme = value; NotifyPropertyChanged(); } } }
    }
}
