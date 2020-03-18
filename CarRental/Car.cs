namespace CarRental
{
    public class Car
    {
        public Car(string brand, string model, string color, string regNumber, int year, double rent)
        {
            Brand = brand;
            Model = model;
            Color = color;
            RegistrationNumber = regNumber;
            Year = year;
            Rent = rent;
            DayRent = 0;
        } 

        public Car()
        {
            DayRent = 0;
        }

        private string _brand;
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        private string _model;
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        private string _color;
        public string Color
        {
            get => _color;
            set => _color = value;
        }

        private string _registrationNumber;
        public string RegistrationNumber
        {
            get => _registrationNumber;
            set => _registrationNumber = value;
        }

        private int _year;
        public int Year
        {
            get => _year;
            set => _year = value;
        }

        private double _rent;
        public double Rent
        {
            get => _rent;
            set => _rent = value;
        }

        private int _dayRent;
        public int DayRent
        {
            get => _dayRent;
            set => _dayRent = value;
        }
    }
}
