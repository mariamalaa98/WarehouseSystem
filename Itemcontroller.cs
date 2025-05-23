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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Desktop_project
{
    public partial class Itemcontroller : UserControl
    {
        public Itemcontroller()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createitem_Click(object sender, EventArgs e)
        {

            try
            {
                // Retrieve values from textboxes
                string code = textBox4.Text.Trim();
                string name = textBox2.Text.Trim();
                int warehouseId = int.Parse(textBox3.Text); // Convert warehouse ID to int

                // Create a new Item object using object initializer
                Item newItem = new Item
                {
                    Code = code,
                    Name = name,
                    Warehouseid = warehouseId
                };


                // Add to the database
                using (var context = new EntityContext())
                {
                    context.Items.Add(newItem);
                    context.SaveChanges();
                }

                // Show success message
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear textboxes after successful addition
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateitem_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = int.Parse(textBox1.Text.Trim()); // Assuming TextBox1 holds ItemId
                string newName = textBox2.Text.Trim();
                int newWarehouseId = int.Parse(textBox3.Text.Trim());

                using (var context = new EntityContext())
                {
                    // Find the item by ID
                    var existingItem = context.Items.FirstOrDefault(i => i.ItemId == itemId);

                    if (existingItem != null)
                    {
                        // Update properties
                        existingItem.Name = newName;
                        existingItem.Warehouseid = newWarehouseId;

                        context.SaveChanges(); // Save changes to DB
                        MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

    }



}

