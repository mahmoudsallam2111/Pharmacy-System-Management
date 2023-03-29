namespace Pharmacy_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(251, 45);
            label1.Name = "label1";
            label1.Size = new Size(214, 43);
            label1.TabIndex = 1;
            label1.Text = "🅿🅷🅰🆁🅼🅰";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(517, 111);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 2;
            label2.Text = "PoweredBy.Mahmoud Ai";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bunifuCircleProgress1
            // 
            bunifuCircleProgress1.Animated = false;
            bunifuCircleProgress1.AnimationInterval = 5;
            bunifuCircleProgress1.AnimationSpeed = 5;
            bunifuCircleProgress1.BackColor = Color.Transparent;
            bunifuCircleProgress1.CircleMargin = 10;
            bunifuCircleProgress1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuCircleProgress1.ForeColor = Color.White;
            bunifuCircleProgress1.IsPercentage = false;
            bunifuCircleProgress1.LineProgressThickness = 10;
            bunifuCircleProgress1.LineThickness = 10;
            bunifuCircleProgress1.Location = new Point(300, 181);
            bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            bunifuCircleProgress1.ProgressBackColor = Color.Gainsboro;
            bunifuCircleProgress1.ProgressColor = Color.FromArgb(0, 64, 0);
            bunifuCircleProgress1.ProgressColor2 = Color.DodgerBlue;
            bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            bunifuCircleProgress1.SecondaryFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuCircleProgress1.Size = new Size(178, 178);
            bunifuCircleProgress1.SubScriptColor = Color.FromArgb(166, 166, 166);
            bunifuCircleProgress1.SubScriptMargin = new Padding(5, -20, 0, 0);
            bunifuCircleProgress1.SubScriptText = "";
            bunifuCircleProgress1.SuperScriptColor = Color.DarkGray;
            bunifuCircleProgress1.SuperScriptMargin = new Padding(5, 20, 0, 0);
            bunifuCircleProgress1.SuperScriptText = "";
            bunifuCircleProgress1.TabIndex = 16;
            bunifuCircleProgress1.Text = "30";
            bunifuCircleProgress1.TextMargin = new Padding(0, 5, 0, 0);
            bunifuCircleProgress1.Value = 30;
            bunifuCircleProgress1.ValueByTransition = 30;
            bunifuCircleProgress1.ValueMargin = new Padding(0, 5, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(429, 421);
            label3.Name = "label3";
            label3.Size = new Size(359, 20);
            label3.TabIndex = 17;
            label3.Text = "Copyright © https://github.com/mahmoudsallam211";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(182, 30);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 18;
            label4.Text = "⚡";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bunifuCircleProgress1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private Label label3;
        private Label label4;
    }
}






















