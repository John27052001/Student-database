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
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DashGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeBlurb = new System.Windows.Forms.Label();
            this.dahsbord = new System.Windows.Forms.Label();
            this.editInfoPage = new System.Windows.Forms.GroupBox();
            this.toDashboardBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dobTxtBox = new System.Windows.Forms.TextBox();
            this.dobTxt = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.Label();
            this.lnameTxtBox = new System.Windows.Forms.TextBox();
            this.lnameTxt = new System.Windows.Forms.Label();
            this.fnameTxtBox = new System.Windows.Forms.TextBox();
            this.fnameTxt = new System.Windows.Forms.Label();
            this.editInfoTxt = new System.Windows.Forms.Label();
            this.ClassManagePage = new System.Windows.Forms.GroupBox();
            this.ToDashboard = new System.Windows.Forms.Button();
            this.DropClass = new System.Windows.Forms.Button();
            this.AddClass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentlyEnrolledClassesGrid = new System.Windows.Forms.DataGridView();
            this.AvalableClassesGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginPage.SuspendLayout();
            this.Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashGridView)).BeginInit();
            this.editInfoPage.SuspendLayout();
            this.ClassManagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyEnrolledClassesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvalableClassesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPassword
            // 
            this.LoginPassword.AccessibleName = "LoginPassword";
            this.LoginPassword.Location = new System.Drawing.Point(396, 319);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(148, 22);
            this.LoginPassword.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AccessibleName = "LoginUsername";
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(396, 299);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(67, 16);
            this.Label.TabIndex = 1;
            this.Label.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "LoginButton";
            this.LoginButton.Location = new System.Drawing.Point(417, 372);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 28);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // LoginUsername
            // 
            this.LoginUsername.AccessibleName = "LoginUsername";
            this.LoginUsername.Location = new System.Drawing.Point(396, 271);
            this.LoginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(148, 22);
            this.LoginUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AccessibleName = "LoginUsername";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
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
            this.LoginPage.Location = new System.Drawing.Point(16, 638);
            this.LoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(4);
            this.LoginPage.Size = new System.Drawing.Size(979, 622);
            this.LoginPage.TabIndex = 6;
            this.LoginPage.TabStop = false;
            this.LoginPage.Visible = false;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.editInfoBtn);
            this.Dashboard.Controls.Add(this.button1);
            this.Dashboard.Controls.Add(this.DashGridView);
            this.Dashboard.Controls.Add(this.label3);
            this.Dashboard.Controls.Add(this.WelcomeBlurb);
            this.Dashboard.Controls.Add(this.dahsbord);
            this.Dashboard.Location = new System.Drawing.Point(1001, 152);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(4);
            this.Dashboard.Size = new System.Drawing.Size(979, 615);
            this.Dashboard.TabIndex = 7;
            this.Dashboard.TabStop = false;
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.Location = new System.Drawing.Point(176, 569);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(120, 28);
            this.editInfoBtn.TabIndex = 5;
            this.editInfoBtn.Text = "Edit Info";
            this.editInfoBtn.UseVisualStyleBackColor = true;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
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
            this.DashGridView.Location = new System.Drawing.Point(29, 210);
            this.DashGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DashGridView.Name = "DashGridView";
            this.DashGridView.ReadOnly = true;
            this.DashGridView.RowHeadersWidth = 51;
            this.DashGridView.Size = new System.Drawing.Size(917, 350);
            this.DashGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currently Enrolled Classes:";
            // 
            // WelcomeBlurb
            // 
            this.WelcomeBlurb.AutoSize = true;
            this.WelcomeBlurb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBlurb.Location = new System.Drawing.Point(24, 52);
            this.WelcomeBlurb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeBlurb.Name = "WelcomeBlurb";
            this.WelcomeBlurb.Size = new System.Drawing.Size(272, 100);
            this.WelcomeBlurb.TabIndex = 1;
            this.WelcomeBlurb.Text = "Welcome {FNAME} {LNAME}\r\nPhoneNumb: {PhoneNum}\r\nDOB: {DOB}\r\nGender: {Gender} \r\n";
            // 
            // dahsbord
            // 
            this.dahsbord.AutoSize = true;
            this.dahsbord.Location = new System.Drawing.Point(8, 19);
            this.dahsbord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dahsbord.Name = "dahsbord";
            this.dahsbord.Size = new System.Drawing.Size(75, 16);
            this.dahsbord.TabIndex = 0;
            this.dahsbord.Text = "Dashboard";
            // 
            // editInfoPage
            // 
            this.editInfoPage.Controls.Add(this.toDashboardBtn);
            this.editInfoPage.Controls.Add(this.saveBtn);
            this.editInfoPage.Controls.Add(this.dobTxtBox);
            this.editInfoPage.Controls.Add(this.dobTxt);
            this.editInfoPage.Controls.Add(this.phoneTxtBox);
            this.editInfoPage.Controls.Add(this.phoneTxt);
            this.editInfoPage.Controls.Add(this.lnameTxtBox);
            this.editInfoPage.Controls.Add(this.lnameTxt);
            this.editInfoPage.Controls.Add(this.fnameTxtBox);
            this.editInfoPage.Controls.Add(this.fnameTxt);
            this.editInfoPage.Controls.Add(this.editInfoTxt);
            this.editInfoPage.Location = new System.Drawing.Point(16, 22);
            this.editInfoPage.Name = "editInfoPage";
            this.editInfoPage.Size = new System.Drawing.Size(977, 605);
            this.editInfoPage.TabIndex = 8;
            this.editInfoPage.TabStop = false;
            this.editInfoPage.Text = "Edit Info";
            // 
            // toDashboardBtn
            // 
            this.toDashboardBtn.Location = new System.Drawing.Point(201, 314);
            this.toDashboardBtn.Name = "toDashboardBtn";
            this.toDashboardBtn.Size = new System.Drawing.Size(121, 30);
            this.toDashboardBtn.TabIndex = 11;
            this.toDashboardBtn.Text = "To Dashboard";
            this.toDashboardBtn.UseVisualStyleBackColor = true;
            this.toDashboardBtn.Click += new System.EventHandler(this.toDashboardBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(59, 314);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 30);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dobTxtBox
            // 
            this.dobTxtBox.Location = new System.Drawing.Point(187, 254);
            this.dobTxtBox.Name = "dobTxtBox";
            this.dobTxtBox.Size = new System.Drawing.Size(180, 22);
            this.dobTxtBox.TabIndex = 8;
            // 
            // dobTxt
            // 
            this.dobTxt.AutoSize = true;
            this.dobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTxt.Location = new System.Drawing.Point(59, 256);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(52, 20);
            this.dobTxt.TabIndex = 7;
            this.dobTxt.Text = "DOB:";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(187, 202);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(180, 22);
            this.phoneTxtBox.TabIndex = 6;
            // 
            // phoneTxt
            // 
            this.phoneTxt.AutoSize = true;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(59, 204);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(61, 20);
            this.phoneTxt.TabIndex = 5;
            this.phoneTxt.Text = "Phone:";
            // 
            // lnameTxtBox
            // 
            this.lnameTxtBox.Location = new System.Drawing.Point(187, 149);
            this.lnameTxtBox.Name = "lnameTxtBox";
            this.lnameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.lnameTxtBox.TabIndex = 4;
            // 
            // lnameTxt
            // 
            this.lnameTxt.AutoSize = true;
            this.lnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.Location = new System.Drawing.Point(59, 148);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(96, 20);
            this.lnameTxt.TabIndex = 3;
            this.lnameTxt.Text = "Last Name:";
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.Location = new System.Drawing.Point(187, 94);
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.fnameTxtBox.TabIndex = 2;
            // 
            // fnameTxt
            // 
            this.fnameTxt.AutoSize = true;
            this.fnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.Location = new System.Drawing.Point(59, 94);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(97, 20);
            this.fnameTxt.TabIndex = 1;
            this.fnameTxt.Text = "First Name:";
            // 
            // editInfoTxt
            // 
            this.editInfoTxt.AutoSize = true;
            this.editInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoTxt.Location = new System.Drawing.Point(54, 40);
            this.editInfoTxt.Name = "editInfoTxt";
            this.editInfoTxt.Size = new System.Drawing.Size(268, 29);
            this.editInfoTxt.TabIndex = 0;
            this.editInfoTxt.Text = "Edit Student Information";
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
            this.ClassManagePage.Location = new System.Drawing.Point(16, 15);
            this.ClassManagePage.Margin = new System.Windows.Forms.Padding(4);
            this.ClassManagePage.Name = "ClassManagePage";
            this.ClassManagePage.Padding = new System.Windows.Forms.Padding(4);
            this.ClassManagePage.Size = new System.Drawing.Size(977, 612);
            this.ClassManagePage.TabIndex = 8;
            this.ClassManagePage.TabStop = false;
            // 
            // ToDashboard
            // 
            this.ToDashboard.Location = new System.Drawing.Point(13, 576);
            this.ToDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.ToDashboard.Name = "ToDashboard";
            this.ToDashboard.Size = new System.Drawing.Size(136, 28);
            this.ToDashboard.TabIndex = 7;
            this.ToDashboard.Text = "To Dashboard";
            this.ToDashboard.UseVisualStyleBackColor = true;
            this.ToDashboard.Click += new System.EventHandler(this.ToDashboard_Click);
            // 
            // DropClass
            // 
            this.DropClass.Enabled = false;
            this.DropClass.Location = new System.Drawing.Point(13, 533);
            this.DropClass.Margin = new System.Windows.Forms.Padding(4);
            this.DropClass.Name = "DropClass";
            this.DropClass.Size = new System.Drawing.Size(100, 28);
            this.DropClass.TabIndex = 6;
            this.DropClass.Text = "DropClass";
            this.DropClass.UseVisualStyleBackColor = true;
            this.DropClass.Click += new System.EventHandler(this.DropClass_Click);
            // 
            // AddClass
            // 
            this.AddClass.Enabled = false;
            this.AddClass.Location = new System.Drawing.Point(13, 263);
            this.AddClass.Margin = new System.Windows.Forms.Padding(4);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(100, 28);
            this.AddClass.TabIndex = 5;
            this.AddClass.Text = "Add Class";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Currently enrolled classes";
            // 
            // CurrentlyEnrolledClassesGrid
            // 
            this.CurrentlyEnrolledClassesGrid.AllowUserToAddRows = false;
            this.CurrentlyEnrolledClassesGrid.AllowUserToDeleteRows = false;
            this.CurrentlyEnrolledClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentlyEnrolledClassesGrid.Location = new System.Drawing.Point(13, 341);
            this.CurrentlyEnrolledClassesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentlyEnrolledClassesGrid.Name = "CurrentlyEnrolledClassesGrid";
            this.CurrentlyEnrolledClassesGrid.ReadOnly = true;
            this.CurrentlyEnrolledClassesGrid.RowHeadersWidth = 51;
            this.CurrentlyEnrolledClassesGrid.Size = new System.Drawing.Size(940, 185);
            this.CurrentlyEnrolledClassesGrid.TabIndex = 3;
            this.CurrentlyEnrolledClassesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentlyEnrolledClassesGrid_CellClick);
            // 
            // AvalableClassesGrid
            // 
            this.AvalableClassesGrid.AllowUserToAddRows = false;
            this.AvalableClassesGrid.AllowUserToDeleteRows = false;
            this.AvalableClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvalableClassesGrid.Location = new System.Drawing.Point(13, 70);
            this.AvalableClassesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AvalableClassesGrid.Name = "AvalableClassesGrid";
            this.AvalableClassesGrid.ReadOnly = true;
            this.AvalableClassesGrid.RowHeadersWidth = 51;
            this.AvalableClassesGrid.Size = new System.Drawing.Size(940, 185);
            this.AvalableClassesGrid.TabIndex = 2;
            this.AvalableClassesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvalableClassesGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Avalable Classes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Classes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 651);
            this.Controls.Add(this.editInfoPage);
            this.Controls.Add(this.ClassManagePage);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashGridView)).EndInit();
            this.editInfoPage.ResumeLayout(false);
            this.editInfoPage.PerformLayout();
            this.ClassManagePage.ResumeLayout(false);
            this.ClassManagePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyEnrolledClassesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvalableClassesGrid)).EndInit();
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
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.GroupBox editInfoPage;
        private System.Windows.Forms.Label editInfoTxt;
        private System.Windows.Forms.TextBox fnameTxtBox;
        private System.Windows.Forms.Label fnameTxt;
        private System.Windows.Forms.Label lnameTxt;
        private System.Windows.Forms.TextBox lnameTxtBox;
        private System.Windows.Forms.Label phoneTxt;
        private System.Windows.Forms.Label dobTxt;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox dobTxtBox;
        private System.Windows.Forms.Button toDashboardBtn;
    }
}

