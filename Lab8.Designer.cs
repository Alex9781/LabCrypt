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
            this.Elgamal_btn = new System.Windows.Forms.Button();
            this.Ecc_btn = new System.Windows.Forms.Button();
            this.gBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.CbBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.e2Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
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
            this.RSA_btn.Size = new System.Drawing.Size(109, 37);
            this.RSA_btn.TabIndex = 31;
            this.RSA_btn.Text = "RSA";
            this.RSA_btn.UseVisualStyleBackColor = false;
            this.RSA_btn.Click += new System.EventHandler(this.RSA_btn_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 91);
            this.pBox.Name = "pBox";
            this.pBox.PlaceholderText = "p";
            this.pBox.Size = new System.Drawing.Size(339, 23);
            this.pBox.TabIndex = 32;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(12, 120);
            this.qBox.Name = "qBox";
            this.qBox.PlaceholderText = "q";
            this.qBox.Size = new System.Drawing.Size(109, 23);
            this.qBox.TabIndex = 33;
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(12, 149);
            this.eBox.Name = "eBox";
            this.eBox.PlaceholderText = "e";
            this.eBox.Size = new System.Drawing.Size(109, 23);
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
            // Elgamal_btn
            // 
            this.Elgamal_btn.Location = new System.Drawing.Point(127, 48);
            this.Elgamal_btn.Name = "Elgamal_btn";
            this.Elgamal_btn.Size = new System.Drawing.Size(109, 37);
            this.Elgamal_btn.TabIndex = 39;
            this.Elgamal_btn.Text = "Elgamal";
            this.Elgamal_btn.UseVisualStyleBackColor = true;
            this.Elgamal_btn.Click += new System.EventHandler(this.Elgamal_btn_Click);
            // 
            // Ecc_btn
            // 
            this.Ecc_btn.Location = new System.Drawing.Point(242, 48);
            this.Ecc_btn.Name = "Ecc_btn";
            this.Ecc_btn.Size = new System.Drawing.Size(109, 37);
            this.Ecc_btn.TabIndex = 40;
            this.Ecc_btn.Text = "ECC";
            this.Ecc_btn.UseVisualStyleBackColor = true;
            this.Ecc_btn.Click += new System.EventHandler(this.Ecc_btn_Click);
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(127, 120);
            this.gBox.Name = "gBox";
            this.gBox.PlaceholderText = "g";
            this.gBox.Size = new System.Drawing.Size(109, 23);
            this.gBox.TabIndex = 41;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(127, 149);
            this.xBox.Name = "xBox";
            this.xBox.PlaceholderText = "x";
            this.xBox.Size = new System.Drawing.Size(109, 23);
            this.xBox.TabIndex = 42;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(242, 149);
            this.yBox.Name = "yBox";
            this.yBox.PlaceholderText = "y";
            this.yBox.Size = new System.Drawing.Size(109, 23);
            this.yBox.TabIndex = 43;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(242, 207);
            this.bBox.Name = "bBox";
            this.bBox.PlaceholderText = "b";
            this.bBox.Size = new System.Drawing.Size(109, 23);
            this.bBox.TabIndex = 44;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(242, 178);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(109, 23);
            this.aBox.TabIndex = 45;
            // 
            // CbBox
            // 
            this.CbBox.Location = new System.Drawing.Point(242, 236);
            this.CbBox.Name = "CbBox";
            this.CbBox.PlaceholderText = "Cb";
            this.CbBox.Size = new System.Drawing.Size(109, 23);
            this.CbBox.TabIndex = 46;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(242, 265);
            this.kBox.Name = "kBox";
            this.kBox.PlaceholderText = "k";
            this.kBox.Size = new System.Drawing.Size(109, 23);
            this.kBox.TabIndex = 47;
            // 
            // e2Box
            // 
            this.e2Box.Location = new System.Drawing.Point(242, 294);
            this.e2Box.Name = "e2Box";
            this.e2Box.PlaceholderText = "e";
            this.e2Box.Size = new System.Drawing.Size(109, 23);
            this.e2Box.TabIndex = 48;
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(242, 120);
            this.x2Box.Name = "x2Box";
            this.x2Box.PlaceholderText = "x";
            this.x2Box.Size = new System.Drawing.Size(109, 23);
            this.x2Box.TabIndex = 49;
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 631);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.e2Box);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.CbBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.Ecc_btn);
            this.Controls.Add(this.Elgamal_btn);
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
        private Button Elgamal_btn;
        private Button Ecc_btn;
        private TextBox gBox;
        private TextBox xBox;
        private TextBox yBox;
        private TextBox bBox;
        private TextBox aBox;
        private TextBox CbBox;
        private TextBox kBox;
        private TextBox e2Box;
        private TextBox x2Box;
    }
}