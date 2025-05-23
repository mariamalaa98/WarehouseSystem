using EF_Desktop_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EF_Desktop_project
{
    public partial class Suppliercontroller : UserControl
    {
        public Suppliercontroller()
        {
            InitializeComponent();
        }

        private void createSupplier_Click(object sender, EventArgs e)
        {
            //  i want to add new customer to DB
            // Validate input
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (var context = new EntityContext())
                {
                    var supplier = new Supplier
                    {
                        Name = textBox4.Text.Trim(),
                        HomePhone = textBox3.Text.Trim(),
                        Phone = textBox2.Text.Trim(),
                        Fax = textBox6.Text.Trim(),
                        Mail = textBox5.Text.Trim(),
                        Website = textBox7.Text.Trim()
                    };

                    context.Suppliers.Add(supplier);
                    context.SaveChanges();
                }

                MessageBox.Show("supplier added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        

        private void updateSupplier_Click(object sender, EventArgs e)
        {
            // update supplier name, homephone, phone, fax, mail, website
            //Validate input
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a customer ID.");
                return;
            }

            try
            {
                using (var context = new EntityContext())
                {
                    var supplierId = int.Parse(textBox1.Text.Trim());
                    var supplier = context.Suppliers.Find(supplierId);

                    if (supplier == null)
                    {
                        MessageBox.Show("supplier not found.");
                        return;
                    }

                    supplier.Name = textBox4.Text.Trim();
                    supplier.HomePhone = textBox3.Text.Trim();
                    supplier.Phone = textBox2.Text.Trim();
                    supplier.Fax = textBox6.Text.Trim();
                    supplier.Mail = textBox5.Text.Trim();
                    supplier.Website = textBox7.Text.Trim();

                    context.SaveChanges();
                }

                MessageBox.Show("supplier updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
    }


