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
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        Thickness Thick;
        Brush Bkup_BG, Bkup_FG, Bkup_HB, Bkup_HF;
        double H = 16;
        public CustomButton(){
            InitializeComponent();
            rec.Width = Gr.Width;
            rec.Height = Gr.Height;
            rec.Margin = Gr.Margin;
            Thick = new Thickness(rec.Width / 10, (rec.Height / 2) - H, 0, 0);
            H = tx.FontSize -4;
            tx.Width = 8 * rec.Width / 10;
            tx.Height = (rec.Height / 2) + H;
            tx.Margin = Thick;
            Bkup_HB = (Brush)new BrushConverter().ConvertFrom("#FF0367BB");
            Bkup_HF = Brushes.White;
           
        }

        public string Text { get { return tx.Text; } set { tx.Text = value; } }
        public double Width { get { return rec.Width; } set { rec.Width = Gr.Width = value;  tx.Width = 8 * rec.Width / 10; Thick.Left = rec.Width/ 10; tx.Margin = Thick; } }
        public double Height { get { return rec.Height; } set { rec.Height = Gr.Height = value; tx.Height = (rec.Height / 2) + H; Thick.Top = (rec.Height / 2) - H; tx.Margin = Thick; } }
        public Brush Background { get { return rec.Fill; } set { rec.Fill = value; } }
        public Brush HighlightedBackground { get { return Bkup_HB; } set { Bkup_HB = value; } }
        public Brush HighlightedForeground { get { return Bkup_HF; } set { Bkup_HF = value; } }
        public Brush Foreground { get { return tx.Foreground; } set { tx.Foreground = value; } }
        public Thickness Margin { get { return rec.Margin; } set { rec.Margin = Gr.Margin= value; value.Left += tx.Margin.Left; value.Right += tx.Margin.Right; value.Bottom += tx.Margin.Bottom; value.Top += tx.Margin.Top; tx.Margin = value; } }
        public double TextSize { get { return tx.FontSize; } set { tx.FontSize =H= value; } }
        public TextAlignment TextAlignment { get { return tx.TextAlignment; } set { tx.TextAlignment = value; } }
        public double TextShiftUp { get { return H - tx.FontSize; } set { H = tx.FontSize + value; tx.Height = (rec.Height / 2) + H; Thick.Top = (rec.Height / 2) - H; tx.Margin = Thick; } }
        public string Name { get { return rec.Name; } set { rec.Name = value; } }

        public void Highlight()
        {
            Bkup_BG = this.Background; Bkup_FG = this.Foreground; Bkup_HB = this.HighlightedBackground; Bkup_HF = this.HighlightedForeground;
            this.Background = this.HighlightedBackground;
            this.Foreground = this.HighlightedForeground;
        }
        public void UnHighlight()
        {
            this.Background = this.Bkup_BG;
            this.Foreground = this.Bkup_FG;
        }
        public void Hide(){
            rec.Visibility = Visibility.Hidden;
            tx.Visibility = Visibility.Hidden;
        }
        public void Show()
        {
            rec.Visibility = Visibility.Visible;
            tx.Visibility = Visibility.Visible;
        }
    }
}
