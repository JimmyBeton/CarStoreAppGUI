
namespace CarStoreAppGUI
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create_client = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.streetTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.cleardata_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.orderid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderid);
            this.groupBox1.Controls.Add(this.cleardata_btn);
            this.groupBox1.Controls.Add(this.cityTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.countryCombobox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.streetTextbox);
            this.groupBox1.Controls.Add(this.create_client);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textbox_surname);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // create_client
            // 
            this.create_client.Location = new System.Drawing.Point(116, 247);
            this.create_client.Name = "create_client";
            this.create_client.Size = new System.Drawing.Size(206, 45);
            this.create_client.TabIndex = 5;
            this.create_client.Text = "Generate order";
            this.create_client.UseVisualStyleBackColor = true;
            this.create_client.Click += new System.EventHandler(this.create_client_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(119, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "COMPLETE ALL DATA!";
            this.label3.Visible = false;
            // 
            // textbox_surname
            // 
            this.textbox_surname.Location = new System.Drawing.Point(75, 61);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(344, 22);
            this.textbox_surname.TabIndex = 3;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(75, 33);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(344, 22);
            this.textbox_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(358, 355);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(73, 43);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(17, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ORDER GENERATED SUCCESFULLY";
            this.label4.Visible = false;
            // 
            // streetTextbox
            // 
            this.streetTextbox.Location = new System.Drawing.Point(75, 108);
            this.streetTextbox.Name = "streetTextbox";
            this.streetTextbox.Size = new System.Drawing.Size(161, 22);
            this.streetTextbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Street:";
            // 
            // countryCombobox
            // 
            this.countryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.Items.AddRange(new object[] {
            "PL",
            "DE",
            "UK",
            "FR",
            "SW",
            "AU",
            "SPA",
            "POR",
            "RUS",
            "USA",
            "CH",
            "JAP",
            "AUS",
            "CZ",
            "SLO",
            "ITA",
            "HUN"});
            this.countryCombobox.Location = new System.Drawing.Point(331, 108);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(88, 24);
            this.countryCombobox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "City:";
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(75, 136);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(161, 22);
            this.cityTextbox.TabIndex = 11;
            // 
            // cleardata_btn
            // 
            this.cleardata_btn.Location = new System.Drawing.Point(331, 139);
            this.cleardata_btn.Name = "cleardata_btn";
            this.cleardata_btn.Size = new System.Drawing.Size(88, 29);
            this.cleardata_btn.TabIndex = 12;
            this.cleardata_btn.Text = "Clear data";
            this.cleardata_btn.UseVisualStyleBackColor = true;
            this.cleardata_btn.Click += new System.EventHandler(this.cleardata_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // orderid
            // 
            this.orderid.AutoSize = true;
            this.orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderid.Location = new System.Drawing.Point(19, 183);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(53, 20);
            this.orderid.TabIndex = 13;
            this.orderid.Text = "label8";
            this.orderid.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "CarStoreApp-GeneratingOrder";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox countryCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox streetTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cleardata_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label orderid;
    }
}