namespace LabCrypt
{
    partial class Lab5
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Shennon_btn = new System.Windows.Forms.Button();
            this.Gost_28147_btn = new System.Windows.Forms.Button();
            this.ivBox = new System.Windows.Forms.TextBox();
            this.TBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(821, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 586);
            this.OutputTextBox.TabIndex = 5;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(465, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 586);
            this.InputTextBox.TabIndex = 6;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 203);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 15;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(156, 203);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 16;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(127, 117);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Key";
            this.keyBox.Size = new System.Drawing.Size(109, 23);
            this.keyBox.TabIndex = 17;
            // 
            // Shennon_btn
            // 
            this.Shennon_btn.BackColor = System.Drawing.Color.Turquoise;
            this.Shennon_btn.Location = new System.Drawing.Point(12, 48);
            this.Shennon_btn.Name = "Shennon_btn";
            this.Shennon_btn.Size = new System.Drawing.Size(109, 63);
            this.Shennon_btn.TabIndex = 18;
            this.Shennon_btn.Text = "Одноразовый блокнот К.Шеннона";
            this.Shennon_btn.UseVisualStyleBackColor = false;
            this.Shennon_btn.Click += new System.EventHandler(this.Shennon_btn_Click);
            // 
            // Gost_28147_btn
            // 
            this.Gost_28147_btn.Location = new System.Drawing.Point(127, 48);
            this.Gost_28147_btn.Name = "Gost_28147_btn";
            this.Gost_28147_btn.Size = new System.Drawing.Size(109, 63);
            this.Gost_28147_btn.TabIndex = 19;
            this.Gost_28147_btn.Text = "Гаммирование ГОСТ 28147-89";
            this.Gost_28147_btn.UseVisualStyleBackColor = true;
            this.Gost_28147_btn.Click += new System.EventHandler(this.Gost_28147_btn_Click);
            // 
            // ivBox
            // 
            this.ivBox.Enabled = false;
            this.ivBox.Location = new System.Drawing.Point(127, 146);
            this.ivBox.Name = "ivBox";
            this.ivBox.PlaceholderText = "IV";
            this.ivBox.Size = new System.Drawing.Size(109, 23);
            this.ivBox.TabIndex = 20;
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(12, 117);
            this.TBox.Name = "TBox";
            this.TBox.PlaceholderText = "T(0)";
            this.TBox.Size = new System.Drawing.Size(109, 23);
            this.TBox.TabIndex = 21;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 145);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(109, 23);
            this.aBox.TabIndex = 22;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(12, 174);
            this.cBox.Name = "cBox";
            this.cBox.PlaceholderText = "c";
            this.cBox.Size = new System.Drawing.Size(109, 23);
            this.cBox.TabIndex = 23;
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 610);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.ivBox);
            this.Controls.Add(this.Gost_28147_btn);
            this.Controls.Add(this.Shennon_btn);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab5";
            this.Text = "Lab5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private TextBox keyBox;
        private Button Shennon_btn;
        private Button Gost_28147_btn;
        private TextBox ivBox;
        private TextBox TBox;
        private TextBox aBox;
        private TextBox cBox;
    }
}