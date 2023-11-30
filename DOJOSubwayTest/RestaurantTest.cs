using DOJOSubway.Items.Model;
using DOJOSubway.Restaurant.Model;

namespace DOJOSubwayTest;

public class RestaurantTest
{

    [Test]
    public void AddOrderTest()
    {
        var testRestaurant = new Restaurant("HellsKitchen");
        testRestaurant.AddOrder(new Sandwich(new List<Ingredients>{new Ingredients("ham", 2)}));
        testRestaurant.AddOrder(new Drink(Flavours.CocaCola));

        const decimal expectedIncome = 3.5m;
        
        Assert.That(testRestaurant.GetIncome(), Is.EqualTo(expectedIncome));
    }
}