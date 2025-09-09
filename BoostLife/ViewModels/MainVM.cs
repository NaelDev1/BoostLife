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
private void IrParaProjetos()
{
CurrentView = new Projetos();
}

}
