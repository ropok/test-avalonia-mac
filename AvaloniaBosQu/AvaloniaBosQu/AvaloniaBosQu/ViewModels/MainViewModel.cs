using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaBosQu.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _greeting = "Halo Mas Yuda, sehat-sehat terus di Jakarta!";
    }
}
