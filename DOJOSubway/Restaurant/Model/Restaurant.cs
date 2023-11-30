using DOJOSubway.Items.Model;

namespace DOJOSubway.Restaurant.Model;

public class Restaurant
{
    private string _name;
    private readonly List<OrderItem> _orders = new();

    public void AddOrder(OrderItem order)
    {
        _orders.Add(order);
    }

    public decimal GetIncome()
    {
        return _orders.Sum(order => order.GetPrice());
    }

    public Restaurant(string name)
    {
        _name = name;
    }
}