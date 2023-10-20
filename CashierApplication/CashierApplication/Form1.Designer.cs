namespace CashierApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.bttn_calculate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_changefinal = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.bttn_compute = new System.Windows.Forms.Button();
            this.item_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item.Location = new System.Drawing.Point(114, 9);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(55, 24);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "ITEM";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_price.Location = new System.Drawing.Point(387, 9);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(65, 24);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "PRICE";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(355, 36);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(130, 24);
            this.txt_price.TabIndex = 3;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_quantity.Location = new System.Drawing.Point(22, 72);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(105, 24);
            this.lbl_quantity.TabIndex = 4;
            this.lbl_quantity.Text = "QUANTITY";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(16, 99);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(116, 24);
            this.txt_quantity.TabIndex = 5;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_discount.Location = new System.Drawing.Point(361, 72);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(106, 24);
            this.lbl_discount.TabIndex = 6;
            this.lbl_discount.Text = "DISCOUNT";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(355, 99);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(130, 24);
            this.txt_discount.TabIndex = 7;
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_payment.Location = new System.Drawing.Point(67, 264);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(107, 24);
            this.lbl_payment.TabIndex = 8;
            this.lbl_payment.Text = "PAYMENT:";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(179, 264);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(149, 24);
            this.txt_payment.TabIndex = 9;
            // 
            // bttn_calculate
            // 
            this.bttn_calculate.Location = new System.Drawing.Point(355, 264);
            this.bttn_calculate.Name = "bttn_calculate";
            this.bttn_calculate.Size = new System.Drawing.Size(101, 24);
            this.bttn_calculate.TabIndex = 10;
            this.bttn_calculate.Text = "CALCULATE";
            this.bttn_calculate.UseVisualStyleBackColor = true;
            this.bttn_calculate.Click += new System.EventHandler(this.Bttn_calculate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_change.Location = new System.Drawing.Point(78, 297);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(96, 24);
            this.lbl_change.TabIndex = 11;
            this.lbl_change.Text = "CHANGE:";
            // 
            // lbl_changefinal
            // 
            this.lbl_changefinal.AutoSize = true;
            this.lbl_changefinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_changefinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changefinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_changefinal.Location = new System.Drawing.Point(176, 297);
            this.lbl_changefinal.Name = "lbl_changefinal";
            this.lbl_changefinal.Size = new System.Drawing.Size(70, 24);
            this.lbl_changefinal.TabIndex = 12;
            this.lbl_changefinal.Text = "%%%%";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_total.Location = new System.Drawing.Point(223, 200);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(72, 24);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "TOTAL";
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_totalprice.Location = new System.Drawing.Point(203, 224);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_totalprice.Size = new System.Drawing.Size(115, 24);
            this.lbl_totalprice.TabIndex = 14;
            this.lbl_totalprice.Text = "%%%%%%%";
            this.lbl_totalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_compute
            // 
            this.bttn_compute.Location = new System.Drawing.Point(184, 147);
            this.bttn_compute.Name = "bttn_compute";
            this.bttn_compute.Size = new System.Drawing.Size(145, 33);
            this.bttn_compute.TabIndex = 15;
            this.bttn_compute.Text = "COMPUTE";
            this.bttn_compute.UseVisualStyleBackColor = true;
            this.bttn_compute.Click += new System.EventHandler(this.Bttn_compute_Click);
            // 
            // item_combobox
            // 
            this.item_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_combobox.FormattingEnabled = true;
            this.item_combobox.Location = new System.Drawing.Point(16, 36);
            this.item_combobox.Name = "item_combobox";
            this.item_combobox.Size = new System.Drawing.Size(246, 24);
            this.item_combobox.TabIndex = 16;
            this.item_combobox.SelectedIndexChanged += new System.EventHandler(this.item_combobox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 358);
            this.Controls.Add(this.item_combobox);
            this.Controls.Add(this.bttn_compute);
            this.Controls.Add(this.lbl_totalprice);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_changefinal);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.bttn_calculate);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_item);
            this.Name = "Form1";
            this.Text = "Cashier Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Button bttn_calculate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label lbl_changefinal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.Button bttn_compute;
        private System.Windows.Forms.ComboBox item_combobox;
    }
}

