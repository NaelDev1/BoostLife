using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BoostLife.CustomControls;

/// <summary>
/// Interação lógica para NavBarButton.xam
/// </summary>
public partial class NavBarButton : UserControl
{
    public NavBarButton()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(nameof(Title), typeof(string), typeof(NavBarButton), new PropertyMetadata("Title"));


    public PackIconBootstrapIconsKind Icon
    {
        get => (PackIconBootstrapIconsKind)GetValue(IconProperty);
        set => SetValue(IconProperty, value);

    }

    static readonly DependencyProperty IconProperty =
       DependencyProperty.Register(nameof(Icon), typeof(PackIconBootstrapIconsKind), typeof(NavBarButton), new PropertyMetadata(PackIconBootstrapIconsKind.CurrencyDollar));


    public ICommand ClickCommand
    {
        get => (ICommand)GetValue(ClickCommandProperty);
        set => SetValue(ClickCommandProperty, value);
    }

    static readonly DependencyProperty ClickCommandProperty =
       DependencyProperty.Register(nameof(ClickCommand), typeof(ICommand), typeof(NavBarButton));


}
