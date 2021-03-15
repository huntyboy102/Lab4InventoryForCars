namespace Lab4InventoryForCars
{
    /// <summary>
    /// A class created to keep track of cars that have been entered by the user.
    /// </summary>
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
        private decimal carPrice;
        // A private bool that checks if the car is new.
        private bool carNewStatus = false;

        /// <summary>
        /// Constructor - Default - Creates a new car object.
        /// </summary>
        public Car()
        {
            carCount += 1;
            carIdNumber = carCount;
        }

        /// <summary>
        /// Constructor - Parameterized - Creates a new car object.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="newStatus"></param>
        public Car(string make, string model, int year, decimal price, bool newStatus) : this()
        {
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            carNewStatus = newStatus;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of cars that have been entered into the listview.
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets the cars Identification number.
        /// </summary>
        public int Id
        {
            get
            {
                return carIdNumber;
            }
        }

        /// <summary>
        /// NewStatus Property - Gets and sets the status of the car.
        /// </summary>
        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                carNewStatus = value;
            }
        }

        /// <summary>
        /// Make Property - Gets and Sets the model of the car.
        /// </summary>
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                carMake = value;
            }
        }

        /// <summary>
        /// Model Property - Gets and Sets the model of the car.
        /// </summary>
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Year Property - Gets and Sets the year of the car.
        /// </summary>
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }

        /// <summary>
        /// Price Property - Gets and Sets the price of the car.
        /// </summary>
        public decimal Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }

        /// <summary>
        /// GetCarData is a function that gets all entered car data from the class scope.
        /// </summary>
        /// <returns></returns>
        public string GetCarData()
        {
            return "This is a " + carMake + " " + carModel + " from the year " + carYear +
                   " it is worth " + carPrice + " and it is " + (carNewStatus ? "new." : "not new.");
        }
    }
}