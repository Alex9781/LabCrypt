namespace LabCrypt
{
    partial class Lab1
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
            this.Atbash_btn = new System.Windows.Forms.Button();
            this.Caesar_btn = new System.Windows.Forms.Button();
            this.Polybius_btn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.Is_Alph_Full_CheckBox = new System.Windows.Forms.CheckBox();
            this.alph_Help_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 0;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.AcceptsReturn = true;
            this.OutputTextBox.AcceptsTab = true;
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(831, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 617);
            this.OutputTextBox.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(475, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 617);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Atbash_btn
            // 
            this.Atbash_btn.BackColor = System.Drawing.Color.Turquoise;
            this.Atbash_btn.Location = new System.Drawing.Point(12, 48);
            this.Atbash_btn.Name = "Atbash_btn";
            this.Atbash_btn.Size = new System.Drawing.Size(80, 50);
            this.Atbash_btn.TabIndex = 3;
            this.Atbash_btn.Text = "Шифр АТБАШ";
            this.Atbash_btn.UseVisualStyleBackColor = false;
            this.Atbash_btn.Click += new System.EventHandler(this.Atbash_btn_Click);
            // 
            // Caesar_btn
            // 
            this.Caesar_btn.Location = new System.Drawing.Point(98, 48);
            this.Caesar_btn.Name = "Caesar_btn";
            this.Caesar_btn.Size = new System.Drawing.Size(80, 50);
            this.Caesar_btn.TabIndex = 4;
            this.Caesar_btn.Text = "Шифр Цезаря";
            this.Caesar_btn.UseVisualStyleBackColor = true;
            this.Caesar_btn.Click += new System.EventHandler(this.Caesar_btn_Click);
            // 
            // Polybius_btn
            // 
            this.Polybius_btn.Location = new System.Drawing.Point(184, 48);
            this.Polybius_btn.Name = "Polybius_btn";
            this.Polybius_btn.Size = new System.Drawing.Size(80, 50);
            this.Polybius_btn.TabIndex = 5;
            this.Polybius_btn.Text = "Квадрат Полибия";
            this.Polybius_btn.UseVisualStyleBackColor = true;
            this.Polybius_btn.Click += new System.EventHandler(this.Polybius_btn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Enabled = false;
            this.keyBox.Location = new System.Drawing.Point(98, 104);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Key";
            this.keyBox.Size = new System.Drawing.Size(80, 23);
            this.keyBox.TabIndex = 6;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 133);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 7;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(184, 133);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 8;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // Is_Alph_Full_CheckBox
            // 
            this.Is_Alph_Full_CheckBox.AutoSize = true;
            this.Is_Alph_Full_CheckBox.Location = new System.Drawing.Point(12, 169);
            this.Is_Alph_Full_CheckBox.Name = "Is_Alph_Full_CheckBox";
            this.Is_Alph_Full_CheckBox.Size = new System.Drawing.Size(121, 19);
            this.Is_Alph_Full_CheckBox.TabIndex = 9;
            this.Is_Alph_Full_CheckBox.Text = "Полный алфавит";
            this.Is_Alph_Full_CheckBox.UseVisualStyleBackColor = true;
            // 
            // alph_Help_Label
            // 
            this.alph_Help_Label.AutoSize = true;
            this.alph_Help_Label.Location = new System.Drawing.Point(12, 191);
            this.alph_Help_Label.Name = "alph_Help_Label";
            this.alph_Help_Label.Size = new System.Drawing.Size(434, 30);
            this.alph_Help_Label.TabIndex = 10;
            this.alph_Help_Label.Text = "Необходимо для сверки с карточкой\r\nЕсли не выделено, использует обрезанный алфави" +
    "т без \"ё\" и спец. символов";
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 641);
            this.Controls.Add(this.alph_Help_Label);
            this.Controls.Add(this.Is_Alph_Full_CheckBox);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Polybius_btn);
            this.Controls.Add(this.Caesar_btn);
            this.Controls.Add(this.Atbash_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab1";
            this.Text = "Lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button Atbash_btn;
        private Button Caesar_btn;
        private Button Polybius_btn;
        private TextBox keyBox;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private CheckBox Is_Alph_Full_CheckBox;
        private Label alph_Help_Label;
    }
}