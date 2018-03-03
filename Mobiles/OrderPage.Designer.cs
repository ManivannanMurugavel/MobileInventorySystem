namespace Mobiles
{
	partial class OrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cusimage = new System.Windows.Forms.PictureBox();
            this.pincode = new System.Windows.Forms.TextBox();
            this.mobnum = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.village = new System.Windows.Forms.TextBox();
            this.lsname = new System.Windows.Forms.TextBox();
            this.frname = new System.Windows.Forms.TextBox();
            this.cusId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.prdimage = new System.Windows.Forms.PictureBox();
            this.ttlprice = new System.Windows.Forms.TextBox();
            this.eachprice = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mdlName = new System.Windows.Forms.TextBox();
            this.brndName = new System.Windows.Forms.TextBox();
            this.prdType = new System.Windows.Forms.TextBox();
            this.prdId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PrintOrder = new System.Windows.Forms.Button();
            this.orderslist = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.prdSearchBtn = new Mobiles.CircleButton();
            this.cusSearchBtn = new Mobiles.CircleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusimage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderslist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(554, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Detail";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 62);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 42);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cusimage);
            this.panel3.Controls.Add(this.pincode);
            this.panel3.Controls.Add(this.mobnum);
            this.panel3.Controls.Add(this.area);
            this.panel3.Controls.Add(this.village);
            this.panel3.Controls.Add(this.lsname);
            this.panel3.Controls.Add(this.frname);
            this.panel3.Controls.Add(this.cusId);
            this.panel3.Controls.Add(this.cusSearchBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 668);
            this.panel3.TabIndex = 3;
            // 
            // cusimage
            // 
            this.cusimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusimage.Location = new System.Drawing.Point(72, 550);
            this.cusimage.Name = "cusimage";
            this.cusimage.Size = new System.Drawing.Size(100, 100);
            this.cusimage.TabIndex = 12;
            this.cusimage.TabStop = false;
            // 
            // pincode
            // 
            this.pincode.Enabled = false;
            this.pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincode.Location = new System.Drawing.Point(37, 504);
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(180, 26);
            this.pincode.TabIndex = 11;
            // 
            // mobnum
            // 
            this.mobnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobnum.Location = new System.Drawing.Point(37, 438);
            this.mobnum.Name = "mobnum";
            this.mobnum.Size = new System.Drawing.Size(180, 26);
            this.mobnum.TabIndex = 10;
            this.mobnum.Enter += new System.EventHandler(this.mobnum_Enter);
            this.mobnum.Leave += new System.EventHandler(this.mobnum_Leave);
            // 
            // area
            // 
            this.area.Enabled = false;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(37, 375);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(180, 26);
            this.area.TabIndex = 9;
            // 
            // village
            // 
            this.village.Enabled = false;
            this.village.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.village.Location = new System.Drawing.Point(37, 310);
            this.village.Name = "village";
            this.village.Size = new System.Drawing.Size(180, 26);
            this.village.TabIndex = 8;
            // 
            // lsname
            // 
            this.lsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsname.Location = new System.Drawing.Point(37, 248);
            this.lsname.Name = "lsname";
            this.lsname.Size = new System.Drawing.Size(180, 26);
            this.lsname.TabIndex = 7;
            this.lsname.Enter += new System.EventHandler(this.lsname_Enter);
            this.lsname.Leave += new System.EventHandler(this.lsname_Leave);
            // 
            // frname
            // 
            this.frname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frname.Location = new System.Drawing.Point(37, 189);
            this.frname.Name = "frname";
            this.frname.Size = new System.Drawing.Size(180, 26);
            this.frname.TabIndex = 6;
            this.frname.Enter += new System.EventHandler(this.frname_Enter);
            this.frname.Leave += new System.EventHandler(this.frname_Leave);
            // 
            // cusId
            // 
            this.cusId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusId.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusId.Location = new System.Drawing.Point(49, 65);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(157, 31);
            this.cusId.TabIndex = 2;
            this.cusId.Enter += new System.EventHandler(this.cusId_Enter);
            this.cusId.Leave += new System.EventHandler(this.cusId_Leave);
            this.cusId.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.cusId.MouseLeave += new System.EventHandler(this.cusId_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.prdimage);
            this.panel4.Controls.Add(this.ttlprice);
            this.panel4.Controls.Add(this.eachprice);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.mdlName);
            this.panel4.Controls.Add(this.brndName);
            this.panel4.Controls.Add(this.prdType);
            this.panel4.Controls.Add(this.prdId);
            this.panel4.Controls.Add(this.prdSearchBtn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1067, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 668);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(78, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prdimage
            // 
            this.prdimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdimage.Location = new System.Drawing.Point(91, 550);
            this.prdimage.Name = "prdimage";
            this.prdimage.Size = new System.Drawing.Size(100, 100);
            this.prdimage.TabIndex = 11;
            this.prdimage.TabStop = false;
            // 
            // ttlprice
            // 
            this.ttlprice.Enabled = false;
            this.ttlprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlprice.Location = new System.Drawing.Point(54, 504);
            this.ttlprice.Name = "ttlprice";
            this.ttlprice.Size = new System.Drawing.Size(180, 26);
            this.ttlprice.TabIndex = 10;
            // 
            // eachprice
            // 
            this.eachprice.Enabled = false;
            this.eachprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eachprice.Location = new System.Drawing.Point(54, 455);
            this.eachprice.Name = "eachprice";
            this.eachprice.Size = new System.Drawing.Size(180, 26);
            this.eachprice.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(127, 401);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.QtyValChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_KeyPressed);
            // 
            // mdlName
            // 
            this.mdlName.Enabled = false;
            this.mdlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdlName.Location = new System.Drawing.Point(54, 342);
            this.mdlName.Name = "mdlName";
            this.mdlName.Size = new System.Drawing.Size(180, 26);
            this.mdlName.TabIndex = 7;
            // 
            // brndName
            // 
            this.brndName.Enabled = false;
            this.brndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brndName.Location = new System.Drawing.Point(54, 280);
            this.brndName.Name = "brndName";
            this.brndName.Size = new System.Drawing.Size(180, 26);
            this.brndName.TabIndex = 6;
            // 
            // prdType
            // 
            this.prdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdType.Location = new System.Drawing.Point(54, 224);
            this.prdType.Name = "prdType";
            this.prdType.Size = new System.Drawing.Size(180, 26);
            this.prdType.TabIndex = 5;
            this.prdType.MouseHover += new System.EventHandler(this.mouseHoverPrdType);
            // 
            // prdId
            // 
            this.prdId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdId.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdId.Location = new System.Drawing.Point(64, 65);
            this.prdId.Name = "prdId";
            this.prdId.Size = new System.Drawing.Size(157, 31);
            this.prdId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(78, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.PrintOrder);
            this.panel5.Controls.Add(this.orderslist);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(272, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(795, 668);
            this.panel5.TabIndex = 5;
            // 
            // PrintOrder
            // 
            this.PrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PrintOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintOrder.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintOrder.ForeColor = System.Drawing.Color.Maroon;
            this.PrintOrder.Location = new System.Drawing.Point(551, 550);
            this.PrintOrder.Name = "PrintOrder";
            this.PrintOrder.Size = new System.Drawing.Size(119, 44);
            this.PrintOrder.TabIndex = 2;
            this.PrintOrder.Text = "Print";
            this.PrintOrder.UseVisualStyleBackColor = false;
            this.PrintOrder.Click += new System.EventHandler(this.PrintOrder_Click);
            // 
            // orderslist
            // 
            this.orderslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderslist.Location = new System.Drawing.Point(72, 168);
            this.orderslist.Name = "orderslist";
            this.orderslist.Size = new System.Drawing.Size(660, 318);
            this.orderslist.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(301, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order Items";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_Document);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // prdSearchBtn
            // 
            this.prdSearchBtn.AutoEllipsis = true;
            this.prdSearchBtn.BackColor = System.Drawing.Color.HotPink;
            this.prdSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prdSearchBtn.FlatAppearance.BorderSize = 0;
            this.prdSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prdSearchBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdSearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdSearchBtn.Location = new System.Drawing.Point(87, 118);
            this.prdSearchBtn.Name = "prdSearchBtn";
            this.prdSearchBtn.Size = new System.Drawing.Size(114, 31);
            this.prdSearchBtn.TabIndex = 3;
            this.prdSearchBtn.Text = "Search";
            this.prdSearchBtn.UseVisualStyleBackColor = false;
            this.prdSearchBtn.Click += new System.EventHandler(this.prdSearchBtn_Click);
            // 
            // cusSearchBtn
            // 
            this.cusSearchBtn.AutoEllipsis = true;
            this.cusSearchBtn.BackColor = System.Drawing.Color.HotPink;
            this.cusSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusSearchBtn.FlatAppearance.BorderSize = 0;
            this.cusSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusSearchBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusSearchBtn.Location = new System.Drawing.Point(72, 118);
            this.cusSearchBtn.Name = "cusSearchBtn";
            this.cusSearchBtn.Size = new System.Drawing.Size(114, 31);
            this.cusSearchBtn.TabIndex = 1;
            this.cusSearchBtn.Text = "Search";
            this.cusSearchBtn.UseVisualStyleBackColor = false;
            this.cusSearchBtn.Click += new System.EventHandler(this.cusSearchBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(1233, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1350, 772);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PageMouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusimage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderslist)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private CircleButton cusSearchBtn;
		private System.Windows.Forms.TextBox cusId;
		private System.Windows.Forms.TextBox prdId;
		private CircleButton prdSearchBtn;
		private System.Windows.Forms.TextBox mdlName;
		private System.Windows.Forms.TextBox brndName;
		private System.Windows.Forms.TextBox prdType;
		private System.Windows.Forms.TextBox ttlprice;
		private System.Windows.Forms.TextBox eachprice;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.PictureBox prdimage;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox cusimage;
		private System.Windows.Forms.TextBox pincode;
		private System.Windows.Forms.TextBox mobnum;
		private System.Windows.Forms.TextBox area;
		private System.Windows.Forms.TextBox village;
		private System.Windows.Forms.TextBox lsname;
		private System.Windows.Forms.TextBox frname;
		private System.Windows.Forms.DataGridView orderslist;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button PrintOrder;
		private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button2;
    }
}