using System.Windows;
using System.Windows.Controls;

namespace BoostLife.Views;

/// <summary>
/// Interação lógica para ViciosView.xam
/// </summary>
public partial class ViciosView : UserControl
{
    public ViciosView()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        popCadastro.IsOpen = false;
    }
}
