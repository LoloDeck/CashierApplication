namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblitem = new Label();
            lblDiscount = new Label();
            itemTxtbox = new TextBox();
            discountTxtbox = new TextBox();
            lblPrice = new Label();
            priceTxtbox = new TextBox();
            lblQuantity = new Label();
            QuantityTxtbox = new TextBox();
            ComputeBtn = new Button();
            lblTotalAmount = new Label();
            totalAmountTxtbox = new TextBox();
            lblPayment = new Label();
            paymentTxtbox = new TextBox();
            submitBtn = new Button();
            lblChange = new Label();
            changeTxtbox = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblitem
            // 
            lblitem.AutoSize = true;
            lblitem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblitem.Location = new Point(37, 60);
            lblitem.Name = "lblitem";
            lblitem.Size = new Size(56, 25);
            lblitem.TabIndex = 0;
            lblitem.Text = "Item:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(299, 60);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(122, 25);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount(%):";
            // 
            // itemTxtbox
            // 
            itemTxtbox.Font = new Font("Segoe UI", 11F);
            itemTxtbox.Location = new Point(37, 88);
            itemTxtbox.Name = "itemTxtbox";
            itemTxtbox.Size = new Size(235, 32);
            itemTxtbox.TabIndex = 2;
            // 
            // discountTxtbox
            // 
            discountTxtbox.Font = new Font("Segoe UI", 11F);
            discountTxtbox.Location = new Point(300, 88);
            discountTxtbox.Name = "discountTxtbox";
            discountTxtbox.Size = new Size(156, 32);
            discountTxtbox.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(37, 135);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price: ";
            // 
            // priceTxtbox
            // 
            priceTxtbox.Font = new Font("Segoe UI", 11F);
            priceTxtbox.Location = new Point(93, 131);
            priceTxtbox.Name = "priceTxtbox";
            priceTxtbox.Size = new Size(179, 32);
            priceTxtbox.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(300, 135);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(92, 25);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            // 
            // QuantityTxtbox
            // 
            QuantityTxtbox.Font = new Font("Segoe UI", 11F);
            QuantityTxtbox.Location = new Point(401, 132);
            QuantityTxtbox.Name = "QuantityTxtbox";
            QuantityTxtbox.Size = new Size(55, 32);
            QuantityTxtbox.TabIndex = 7;
            // 
            // ComputeBtn
            // 
            ComputeBtn.BackColor = Color.Crimson;
            ComputeBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComputeBtn.Location = new Point(37, 185);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(147, 45);
            ComputeBtn.TabIndex = 8;
            ComputeBtn.Text = "Compute";
            ComputeBtn.UseVisualStyleBackColor = false;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(190, 195);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(138, 25);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.Text = "Total Amount: ";
            // 
            // totalAmountTxtbox
            // 
            totalAmountTxtbox.BorderStyle = BorderStyle.None;
            totalAmountTxtbox.Font = new Font("Segoe UI", 11F);
            totalAmountTxtbox.Location = new Point(323, 192);
            totalAmountTxtbox.Name = "totalAmountTxtbox";
            totalAmountTxtbox.Size = new Size(133, 25);
            totalAmountTxtbox.TabIndex = 10;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.Location = new Point(37, 263);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(174, 25);
            lblPayment.TabIndex = 11;
            lblPayment.Text = "Payment Received:";
            // 
            // paymentTxtbox
            // 
            paymentTxtbox.Font = new Font("Segoe UI", 11F);
            paymentTxtbox.Location = new Point(213, 260);
            paymentTxtbox.Name = "paymentTxtbox";
            paymentTxtbox.Size = new Size(130, 32);
            paymentTxtbox.TabIndex = 12;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Crimson;
            submitBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(349, 256);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(107, 38);
            submitBtn.TabIndex = 13;
            submitBtn.Text = "Sumbit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(126, 317);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(81, 25);
            lblChange.TabIndex = 14;
            lblChange.Text = "Change:";
            // 
            // changeTxtbox
            // 
            changeTxtbox.BorderStyle = BorderStyle.None;
            changeTxtbox.Font = new Font("Segoe UI", 11F);
            changeTxtbox.Location = new Point(213, 317);
            changeTxtbox.Name = "changeTxtbox";
            changeTxtbox.Size = new Size(133, 25);
            changeTxtbox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(494, 33);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(229, 30);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(229, 30);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(494, 388);
            Controls.Add(changeTxtbox);
            Controls.Add(lblChange);
            Controls.Add(submitBtn);
            Controls.Add(paymentTxtbox);
            Controls.Add(lblPayment);
            Controls.Add(totalAmountTxtbox);
            Controls.Add(lblTotalAmount);
            Controls.Add(ComputeBtn);
            Controls.Add(QuantityTxtbox);
            Controls.Add(lblQuantity);
            Controls.Add(priceTxtbox);
            Controls.Add(lblPrice);
            Controls.Add(discountTxtbox);
            Controls.Add(itemTxtbox);
            Controls.Add(lblDiscount);
            Controls.Add(lblitem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblitem;
        private Label lblDiscount;
        private TextBox itemTxtbox;
        private TextBox discountTxtbox;
        private Label lblPrice;
        private TextBox priceTxtbox;
        private Label lblQuantity;
        private TextBox QuantityTxtbox;
        private Button ComputeBtn;
        private Label lblTotalAmount;
        private TextBox totalAmountTxtbox;
        private Label lblPayment;
        private TextBox paymentTxtbox;
        private Button submitBtn;
        private Label lblChange;
        private TextBox changeTxtbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}
