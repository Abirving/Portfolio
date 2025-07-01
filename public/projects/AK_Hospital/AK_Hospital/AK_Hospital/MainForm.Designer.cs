namespace AK_Hospital
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NavPanel = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PresButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.HomeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MedicButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.StaffButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PatientsButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProfileButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MainPanel = new Guna.UI.WinForms.GunaPanel();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.logoutButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.elipseControl = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.NavPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Teal;
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Controls.Add(this.PresButton);
            this.NavPanel.Controls.Add(this.HomeButton);
            this.NavPanel.Controls.Add(this.MedicButton);
            this.NavPanel.Controls.Add(this.StaffButton);
            this.NavPanel.Controls.Add(this.PatientsButton);
            this.NavPanel.Controls.Add(this.ProfileButton);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.ForeColor = System.Drawing.Color.White;
            this.NavPanel.Location = new System.Drawing.Point(4, 4);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.NavPanel.Size = new System.Drawing.Size(1685, 63);
            this.NavPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1419, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 0;
            // 
            // PresButton
            // 
            this.PresButton.Animated = true;
            this.PresButton.AnimationHoverSpeed = 0.07F;
            this.PresButton.AnimationSpeed = 0.03F;
            this.PresButton.BackColor = System.Drawing.Color.Transparent;
            this.PresButton.BaseColor = System.Drawing.Color.Transparent;
            this.PresButton.BorderColor = System.Drawing.Color.Black;
            this.PresButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.PresButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PresButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.PresButton.CheckedForeColor = System.Drawing.Color.Black;
            this.PresButton.CheckedImage = null;
            this.PresButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.PresButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PresButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PresButton.FocusedColor = System.Drawing.Color.Empty;
            this.PresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresButton.ForeColor = System.Drawing.Color.Black;
            this.PresButton.Image = null;
            this.PresButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PresButton.LineBottom = 2;
            this.PresButton.LineColor = System.Drawing.Color.Transparent;
            this.PresButton.Location = new System.Drawing.Point(697, 6);
            this.PresButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresButton.Name = "PresButton";
            this.PresButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.PresButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PresButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.PresButton.OnHoverImage = null;
            this.PresButton.OnHoverLineColor = System.Drawing.Color.LightSeaGreen;
            this.PresButton.OnPressedColor = System.Drawing.Color.Black;
            this.PresButton.Size = new System.Drawing.Size(172, 57);
            this.PresButton.TabIndex = 5;
            this.PresButton.Text = "Prescriptions";
            this.PresButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PresButton.Click += new System.EventHandler(this.PresButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AnimationHoverSpeed = 0.07F;
            this.HomeButton.AnimationSpeed = 0.03F;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BaseColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.HomeButton.Checked = true;
            this.HomeButton.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.HomeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.HomeButton.CheckedForeColor = System.Drawing.Color.Black;
            this.HomeButton.CheckedImage = null;
            this.HomeButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FocusedColor = System.Drawing.Color.Empty;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Black;
            this.HomeButton.Image = null;
            this.HomeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.HomeButton.LineBottom = 2;
            this.HomeButton.LineColor = System.Drawing.Color.Transparent;
            this.HomeButton.Location = new System.Drawing.Point(0, 6);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.HomeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.HomeButton.OnHoverImage = null;
            this.HomeButton.OnHoverLineColor = System.Drawing.Color.Azure;
            this.HomeButton.OnPressedColor = System.Drawing.Color.Black;
            this.HomeButton.Size = new System.Drawing.Size(172, 57);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MedicButton
            // 
            this.MedicButton.Animated = true;
            this.MedicButton.AnimationHoverSpeed = 0.07F;
            this.MedicButton.AnimationSpeed = 0.03F;
            this.MedicButton.BackColor = System.Drawing.Color.Transparent;
            this.MedicButton.BaseColor = System.Drawing.Color.Transparent;
            this.MedicButton.BorderColor = System.Drawing.Color.Black;
            this.MedicButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.MedicButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MedicButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MedicButton.CheckedForeColor = System.Drawing.Color.Black;
            this.MedicButton.CheckedImage = null;
            this.MedicButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.MedicButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MedicButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MedicButton.FocusedColor = System.Drawing.Color.Empty;
            this.MedicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicButton.ForeColor = System.Drawing.Color.Black;
            this.MedicButton.Image = null;
            this.MedicButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MedicButton.LineBottom = 2;
            this.MedicButton.LineColor = System.Drawing.Color.Transparent;
            this.MedicButton.Location = new System.Drawing.Point(869, 6);
            this.MedicButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedicButton.Name = "MedicButton";
            this.MedicButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.MedicButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MedicButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.MedicButton.OnHoverImage = null;
            this.MedicButton.OnHoverLineColor = System.Drawing.Color.LightSeaGreen;
            this.MedicButton.OnPressedColor = System.Drawing.Color.Black;
            this.MedicButton.Size = new System.Drawing.Size(172, 57);
            this.MedicButton.TabIndex = 3;
            this.MedicButton.Text = "Medications";
            this.MedicButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MedicButton.Click += new System.EventHandler(this.MedicButton_Click);
            // 
            // StaffButton
            // 
            this.StaffButton.Animated = true;
            this.StaffButton.AnimationHoverSpeed = 0.07F;
            this.StaffButton.AnimationSpeed = 0.03F;
            this.StaffButton.BackColor = System.Drawing.Color.Transparent;
            this.StaffButton.BaseColor = System.Drawing.Color.Transparent;
            this.StaffButton.BorderColor = System.Drawing.Color.Black;
            this.StaffButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.StaffButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StaffButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.StaffButton.CheckedForeColor = System.Drawing.Color.Black;
            this.StaffButton.CheckedImage = null;
            this.StaffButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.StaffButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StaffButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StaffButton.FocusedColor = System.Drawing.Color.Empty;
            this.StaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffButton.ForeColor = System.Drawing.Color.Black;
            this.StaffButton.Image = null;
            this.StaffButton.ImageSize = new System.Drawing.Size(20, 20);
            this.StaffButton.LineBottom = 2;
            this.StaffButton.LineColor = System.Drawing.Color.Transparent;
            this.StaffButton.Location = new System.Drawing.Point(1041, 6);
            this.StaffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.StaffButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StaffButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.StaffButton.OnHoverImage = null;
            this.StaffButton.OnHoverLineColor = System.Drawing.Color.LightSeaGreen;
            this.StaffButton.OnPressedColor = System.Drawing.Color.Black;
            this.StaffButton.Size = new System.Drawing.Size(172, 57);
            this.StaffButton.TabIndex = 2;
            this.StaffButton.Text = "Staff";
            this.StaffButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.Animated = true;
            this.PatientsButton.AnimationHoverSpeed = 0.07F;
            this.PatientsButton.AnimationSpeed = 0.03F;
            this.PatientsButton.BackColor = System.Drawing.Color.Transparent;
            this.PatientsButton.BaseColor = System.Drawing.Color.Transparent;
            this.PatientsButton.BorderColor = System.Drawing.Color.Black;
            this.PatientsButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.PatientsButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PatientsButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.PatientsButton.CheckedForeColor = System.Drawing.Color.Black;
            this.PatientsButton.CheckedImage = null;
            this.PatientsButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.PatientsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PatientsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PatientsButton.FocusedColor = System.Drawing.Color.Empty;
            this.PatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsButton.ForeColor = System.Drawing.Color.Black;
            this.PatientsButton.Image = null;
            this.PatientsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PatientsButton.LineBottom = 2;
            this.PatientsButton.LineColor = System.Drawing.Color.Transparent;
            this.PatientsButton.Location = new System.Drawing.Point(1213, 6);
            this.PatientsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.PatientsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PatientsButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.PatientsButton.OnHoverImage = null;
            this.PatientsButton.OnHoverLineColor = System.Drawing.Color.LightSeaGreen;
            this.PatientsButton.OnPressedColor = System.Drawing.Color.Black;
            this.PatientsButton.Size = new System.Drawing.Size(172, 57);
            this.PatientsButton.TabIndex = 1;
            this.PatientsButton.Text = "Patients";
            this.PatientsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Animated = true;
            this.ProfileButton.AnimationHoverSpeed = 0.07F;
            this.ProfileButton.AnimationSpeed = 0.03F;
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BaseColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BorderColor = System.Drawing.Color.Black;
            this.ProfileButton.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.ProfileButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ProfileButton.CheckedForeColor = System.Drawing.Color.Black;
            this.ProfileButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ProfileButton.CheckedImage")));
            this.ProfileButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.ProfileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProfileButton.FocusedColor = System.Drawing.Color.Empty;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.Black;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageOffsetX = 20;
            this.ProfileButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ProfileButton.LineBottom = 2;
            this.ProfileButton.LineColor = System.Drawing.Color.Transparent;
            this.ProfileButton.Location = new System.Drawing.Point(1385, 6);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ProfileButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ProfileButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ProfileButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("ProfileButton.OnHoverImage")));
            this.ProfileButton.OnHoverLineColor = System.Drawing.Color.LightSeaGreen;
            this.ProfileButton.OnPressedColor = System.Drawing.Color.Black;
            this.ProfileButton.Size = new System.Drawing.Size(300, 57);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProfileButton.TextOffsetX = 7;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Teal;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.SubMenu);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(4, 67);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1685, 766);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubMenu.Controls.Add(this.exitButton);
            this.SubMenu.Controls.Add(this.logoutButton);
            this.SubMenu.Location = new System.Drawing.Point(1385, -2);
            this.SubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubMenu.Size = new System.Drawing.Size(303, 122);
            this.SubMenu.TabIndex = 0;
            this.SubMenu.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.AnimationHoverSpeed = 0.07F;
            this.exitButton.AnimationSpeed = 0.03F;
            this.exitButton.BackColor = System.Drawing.Color.Teal;
            this.exitButton.BaseColor = System.Drawing.Color.Teal;
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.CheckedBaseColor = System.Drawing.Color.Teal;
            this.exitButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.exitButton.CheckedForeColor = System.Drawing.Color.Black;
            this.exitButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("exitButton.CheckedImage")));
            this.exitButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FocusedColor = System.Drawing.Color.Empty;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageSize = new System.Drawing.Size(30, 30);
            this.exitButton.LineColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(4, 61);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("exitButton.OnHoverImage")));
            this.exitButton.OnHoverLineColor = System.Drawing.Color.Azure;
            this.exitButton.OnPressedColor = System.Drawing.Color.Black;
            this.exitButton.Size = new System.Drawing.Size(295, 57);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Animated = true;
            this.logoutButton.AnimationHoverSpeed = 0.07F;
            this.logoutButton.AnimationSpeed = 0.03F;
            this.logoutButton.BackColor = System.Drawing.Color.Teal;
            this.logoutButton.BaseColor = System.Drawing.Color.Teal;
            this.logoutButton.BorderColor = System.Drawing.Color.Black;
            this.logoutButton.CheckedBaseColor = System.Drawing.Color.Teal;
            this.logoutButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.logoutButton.CheckedForeColor = System.Drawing.Color.Black;
            this.logoutButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.CheckedImage")));
            this.logoutButton.CheckedLineColor = System.Drawing.Color.DarkSlateGray;
            this.logoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.FocusedColor = System.Drawing.Color.Empty;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageSize = new System.Drawing.Size(30, 30);
            this.logoutButton.LineColor = System.Drawing.Color.Transparent;
            this.logoutButton.Location = new System.Drawing.Point(4, 4);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.logoutButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.OnHoverImage")));
            this.logoutButton.OnHoverLineColor = System.Drawing.Color.Azure;
            this.logoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.logoutButton.Size = new System.Drawing.Size(295, 57);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // elipseControl
            // 
            this.elipseControl.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1693, 837);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spawn Point Hospital";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel NavPanel;
        private Guna.UI.WinForms.GunaAdvenceButton ProfileButton;
        private Guna.UI.WinForms.GunaPanel MainPanel;
        private Guna.UI.WinForms.GunaAdvenceButton PresButton;
        private Guna.UI.WinForms.GunaAdvenceButton HomeButton;
        private Guna.UI.WinForms.GunaAdvenceButton MedicButton;
        private Guna.UI.WinForms.GunaAdvenceButton StaffButton;
        private Guna.UI.WinForms.GunaAdvenceButton PatientsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubMenu;
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaAdvenceButton logoutButton;
        private Guna.UI.WinForms.GunaElipse elipseControl;
        private Guna.UI.WinForms.GunaDragControl dragControl;
    }
}

