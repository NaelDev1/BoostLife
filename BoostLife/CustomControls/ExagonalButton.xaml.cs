using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BoostLife.CustomControls;

/// <summary>
/// Interação lógica para ExagonalButton.xam
/// </summary>
public partial class ExagonalButton : UserControl
{
    public ExagonalButton()
    {
        InitializeComponent();
    }

    public ICommand ClickCommand
    {
        get => (ICommand)GetValue(ClickCommandProperty);
        set => SetValue(ClickCommandProperty, value);
    }

    static readonly DependencyProperty ClickCommandProperty =
       DependencyProperty.Register(nameof(ClickCommand), typeof(ICommand), typeof(ExagonalButton));
}
