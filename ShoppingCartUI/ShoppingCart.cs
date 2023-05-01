using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartUI
{
	public class ShoppingCart
	{
		private List<ProductList> products;
		private static ShoppingCart _instance;
		

		public static ShoppingCart Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = ShoppingCart.Instance;
				}
				return _instance;
			}
		}

		public ShoppingCart()
		{
			products = new List<ProductList>();
		}
		public List<ProductList> GetProducts()
		{
			return products;
		}

		public void AddProduct(ProductList product, int quantity)
		{
			if (quantity <= 0)
			{
				throw new ArgumentException("商品數量不能為0。");
			}

			ProductList existingProduct = products.Find(p => p.ProductIndex == product.ProductIndex);

			if (existingProduct != null)
			{
				existingProduct.Quantity += quantity;
			}
			else
			{
				products.Add(new ProductList
				{
					ProductIndex = product.ProductIndex,
					ProductName = product.ProductName,
					Price = product.Price,
					Quantity = quantity
				});
			}
		}
		public decimal GetTotalPrice()
		{
			decimal totalPrice = 0;

			foreach (ProductList product in products)
			{
				if (!product.IsDeleted)
				{
					totalPrice += product.Price * product.Quantity;
				}
			}

			return totalPrice;
		}
		public void RemoveProduct(int productIndex)
		{
			ProductList existingProduct = products.Find(p => p.ProductIndex == productIndex);

			if (existingProduct != null)
			{
				existingProduct.IsDeleted = false;
			}
		}
		public void AddDeletedProduct(int productIndex, int quantity)
		{
			if (quantity <= 0)
			{
				throw new ArgumentException("商品數量不能為0。");
			}

			ProductList existingProduct = products.Find(p => p.ProductIndex == productIndex);

			if (existingProduct != null && existingProduct.IsDeleted)
			{
				existingProduct.Quantity = quantity;
				existingProduct.IsDeleted = false;
			}
			else
			{
				throw new ArgumentException("找不到指定的商品或該商品未被刪除。");
			}
		}
	}
}
