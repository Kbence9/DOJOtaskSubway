namespace DOJOSubway.Items.Model;

public class Sandwich : OrderItem
{
    private readonly IEnumerable<Ingredients> _ingredients;

    public Sandwich(IEnumerable<Ingredients> ingredients)
    {
        _ingredients = ingredients;
    }
    
    public override decimal GetPrice()
    {
        return _ingredients.Sum(ing => ing.Price);
    }
}