using BoostLife.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace BoostLife.ViewModels;

internal partial class MainVM : ObservableObject
{
    [ObservableProperty]
    private UserControl _currentView = new ViciosView();

    [RelayCommand]
    private void IrParaTela(TipoTela tela)
    {
        switch (tela)
        {
            case TipoTela.PROJETOS:
                    if (CurrentView.Name != "TelaProjetos")
                    CurrentView = new ProjetosView();
                break;
            case TipoTela.CONTAS:
                    if (CurrentView.Name != "TelaContas")
                CurrentView = new ContasView();
                break;
            case TipoTela.VICIOS:
                    if (CurrentView.Name != "TelaVicios")
                CurrentView = new ViciosView();
                break;
        }

    }

}

enum TipoTela
{
    PROJETOS,
    CONTAS,
    VICIOS
}
