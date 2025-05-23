
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
using System.Xml.Linq;

namespace EF_Desktop_project
{
    public partial class CustomerController : UserControl
    {
        public CustomerController()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void createCustomer_Click(object sender, EventArgs e)
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
                    var cust = new Customer
                    {
                        Name = textBox4.Text.Trim(),
                        HomePhone = textBox3.Text.Trim(),
                        Phone = textBox2.Text.Trim(),
                        Fax = textBox6.Text.Trim(),
                        Mail = textBox5.Text.Trim(),
                        Website = textBox7.Text.Trim()
                    };

                    context.Customers.Add(cust);
                    context.SaveChanges();
                }

                MessageBox.Show("Customer added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void updatecustomer_Click(object sender, EventArgs e)
        {
            //update customer name, homephone, phone, fax, mail, website
            // Validate input
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a customer ID.");
                return;
            }

            try
            {
                using (var context = new EntityContext())
                {
                    var customerId = int.Parse(textBox1.Text.Trim());
                    var customer = context.Customers.Find(customerId);

                    if (customer == null)
                    {
                        MessageBox.Show("Customer not found.");
                        return;
                    }

                    customer.Name = textBox4.Text.Trim();
                    customer.HomePhone = textBox3.Text.Trim();
                    customer.Phone = textBox2.Text.Trim();
                    customer.Fax = textBox6.Text.Trim();
                    customer.Mail = textBox5.Text.Trim();
                    customer.Website = textBox7.Text.Trim();

                    context.SaveChanges();
                }

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedItemId = (int)comboBox1.SelectedValue;
                MessageBox.Show($"Selected Item ID: {selectedItemId}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadItemsIntoComboBox();  
        }
        private void LoadItemsIntoComboBox()
        {
            try
            {
                using (var context = new EntityContext()) 
                {
                    var items = context.Items.ToList();
                    comboBox1.DisplayMember = "Name";  
                    comboBox1.ValueMember = "Id";      
                    comboBox1.DataSource = items;                      }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}");
            }
        }

        
void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please enter both Customer ID and Warehouse ID.");
                return;
            }

            try
            {
               
                if (!int.TryParse(textBox1.Text.Trim(), out int customerId))
                {
                    MessageBox.Show("Invalid Customer ID.");
                    return;
                }

                if (!int.TryParse(textBox8.Text.Trim(), out int warehouseId))
                {
                    MessageBox.Show("Invalid Warehouse ID.");
                    return;
                }

                int itemId = (comboBox1.SelectedItem as Item).ItemId;

               
                using (var context = new EntityContext())
                {
                    var itemSupplier = context.SupplierPermissionItems
                                              .Include(spi => spi.SupplierPermission)
                                              .ThenInclude(sp => sp.Supplier)
                                              .FirstOrDefault(spi => spi.ItemId == itemId && spi.SupplierPermission.Warehouse == warehouseId);

                    if (itemSupplier == null)
                    {
                        MessageBox.Show("No supplier found for the selected item and warehouse.");
                        return;
                    }

                    int supplierId = itemSupplier.SupplierPermission.SupplierId;

                    
                    var disposePermission = new DisposePermission
                    {
                        CustomerId = customerId,
                        WarehouseId = warehouseId,
                        PermissionDate = DateOnly.FromDateTime(DateTime.Now),
                        DisposePermissionItems = new List<DisposePermissionItem>
                        {
                            new DisposePermissionItem
                            {
                                ItemId = itemId,
                                SupplierId = supplierId
                            }
                        }
                    };

                   
                    context.DisposePermissions.Add(disposePermission);
                    context.SaveChanges();
                }

                MessageBox.Show("Dispose permission created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}

