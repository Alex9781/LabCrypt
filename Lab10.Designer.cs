namespace LabCrypt
{
    partial class Lab10
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
            this.GOST94_ecp_btn = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.TextBox();
            this.qBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.sBox = new System.Windows.Forms.TextBox();
            this.Sign_btn = new System.Windows.Forms.Button();
            this.Check_btn = new System.Windows.Forms.Button();
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
            this.OutputTextBox.Location = new System.Drawing.Point(931, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 618);
            this.OutputTextBox.TabIndex = 38;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(575, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 618);
            this.InputTextBox.TabIndex = 39;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // GOST94_ecp_btn
            // 
            this.GOST94_ecp_btn.BackColor = System.Drawing.Color.Turquoise;
            this.GOST94_ecp_btn.Location = new System.Drawing.Point(12, 48);
            this.GOST94_ecp_btn.Name = "GOST94_ecp_btn";
            this.GOST94_ecp_btn.Size = new System.Drawing.Size(80, 49);
            this.GOST94_ecp_btn.TabIndex = 40;
            this.GOST94_ecp_btn.Text = "ГОСТ 94 ЭЦП";
            this.GOST94_ecp_btn.UseVisualStyleBackColor = false;
            this.GOST94_ecp_btn.Click += new System.EventHandler(this.GOST94_ecp_btn_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 103);
            this.pBox.Name = "pBox";
            this.pBox.PlaceholderText = "p";
            this.pBox.Size = new System.Drawing.Size(224, 23);
            this.pBox.TabIndex = 41;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(12, 132);
            this.qBox.Name = "qBox";
            this.qBox.PlaceholderText = "q";
            this.qBox.Size = new System.Drawing.Size(224, 23);
            this.qBox.TabIndex = 42;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 161);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(224, 23);
            this.aBox.TabIndex = 43;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(12, 190);
            this.xBox.Name = "xBox";
            this.xBox.PlaceholderText = "x";
            this.xBox.Size = new System.Drawing.Size(224, 23);
            this.xBox.TabIndex = 44;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(12, 219);
            this.kBox.Name = "kBox";
            this.kBox.PlaceholderText = "k";
            this.kBox.Size = new System.Drawing.Size(224, 23);
            this.kBox.TabIndex = 45;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(12, 248);
            this.rBox.Name = "rBox";
            this.rBox.PlaceholderText = "r";
            this.rBox.Size = new System.Drawing.Size(224, 23);
            this.rBox.TabIndex = 46;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(12, 277);
            this.sBox.Name = "sBox";
            this.sBox.PlaceholderText = "s";
            this.sBox.Size = new System.Drawing.Size(224, 23);
            this.sBox.TabIndex = 47;
            // 
            // Sign_btn
            // 
            this.Sign_btn.Location = new System.Drawing.Point(12, 306);
            this.Sign_btn.Name = "Sign_btn";
            this.Sign_btn.Size = new System.Drawing.Size(80, 30);
            this.Sign_btn.TabIndex = 48;
            this.Sign_btn.Text = "Sign";
            this.Sign_btn.UseVisualStyleBackColor = true;
            this.Sign_btn.Click += new System.EventHandler(this.Sign_btn_Click);
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(156, 306);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(80, 30);
            this.Check_btn.TabIndex = 49;
            this.Check_btn.Text = "Check";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 642);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.Sign_btn);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.GOST94_ecp_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MainPage_btn);
            this.Name = "Lab10";
            this.Text = "Lab10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainPage_btn;
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button GOST94_ecp_btn;
        private TextBox pBox;
        private TextBox qBox;
        private TextBox aBox;
        private TextBox xBox;
        private TextBox kBox;
        private TextBox rBox;
        private TextBox sBox;
        private Button Sign_btn;
        private Button Check_btn;
    }
}