namespace Chapter_2._2_Store_Cash_Register_Using_Simple_Factory
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_Count = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_TotalPrice = new System.Windows.Forms.Label();
            this.comB_Discount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_shoppingList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price :";
            // 
            // txtB_Price
            // 
            this.txtB_Price.Location = new System.Drawing.Point(93, 46);
            this.txtB_Price.Name = "txtB_Price";
            this.txtB_Price.Size = new System.Drawing.Size(100, 22);
            this.txtB_Price.TabIndex = 1;
            this.txtB_Price.Text = "0.0";
            this.txtB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count :";
            // 
            // txtB_Count
            // 
            this.txtB_Count.Location = new System.Drawing.Point(93, 83);
            this.txtB_Count.Name = "txtB_Count";
            this.txtB_Count.Size = new System.Drawing.Size(100, 22);
            this.txtB_Count.TabIndex = 3;
            this.txtB_Count.Text = "0";
            this.txtB_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(225, 44);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(225, 86);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Price :";
            // 
            // lab_TotalPrice
            // 
            this.lab_TotalPrice.AutoSize = true;
            this.lab_TotalPrice.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_TotalPrice.Location = new System.Drawing.Point(245, 341);
            this.lab_TotalPrice.Name = "lab_TotalPrice";
            this.lab_TotalPrice.Size = new System.Drawing.Size(60, 37);
            this.lab_TotalPrice.TabIndex = 8;
            this.lab_TotalPrice.Text = "0.0";
            // 
            // comB_Discount
            // 
            this.comB_Discount.FormattingEnabled = true;
            this.comB_Discount.Location = new System.Drawing.Point(93, 127);
            this.comB_Discount.Name = "comB_Discount";
            this.comB_Discount.Size = new System.Drawing.Size(121, 20);
            this.comB_Discount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Discount :";
            // 
            // lbx_shoppingList
            // 
            this.lbx_shoppingList.FormattingEnabled = true;
            this.lbx_shoppingList.ItemHeight = 12;
            this.lbx_shoppingList.Location = new System.Drawing.Point(37, 169);
            this.lbx_shoppingList.Name = "lbx_shoppingList";
            this.lbx_shoppingList.Size = new System.Drawing.Size(268, 124);
            this.lbx_shoppingList.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 391);
            this.Controls.Add(this.lbx_shoppingList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comB_Discount);
            this.Controls.Add(this.lab_TotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtB_Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_Price);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Store Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_Count;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_TotalPrice;
        private System.Windows.Forms.ComboBox comB_Discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_shoppingList;
    }
}

