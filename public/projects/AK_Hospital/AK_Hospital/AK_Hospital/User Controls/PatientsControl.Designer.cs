namespace AK_Hospital.User_Controls
{
    partial class PatientsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsControl));
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.patientId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.firstname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lastname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.age = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.number = new Guna.UI.WinForms.GunaTextBox();
            this.description = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.active = new Guna.UI.WinForms.GunaRadioButton();
            this.inactive = new Guna.UI.WinForms.GunaRadioButton();
            this.updatePatients = new Guna.UI.WinForms.GunaAdvenceButton();
            this.inactiveatePatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addPatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.error1 = new Guna.UI.WinForms.GunaPictureBox();
            this.error2 = new Guna.UI.WinForms.GunaPictureBox();
            this.error3 = new Guna.UI.WinForms.GunaPictureBox();
            this.error4 = new Guna.UI.WinForms.GunaPictureBox();
            this.errorDisplay = new System.Windows.Forms.Timer(this.components);
            this.clear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.allRecords = new Guna.UI.WinForms.GunaAdvenceButton();
            this.inactiveRecords = new Guna.UI.WinForms.GunaAdvenceButton();
            this.activeRecords = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
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
            this.dgv.Location = new System.Drawing.Point(559, 17);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(690, 506);
            this.dgv.TabIndex = 0;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Azure;
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
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(220, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(101, 37);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Patients";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(47, 113);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "PatientID";
            // 
            // patientId
            // 
            this.patientId.BackColor = System.Drawing.Color.Transparent;
            this.patientId.BaseColor = System.Drawing.Color.LightCyan;
            this.patientId.BorderColor = System.Drawing.Color.Black;
            this.patientId.BorderSize = 1;
            this.patientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientId.FocusedBaseColor = System.Drawing.Color.White;
            this.patientId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patientId.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientId.Location = new System.Drawing.Point(191, 108);
            this.patientId.Name = "patientId";
            this.patientId.PasswordChar = '\0';
            this.patientId.Radius = 10;
            this.patientId.SelectedText = "";
            this.patientId.Size = new System.Drawing.Size(307, 33);
            this.patientId.TabIndex = 1;
            this.patientId.TextOffsetX = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(47, 152);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "First Name";
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
            this.firstname.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(191, 147);
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.Radius = 10;
            this.firstname.SelectedText = "";
            this.firstname.Size = new System.Drawing.Size(307, 33);
            this.firstname.TabIndex = 2;
            this.firstname.TextOffsetX = 10;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(47, 190);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Last Name";
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
            this.lastname.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(191, 185);
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.Radius = 10;
            this.lastname.SelectedText = "";
            this.lastname.Size = new System.Drawing.Size(307, 33);
            this.lastname.TabIndex = 3;
            this.lastname.TextOffsetX = 10;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(47, 229);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(44, 28);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Age";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.BaseColor = System.Drawing.Color.LightCyan;
            this.age.BorderColor = System.Drawing.Color.Black;
            this.age.BorderSize = 1;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.FocusedBaseColor = System.Drawing.Color.White;
            this.age.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.age.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.age.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(191, 224);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.Radius = 10;
            this.age.SelectedText = "";
            this.age.Size = new System.Drawing.Size(307, 33);
            this.age.TabIndex = 4;
            this.age.TextOffsetX = 10;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(47, 306);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Phone Number";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(47, 268);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Description";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.BaseColor = System.Drawing.Color.LightCyan;
            this.number.BorderColor = System.Drawing.Color.Black;
            this.number.BorderSize = 1;
            this.number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.number.FocusedBaseColor = System.Drawing.Color.White;
            this.number.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.number.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.number.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(191, 301);
            this.number.Name = "number";
            this.number.PasswordChar = '\0';
            this.number.Radius = 10;
            this.number.SelectedText = "";
            this.number.Size = new System.Drawing.Size(307, 33);
            this.number.TabIndex = 6;
            this.number.TextOffsetX = 10;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.BaseColor = System.Drawing.Color.LightCyan;
            this.description.BorderColor = System.Drawing.Color.Black;
            this.description.BorderSize = 1;
            this.description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description.FocusedBaseColor = System.Drawing.Color.White;
            this.description.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.description.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.description.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(191, 263);
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.Radius = 10;
            this.description.SelectedText = "";
            this.description.Size = new System.Drawing.Size(307, 33);
            this.description.TabIndex = 5;
            this.description.TextOffsetX = 10;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(47, 345);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(62, 28);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "Status";
            // 
            // active
            // 
            this.active.BaseColor = System.Drawing.Color.White;
            this.active.CheckedOffColor = System.Drawing.Color.Black;
            this.active.CheckedOnColor = System.Drawing.Color.Black;
            this.active.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.active.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.Location = new System.Drawing.Point(191, 345);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(78, 25);
            this.active.TabIndex = 7;
            this.active.Text = "Active";
            // 
            // inactive
            // 
            this.inactive.BaseColor = System.Drawing.Color.White;
            this.inactive.CheckedOffColor = System.Drawing.Color.Black;
            this.inactive.CheckedOnColor = System.Drawing.Color.Black;
            this.inactive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inactive.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactive.Location = new System.Drawing.Point(308, 345);
            this.inactive.Name = "inactive";
            this.inactive.Size = new System.Drawing.Size(101, 25);
            this.inactive.TabIndex = 8;
            this.inactive.Text = "In-Active";
            // 
            // updatePatients
            // 
            this.updatePatients.Animated = true;
            this.updatePatients.AnimationHoverSpeed = 0.07F;
            this.updatePatients.AnimationSpeed = 0.03F;
            this.updatePatients.BackColor = System.Drawing.Color.Transparent;
            this.updatePatients.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.updatePatients.BorderColor = System.Drawing.Color.Black;
            this.updatePatients.BorderSize = 1;
            this.updatePatients.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updatePatients.CheckedBorderColor = System.Drawing.Color.Black;
            this.updatePatients.CheckedForeColor = System.Drawing.Color.White;
            this.updatePatients.CheckedImage = null;
            this.updatePatients.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updatePatients.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatePatients.FocusedColor = System.Drawing.Color.Empty;
            this.updatePatients.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatients.ForeColor = System.Drawing.Color.Black;
            this.updatePatients.Image = null;
            this.updatePatients.ImageSize = new System.Drawing.Size(20, 20);
            this.updatePatients.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updatePatients.Location = new System.Drawing.Point(52, 481);
            this.updatePatients.Name = "updatePatients";
            this.updatePatients.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.updatePatients.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updatePatients.OnHoverForeColor = System.Drawing.Color.White;
            this.updatePatients.OnHoverImage = null;
            this.updatePatients.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updatePatients.OnPressedColor = System.Drawing.Color.Black;
            this.updatePatients.Radius = 10;
            this.updatePatients.Size = new System.Drawing.Size(202, 42);
            this.updatePatients.TabIndex = 4;
            this.updatePatients.Text = "Update Patient";
            this.updatePatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatePatients.Click += new System.EventHandler(this.updatePatients_Click);
            // 
            // inactiveatePatient
            // 
            this.inactiveatePatient.Animated = true;
            this.inactiveatePatient.AnimationHoverSpeed = 0.07F;
            this.inactiveatePatient.AnimationSpeed = 0.03F;
            this.inactiveatePatient.BackColor = System.Drawing.Color.Transparent;
            this.inactiveatePatient.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.inactiveatePatient.BorderColor = System.Drawing.Color.Black;
            this.inactiveatePatient.BorderSize = 1;
            this.inactiveatePatient.CheckedBaseColor = System.Drawing.Color.Gray;
            this.inactiveatePatient.CheckedBorderColor = System.Drawing.Color.Black;
            this.inactiveatePatient.CheckedForeColor = System.Drawing.Color.White;
            this.inactiveatePatient.CheckedImage = null;
            this.inactiveatePatient.CheckedLineColor = System.Drawing.Color.DimGray;
            this.inactiveatePatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.inactiveatePatient.FocusedColor = System.Drawing.Color.Empty;
            this.inactiveatePatient.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveatePatient.ForeColor = System.Drawing.Color.Black;
            this.inactiveatePatient.Image = null;
            this.inactiveatePatient.ImageSize = new System.Drawing.Size(20, 20);
            this.inactiveatePatient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inactiveatePatient.Location = new System.Drawing.Point(296, 481);
            this.inactiveatePatient.Name = "inactiveatePatient";
            this.inactiveatePatient.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.inactiveatePatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.inactiveatePatient.OnHoverForeColor = System.Drawing.Color.White;
            this.inactiveatePatient.OnHoverImage = null;
            this.inactiveatePatient.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inactiveatePatient.OnPressedColor = System.Drawing.Color.Black;
            this.inactiveatePatient.Radius = 10;
            this.inactiveatePatient.Size = new System.Drawing.Size(202, 42);
            this.inactiveatePatient.TabIndex = 4;
            this.inactiveatePatient.Text = "Update Status";
            this.inactiveatePatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inactiveatePatient.Click += new System.EventHandler(this.inactiveatePatient_Click);
            // 
            // addPatient
            // 
            this.addPatient.Animated = true;
            this.addPatient.AnimationHoverSpeed = 0.07F;
            this.addPatient.AnimationSpeed = 0.03F;
            this.addPatient.BackColor = System.Drawing.Color.Transparent;
            this.addPatient.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.addPatient.BorderColor = System.Drawing.Color.Black;
            this.addPatient.BorderSize = 1;
            this.addPatient.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addPatient.CheckedBorderColor = System.Drawing.Color.Black;
            this.addPatient.CheckedForeColor = System.Drawing.Color.White;
            this.addPatient.CheckedImage = null;
            this.addPatient.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addPatient.FocusedColor = System.Drawing.Color.Empty;
            this.addPatient.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient.ForeColor = System.Drawing.Color.Black;
            this.addPatient.Image = null;
            this.addPatient.ImageSize = new System.Drawing.Size(20, 20);
            this.addPatient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addPatient.Location = new System.Drawing.Point(52, 433);
            this.addPatient.Name = "addPatient";
            this.addPatient.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.addPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.addPatient.OnHoverImage = null;
            this.addPatient.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addPatient.OnPressedColor = System.Drawing.Color.Black;
            this.addPatient.Radius = 10;
            this.addPatient.Size = new System.Drawing.Size(446, 42);
            this.addPatient.TabIndex = 4;
            this.addPatient.Text = "Add Patient";
            this.addPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // error1
            // 
            this.error1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error1.BaseColor = System.Drawing.Color.White;
            this.error1.Image = ((System.Drawing.Image)(resources.GetObject("error1.Image")));
            this.error1.Location = new System.Drawing.Point(522, 113);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(20, 20);
            this.error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error1.TabIndex = 17;
            this.error1.TabStop = false;
            this.error1.Visible = false;
            // 
            // error2
            // 
            this.error2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error2.BaseColor = System.Drawing.Color.White;
            this.error2.Image = ((System.Drawing.Image)(resources.GetObject("error2.Image")));
            this.error2.Location = new System.Drawing.Point(522, 152);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(20, 20);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error2.TabIndex = 17;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // error3
            // 
            this.error3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error3.BaseColor = System.Drawing.Color.White;
            this.error3.Image = ((System.Drawing.Image)(resources.GetObject("error3.Image")));
            this.error3.Location = new System.Drawing.Point(522, 190);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(20, 20);
            this.error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error3.TabIndex = 17;
            this.error3.TabStop = false;
            this.error3.Visible = false;
            // 
            // error4
            // 
            this.error4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.error4.BaseColor = System.Drawing.Color.White;
            this.error4.Image = ((System.Drawing.Image)(resources.GetObject("error4.Image")));
            this.error4.Location = new System.Drawing.Point(522, 229);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(20, 20);
            this.error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error4.TabIndex = 17;
            this.error4.TabStop = false;
            this.error4.Visible = false;
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
            this.clear.Location = new System.Drawing.Point(52, 529);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear.OnHoverForeColor = System.Drawing.Color.White;
            this.clear.OnHoverImage = null;
            this.clear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Radius = 10;
            this.clear.Size = new System.Drawing.Size(446, 42);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // allRecords
            // 
            this.allRecords.Animated = true;
            this.allRecords.AnimationHoverSpeed = 0.07F;
            this.allRecords.AnimationSpeed = 0.03F;
            this.allRecords.BackColor = System.Drawing.Color.Transparent;
            this.allRecords.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.allRecords.BorderColor = System.Drawing.Color.Black;
            this.allRecords.BorderSize = 1;
            this.allRecords.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.allRecords.Checked = true;
            this.allRecords.CheckedBaseColor = System.Drawing.Color.Teal;
            this.allRecords.CheckedBorderColor = System.Drawing.Color.Black;
            this.allRecords.CheckedForeColor = System.Drawing.Color.White;
            this.allRecords.CheckedImage = null;
            this.allRecords.CheckedLineColor = System.Drawing.Color.DimGray;
            this.allRecords.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allRecords.FocusedColor = System.Drawing.Color.Empty;
            this.allRecords.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRecords.ForeColor = System.Drawing.Color.Black;
            this.allRecords.Image = null;
            this.allRecords.ImageSize = new System.Drawing.Size(20, 20);
            this.allRecords.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.allRecords.Location = new System.Drawing.Point(1097, 555);
            this.allRecords.Name = "allRecords";
            this.allRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.allRecords.OnHoverBorderColor = System.Drawing.Color.Black;
            this.allRecords.OnHoverForeColor = System.Drawing.Color.White;
            this.allRecords.OnHoverImage = null;
            this.allRecords.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.allRecords.OnPressedColor = System.Drawing.Color.Black;
            this.allRecords.Size = new System.Drawing.Size(152, 37);
            this.allRecords.TabIndex = 4;
            this.allRecords.Text = "All Records";
            this.allRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inactiveRecords
            // 
            this.inactiveRecords.Animated = true;
            this.inactiveRecords.AnimationHoverSpeed = 0.07F;
            this.inactiveRecords.AnimationSpeed = 0.03F;
            this.inactiveRecords.BackColor = System.Drawing.Color.Transparent;
            this.inactiveRecords.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.inactiveRecords.BorderColor = System.Drawing.Color.Black;
            this.inactiveRecords.BorderSize = 1;
            this.inactiveRecords.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.inactiveRecords.CheckedBaseColor = System.Drawing.Color.Teal;
            this.inactiveRecords.CheckedBorderColor = System.Drawing.Color.Black;
            this.inactiveRecords.CheckedForeColor = System.Drawing.Color.White;
            this.inactiveRecords.CheckedImage = null;
            this.inactiveRecords.CheckedLineColor = System.Drawing.Color.DimGray;
            this.inactiveRecords.DialogResult = System.Windows.Forms.DialogResult.None;
            this.inactiveRecords.FocusedColor = System.Drawing.Color.Empty;
            this.inactiveRecords.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveRecords.ForeColor = System.Drawing.Color.Black;
            this.inactiveRecords.Image = null;
            this.inactiveRecords.ImageSize = new System.Drawing.Size(20, 20);
            this.inactiveRecords.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inactiveRecords.Location = new System.Drawing.Point(948, 555);
            this.inactiveRecords.Name = "inactiveRecords";
            this.inactiveRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inactiveRecords.OnHoverBorderColor = System.Drawing.Color.Black;
            this.inactiveRecords.OnHoverForeColor = System.Drawing.Color.White;
            this.inactiveRecords.OnHoverImage = null;
            this.inactiveRecords.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inactiveRecords.OnPressedColor = System.Drawing.Color.Black;
            this.inactiveRecords.Size = new System.Drawing.Size(152, 37);
            this.inactiveRecords.TabIndex = 4;
            this.inactiveRecords.Text = "Only In-Active";
            this.inactiveRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activeRecords
            // 
            this.activeRecords.Animated = true;
            this.activeRecords.AnimationHoverSpeed = 0.07F;
            this.activeRecords.AnimationSpeed = 0.03F;
            this.activeRecords.BackColor = System.Drawing.Color.Transparent;
            this.activeRecords.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.activeRecords.BorderColor = System.Drawing.Color.Black;
            this.activeRecords.BorderSize = 1;
            this.activeRecords.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.activeRecords.CheckedBaseColor = System.Drawing.Color.Teal;
            this.activeRecords.CheckedBorderColor = System.Drawing.Color.Black;
            this.activeRecords.CheckedForeColor = System.Drawing.Color.White;
            this.activeRecords.CheckedImage = null;
            this.activeRecords.CheckedLineColor = System.Drawing.Color.DimGray;
            this.activeRecords.DialogResult = System.Windows.Forms.DialogResult.None;
            this.activeRecords.FocusedColor = System.Drawing.Color.Empty;
            this.activeRecords.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeRecords.ForeColor = System.Drawing.Color.Black;
            this.activeRecords.Image = null;
            this.activeRecords.ImageSize = new System.Drawing.Size(20, 20);
            this.activeRecords.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.activeRecords.Location = new System.Drawing.Point(799, 555);
            this.activeRecords.Name = "activeRecords";
            this.activeRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeRecords.OnHoverBorderColor = System.Drawing.Color.Black;
            this.activeRecords.OnHoverForeColor = System.Drawing.Color.White;
            this.activeRecords.OnHoverImage = null;
            this.activeRecords.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.activeRecords.OnPressedColor = System.Drawing.Color.Black;
            this.activeRecords.Size = new System.Drawing.Size(152, 37);
            this.activeRecords.TabIndex = 4;
            this.activeRecords.Text = "Only Active";
            this.activeRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.inactiveatePatient);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.activeRecords);
            this.Controls.Add(this.inactiveRecords);
            this.Controls.Add(this.allRecords);
            this.Controls.Add(this.updatePatients);
            this.Controls.Add(this.inactive);
            this.Controls.Add(this.active);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.description);
            this.Controls.Add(this.number);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgv);
            this.Name = "PatientsControl";
            this.Size = new System.Drawing.Size(1264, 623);
            this.Load += new System.EventHandler(this.PatientsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox patientId;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox firstname;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox lastname;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox age;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox number;
        private Guna.UI.WinForms.GunaTextBox description;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaRadioButton active;
        private Guna.UI.WinForms.GunaRadioButton inactive;
        private Guna.UI.WinForms.GunaAdvenceButton updatePatients;
        private Guna.UI.WinForms.GunaAdvenceButton inactiveatePatient;
        private Guna.UI.WinForms.GunaAdvenceButton addPatient;
        private System.Windows.Forms.Timer updater;
        private Guna.UI.WinForms.GunaPictureBox error1;
        private Guna.UI.WinForms.GunaPictureBox error2;
        private Guna.UI.WinForms.GunaPictureBox error3;
        private Guna.UI.WinForms.GunaPictureBox error4;
        private System.Windows.Forms.Timer errorDisplay;
        private Guna.UI.WinForms.GunaAdvenceButton clear;
        private Guna.UI.WinForms.GunaAdvenceButton allRecords;
        private Guna.UI.WinForms.GunaAdvenceButton inactiveRecords;
        private Guna.UI.WinForms.GunaAdvenceButton activeRecords;
    }
}
