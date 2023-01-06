using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Form1 : Form
    {
        CoffeeDataContext db = new CoffeeDataContext();
        public Form1()
        {
            InitializeComponent();
            bindingSourceCoffee.DataSource = db.Coffee_s;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingSourceCoffee.RemoveCurrent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bindingSourceCoffee.EndEdit();
            db.SubmitChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bindingSourceCoffee.AddNew();
          
        }
    }
}
