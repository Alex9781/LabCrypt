namespace LabCrypt
{
    partial class Lab2
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.MainPage_btn = new System.Windows.Forms.Button();
            this.Trithemium_btn = new System.Windows.Forms.Button();
            this.Belazo_btn = new System.Windows.Forms.Button();
            this.Vigenere_btn = new System.Windows.Forms.Button();
            this.Magma_btn = new System.Windows.Forms.Button();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(845, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 614);
            this.OutputTextBox.TabIndex = 2;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(489, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 614);
            this.InputTextBox.TabIndex = 3;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 4;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // Trithemium_btn
            // 
            this.Trithemium_btn.BackColor = System.Drawing.Color.Turquoise;
            this.Trithemium_btn.Location = new System.Drawing.Point(12, 48);
            this.Trithemium_btn.Name = "Trithemium_btn";
            this.Trithemium_btn.Size = new System.Drawing.Size(80, 61);
            this.Trithemium_btn.TabIndex = 5;
            this.Trithemium_btn.Text = "Шифр Тритемия";
            this.Trithemium_btn.UseVisualStyleBackColor = false;
            this.Trithemium_btn.Click += new System.EventHandler(this.Trithemium_btn_Click);
            // 
            // Belazo_btn
            // 
            this.Belazo_btn.Location = new System.Drawing.Point(98, 48);
            this.Belazo_btn.Name = "Belazo_btn";
            this.Belazo_btn.Size = new System.Drawing.Size(80, 61);
            this.Belazo_btn.TabIndex = 6;
            this.Belazo_btn.Text = "Шифр Белазо";
            this.Belazo_btn.UseVisualStyleBackColor = true;
            this.Belazo_btn.Click += new System.EventHandler(this.Belazo_btn_Click);
            // 
            // Vigenere_btn
            // 
            this.Vigenere_btn.Location = new System.Drawing.Point(184, 48);
            this.Vigenere_btn.Name = "Vigenere_btn";
            this.Vigenere_btn.Size = new System.Drawing.Size(80, 61);
            this.Vigenere_btn.TabIndex = 7;
            this.Vigenere_btn.Text = "Шифр Виженера";
            this.Vigenere_btn.UseVisualStyleBackColor = true;
            this.Vigenere_btn.Click += new System.EventHandler(this.Vigenere_btn_Click);
            // 
            // Magma_btn
            // 
            this.Magma_btn.Location = new System.Drawing.Point(270, 48);
            this.Magma_btn.Name = "Magma_btn";
            this.Magma_btn.Size = new System.Drawing.Size(80, 61);
            this.Magma_btn.TabIndex = 8;
            this.Magma_btn.Text = "S-блок замены \"Магма\"";
            this.Magma_btn.UseVisualStyleBackColor = true;
            this.Magma_btn.Click += new System.EventHandler(this.Magma_btn_Click);
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 137);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 9;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(270, 137);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 10;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Enabled = false;
            this.keyBox.Location = new System.Drawing.Point(98, 115);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Key";
            this.keyBox.Size = new System.Drawing.Size(166, 23);
            this.keyBox.TabIndex = 11;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 638);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Magma_btn);
            this.Controls.Add(this.Vigenere_btn);
            this.Controls.Add(this.Belazo_btn);
            this.Controls.Add(this.Trithemium_btn);
            this.Controls.Add(this.MainPage_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Lab2";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button MainPage_btn;
        private Button Trithemium_btn;
        private Button Belazo_btn;
        private Button Vigenere_btn;
        private Button Magma_btn;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private TextBox keyBox;
    }
}