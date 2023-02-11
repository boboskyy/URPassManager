namespace URPassManager
{
    partial class RegisterForm
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
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.rePasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addFpBtn = new MetroFramework.Controls.MetroButton();
            this.fpPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasło:";
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(23, 89);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(315, 23);
            this.passwordBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
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
            this.rePasswordBox.Location = new System.Drawing.Point(23, 139);
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
            this.rePasswordBox.TabIndex = 4;
            this.rePasswordBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rePasswordBox.UseSelectable = true;
            this.rePasswordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rePasswordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rePasswordBox.TextChanged += new System.EventHandler(this.rePasswordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Powtórz Hasło:";
            // 
            // addFpBtn
            // 
            this.addFpBtn.Enabled = false;
            this.addFpBtn.Location = new System.Drawing.Point(23, 175);
            this.addFpBtn.Name = "addFpBtn";
            this.addFpBtn.Size = new System.Drawing.Size(315, 23);
            this.addFpBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.addFpBtn.TabIndex = 5;
            this.addFpBtn.Text = "Dodaj odcisk palca";
            this.addFpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addFpBtn.UseSelectable = true;
            this.addFpBtn.Click += new System.EventHandler(this.addFpBtn_Click);
            // 
            // fpPicBox
            // 
            this.fpPicBox.Location = new System.Drawing.Point(23, 220);
            this.fpPicBox.Name = "fpPicBox";
            this.fpPicBox.Size = new System.Drawing.Size(315, 217);
            this.fpPicBox.TabIndex = 6;
            this.fpPicBox.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 220);
            this.Controls.Add(this.fpPicBox);
            this.Controls.Add(this.addFpBtn);
            this.Controls.Add(this.rePasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Rejestracja";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fpPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroTextBox rePasswordBox;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton addFpBtn;
        private System.Windows.Forms.PictureBox fpPicBox;
    }
}