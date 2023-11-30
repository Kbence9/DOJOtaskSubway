namespace DOJOSubway.Items.Model;

public enum Flavours
{
    CocaCola,
    Fanta,
    IceTea
}

public class FlavourExtension
{
    private static Dictionary<Flavours, decimal> flavours = new Dictionary<Flavours, decimal>
    {
        { Flavours.CocaCola, (decimal)0.5 },
        { Flavours.Fanta, (decimal)0.4 },
        { Flavours.IceTea, (decimal)0.3 }
    };

    public static decimal GetPrice(Flavours flavour)
    {
        return flavours[flavour];
    }
}