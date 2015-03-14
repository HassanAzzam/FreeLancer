using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.DAL;
namespace Resturant
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void LoginButt_Click(object sender, EventArgs e)
        {
            var db = new ResturantEntities();
            string userName = LoginUserNameTxt.Text;
            string password = LoginPasswordTxt.Text;
            var user = db.ResEmployeeBasics.Where(u => u.UserName == userName).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("كلمه السر خطأ");
                LoginUserNameTxt.Text = "";
                LoginPasswordTxt.Text = "";
            }
            else
            {
                var addEmployee = new AddEmployee();
                addEmployee.ShowDialog();
                this.Hide();
                this.Close();
            }
        }



    }
}
