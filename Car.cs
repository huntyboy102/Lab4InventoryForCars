namespace Lab4InventoryForCars
{
    class Car
    {
        // A private static integer that holds the number of cars entered.
        private static int carCount = 0;
        // A private readonly variable that keeps track of the cars identification number.
        private readonly int carIdNumber = 1;
        // A private string that keeps track of the cars make.
        private string carMake = string.Empty;
        // A private string that keeps track of the cars model.
        private string carModel = string.Empty;
        // A private integer that keeps track of the cars year.
        private int carYear;
        // A private integer that keeps track of the cars current price
        private decimal carPrice = 0;
        // A private bool that checks if the car is new.
        private bool carNewStatus = false;

        public Car()
        {
            carCount += 1;
            carIdNumber = carCount;
        }

        public Car(string make, string model, int year, decimal price, bool newStatus): this()
        {
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            carNewStatus = newStatus;
        }

        public string GetCarData()
        {
            return "This is a " + carMake + " " + carModel + " from the year " + carYear + 
                   " it is worth " + carPrice + " and it is " + (carNewStatus ? "new." : "not new.");
        }
        //public int Count
        //{
        //    get
        //    {
        //        return carCount;
        //    }
        //}

        //public int Id
        //{
        //    get
        //    {
        //        return carIdNumber;
        //    }
        //}

        //public bool NewStatus
        //{
        //    get
        //    {
        //        return carNewStatus;
        //    }
        //    set
        //    {
        //        carNewStatus = value;
        //    }
        //}

        //public string Make
        //{
        //    get
        //    {
        //        return carMake;
        //    }
        //    set
        //    {
        //        carMake = value;
        //    }
        //}

        //public string Model
        //{
        //    get
        //    {
        //        return carModel;
        //    }
        //    set
        //    {
        //        carModel = value;
        //    }
        //}

        //public int Year
        //{
        //    get
        //    {
        //        return carYear;
        //    }
        //    set
        //    {
        //        carYear = value;
        //    }
        //}

        //public decimal Price
        //{
        //    get
        //    {
        //        return carPrice;
        //    }
        //    set
        //    {
        //        carPrice = value;
        //    }
        //}
    }
}