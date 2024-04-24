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
            this.Logout = new System.Windows.Forms.Button();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DashGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeBlurb = new System.Windows.Forms.Label();
            this.dahsbord = new System.Windows.Forms.Label();
            this.editInfoPage = new System.Windows.Forms.GroupBox();
            this.saveChangePassBtn = new System.Windows.Forms.Button();
            this.newPassTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.oldPassTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changePasswordTxt = new System.Windows.Forms.Label();
            this.genComboBox = new System.Windows.Forms.ComboBox();
            this.genderTxt = new System.Windows.Forms.Label();
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
            this.LoginPage.Location = new System.Drawing.Point(12, 12);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(734, 505);
            this.LoginPage.TabIndex = 6;
            this.LoginPage.TabStop = false;
            this.LoginPage.Visible = false;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.Logout);
            this.Dashboard.Controls.Add(this.editInfoBtn);
            this.Dashboard.Controls.Add(this.button1);
            this.Dashboard.Controls.Add(this.DashGridView);
            this.Dashboard.Controls.Add(this.label3);
            this.Dashboard.Controls.Add(this.WelcomeBlurb);
            this.Dashboard.Controls.Add(this.dahsbord);
            this.Dashboard.Location = new System.Drawing.Point(752, 545);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(734, 500);
            this.Dashboard.TabIndex = 7;
            this.Dashboard.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(612, 461);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(105, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.Location = new System.Drawing.Point(132, 462);
            this.editInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(90, 23);
            this.editInfoBtn.TabIndex = 5;
            this.editInfoBtn.Text = "Edit Info";
            this.editInfoBtn.UseVisualStyleBackColor = true;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
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
            this.DashGridView.RowHeadersWidth = 51;
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
            this.WelcomeBlurb.Location = new System.Drawing.Point(18, 42);
            this.WelcomeBlurb.Name = "WelcomeBlurb";
            this.WelcomeBlurb.Size = new System.Drawing.Size(214, 80);
            this.WelcomeBlurb.TabIndex = 1;
            this.WelcomeBlurb.Text = "Welcome {FNAME} {LNAME}\r\nPhoneNumb: {PhoneNum}\r\nDOB: {DOB}\r\nGender: {Gender} \r\n";
            // 
            // dahsbord
            // 
            this.dahsbord.AutoSize = true;
            this.dahsbord.Location = new System.Drawing.Point(6, 15);
            this.dahsbord.Name = "dahsbord";
            this.dahsbord.Size = new System.Drawing.Size(59, 13);
            this.dahsbord.TabIndex = 0;
            this.dahsbord.Text = "Dashboard";
            // 
            // editInfoPage
            // 
            this.editInfoPage.Controls.Add(this.saveChangePassBtn);
            this.editInfoPage.Controls.Add(this.newPassTxtBox);
            this.editInfoPage.Controls.Add(this.label8);
            this.editInfoPage.Controls.Add(this.oldPassTxtBox);
            this.editInfoPage.Controls.Add(this.label7);
            this.editInfoPage.Controls.Add(this.changePasswordTxt);
            this.editInfoPage.Controls.Add(this.genComboBox);
            this.editInfoPage.Controls.Add(this.genderTxt);
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
            this.editInfoPage.Location = new System.Drawing.Point(774, 30);
            this.editInfoPage.Margin = new System.Windows.Forms.Padding(2);
            this.editInfoPage.Name = "editInfoPage";
            this.editInfoPage.Padding = new System.Windows.Forms.Padding(2);
            this.editInfoPage.Size = new System.Drawing.Size(733, 492);
            this.editInfoPage.TabIndex = 8;
            this.editInfoPage.TabStop = false;
            // 
            // saveChangePassBtn
            // 
            this.saveChangePassBtn.Location = new System.Drawing.Point(398, 208);
            this.saveChangePassBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangePassBtn.Name = "saveChangePassBtn";
            this.saveChangePassBtn.Size = new System.Drawing.Size(61, 22);
            this.saveChangePassBtn.TabIndex = 19;
            this.saveChangePassBtn.Text = "Save";
            this.saveChangePassBtn.UseVisualStyleBackColor = true;
            this.saveChangePassBtn.Click += new System.EventHandler(this.saveChangePassBtn_Click);
            // 
            // newPassTxtBox
            // 
            this.newPassTxtBox.Location = new System.Drawing.Point(511, 164);
            this.newPassTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPassTxtBox.Name = "newPassTxtBox";
            this.newPassTxtBox.PasswordChar = '*';
            this.newPassTxtBox.Size = new System.Drawing.Size(117, 20);
            this.newPassTxtBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "New Password:";
            // 
            // oldPassTxtBox
            // 
            this.oldPassTxtBox.Location = new System.Drawing.Point(511, 127);
            this.oldPassTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldPassTxtBox.Name = "oldPassTxtBox";
            this.oldPassTxtBox.Size = new System.Drawing.Size(117, 20);
            this.oldPassTxtBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Old Password:";
            // 
            // changePasswordTxt
            // 
            this.changePasswordTxt.AutoSize = true;
            this.changePasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTxt.Location = new System.Drawing.Point(394, 76);
            this.changePasswordTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changePasswordTxt.Name = "changePasswordTxt";
            this.changePasswordTxt.Size = new System.Drawing.Size(138, 20);
            this.changePasswordTxt.TabIndex = 14;
            this.changePasswordTxt.Text = "Change Password";
            // 
            // genComboBox
            // 
            this.genComboBox.AllowDrop = true;
            this.genComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genComboBox.FormattingEnabled = true;
            this.genComboBox.Location = new System.Drawing.Point(140, 249);
            this.genComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genComboBox.Name = "genComboBox";
            this.genComboBox.Size = new System.Drawing.Size(136, 21);
            this.genComboBox.TabIndex = 13;
            // 
            // genderTxt
            // 
            this.genderTxt.AutoSize = true;
            this.genderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxt.Location = new System.Drawing.Point(44, 249);
            this.genderTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(60, 17);
            this.genderTxt.TabIndex = 12;
            this.genderTxt.Text = "Gender:";
            // 
            // toDashboardBtn
            // 
            this.toDashboardBtn.Location = new System.Drawing.Point(151, 296);
            this.toDashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toDashboardBtn.Name = "toDashboardBtn";
            this.toDashboardBtn.Size = new System.Drawing.Size(91, 24);
            this.toDashboardBtn.TabIndex = 11;
            this.toDashboardBtn.Text = "To Dashboard";
            this.toDashboardBtn.UseVisualStyleBackColor = true;
            this.toDashboardBtn.Click += new System.EventHandler(this.toDashboardBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(44, 296);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 24);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dobTxtBox
            // 
            this.dobTxtBox.Location = new System.Drawing.Point(140, 206);
            this.dobTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.dobTxtBox.Name = "dobTxtBox";
            this.dobTxtBox.Size = new System.Drawing.Size(136, 20);
            this.dobTxtBox.TabIndex = 8;
            // 
            // dobTxt
            // 
            this.dobTxt.AutoSize = true;
            this.dobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTxt.Location = new System.Drawing.Point(44, 208);
            this.dobTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(42, 17);
            this.dobTxt.TabIndex = 7;
            this.dobTxt.Text = "DOB:";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(140, 164);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(136, 20);
            this.phoneTxtBox.TabIndex = 6;
            // 
            // phoneTxt
            // 
            this.phoneTxt.AutoSize = true;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(44, 166);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(53, 17);
            this.phoneTxt.TabIndex = 5;
            this.phoneTxt.Text = "Phone:";
            // 
            // lnameTxtBox
            // 
            this.lnameTxtBox.Location = new System.Drawing.Point(140, 121);
            this.lnameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameTxtBox.Name = "lnameTxtBox";
            this.lnameTxtBox.Size = new System.Drawing.Size(136, 20);
            this.lnameTxtBox.TabIndex = 4;
            // 
            // lnameTxt
            // 
            this.lnameTxt.AutoSize = true;
            this.lnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.Location = new System.Drawing.Point(44, 120);
            this.lnameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(80, 17);
            this.lnameTxt.TabIndex = 3;
            this.lnameTxt.Text = "Last Name:";
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.Location = new System.Drawing.Point(140, 76);
            this.fnameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.Size = new System.Drawing.Size(136, 20);
            this.fnameTxtBox.TabIndex = 2;
            // 
            // fnameTxt
            // 
            this.fnameTxt.AutoSize = true;
            this.fnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.Location = new System.Drawing.Point(44, 76);
            this.fnameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(80, 17);
            this.fnameTxt.TabIndex = 1;
            this.fnameTxt.Text = "First Name:";
            // 
            // editInfoTxt
            // 
            this.editInfoTxt.AutoSize = true;
            this.editInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoTxt.Location = new System.Drawing.Point(40, 32);
            this.editInfoTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editInfoTxt.Name = "editInfoTxt";
            this.editInfoTxt.Size = new System.Drawing.Size(208, 24);
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
            this.ClassManagePage.Location = new System.Drawing.Point(13, 545);
            this.ClassManagePage.Name = "ClassManagePage";
            this.ClassManagePage.Size = new System.Drawing.Size(733, 497);
            this.ClassManagePage.TabIndex = 8;
            this.ClassManagePage.TabStop = false;
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
            // DropClass
            // 
            this.DropClass.Enabled = false;
            this.DropClass.Location = new System.Drawing.Point(10, 433);
            this.DropClass.Name = "DropClass";
            this.DropClass.Size = new System.Drawing.Size(75, 23);
            this.DropClass.TabIndex = 6;
            this.DropClass.Text = "DropClass";
            this.DropClass.UseVisualStyleBackColor = true;
            this.DropClass.Click += new System.EventHandler(this.DropClass_Click);
            // 
            // AddClass
            // 
            this.AddClass.Enabled = false;
            this.AddClass.Location = new System.Drawing.Point(10, 214);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(75, 23);
            this.AddClass.TabIndex = 5;
            this.AddClass.Text = "Add Class";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
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
            // CurrentlyEnrolledClassesGrid
            // 
            this.CurrentlyEnrolledClassesGrid.AllowUserToAddRows = false;
            this.CurrentlyEnrolledClassesGrid.AllowUserToDeleteRows = false;
            this.CurrentlyEnrolledClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentlyEnrolledClassesGrid.Location = new System.Drawing.Point(10, 277);
            this.CurrentlyEnrolledClassesGrid.Name = "CurrentlyEnrolledClassesGrid";
            this.CurrentlyEnrolledClassesGrid.ReadOnly = true;
            this.CurrentlyEnrolledClassesGrid.RowHeadersWidth = 51;
            this.CurrentlyEnrolledClassesGrid.Size = new System.Drawing.Size(705, 150);
            this.CurrentlyEnrolledClassesGrid.TabIndex = 3;
            this.CurrentlyEnrolledClassesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentlyEnrolledClassesGrid_CellClick);
            // 
            // AvalableClassesGrid
            // 
            this.AvalableClassesGrid.AllowUserToAddRows = false;
            this.AvalableClassesGrid.AllowUserToDeleteRows = false;
            this.AvalableClassesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvalableClassesGrid.Location = new System.Drawing.Point(10, 57);
            this.AvalableClassesGrid.Name = "AvalableClassesGrid";
            this.AvalableClassesGrid.ReadOnly = true;
            this.AvalableClassesGrid.RowHeadersWidth = 51;
            this.AvalableClassesGrid.Size = new System.Drawing.Size(705, 150);
            this.AvalableClassesGrid.TabIndex = 2;
            this.AvalableClassesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvalableClassesGrid_CellClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Classes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 528);
            this.Controls.Add(this.editInfoPage);
            this.Controls.Add(this.ClassManagePage);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StudentDatabase";
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
        private System.Windows.Forms.ComboBox genComboBox;
        private System.Windows.Forms.Label genderTxt;
        private System.Windows.Forms.TextBox newPassTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oldPassTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label changePasswordTxt;
        private System.Windows.Forms.Button saveChangePassBtn;
        private System.Windows.Forms.Button Logout;
    }
}

