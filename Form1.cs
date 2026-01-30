namespace GroupProject;

public partial class Game : Form
{
    public Game()
    {
        InitializeComponent();

        Vehicle currentVehicle = VehicleGenerator.GenerateVehicle();
        List<VehicleAttribute> currentIssues = VehicleGenerator.GenerateIssues();
        VehicleAttribute? currentPositive = VehicleGenerator.GeneratePositive();

        // Display vehicle information
        LabelName.Text = currentVehicle.Name;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void progressBar1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }



    private void button1_Click_1(object sender, EventArgs e)
    {

    }
}




class VehicleGenerator
{
    public static Vehicle GenerateVehicle()
    {
        var vehicles = new List<Vehicle>
        {
            new Vehicle("Volvo 850r", "Volvo.png", 15000),
            new Vehicle("Subaru Legacy", "Legacy.png", 10000),
            new Vehicle("Subaru Impreza", "Impreza.png", 18000),
            new Vehicle("Chevrolet Bel Air", "BelAir.png", 40000),
            new Vehicle("Chevrolet Silverado", "Silverado.png", 11000),
            new Vehicle("Suzuki Jimney", "Jimny.png", 20000),
            new Vehicle("Bismarck", "", 1000000),
            new Vehicle("Yamato", "", 1000000),
            new Vehicle("MiG-15", "", 150000),
            new Vehicle("Fairey Swordfish", "", 60000),
            new Vehicle("Churchill Gun Carrier", "", 35000),
            new Vehicle("T34", "", 50000),
            new Vehicle("Toyota Land Cruiser", "LandCruiser.png", 25000),
            new Vehicle("B29 Enola Gay", "", 160000),
            new Vehicle("Reliant Robin", "ReliantRobin.png", 30000),
            new Vehicle("RedBull Soapbox", "SoapBox.png", 19000),
            new Vehicle("RedBull Mini", "RBmini.png", 30000),
            new Vehicle("Carthaginian War Elephant", "WarElephant.png", 40000),
            new Vehicle("Mustang Mach 1", "Mustang.png", 60000),
            new Vehicle("Williams FW14B", "WilliamsFW14B.png", 260000)
        };

        var random = new Random();
        var generatedVehicleNumber = random.Next(vehicles.Count);
        var generatedVehicle = vehicles[generatedVehicleNumber];

        System.Diagnostics.Debug.WriteLine(generatedVehicle);
        return generatedVehicle;

        //int int2 = num2.Next(20);
        //Tuple<string, string, int> Vehicle = Vehicles[int2];

        //return GeneratedVehicle;
    }

    public static VehicleAttribute? GeneratePositive()
    {
        var positives = new List<VehicleAttribute>
        {
            new VehicleAttribute("Trustworthy Owner", 3000),
            new VehicleAttribute("Valid MOT", 500),
            new VehicleAttribute("Rare Model", 6000),
            new VehicleAttribute("Filled With Gold", 2000),
            new VehicleAttribute("Spare Wheel", 200)
        };

        var random = new Random();
        var generatedPositiveNumber = random.Next(50);

        if (generatedPositiveNumber <= 4)
        {
            var generatedPositive = positives[generatedPositiveNumber];
            System.Diagnostics.Debug.WriteLine(generatedPositive);
            return generatedPositive;
        }

        return null;
    }

    public static List<VehicleAttribute> GenerateIssues()
    {
        var issues = new List<VehicleAttribute>
        {
            new VehicleAttribute("Rust", -3000),
            new VehicleAttribute("Engine Knocking", -500),
            new VehicleAttribute("Broken Shock Absorber", -100),
            new VehicleAttribute("Misfiring", -600),
            new VehicleAttribute("Blown Head Gasket", -200),
            new VehicleAttribute("'Slick' Tyres", -400),
            new VehicleAttribute("Electrical Issues", -50),
            new VehicleAttribute("Oil Leak", -70),
            new VehicleAttribute("Fuel Leak", -400),
            new VehicleAttribute("Broken Camshaft", -300),
            new VehicleAttribute("Bullet Holes", -900),
            new VehicleAttribute("Full of Water", -200),
            new VehicleAttribute("Misaligned Steering", -60),
            new VehicleAttribute("Dead Body in the Back", -4000),
            new VehicleAttribute("Suggestion Wheel", -2000),
            new VehicleAttribute("Shattered Windows", -600),
            new VehicleAttribute("Spontaneous Combustion", -10000),
            new VehicleAttribute("Broken Radiator", -600),
            new VehicleAttribute("Broken Radio", -30),
            new VehicleAttribute("Filled with Asbestos", -6000)
        };

        var issuesSelected = new List<VehicleAttribute>();

        for (int i = 0; i < 3; i++)
        {
            var random = new Random();
            var generatedIssueNumber = random.Next(issues.Count);
            issuesSelected.Add(issues[generatedIssueNumber]);
        }

        return issuesSelected;
    }
   
}
