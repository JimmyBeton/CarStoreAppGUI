
namespace CarStoreAppGUI
{
    partial class Car_Store
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_idt = new System.Windows.Forms.Label();
            this.create_a_car = new System.Windows.Forms.Button();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.marka_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarInventory_Listbox = new System.Windows.Forms.ListBox();
            this.add_to_cart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShoppingCart_ListBox = new System.Windows.Forms.ListBox();
            this.total_cost = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalcost_label = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.History_listbox = new System.Windows.Forms.ListBox();
            this.add_to_inventory = new System.Windows.Forms.Button();
            this.country_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clear_data = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vintage_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.download_history = new System.Windows.Forms.Button();
            this.save_to_history = new System.Windows.Forms.Button();
            this.create_order = new System.Windows.Forms.Button();
            this.delete_from_inventory = new System.Windows.Forms.Button();
            this.delete_from_cart = new System.Windows.Forms.Button();
            this.clear_history_file = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.help_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_idt);
            this.groupBox1.Controls.Add(this.create_a_car);
            this.groupBox1.Controls.Add(this.price_textbox);
            this.groupBox1.Controls.Add(this.model_textbox);
            this.groupBox1.Controls.Add(this.marka_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            // 
            // label_idt
            // 
            this.label_idt.AutoSize = true;
            this.label_idt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_idt.ForeColor = System.Drawing.Color.Red;
            this.label_idt.Location = new System.Drawing.Point(69, 113);
            this.label_idt.Name = "label_idt";
            this.label_idt.Size = new System.Drawing.Size(158, 17);
            this.label_idt.TabIndex = 7;
            this.label_idt.Text = "INVALID DATA TYPE";
            this.label_idt.Visible = false;
            // 
            // create_a_car
            // 
            this.create_a_car.Location = new System.Drawing.Point(39, 149);
            this.create_a_car.Name = "create_a_car";
            this.create_a_car.Size = new System.Drawing.Size(154, 39);
            this.create_a_car.TabIndex = 6;
            this.create_a_car.Text = "Create a car";
            this.create_a_car.UseVisualStyleBackColor = true;
            this.create_a_car.Click += new System.EventHandler(this.create_a_car_Click);
            // 
            // price_textbox
            // 
            this.price_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_textbox.Location = new System.Drawing.Point(72, 88);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(159, 22);
            this.price_textbox.TabIndex = 5;
            // 
            // model_textbox
            // 
            this.model_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.model_textbox.Location = new System.Drawing.Point(72, 59);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(159, 22);
            this.model_textbox.TabIndex = 4;
            // 
            // marka_textbox
            // 
            this.marka_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marka_textbox.Location = new System.Drawing.Point(72, 30);
            this.marka_textbox.Name = "marka_textbox";
            this.marka_textbox.Size = new System.Drawing.Size(159, 22);
            this.marka_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarInventory_Listbox);
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 560);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory (list of cars)";
            // 
            // CarInventory_Listbox
            // 
            this.CarInventory_Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarInventory_Listbox.FormattingEnabled = true;
            this.CarInventory_Listbox.ItemHeight = 16;
            this.CarInventory_Listbox.Location = new System.Drawing.Point(6, 21);
            this.CarInventory_Listbox.Name = "CarInventory_Listbox";
            this.CarInventory_Listbox.Size = new System.Drawing.Size(344, 530);
            this.CarInventory_Listbox.TabIndex = 0;
            // 
            // add_to_cart
            // 
            this.add_to_cart.Location = new System.Drawing.Point(537, 578);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(165, 39);
            this.add_to_cart.TabIndex = 2;
            this.add_to_cart.Text = "Add to cart";
            this.add_to_cart.UseVisualStyleBackColor = true;
            this.add_to_cart.Click += new System.EventHandler(this.add_to_cart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShoppingCart_ListBox);
            this.groupBox3.Location = new System.Drawing.Point(724, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 560);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping cart";
            // 
            // ShoppingCart_ListBox
            // 
            this.ShoppingCart_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShoppingCart_ListBox.FormattingEnabled = true;
            this.ShoppingCart_ListBox.ItemHeight = 16;
            this.ShoppingCart_ListBox.Location = new System.Drawing.Point(6, 21);
            this.ShoppingCart_ListBox.Name = "ShoppingCart_ListBox";
            this.ShoppingCart_ListBox.Size = new System.Drawing.Size(333, 530);
            this.ShoppingCart_ListBox.TabIndex = 0;
            // 
            // total_cost
            // 
            this.total_cost.Location = new System.Drawing.Point(971, 575);
            this.total_cost.Name = "total_cost";
            this.total_cost.Size = new System.Drawing.Size(104, 40);
            this.total_cost.TabIndex = 4;
            this.total_cost.Text = "Total cost";
            this.total_cost.UseVisualStyleBackColor = true;
            this.total_cost.Click += new System.EventHandler(this.total_cost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total cost: ";
            // 
            // totalcost_label
            // 
            this.totalcost_label.AutoSize = true;
            this.totalcost_label.Location = new System.Drawing.Point(826, 589);
            this.totalcost_label.Name = "totalcost_label";
            this.totalcost_label.Size = new System.Drawing.Size(48, 17);
            this.totalcost_label.TabIndex = 6;
            this.totalcost_label.Text = "0.00 $";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(4, 48);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 37);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.History_listbox);
            this.groupBox4.Location = new System.Drawing.Point(2, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 357);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "History";
            // 
            // History_listbox
            // 
            this.History_listbox.FormattingEnabled = true;
            this.History_listbox.ItemHeight = 16;
            this.History_listbox.Location = new System.Drawing.Point(9, 21);
            this.History_listbox.Name = "History_listbox";
            this.History_listbox.Size = new System.Drawing.Size(345, 324);
            this.History_listbox.TabIndex = 0;
            // 
            // add_to_inventory
            // 
            this.add_to_inventory.Location = new System.Drawing.Point(4, 8);
            this.add_to_inventory.Name = "add_to_inventory";
            this.add_to_inventory.Size = new System.Drawing.Size(168, 37);
            this.add_to_inventory.TabIndex = 9;
            this.add_to_inventory.Text = "Add to inventory";
            this.add_to_inventory.UseVisualStyleBackColor = true;
            this.add_to_inventory.Click += new System.EventHandler(this.add_to_inventory_Click);
            // 
            // country_combobox
            // 
            this.country_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_combobox.FormattingEnabled = true;
            this.country_combobox.Items.AddRange(new object[] {
            "PL",
            "DE",
            "UK",
            "FR",
            "RUS",
            "CZ",
            "SLO",
            "USA",
            "JP",
            "CH",
            "SPA",
            "POR",
            "SW",
            "AU",
            "HUN",
            "FIN",
            "NOR",
            "SWE",
            "UKR",
            "BEL",
            "ITA"});
            this.country_combobox.Location = new System.Drawing.Point(6, 30);
            this.country_combobox.Name = "country_combobox";
            this.country_combobox.Size = new System.Drawing.Size(95, 24);
            this.country_combobox.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clear_data);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.vintage_combobox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.country_combobox);
            this.groupBox5.Location = new System.Drawing.Point(255, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 195);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // clear_data
            // 
            this.clear_data.Location = new System.Drawing.Point(6, 149);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(95, 39);
            this.clear_data.TabIndex = 14;
            this.clear_data.Text = "Clear data";
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vintage:";
            // 
            // vintage_combobox
            // 
            this.vintage_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vintage_combobox.FormattingEnabled = true;
            this.vintage_combobox.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.vintage_combobox.Location = new System.Drawing.Point(6, 88);
            this.vintage_combobox.Name = "vintage_combobox";
            this.vintage_combobox.Size = new System.Drawing.Size(95, 24);
            this.vintage_combobox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country:";
            // 
            // download_history
            // 
            this.download_history.Location = new System.Drawing.Point(180, 8);
            this.download_history.Name = "download_history";
            this.download_history.Size = new System.Drawing.Size(165, 37);
            this.download_history.TabIndex = 12;
            this.download_history.Text = "Download history";
            this.download_history.UseVisualStyleBackColor = true;
            this.download_history.Click += new System.EventHandler(this.download_history_Click);
            // 
            // save_to_history
            // 
            this.save_to_history.Location = new System.Drawing.Point(368, 578);
            this.save_to_history.Name = "save_to_history";
            this.save_to_history.Size = new System.Drawing.Size(163, 39);
            this.save_to_history.TabIndex = 13;
            this.save_to_history.Text = "Save to history file";
            this.save_to_history.UseVisualStyleBackColor = true;
            this.save_to_history.Click += new System.EventHandler(this.save_to_history_Click);
            // 
            // create_order
            // 
            this.create_order.Location = new System.Drawing.Point(971, 621);
            this.create_order.Name = "create_order";
            this.create_order.Size = new System.Drawing.Size(104, 40);
            this.create_order.TabIndex = 14;
            this.create_order.Text = "Create order";
            this.create_order.UseVisualStyleBackColor = true;
            this.create_order.Click += new System.EventHandler(this.create_order_Click);
            // 
            // delete_from_inventory
            // 
            this.delete_from_inventory.Location = new System.Drawing.Point(537, 621);
            this.delete_from_inventory.Name = "delete_from_inventory";
            this.delete_from_inventory.Size = new System.Drawing.Size(165, 37);
            this.delete_from_inventory.TabIndex = 15;
            this.delete_from_inventory.Text = "Delete from Inventory";
            this.delete_from_inventory.UseVisualStyleBackColor = true;
            this.delete_from_inventory.Click += new System.EventHandler(this.delete_from_inventory_Click);
            // 
            // delete_from_cart
            // 
            this.delete_from_cart.Location = new System.Drawing.Point(745, 621);
            this.delete_from_cart.Name = "delete_from_cart";
            this.delete_from_cart.Size = new System.Drawing.Size(186, 37);
            this.delete_from_cart.TabIndex = 16;
            this.delete_from_cart.Text = "Delete from shopping cart";
            this.delete_from_cart.UseVisualStyleBackColor = true;
            this.delete_from_cart.Click += new System.EventHandler(this.delete_from_cart_Click);
            // 
            // clear_history_file
            // 
            this.clear_history_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_history_file.ForeColor = System.Drawing.Color.Red;
            this.clear_history_file.Location = new System.Drawing.Point(180, 48);
            this.clear_history_file.Name = "clear_history_file";
            this.clear_history_file.Size = new System.Drawing.Size(165, 37);
            this.clear_history_file.TabIndex = 17;
            this.clear_history_file.Text = "Clear history file";
            this.clear_history_file.UseVisualStyleBackColor = true;
            this.clear_history_file.Click += new System.EventHandler(this.clear_history_file_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.help_btn);
            this.groupBox6.Controls.Add(this.download_history);
            this.groupBox6.Controls.Add(this.clear_history_file);
            this.groupBox6.Controls.Add(this.add_to_inventory);
            this.groupBox6.Controls.Add(this.exit);
            this.groupBox6.Location = new System.Drawing.Point(11, 572);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 89);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // help_btn
            // 
            this.help_btn.Location = new System.Drawing.Point(87, 48);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(85, 37);
            this.help_btn.TabIndex = 18;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // Car_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 664);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.delete_from_cart);
            this.Controls.Add(this.delete_from_inventory);
            this.Controls.Add(this.create_order);
            this.Controls.Add(this.save_to_history);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.totalcost_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_cost);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.add_to_cart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Car_Store";
            this.Text = "Car Store";
            this.Load += new System.EventHandler(this.Car_Store_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create_a_car;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox marka_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox CarInventory_Listbox;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ShoppingCart_ListBox;
        private System.Windows.Forms.Button total_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalcost_label;
        private System.Windows.Forms.Label label_idt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox History_listbox;
        private System.Windows.Forms.Button add_to_inventory;
        private System.Windows.Forms.ComboBox country_combobox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox vintage_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button download_history;
        private System.Windows.Forms.Button save_to_history;
        private System.Windows.Forms.Button create_order;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.Button delete_from_inventory;
        private System.Windows.Forms.Button delete_from_cart;
        private System.Windows.Forms.Button clear_history_file;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button help_btn;
    }
}

