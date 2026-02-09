namespace GroupProject.Domain;

public class Vehicle
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public List<VehicleAttribute> Issues { get; set; } = [];
    public VehicleAttribute? Positive { get; set; }

    public Vehicle(string name, string image, decimal price)
    {
        Name = name;
        Image = image;
        Price = price;
    }
}

