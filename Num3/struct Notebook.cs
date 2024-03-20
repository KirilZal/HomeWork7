namespace Num3
{
    struct Notebook
    {
        private string name;
        private string manufacturer;
        private double price;


        public Notebook(string Name,string Manuf,double Price) 
        {
            this.name = Name;
            this.manufacturer = Manuf;
            this.price = Price;

            
        }
        public static  void Gets()
        {
            Notebook notebook = new Notebook("MACBOOK", "APPLE", 1000);
            Console.WriteLine(notebook.name);
            Console.WriteLine(notebook.manufacturer);
            Console.WriteLine("$"+notebook.price);


        }
        static void Main(string[] args)
        {
            Gets();
        }
    }
}