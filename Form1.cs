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

        private String IssueGenerator()
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
            List<String> generatedIssue = new List<String>();
            for (int i = 0; i < 3; i++)
            {
                Random num2 = new Random();
                int int2 = num2.Next(20);
                string Issue1 = Issues[int2];
                generatedIssue.Add(Issue1);
            }
            return generatedIssue;
        }



    }
    public class Vehicles
    {
        private void Issues()
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
            //move below to a method
            Random num2 = new Random();
            int int2 = num2.Next(20);
            string Issue1 = Issues[int2];
            Console.WriteLine(Issue1);
            Random num3 = new Random();
            int int3 = num2.Next(20);
            string Issue2 = Issues[int2];
            Console.WriteLine(Issue2);
            //selects two issues; judah, you  can add the percentage chances later :)
        }
        private void positives()
        {
            Console.WriteLine("Positive Selection Triggered");
            List<String> Positives = new List<String>();
            Positives.Add("Workshop Voucher");
            Positives.Add("Respectable Previous Owner");
            Positives.Add("Valid MOT");
            Positives.Add("Cheap Insurance");
            Positives.Add("Negligible Tax");
            Positives.Add("Garden Centre Voucher in the Boot");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
            Positives.Add("");
        }
        private void Car()
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
            Vehicles.Add("ASDA Shopping Trolley");
            Vehicles.Add("Wright Flyer");
            //move below to a method
            Random num1 = new Random();
            int int1 = num1.Next(20);
            Console.WriteLine(int1);
            //number used to get the other things
            string Vehicle = Vehicles[int1];
            Console.WriteLine(Vehicle);
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
}
