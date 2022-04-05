namespace LabCrypt
{
    partial class Lab8
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
            this.MainPage_btn = new System.Windows.Forms.Button();
            this.RSA_btn = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.TextBox();
            this.qBox = new System.Windows.Forms.TextBox();
            this.eBox = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 23;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // RSA_btn
            // 
            this.RSA_btn.BackColor = System.Drawing.Color.Turquoise;
            this.RSA_btn.Location = new System.Drawing.Point(12, 48);
            this.RSA_btn.Name = "RSA_btn";
            this.RSA_btn.Size = new System.Drawing.Size(80, 37);
            this.RSA_btn.TabIndex = 31;
            this.RSA_btn.Text = "RSA";
            this.RSA_btn.UseVisualStyleBackColor = false;
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 91);
            this.pBox.Name = "pBox";
            this.pBox.PlaceholderText = "p";
            this.pBox.Size = new System.Drawing.Size(224, 23);
            this.pBox.TabIndex = 32;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(12, 120);
            this.qBox.Name = "qBox";
            this.qBox.PlaceholderText = "q";
            this.qBox.Size = new System.Drawing.Size(224, 23);
            this.qBox.TabIndex = 33;
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(12, 149);
            this.eBox.Name = "eBox";
            this.eBox.PlaceholderText = "e";
            this.eBox.Size = new System.Drawing.Size(224, 23);
            this.eBox.TabIndex = 34;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 178);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 35;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(156, 178);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 36;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(984, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 607);
            this.OutputTextBox.TabIndex = 37;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(619, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 607);
            this.InputTextBox.TabIndex = 38;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 631);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.RSA_btn);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab8";
            this.Text = "Lab8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private Button RSA_btn;
        private TextBox pBox;
        private TextBox qBox;
        private TextBox eBox;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
    }
}