namespace LabCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            UpdateForm();
        }

        public void UpdateForm()
        {
            this.InputTextBox.Text = Program.InputText;
            this.OutputTextBox.Text = Program.OutputText;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.InputText = this.InputTextBox.Text;
        }

        private void SelectFile_btn_Click(object sender, EventArgs e)
        {
            Program.SelectFile();
            this.InputTextBox.Text = Program.InputText;
        }

        private void Swap_btn_Click(object sender, EventArgs e)
        {
            Program.SwapText();
            this.InputTextBox.Text = Program.InputText;
            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Clear_Output_btn_Click(object sender, EventArgs e)
        {
            Program.OutputText = "";
            this.InputTextBox.Text = Program.InputText;
            this.OutputTextBox.Text = Program.OutputText;
        }

        private void Lab1_btn_Click(object sender, EventArgs e)
        {
            if (Program.Forms.FindIndex(form => form.GetType() == typeof(Lab1)) == -1)
            {
                Lab1 lab1 = new();
                lab1.UpdateForm();
                lab1.Show();
            }
            else 
            {
                Lab1 lab1 = Program.Forms.OfType<Lab1>().First();
                lab1.UpdateForm();
                lab1.Show();
            }

            this.Hide();
        }

        private void Lab2_btn_Click(object sender, EventArgs e)
        {
            if (Program.Forms.FindIndex(form => form.GetType() == typeof(Lab2)) == -1)
            {
                Lab2 lab2 = new();
                lab2.UpdateForm();
                lab2.Show();
            }
            else
            {
                Lab2 lab2 = Program.Forms.OfType<Lab2>().First();
                lab2.UpdateForm();
                lab2.Show();
            }

            this.Hide();
        }

        private void Lab3_btn_Click(object sender, EventArgs e)
        {
            if (Program.Forms.FindIndex(form => form.GetType() == typeof(Lab3)) == -1)
            {
                Lab3 lab3 = new();
                lab3.UpdateForm();
                lab3.Show();
            }
            else
            {
                Lab3 lab3 = Program.Forms.OfType<Lab3>().First();
                lab3.UpdateForm();
                lab3.Show();
            }

            this.Hide();
        }

        private void Lab4_btn_Click(object sender, EventArgs e)
        {
            if (Program.Forms.FindIndex(form => form.GetType() == typeof(Lab4)) == -1)
            {
                Lab4 lab4 = new();
                lab4.UpdateForm();
                lab4.Show();
            }
            else
            {
                Lab4 lab4 = Program.Forms.OfType<Lab4>().First();
                lab4.UpdateForm();
                lab4.Show();
            }

            this.Hide();
        }
    }
}
