using System.Text.Json;
namespace DB
{
    public class Program
    {
        public static void Main()
        {
            DataBase dataBase = new DataBase();
            Client client = new Client("РОМА", "lox@mail.ru");
            Market market = new Market("ЦУМ", "www.cum.ru", "Универсам");
            Store store = new Store(market, "Казань");

            Merch merch1 = new Merch("001", "Cat", 1000f, store, 2);
            Merch merch2 = new Merch("002", "Dad", 0f, store, 2);

            Basket basket = new Basket(client, "01.02.2022", "03.02.2022", new List<Merch> { merch1,merch2}, 1000f);
            string json = JsonSerializer.Serialize(basket);
            Console.WriteLine(json);
        }

    }
}