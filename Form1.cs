using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Security.Policy;

namespace GroupProject
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
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




    class Vehicle
    {
        private string name;
        private int price;
        private string image;
        private List<Tuple<String, int>> issue;
        private string positive;
        private int issuevalue;
        private int positivevalue;
        public static List<Tuple<String, int>> IssueGenerator()
        {
            Console.WriteLine("Issue Selection Triggered");
            List<Tuple<String, int>> Issues = new List<Tuple<String, int>>();
            Issues.Add(Tuple.Create("Rust", -3000));
            Issues.Add(Tuple.Create("Engine Knocking", -500));
            Issues.Add(Tuple.Create("Broken Shock Absorber", -100));
            Issues.Add(Tuple.Create("Misfiring", -600));
            Issues.Add(Tuple.Create("Blown Head Gasket", -200));
            Issues.Add(Tuple.Create("'Slick' Tyres", -400));
            Issues.Add(Tuple.Create("Electrical Issues", -50));
            Issues.Add(Tuple.Create("Oil Leak", -70));
            Issues.Add(Tuple.Create("Fuel Leak", -400));
            Issues.Add(Tuple.Create("Broken Camshaft", -300));
            Issues.Add(Tuple.Create("Bullet Holes", -900));
            Issues.Add(Tuple.Create("Full of Water", -200));
            Issues.Add(Tuple.Create("Misaligned Steering", -60));
            Issues.Add(Tuple.Create("Dead Body in the Back", -4000));
            Issues.Add(Tuple.Create("Suggestion Wheel", -2000));
            Issues.Add(Tuple.Create("Shattered Windows", -600));
            Issues.Add(Tuple.Create("Spontaneous Combustion", -10000));
            Issues.Add(Tuple.Create("Broken Radiator", -600));
            Issues.Add(Tuple.Create("Broken Radio", -30));
            Issues.Add(Tuple.Create("Filled with Asbestos", -6000));
            List<Tuple<String, int>> GeneratedIssue = new List<Tuple<String, int>>();
            for (int i = 0; i < 3; i++)
            {
                Random num2 = new Random();
                int int2 = num2.Next(20);
                Tuple<string, int> Issue = Issues[int2];
                System.Diagnostics.Debug.WriteLine(Issue);
                //GeneratedIssue.Add(Tuple.Create(Issue));
            }
            return GeneratedIssue;

        }
        public static List<Tuple<String, string, int>> VehicleGenerator()
        {
            List<Tuple<String, String, int>> Vehicles = new List<Tuple<String, String, int>>();
            Vehicles.Add(Tuple.Create("Volvo 850r", "Volvo.png", 15000));
            Vehicles.Add(Tuple.Create("Subaru Legacy", "Legacy.png", 10000));
            Vehicles.Add(Tuple.Create("Subaru Impreza", "Impreza.png", 18000));
            Vehicles.Add(Tuple.Create("Chevrolet Bel Air", "BelAir.png", 40000));
            Vehicles.Add(Tuple.Create("Chevrolet Silverado", "Silverado.png", 11000));
            Vehicles.Add(Tuple.Create("Suzuki Jimney", "Jimny.png", 20000));
            Vehicles.Add(Tuple.Create("Bismarck", "", 1000000));
            Vehicles.Add(Tuple.Create("Yamato", "", 1000000));
            Vehicles.Add(Tuple.Create("MiG-15", "", 150000));
            Vehicles.Add(Tuple.Create("Fairey Swordfish", "", 60000));
            Vehicles.Add(Tuple.Create("Churchill Gun Carrier", "", 35000));
            Vehicles.Add(Tuple.Create("T34", "", 50000));
            Vehicles.Add(Tuple.Create("Toyota Land Cruiser", "LandCruiser.png", 25000));
            Vehicles.Add(Tuple.Create("B29 Enola Gay", "", 160000));
            Vehicles.Add(Tuple.Create("Reliant Robin", "ReliantRobin.png", 30000));
            Vehicles.Add(Tuple.Create("RedBull Soapbox", "SoapBox.png", 19000));
            Vehicles.Add(Tuple.Create("RedBull Mini", "RBmini.png", 30000));
            Vehicles.Add(Tuple.Create("Carthaginian War Elephant", "WarElephant.png", 40000));
            Vehicles.Add(Tuple.Create("Mustang Mach 1", "Mustang.png", 60000));
            Vehicles.Add(Tuple.Create("Williams FW14B", "WilliamsFW14B.png", 260000));

            List<Tuple<String, String, int>> GeneratedVehicle = new List<Tuple<String, String, int>>();
            Random num2 = new Random();
            int int2 = num2.Next(20);
            Tuple<string, string, int> Vehicle = Vehicles[int2];
            System.Diagnostics.Debug.WriteLine(Vehicle);
            return GeneratedVehicle;
        }

        public static List<Tuple<String, string, int>> PositiveGenerator()
        {
            List<Tuple<String, int>> Positives = new List<Tuple<String, int>>();
            Positives.Add(Tuple.Create("Trustworthy Owner", 3000));
            Positives.Add(Tuple.Create("Valid MOT", 500));
            Positives.Add(Tuple.Create("Rare Model", 6000));
            Positives.Add(Tuple.Create("Filled With Gold", 2000));
            Positives.Add(Tuple.Create("Spare Wheel", 200));
            List<Tuple<String, String, int>> GeneratedPositive = new List<Tuple<String, String, int>>();
            Random num1 = new Random();
            int int1 = num1.Next(50);
            if (int1 <= 4)
            {
                Tuple<string, int> Positive = Positives[int1];
                System.Diagnostics.Debug.WriteLine(Positive);
            }
            Console.WriteLine(GeneratedPositive);
            return GeneratedPositive;
        }


        public Vehicle(string modelName, string imageFile, int modelPrice, List<Tuple<string, int>> issueslist, string positivechoice, int issueprice, int positiveprice)
        {
            name = modelName;
            image = imageFile;
            price = modelPrice;
            issue = issueslist;
            positive = positivechoice;
            issuevalue = issueprice;
            positivevalue = positiveprice;
        }
        Vehicle vehicle1 = new Vehicle(VehicleGenerator(), IssueGenerator(), PositiveGenerator());
        
    }
}
