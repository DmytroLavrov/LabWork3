using System;

namespace FourthTask
{
    class Invoice
    {
        public int account;
        public string customer;
        public string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        private int price;
        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            Article = "";
            Quantity = 0;
            this.price = price;
        }
        private double PriceWithVAT()
        {
            return price * Quantity * 1.2;
        }
        private double PriceWithoutVAT()
        {
            return (double)price * Quantity;
        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            return "Рахунок №" + account + "\nКлієнт: " + customer + "\nПостачальник: " + provider + "\nІнформація про товар:\nПродукт - " + Article
                + ", Кількість - " + Quantity + ", Ціна за одиницю - " + price + "\nЗагальна вартість без ПДВ: " + PriceWithoutVAT().ToString() + ", з ПДВ: " + PriceWithVAT().ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Invoice inv = new Invoice(117, "Ілля Забарний", "Микола Матвієнко", 2048);
            inv.Article = "Стіл з дерева";
            inv.Quantity = 303;
            Console.WriteLine(inv.ToString());
            Console.ReadKey();
        }
    }
}
