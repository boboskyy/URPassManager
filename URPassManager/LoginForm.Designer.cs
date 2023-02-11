namespace URPassManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginPassBt = new MetroFramework.Controls.MetroButton();
            this.rePasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.loginFpBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasło:";
            // 
            // loginPassBt
            // 
            this.loginPassBt.Enabled = false;
            this.loginPassBt.Location = new System.Drawing.Point(23, 170);
            this.loginPassBt.Name = "loginPassBt";
            this.loginPassBt.Size = new System.Drawing.Size(153, 23);
            this.loginPassBt.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginPassBt.TabIndex = 7;
            this.loginPassBt.Text = "Logowanie hasłem";
            this.loginPassBt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginPassBt.UseSelectable = true;
            this.loginPassBt.Click += new System.EventHandler(this.loginPassBt_Click);
            // 
            // rePasswordBox
            // 
            // 
            // 
            // 
            this.rePasswordBox.CustomButton.Image = null;
            this.rePasswordBox.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.rePasswordBox.CustomButton.Name = "";
            this.rePasswordBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rePasswordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rePasswordBox.CustomButton.TabIndex = 1;
            this.rePasswordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rePasswordBox.CustomButton.UseSelectable = true;
            this.rePasswordBox.CustomButton.Visible = false;
            this.rePasswordBox.Lines = new string[0];
            this.rePasswordBox.Location = new System.Drawing.Point(23, 134);
            this.rePasswordBox.MaxLength = 32767;
            this.rePasswordBox.Name = "rePasswordBox";
            this.rePasswordBox.PasswordChar = '●';
            this.rePasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rePasswordBox.SelectedText = "";
            this.rePasswordBox.SelectionLength = 0;
            this.rePasswordBox.SelectionStart = 0;
            this.rePasswordBox.ShortcutsEnabled = true;
            this.rePasswordBox.Size = new System.Drawing.Size(315, 23);
            this.rePasswordBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.rePasswordBox.TabIndex = 6;
            this.rePasswordBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rePasswordBox.UseSelectable = true;
            this.rePasswordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rePasswordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rePasswordBox.TextChanged += new System.EventHandler(this.rePasswordBox_TextChanged_1);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(23, 73);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(259, 26);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Musisz się zalogować. \r\nPodaj hasło lub zeskanuj swój palec.";
            // 
            // loginFpBtn
            // 
            this.loginFpBtn.Location = new System.Drawing.Point(185, 170);
            this.loginFpBtn.Name = "loginFpBtn";
            this.loginFpBtn.Size = new System.Drawing.Size(153, 23);
            this.loginFpBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginFpBtn.TabIndex = 9;
            this.loginFpBtn.Text = "Odcisk palca";
            this.loginFpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginFpBtn.UseSelectable = true;
            this.loginFpBtn.Click += new System.EventHandler(this.loginFpBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 210);
            this.Controls.Add(this.loginFpBtn);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.loginPassBt);
            this.Controls.Add(this.rePasswordBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Zaloguj się";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton loginPassBt;
        private MetroFramework.Controls.MetroTextBox rePasswordBox;
        private System.Windows.Forms.Label InfoLabel;
        private MetroFramework.Controls.MetroButton loginFpBtn;
    }
}