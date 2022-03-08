namespace LabCrypt
{
    partial class Lab4
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
            this.Vertical_btn = new System.Windows.Forms.Button();
            this.Cardan_btn = new System.Windows.Forms.Button();
            this.Feistel_btn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(834, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 593);
            this.OutputTextBox.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(478, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 593);
            this.InputTextBox.TabIndex = 2;
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 3;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // Vertical_btn
            // 
            this.Vertical_btn.BackColor = System.Drawing.Color.Turquoise;
            this.Vertical_btn.Location = new System.Drawing.Point(12, 48);
            this.Vertical_btn.Name = "Vertical_btn";
            this.Vertical_btn.Size = new System.Drawing.Size(96, 49);
            this.Vertical_btn.TabIndex = 9;
            this.Vertical_btn.Text = "Вертикальная перестановка";
            this.Vertical_btn.UseVisualStyleBackColor = false;
            this.Vertical_btn.Click += new System.EventHandler(this.Vertical_btn_Click);
            // 
            // Cardan_btn
            // 
            this.Cardan_btn.Location = new System.Drawing.Point(114, 48);
            this.Cardan_btn.Name = "Cardan_btn";
            this.Cardan_btn.Size = new System.Drawing.Size(96, 49);
            this.Cardan_btn.TabIndex = 10;
            this.Cardan_btn.Text = "Решетка Кардано";
            this.Cardan_btn.UseVisualStyleBackColor = true;
            this.Cardan_btn.Click += new System.EventHandler(this.Cardan_btn_Click);
            // 
            // Feistel_btn
            // 
            this.Feistel_btn.Location = new System.Drawing.Point(216, 48);
            this.Feistel_btn.Name = "Feistel_btn";
            this.Feistel_btn.Size = new System.Drawing.Size(96, 49);
            this.Feistel_btn.TabIndex = 11;
            this.Feistel_btn.Text = "Cеть Фейстеля";
            this.Feistel_btn.UseVisualStyleBackColor = true;
            this.Feistel_btn.Click += new System.EventHandler(this.Feistel_btn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 103);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Key";
            this.keyBox.Size = new System.Drawing.Size(300, 23);
            this.keyBox.TabIndex = 13;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(12, 132);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Encrypt_btn.TabIndex = 14;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(232, 132);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 15;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "Для решётки Кардано размером 10*6\r\n0 - закрытая клетка\r\n1 - открытая\r\nСлева напра" +
    "во, сверху вниз\r\n";
            // 
            // Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Feistel_btn);
            this.Controls.Add(this.Cardan_btn);
            this.Controls.Add(this.Vertical_btn);
            this.Controls.Add(this.MainPage_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Lab4";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button MainPage_btn;
        private Button Vertical_btn;
        private Button Cardan_btn;
        private Button Feistel_btn;
        private TextBox keyBox;
        private Button Encrypt_btn;
        private Button Decrypt_btn;
        private Label label1;
    }
}