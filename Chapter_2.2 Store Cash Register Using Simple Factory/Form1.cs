using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2._2_Store_Cash_Register_Using_Simple_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] discountItems = { "無折扣" , "打七折" , "滿五百折一百" , "滿五百折兩百"};
            comB_Discount.Items.AddRange(discountItems);
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtB_Price.Text);
            int count = Convert.ToInt32(txtB_Count.Text);
            /* 
             * 簡單工廠的實現，但沒有辦法個別設定工廠的參數，都是依照寫死的情況下去調整的，
             * 但其實在下拉選單中增加選項，例如滿五百折一百和滿五百折兩百，這樣工廠內就可以把參數設死了，
             * 好處是使用者不需要去new物件。
             * 
            */
            CashSuper cs = CashFactory.createCashAcept(comB_Discount.SelectedItem.ToString());   
            double totalProce = price * count;
            double finalProce = cs.acceptCash(totalProce);
            lab_TotalPrice.Text = finalProce.ToString();
            lbx_shoppingList.Items.Add("單價:" + price.ToString() + " 數量:"+ count.ToString() + " " + comB_Discount.SelectedItem + " 合計:" + finalProce.ToString());
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtB_Count.Text = "0";
            txtB_Price.Text = "0.0";
            lab_TotalPrice.Text = "0.0";
        }

    }
}
