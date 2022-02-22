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
                Lab1 lab1 = (Lab1)Program.Forms[1];
                lab1.UpdateForm();
                lab1.Show();
            }

            this.Hide();
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
                Lab2 lab2 = (Lab2)Program.Forms[1];
                lab2.UpdateForm();
                lab2.Show();
            }

            this.Hide();
        }
    }
}
