using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShoppingCartUI
{
	public partial class GoodsStore : Form
	{
		private List<ProductList> productList;
		private ShoppingCart shoppingCart;
		private ShoppingCart cart = new ShoppingCart();

		public GoodsStore()
		{
			InitializeComponent();
		}

		private void priceCalc_Click(object sender, EventArgs e)
		{
			// 取得購物車所有商品的總價
			decimal totalPrice = shoppingCart.GetTotalPrice();

			// 顯示總價
			totalPrice_textBox.Text = totalPrice.ToString("C0");
		}

		private void Add_button1_Click(object sender, EventArgs e)
		{
			ProductList selectedProduct = (ProductList)product_comboBox1.SelectedItem;
			int quantity = (int)numericUpDown1.Value;

			// 加入商品到購物車
			if (quantity <= 0)
			{
				MessageBox.Show("商品數量不能為 0。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				shoppingCart.AddProduct(selectedProduct, quantity);
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			UpdateShoppingCart(shoppingCart);

		}

		private void product_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProductList selectedProduct = (ProductList)product_comboBox1.SelectedItem;

			// 顯示商品單價
			Price_textBox1.Text = selectedProduct.Price.ToString("C0");
		}

		private void UpdateShoppingCart(ShoppingCart shoppingCart)
		{
			// 先清除所有舊的資料
			dataGridView1.Rows.Clear();

			// 依序新增每一個商品到 DataGridView
			int allPrice = 0;
			foreach (ProductList product in shoppingCart.GetProducts())
			{
				int quantity = product.Quantity;
				int totalPrice = (int)product.Quantity * (int)product.Price;

				// 將商品名稱、數量、單價、總價新增到 DataGridView
				dataGridView1.Rows.Add(product.ProductName, quantity, totalPrice);

				allPrice += totalPrice;
			}
		}
		//private void Delete_click(object sender, EventArgs e)
		//{

		//	int productIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductIndex"].Value);

		//	List<ProductList> products = cart.GetProducts();

		//	ProductList product = products.Find(p => p.ProductIndex == productIndex);
		//	if (product != null)
		//	{
		//		cart.RemoveProduct(productIndex);
		//	}
		//}

		private void GoodsStore_Load(object sender, EventArgs e)
		{
			productList = new List<ProductList>();
			productList.Add(new ProductList { ProductIndex = 0, ProductName = "請選擇欲購買的商品", Price = 0, Quantity = 0 });
			productList.Add(new ProductList { ProductIndex = 1, ProductName = "大站娃", Price = 1190, Quantity = 0 });
			productList.Add(new ProductList { ProductIndex = 2, ProductName = "小站娃", Price = 480, Quantity = 0 });
			productList.Add(new ProductList { ProductIndex = 3, ProductName = "手機殼", Price = 735, Quantity = 0 });
			productList.Add(new ProductList { ProductIndex = 4, ProductName = "拖鞋", Price = 680, Quantity = 0 });
			productList.Add(new ProductList { ProductIndex = 5, ProductName = "洗臉髮帶", Price = 410, Quantity = 0 });

			// 設定商品列表ComboBox
			product_comboBox1.DataSource = productList;
			product_comboBox1.DisplayMember = "ProductName";
			product_comboBox1.ValueMember = "ProductIndex";

			shoppingCart = new ShoppingCart();
		}
	}
}
