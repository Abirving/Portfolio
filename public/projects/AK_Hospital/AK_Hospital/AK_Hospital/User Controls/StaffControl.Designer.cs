namespace AK_Hospital.User_Controls
{
    partial class StaffControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.error4 = new Guna.UI.WinForms.GunaPictureBox();
            this.error3 = new Guna.UI.WinForms.GunaPictureBox();
            this.error2 = new Guna.UI.WinForms.GunaPictureBox();
            this.error1 = new Guna.UI.WinForms.GunaPictureBox();
            this.clear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.deleteStaff = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addStaff = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updateStaff = new Guna.UI.WinForms.GunaAdvenceButton();
            this.surgeon = new Guna.UI.WinForms.GunaRadioButton();
            this.admin = new Guna.UI.WinForms.GunaRadioButton();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.pass = new Guna.UI.WinForms.GunaTextBox();
            this.firstname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lastname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.staffId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.errorDisplay = new System.Windows.Forms.Timer(this.components);
            this.nurse = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.confirm = new Guna.UI.WinForms.GunaTextBox();
            this.error5 = new Guna.UI.WinForms.GunaPictureBox();
            this.error6 = new Guna.UI.WinForms.GunaPictureBox();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.allRecord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.admins = new Guna.UI.WinForms.GunaAdvenceButton();
            this.surgeons = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nurses = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // error4
            // 
            this.error4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error4.BaseColor = System.Drawing.Color.White;
            this.error4.Image = ((System.Drawing.Image)(resources.GetObject("error4.Image")));
            this.error4.Location = new System.Drawing.Point(1628, 295);
            this.error4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(27, 25);
            this.error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error4.TabIndex = 42;
            this.error4.TabStop = false;
            this.error4.Visible = false;
            // 
            // error3
            // 
            this.error3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error3.BaseColor = System.Drawing.Color.White;
            this.error3.Image = ((System.Drawing.Image)(resources.GetObject("error3.Image")));
            this.error3.Location = new System.Drawing.Point(1628, 247);
            this.error3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(27, 25);
            this.error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error3.TabIndex = 41;
            this.error3.TabStop = false;
            this.error3.Visible = false;
            // 
            // error2
            // 
            this.error2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error2.BaseColor = System.Drawing.Color.White;
            this.error2.Image = ((System.Drawing.Image)(resources.GetObject("error2.Image")));
            this.error2.Location = new System.Drawing.Point(1628, 201);
            this.error2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(27, 25);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error2.TabIndex = 40;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // error1
            // 
            this.error1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error1.BaseColor = System.Drawing.Color.White;
            this.error1.Image = ((System.Drawing.Image)(resources.GetObject("error1.Image")));
            this.error1.Location = new System.Drawing.Point(1628, 153);
            this.error1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(27, 25);
            this.error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error1.TabIndex = 39;
            this.error1.TabStop = false;
            this.error1.Visible = false;
            this.error1.Click += new System.EventHandler(this.error1_Click);
            // 
            // clear
            // 
            this.clear.Animated = true;
            this.clear.AnimationHoverSpeed = 0.07F;
            this.clear.AnimationSpeed = 0.03F;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.clear.BorderColor = System.Drawing.Color.Black;
            this.clear.BorderSize = 1;
            this.clear.CheckedBaseColor = System.Drawing.Color.Gray;
            this.clear.CheckedBorderColor = System.Drawing.Color.Black;
            this.clear.CheckedForeColor = System.Drawing.Color.White;
            this.clear.CheckedImage = null;
            this.clear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear.FocusedColor = System.Drawing.Color.Empty;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Image = null;
            this.clear.ImageSize = new System.Drawing.Size(20, 20);
            this.clear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clear.Location = new System.Drawing.Point(1001, 640);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear.OnHoverForeColor = System.Drawing.Color.White;
            this.clear.OnHoverImage = null;
            this.clear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Radius = 10;
            this.clear.Size = new System.Drawing.Size(595, 52);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // deleteStaff
            // 
            this.deleteStaff.Animated = true;
            this.deleteStaff.AnimationHoverSpeed = 0.07F;
            this.deleteStaff.AnimationSpeed = 0.03F;
            this.deleteStaff.BackColor = System.Drawing.Color.Transparent;
            this.deleteStaff.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.deleteStaff.BorderColor = System.Drawing.Color.Black;
            this.deleteStaff.BorderSize = 1;
            this.deleteStaff.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteStaff.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteStaff.CheckedForeColor = System.Drawing.Color.White;
            this.deleteStaff.CheckedImage = null;
            this.deleteStaff.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteStaff.FocusedColor = System.Drawing.Color.Empty;
            this.deleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStaff.ForeColor = System.Drawing.Color.Black;
            this.deleteStaff.Image = null;
            this.deleteStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteStaff.Location = new System.Drawing.Point(1327, 581);
            this.deleteStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteStaff.Name = "deleteStaff";
            this.deleteStaff.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.deleteStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteStaff.OnHoverImage = null;
            this.deleteStaff.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteStaff.OnPressedColor = System.Drawing.Color.Black;
            this.deleteStaff.Radius = 10;
            this.deleteStaff.Size = new System.Drawing.Size(269, 52);
            this.deleteStaff.TabIndex = 12;
            this.deleteStaff.Text = "Delete Staff";
            this.deleteStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteStaff.Click += new System.EventHandler(this.deleteStaff_Click);
            // 
            // addStaff
            // 
            this.addStaff.Animated = true;
            this.addStaff.AnimationHoverSpeed = 0.07F;
            this.addStaff.AnimationSpeed = 0.03F;
            this.addStaff.BackColor = System.Drawing.Color.Transparent;
            this.addStaff.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.addStaff.BorderColor = System.Drawing.Color.Black;
            this.addStaff.BorderSize = 1;
            this.addStaff.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addStaff.CheckedBorderColor = System.Drawing.Color.Black;
            this.addStaff.CheckedForeColor = System.Drawing.Color.White;
            this.addStaff.CheckedImage = null;
            this.addStaff.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addStaff.FocusedColor = System.Drawing.Color.Empty;
            this.addStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff.ForeColor = System.Drawing.Color.Black;
            this.addStaff.Image = null;
            this.addStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.addStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addStaff.Location = new System.Drawing.Point(1001, 522);
            this.addStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff.Name = "addStaff";
            this.addStaff.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.addStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.addStaff.OnHoverImage = null;
            this.addStaff.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addStaff.OnPressedColor = System.Drawing.Color.Black;
            this.addStaff.Radius = 10;
            this.addStaff.Size = new System.Drawing.Size(595, 52);
            this.addStaff.TabIndex = 10;
            this.addStaff.Text = "Add Staff";
            this.addStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addStaff.Click += new System.EventHandler(this.addStaff_Click);
            // 
            // updateStaff
            // 
            this.updateStaff.Animated = true;
            this.updateStaff.AnimationHoverSpeed = 0.07F;
            this.updateStaff.AnimationSpeed = 0.03F;
            this.updateStaff.BackColor = System.Drawing.Color.Transparent;
            this.updateStaff.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.updateStaff.BorderColor = System.Drawing.Color.Black;
            this.updateStaff.BorderSize = 1;
            this.updateStaff.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateStaff.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateStaff.CheckedForeColor = System.Drawing.Color.White;
            this.updateStaff.CheckedImage = null;
            this.updateStaff.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateStaff.FocusedColor = System.Drawing.Color.Empty;
            this.updateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaff.ForeColor = System.Drawing.Color.Black;
            this.updateStaff.Image = null;
            this.updateStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.updateStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateStaff.Location = new System.Drawing.Point(1001, 581);
            this.updateStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateStaff.Name = "updateStaff";
            this.updateStaff.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.updateStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.updateStaff.OnHoverImage = null;
            this.updateStaff.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateStaff.OnPressedColor = System.Drawing.Color.Black;
            this.updateStaff.Radius = 10;
            this.updateStaff.Size = new System.Drawing.Size(269, 52);
            this.updateStaff.TabIndex = 11;
            this.updateStaff.Text = "Update Staff";
            this.updateStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateStaff.Click += new System.EventHandler(this.updateStaff_Click);
            // 
            // surgeon
            // 
            this.surgeon.BaseColor = System.Drawing.Color.White;
            this.surgeon.CheckedOffColor = System.Drawing.Color.Black;
            this.surgeon.CheckedOnColor = System.Drawing.Color.Black;
            this.surgeon.FillColor = System.Drawing.Color.Lime;
            this.surgeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgeon.Location = new System.Drawing.Point(1327, 441);
            this.surgeon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgeon.Name = "surgeon";
            this.surgeon.Size = new System.Drawing.Size(105, 26);
            this.surgeon.TabIndex = 8;
            this.surgeon.Text = "Surgeon";
            // 
            // admin
            // 
            this.admin.BaseColor = System.Drawing.Color.White;
            this.admin.CheckedOffColor = System.Drawing.Color.Black;
            this.admin.CheckedOnColor = System.Drawing.Color.Black;
            this.admin.FillColor = System.Drawing.Color.Red;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(1187, 441);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(87, 26);
            this.admin.TabIndex = 7;
            this.admin.Text = "Admin";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.LightCyan;
            this.username.BorderColor = System.Drawing.Color.Black;
            this.username.BorderSize = 1;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(1187, 289);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 10;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(409, 41);
            this.username.TabIndex = 4;
            this.username.TextOffsetX = 10;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(995, 441);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(51, 25);
            this.gunaLabel8.TabIndex = 25;
            this.gunaLabel8.Text = "Role";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(995, 295);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Username";
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.BaseColor = System.Drawing.Color.LightCyan;
            this.pass.BorderColor = System.Drawing.Color.Black;
            this.pass.BorderSize = 1;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.FocusedBaseColor = System.Drawing.Color.White;
            this.pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(1187, 337);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.Radius = 10;
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(409, 41);
            this.pass.TabIndex = 5;
            this.pass.TextOffsetX = 10;
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.BaseColor = System.Drawing.Color.LightCyan;
            this.firstname.BorderColor = System.Drawing.Color.Black;
            this.firstname.BorderSize = 1;
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.FocusedBaseColor = System.Drawing.Color.White;
            this.firstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.firstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(1187, 194);
            this.firstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.Radius = 10;
            this.firstname.SelectedText = "";
            this.firstname.Size = new System.Drawing.Size(409, 41);
            this.firstname.TabIndex = 2;
            this.firstname.TextOffsetX = 10;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(995, 343);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel7.TabIndex = 24;
            this.gunaLabel7.Text = "Password";
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.BaseColor = System.Drawing.Color.LightCyan;
            this.lastname.BorderColor = System.Drawing.Color.Black;
            this.lastname.BorderSize = 1;
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.FocusedBaseColor = System.Drawing.Color.White;
            this.lastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(1187, 241);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.Radius = 10;
            this.lastname.SelectedText = "";
            this.lastname.Size = new System.Drawing.Size(409, 41);
            this.lastname.TabIndex = 3;
            this.lastname.TextOffsetX = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(995, 201);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(106, 25);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "First Name";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(995, 247);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(106, 25);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Last Name";
            // 
            // staffId
            // 
            this.staffId.BackColor = System.Drawing.Color.Transparent;
            this.staffId.BaseColor = System.Drawing.Color.LightCyan;
            this.staffId.BorderColor = System.Drawing.Color.Black;
            this.staffId.BorderSize = 1;
            this.staffId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffId.FocusedBaseColor = System.Drawing.Color.White;
            this.staffId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staffId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.staffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffId.Location = new System.Drawing.Point(1187, 146);
            this.staffId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffId.Name = "staffId";
            this.staffId.PasswordChar = '\0';
            this.staffId.Radius = 10;
            this.staffId.SelectedText = "";
            this.staffId.Size = new System.Drawing.Size(409, 41);
            this.staffId.TabIndex = 1;
            this.staffId.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(995, 153);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 25);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Staff ID";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1279, 34);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(71, 31);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Staff";
            // 
            // errorDisplay
            // 
            this.errorDisplay.Interval = 1000;
            this.errorDisplay.Tick += new System.EventHandler(this.errorDisplay_Tick);
            // 
            // nurse
            // 
            this.nurse.BaseColor = System.Drawing.Color.White;
            this.nurse.CheckedOffColor = System.Drawing.Color.Black;
            this.nurse.CheckedOnColor = System.Drawing.Color.Black;
            this.nurse.FillColor = System.Drawing.Color.Lime;
            this.nurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurse.Location = new System.Drawing.Point(1496, 441);
            this.nurse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nurse.Name = "nurse";
            this.nurse.Size = new System.Drawing.Size(84, 26);
            this.nurse.TabIndex = 9;
            this.nurse.Text = "Nurse";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(995, 391);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel6.TabIndex = 24;
            this.gunaLabel6.Text = "Confirm Pass";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.BaseColor = System.Drawing.Color.LightCyan;
            this.confirm.BorderColor = System.Drawing.Color.Black;
            this.confirm.BorderSize = 1;
            this.confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm.FocusedBaseColor = System.Drawing.Color.White;
            this.confirm.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirm.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(1187, 385);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '\0';
            this.confirm.Radius = 10;
            this.confirm.SelectedText = "";
            this.confirm.Size = new System.Drawing.Size(409, 41);
            this.confirm.TabIndex = 6;
            this.confirm.TextOffsetX = 10;
            // 
            // error5
            // 
            this.error5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error5.BaseColor = System.Drawing.Color.White;
            this.error5.Image = ((System.Drawing.Image)(resources.GetObject("error5.Image")));
            this.error5.Location = new System.Drawing.Point(1628, 343);
            this.error5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(27, 25);
            this.error5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error5.TabIndex = 42;
            this.error5.TabStop = false;
            this.error5.Visible = false;
            // 
            // error6
            // 
            this.error6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error6.BaseColor = System.Drawing.Color.White;
            this.error6.Image = ((System.Drawing.Image)(resources.GetObject("error6.Image")));
            this.error6.Location = new System.Drawing.Point(1628, 391);
            this.error6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error6.Name = "error6";
            this.error6.Size = new System.Drawing.Size(27, 25);
            this.error6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error6.TabIndex = 42;
            this.error6.TabStop = false;
            this.error6.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeight = 34;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv.Location = new System.Drawing.Point(21, 17);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(920, 640);
            this.dgv.TabIndex = 43;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // allRecord
            // 
            this.allRecord.Animated = true;
            this.allRecord.AnimationHoverSpeed = 0.07F;
            this.allRecord.AnimationSpeed = 0.03F;
            this.allRecord.BackColor = System.Drawing.Color.Transparent;
            this.allRecord.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.allRecord.BorderColor = System.Drawing.Color.Black;
            this.allRecord.BorderSize = 1;
            this.allRecord.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.allRecord.Checked = true;
            this.allRecord.CheckedBaseColor = System.Drawing.Color.Teal;
            this.allRecord.CheckedBorderColor = System.Drawing.Color.Black;
            this.allRecord.CheckedForeColor = System.Drawing.Color.White;
            this.allRecord.CheckedImage = null;
            this.allRecord.CheckedLineColor = System.Drawing.Color.DimGray;
            this.allRecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allRecord.FocusedColor = System.Drawing.Color.Empty;
            this.allRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRecord.ForeColor = System.Drawing.Color.Black;
            this.allRecord.Image = null;
            this.allRecord.ImageSize = new System.Drawing.Size(20, 20);
            this.allRecord.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.allRecord.Location = new System.Drawing.Point(21, 684);
            this.allRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allRecord.Name = "allRecord";
            this.allRecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.allRecord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.allRecord.OnHoverForeColor = System.Drawing.Color.White;
            this.allRecord.OnHoverImage = null;
            this.allRecord.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.allRecord.OnPressedColor = System.Drawing.Color.Black;
            this.allRecord.Size = new System.Drawing.Size(203, 46);
            this.allRecord.TabIndex = 44;
            this.allRecord.Text = "All Records";
            this.allRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admins
            // 
            this.admins.Animated = true;
            this.admins.AnimationHoverSpeed = 0.07F;
            this.admins.AnimationSpeed = 0.03F;
            this.admins.BackColor = System.Drawing.Color.Transparent;
            this.admins.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.admins.BorderColor = System.Drawing.Color.Black;
            this.admins.BorderSize = 1;
            this.admins.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.admins.CheckedBaseColor = System.Drawing.Color.Teal;
            this.admins.CheckedBorderColor = System.Drawing.Color.Black;
            this.admins.CheckedForeColor = System.Drawing.Color.White;
            this.admins.CheckedImage = null;
            this.admins.CheckedLineColor = System.Drawing.Color.DimGray;
            this.admins.DialogResult = System.Windows.Forms.DialogResult.None;
            this.admins.FocusedColor = System.Drawing.Color.Empty;
            this.admins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admins.ForeColor = System.Drawing.Color.Black;
            this.admins.Image = null;
            this.admins.ImageSize = new System.Drawing.Size(20, 20);
            this.admins.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.admins.Location = new System.Drawing.Point(220, 684);
            this.admins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admins.Name = "admins";
            this.admins.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admins.OnHoverBorderColor = System.Drawing.Color.Black;
            this.admins.OnHoverForeColor = System.Drawing.Color.White;
            this.admins.OnHoverImage = null;
            this.admins.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.admins.OnPressedColor = System.Drawing.Color.Black;
            this.admins.Size = new System.Drawing.Size(203, 46);
            this.admins.TabIndex = 45;
            this.admins.Text = "Only Admins";
            this.admins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.admins.Click += new System.EventHandler(this.admins_Click);
            // 
            // surgeons
            // 
            this.surgeons.Animated = true;
            this.surgeons.AnimationHoverSpeed = 0.07F;
            this.surgeons.AnimationSpeed = 0.03F;
            this.surgeons.BackColor = System.Drawing.Color.Transparent;
            this.surgeons.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.surgeons.BorderColor = System.Drawing.Color.Black;
            this.surgeons.BorderSize = 1;
            this.surgeons.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.surgeons.CheckedBaseColor = System.Drawing.Color.Teal;
            this.surgeons.CheckedBorderColor = System.Drawing.Color.Black;
            this.surgeons.CheckedForeColor = System.Drawing.Color.White;
            this.surgeons.CheckedImage = null;
            this.surgeons.CheckedLineColor = System.Drawing.Color.DimGray;
            this.surgeons.DialogResult = System.Windows.Forms.DialogResult.None;
            this.surgeons.FocusedColor = System.Drawing.Color.Empty;
            this.surgeons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgeons.ForeColor = System.Drawing.Color.Black;
            this.surgeons.Image = null;
            this.surgeons.ImageSize = new System.Drawing.Size(20, 20);
            this.surgeons.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.surgeons.Location = new System.Drawing.Point(419, 684);
            this.surgeons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgeons.Name = "surgeons";
            this.surgeons.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.surgeons.OnHoverBorderColor = System.Drawing.Color.Black;
            this.surgeons.OnHoverForeColor = System.Drawing.Color.White;
            this.surgeons.OnHoverImage = null;
            this.surgeons.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.surgeons.OnPressedColor = System.Drawing.Color.Black;
            this.surgeons.Size = new System.Drawing.Size(203, 46);
            this.surgeons.TabIndex = 46;
            this.surgeons.Text = "Only Surgeons";
            this.surgeons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nurses
            // 
            this.nurses.Animated = true;
            this.nurses.AnimationHoverSpeed = 0.07F;
            this.nurses.AnimationSpeed = 0.03F;
            this.nurses.BackColor = System.Drawing.Color.Transparent;
            this.nurses.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.nurses.BorderColor = System.Drawing.Color.Black;
            this.nurses.BorderSize = 1;
            this.nurses.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.nurses.CheckedBaseColor = System.Drawing.Color.Teal;
            this.nurses.CheckedBorderColor = System.Drawing.Color.Black;
            this.nurses.CheckedForeColor = System.Drawing.Color.White;
            this.nurses.CheckedImage = null;
            this.nurses.CheckedLineColor = System.Drawing.Color.DimGray;
            this.nurses.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nurses.FocusedColor = System.Drawing.Color.Empty;
            this.nurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurses.ForeColor = System.Drawing.Color.Black;
            this.nurses.Image = null;
            this.nurses.ImageSize = new System.Drawing.Size(20, 20);
            this.nurses.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nurses.Location = new System.Drawing.Point(617, 684);
            this.nurses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nurses.Name = "nurses";
            this.nurses.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nurses.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nurses.OnHoverForeColor = System.Drawing.Color.White;
            this.nurses.OnHoverImage = null;
            this.nurses.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nurses.OnPressedColor = System.Drawing.Color.Black;
            this.nurses.Size = new System.Drawing.Size(203, 46);
            this.nurses.TabIndex = 45;
            this.nurses.Text = "Only Nurses";
            this.nurses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.allRecord);
            this.Controls.Add(this.nurses);
            this.Controls.Add(this.admins);
            this.Controls.Add(this.surgeons);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.error6);
            this.Controls.Add(this.error5);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.deleteStaff);
            this.Controls.Add(this.addStaff);
            this.Controls.Add(this.updateStaff);
            this.Controls.Add(this.nurse);
            this.Controls.Add(this.surgeon);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.username);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(1685, 767);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox error4;
        private Guna.UI.WinForms.GunaPictureBox error3;
        private Guna.UI.WinForms.GunaPictureBox error2;
        private Guna.UI.WinForms.GunaPictureBox error1;
        private Guna.UI.WinForms.GunaAdvenceButton clear;
        private System.Windows.Forms.Timer updater;
        private Guna.UI.WinForms.GunaAdvenceButton deleteStaff;
        private Guna.UI.WinForms.GunaAdvenceButton addStaff;
        private Guna.UI.WinForms.GunaAdvenceButton updateStaff;
        private Guna.UI.WinForms.GunaRadioButton surgeon;
        private Guna.UI.WinForms.GunaRadioButton admin;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox pass;
        private Guna.UI.WinForms.GunaTextBox firstname;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox lastname;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox staffId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer errorDisplay;
        private Guna.UI.WinForms.GunaRadioButton nurse;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox confirm;
        private Guna.UI.WinForms.GunaPictureBox error5;
        private Guna.UI.WinForms.GunaPictureBox error6;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaAdvenceButton allRecord;
        private Guna.UI.WinForms.GunaAdvenceButton admins;
        private Guna.UI.WinForms.GunaAdvenceButton surgeons;
        private Guna.UI.WinForms.GunaAdvenceButton nurses;
    }
}
