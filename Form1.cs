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

        private List<String> IssueGenerator()
        {
            Console.WriteLine("Issue Selection Triggered");
            List<String> Issues = new List<String>();
            Issues.Add("Rust");
            Issues.Add("Engine Knocking");
            Issues.Add("Broken Shock Absorber");
            Issues.Add("Misfiring");
            Issues.Add("Blown Head Gasket");
            Issues.Add("'Slick' Tyres");
            Issues.Add("Electrical Issues");
            Issues.Add("Oil Leak");
            Issues.Add("Fuel Leak");
            Issues.Add("Broken Camshaft");
            Issues.Add("Bullet Holes");
            Issues.Add("Full of Water");
            Issues.Add("Misaligned Steering");
            Issues.Add("Dead Body in the Back");
            Issues.Add("Suggestion Wheel");
            Issues.Add("Shattered Windows");
            Issues.Add("Spontaneous Combustion");
            Issues.Add("Broken Radiator");
            Issues.Add("Broken Radio");
            Issues.Add("Filled with Asbestos");
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
        private List<String> VehicleGenerator()
        {
            Console.WriteLine("Vehicle Selection Triggered");
            List<String> Vehicles = new List<String>();
            Vehicles.Add("Volvo 850r");
            Vehicles.Add("Subaru Legacy");
            Vehicles.Add("Subaru Impreza");
            Vehicles.Add("Chevrolet Bel Air");
            Vehicles.Add("Chevrolet Silverado");
            Vehicles.Add("Suzuki Jimney");
            Vehicles.Add("Bismarck");
            Vehicles.Add("Yamato");
            Vehicles.Add("MiG-15");
            Vehicles.Add("Fairey Swordfish");
            Vehicles.Add("Churchill Gun Carrier");
            Vehicles.Add("T34");
            Vehicles.Add("Toyota Land Cruiser");
            Vehicles.Add("B29 Enola Gay");
            Vehicles.Add("Reliant Robin");
            Vehicles.Add("RedBull Soapbox");
            Vehicles.Add("RedBull Mini");
            Vehicles.Add("Carthaginian War Elephant");
            Vehicles.Add("Mustang Mach 1");
            Vehicles.Add("Williams FW14B");

            List<String> GeneratedVehicle = new List<String>();
            Random num1 = new Random();
            int int1 = num1.Next(20);
            Console.WriteLine(int1);
            //number used to get the other things

            List<String> Images = new List<String>();
            Images.Add("Volvo.png");
            Images.Add("Legacy.png");
            Images.Add("Impreza.png");
            Images.Add("BelAir.png");
            Images.Add("Silverado.png");
            Images.Add("Jimny.png");
            Images.Add("");
            Images.Add("");
            Images.Add("");
            Images.Add("");
            Images.Add("");
            Images.Add("");
            Images.Add("LandCruiser.png");
            Images.Add("");
            Images.Add("ReliantRobin.png");
            Images.Add("SoapBox.png");
            Images.Add("RBmini.png");
            Images.Add("WarElephant.png");
            Images.Add("Mustang.png");
            Images.Add("WilliamsFW14B.png");

            return GeneratedVehicle;
        }


    }

    }
    class Vehicle
    {
        private string Name;
        private int Price;
        private string Image;
        private string Issue;
        private string Positives;
        private string owner;
        
        public Vehicle(String pName, int pPrice, string pImage)
        {
            Name = pName;
            Price = pPrice;
            Image = pImage;
            owner = "No Owner";
        }
    }
