using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2._1_Store_Cash_Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] discountItems = { "八折" , "七折" , "五折" , "三折" };
            comB_Discount.Items.AddRange(discountItems);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtB_Price.Text);
            int count = Convert.ToInt32(txtB_Count.Text);
            double discount = 0;            
            switch(comB_Discount.SelectedIndex)
            {
                case 0:
                    discount = 0.8;
                    break;
                case 1:
                    discount = 0.7;
                    break;
                case 2:
                    discount = 0.5;
                    break;
                case 3:
                    discount = 0.3;
                    break;
                default:
                    discount = 1;
                    break;
            }
            price = price * discount;
            int totalProce = (int)price * count;
            lab_TotalPrice.Text = totalProce.ToString();
            lbx_shoppingList.Items.Add("單價:" + price.ToString() + " 數量:"+ count.ToString() + " " + comB_Discount.SelectedItem + "合計:" + totalProce.ToString());
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtB_Count.Text = "0";
            txtB_Price.Text = "0.0";
            lab_TotalPrice.Text = "0.0";
        }
    }
}
