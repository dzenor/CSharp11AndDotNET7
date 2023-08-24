namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);

            MessageBox.Show(text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;
            string name = textBox2.Text;

            MessageBox.Show(address + " " + name);

        }
    }
}