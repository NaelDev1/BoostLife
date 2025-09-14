using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace BoostLife.CustomControls;

/// <summary>
/// Interação lógica para CreditCardBox.xam
/// </summary>
public partial class CreditCardBox : UserControl
{
    public CreditCardBox()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    static readonly DependencyProperty TitleProperty =
       DependencyProperty.Register(nameof(Title), typeof(string), typeof(CreditCardBox),
           new PropertyMetadata("Will Back"));

    public int Amount
    {
        get => (int)GetValue(AmountProperty);
        set => SetValue(AmountProperty, value);
    }

    static readonly DependencyProperty AmountProperty =
       DependencyProperty.Register(nameof(Amount), typeof(int), typeof(CreditCardBox),
           new PropertyMetadata(125055));



    public string CloseDay
    {
        get => (string)GetValue(CloseDayProperty);
        set => SetValue(CloseDayProperty, value);
    }

    static readonly DependencyProperty CloseDayProperty =
       DependencyProperty.Register(nameof(CloseDay), typeof(string), typeof(CreditCardBox));


    public System.Windows.Media.Color PrimaryColor
    {
        get => (System.Windows.Media.Color)GetValue(PrimaryColorProperty);
        set => SetValue(PrimaryColorProperty, value);
    }

    static readonly DependencyProperty PrimaryColorProperty =
      DependencyProperty.Register(nameof(PrimaryColor), typeof(System.Windows.Media.Color), typeof(CreditCardBox),

          new PropertyMetadata(System.Windows.Media.Color.FromArgb(ColorTranslator.FromHtml("#FEDA00").A, ColorTranslator.FromHtml("#FEDA00").R, ColorTranslator.FromHtml("#FEDA00").G, ColorTranslator.FromHtml("#FEDA00").B)));
    //("#FEDA00")

    public System.Windows.Media.Color SecondaryColor
    {
        get => (System.Windows.Media.Color)GetValue(SecondaryColorProperty);
        set => SetValue(SecondaryColorProperty, value);
    }

    static readonly DependencyProperty SecondaryColorProperty =
      DependencyProperty.Register(nameof(SecondaryColor), typeof(System.Windows.Media.Color), typeof(CreditCardBox),
         new PropertyMetadata(System.Windows.Media.Color.FromArgb( ColorTranslator.FromHtml("#FEDA00").A, ColorTranslator.FromHtml("#FEDA00").R, ColorTranslator.FromHtml("#FEDA00").G, ColorTranslator.FromHtml("#FEDA00").B)));
    //"#FEDA00"
}
