namespace W4_Encapsulation
{
    public class Car
    {
        private string _make;
        private string _model;
        private string _color;
        private int _numberOfDoors;

        // getters and setters
        public string Make { get { return _make; } set { _make = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set
            {
                if (value != 2 || value != 4)
                {
                    Console.WriteLine("Invalid number of doors");
                    _numberOfDoors = -1;
                }
                else
                {
                    _numberOfDoors = value;
                }
            }
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Make: {_make}");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Color: {_color}");
            Console.WriteLine($"Number of doors: {_numberOfDoors}");
        }
    }
}
