namespace ConsoleApp3
{
    internal class Product
    {
        public static int counter = 0;
        public string name = "노네임";
        public int price = 1000;
        public int id = -1;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.id = counter++;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "["+this.id+ "]"+this.name + " : " + this.price;
        }
    }
}