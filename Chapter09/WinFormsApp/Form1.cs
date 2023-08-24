using Newtonsoft.Json;
using Packt.Shared;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.CheckFileExists)
            {
                string jsonText = File.ReadAllText(this.openFileDialog1.FileName);
                List<Person>? people = JsonConvert.DeserializeObject<List<Person>>(jsonText);

                if (people != null)
                {
                    this.label1.Text = "";
                    foreach (var item in people)
                    {
                        this.label1.Text += item.FirstName + " ";
                    }
                }
            }
        }
    }
}