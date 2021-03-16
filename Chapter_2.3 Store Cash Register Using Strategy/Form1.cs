using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2._3_Store_Cash_Register_Using_Strategy
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
            CashSuper cs = null;
            switch (strategy)
            {
                case "無折扣":
                    cs = new CashNormal();
                    break;
                case "打七折":
                    cs = new CashRebate("0.7");
                    break;
                case "滿五百折一百":
                    cs = new CashReturn("500","100");
                    break;
                case "滿五百折兩百":
                    cs = new CashReturn("500", "200");
                    break;
                default:
                    cs = new CashNormal();
                    break;
            }

            /*              
             * 工廠模式最大的好處就是使用者"不需要判斷"要new哪一個底層類別
             * 工廠模式只需要知道 CashSuper 與 CashFactory 類別
             * 策略模式最大的不同就是使用者在這邊的宣告與 new 的建立都是使用同一個類別 CashContext
             * 策略模式需要知道 Context 和 底層的類別們，且"需要判斷"要用哪一個底層類別去new
             * 
             * 全部的類別有                 CashSuper CashNormal CashRebate CashReturn CashFactory CashContext
             * 工廠模式使用者須知道的類別       ○                                          ○
             * 策略模式使用者需知道的類別                 ○         ○         ○                      ○
             */
            CashContext cc = new CashContext(cs);

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
