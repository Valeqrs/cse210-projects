namespace OnlineOrdering
{
    public class Customer
    {
        // Private member variables
        private string _name;
        private Address _address;   // Composition: a Customer has an Address

        // Constructor
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Determines if the customer lives in the USA (delegates to Address)
        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        // Getters
        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }
    }
}