/*Задание.
Добавить в программу (https://github.com/itstep-shambala/Sales.git) возможность добавления данных о покупке после ввода 
всей необходимой информации. Т.е.нужно от пользователя получить данные для всех полей таблицы tab_orders и написать 
запрос на добавление в неё строки.*/

using MySql.Data.MySqlClient;
using System;
using CLI;
using SalesLib;

namespace SalesApp
{
    class Program
    {
        static void Main()
        {
            var db = new DataBase();
            /*var products = db.GetProducts();
            var buyers = db.GetBuyers();
            Buyer buyer;
            
            foreach (var item in buyers)
            {
                Show.PrintLn($"{item.Id} - {item.Name}");
            }
            Show.PrintLn("Выберите номер покупателя");
            var buyer_id = uint.Parse(Console.ReadLine());
            if (buyer_id == 0)
            {
                buyer = new Buyer();
            }
            else
            {
                buyer = buyers[(int)(buyer_id - 1)];
            }

            Show.PrintLn($"{buyer.Name} - {buyer.Discount}");

            foreach (var product in products)
            {
                Show.PrintLn($"{product.Id}: {product.Name}, {product.Price}");
            }

            Show.Print("Введите номер продукта: ");
            var product_id = uint.Parse(Console.ReadLine());
            Show.Print("Введите количество: ");
            var count_user = uint.Parse(Console.ReadLine());

            var count_stock = db.GetProductCount(product_id);

            if (count_user > count_stock)
            {
                Show.Error("Столько нет товара на складе");
                return;
            }

            var price = products[(int)(product_id - 1)].Price;
            var total_price = count_user * (price - price * buyer.Discount / 100);
            Show.PrintLn($"Вам необходимо заплатить - {total_price}");*/
            
            Show.PrintLn("Введите данные о заказе: ");
            Show.Print("Номер покупателя  ");
            var buyer_id = uint.Parse(Console.ReadLine());
            Show.Print("Номер продавца  ");
            var seller_id = uint.Parse(Console.ReadLine());
            Show.Print("Дата  ");
            //var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var date = Convert.ToString(Console.ReadLine());
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Show.Print("Номер продукта  ");
            var product_id = uint.Parse(Console.ReadLine());
            Show.Print("Цена  ");
            var amount = uint.Parse(Console.ReadLine());
            Show.Print("Итоговая стоимость  ");
            var total_price = uint.Parse(Console.ReadLine());

            db.AddOrder(buyer_id, seller_id, date, /*DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")*/ product_id, amount, total_price);
            /*var orders = db.GetOrders();
            foreach (var order in orders)
            {
                Show.PrintLn($"{order.Id}: {order.BuyerId}, {order.Date} {order.Amount}, {order.TotalPrice}");
            }*/
        }
    }
}
