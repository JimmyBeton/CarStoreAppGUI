using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace CarStoreAppGUI
{
    public partial class Form2 : Form
    {
        Car_Store car_store;
        int seconds = 0;
        //static List<string> order_list = new List<string>();

        //BindingSource order_bindingSource = new BindingSource();
        public Form2(Car_Store car_store)
        {
            this.car_store = car_store;
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
           //
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void download_shoplist_btn_Click(object sender, EventArgs e)
        {
            //Car_Store form1 = new Car_Store();
            //order_listbox.Items.Add(form1.myS)
            
        }

        private void create_client_Click(object sender, EventArgs e) //GENERATE ORDER
        {
            //check if all data is completed
            if (textbox_name.Text != "" && textbox_surname.Text != "" && streetTextbox.Text != "" && cityTextbox.Text != "" && countryCombobox.SelectedItem != null)
            {
                label3.Visible = false;
                label4.Visible = true;

                DateTime localDate = DateTime.Now;
                string date_str = localDate.ToString("dd/MM/yyyy;HH:mm:ss");

                string id = date_str;
                orderid.Text = id;
                orderid.Visible = true;
                               
                Client client = new Client(textbox_name.Text, textbox_surname.Text,id, streetTextbox.Text, cityTextbox.Text, countryCombobox.SelectedItem.ToString());
                client.orderslist.Add(client);


                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string order_file = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\CarStoreAppGUI\orders.txt");
                string order_file_path = Path.GetFullPath(order_file);
                //string order_file_path = @"C:\Users\Mateusz\Desktop\PLIKI - PROGRAMY,PROGRAMOWANIE\Visual Studio\CarStoreAppGUI\orders.txt";
                StreamWriter plik = new StreamWriter(order_file_path, true);

                plik.WriteLine(client.ToString());
                plik.Close();

                timer1.Enabled = true;

            }
            else
            {
                label3.Visible = true;
            }
        }

        private void cleardata_btn_Click(object sender, EventArgs e)
        {
            textbox_name.Text = "";
            textbox_surname.Text = "";
            streetTextbox.Text = "";
            countryCombobox.SelectedItem = null;
            cityTextbox.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 3)
            {
                textbox_name.Text = "";
                textbox_surname.Text = "";
                streetTextbox.Text = "";
                countryCombobox.SelectedItem = null;
                cityTextbox.Text = "";
                orderid.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                create_client.Enabled = false;
                seconds = 0;
                this.Close();
            }
        }
    }
}
