namespace AK_Hospital
{
    partial class LoginForm
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new Guna.UI.WinForms.GunaTextBox();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.loginButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BaseColor = System.Drawing.Color.LightCyan;
            this.password.BorderColor = System.Drawing.Color.Black;
            this.password.BorderSize = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(303, 234);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Radius = 8;
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(351, 42);
            this.password.TabIndex = 9;
            this.password.TextOffsetX = 15;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.LightCyan;
            this.username.BorderColor = System.Drawing.Color.Black;
            this.username.BorderSize = 1;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(303, 177);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 8;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(351, 42);
            this.username.TabIndex = 5;
            this.username.TextOffsetX = 15;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(144, 241);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(144, 177);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Username";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(85, 73);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(561, 39);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Welcome to Spawn Point Hospital";
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.AnimationHoverSpeed = 0.07F;
            this.exitButton.AnimationSpeed = 0.03F;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.BorderSize = 1;
            this.exitButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.exitButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.exitButton.CheckedForeColor = System.Drawing.Color.White;
            this.exitButton.CheckedImage = null;
            this.exitButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.FocusedColor = System.Drawing.Color.Empty;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Image = null;
            this.exitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.exitButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.exitButton.Location = new System.Drawing.Point(431, 327);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.exitButton.OnHoverImage = null;
            this.exitButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.exitButton.OnPressedColor = System.Drawing.Color.Black;
            this.exitButton.Radius = 15;
            this.exitButton.Size = new System.Drawing.Size(223, 52);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.BorderSize = 1;
            this.loginButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.loginButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.loginButton.CheckedForeColor = System.Drawing.Color.White;
            this.loginButton.CheckedImage = null;
            this.loginButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.FocusedColor = System.Drawing.Color.Empty;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.Location = new System.Drawing.Point(151, 327);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 15;
            this.loginButton.Size = new System.Drawing.Size(231, 52);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel1;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panel1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(807, 452);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox password;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaAdvenceButton loginButton;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
    }
}