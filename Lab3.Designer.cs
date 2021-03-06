namespace LabCrypt
{
    partial class Lab3
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
            this.Matrix_btn = new System.Windows.Forms.Button();
            this.Playfair_btn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.alph_Help_Label = new System.Windows.Forms.Label();
            this.Is_Alph_Full_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 5;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(835, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 601);
            this.OutputTextBox.TabIndex = 6;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(479, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 601);
            this.InputTextBox.TabIndex = 7;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Matrix_btn
            // 
            this.Matrix_btn.BackColor = System.Drawing.Color.Turquoise;
            this.Matrix_btn.Location = new System.Drawing.Point(12, 48);
            this.Matrix_btn.Name = "Matrix_btn";
            this.Matrix_btn.Size = new System.Drawing.Size(96, 49);
            this.Matrix_btn.TabIndex = 8;
            this.Matrix_btn.Text = "Матричный шифр";
            this.Matrix_btn.UseVisualStyleBackColor = false;
            this.Matrix_btn.Click += new System.EventHandler(this.Matrix_btn_Click);
            // 
            // Playfair_btn
            // 
            this.Playfair_btn.Location = new System.Drawing.Point(114, 48);
            this.Playfair_btn.Name = "Playfair_btn";
            this.Playfair_btn.Size = new System.Drawing.Size(96, 49);
            this.Playfair_btn.TabIndex = 9;
            this.Playfair_btn.Text = "Шифр Плейфера";
            this.Playfair_btn.UseVisualStyleBackColor = true;
            this.Playfair_btn.Click += new System.EventHandler(this.Playfair_btn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 103);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Key";
            this.keyBox.Size = new System.Drawing.Size(198, 23);
            this.keyBox.TabIndex = 12;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 132);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 13;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(130, 132);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 14;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // alph_Help_Label
            // 
            this.alph_Help_Label.AutoSize = true;
            this.alph_Help_Label.Location = new System.Drawing.Point(12, 190);
            this.alph_Help_Label.Name = "alph_Help_Label";
            this.alph_Help_Label.Size = new System.Drawing.Size(434, 30);
            this.alph_Help_Label.TabIndex = 16;
            this.alph_Help_Label.Text = "Необходимо для сверки с карточкой\r\nЕсли не выделено, использует обрезанный алфави" +
    "т без \"ё\" и спец. символов";
            // 
            // Is_Alph_Full_CheckBox
            // 
            this.Is_Alph_Full_CheckBox.AutoSize = true;
            this.Is_Alph_Full_CheckBox.Location = new System.Drawing.Point(12, 168);
            this.Is_Alph_Full_CheckBox.Name = "Is_Alph_Full_CheckBox";
            this.Is_Alph_Full_CheckBox.Size = new System.Drawing.Size(121, 19);
            this.Is_Alph_Full_CheckBox.TabIndex = 15;
            this.Is_Alph_Full_CheckBox.Text = "Полный алфавит";
            this.Is_Alph_Full_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 625);
            this.Controls.Add(this.alph_Help_Label);
            this.Controls.Add(this.Is_Alph_Full_CheckBox);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Playfair_btn);
            this.Controls.Add(this.Matrix_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab3";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button Matrix_btn;
        private Button Playfair_btn;
        private TextBox keyBox;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private Label alph_Help_Label;
        private CheckBox Is_Alph_Full_CheckBox;
    }
}