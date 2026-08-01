using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        // Private member variables
        private List<Product> _products;   // Composition: list of Products
        private Customer _customer;        // Composition: one Customer

        // Constructor (customer is required; product list starts empty)
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        // Adds a product to the order
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Computes the total cost (products + shipping)
        public double GetTotalCost()
        {
            double totalProducts = 0;

            foreach (Product product in _products)
            {
                totalProducts += product.GetTotalCost();
            }

            // Shipping: $5 if in USA, $35 otherwise
            double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;

            return totalProducts + shippingCost;
        }

        // Generates the packing label (name and ID of each product)
        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();

            foreach (Product product in _products)
            {
                packingLabel.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
            }

            return packingLabel.ToString();
        }

        // Generates the shipping label (customer name + full address)
        public string GetShippingLabel()
        {
            return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }
}