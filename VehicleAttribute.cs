namespace GroupProject;

public class VehicleAttribute
{
    public string Attribute { get; set; }
    public decimal PriceEffect { get; set; }

    public VehicleAttribute(string attribute, decimal priceEffect)
    {
        Attribute = attribute;
        PriceEffect = priceEffect;
    }
}
