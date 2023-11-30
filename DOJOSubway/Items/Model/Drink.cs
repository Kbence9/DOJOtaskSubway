namespace DOJOSubway.Items.Model;

public class Drink : OrderItem
{
    private readonly Flavours _flavour;
    private readonly decimal _basePrice = 1;

    public Drink(Flavours flavour)
    {
        _flavour = flavour;
    }

    public override decimal GetPrice()
    {
        return _basePrice + FlavourExtension.GetPrice(_flavour);
    }
}