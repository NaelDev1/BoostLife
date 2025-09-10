using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoostLife.CustomControls
{
    /// <summary>
    /// Interação lógica para RegenerateControl.xam
    /// </summary>
    public partial class RegenerateControl : UserControl
    {
        public RegenerateControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        static readonly DependencyProperty TitleProperty =
           DependencyProperty.Register(nameof(Title), typeof(string), typeof(RegenerateControl), new PropertyMetadata("Titulo"));

        public string Date
        {
            get => (string)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        static readonly DependencyProperty DateProperty =
           DependencyProperty.Register(nameof(Date), typeof(string), typeof(RegenerateControl), new PropertyMetadata("10d 11m 47s"));

        public int Progress
        {
            get => (int)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }

        static readonly DependencyProperty ProgressProperty =
           DependencyProperty.Register(nameof(Progress), typeof(int), typeof(RegenerateControl), new PropertyMetadata(0));
    }
}
