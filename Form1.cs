
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarStoreAppGUI
{
    public partial class Car_Store : Form
    {
        Store myStore = new Store();
        //binding source - zrodlo wiazace, do powiazania klasy Store
        //z ListBoxem Car inventory (klasa z kontrolka)
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource shoppingCartBindingSource = new BindingSource();
        BindingSource carHistoryBindingSource = new BindingSource();
        //myStore.CarList --> Binding Source --> inventory list
        

        public Car_Store()
        {
            InitializeComponent();
        }

        private void create_a_car_Click(object sender, EventArgs e)
        {
            if(marka_textbox.Text !="" && model_textbox.Text !="" &&price_textbox.Text!=""&&country_combobox.SelectedItem!=null&&vintage_combobox.SelectedItem!=null)
            {
                decimal cenal;
                string cenat = price_textbox.Text;
                bool success = decimal.TryParse(cenat, out cenal);

                if (success)
                {
                    Car samochod = new Car(marka_textbox.Text, model_textbox.Text, decimal.Parse(price_textbox.Text),country_combobox.SelectedItem.ToString(),vintage_combobox.SelectedItem.ToString());

                    //MessageBox.Show(samochod.ToString());
                    myStore.Car_List.Add(samochod);
                    carInventoryBindingSource.ResetBindings(false);
                    //true - zmieniamy strukture obiektu
                    //false - zmieniamy tylko jego wartosci parametrow

                    marka_textbox.Text = "";
                    model_textbox.Text = "";
                    price_textbox.Text = "";
                    country_combobox.SelectedItem = null;
                    vintage_combobox.SelectedItem = null;
                    label_idt.Visible = false;
                }
                else
                {
                    label_idt.Visible = true;
                }
            }
            
        }

        private void add_to_cart_Click(object sender, EventArgs e)
        {
            if(CarInventory_Listbox.Items != null)
            {
                //get the selected item from the inventory
                Car selected = (Car)CarInventory_Listbox.SelectedItem;
                //(Car) - obietnica ze to na pewno obiekt klasy samochod
                myStore.Shopping_List.Add(selected);

                //add that item to the cart
                //uptade listbox control
                shoppingCartBindingSource.ResetBindings(false);
            }          
        }

        private void total_cost_Click(object sender, EventArgs e)
        {
            if(ShoppingCart_ListBox.Items != null)
            {
                decimal total = myStore.Podsumowanie();
                totalcost_label.Text = total.ToString() + "$";

                //carInventoryBindingSource.ResetBindings(false);
                //wyczyszczenie koszyka po podsumowaniu
            }
        }
        private void Car_Store_Load(object sender, EventArgs e) //FormLoad
        {
            carInventoryBindingSource.DataSource = myStore.Car_List;
            shoppingCartBindingSource.DataSource = myStore.Shopping_List;
            carHistoryBindingSource.DataSource = myStore.History_list;

            CarInventory_Listbox.DataSource = carInventoryBindingSource;
            ShoppingCart_ListBox.DataSource = shoppingCartBindingSource;
            History_listbox.DataSource = carHistoryBindingSource;
            //myStore.CarList --> Binding Source --> inventory list
            CarInventory_Listbox.DisplayMember = ToString();
            ShoppingCart_ListBox.DisplayMember = ToString();
            History_listbox.DisplayMember = ToString();
            //to co sie wyswietli w listboxies
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_to_history_Click(object sender, EventArgs e)
        {
            Car selected = (Car)CarInventory_Listbox.SelectedItem;
            myStore.History_list.Add(selected);
            //carHistoryBindingSource.ResetBindings(false);

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string history_file = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\CarStoreAppGUI\car_history.txt");
            string history_file_path = Path.GetFullPath(history_file);

            //string history_file_path = @"C:\Users\Mateusz\Desktop\PLIKI - PROGRAMY,PROGRAMOWANIE\Visual Studio\CarStoreAppGUI\car_history.txt";
            StreamWriter plik = new StreamWriter(history_file_path,true);

            plik.WriteLine(selected.ToString());
            plik.Close();
        }

        private void download_history_Click(object sender, EventArgs e)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string history_file = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\CarStoreAppGUI\car_history.txt");
            string history_file_path = Path.GetFullPath(history_file);
            //string history_file_path = @"C:\Users\Mateusz\Desktop\PLIKI - PROGRAMY,PROGRAMOWANIE\Visual Studio\CarStoreAppGUI\car_history.txt";
            try
            {
                using (StreamReader plik = File.OpenText(history_file_path))
                {
                    int licznik = 0;
                    foreach (string linia in File.ReadAllLines(history_file_path))
                    {
                        if (linia != String.Empty) ++licznik;
                    }                   
                    
                    string[] lines = new string[licznik];
                    foreach (string line in File.ReadLines(history_file_path))
                    {                                            
                        lines = File.ReadAllLines(history_file_path);
                        foreach(string lines_tab_lines in lines)
                        {
                            string[] obiekt = lines_tab_lines.Split(';');
                            Car samochod = new Car(obiekt[0], obiekt[1], decimal.Parse(obiekt[2]), obiekt[3], obiekt[4]);
                            myStore.History_list.Add(samochod);
                        }                                              
                    }
                    
                    carHistoryBindingSource.ResetBindings(false);
                    plik.Close();
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("FILE READING ERROR");
            }
        }

        private void add_to_inventory_Click(object sender, EventArgs e)
        {
            if(History_listbox.Items != null)
            {
                Car selected = (Car)History_listbox.SelectedItem;
                myStore.Car_List.Add(selected);
                carInventoryBindingSource.ResetBindings(false);
            }          
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            marka_textbox.Text = "";
            model_textbox.Text = "";
            price_textbox.Text = "";
            country_combobox.SelectedItem = null;
            vintage_combobox.SelectedItem = null;
        }

        private void delete_from_inventory_Click(object sender, EventArgs e)
        {
            if (CarInventory_Listbox.Items != null)
            {
                Car selected = (Car)CarInventory_Listbox.SelectedItem;
                myStore.Car_List.Remove(selected);
                carInventoryBindingSource.ResetBindings(false);
            }
        }

        private void clear_history_file_Click(object sender, EventArgs e)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string history_file = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\CarStoreAppGUI\car_history.txt");
            string history_file_path = Path.GetFullPath(history_file);
            //string history_file_path = @"C:\Users\Mateusz\Desktop\PLIKI - PROGRAMY,PROGRAMOWANIE\Visual Studio\car_history.txt";
            StreamWriter plik = new StreamWriter(history_file_path, true);
            File.WriteAllText(history_file_path, "");
        }

        private void delete_from_cart_Click(object sender, EventArgs e)
        {
            if (ShoppingCart_ListBox.Items != null)
            {
                Car selected = (Car)ShoppingCart_ListBox.SelectedItem;
                myStore.Shopping_List.Remove(selected);
                shoppingCartBindingSource.ResetBindings(false);
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear history file - deletes all data in history file" +
                            "Download history   - downloads all data from history file");
        }

        private void create_order_Click(object sender, EventArgs e)
        {
            if(CarInventory_Listbox.Items != null)
            {
                Form2 f2 = new Form2(this);
                f2.Owner = this;
                f2.ShowDialog();
            }                     
        }
    }
}






//--------------------------------------------------------------------------------
// DO ZROBIENIA
//
//(-)1. download_history_click - what if file is empty? (for ex. show message box)
//(+)2. delete_from_cart - create instructions (deleting + total cost?) *DONE*
//(-)3. create_order - new form, user class (user data), order class (order data)
//(+)4. delete_from_inventory - button is not deleting selected car objects *DONE*
//(+/2)5. help_btn with message box which contains instructions to other buttons
//--------------------------------------------------------------------------------