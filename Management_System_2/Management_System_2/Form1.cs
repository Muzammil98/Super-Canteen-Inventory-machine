using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Management_System_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txt_Coffee.Text = "0";
            txt_ColdDrink.Text = "0";
            txt_CostOfDrinks.Text = "0";
            txt_CostOfFood.Text = "0";
            txt_CustomFries.Text = "0";
            txt_GnSpicy_Fries.Text = "0";
            txt_GreenTea.Text = "0";
            txt_IcedTea.Text = "0";
            txt_MnC_Fries.Text = "0";
            txt_Rice.Text = "0";
            txt_ServiceCharges.Text = "30";
            txt_SubTotal.Text = "0";
            txt_Tax.Text = "0";
            txt_Total.Text = "0";
            txt_Water.Text = "0";
            txt_Zinger.Text = "0";

            //Price(if need to change...change here and also in the buttonTotal code)
            label_price_Coffee.Text = "30";
            label_price_CustomFries.Text = "70";
            label_price_Drinks.Text = "50";
            label_price_GnSFries.Text = "50";
            label_price_GTea.Text = "30";
            label_price_ITea.Text = "30";
            label_price_MnCFries.Text = "50";
            label_price_Rice.Text = "150";
            label_price_Water.Text = "20";
            label_price_ZInger.Text = "150";

          
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            chk_Coffee.Checked = false;
            chk_ColdDrink.Checked = false;
            chk_Custom_Fries.Checked = false;
            chk_GnSpicy_Fries.Checked = false;
            chk_Green_Tea.Checked = false;
            chk_Iced_Tea.Checked = false;
            chk_MnCheese_Fries.Checked = false;
            chk_Rice.Checked = false;
            chk_Water.Checked = false;
            chk_Zinger.Checked = false;

            txt_Coffee.Enabled = false;
            txt_ColdDrink.Enabled = false;
            txt_CostOfDrinks.Enabled = false;
            txt_CostOfFood.Enabled = false;
            txt_CustomFries.Enabled = false;
            txt_GnSpicy_Fries.Enabled = false;
            txt_GreenTea.Enabled = false;
            txt_IcedTea.Enabled = false;
            txt_MnC_Fries.Enabled = false;
            txt_Rice.Enabled = false;
            txt_ServiceCharges.Enabled = false;
            txt_SubTotal.Enabled = false;
            txt_Tax.Enabled = false;
            txt_Total.Enabled = false;
            txt_Water.Enabled = false;
            txt_Zinger.Enabled = false;

            txt_Coffee.Text = "0";
            txt_ColdDrink.Text = "0";
            txt_CostOfDrinks.Text = "0";
            txt_CostOfFood.Text = "0";
            txt_CustomFries.Text = "0";
            txt_GnSpicy_Fries.Text = "0";
            txt_GreenTea.Text = "0";
            txt_IcedTea.Text = "0";
            txt_MnC_Fries.Text = "0";
            txt_Rice.Text = "0";
            txt_ServiceCharges.Text = "30";
            txt_SubTotal.Text = "0";
            txt_Tax.Text = "0";
            txt_Total.Text = "0";
            txt_Water.Text = "0";
            txt_Zinger.Text = "0";
        }
        #region Chk_Enable/Disable_Text_Enable/Disable

        
        private void chk_MnCheese_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MnCheese_Fries.Checked == true)
            {
                txt_MnC_Fries.Enabled = true;
                txt_MnC_Fries.Clear();
                txt_MnC_Fries.Focus();
                
            }
            else
            {
                txt_MnC_Fries.Enabled = false;
                txt_MnC_Fries.Text = "0";
            }
        }

        private void chk_GnSpicy_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_GnSpicy_Fries.Checked == true)
            {
                txt_GnSpicy_Fries.Enabled = true;
                txt_GnSpicy_Fries.Clear();
                txt_GnSpicy_Fries.Focus();
            }
            else
            {
                txt_GnSpicy_Fries.Enabled = false;
                txt_GnSpicy_Fries.Text = "0";
            }
        }

        private void chk_Iced_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Iced_Tea.Checked == true)
            {
                txt_IcedTea.Enabled = true;
                txt_IcedTea.Clear();
                txt_IcedTea.Focus();
            }
            else
            {
                txt_IcedTea.Enabled = false;
                txt_IcedTea.Text = "0";
            }

        }

        private void chk_Green_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Green_Tea.Checked == true)
            {
                txt_GreenTea.Enabled = true;
                txt_GreenTea.Clear();
                txt_GreenTea.Focus();
            }
            else
            {
                txt_GreenTea.Enabled = false;
                txt_GreenTea.Text = "0";
            }
        }

        private void chk_Custom_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Custom_Fries.Checked == true)
            {
                txt_CustomFries.Enabled = true;
                txt_CustomFries.Clear();
                txt_CustomFries.Focus();
            }
            else
            {
                txt_CustomFries.Enabled = false;
                txt_CustomFries.Text = "0";
            }
        }

        private void chk_ColdDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ColdDrink.Checked == true)
            {
                txt_ColdDrink.Enabled = true;
                txt_ColdDrink.Clear();
                txt_ColdDrink.Focus();
            }
            else
            {
                txt_ColdDrink.Enabled = false;
                txt_ColdDrink.Text = "0";
            }
        }

        private void chk_Zinger_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Zinger.Checked == true)
            {
                txt_Zinger.Enabled = true;
                txt_Zinger.Clear();
                txt_Zinger.Focus();
            }
            else
            {
                txt_Zinger.Enabled = false;
                txt_Zinger.Text = "0";
            }
        }

        private void chk_Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Coffee.Checked == true)
            {
                txt_Coffee.Enabled = true;
                txt_Coffee.Clear();
                txt_Coffee.Focus();
            }
            else
            {
                txt_Coffee.Enabled = false;
                txt_Coffee.Text = "0";
            }

        }

        private void chk_Rice_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Rice.Checked == true)
            {
                txt_Rice.Enabled = true;
                txt_Rice.Clear();
                txt_Rice.Focus();
            }
            else
            {
                txt_Rice.Enabled = false;
                txt_Rice.Text = "0";
            }
        }
         

        private void chk_Water_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Water.Checked == true)
            {
                txt_Water.Enabled = true;
                txt_Water.Clear();
                txt_Water.Focus();
            }
            else
            {
                txt_Water.Enabled = false;
                txt_Water.Text = "0";
            }

        }

        #endregion
        #region ToolStrip_Buttons

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richtxt_Reciept.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richtxt_Reciept.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) |*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richtxt_Reciept.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
           
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) |*.*";

            if (saveFile.ShowDialog()== DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                sw.WriteLine(richtxt_Reciept.Text);
                sw.Close();
            }
            
        }
        #endregion


        private void button_Reciept_Click(object sender, EventArgs e)
        {
            richtxt_Reciept.Clear();

            richtxt_Reciept.AppendText(Environment.NewLine);
            richtxt_Reciept.AppendText("\t UBIT SNACKS n DRINKS CANTEEN  " + Environment.NewLine);
            richtxt_Reciept.AppendText("-----------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richtxt_Reciept.AppendText("Mac n Cheese Fries \t\t\t\t" + txt_MnC_Fries.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Garlic n Spicy Fries \t\t\t\t" + txt_GnSpicy_Fries.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Custom Made Fries \t\t\t\t" + txt_CustomFries.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Chicken Broast Zinger \t\t\t\t" + txt_Zinger.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Chicken Manchurian Rice \t\t\t" + txt_Rice.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Iced Tea \t\t\t\t\t" + txt_IcedTea.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Green Tea \t\t\t\t\t" + txt_GreenTea.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Cold Drinks \t\t\t\t\t" + txt_ColdDrink.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Coffee \t\t\t\t\t\t" + txt_Coffee.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Crystal Water \t\t\t\t\t" + txt_Water.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("-----------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richtxt_Reciept.AppendText("Service Charges \t\t\t\t\t" + "Rs:" + txt_ServiceCharges.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Sub Total \t\t\t\t\t" + "Rs:" + txt_SubTotal.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("-----------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richtxt_Reciept.AppendText("Tax \t\t\t\t\t\t" + "Rs:" + txt_Tax.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("Total \t\t\t\t\t\t" + "Rs:" + txt_Total.Text + Environment.NewLine);
            richtxt_Reciept.AppendText("-----------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richtxt_Reciept.AppendText(label_Date.Text + "\t\t\t" + label_Time.Text + Environment.NewLine);
            richtxt_Reciept.AppendText(Environment.NewLine);
            richtxt_Reciept.AppendText(Environment.NewLine);
            richtxt_Reciept.AppendText(Environment.NewLine);
            richtxt_Reciept.AppendText("-----------------------------THANK YOU FOR BUYING----------------------------" + Environment.NewLine);



        }
        #region TextBox_OnlyDigits


        private void test_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MnC_Fries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_GnSpicy_Fries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CustomFries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Zinger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Rice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_IcedTea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_GreenTea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ColdDrink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Coffee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Water_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void button_Total_Click(object sender, EventArgs e)
        {
            double MnC_Fries, GnS_Fries, Cus_Fries, Zinger, Rice, Ice_Tea, Green_Tea, Coffee, Water, ColdDrink,tax,cost_of_Food,cost_of_Drinks,serviceCharge;

            

            //Price of Products Here
            MnC_Fries = 50;
            GnS_Fries = 50;
            Cus_Fries = 70;
            Zinger = 150;
            Rice = 150;
            Ice_Tea = 30;
            Green_Tea = 30;
            Coffee = 30;
            Water = 20;
            ColdDrink = 50;

            tax = 5.50; // tax assigned here

            // Converting the input string(value) to double(local variable) 
            double MacNFries = Convert.ToDouble(txt_MnC_Fries.Text);
            double GarlFries = Convert.ToDouble(txt_GnSpicy_Fries.Text);
            double CustmFries = Convert.ToDouble(txt_CustomFries.Text);
            double zinger = Convert.ToDouble(txt_Zinger.Text);
            double rice = Convert.ToDouble(txt_Rice.Text);
            double iTea = Convert.ToDouble(txt_IcedTea.Text);
            double gTea = Convert.ToDouble(txt_GreenTea.Text);
            double coffe = Convert.ToDouble(txt_Coffee.Text);
            double water = Convert.ToDouble(txt_Water.Text);
            double drink = Convert.ToDouble(txt_ColdDrink.Text);

            serviceCharge = Convert.ToDouble(txt_ServiceCharges.Text); // equating double(service charge) with string (textbox of service charge)

            // making class object and giving parameters of converted input strings from above
            Foods_Drinks obj = new Foods_Drinks(MacNFries, GarlFries, CustmFries, zinger, rice, iTea, gTea, coffe, water, drink);
          

            // cost of dinks = input value * price 
            cost_of_Drinks = (iTea * Ice_Tea) + (gTea * Green_Tea) + (coffe * Coffee) + (water * Water) + (drink * ColdDrink);
            txt_CostOfDrinks.Text = Convert.ToString(cost_of_Drinks); // textbox of costOFDrinks is now equal to the cost of drink calculated above

            // cost of foods = input value * price 
            cost_of_Food = (MacNFries * MnC_Fries) + (GarlFries * GnS_Fries) + (CustmFries * Cus_Fries) + (zinger * Zinger) + (rice * Rice);
            txt_CostOfFood.Text = Convert.ToString(cost_of_Food); // textbox of costOfFoods is now equal to the cost of food calculated above



            txt_SubTotal.Text = Convert.ToString(cost_of_Food + cost_of_Drinks + serviceCharge);
            txt_Tax.Text = Convert.ToString((cost_of_Food + cost_of_Drinks + serviceCharge) * tax / 100);

            double calculatedTax = Convert.ToDouble(txt_Tax.Text); // converting the above calculated tax so to multiply it below 

            txt_Total.Text = Convert.ToString(cost_of_Drinks + cost_of_Food + serviceCharge  + calculatedTax); // total is equal to the drinks`food cost + service charge + calculated tax(above)

            

        }
    }
}
