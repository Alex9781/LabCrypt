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

        private void RenderLab<T>() where T : Form, IMyForm, new()
        {
            if (Program.Forms.FindIndex(form => form.GetType() == typeof(T)) == -1)
            {
                T lab = new();
                lab.UpdateForm();
                lab.Show();
            }
            else
            {
                T lab = Program.Forms.OfType<T>().First();
                lab.UpdateForm();
                lab.Show();
            }

            this.Hide();
        }

        private void Lab1_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab1>();
        }

        private void Lab2_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab2>();
        }

        private void Lab3_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab3>();
        }

        private void Lab4_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab4>();
        }

        private void Lab5_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab5>();
        }

        private void Lab6_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab6>();
        }

        private void Lab7_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab7>();
        }

        private void Lab8_btn_Click(object sender, EventArgs e)
        {
            RenderLab<Lab8>();
        }
    }
}
