using System.CodeDom.Compiler;
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

        
    }

    }
    class Vehicle
    {
        private string Name;
        private int Price;
        private string Image;
        private List<String> Issue;
        private string Positives;
        private string owner;
        public List<String> IssueGenerator()
        {
            Console.WriteLine("Issue Selection Triggered");
            List<String> Issues = new List<String>();
            Issues.Add("Rust", -3000);
            Issues.Add("Engine Knocking", -500);
            Issues.Add("Broken Shock Absorber", -100);
            Issues.Add("Misfiring", -600);
            Issues.Add("Blown Head Gasket", -200);
            Issues.Add("'Slick' Tyres", -400);
            Issues.Add("Electrical Issues", -50);
            Issues.Add("Oil Leak", -70);
            Issues.Add("Fuel Leak", -400);
            Issues.Add("Broken Camshaft", -300);
            Issues.Add("Bullet Holes", -900);
            Issues.Add("Full of Water", -200);
            Issues.Add("Misaligned Steering", -60);
            Issues.Add("Dead Body in the Back", -4000);
            Issues.Add("Suggestion Wheel", -2000);
            Issues.Add("Shattered Windows", -600);
            Issues.Add("Spontaneous Combustion", -10000);
            Issues.Add("Broken Radiator", -600);
            Issues.Add("Broken Radio", -30);
            Issues.Add("Filled with Asbestos", -6000);
            List<String> GeneratedIssue = new List<String>();
            for (int i = 0; i < 3; i++)
            {
                Random num2 = new Random();
                int int2 = num2.Next(20);
                string Issue1 = Issues[int2];
                GeneratedIssue.Add(Issue1);
            }
            return GeneratedIssue;
        }
        public List<String> VehicleGenerator()
        {
            Console.WriteLine("Vehicle Selection Triggered");
            List<String> Vehicles = new List<String>();
            Vehicles.Add("Volvo 850r", "Volvo.png");
            Vehicles.Add("Subaru Legacy", "Legacy.png");
            Vehicles.Add("Subaru Impreza", "Impreza.png");
            Vehicles.Add("Chevrolet Bel Air", "BelAir.png");
            Vehicles.Add("Chevrolet Silverado", "Silverado.png");
            Vehicles.Add("Suzuki Jimney", "Jimny.png");
            Vehicles.Add("Bismarck", "");
            Vehicles.Add("Yamato", "");
            Vehicles.Add("MiG-15", "");
            Vehicles.Add("Fairey Swordfish", "");
            Vehicles.Add("Churchill Gun Carrier", "");
            Vehicles.Add("T34", "");
            Vehicles.Add("Toyota Land Cruiser", "LandCruiser.png");
            Vehicles.Add("B29 Enola Gay", "");
            Vehicles.Add("Reliant Robin", "ReliantRobin.png");
            Vehicles.Add("RedBull Soapbox", "SoapBox.png");
            Vehicles.Add("RedBull Mini", "RBmini.png");
            Vehicles.Add("Carthaginian War Elephant", "WarElephant.png");
            Vehicles.Add("Mustang Mach 1", "Mustang.png");
            Vehicles.Add("Williams FW14B", "WilliamsFW14B.png");

            Random num1 = new Random();
            int int1 = num1.Next(20);
            Console.WriteLine(int1);
            //number used to get the other things
            return Vehicles(int1);
        }

        public List<String> PositiveGenerator()
        {
            Console.WriteLine("Positive Generation Triggered");
            List<String> Positives = new List<String>();
            Positives.Add("Trustworthy Owner", 3000);
            Positives.Add("Valid MOT", 500);
            Positives.Add("Rare Model", 6000);
            Positives.Add("Filled With Gold", 2000);
            Positives.Add("Spare Wheel", 200);
            List<String> GeneratedPositive = new List<String>();
            Random num1 = new Random();
            int int1 = num1.Next(50);
            if (int1 <= 4)
            {
                GeneratedPositive.Add(Positives(int1));
            }
            Console.WriteLine(GeneratedPositive);
            return GeneratedPositive;
        }
        

        public Vehicle(String pName, int pPrice, string pImage)
        {
            Name = VehicleGenerator(0);
            Price = pPrice;
            Image = VehicleGenerator(1);
            Issue = IssueGenerator(0);
            Issue = IssueGenerator(1); 
            Positives = PositiveGenerator(0);
            PositivesValue = PositiveGenerator(1);
            
            
        }

        
    }
