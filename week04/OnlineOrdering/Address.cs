namespace OnlineOrdering
{
    public class Address
    {
        // Private member variables
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        // Constructor
        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        // Returns true if the address is in the USA (case-insensitive)
        public bool IsInUSA()
        {
            return _country.ToLower() == "usa";
        }

        // Returns the full address as a multi-line string
        public string GetFullAddress()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}
