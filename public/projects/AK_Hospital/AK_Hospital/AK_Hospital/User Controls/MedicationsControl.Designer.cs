namespace AK_Hospital.User_Controls
{
    partial class MedicationsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.error2 = new Guna.UI.WinForms.GunaPictureBox();
            this.error1 = new Guna.UI.WinForms.GunaPictureBox();
            this.deleteMedication = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addMedication = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updateMedication = new Guna.UI.WinForms.GunaAdvenceButton();
            this.medName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.medId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.errorDisplay = new System.Windows.Forms.Timer(this.components);
            this.clear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.prescribedFor = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // error2
            // 
            this.error2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error2.BaseColor = System.Drawing.Color.White;
            this.error2.Image = ((System.Drawing.Image)(resources.GetObject("error2.Image")));
            this.error2.Location = new System.Drawing.Point(506, 151);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(20, 20);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error2.TabIndex = 39;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // error1
            // 
            this.error1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error1.BaseColor = System.Drawing.Color.White;
            this.error1.Image = ((System.Drawing.Image)(resources.GetObject("error1.Image")));
            this.error1.Location = new System.Drawing.Point(506, 112);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(20, 20);
            this.error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error1.TabIndex = 38;
            this.error1.TabStop = false;
            this.error1.Visible = false;
            // 
            // deleteMedication
            // 
            this.deleteMedication.Animated = true;
            this.deleteMedication.AnimationHoverSpeed = 0.07F;
            this.deleteMedication.AnimationSpeed = 0.03F;
            this.deleteMedication.BackColor = System.Drawing.Color.Transparent;
            this.deleteMedication.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.deleteMedication.BorderColor = System.Drawing.Color.Black;
            this.deleteMedication.BorderSize = 1;
            this.deleteMedication.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteMedication.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteMedication.CheckedForeColor = System.Drawing.Color.White;
            this.deleteMedication.CheckedImage = null;
            this.deleteMedication.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteMedication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteMedication.FocusedColor = System.Drawing.Color.Empty;
            this.deleteMedication.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMedication.ForeColor = System.Drawing.Color.Black;
            this.deleteMedication.Image = null;
            this.deleteMedication.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteMedication.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteMedication.Location = new System.Drawing.Point(280, 308);
            this.deleteMedication.Name = "deleteMedication";
            this.deleteMedication.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.deleteMedication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteMedication.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteMedication.OnHoverImage = null;
            this.deleteMedication.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteMedication.OnPressedColor = System.Drawing.Color.Black;
            this.deleteMedication.Radius = 10;
            this.deleteMedication.Size = new System.Drawing.Size(202, 42);
            this.deleteMedication.TabIndex = 5;
            this.deleteMedication.Text = "Delete Medication";
            this.deleteMedication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteMedication.Click += new System.EventHandler(this.deleteMedication_Click);
            // 
            // addMedication
            // 
            this.addMedication.Animated = true;
            this.addMedication.AnimationHoverSpeed = 0.07F;
            this.addMedication.AnimationSpeed = 0.03F;
            this.addMedication.BackColor = System.Drawing.Color.Transparent;
            this.addMedication.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.addMedication.BorderColor = System.Drawing.Color.Black;
            this.addMedication.BorderSize = 1;
            this.addMedication.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addMedication.CheckedBorderColor = System.Drawing.Color.Black;
            this.addMedication.CheckedForeColor = System.Drawing.Color.White;
            this.addMedication.CheckedImage = null;
            this.addMedication.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addMedication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addMedication.FocusedColor = System.Drawing.Color.Empty;
            this.addMedication.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedication.ForeColor = System.Drawing.Color.Black;
            this.addMedication.Image = null;
            this.addMedication.ImageSize = new System.Drawing.Size(20, 20);
            this.addMedication.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addMedication.Location = new System.Drawing.Point(36, 260);
            this.addMedication.Name = "addMedication";
            this.addMedication.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.addMedication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addMedication.OnHoverForeColor = System.Drawing.Color.White;
            this.addMedication.OnHoverImage = null;
            this.addMedication.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addMedication.OnPressedColor = System.Drawing.Color.Black;
            this.addMedication.Radius = 10;
            this.addMedication.Size = new System.Drawing.Size(446, 42);
            this.addMedication.TabIndex = 3;
            this.addMedication.Text = "Add Medication";
            this.addMedication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addMedication.Click += new System.EventHandler(this.addMedication_Click);
            // 
            // updateMedication
            // 
            this.updateMedication.Animated = true;
            this.updateMedication.AnimationHoverSpeed = 0.07F;
            this.updateMedication.AnimationSpeed = 0.03F;
            this.updateMedication.BackColor = System.Drawing.Color.Transparent;
            this.updateMedication.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.updateMedication.BorderColor = System.Drawing.Color.Black;
            this.updateMedication.BorderSize = 1;
            this.updateMedication.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateMedication.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateMedication.CheckedForeColor = System.Drawing.Color.White;
            this.updateMedication.CheckedImage = null;
            this.updateMedication.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateMedication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateMedication.FocusedColor = System.Drawing.Color.Empty;
            this.updateMedication.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedication.ForeColor = System.Drawing.Color.Black;
            this.updateMedication.Image = null;
            this.updateMedication.ImageSize = new System.Drawing.Size(20, 20);
            this.updateMedication.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateMedication.Location = new System.Drawing.Point(36, 308);
            this.updateMedication.Name = "updateMedication";
            this.updateMedication.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.updateMedication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateMedication.OnHoverForeColor = System.Drawing.Color.White;
            this.updateMedication.OnHoverImage = null;
            this.updateMedication.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateMedication.OnPressedColor = System.Drawing.Color.Black;
            this.updateMedication.Radius = 10;
            this.updateMedication.Size = new System.Drawing.Size(202, 42);
            this.updateMedication.TabIndex = 4;
            this.updateMedication.Text = "Update Medication";
            this.updateMedication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateMedication.Click += new System.EventHandler(this.updateMedication_Click);
            // 
            // medName
            // 
            this.medName.BackColor = System.Drawing.Color.Transparent;
            this.medName.BaseColor = System.Drawing.Color.LightCyan;
            this.medName.BorderColor = System.Drawing.Color.Black;
            this.medName.BorderSize = 1;
            this.medName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medName.FocusedBaseColor = System.Drawing.Color.White;
            this.medName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.medName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medName.Location = new System.Drawing.Point(175, 146);
            this.medName.Name = "medName";
            this.medName.PasswordChar = '\0';
            this.medName.Radius = 10;
            this.medName.SelectedText = "";
            this.medName.Size = new System.Drawing.Size(307, 33);
            this.medName.TabIndex = 2;
            this.medName.TextOffsetX = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(31, 151);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "Medication";
            // 
            // medId
            // 
            this.medId.BackColor = System.Drawing.Color.Transparent;
            this.medId.BaseColor = System.Drawing.Color.LightCyan;
            this.medId.BorderColor = System.Drawing.Color.Black;
            this.medId.BorderSize = 1;
            this.medId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medId.FocusedBaseColor = System.Drawing.Color.White;
            this.medId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.medId.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medId.Location = new System.Drawing.Point(175, 107);
            this.medId.Name = "medId";
            this.medId.PasswordChar = '\0';
            this.medId.Radius = 10;
            this.medId.SelectedText = "";
            this.medId.Size = new System.Drawing.Size(307, 33);
            this.medId.TabIndex = 1;
            this.medId.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(31, 112);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(121, 28);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Medication ID";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(197, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(144, 37);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Medications";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv.Location = new System.Drawing.Point(560, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(690, 590);
            this.dgv.TabIndex = 18;
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
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // errorDisplay
            // 
            this.errorDisplay.Interval = 1000;
            this.errorDisplay.Tick += new System.EventHandler(this.errorDisplay_Tick);
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
            this.clear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Image = null;
            this.clear.ImageSize = new System.Drawing.Size(20, 20);
            this.clear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clear.Location = new System.Drawing.Point(36, 356);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear.OnHoverForeColor = System.Drawing.Color.White;
            this.clear.OnHoverImage = null;
            this.clear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Radius = 10;
            this.clear.Size = new System.Drawing.Size(446, 42);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(31, 190);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(125, 28);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Prescribed For";
            // 
            // prescribedFor
            // 
            this.prescribedFor.BackColor = System.Drawing.Color.Transparent;
            this.prescribedFor.BaseColor = System.Drawing.Color.LightCyan;
            this.prescribedFor.BorderColor = System.Drawing.Color.Black;
            this.prescribedFor.BorderSize = 1;
            this.prescribedFor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prescribedFor.FocusedBaseColor = System.Drawing.Color.White;
            this.prescribedFor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prescribedFor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prescribedFor.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescribedFor.Location = new System.Drawing.Point(175, 185);
            this.prescribedFor.Name = "prescribedFor";
            this.prescribedFor.PasswordChar = '\0';
            this.prescribedFor.Radius = 10;
            this.prescribedFor.SelectedText = "";
            this.prescribedFor.Size = new System.Drawing.Size(307, 33);
            this.prescribedFor.TabIndex = 2;
            this.prescribedFor.TextOffsetX = 10;
            // 
            // MedicationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.deleteMedication);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addMedication);
            this.Controls.Add(this.updateMedication);
            this.Controls.Add(this.prescribedFor);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.medName);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.medId);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgv);
            this.Name = "MedicationsControl";
            this.Size = new System.Drawing.Size(1264, 623);
            this.Load += new System.EventHandler(this.MedicationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox error2;
        private Guna.UI.WinForms.GunaPictureBox error1;
        private Guna.UI.WinForms.GunaAdvenceButton deleteMedication;
        private Guna.UI.WinForms.GunaAdvenceButton addMedication;
        private Guna.UI.WinForms.GunaAdvenceButton updateMedication;
        private Guna.UI.WinForms.GunaTextBox medName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox medId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.Timer errorDisplay;
        private Guna.UI.WinForms.GunaAdvenceButton clear;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox prescribedFor;
    }
}
