namespace AK_Hospital.User_Controls
{
    partial class PrescriptionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorDisplay = new System.Windows.Forms.Timer(this.components);
            this.error3 = new Guna.UI.WinForms.GunaPictureBox();
            this.error2 = new Guna.UI.WinForms.GunaPictureBox();
            this.error1 = new Guna.UI.WinForms.GunaPictureBox();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.deletePrescription = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addPrescription = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updatePrescription = new Guna.UI.WinForms.GunaAdvenceButton();
            this.patId = new Guna.UI.WinForms.GunaTextBox();
            this.medId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.preId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.clear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.patientName = new Guna.UI.WinForms.GunaTextBox();
            this.medicationName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.PatientUpdater = new System.Windows.Forms.Timer(this.components);
            this.MedUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // errorDisplay
            // 
            this.errorDisplay.Interval = 1000;
            this.errorDisplay.Tick += new System.EventHandler(this.errorDisplay_Tick);
            // 
            // error3
            // 
            this.error3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error3.BaseColor = System.Drawing.Color.White;
            this.error3.Image = ((System.Drawing.Image)(resources.GetObject("error3.Image")));
            this.error3.Location = new System.Drawing.Point(1625, 229);
            this.error3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(27, 25);
            this.error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error3.TabIndex = 38;
            this.error3.TabStop = false;
            this.error3.Visible = false;
            // 
            // error2
            // 
            this.error2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error2.BaseColor = System.Drawing.Color.White;
            this.error2.Image = ((System.Drawing.Image)(resources.GetObject("error2.Image")));
            this.error2.Location = new System.Drawing.Point(1625, 182);
            this.error2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(27, 25);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error2.TabIndex = 41;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // error1
            // 
            this.error1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error1.BaseColor = System.Drawing.Color.White;
            this.error1.Image = ((System.Drawing.Image)(resources.GetObject("error1.Image")));
            this.error1.Location = new System.Drawing.Point(1625, 134);
            this.error1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(27, 25);
            this.error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error1.TabIndex = 40;
            this.error1.TabStop = false;
            this.error1.Visible = false;
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // deletePrescription
            // 
            this.deletePrescription.Animated = true;
            this.deletePrescription.AnimationHoverSpeed = 0.07F;
            this.deletePrescription.AnimationSpeed = 0.03F;
            this.deletePrescription.BackColor = System.Drawing.Color.Transparent;
            this.deletePrescription.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.deletePrescription.BorderColor = System.Drawing.Color.Black;
            this.deletePrescription.BorderSize = 1;
            this.deletePrescription.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deletePrescription.CheckedBorderColor = System.Drawing.Color.Black;
            this.deletePrescription.CheckedForeColor = System.Drawing.Color.White;
            this.deletePrescription.CheckedImage = null;
            this.deletePrescription.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deletePrescription.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletePrescription.FocusedColor = System.Drawing.Color.Empty;
            this.deletePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrescription.ForeColor = System.Drawing.Color.Black;
            this.deletePrescription.Image = null;
            this.deletePrescription.ImageSize = new System.Drawing.Size(20, 20);
            this.deletePrescription.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deletePrescription.Location = new System.Drawing.Point(1324, 556);
            this.deletePrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletePrescription.Name = "deletePrescription";
            this.deletePrescription.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.deletePrescription.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletePrescription.OnHoverForeColor = System.Drawing.Color.White;
            this.deletePrescription.OnHoverImage = null;
            this.deletePrescription.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deletePrescription.OnPressedColor = System.Drawing.Color.Black;
            this.deletePrescription.Radius = 10;
            this.deletePrescription.Size = new System.Drawing.Size(269, 52);
            this.deletePrescription.TabIndex = 6;
            this.deletePrescription.Text = "Delete Prescription";
            this.deletePrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletePrescription.Click += new System.EventHandler(this.deletePrescription_Click);
            // 
            // addPrescription
            // 
            this.addPrescription.Animated = true;
            this.addPrescription.AnimationHoverSpeed = 0.07F;
            this.addPrescription.AnimationSpeed = 0.03F;
            this.addPrescription.BackColor = System.Drawing.Color.Transparent;
            this.addPrescription.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.addPrescription.BorderColor = System.Drawing.Color.Black;
            this.addPrescription.BorderSize = 1;
            this.addPrescription.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addPrescription.CheckedBorderColor = System.Drawing.Color.Black;
            this.addPrescription.CheckedForeColor = System.Drawing.Color.White;
            this.addPrescription.CheckedImage = null;
            this.addPrescription.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addPrescription.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addPrescription.FocusedColor = System.Drawing.Color.Empty;
            this.addPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrescription.ForeColor = System.Drawing.Color.Black;
            this.addPrescription.Image = null;
            this.addPrescription.ImageSize = new System.Drawing.Size(20, 20);
            this.addPrescription.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addPrescription.Location = new System.Drawing.Point(999, 497);
            this.addPrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPrescription.Name = "addPrescription";
            this.addPrescription.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.addPrescription.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addPrescription.OnHoverForeColor = System.Drawing.Color.White;
            this.addPrescription.OnHoverImage = null;
            this.addPrescription.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addPrescription.OnPressedColor = System.Drawing.Color.Black;
            this.addPrescription.Radius = 10;
            this.addPrescription.Size = new System.Drawing.Size(595, 52);
            this.addPrescription.TabIndex = 4;
            this.addPrescription.Text = "Add Prescription";
            this.addPrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPrescription.Click += new System.EventHandler(this.addPrescription_Click);
            // 
            // updatePrescription
            // 
            this.updatePrescription.Animated = true;
            this.updatePrescription.AnimationHoverSpeed = 0.07F;
            this.updatePrescription.AnimationSpeed = 0.03F;
            this.updatePrescription.BackColor = System.Drawing.Color.Transparent;
            this.updatePrescription.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.updatePrescription.BorderColor = System.Drawing.Color.Black;
            this.updatePrescription.BorderSize = 1;
            this.updatePrescription.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updatePrescription.CheckedBorderColor = System.Drawing.Color.Black;
            this.updatePrescription.CheckedForeColor = System.Drawing.Color.White;
            this.updatePrescription.CheckedImage = null;
            this.updatePrescription.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updatePrescription.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatePrescription.FocusedColor = System.Drawing.Color.Empty;
            this.updatePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrescription.ForeColor = System.Drawing.Color.Black;
            this.updatePrescription.Image = null;
            this.updatePrescription.ImageSize = new System.Drawing.Size(20, 20);
            this.updatePrescription.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updatePrescription.Location = new System.Drawing.Point(999, 556);
            this.updatePrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatePrescription.Name = "updatePrescription";
            this.updatePrescription.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.updatePrescription.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updatePrescription.OnHoverForeColor = System.Drawing.Color.White;
            this.updatePrescription.OnHoverImage = null;
            this.updatePrescription.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updatePrescription.OnPressedColor = System.Drawing.Color.Black;
            this.updatePrescription.Radius = 10;
            this.updatePrescription.Size = new System.Drawing.Size(269, 52);
            this.updatePrescription.TabIndex = 5;
            this.updatePrescription.Text = "Update Prescription";
            this.updatePrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatePrescription.Click += new System.EventHandler(this.updatePrescription_Click);
            // 
            // patId
            // 
            this.patId.BackColor = System.Drawing.Color.Transparent;
            this.patId.BaseColor = System.Drawing.Color.LightCyan;
            this.patId.BorderColor = System.Drawing.Color.Black;
            this.patId.BorderSize = 1;
            this.patId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patId.FocusedBaseColor = System.Drawing.Color.White;
            this.patId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patId.Location = new System.Drawing.Point(1184, 176);
            this.patId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patId.Name = "patId";
            this.patId.PasswordChar = '\0';
            this.patId.Radius = 10;
            this.patId.SelectedText = "";
            this.patId.Size = new System.Drawing.Size(409, 41);
            this.patId.TabIndex = 2;
            this.patId.TextOffsetX = 10;
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
            this.medId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medId.Location = new System.Drawing.Point(1184, 223);
            this.medId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medId.Name = "medId";
            this.medId.PasswordChar = '\0';
            this.medId.Radius = 10;
            this.medId.SelectedText = "";
            this.medId.Size = new System.Drawing.Size(409, 41);
            this.medId.TabIndex = 3;
            this.medId.TextOffsetX = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(992, 182);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(93, 25);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "Patient Id";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(992, 229);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(131, 25);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Medication ID";
            // 
            // preId
            // 
            this.preId.BackColor = System.Drawing.Color.Transparent;
            this.preId.BaseColor = System.Drawing.Color.LightCyan;
            this.preId.BorderColor = System.Drawing.Color.Black;
            this.preId.BorderSize = 1;
            this.preId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.preId.FocusedBaseColor = System.Drawing.Color.White;
            this.preId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.preId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.preId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preId.Location = new System.Drawing.Point(1184, 128);
            this.preId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preId.Name = "preId";
            this.preId.PasswordChar = '\0';
            this.preId.Radius = 10;
            this.preId.SelectedText = "";
            this.preId.Size = new System.Drawing.Size(409, 41);
            this.preId.TabIndex = 1;
            this.preId.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(992, 134);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 25);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Prescription ID";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1223, 16);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(172, 31);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "Prescriptions";
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
            this.clear.Location = new System.Drawing.Point(999, 615);
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
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Click += new System.EventHandler(this.clear_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv.Location = new System.Drawing.Point(17, 20);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(920, 726);
            this.dgv.TabIndex = 42;
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
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.Color.Transparent;
            this.patientName.BaseColor = System.Drawing.Color.PowderBlue;
            this.patientName.BorderColor = System.Drawing.Color.Black;
            this.patientName.BorderSize = 1;
            this.patientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientName.Enabled = false;
            this.patientName.FocusedBaseColor = System.Drawing.Color.White;
            this.patientName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.Location = new System.Drawing.Point(1184, 320);
            this.patientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientName.Name = "patientName";
            this.patientName.PasswordChar = '\0';
            this.patientName.Radius = 10;
            this.patientName.SelectedText = "";
            this.patientName.Size = new System.Drawing.Size(409, 41);
            this.patientName.TabIndex = 1;
            this.patientName.TextOffsetX = 10;
            // 
            // medicationName
            // 
            this.medicationName.BackColor = System.Drawing.Color.Transparent;
            this.medicationName.BaseColor = System.Drawing.Color.PowderBlue;
            this.medicationName.BorderColor = System.Drawing.Color.Black;
            this.medicationName.BorderSize = 1;
            this.medicationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicationName.Enabled = false;
            this.medicationName.FocusedBaseColor = System.Drawing.Color.White;
            this.medicationName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicationName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.medicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationName.Location = new System.Drawing.Point(1184, 368);
            this.medicationName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicationName.Name = "medicationName";
            this.medicationName.PasswordChar = '\0';
            this.medicationName.Radius = 10;
            this.medicationName.SelectedText = "";
            this.medicationName.Size = new System.Drawing.Size(409, 41);
            this.medicationName.TabIndex = 1;
            this.medicationName.TextOffsetX = 10;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(992, 372);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(107, 25);
            this.gunaLabel5.TabIndex = 21;
            this.gunaLabel5.Text = "Medication";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(992, 325);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel6.TabIndex = 22;
            this.gunaLabel6.Text = "Patient Name";
            // 
            // PatientUpdater
            // 
            this.PatientUpdater.Interval = 1000;
            this.PatientUpdater.Tick += new System.EventHandler(this.PatientUpdater_Tick);
            // 
            // MedUpdater
            // 
            this.MedUpdater.Interval = 1000;
            this.MedUpdater.Tick += new System.EventHandler(this.MedUpdater_Tick);
            // 
            // PrescriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.deletePrescription);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addPrescription);
            this.Controls.Add(this.updatePrescription);
            this.Controls.Add(this.patId);
            this.Controls.Add(this.medId);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.medicationName);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.preId);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrescriptionControl";
            this.Size = new System.Drawing.Size(1685, 767);
            this.Load += new System.EventHandler(this.PrescriptionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer errorDisplay;
        private Guna.UI.WinForms.GunaPictureBox error3;
        private Guna.UI.WinForms.GunaPictureBox error2;
        private Guna.UI.WinForms.GunaPictureBox error1;
        private System.Windows.Forms.Timer updater;
        private Guna.UI.WinForms.GunaAdvenceButton deletePrescription;
        private Guna.UI.WinForms.GunaAdvenceButton addPrescription;
        private Guna.UI.WinForms.GunaAdvenceButton updatePrescription;
        private Guna.UI.WinForms.GunaTextBox patId;
        private Guna.UI.WinForms.GunaTextBox medId;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox preId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton clear;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaTextBox patientName;
        private Guna.UI.WinForms.GunaTextBox medicationName;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Timer PatientUpdater;
        private System.Windows.Forms.Timer MedUpdater;
    }
}
