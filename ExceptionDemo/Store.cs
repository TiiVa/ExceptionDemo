using ClassLib;
using LINQDemo.Data;

namespace ExceptionDemo;

public class Store
{
    public DataSource Db { get; set; } = new DataSource();

    public void Welcome()
    {
        Console.WriteLine("Välkommen!");

        ViewBasket();
    }

    private void ViewBasket()
    {
        try
        {
            var cart = Db.GetCartForPerson(9);

            foreach (var product in cart)
            {
                Console.WriteLine(product.Name);
            }
        }
        catch (IdiotUserException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Ojojoj!");
        }
        finally
        {
            Console.WriteLine("All is reset!");
        }
    }
}