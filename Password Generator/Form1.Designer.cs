namespace Password_Generator
{
    partial class PassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen));
            this.Password = new System.Windows.Forms.Label();
            this.PasswordLength = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.Copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Password, "Password");
            this.Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Password.Name = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLength
            // 
            resources.ApplyResources(this.PasswordLength, "PasswordLength");
            this.PasswordLength.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Click += new System.EventHandler(this.PasswordLength_Click);
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.PasswordLengthSlider, "PasswordLengthSlider");
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.PasswordLengthSlider_Scroll);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Copy, "Copy");
            this.Copy.ForeColor = System.Drawing.Color.DarkGray;
            this.Copy.Name = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // PassGen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PassGen";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label PasswordLength;
        private System.Windows.Forms.TrackBar PasswordLengthSlider;
        private System.Windows.Forms.Button Copy;
    }
}

