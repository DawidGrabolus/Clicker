using Clicker.ViewModels;
namespace Clicker;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();

    }
}
