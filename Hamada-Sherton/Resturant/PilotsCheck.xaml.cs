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

namespace Resturant
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PilotsCheck : UserControl
    {
         CustomButton selected,Check;
        const int dash = 60;
        int BtnNum;
        double TotalDeliveryPay;
        AdminWindow AdW;
        public PilotsCheck(AdminWindow AdW)
        {
            this.AdW = AdW;
            InitializeComponent();
            Check = new CustomButton() { Text = "تصفية الحساب :   2.00    ",/* TextAlignment = TextAlignment.Left,*/ Width = 290, Height = 60, Margin = new Thickness(ss7_2.Margin.Left-233, 0, 0, 0), Background = (Brush)new BrushConverter().ConvertFrom("#FF008D2D"), Foreground = Brushes.White, TextShiftUp = -5, };
            Check.Hide();
            selected = null;
            BtnNum = 0;
            TotalDeliveryPay = 0;
            Check.MouseDown += Check_MouseDown;
            Gr.Children.Add(Check);

            CustomButton btn = new CustomButton() { Text = "أحمد محسن",TextAlignment = TextAlignment.Right, Width = Gr2.Width, Height = dash, Background = Brushes.White, Foreground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedBackground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedForeground = Brushes.White, };
            Gr2.Children.Add(btn);
            BtnNum++;
            btn.MouseDown += btn_MouseDown;
            btn = new CustomButton() { Text = "حسن عزام", TextAlignment = TextAlignment.Right, Width = Gr2.Width, Height = dash,  Background = Brushes.White, Foreground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedBackground = (Brush)new BrushConverter().ConvertFrom("#FF0367BB"), HighlightedForeground = Brushes.White, };
            Gr2.Children.Add(btn);
            btn.MouseDown += btn_MouseDown;
            BtnNum++;
        }

        void btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (selected != null) selected.UnHighlight();
            var s = sender as CustomButton;
            selected = s;
            s.Highlight();
            //
            //
            //
            Check.Show();
            ss7_1.Visibility = Visibility.Visible;
            ss7_2.Visibility = Visibility.Visible;
            circ.Visibility = Visibility.Hidden;
            s7_1.Visibility = Visibility.Hidden;
            s7_2.Visibility = Visibility.Hidden;
        }

        void Check_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Check.Hide();
            ss7_1.Visibility = Visibility.Hidden;
            ss7_2.Visibility = Visibility.Hidden;
            circ.Visibility = Visibility.Visible;
            s7_1.Visibility = Visibility.Visible;
            s7_2.Visibility = Visibility.Visible;
            TotalDeliveryPay+=2;
            tx_Copy.Text = TotalDeliveryPay.ToString();
            Gr2.Children.Remove(selected);
            selected.Hide();
            selected = null;
            AdW.PilotsNot.Text = (int.Parse(AdW.PilotsNot.Text)-1).ToString();
            if (AdW.PilotsNot.Text == "0") { AdW.PilotsNot.Visibility = Visibility.Hidden; AdW.NotBackground.Visibility = Visibility.Hidden; }
        }
    }
}
