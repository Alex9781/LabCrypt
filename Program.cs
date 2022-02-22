namespace LabCrypt
{
    internal static class Program
    {
        public static string InputText = "";
        public static string OutputText = "";
        public static List<Form> Forms = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Forms.Add(new Form1());
            Application.Run(Forms[0]);
        }

        public static void ApplicationExit(object sender, EventArgs e)
        {
            foreach (Form form in Forms)
            {
                if (form == sender) continue;
                form.Close();
            }
        }

        public static void SelectFile()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = "C:\\Users\\alexz\\Desktop\\Univer\\2.2\\Крипта";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new(fileStream);
                Program.InputText = reader.ReadToEnd();
            }
        }

        public static void SwapText()
        {
            var a = Program.InputText;
            Program.InputText = Program.OutputText;
            Program.OutputText = a;
        }
    }
}
