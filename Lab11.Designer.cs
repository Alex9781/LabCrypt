namespace LabCrypt
{
    partial class Lab11
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
            this.DH_btn = new System.Windows.Forms.Button();
            this.nBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.ybBox = new System.Windows.Forms.TextBox();
            this.Exchange_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(893, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 575);
            this.OutputTextBox.TabIndex = 39;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(537, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 575);
            this.InputTextBox.TabIndex = 40;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // MainPage_btn
            // 
            this.MainPage_btn.Location = new System.Drawing.Point(12, 12);
            this.MainPage_btn.Name = "MainPage_btn";
            this.MainPage_btn.Size = new System.Drawing.Size(80, 30);
            this.MainPage_btn.TabIndex = 41;
            this.MainPage_btn.Text = "Main Page";
            this.MainPage_btn.UseVisualStyleBackColor = true;
            this.MainPage_btn.Click += new System.EventHandler(this.MainPage_btn_Click);
            // 
            // DH_btn
            // 
            this.DH_btn.BackColor = System.Drawing.Color.Turquoise;
            this.DH_btn.Location = new System.Drawing.Point(12, 48);
            this.DH_btn.Name = "DH_btn";
            this.DH_btn.Size = new System.Drawing.Size(80, 49);
            this.DH_btn.TabIndex = 42;
            this.DH_btn.Text = "DH";
            this.DH_btn.UseVisualStyleBackColor = false;
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 103);
            this.nBox.Name = "nBox";
            this.nBox.PlaceholderText = "n";
            this.nBox.Size = new System.Drawing.Size(224, 23);
            this.nBox.TabIndex = 43;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 132);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(224, 23);
            this.aBox.TabIndex = 44;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(12, 161);
            this.kBox.Name = "kBox";
            this.kBox.PlaceholderText = "k";
            this.kBox.Size = new System.Drawing.Size(224, 23);
            this.kBox.TabIndex = 46;
            // 
            // ybBox
            // 
            this.ybBox.Location = new System.Drawing.Point(12, 190);
            this.ybBox.Name = "ybBox";
            this.ybBox.PlaceholderText = "yb";
            this.ybBox.Size = new System.Drawing.Size(224, 23);
            this.ybBox.TabIndex = 47;
            // 
            // Exchange_btn
            // 
            this.Exchange_btn.Location = new System.Drawing.Point(12, 219);
            this.Exchange_btn.Name = "Exchange_btn";
            this.Exchange_btn.Size = new System.Drawing.Size(80, 36);
            this.Exchange_btn.TabIndex = 48;
            this.Exchange_btn.Text = "Exchange";
            this.Exchange_btn.UseVisualStyleBackColor = true;
            this.Exchange_btn.Click += new System.EventHandler(this.Exchange_btn_Click);
            // 
            // ß
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 599);
            this.Controls.Add(this.Exchange_btn);
            this.Controls.Add(this.ybBox);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.DH_btn);
            this.Controls.Add(this.MainPage_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Lab11";
            this.Text = "Lab11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button MainPage_btn;
        private Button DH_btn;
        private TextBox nBox;
        private TextBox aBox;
        private TextBox kBox;
        private TextBox ybBox;
        private Button Exchange_btn;
    }
}