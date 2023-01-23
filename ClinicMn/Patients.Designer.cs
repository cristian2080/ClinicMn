namespace ClinicMn
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.EditBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.AddBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.DelBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.PatAlTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PatHIVCb = new System.Windows.Forms.ComboBox();
            this.PatPhoneTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PatAddTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PatDOB = new System.Windows.Forms.DateTimePicker();
            this.PatGenCb = new System.Windows.Forms.ComboBox();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.PatientsDGV);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.DelBtn);
            this.panel1.Controls.Add(this.PatAlTb);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.PatHIVCb);
            this.panel1.Controls.Add(this.PatPhoneTb);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.PatAddTb);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PatDOB);
            this.panel1.Controls.Add(this.PatGenCb);
            this.panel1.Controls.Add(this.PatNameTb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 687);
            this.panel1.TabIndex = 1;
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.AllowUserToOrderColumns = true;
            this.PatientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.Location = new System.Drawing.Point(217, 401);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.Size = new System.Drawing.Size(1138, 283);
            this.PatientsDGV.TabIndex = 75;
            this.PatientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.AllowAnimations = true;
            this.EditBtn.AllowMouseEffects = true;
            this.EditBtn.AllowToggling = false;
            this.EditBtn.AnimationSpeed = 200;
            this.EditBtn.AutoGenerateColors = false;
            this.EditBtn.AutoRoundBorders = false;
            this.EditBtn.AutoSizeLeftIcon = true;
            this.EditBtn.AutoSizeRightIcon = true;
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.ButtonTextMarginLeft = 0;
            this.EditBtn.ColorContrastOnClick = 45;
            this.EditBtn.ColorContrastOnHover = 45;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.EditBtn.CustomizableEdges = borderEdges10;
            this.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EditBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EditBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.EditBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EditBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EditBtn.IconMarginLeft = 11;
            this.EditBtn.IconPadding = 10;
            this.EditBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EditBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EditBtn.IconSize = 25;
            this.EditBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.IdleBorderRadius = 10;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.EditBtn.IdleIconLeftImage = null;
            this.EditBtn.IdleIconRightImage = null;
            this.EditBtn.IndicateFocus = false;
            this.EditBtn.Location = new System.Drawing.Point(982, 324);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EditBtn.OnDisabledState.BorderRadius = 10;
            this.EditBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.EditBtn.OnDisabledState.BorderThickness = 1;
            this.EditBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EditBtn.OnDisabledState.IconLeftImage = null;
            this.EditBtn.OnDisabledState.IconRightImage = null;
            this.EditBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.EditBtn.onHoverState.BorderRadius = 10;
            this.EditBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.EditBtn.onHoverState.BorderThickness = 1;
            this.EditBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.EditBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.onHoverState.IconLeftImage = null;
            this.EditBtn.onHoverState.IconRightImage = null;
            this.EditBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.OnIdleState.BorderRadius = 10;
            this.EditBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.EditBtn.OnIdleState.BorderThickness = 1;
            this.EditBtn.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.EditBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.OnIdleState.IconLeftImage = null;
            this.EditBtn.OnIdleState.IconRightImage = null;
            this.EditBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EditBtn.OnPressedState.BorderRadius = 10;
            this.EditBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.EditBtn.OnPressedState.BorderThickness = 1;
            this.EditBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EditBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.OnPressedState.IconLeftImage = null;
            this.EditBtn.OnPressedState.IconRightImage = null;
            this.EditBtn.Size = new System.Drawing.Size(150, 39);
            this.EditBtn.TabIndex = 21;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditBtn.TextMarginLeft = 0;
            this.EditBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.EditBtn.UseDefaultRadiusAndThickness = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AllowAnimations = true;
            this.AddBtn.AllowMouseEffects = true;
            this.AddBtn.AllowToggling = false;
            this.AddBtn.AnimationSpeed = 200;
            this.AddBtn.AutoGenerateColors = false;
            this.AddBtn.AutoRoundBorders = false;
            this.AddBtn.AutoSizeLeftIcon = true;
            this.AddBtn.AutoSizeRightIcon = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BackColor1 = System.Drawing.Color.Black;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.AddBtn.ButtonText = "Add";
            this.AddBtn.ButtonTextMarginLeft = 0;
            this.AddBtn.ColorContrastOnClick = 45;
            this.AddBtn.ColorContrastOnHover = 45;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.AddBtn.CustomizableEdges = borderEdges11;
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.AddBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddBtn.IconMarginLeft = 11;
            this.AddBtn.IconPadding = 10;
            this.AddBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddBtn.IconSize = 25;
            this.AddBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.IdleBorderRadius = 10;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleFillColor = System.Drawing.Color.Black;
            this.AddBtn.IdleIconLeftImage = null;
            this.AddBtn.IdleIconRightImage = null;
            this.AddBtn.IndicateFocus = false;
            this.AddBtn.Location = new System.Drawing.Point(740, 324);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddBtn.OnDisabledState.BorderRadius = 10;
            this.AddBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.AddBtn.OnDisabledState.BorderThickness = 1;
            this.AddBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddBtn.OnDisabledState.IconLeftImage = null;
            this.AddBtn.OnDisabledState.IconRightImage = null;
            this.AddBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddBtn.onHoverState.BorderRadius = 10;
            this.AddBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.AddBtn.onHoverState.BorderThickness = 1;
            this.AddBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddBtn.onHoverState.IconLeftImage = null;
            this.AddBtn.onHoverState.IconRightImage = null;
            this.AddBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.OnIdleState.BorderRadius = 10;
            this.AddBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.AddBtn.OnIdleState.BorderThickness = 1;
            this.AddBtn.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.AddBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddBtn.OnIdleState.IconLeftImage = null;
            this.AddBtn.OnIdleState.IconRightImage = null;
            this.AddBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddBtn.OnPressedState.BorderRadius = 10;
            this.AddBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.AddBtn.OnPressedState.BorderThickness = 1;
            this.AddBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddBtn.OnPressedState.IconLeftImage = null;
            this.AddBtn.OnPressedState.IconRightImage = null;
            this.AddBtn.Size = new System.Drawing.Size(150, 39);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddBtn.TextMarginLeft = 0;
            this.AddBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddBtn.UseDefaultRadiusAndThickness = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.AllowAnimations = true;
            this.DelBtn.AllowMouseEffects = true;
            this.DelBtn.AllowToggling = false;
            this.DelBtn.AnimationSpeed = 200;
            this.DelBtn.AutoGenerateColors = false;
            this.DelBtn.AutoRoundBorders = false;
            this.DelBtn.AutoSizeLeftIcon = true;
            this.DelBtn.AutoSizeRightIcon = true;
            this.DelBtn.BackColor = System.Drawing.Color.Transparent;
            this.DelBtn.BackColor1 = System.Drawing.Color.Red;
            this.DelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelBtn.BackgroundImage")));
            this.DelBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.DelBtn.ButtonText = "Delete";
            this.DelBtn.ButtonTextMarginLeft = 0;
            this.DelBtn.ColorContrastOnClick = 45;
            this.DelBtn.ColorContrastOnHover = 45;
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.DelBtn.CustomizableEdges = borderEdges12;
            this.DelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DelBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DelBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DelBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.DelBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DelBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DelBtn.IconMarginLeft = 11;
            this.DelBtn.IconPadding = 10;
            this.DelBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DelBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DelBtn.IconSize = 25;
            this.DelBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.DelBtn.IdleBorderRadius = 10;
            this.DelBtn.IdleBorderThickness = 1;
            this.DelBtn.IdleFillColor = System.Drawing.Color.Red;
            this.DelBtn.IdleIconLeftImage = null;
            this.DelBtn.IdleIconRightImage = null;
            this.DelBtn.IndicateFocus = false;
            this.DelBtn.Location = new System.Drawing.Point(499, 324);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DelBtn.OnDisabledState.BorderRadius = 10;
            this.DelBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.DelBtn.OnDisabledState.BorderThickness = 1;
            this.DelBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DelBtn.OnDisabledState.IconLeftImage = null;
            this.DelBtn.OnDisabledState.IconRightImage = null;
            this.DelBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DelBtn.onHoverState.BorderRadius = 10;
            this.DelBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.DelBtn.onHoverState.BorderThickness = 1;
            this.DelBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DelBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DelBtn.onHoverState.IconLeftImage = null;
            this.DelBtn.onHoverState.IconRightImage = null;
            this.DelBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DelBtn.OnIdleState.BorderRadius = 10;
            this.DelBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.DelBtn.OnIdleState.BorderThickness = 1;
            this.DelBtn.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.DelBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DelBtn.OnIdleState.IconLeftImage = null;
            this.DelBtn.OnIdleState.IconRightImage = null;
            this.DelBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DelBtn.OnPressedState.BorderRadius = 10;
            this.DelBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.DelBtn.OnPressedState.BorderThickness = 1;
            this.DelBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DelBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DelBtn.OnPressedState.IconLeftImage = null;
            this.DelBtn.OnPressedState.IconRightImage = null;
            this.DelBtn.Size = new System.Drawing.Size(150, 39);
            this.DelBtn.TabIndex = 19;
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelBtn.TextMarginLeft = 0;
            this.DelBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.DelBtn.UseDefaultRadiusAndThickness = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // PatAlTb
            // 
            this.PatAlTb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAlTb.Location = new System.Drawing.Point(810, 158);
            this.PatAlTb.Multiline = true;
            this.PatAlTb.Name = "PatAlTb";
            this.PatAlTb.Size = new System.Drawing.Size(221, 76);
            this.PatAlTb.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(806, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 22);
            this.label17.TabIndex = 17;
            this.label17.Text = "Allergies";
            // 
            // PatHIVCb
            // 
            this.PatHIVCb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatHIVCb.FormattingEnabled = true;
            this.PatHIVCb.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.PatHIVCb.Location = new System.Drawing.Point(633, 156);
            this.PatHIVCb.Name = "PatHIVCb";
            this.PatHIVCb.Size = new System.Drawing.Size(112, 26);
            this.PatHIVCb.TabIndex = 16;
            this.PatHIVCb.Text = "HIV";
            // 
            // PatPhoneTb
            // 
            this.PatPhoneTb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhoneTb.Location = new System.Drawing.Point(499, 223);
            this.PatPhoneTb.Name = "PatPhoneTb";
            this.PatPhoneTb.Size = new System.Drawing.Size(221, 26);
            this.PatPhoneTb.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(495, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 22);
            this.label16.TabIndex = 14;
            this.label16.Text = "Phone";
            // 
            // PatAddTb
            // 
            this.PatAddTb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddTb.Location = new System.Drawing.Point(1071, 158);
            this.PatAddTb.Multiline = true;
            this.PatAddTb.Name = "PatAddTb";
            this.PatAddTb.Size = new System.Drawing.Size(221, 76);
            this.PatAddTb.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(1067, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(240, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "DOB";
            // 
            // PatDOB
            // 
            this.PatDOB.Location = new System.Drawing.Point(244, 223);
            this.PatDOB.Name = "PatDOB";
            this.PatDOB.Size = new System.Drawing.Size(221, 26);
            this.PatDOB.TabIndex = 10;
            // 
            // PatGenCb
            // 
            this.PatGenCb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGenCb.FormattingEnabled = true;
            this.PatGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGenCb.Location = new System.Drawing.Point(499, 158);
            this.PatGenCb.Name = "PatGenCb";
            this.PatGenCb.Size = new System.Drawing.Size(112, 26);
            this.PatGenCb.TabIndex = 9;
            this.PatGenCb.Text = "Gender";
            // 
            // PatNameTb
            // 
            this.PatNameTb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.Location = new System.Drawing.Point(244, 158);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(221, 26);
            this.PatNameTb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(240, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Patient Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1332, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(672, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clinic";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 687);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(80, 620);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Logout";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(16, 601);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(54, 54);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(76, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Receptionists";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(16, 356);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(54, 54);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(77, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Laboratory";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(16, 269);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(54, 58);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(80, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Doctors";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(16, 198);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(54, 49);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(16, 115);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 58);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Home";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 687);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox PatGenCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker PatDOB;
        private System.Windows.Forms.TextBox PatAlTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox PatHIVCb;
        private System.Windows.Forms.TextBox PatPhoneTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PatAddTb;
        private System.Windows.Forms.Label label15;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 EditBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 DelBtn;
        private System.Windows.Forms.DataGridView PatientsDGV;
    }
}