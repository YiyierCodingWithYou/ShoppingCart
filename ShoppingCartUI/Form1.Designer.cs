namespace ShoppingCartUI
{
	partial class GoodsStore
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.GetTotalPrice = new System.Windows.Forms.Button();
			this.totalPrice_textBox = new System.Windows.Forms.TextBox();
			this.totalPrice_label = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Add_button1 = new System.Windows.Forms.Button();
			this.shoppingCart_label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.product_comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Price_textBox1 = new System.Windows.Forms.TextBox();
			this.delete_button1 = new System.Windows.Forms.Button();
			this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productQuantity,
            this.totalPrice,
            this.ProductIndex});
			this.dataGridView1.Location = new System.Drawing.Point(585, 147);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(448, 193);
			this.dataGridView1.TabIndex = 0;
			// 
			// GetTotalPrice
			// 
			this.GetTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.GetTotalPrice.Location = new System.Drawing.Point(666, 354);
			this.GetTotalPrice.Name = "GetTotalPrice";
			this.GetTotalPrice.Size = new System.Drawing.Size(75, 27);
			this.GetTotalPrice.TabIndex = 1;
			this.GetTotalPrice.Text = "結帳";
			this.GetTotalPrice.UseVisualStyleBackColor = true;
			this.GetTotalPrice.Click += new System.EventHandler(this.priceCalc_Click);
			// 
			// totalPrice_textBox
			// 
			this.totalPrice_textBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.totalPrice_textBox.Location = new System.Drawing.Point(933, 352);
			this.totalPrice_textBox.Name = "totalPrice_textBox";
			this.totalPrice_textBox.Size = new System.Drawing.Size(100, 27);
			this.totalPrice_textBox.TabIndex = 2;
			// 
			// totalPrice_label
			// 
			this.totalPrice_label.AutoSize = true;
			this.totalPrice_label.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.totalPrice_label.Location = new System.Drawing.Point(875, 356);
			this.totalPrice_label.Name = "totalPrice_label";
			this.totalPrice_label.Size = new System.Drawing.Size(54, 19);
			this.totalPrice_label.TabIndex = 3;
			this.totalPrice_label.Text = "總金額";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown1.Location = new System.Drawing.Point(876, 33);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(110, 27);
			this.numericUpDown1.TabIndex = 5;
			// 
			// Add_button1
			// 
			this.Add_button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Add_button1.Location = new System.Drawing.Point(876, 68);
			this.Add_button1.Name = "Add_button1";
			this.Add_button1.Size = new System.Drawing.Size(110, 29);
			this.Add_button1.TabIndex = 7;
			this.Add_button1.Text = "加入購物車";
			this.Add_button1.UseVisualStyleBackColor = true;
			this.Add_button1.Click += new System.EventHandler(this.Add_button1_Click);
			// 
			// shoppingCart_label1
			// 
			this.shoppingCart_label1.AutoSize = true;
			this.shoppingCart_label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.shoppingCart_label1.Location = new System.Drawing.Point(585, 125);
			this.shoppingCart_label1.Name = "shoppingCart_label1";
			this.shoppingCart_label1.Size = new System.Drawing.Size(54, 19);
			this.shoppingCart_label1.TabIndex = 7;
			this.shoppingCart_label1.Text = "購物車";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ShoppingCartUI.Properties.Resources.Mang;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(24, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(555, 348);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// product_comboBox1
			// 
			this.product_comboBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.product_comboBox1.FormattingEnabled = true;
			this.product_comboBox1.Items.AddRange(new object[] {
            "大站娃",
            "小站娃",
            "手機殼",
            "拖鞋",
            "洗臉髮帶"});
			this.product_comboBox1.Location = new System.Drawing.Point(631, 33);
			this.product_comboBox1.Name = "product_comboBox1";
			this.product_comboBox1.Size = new System.Drawing.Size(180, 27);
			this.product_comboBox1.TabIndex = 8;
			this.product_comboBox1.SelectedIndexChanged += new System.EventHandler(this.product_comboBox1_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(588, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 19);
			this.label6.TabIndex = 9;
			this.label6.Text = "商品";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(831, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 19);
			this.label7.TabIndex = 10;
			this.label7.Text = "數量";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(588, 78);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 19);
			this.label8.TabIndex = 11;
			this.label8.Text = "單價";
			// 
			// Price_textBox1
			// 
			this.Price_textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.Price_textBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Price_textBox1.Location = new System.Drawing.Point(632, 71);
			this.Price_textBox1.Name = "Price_textBox1";
			this.Price_textBox1.ReadOnly = true;
			this.Price_textBox1.Size = new System.Drawing.Size(179, 27);
			this.Price_textBox1.TabIndex = 12;
			// 
			// delete_button1
			// 
			this.delete_button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.delete_button1.Location = new System.Drawing.Point(585, 354);
			this.delete_button1.Name = "delete_button1";
			this.delete_button1.Size = new System.Drawing.Size(75, 27);
			this.delete_button1.TabIndex = 13;
			this.delete_button1.Text = "刪除";
			this.delete_button1.UseVisualStyleBackColor = true;
			//this.delete_button1.Click += new System.EventHandler(this.Delete_click);
			// 
			// productName
			// 
			this.productName.HeaderText = "商品名稱";
			this.productName.MinimumWidth = 6;
			this.productName.Name = "productName";
			this.productName.Width = 125;
			// 
			// productQuantity
			// 
			this.productQuantity.HeaderText = "數量";
			this.productQuantity.MinimumWidth = 6;
			this.productQuantity.Name = "productQuantity";
			this.productQuantity.Width = 85;
			// 
			// totalPrice
			// 
			this.totalPrice.HeaderText = "總價";
			this.totalPrice.MinimumWidth = 6;
			this.totalPrice.Name = "totalPrice";
			this.totalPrice.Width = 125;
			// 
			// ProductIndex
			// 
			this.ProductIndex.DataPropertyName = "ProductIndex";
			this.ProductIndex.HeaderText = "索引值";
			this.ProductIndex.MinimumWidth = 6;
			this.ProductIndex.Name = "ProductIndex";
			this.ProductIndex.Width = 125;
			// 
			// GoodsStore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 404);
			this.Controls.Add(this.delete_button1);
			this.Controls.Add(this.totalPrice_textBox);
			this.Controls.Add(this.Price_textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.product_comboBox1);
			this.Controls.Add(this.shoppingCart_label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.GetTotalPrice);
			this.Controls.Add(this.totalPrice_label);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.Add_button1);
			this.Name = "GoodsStore";
			this.Text = "松鼠專賣店";
			this.Load += new System.EventHandler(this.GoodsStore_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button GetTotalPrice;
		private System.Windows.Forms.TextBox totalPrice_textBox;
		private System.Windows.Forms.Label totalPrice_label;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button Add_button1;
		private System.Windows.Forms.Label shoppingCart_label1;
		private System.Windows.Forms.ComboBox product_comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Price_textBox1;
		private System.Windows.Forms.Button delete_button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productName;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductIndex;
	}
}

