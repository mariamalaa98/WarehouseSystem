namespace EF_Desktop_project
{
    partial class Warehousecontroller
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            updatecustomer = new Button();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            addwarehouse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 17;
            label1.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 29);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 21;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 90);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 22;
            label5.Text = "Mng_id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 164);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 24;
            // 
            // updatecustomer
            // 
            updatecustomer.Location = new Point(332, 187);
            updatecustomer.Name = "updatecustomer";
            updatecustomer.Size = new Size(167, 29);
            updatecustomer.TabIndex = 32;
            updatecustomer.Text = "Update_WareHouse";
            updatecustomer.UseVisualStyleBackColor = true;
            updatecustomer.Click += updatecustomer_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(71, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(332, 87);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(199, 27);
            textBox6.TabIndex = 28;
            // 
            // addwarehouse
            // 
            addwarehouse.Location = new Point(77, 187);
            addwarehouse.Name = "addwarehouse";
            addwarehouse.Size = new Size(167, 29);
            addwarehouse.TabIndex = 33;
            addwarehouse.Text = "Add_WareHouse";
            addwarehouse.UseVisualStyleBackColor = true;
            addwarehouse.Click += addwarehouse_Click;
            // 
            // Warehousecontroller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addwarehouse);
            Controls.Add(updatecustomer);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Warehousecontroller";
            Size = new Size(561, 301);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button updatecustomer;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button createwarehouse;
        private Button addwarehouse;
    }
}
