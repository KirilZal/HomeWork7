namespace Num1
{
   struct Train
    {
        private string _destination;
        private int _trainNumber;
        private string  _departureTime;

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int TrainNumber
        {
            get { return _trainNumber; }
            set { _trainNumber = value; }
        }

        public string DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }
        }

        
        public Train(string destination, int trainNumber, string departureTime)
        {
            _destination = destination;
            _trainNumber = trainNumber;
            _departureTime = departureTime;
        }

    }

}
