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
using System.Windows.Shapes;

namespace Resturant
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        CustomButton SelectedOption;
        public AdminWindow()
        {
            InitializeComponent();
            SelectedOption = null;
            CustomButton btn = new CustomButton() { Text = "حسابات الدليفري",TextSize=18, TextShiftUp=-2, TextAlignment = TextAlignment.Right, Width = Options.Width, Height = 60, Background = Brushes.White, Foreground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedBackground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedForeground = Brushes.White, };
            Options.Children.Add(btn);
            btn.MouseDown += btn_MouseDown;
        }
        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (SelectedOption != null) SelectedOption.UnHighlight();
            SelectedOption = (CustomButton)sender;
            SelectedOption.Highlight();
            Gr2.Children.Add(new PilotsCheck(this));

        }
    }
}
