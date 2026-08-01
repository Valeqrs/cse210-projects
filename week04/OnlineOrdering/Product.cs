namespace OnlineOrdering
{
    public class Product
    {
        // Private member variables
        private string _name;
        private int _productId;
        private double _pricePerUnit;
        private int _quantity;

        // Constructor
        public Product(string name, int productId, double pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        // Calculates total cost for this product (price * quantity)
        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        // Getters for packing label
        public string GetName()
        {
            return _name;
        }

        public int GetProductId()
        {
            return _productId;
        }
    }
}