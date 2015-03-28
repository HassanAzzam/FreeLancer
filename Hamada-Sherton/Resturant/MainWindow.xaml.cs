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
using System.Collections.Generic;
using Resturant.DAL;
namespace Resturant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CustomButton> SubCategory;
        List<CustomButton> CategoryButtons;
        string Quantity;
        float Total;
        CustomButton SelectedCat, SelectedSubCat;
        public MainWindow()
        {
            InitializeComponent();

            #region NumPad Buttons

            for (int i = 0; i < 10; i++)
            {
                CustomButton QB = new CustomButton() { 
                Name = "QuantityBtn",
                Width=60,
                Height=60,
                Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(5, 5, 0, 0),
                Text=(i+1).ToString()[((i+1).ToString()).Length - 1].ToString(),
                };
                NumPad.Children.Add(QB);
                QB.MouseDown += QB_MouseDown;
            }
            CustomButton QR = new CustomButton()
            {
                Name = "QuantityResetBtn",
                Width = 125,
                Height = 60,
                Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(5, 5, 0, 0),
                Text = "مسح",
            };
            NumPad.Children.Add(QR);
            QR.MouseDown += QuantityReset;
            #endregion

            #region Action Buttons

            for (int i = 0; i < 3; i++)
            {
                CustomButton ActionBtn = new CustomButton()
                {
                    Name = "ActionBtn",
                    Width = 168,
                    Height = 60,
                    Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Margin = new Thickness(0, 5, 0, 0),
                };
                if (i == 0) { ActionBtn.Text = "دفع"; ActionBtn.Background = (Brush)new BrushConverter().ConvertFrom("#FF027421"); } if (i == 1) { ActionBtn.Text = "دليفري"; ActionBtn.Background = (Brush)new BrushConverter().ConvertFrom("#FFDEA200"); } if (i == 2) { ActionBtn.Text = "إلغاء"; ActionBtn.Background = (Brush)new BrushConverter().ConvertFrom("#FFA00000"); }
                Actions.Children.Add(ActionBtn);
                ActionBtn.MouseDown += Action_MouseDown;
            }

            #endregion

            #region Exit Button

            CustomButton ExitBtn = new CustomButton()
            {
                Name = "ExitBtn",
                Width = 150,
                Height = 60,
                TextShiftUp = 3,
                Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 15, 0, 0),
                Text="خروج",
            };
            Ext.Children.Add(ExitBtn);
            ExitBtn.MouseDown += ExitBtn_MouseDown;

            #endregion


            Quantity = "";
            Total = 0;
            SubCategory = new List<CustomButton>();
            CategoryButtons = new List<CustomButton>();
            var db = new res_for_sheratonEntities();
            var list = db.ResMainCategoryCodes.ToList();
            foreach (var item in list)
            {

                CategoryButtons.Add(new CustomButton()
                {
                    Name = "Catbtn",
                    Text = item.MainCategoryNameA,
                    Width = CategoryMenu.Height,
                    Height = CategoryMenu.Height - 10,
                    VerticalAlignment = VerticalAlignment.Bottom,
                    Margin = new Thickness(0,0 , 0, 0),
                    FontSize= 20,
                    Background = (Brush)new BrushConverter().ConvertFrom("#FFA6A6A6"),
                    HighlightedBackground = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                    HighlightedForeground = Brushes.White,
                });
                CategoryButtons[CategoryButtons.Count - 1].MouseDown += new MouseButtonEventHandler(CatBtnClick);
                CategoryMenu.Children.Add(CategoryButtons[CategoryButtons.Count - 1]);

            }
            var list1 = db.ResSubCategoryCodes.ToList();
            foreach (var item in list1)
            {
                SubCategory.Add(new CustomButton()
                {
                    Name = "Btn",
                    Text = item.SubCategoryNameA,
                    Width = 110,
                    Height = 110,
                    FontSize = 14,
                    TextShiftUp = 6,
                    Margin = new Thickness(5, 5, 0, 0),
                    Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                });
                SubMenu.Children.Add(SubCategory[SubCategory.Count - 1]);
                SubCategory[SubCategory.Count - 1].MouseDown += new MouseButtonEventHandler(SubCatBtnClick);
            }

        }

        void ExitBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        void QB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CustomButton tmp = sender as CustomButton;
            if(Quantity!=""||tmp.Text!="0")Quantity += tmp.Text;
        }
        
        void CatBtnClick(object sender, MouseEventArgs e)
        {
            var db = new res_for_sheratonEntities();
            if (SelectedCat != null) { SelectedCat.UnHighlight(); SelectedCat.Height -= 10; }
            SelectedCat = (CustomButton)sender;
            SelectedCat.Highlight(); SelectedCat.Height += 10;
            var id = db.ResMainCategoryCodes.Where(it => it.MainCategoryNameA == SelectedCat.Text).Select(it => it.MainCategoryId).FirstOrDefault();
            SubCategory.Clear();
            SubMenu.Children.Clear();
            var list = db.ResSubCategoryCodes.Where(i => i.MainCategoryId == id).ToList();
            foreach (var item in list)
            {
                SubCategory.Add(new CustomButton(){
                    Name = "Btn",
                    Text = item.SubCategoryNameA,
                    Width = 110,
                    Height = 110,
                    FontSize = 14,
                    TextShiftUp = 6,
                    Margin = new Thickness(5, 5, 0, 0),
                    Background = (Brush)new BrushConverter().ConvertFrom("#FF0051BB"),
                });
                SubMenu.Children.Add(SubCategory[SubCategory.Count - 1]);
                SubCategory[SubCategory.Count - 1].MouseDown += new MouseButtonEventHandler(SubCatBtnClick);
            } 
           
        }

        void SubCatBtnClick(object sender, RoutedEventArgs e)
        {
            if (Quantity == "") Quantity = "1";
            CustomButton tmp = sender as CustomButton;
            BillView.Children.Add(new Label() { Content=tmp.Text,HorizontalContentAlignment=HorizontalAlignment.Left,VerticalContentAlignment=VerticalAlignment.Center, Foreground=tmp.Background, FontSize = 16, FontWeight = FontWeights.Medium, Width=235, Height =40, });
            BillView.Children.Add(new Label() { Content = Quantity.ToString(), HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, Foreground = tmp.Background, FontSize = 16, FontWeight = FontWeights.Medium, Width = 95, Height = 40, });
            int cost= int.Parse(Quantity)*2;
            BillView.Children.Add(new Label() { Content = cost.ToString(), HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, Foreground = tmp.Background, FontSize = 16, FontWeight = FontWeights.Medium, Width = 111, Height = 40, });
            Quantity = "";
            Total += cost;
            TotalPay.Content = Total.ToString();
        }

        private void QuantityReset(object sender, MouseButtonEventArgs e)
        {
            Quantity = "";
        }

        private void Action_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var tmp = (CustomButton)sender;
            if (tmp.Text == "دفع") ;
            if (tmp.Text == "دليفري") ;
            if (tmp.Text == "إلغاء") ;
        }



    }
}
