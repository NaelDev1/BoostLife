using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BoostLife.ViewModels;

internal partial class VicioVM : ObservableObject
{

    [ObservableProperty]
    private bool _cadOpen = true;

    [RelayCommand]
    private void OnCloseCadastro()
    {
        CadOpen = false;
    }

    [RelayCommand]
    private void OnOpenCadastro()
    {
        CadOpen = true;
    }

}
