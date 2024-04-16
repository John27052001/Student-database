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
            this.button1 = new System.Windows.Forms.Button();
            this.DashGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeBlurb = new System.Windows.Forms.Label();
            this.dahsbord = new System.Windows.Forms.Label();
            this.ClassManagePage = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvalableClassesGrid = new System.Windows.Forms.DataGridView();
            this.CurrentlyEnrolledClassesGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.AddClass = new System.Windows.Forms.Button();
            this.DropClass = new System.Windows.Forms.Button();
            this.ToDashboard = new System.Windows.Forms.Button();
            this.LoginPage.SuspendLayout();
            this.Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashGridView)).BeginInit();
            this.ClassManagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvalableClassesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyEnrolledClassesGrid)).BeginInit();
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
            this.Dashboard.Controls.Add(this.button1);
            this.Dashboard.Controls.Add(this.DashGridView);
            this.Dashboard.Controls.Add(this.label3);
            this.Dashboard.Controls.Add(this.WelcomeBlurb);
            this.Dashboard.Controls.Add(this.dahsbord);
            this.Dashboard.Location = new System.Drawing.Point(733, 12);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(734, 500);
            this.Dashboard.TabIndex = 7;
            this.Dashboard.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Manage Classes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashGridView
            // 
            this.DashGridView.AllowUserToAddRows = false;
            this.DashGridView.AllowUserToDeleteRows = false;
            this.DashGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DashGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DashGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashGridView.Location = new System.Drawing.Point(22, 171);
            this.DashGridView.Name = "DashGridView";
            this.DashGridView.ReadOnly = true;
            this.DashGridView.Size = new System.Drawing.Size(688, 284);
            this.DashGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currently Enrolled Classes:";
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
            // dahsbord
            // 
            this.dahsbord.AutoSize = true;
            this.dahsbord.Location = new System.Drawing.Point(6, 16);
            this.dahsbord.Name = "dahsbord";
            this.dahsbord.Size = new System.Drawing.Size(59, 13);
            this.dahsbord.TabIndex = 0;
            this.dahsbord.Text = "Dashboard";
            // 
            // ClassManagePage
            // 
            this.ClassManagePage.Controls.Add(this.ToDashboard);
            this.ClassManagePage.Controls.Add(this.DropClass);
            this.ClassManagePage.Controls.Add(this.AddClass);
            this.ClassManagePage.Controls.Add(this.label6);
            this.ClassManagePage.Controls.Add(this.CurrentlyEnrolledClassesGrid);
            this.ClassManagePage.Controls.Add(this.AvalableClassesGrid);
            this.ClassManagePage.Controls.Add(this.label5);
            this.ClassManagePage.Controls.Add(this.label4);
            this.ClassManagePage.Location = new System.Drawing.Point(12, 12);
            this.ClassManagePage.Name = "ClassManagePage";
            this.ClassManagePage.Size = new System.Drawing.Size(733, 497);
            this.ClassManagePage.TabIndex = 8;
            this.ClassManagePage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Classes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Avalable Classes";
            // 
            // AvalableClassesGrid
            // 
            this.AvalableClassesGrid.AllowUserToAddRows = false;
            this.AvalableClassesGrid.AllowUserToDeleteRows = false;
            this.AvalableClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvalableClassesGrid.Location = new System.Drawing.Point(10, 57);
            this.AvalableClassesGrid.Name = "AvalableClassesGrid";
            this.AvalableClassesGrid.ReadOnly = true;
            this.AvalableClassesGrid.Size = new System.Drawing.Size(705, 150);
            this.AvalableClassesGrid.TabIndex = 2;
            // 
            // CurrentlyEnrolledClassesGrid
            // 
            this.CurrentlyEnrolledClassesGrid.AllowUserToAddRows = false;
            this.CurrentlyEnrolledClassesGrid.AllowUserToDeleteRows = false;
            this.CurrentlyEnrolledClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentlyEnrolledClassesGrid.Location = new System.Drawing.Point(10, 277);
            this.CurrentlyEnrolledClassesGrid.Name = "CurrentlyEnrolledClassesGrid";
            this.CurrentlyEnrolledClassesGrid.ReadOnly = true;
            this.CurrentlyEnrolledClassesGrid.Size = new System.Drawing.Size(705, 150);
            this.CurrentlyEnrolledClassesGrid.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Currently enrolled classes";
            // 
            // AddClass
            // 
            this.AddClass.Location = new System.Drawing.Point(10, 214);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(75, 23);
            this.AddClass.TabIndex = 5;
            this.AddClass.Text = "Add Class";
            this.AddClass.UseVisualStyleBackColor = true;
            // 
            // DropClass
            // 
            this.DropClass.Location = new System.Drawing.Point(10, 433);
            this.DropClass.Name = "DropClass";
            this.DropClass.Size = new System.Drawing.Size(75, 23);
            this.DropClass.TabIndex = 6;
            this.DropClass.Text = "DropClass";
            this.DropClass.UseVisualStyleBackColor = true;
            // 
            // ToDashboard
            // 
            this.ToDashboard.Location = new System.Drawing.Point(10, 468);
            this.ToDashboard.Name = "ToDashboard";
            this.ToDashboard.Size = new System.Drawing.Size(102, 23);
            this.ToDashboard.TabIndex = 7;
            this.ToDashboard.Text = "To Dashboard";
            this.ToDashboard.UseVisualStyleBackColor = true;
            this.ToDashboard.Click += new System.EventHandler(this.ToDashboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 529);
            this.Controls.Add(this.ClassManagePage);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashGridView)).EndInit();
            this.ClassManagePage.ResumeLayout(false);
            this.ClassManagePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvalableClassesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyEnrolledClassesGrid)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DashGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ClassManagePage;
        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CurrentlyEnrolledClassesGrid;
        private System.Windows.Forms.DataGridView AvalableClassesGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ToDashboard;
        private System.Windows.Forms.Button DropClass;
    }
}

