using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Clicker.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int points;
        public int Points
        {
            get => points;
            set
            {
                if (points != value)
                {
                    points = value;
                    OnPropertyChanged(nameof(Points));
                }
            }
        }

        public ICommand IncreasePointsCommand { get; }
        public ICommand DecreasePointsCommand { get; }

        public MainViewModel()
        {
            IncreasePointsCommand = new Command(IncreasePoints);
            DecreasePointsCommand = new Command(DecreasePoints);
            Points = 0;
        }

        private void IncreasePoints()
        {
            Points++;
        }

        private void DecreasePoints()
        {
            if (Points > 0)
            {
                Points--;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
