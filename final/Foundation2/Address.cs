public class Address{

    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private string _inUS;

    public Address(string streetAddress, string city, string stateProvince, string country){
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;

    }

    public string GetInUS(){
        if (_country == "USA"){
            _inUS = "true";
        }else{
            _inUS = "false";
        }
        
        return _inUS;
    }

    public string FullAddress(){
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
    }
}