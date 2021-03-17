using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2._4_Store_Cash_Register_Using_Strategy_and_Simple_Factory
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

            string strategy = comB_Discount.SelectedItem.ToString();


            /*              
             * 全部的類別有                 CashSuper CashNormal CashRebate CashReturn CashFactory CashContext
             * 工廠模式使用者需知道的類別       ○                                          ○
             * 策略模式使用者需知道的類別                 ○         ○         ○                      ○
             * 策略模式結合工廠模式的情況                                                               ○              
             * 很明顯的策略模式結合工廠模式之後，使用者不需要知道最底層的類別有什麼，
             * 也不需要在客戶端進行底層類別物件的建立，
             * 甚至不需要知道這些底層類別的抽象類別是什麼，
             * 只需要知道 Context 即可。
             */
            CashContext cc = new CashContext(strategy);

            double totalProce = price * count;
            double finalProce = cc.getResult(totalProce);
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
