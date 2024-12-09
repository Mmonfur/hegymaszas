using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace zh2_2023_A
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private Mountain _selectedMountain;
        public ObservableCollection<Mountain> Mountains { get; set; }

        public ICommand ClearClimbedStatusCommand { get; }

        public Mountain SelectedMountain
        {
            get => _selectedMountain;
            set
            {
                if (_selectedMountain != value)
                {
                    _selectedMountain = value;
                    OnPropertyChanged(nameof(SelectedMountain)); // Notification for UI
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();

            // Initialize mountains list
            Mountains = new ObservableCollection<Mountain>
            {
                new Mountain { Name = "János-hegy", Height = 527, HasClimbed = false},
                new Mountain { Name = "Kis-Hárs-hegy", Height = 362, HasClimbed = false },
                new Mountain { Name = "Nagy-Hárs-hegy", Height = 454, HasClimbed = false },
                new Mountain { Name = "Hármashatár-hegy", Height = 495, HasClimbed = false }
            };

            // Command initialization
            ClearClimbedStatusCommand = new ClearClimbedStatusCommand(Mountains);

            // Set BindingContext
            BindingContext = this;
        }

        // Handle mountain selection
        private void OnMountainSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Mountain selectedMountain)
            {
                SelectedMountain = selectedMountain; // Set the selected mountain
                SelectedMountain.HasClimbed = false; // Reset climbing status by default
            }
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
