namespace WindowsFormsApp1
{
    partial class Form1
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
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPage = new System.Windows.Forms.GroupBox();
            this.Dashboard = new System.Windows.Forms.GroupBox();
            this.dahsbord = new System.Windows.Forms.Label();
            this.WelcomeBlurb = new System.Windows.Forms.Label();
            this.LoginPage.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPassword
            // 
            this.LoginPassword.AccessibleName = "LoginPassword";
            this.LoginPassword.Location = new System.Drawing.Point(297, 259);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(112, 20);
            this.LoginPassword.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AccessibleName = "LoginUsername";
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(297, 243);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(53, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "LoginButton";
            this.LoginButton.Location = new System.Drawing.Point(313, 302);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // LoginUsername
            // 
            this.LoginUsername.AccessibleName = "LoginUsername";
            this.LoginUsername.Location = new System.Drawing.Point(297, 220);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(112, 20);
            this.LoginUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AccessibleName = "LoginUsername";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // LoginPage
            // 
            this.LoginPage.AccessibleName = "LoginPage";
            this.LoginPage.Controls.Add(this.label2);
            this.LoginPage.Controls.Add(this.LoginPassword);
            this.LoginPage.Controls.Add(this.Label);
            this.LoginPage.Controls.Add(this.LoginUsername);
            this.LoginPage.Controls.Add(this.LoginButton);
            this.LoginPage.Location = new System.Drawing.Point(12, 518);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(734, 505);
            this.LoginPage.TabIndex = 6;
            this.LoginPage.TabStop = false;
            this.LoginPage.Visible = false;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.WelcomeBlurb);
            this.Dashboard.Controls.Add(this.dahsbord);
            this.Dashboard.Location = new System.Drawing.Point(12, 12);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(734, 500);
            this.Dashboard.TabIndex = 7;
            this.Dashboard.TabStop = false;
            // 
            // dahsbord
            // 
            this.dahsbord.AutoSize = true;
            this.dahsbord.Location = new System.Drawing.Point(6, 16);
            this.dahsbord.Name = "dahsbord";
            this.dahsbord.Size = new System.Drawing.Size(59, 13);
            this.dahsbord.TabIndex = 0;
            this.dahsbord.Text = "Dashboard";
            // 
            // WelcomeBlurb
            // 
            this.WelcomeBlurb.AutoSize = true;
            this.WelcomeBlurb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBlurb.Location = new System.Drawing.Point(18, 40);
            this.WelcomeBlurb.Name = "WelcomeBlurb";
            this.WelcomeBlurb.Size = new System.Drawing.Size(214, 80);
            this.WelcomeBlurb.TabIndex = 1;
            this.WelcomeBlurb.Text = "Welcome {FNAME} {LNAME}\r\nPhoneNumb: {PhoneNum}\r\nDOB: {DOB}\r\nGender: {Gender} \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 529);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LoginPage;
        private System.Windows.Forms.GroupBox Dashboard;
        private System.Windows.Forms.Label dahsbord;
        private System.Windows.Forms.Label WelcomeBlurb;
    }
}

