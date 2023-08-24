using Microsoft.EntityFrameworkCore;
using ToDo_Db;

namespace ToDo_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void FillData()
        {
            using (TodoContext db = new TodoContext())

                DbSet<Shopping> ShoppingList = db.Shoppings;

        }


        private void Shopping_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}