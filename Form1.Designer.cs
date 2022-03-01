namespace LabCrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Lab1_btn = new System.Windows.Forms.Button();
            this.SelectFile_btn = new System.Windows.Forms.Button();
            this.Swap_btn = new System.Windows.Forms.Button();
            this.Clear_Output_btn = new System.Windows.Forms.Button();
            this.Lab2_btn = new System.Windows.Forms.Button();
            this.Lab3_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(825, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 610);
            this.OutputTextBox.TabIndex = 0;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(469, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 610);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // Lab1_btn
            // 
            this.Lab1_btn.Location = new System.Drawing.Point(12, 12);
            this.Lab1_btn.Name = "Lab1_btn";
            this.Lab1_btn.Size = new System.Drawing.Size(80, 30);
            this.Lab1_btn.TabIndex = 2;
            this.Lab1_btn.Text = "Lab1";
            this.Lab1_btn.UseVisualStyleBackColor = true;
            this.Lab1_btn.Click += new System.EventHandler(this.Lab1_btn_Click);
            // 
            // SelectFile_btn
            // 
            this.SelectFile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFile_btn.Location = new System.Drawing.Point(383, 592);
            this.SelectFile_btn.Name = "SelectFile_btn";
            this.SelectFile_btn.Size = new System.Drawing.Size(80, 30);
            this.SelectFile_btn.TabIndex = 3;
            this.SelectFile_btn.Text = "Select File";
            this.SelectFile_btn.UseVisualStyleBackColor = true;
            this.SelectFile_btn.Click += new System.EventHandler(this.SelectFile_btn_Click);
            // 
            // Swap_btn
            // 
            this.Swap_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Swap_btn.Location = new System.Drawing.Point(383, 12);
            this.Swap_btn.Name = "Swap_btn";
            this.Swap_btn.Size = new System.Drawing.Size(80, 30);
            this.Swap_btn.TabIndex = 4;
            this.Swap_btn.Text = "Swap";
            this.Swap_btn.UseVisualStyleBackColor = true;
            this.Swap_btn.Click += new System.EventHandler(this.Swap_btn_Click);
            // 
            // Clear_Output_btn
            // 
            this.Clear_Output_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Output_btn.Location = new System.Drawing.Point(383, 48);
            this.Clear_Output_btn.Name = "Clear_Output_btn";
            this.Clear_Output_btn.Size = new System.Drawing.Size(80, 39);
            this.Clear_Output_btn.TabIndex = 5;
            this.Clear_Output_btn.Text = "Clear Output";
            this.Clear_Output_btn.UseVisualStyleBackColor = true;
            this.Clear_Output_btn.Click += new System.EventHandler(this.Clear_Output_btn_Click);
            // 
            // Lab2_btn
            // 
            this.Lab2_btn.Location = new System.Drawing.Point(12, 48);
            this.Lab2_btn.Name = "Lab2_btn";
            this.Lab2_btn.Size = new System.Drawing.Size(80, 30);
            this.Lab2_btn.TabIndex = 6;
            this.Lab2_btn.Text = "Lab2";
            this.Lab2_btn.UseVisualStyleBackColor = true;
            this.Lab2_btn.Click += new System.EventHandler(this.Lab2_btn_Click);
            // 
            // Lab3_btn
            // 
            this.Lab3_btn.Location = new System.Drawing.Point(12, 84);
            this.Lab3_btn.Name = "Lab3_btn";
            this.Lab3_btn.Size = new System.Drawing.Size(80, 30);
            this.Lab3_btn.TabIndex = 7;
            this.Lab3_btn.Text = "Lab3";
            this.Lab3_btn.UseVisualStyleBackColor = true;
            this.Lab3_btn.Click += new System.EventHandler(this.Lab3_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 634);
            this.Controls.Add(this.Lab3_btn);
            this.Controls.Add(this.Lab2_btn);
            this.Controls.Add(this.Clear_Output_btn);
            this.Controls.Add(this.Swap_btn);
            this.Controls.Add(this.SelectFile_btn);
            this.Controls.Add(this.Lab1_btn);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private Button Lab1_btn;
        private Button SelectFile_btn;
        private Button Swap_btn;
        private Button Clear_Output_btn;
        private Button Lab2_btn;
        private Button Lab3_btn;
    }
}