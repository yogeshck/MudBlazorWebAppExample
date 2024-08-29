using FluentValidation;

namespace MudBlazorWebAppExample.Models;

public class Order
{
    public Order() { OrderLines = new(); }

    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public string ContactNumber { get; set; }
    public string ContactName { get; set; }
    public List<OrderLine> OrderLines { get; set; }
}

public class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator() 
    {
        RuleFor(order => order.OrderNumber).NotEmpty();
        RuleFor(order => order.OrderDate).NotEmpty();
    }
}

public class OrderLine
{
    public string OrderLineId { get; set; }
    public string ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
