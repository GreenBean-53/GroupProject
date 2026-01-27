using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();

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
            //Vehicles

            List<String> Images = new List<String>();
            Images.Add("imageexamplefile.jpg");



            Random num1 = new Random();
            int int1 = num1.Next(20);
            Console.WriteLine(int1);
            //number used to get the other things
            string Vehicle = Vehicles[int1];
            Console.WriteLine(Vehicle);
            //int1 used to get the vehicle choice
            //       string Image = Images[int1];
            //       Console.WriteLine(Image);
            //   string Image = Images[int1];
            //  Console.WriteLine(Image);
            //       string Image = Images[int1];
            //       Console.WriteLine(Image);
            //   string Image = Images[int1];
            //  Console.WriteLine(Image);
            //string Image = Images[int1];
            //Console.WriteLine(Image);
            //later add function to open the individual image file
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void auctionFront_Click(object sender, EventArgs e)
        {

        }

        private void clickPlay(object sender, EventArgs e)
        {
            this.auctionTabs.SelectedTab = this.aucPurPage;
        }

        private void tutorialClick(object sender, EventArgs e)
        {

        }

        private void exitClick(object sender, EventArgs e)
        {

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

            {

            }
            Random num2 = new Random();
            int int2 = num2.Next(20);
            string Issue = Issues[int2];
            Console.WriteLine(Issue);
            //new int2 used to randomise the issue from the list
        }
    }
}
