using MudBlazorWebAppExample.Models;

namespace MudBlazorWebAppExample
{
    public class ExampleAppContext
    {
        private static List<Order> _orders = new();

        public static List<Order> Orders { get => _orders; set => _orders = value; }
    }
}
