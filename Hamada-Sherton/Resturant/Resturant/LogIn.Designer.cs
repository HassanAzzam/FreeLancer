namespace Resturant
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoginPasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginLanguageList = new System.Windows.Forms.ComboBox();
            this.LoginUserNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // LoginButt
            // 
            resources.ApplyResources(this.LoginButt, "LoginButt");
            this.LoginButt.Name = "LoginButt";
            this.LoginButt.UseVisualStyleBackColor = true;
            this.LoginButt.Click += new System.EventHandler(this.LoginButt_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoginPasswordTxt
            // 
            resources.ApplyResources(this.LoginPasswordTxt, "LoginPasswordTxt");
            this.LoginPasswordTxt.Name = "LoginPasswordTxt";
            // 
            // LoginLanguageList
            // 
            this.LoginLanguageList.FormattingEnabled = true;
            this.LoginLanguageList.Items.AddRange(new object[] {
            resources.GetString("LoginLanguageList.Items"),
            resources.GetString("LoginLanguageList.Items1")});
            resources.ApplyResources(this.LoginLanguageList, "LoginLanguageList");
            this.LoginLanguageList.Name = "LoginLanguageList";
            // 
            // LoginUserNameTxt
            // 
            resources.ApplyResources(this.LoginUserNameTxt, "LoginUserNameTxt");
            this.LoginUserNameTxt.Name = "LoginUserNameTxt";
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoginUserNameTxt);
            this.Controls.Add(this.LoginLanguageList);
            this.Controls.Add(this.LoginPasswordTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LoginButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LoginPasswordTxt;
        private System.Windows.Forms.ComboBox LoginLanguageList;
        private System.Windows.Forms.TextBox LoginUserNameTxt;
    }
}

