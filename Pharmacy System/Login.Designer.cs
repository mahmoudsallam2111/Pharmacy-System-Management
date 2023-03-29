namespace Pharmacy_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Username = new Bunifu.UI.WinForms.BunifuTextBox();
            password = new Bunifu.UI.WinForms.BunifuTextBox();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AcceptsReturn = false;
            Username.AcceptsTab = false;
            Username.AnimationSpeed = 200;
            Username.AutoCompleteMode = AutoCompleteMode.None;
            Username.AutoCompleteSource = AutoCompleteSource.None;
            Username.AutoSizeHeight = true;
            Username.BackColor = Color.Transparent;
            Username.BackgroundImage = (Image)resources.GetObject("Username.BackgroundImage");
            Username.BorderColorActive = Color.FromArgb(0, 192, 192);
            Username.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Username.BorderColorHover = Color.FromArgb(64, 0, 0);
            Username.BorderColorIdle = Color.Silver;
            Username.BorderRadius = 1;
            Username.BorderThickness = 3;
            Username.CharacterCasing = CharacterCasing.Normal;
            Username.DefaultFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Username.DefaultText = "";
            Username.FillColor = Color.White;
            Username.ForeColor = Color.Black;
            Username.HideSelection = true;
            Username.IconLeft = null;
            Username.IconLeftCursor = Cursors.IBeam;
            Username.IconPadding = 10;
            Username.IconRight = null;
            Username.IconRightCursor = Cursors.IBeam;
            Username.Location = new Point(40, 133);
            Username.MaxLength = 32767;
            Username.MinimumSize = new Size(1, 1);
            Username.Modified = false;
            Username.Multiline = false;
            Username.Name = "Username";
            stateProperties1.BorderColor = Color.FromArgb(0, 192, 192);
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            Username.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            Username.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(64, 0, 0);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            Username.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Black;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            Username.OnIdleState = stateProperties4;
            Username.Padding = new Padding(3);
            Username.PasswordChar = '\0';
            Username.PlaceholderForeColor = Color.Silver;
            Username.PlaceholderText = "username";
            Username.ReadOnly = false;
            Username.ScrollBars = ScrollBars.None;
            Username.SelectedText = "";
            Username.SelectionLength = 0;
            Username.SelectionStart = 0;
            Username.ShortcutsEnabled = true;
            Username.Size = new Size(296, 58);
            Username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Username.TabIndex = 0;
            Username.TextAlign = HorizontalAlignment.Left;
            Username.TextMarginBottom = 0;
            Username.TextMarginLeft = 3;
            Username.TextMarginTop = 1;
            Username.TextPlaceholder = "username";
            Username.UseSystemPasswordChar = false;
            Username.WordWrap = true;
            // 
            // password
            // 
            password.AcceptsReturn = false;
            password.AcceptsTab = false;
            password.AnimationSpeed = 200;
            password.AutoCompleteMode = AutoCompleteMode.None;
            password.AutoCompleteSource = AutoCompleteSource.None;
            password.AutoSizeHeight = true;
            password.BackColor = Color.Transparent;
            password.BackgroundImage = (Image)resources.GetObject("password.BackgroundImage");
            password.BorderColorActive = Color.DodgerBlue;
            password.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            password.BorderColorHover = Color.FromArgb(64, 0, 0);
            password.BorderColorIdle = Color.Silver;
            password.BorderRadius = 1;
            password.BorderThickness = 3;
            password.CharacterCasing = CharacterCasing.Normal;
            password.DefaultFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            password.DefaultText = "";
            password.FillColor = Color.White;
            password.ForeColor = Color.Black;
            password.HideSelection = true;
            password.IconLeft = null;
            password.IconLeftCursor = Cursors.IBeam;
            password.IconPadding = 10;
            password.IconRight = null;
            password.IconRightCursor = Cursors.IBeam;
            password.Location = new Point(40, 224);
            password.MaxLength = 32767;
            password.MinimumSize = new Size(1, 1);
            password.Modified = false;
            password.Multiline = false;
            password.Name = "password";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            password.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            password.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(64, 0, 0);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            password.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Black;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            password.OnIdleState = stateProperties8;
            password.Padding = new Padding(3);
            password.PasswordChar = '\0';
            password.PlaceholderForeColor = Color.Gray;
            password.PlaceholderText = "Password";
            password.ReadOnly = false;
            password.ScrollBars = ScrollBars.None;
            password.SelectedText = "";
            password.SelectionLength = 0;
            password.SelectionStart = 0;
            password.ShortcutsEnabled = true;
            password.Size = new Size(296, 58);
            password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            password.TabIndex = 1;
            password.TextAlign = HorizontalAlignment.Left;
            password.TextMarginBottom = 0;
            password.TextMarginLeft = 3;
            password.TextMarginTop = 1;
            password.TextPlaceholder = "Password";
            password.UseSystemPasswordChar = true;
            password.WordWrap = true;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuLabel1.ForeColor = Color.White;
            bunifuLabel1.Location = new Point(155, 43);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(86, 45);
            bunifuLabel1.TabIndex = 2;
            bunifuLabel1.Text = "Login";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_login
            // 
            btn_login.AllowAnimations = true;
            btn_login.AllowMouseEffects = true;
            btn_login.AllowToggling = false;
            btn_login.AnimationSpeed = 200;
            btn_login.AutoGenerateColors = false;
            btn_login.AutoRoundBorders = false;
            btn_login.AutoSizeLeftIcon = true;
            btn_login.AutoSizeRightIcon = true;
            btn_login.BackColor = Color.Transparent;
            btn_login.BackColor1 = Color.FromArgb(51, 122, 183);
            btn_login.BackgroundImage = (Image)resources.GetObject("btn_login.BackgroundImage");
            btn_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btn_login.ButtonText = "Login";
            btn_login.ButtonTextMarginLeft = 0;
            btn_login.ColorContrastOnClick = 45;
            btn_login.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btn_login.CustomizableEdges = borderEdges1;
            btn_login.DialogResult = DialogResult.None;
            btn_login.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btn_login.DisabledFillColor = Color.Empty;
            btn_login.DisabledForecolor = Color.Empty;
            btn_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btn_login.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.IconLeft = null;
            btn_login.IconLeftAlign = ContentAlignment.MiddleLeft;
            btn_login.IconLeftCursor = Cursors.Default;
            btn_login.IconLeftPadding = new Padding(11, 3, 3, 3);
            btn_login.IconMarginLeft = 11;
            btn_login.IconPadding = 10;
            btn_login.IconRight = null;
            btn_login.IconRightAlign = ContentAlignment.MiddleRight;
            btn_login.IconRightCursor = Cursors.Default;
            btn_login.IconRightPadding = new Padding(3, 3, 7, 3);
            btn_login.IconSize = 25;
            btn_login.IdleBorderColor = Color.Empty;
            btn_login.IdleBorderRadius = 0;
            btn_login.IdleBorderThickness = 0;
            btn_login.IdleFillColor = Color.Empty;
            btn_login.IdleIconLeftImage = null;
            btn_login.IdleIconRightImage = null;
            btn_login.IndicateFocus = false;
            btn_login.Location = new Point(98, 315);
            btn_login.Name = "btn_login";
            btn_login.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btn_login.OnDisabledState.BorderRadius = 1;
            btn_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btn_login.OnDisabledState.BorderThickness = 1;
            btn_login.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btn_login.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btn_login.OnDisabledState.IconLeftImage = null;
            btn_login.OnDisabledState.IconRightImage = null;
            btn_login.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btn_login.onHoverState.BorderRadius = 1;
            btn_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btn_login.onHoverState.BorderThickness = 1;
            btn_login.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btn_login.onHoverState.ForeColor = Color.White;
            btn_login.onHoverState.IconLeftImage = null;
            btn_login.onHoverState.IconRightImage = null;
            btn_login.OnIdleState.BorderColor = Color.DodgerBlue;
            btn_login.OnIdleState.BorderRadius = 1;
            btn_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btn_login.OnIdleState.BorderThickness = 1;
            btn_login.OnIdleState.FillColor = Color.DodgerBlue;
            btn_login.OnIdleState.ForeColor = Color.White;
            btn_login.OnIdleState.IconLeftImage = null;
            btn_login.OnIdleState.IconRightImage = null;
            btn_login.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btn_login.OnPressedState.BorderRadius = 1;
            btn_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btn_login.OnPressedState.BorderThickness = 1;
            btn_login.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btn_login.OnPressedState.ForeColor = Color.White;
            btn_login.OnPressedState.IconLeftImage = null;
            btn_login.OnPressedState.IconRightImage = null;
            btn_login.Size = new Size(188, 49);
            btn_login.TabIndex = 3;
            btn_login.TextAlign = ContentAlignment.MiddleCenter;
            btn_login.TextAlignment = HorizontalAlignment.Center;
            btn_login.TextMarginLeft = 0;
            btn_login.TextPadding = new Padding(0);
            btn_login.UseDefaultRadiusAndThickness = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(393, 429);
            Controls.Add(btn_login);
            Controls.Add(bunifuLabel1);
            Controls.Add(password);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox Username;
        private Bunifu.UI.WinForms.BunifuTextBox password;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
    }
}