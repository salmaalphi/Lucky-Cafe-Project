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


namespace Lucky_Cafe_Order_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            string customerName = MacamilkaMgc.Text;

            if (customerName == "" || !System.Text.RegularExpressions.Regex.IsMatch(customerName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please enter a valid Customer Name");
                return;
            }


            int quantity;

            if (!int.TryParse(txtMeqa.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid Quantity");
                return;
            }

            
            string drinkName = "";
            double drinkPrice = 0;

            if (shaax.Checked)
            {
                drinkName = "Tea";
                drinkPrice = 1;
            }
            else if (BtnCoffee.Checked)
            {
                drinkName = "Coffee";
                drinkPrice = 2;
            }
            else if (btnJuice.Checked)
            {
                drinkName = "Juice";
                drinkPrice = 3;
            }
            else
            {
                MessageBox.Show("Please select a Drink");
                return;
            }

            
            DabacadaOrder.Items.Clear();

            Random x = new Random();
            bool lucky = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckyMessage = x.Next(1, 51);

                if (luckyMessage == 7 || luckyMessage == 17)
                {
                    lucky = true;
                }

                DabacadaOrder.Items.Add(
                    i + ") " + customerName + " - " +
                    drinkName + " - Lucky: " + luckyMessage +
                    " - $" + drinkPrice.ToString("N2")
                );
            }

            DabacadaOrder.TopIndex = 0;

            
            double totalPrice = drinkPrice * quantity;

            
            if (Ardeyda.Checked)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }

            
            Totalka.Text = "Total Price: $" + totalPrice.ToString("N2");
            
            if (lucky)
            {
                farintaNasibka.Text = "You got a Free Cookie!";
            }
            else
            {
                farintaNasibka.Text = "No prize this time.";
            }
        }



        private void lstOrder_TextChanged(object sender, EventArgs e){}


        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (DabacadaOrder.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter writer = File.AppendText("orders.txt");

            for (int i = 0; i < DabacadaOrder.Items.Count; i++)
            {
                writer.WriteLine(DabacadaOrder.Items[i].ToString());
            }

            writer.WriteLine(Totalka.Text);
            writer.WriteLine(farintaNasibka.Text);
            writer.WriteLine("----------------------");

            writer.Close();

            MessageBox.Show("Order saved.");
        }



        private void btnsaveLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            DabacadaOrder.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                DabacadaOrder.Items.Add(line);
            }

            reader.Close();
        }



        private void btnclear_Click(object sender, EventArgs e)
        {
            MacamilkaMgc.Clear();
            txtMeqa.Clear();

            DabacadaOrder.Items.Clear();

            Totalka.Text = "Total Price:";
            farintaNasibka.Text = "Lucky Message:";

            Ardeyda.Checked = false;
            shaax.Checked = false;
            BtnCoffee.Checked = false;
            btnJuice.Checked = false;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
