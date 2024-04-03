using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Order<HomeDelivery> order = new Order<HomeDelivery>();
            order.Customer = new HomeDelivery()
            {
                Name = "Толян",
                LastName = "Прохоров",
                Address = "Красная поляна, д.9",
                PhoneNumber = "89621356879",
                CarNumber = "А596РЕ99",
                DriverName = "Алексей куравлев"
            };

            Product product = new Product(20, "20x50x30", Color.Blue);
            product.DisplayProduct();
            order.DisplayOrder();
            order.Customer.DeliveryDetails();

            Console.ReadKey();            
        }
    }
    abstract class Customer
    {
        public string Name {  get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Address {  get; set; }
    }

    class HomeDelivery : Customer
    {
        public string CarNumber {  get; set; }
        public string DriverName {  get; set; }

        public void DeliveryDetails()
        {
            Console.WriteLine("\nДетали доставки:");
            Console.WriteLine("Номер машины доставки: {0}\nИмя водителя - {1}", CarNumber, DriverName);
        }
    }

    class PickPointDelivery : Customer
    {
        public string PickPointName {  get; set; }
        public string PickPointAddress { get; set; }
        public void DeliveryDetails()
        {
            Console.WriteLine("\nДетали доставки:");
            Console.WriteLine("Название точки получения: {0}\nАдрес точки получателя - {1}", PickPointName, PickPointAddress);
        }
    }

    class ShopDelivery : Customer
    {
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public void DeliveryDetails()
        {
            Console.WriteLine("\nДетали доставки:");
            Console.WriteLine("Название магазина: {0}\nАдрес магазина - {1}", ShopName, ShopAddress);
        }
    }

    class Product
    {
        public int Weight {  get; set; }
        public string Size { get; set; }
        public Color Colour { get; set; } = Color.Blue;

        public Product(int weight, string size, Color colour)
        {
            Weight = weight;
            Size = size;
            Colour = colour;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Товар:\nВес {0} кг.\nРазмер {1} см.\nРасцветка товара - {2}", Weight, Size, Colour.Name);
        }

    }

    
    
    class Order<TCustomer> where TCustomer : Customer
    {
        public TCustomer Customer;

        public int Number;

        public string Description;

        public void DisplayOrder()
        {
            Console.WriteLine("\nЗаказчик {0} {1}",Customer.LastName, Customer.Name);
            Console.WriteLine("Телефон заказчика: {0}",Customer.PhoneNumber);
            Console.WriteLine("Адрес заказчика: {0}",Customer.Address);
        }
    }
}
