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
            this.GOST12_ecp_btn = new System.Windows.Forms.Button();
            this.a2_box = new System.Windows.Forms.TextBox();
            this.b2_box = new System.Windows.Forms.TextBox();
            this.p2_box = new System.Windows.Forms.TextBox();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.y2_box = new System.Windows.Forms.TextBox();
            this.xu2_box = new System.Windows.Forms.TextBox();
            this.k2_box = new System.Windows.Forms.TextBox();
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
            this.OutputTextBox.Location = new System.Drawing.Point(922, 12);
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
            this.InputTextBox.Location = new System.Drawing.Point(566, 12);
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
            this.pBox.Size = new System.Drawing.Size(80, 23);
            this.pBox.TabIndex = 41;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(12, 132);
            this.qBox.Name = "qBox";
            this.qBox.PlaceholderText = "q";
            this.qBox.Size = new System.Drawing.Size(80, 23);
            this.qBox.TabIndex = 42;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 161);
            this.aBox.Name = "aBox";
            this.aBox.PlaceholderText = "a";
            this.aBox.Size = new System.Drawing.Size(80, 23);
            this.aBox.TabIndex = 43;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(12, 190);
            this.xBox.Name = "xBox";
            this.xBox.PlaceholderText = "x";
            this.xBox.Size = new System.Drawing.Size(80, 23);
            this.xBox.TabIndex = 44;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(12, 219);
            this.kBox.Name = "kBox";
            this.kBox.PlaceholderText = "k";
            this.kBox.Size = new System.Drawing.Size(80, 23);
            this.kBox.TabIndex = 45;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(12, 248);
            this.rBox.Name = "rBox";
            this.rBox.PlaceholderText = "r";
            this.rBox.Size = new System.Drawing.Size(80, 23);
            this.rBox.TabIndex = 46;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(12, 277);
            this.sBox.Name = "sBox";
            this.sBox.PlaceholderText = "s";
            this.sBox.Size = new System.Drawing.Size(80, 23);
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
            // 
            // GOST12_ecp_btn
            // 
            this.GOST12_ecp_btn.BackColor = System.Drawing.Color.Transparent;
            this.GOST12_ecp_btn.Location = new System.Drawing.Point(156, 48);
            this.GOST12_ecp_btn.Name = "GOST12_ecp_btn";
            this.GOST12_ecp_btn.Size = new System.Drawing.Size(80, 49);
            this.GOST12_ecp_btn.TabIndex = 50;
            this.GOST12_ecp_btn.Text = "ГОСТ 12 ЭЦП";
            this.GOST12_ecp_btn.UseVisualStyleBackColor = false;
            this.GOST12_ecp_btn.Click += new System.EventHandler(this.GOST12_ecp_btn_Click);
            // 
            // a2_box
            // 
            this.a2_box.Location = new System.Drawing.Point(156, 103);
            this.a2_box.Name = "a2_box";
            this.a2_box.PlaceholderText = "a";
            this.a2_box.Size = new System.Drawing.Size(80, 23);
            this.a2_box.TabIndex = 51;
            // 
            // b2_box
            // 
            this.b2_box.Location = new System.Drawing.Point(156, 132);
            this.b2_box.Name = "b2_box";
            this.b2_box.PlaceholderText = "b";
            this.b2_box.Size = new System.Drawing.Size(80, 23);
            this.b2_box.TabIndex = 52;
            // 
            // p2_box
            // 
            this.p2_box.Location = new System.Drawing.Point(156, 161);
            this.p2_box.Name = "p2_box";
            this.p2_box.PlaceholderText = "p";
            this.p2_box.Size = new System.Drawing.Size(80, 23);
            this.p2_box.TabIndex = 53;
            // 
            // x2_box
            // 
            this.x2_box.Location = new System.Drawing.Point(156, 219);
            this.x2_box.Name = "x2_box";
            this.x2_box.PlaceholderText = "x";
            this.x2_box.Size = new System.Drawing.Size(80, 23);
            this.x2_box.TabIndex = 54;
            // 
            // y2_box
            // 
            this.y2_box.Location = new System.Drawing.Point(156, 248);
            this.y2_box.Name = "y2_box";
            this.y2_box.PlaceholderText = "y";
            this.y2_box.Size = new System.Drawing.Size(80, 23);
            this.y2_box.TabIndex = 55;
            // 
            // xu2_box
            // 
            this.xu2_box.Location = new System.Drawing.Point(156, 190);
            this.xu2_box.Name = "xu2_box";
            this.xu2_box.PlaceholderText = "Xu";
            this.xu2_box.Size = new System.Drawing.Size(80, 23);
            this.xu2_box.TabIndex = 56;
            // 
            // k2_box
            // 
            this.k2_box.Location = new System.Drawing.Point(156, 277);
            this.k2_box.Name = "k2_box";
            this.k2_box.PlaceholderText = "k";
            this.k2_box.Size = new System.Drawing.Size(80, 23);
            this.k2_box.TabIndex = 57;
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 642);
            this.Controls.Add(this.k2_box);
            this.Controls.Add(this.xu2_box);
            this.Controls.Add(this.y2_box);
            this.Controls.Add(this.x2_box);
            this.Controls.Add(this.p2_box);
            this.Controls.Add(this.b2_box);
            this.Controls.Add(this.a2_box);
            this.Controls.Add(this.GOST12_ecp_btn);
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
        private Button GOST12_ecp_btn;
        private TextBox a2_box;
        private TextBox b2_box;
        private TextBox p2_box;
        private TextBox x2_box;
        private TextBox y2_box;
        private TextBox xu2_box;
        private TextBox k2_box;
    }
}