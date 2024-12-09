using System.ComponentModel;

namespace zh2_2023_A
{//<!--  Title="Hegymászás" -->
    public class Mountain : INotifyPropertyChanged
    {
        private string? _name;
        private int _height;
        private bool _hasClimbed;

        public string? Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }

        public bool HasClimbed
        {
            get => _hasClimbed;
            set
            {
                if (_hasClimbed != value)
                {
                    _hasClimbed = value;
                    OnPropertyChanged(nameof(HasClimbed));
                }
            }
        }

        // INotifyPropertyChanged event
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
