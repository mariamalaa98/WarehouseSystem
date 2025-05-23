using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using EF_Desktop_project.Models;
using Microsoft.VisualBasic.ApplicationServices;
namespace EF_Desktop_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Warehousecontroller warehouse = new Warehousecontroller();
            panel1.Controls.Add(warehouse);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Itemcontroller item = new Itemcontroller();
            panel1.Controls.Add(item);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CustomerController cust = new CustomerController();
            panel1.Controls.Add(cust);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Suppliercontroller supplier = new Suppliercontroller();
            panel1.Controls.Add(supplier);
        }
    }
}
