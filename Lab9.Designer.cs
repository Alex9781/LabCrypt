namespace LabCrypt
{
    partial class Lab9
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
            this.Sign_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.ElgamalDSA_btn = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 24;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(982, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 615);
            this.OutputTextBox.TabIndex = 38;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(626, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 615);
            this.InputTextBox.TabIndex = 39;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Sign_btn
            // 
            this.Sign_btn.Location = new System.Drawing.Point(12, 274);
            this.Sign_btn.Name = "Sign_btn";
            this.Sign_btn.Size = new System.Drawing.Size(80, 30);
            this.Sign_btn.TabIndex = 40;
            this.Sign_btn.Text = "Sign";
            this.Sign_btn.UseVisualStyleBackColor = true;
            this.Sign_btn.Click += new System.EventHandler(this.Sign_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(156, 274);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(80, 30);
            this.Decrypt_btn.TabIndex = 41;
            this.Decrypt_btn.Text = "Check";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // ElgamalDSA_btn
            // 
            this.ElgamalDSA_btn.BackColor = System.Drawing.Color.Turquoise;
            this.ElgamalDSA_btn.Location = new System.Drawing.Point(12, 48);
            this.ElgamalDSA_btn.Name = "ElgamalDSA_btn";
            this.ElgamalDSA_btn.Size = new System.Drawing.Size(80, 46);
            this.ElgamalDSA_btn.TabIndex = 42;
            this.ElgamalDSA_btn.Text = "Elgamal DSA";
            this.ElgamalDSA_btn.UseVisualStyleBackColor = false;
            this.ElgamalDSA_btn.Click += new System.EventHandler(this.ElgamalDSA_btn_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 100);
            this.pBox.Name = "pBox";
            this.pBox.PlaceholderText = "p";
            this.pBox.Size = new System.Drawing.Size(224, 23);
            this.pBox.TabIndex = 43;
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(12, 129);
            this.gBox.Name = "gBox";
            this.gBox.PlaceholderText = "g";
            this.gBox.Size = new System.Drawing.Size(224, 23);
            this.gBox.TabIndex = 44;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(12, 158);
            this.xBox.Name = "xBox";
            this.xBox.PlaceholderText = "x";
            this.xBox.Size = new System.Drawing.Size(224, 23);
            this.xBox.TabIndex = 45;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(12, 187);
            this.kBox.Name = "kBox";
            this.kBox.PlaceholderText = "k";
            this.kBox.Size = new System.Drawing.Size(224, 23);
            this.kBox.TabIndex = 46;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 216);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(224, 23);
            this.aBox.TabIndex = 47;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(12, 245);
            this.bBox.Name = "bBox";
            this.bBox.PlaceholderText = "b";
            this.bBox.Size = new System.Drawing.Size(224, 23);
            this.bBox.TabIndex = 48;
            // 
            // Lab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 639);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.ElgamalDSA_btn);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Sign_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab9";
            this.Text = "Lab9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button Sign_btn;
        private Button Decrypt_btn;
        private Button ElgamalDSA_btn;
        private TextBox pBox;
        private TextBox gBox;
        private TextBox xBox;
        private TextBox kBox;
        private TextBox aBox;
        private TextBox bBox;
    }
}