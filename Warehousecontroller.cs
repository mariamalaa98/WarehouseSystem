using EF_Desktop_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EF_Desktop_project.Form1;

namespace EF_Desktop_project
{
    public partial class Warehousecontroller : UserControl
    {
        public Warehousecontroller()
        {
            InitializeComponent();
        }

        private void addwarehouse_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                // Add warehouse from the form
                using (var context = new EntityContext())
                {
                    var warehouse = new Warehouse(textBox2.Text, textBox4.Text, int.TryParse(textBox6.Text, out int managerId) ? managerId : (int?)null);
                    context.Warehouses.Add(warehouse);
                    context.SaveChanges();
                }

                MessageBox.Show("Warehouse added successfully.");
            }
        }

        private void updatecustomer_Click(object sender, EventArgs e)
        {
            //i want to update the warehouse name and address
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                using (var context = new EntityContext())
                {
                    var warehouse = context.Warehouses.Find(int.TryParse(textBox1.Text, out int id) ? id : 0);
                    if (warehouse == null)
                    {
                        MessageBox.Show("Warehouse not found.");
                        return;
                    }
                    warehouse.Name = textBox4.Text;
                    warehouse.Address = textBox2.Text;
                    warehouse.ManagerId = int.TryParse(textBox6.Text, out int managerId) ? managerId : (int?)null;
                    context.SaveChanges();
                }
                MessageBox.Show("Warehouse updated successfully.");
            }
        }
    }
}
