namespace Pharmacy_System
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            btn_add = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            lable_ava = new Label();
            dgv_bill = new Bunifu.UI.WinForms.BunifuDataGridView();
            medId = new DataGridViewTextBoxColumn();
            MedName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            medcombo_box = new ComboBox();
            txt_quantity = new Bunifu.UI.WinForms.BunifuTextBox();
            txt_totalAmu = new Bunifu.UI.WinForms.BunifuLabel();
            btn_print = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btn_back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)dgv_bill).BeginInit();
            SuspendLayout();
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuLabel1.ForeColor = Color.DarkRed;
            bunifuLabel1.Location = new Point(12, 22);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(145, 35);
            bunifuLabel1.TabIndex = 32;
            bunifuLabel1.Text = "Billing Form";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_add
            // 
            btn_add.AllowAnimations = true;
            btn_add.AllowMouseEffects = true;
            btn_add.AllowToggling = false;
            btn_add.AnimationSpeed = 200;
            btn_add.AutoGenerateColors = false;
            btn_add.AutoRoundBorders = false;
            btn_add.AutoSizeLeftIcon = true;
            btn_add.AutoSizeRightIcon = true;
            btn_add.BackColor = Color.Transparent;
            btn_add.BackColor1 = Color.Maroon;
            btn_add.BackgroundImage = (Image)resources.GetObject("btn_add.BackgroundImage");
            btn_add.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_add.ButtonText = "Add";
            btn_add.ButtonTextMarginLeft = 0;
            btn_add.ColorContrastOnClick = 45;
            btn_add.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btn_add.CustomizableEdges = borderEdges1;
            btn_add.DialogResult = DialogResult.None;
            btn_add.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btn_add.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btn_add.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btn_add.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.IconLeftAlign = ContentAlignment.MiddleLeft;
            btn_add.IconLeftCursor = Cursors.Default;
            btn_add.IconLeftPadding = new Padding(11, 3, 3, 3);
            btn_add.IconMarginLeft = 11;
            btn_add.IconPadding = 10;
            btn_add.IconRightAlign = ContentAlignment.MiddleRight;
            btn_add.IconRightCursor = Cursors.Default;
            btn_add.IconRightPadding = new Padding(3, 3, 7, 3);
            btn_add.IconSize = 25;
            btn_add.IdleBorderColor = Color.DodgerBlue;
            btn_add.IdleBorderRadius = 1;
            btn_add.IdleBorderThickness = 1;
            btn_add.IdleFillColor = Color.Maroon;
            btn_add.IdleIconLeftImage = null;
            btn_add.IdleIconRightImage = null;
            btn_add.IndicateFocus = false;
            btn_add.Location = new Point(44, 287);
            btn_add.Name = "btn_add";
            btn_add.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btn_add.OnDisabledState.BorderRadius = 1;
            btn_add.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_add.OnDisabledState.BorderThickness = 1;
            btn_add.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btn_add.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btn_add.OnDisabledState.IconLeftImage = null;
            btn_add.OnDisabledState.IconRightImage = null;
            btn_add.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            btn_add.onHoverState.BorderRadius = 1;
            btn_add.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_add.onHoverState.BorderThickness = 1;
            btn_add.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            btn_add.onHoverState.ForeColor = Color.White;
            btn_add.onHoverState.IconLeftImage = null;
            btn_add.onHoverState.IconRightImage = null;
            btn_add.OnIdleState.BorderColor = Color.DodgerBlue;
            btn_add.OnIdleState.BorderRadius = 1;
            btn_add.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_add.OnIdleState.BorderThickness = 1;
            btn_add.OnIdleState.FillColor = Color.Maroon;
            btn_add.OnIdleState.ForeColor = Color.White;
            btn_add.OnIdleState.IconLeftImage = null;
            btn_add.OnIdleState.IconRightImage = null;
            btn_add.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btn_add.OnPressedState.BorderRadius = 1;
            btn_add.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_add.OnPressedState.BorderThickness = 1;
            btn_add.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btn_add.OnPressedState.ForeColor = Color.White;
            btn_add.OnPressedState.IconLeftImage = null;
            btn_add.OnPressedState.IconRightImage = null;
            btn_add.Size = new Size(126, 49);
            btn_add.TabIndex = 38;
            btn_add.TextAlign = ContentAlignment.MiddleCenter;
            btn_add.TextAlignment = HorizontalAlignment.Center;
            btn_add.TextMarginLeft = 0;
            btn_add.TextPadding = new Padding(0);
            btn_add.UseDefaultRadiusAndThickness = true;
            btn_add.Click += btn_add_Click;
            // 
            // lable_ava
            // 
            lable_ava.AutoSize = true;
            lable_ava.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lable_ava.Location = new Point(44, 145);
            lable_ava.Name = "lable_ava";
            lable_ava.Size = new Size(129, 23);
            lable_ava.TabIndex = 39;
            lable_ava.Text = "AvaliableStock";
            // 
            // dgv_bill
            // 
            dgv_bill.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_bill.BorderStyle = BorderStyle.None;
            dgv_bill.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_bill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_bill.ColumnHeadersHeight = 40;
            dgv_bill.Columns.AddRange(new DataGridViewColumn[] { medId, MedName, Quantity, UnitPrice, TotalPrice });
            dgv_bill.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgv_bill.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dgv_bill.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgv_bill.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgv_bill.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgv_bill.CurrentTheme.BackColor = Color.White;
            dgv_bill.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgv_bill.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgv_bill.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            dgv_bill.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgv_bill.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgv_bill.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgv_bill.CurrentTheme.Name = null;
            dgv_bill.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgv_bill.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dgv_bill.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgv_bill.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgv_bill.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_bill.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_bill.EnableHeadersVisualStyles = false;
            dgv_bill.GridColor = Color.FromArgb(221, 238, 255);
            dgv_bill.HeaderBackColor = Color.DodgerBlue;
            dgv_bill.HeaderBgColor = Color.Empty;
            dgv_bill.HeaderForeColor = Color.White;
            dgv_bill.Location = new Point(263, 1);
            dgv_bill.Name = "dgv_bill";
            dgv_bill.RowHeadersVisible = false;
            dgv_bill.RowHeadersWidth = 51;
            dgv_bill.RowTemplate.Height = 40;
            dgv_bill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bill.Size = new Size(650, 364);
            dgv_bill.TabIndex = 41;
            dgv_bill.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // medId
            // 
            medId.HeaderText = "medId";
            medId.MinimumWidth = 6;
            medId.Name = "medId";
            // 
            // MedName
            // 
            MedName.HeaderText = "MedName";
            MedName.MinimumWidth = 6;
            MedName.Name = "MedName";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            // 
            // medcombo_box
            // 
            medcombo_box.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            medcombo_box.FormattingEnabled = true;
            medcombo_box.Location = new Point(30, 77);
            medcombo_box.Name = "medcombo_box";
            medcombo_box.Size = new Size(151, 31);
            medcombo_box.TabIndex = 42;
            medcombo_box.SelectionChangeCommitted += medcombo_box_SelectionChangeCommitted;
            // 
            // txt_quantity
            // 
            txt_quantity.AcceptsReturn = false;
            txt_quantity.AcceptsTab = false;
            txt_quantity.AnimationSpeed = 200;
            txt_quantity.AutoCompleteMode = AutoCompleteMode.None;
            txt_quantity.AutoCompleteSource = AutoCompleteSource.None;
            txt_quantity.AutoSizeHeight = true;
            txt_quantity.BackColor = Color.Transparent;
            txt_quantity.BackgroundImage = (Image)resources.GetObject("txt_quantity.BackgroundImage");
            txt_quantity.BorderColorActive = Color.DodgerBlue;
            txt_quantity.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txt_quantity.BorderColorHover = Color.FromArgb(64, 0, 0);
            txt_quantity.BorderColorIdle = Color.Silver;
            txt_quantity.BorderRadius = 1;
            txt_quantity.BorderThickness = 1;
            txt_quantity.CharacterCasing = CharacterCasing.Normal;
            txt_quantity.DefaultFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_quantity.DefaultText = "";
            txt_quantity.FillColor = Color.White;
            txt_quantity.HideSelection = true;
            txt_quantity.IconLeft = null;
            txt_quantity.IconLeftCursor = Cursors.IBeam;
            txt_quantity.IconPadding = 10;
            txt_quantity.IconRight = null;
            txt_quantity.IconRightCursor = Cursors.IBeam;
            txt_quantity.Location = new Point(30, 204);
            txt_quantity.MaxLength = 32767;
            txt_quantity.MinimumSize = new Size(1, 1);
            txt_quantity.Modified = false;
            txt_quantity.Multiline = false;
            txt_quantity.Name = "txt_quantity";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txt_quantity.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txt_quantity.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(64, 0, 0);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txt_quantity.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txt_quantity.OnIdleState = stateProperties4;
            txt_quantity.Padding = new Padding(3);
            txt_quantity.PasswordChar = '\0';
            txt_quantity.PlaceholderForeColor = Color.Maroon;
            txt_quantity.PlaceholderText = "Quantity";
            txt_quantity.ReadOnly = false;
            txt_quantity.ScrollBars = ScrollBars.None;
            txt_quantity.SelectedText = "";
            txt_quantity.SelectionLength = 0;
            txt_quantity.SelectionStart = 0;
            txt_quantity.ShortcutsEnabled = true;
            txt_quantity.Size = new Size(176, 42);
            txt_quantity.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txt_quantity.TabIndex = 43;
            txt_quantity.TextAlign = HorizontalAlignment.Left;
            txt_quantity.TextMarginBottom = 0;
            txt_quantity.TextMarginLeft = 3;
            txt_quantity.TextMarginTop = 1;
            txt_quantity.TextPlaceholder = "Quantity";
            txt_quantity.UseSystemPasswordChar = false;
            txt_quantity.WordWrap = true;
            // 
            // txt_totalAmu
            // 
            txt_totalAmu.AllowParentOverrides = false;
            txt_totalAmu.AutoEllipsis = false;
            txt_totalAmu.CursorType = Cursors.Default;
            txt_totalAmu.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt_totalAmu.ForeColor = Color.DarkRed;
            txt_totalAmu.Location = new Point(698, 371);
            txt_totalAmu.Name = "txt_totalAmu";
            txt_totalAmu.RightToLeft = RightToLeft.No;
            txt_totalAmu.Size = new Size(159, 35);
            txt_totalAmu.TabIndex = 44;
            txt_totalAmu.Text = "Total Amount";
            txt_totalAmu.TextAlignment = ContentAlignment.TopLeft;
            txt_totalAmu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_print
            // 
            btn_print.AllowAnimations = true;
            btn_print.AllowMouseEffects = true;
            btn_print.AllowToggling = false;
            btn_print.AnimationSpeed = 200;
            btn_print.AutoGenerateColors = false;
            btn_print.AutoRoundBorders = false;
            btn_print.AutoSizeLeftIcon = true;
            btn_print.AutoSizeRightIcon = true;
            btn_print.BackColor = Color.Transparent;
            btn_print.BackColor1 = Color.Maroon;
            btn_print.BackgroundImage = (Image)resources.GetObject("btn_print.BackgroundImage");
            btn_print.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_print.ButtonText = "Print Bill";
            btn_print.ButtonTextMarginLeft = 0;
            btn_print.ColorContrastOnClick = 45;
            btn_print.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btn_print.CustomizableEdges = borderEdges2;
            btn_print.DialogResult = DialogResult.None;
            btn_print.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btn_print.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btn_print.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btn_print.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btn_print.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_print.ForeColor = Color.White;
            btn_print.IconLeftAlign = ContentAlignment.MiddleLeft;
            btn_print.IconLeftCursor = Cursors.Default;
            btn_print.IconLeftPadding = new Padding(11, 3, 3, 3);
            btn_print.IconMarginLeft = 11;
            btn_print.IconPadding = 10;
            btn_print.IconRightAlign = ContentAlignment.MiddleRight;
            btn_print.IconRightCursor = Cursors.Default;
            btn_print.IconRightPadding = new Padding(3, 3, 7, 3);
            btn_print.IconSize = 25;
            btn_print.IdleBorderColor = Color.DodgerBlue;
            btn_print.IdleBorderRadius = 1;
            btn_print.IdleBorderThickness = 1;
            btn_print.IdleFillColor = Color.Maroon;
            btn_print.IdleIconLeftImage = null;
            btn_print.IdleIconRightImage = null;
            btn_print.IndicateFocus = false;
            btn_print.Location = new Point(494, 406);
            btn_print.Name = "btn_print";
            btn_print.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btn_print.OnDisabledState.BorderRadius = 1;
            btn_print.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_print.OnDisabledState.BorderThickness = 1;
            btn_print.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btn_print.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btn_print.OnDisabledState.IconLeftImage = null;
            btn_print.OnDisabledState.IconRightImage = null;
            btn_print.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            btn_print.onHoverState.BorderRadius = 1;
            btn_print.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_print.onHoverState.BorderThickness = 1;
            btn_print.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            btn_print.onHoverState.ForeColor = Color.White;
            btn_print.onHoverState.IconLeftImage = null;
            btn_print.onHoverState.IconRightImage = null;
            btn_print.OnIdleState.BorderColor = Color.DodgerBlue;
            btn_print.OnIdleState.BorderRadius = 1;
            btn_print.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_print.OnIdleState.BorderThickness = 1;
            btn_print.OnIdleState.FillColor = Color.Maroon;
            btn_print.OnIdleState.ForeColor = Color.White;
            btn_print.OnIdleState.IconLeftImage = null;
            btn_print.OnIdleState.IconRightImage = null;
            btn_print.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btn_print.OnPressedState.BorderRadius = 1;
            btn_print.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_print.OnPressedState.BorderThickness = 1;
            btn_print.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btn_print.OnPressedState.ForeColor = Color.White;
            btn_print.OnPressedState.IconLeftImage = null;
            btn_print.OnPressedState.IconRightImage = null;
            btn_print.Size = new Size(140, 49);
            btn_print.TabIndex = 45;
            btn_print.TextAlign = ContentAlignment.MiddleCenter;
            btn_print.TextAlignment = HorizontalAlignment.Center;
            btn_print.TextMarginLeft = 0;
            btn_print.TextPadding = new Padding(0);
            btn_print.UseDefaultRadiusAndThickness = true;
            btn_print.Click += btn_print_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btn_back
            // 
            btn_back.AllowAnimations = true;
            btn_back.AllowMouseEffects = true;
            btn_back.AllowToggling = false;
            btn_back.AnimationSpeed = 200;
            btn_back.AutoGenerateColors = false;
            btn_back.AutoRoundBorders = false;
            btn_back.AutoSizeLeftIcon = true;
            btn_back.AutoSizeRightIcon = true;
            btn_back.BackColor = Color.Transparent;
            btn_back.BackColor1 = Color.Maroon;
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_back.ButtonText = "Back";
            btn_back.ButtonTextMarginLeft = 0;
            btn_back.ColorContrastOnClick = 45;
            btn_back.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btn_back.CustomizableEdges = borderEdges3;
            btn_back.DialogResult = DialogResult.None;
            btn_back.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btn_back.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btn_back.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btn_back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btn_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.IconLeftAlign = ContentAlignment.MiddleLeft;
            btn_back.IconLeftCursor = Cursors.Default;
            btn_back.IconLeftPadding = new Padding(11, 3, 3, 3);
            btn_back.IconMarginLeft = 11;
            btn_back.IconPadding = 10;
            btn_back.IconRightAlign = ContentAlignment.MiddleRight;
            btn_back.IconRightCursor = Cursors.Default;
            btn_back.IconRightPadding = new Padding(3, 3, 7, 3);
            btn_back.IconSize = 25;
            btn_back.IdleBorderColor = Color.DodgerBlue;
            btn_back.IdleBorderRadius = 1;
            btn_back.IdleBorderThickness = 1;
            btn_back.IdleFillColor = Color.Maroon;
            btn_back.IdleIconLeftImage = null;
            btn_back.IdleIconRightImage = null;
            btn_back.IndicateFocus = false;
            btn_back.Location = new Point(263, 406);
            btn_back.Name = "btn_back";
            btn_back.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btn_back.OnDisabledState.BorderRadius = 1;
            btn_back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_back.OnDisabledState.BorderThickness = 1;
            btn_back.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btn_back.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btn_back.OnDisabledState.IconLeftImage = null;
            btn_back.OnDisabledState.IconRightImage = null;
            btn_back.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            btn_back.onHoverState.BorderRadius = 1;
            btn_back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_back.onHoverState.BorderThickness = 1;
            btn_back.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            btn_back.onHoverState.ForeColor = Color.White;
            btn_back.onHoverState.IconLeftImage = null;
            btn_back.onHoverState.IconRightImage = null;
            btn_back.OnIdleState.BorderColor = Color.DodgerBlue;
            btn_back.OnIdleState.BorderRadius = 1;
            btn_back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_back.OnIdleState.BorderThickness = 1;
            btn_back.OnIdleState.FillColor = Color.Maroon;
            btn_back.OnIdleState.ForeColor = Color.White;
            btn_back.OnIdleState.IconLeftImage = null;
            btn_back.OnIdleState.IconRightImage = null;
            btn_back.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btn_back.OnPressedState.BorderRadius = 1;
            btn_back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btn_back.OnPressedState.BorderThickness = 1;
            btn_back.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btn_back.OnPressedState.ForeColor = Color.White;
            btn_back.OnPressedState.IconLeftImage = null;
            btn_back.OnPressedState.IconRightImage = null;
            btn_back.Size = new Size(126, 49);
            btn_back.TabIndex = 46;
            btn_back.TextAlign = ContentAlignment.MiddleCenter;
            btn_back.TextAlignment = HorizontalAlignment.Center;
            btn_back.TextMarginLeft = 0;
            btn_back.TextPadding = new Padding(0);
            btn_back.UseDefaultRadiusAndThickness = true;
            btn_back.Click += btn_back_Click;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 536);
            Controls.Add(btn_back);
            Controls.Add(btn_print);
            Controls.Add(txt_totalAmu);
            Controls.Add(txt_quantity);
            Controls.Add(medcombo_box);
            Controls.Add(dgv_bill);
            Controls.Add(lable_ava);
            Controls.Add(btn_add);
            Controls.Add(bunifuLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillForm";
            Text = "BillForm";
            Load += BillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_add;
        private Label lable_ava;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_bill;
        private ComboBox medcombo_box;
        private Bunifu.UI.WinForms.BunifuTextBox txt_quantity;
        private DataGridViewTextBoxColumn medId;
        private DataGridViewTextBoxColumn MedName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private Bunifu.UI.WinForms.BunifuLabel txt_totalAmu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_print;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_back;
    }
}