namespace EF_Desktop_project
{
    partial class Itemcontroller
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
            updateitem = new Button();
            createitem = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // updateitem
            // 
            updateitem.Location = new Point(407, 258);
            updateitem.Name = "updateitem";
            updateitem.Size = new Size(138, 29);
            updateitem.TabIndex = 32;
            updateitem.Text = "Update_Item";
            updateitem.UseVisualStyleBackColor = true;
            updateitem.Click += updateitem_Click;
            // 
            // createitem
            // 
            createitem.Location = new Point(103, 258);
            createitem.Name = "createitem";
            createitem.Size = new Size(138, 29);
            createitem.TabIndex = 31;
            createitem.Text = "Add_Item";
            createitem.UseVisualStyleBackColor = true;
            createitem.Click += createitem_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 87);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 22;
            label5.Text = "unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 65);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 21;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 179);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 20;
            label3.Text = "WH_Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 120);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 19;
            label2.Text = "Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "Item_id";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(407, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 33;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Itemcontroller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(updateitem);
            Controls.Add(createitem);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Itemcontroller";
            Size = new Size(596, 301);
            Load += Item_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateitem;
        private Button createitem;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
    }
}
