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
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    /// 

    public partial class NewCustomer : Window
    {
        int PhoneNums;
        public NewCustomer()
        {
            InitializeComponent();
            PhoneNums = 1;
        }

        private void NewOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //
            //      adding new row in customer table.
            //
            //
        }

        private void PlusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Height += 60;
            this.Gr.Height += 60;
            TranslateTransform tt = new TranslateTransform(0,  PhoneNums*60);
            Gr2.RenderTransform = tt;
            var tb = new TextBox() { VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(0, 120 + (PhoneNums * 60), 111, 0), Text = "", Width = 534, Height = 24, FontWeight = FontWeights.Medium, FontSize = 16, };
            Gr.Children.Add(tb);
            Label L = new Label() { VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Right, Margin = new Thickness(0, 115+(PhoneNums*60), -360, 0), Width = 534, Height = 35, FontWeight = FontWeights.Medium, FontSize = 16, };
            Gr.Children.Add(L);
           
            PhoneNums++;
            L.Content = ": " + PhoneNums.ToString() + "رقـم الهـاتـف";
            
            
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            NewCustBtn.Fill = (Brush)new BrushConverter().ConvertFrom("#FF0072E6");
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            NewCustBtn.Fill = (Brush)new BrushConverter().ConvertFrom("#FF2893FF");
        }

    }
}
