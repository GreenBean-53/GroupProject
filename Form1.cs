using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using GroupProject.Domain;
using GroupProject.Services;

namespace GroupProject;

public partial class Game : Form
{
    private Vehicle _currentVehicle;

    public Game()
    {
        InitializeComponent();

        _currentVehicle = VehicleGenerator.GenerateVehicleWithAdjustedPrice();
        SetupVehicle();
    }

    private void SetupVehicle()
    {
        // LabelName.Text = _currentVehicle.Name;

        // You can set up other UI elements related to the vehicle here
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
        this.auctionTabs.SelectedTab = this.tutorialPage;
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
        this.auctionTabs.SelectedTab = this.tutorialPage;
    }

    private void exitClick(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click_3(object sender, EventArgs e)
    {
        this.auctionTabs.SelectedTab = this.mainMenu;
    }

    private void negativeAttributes_TextChanged(object sender, EventArgs e)
    {

    }

    private void vehcileTitle_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        vehcileTitle.Text = _currentVehicle.Name;

        startButton.Enabled = false;    
        startButton.Visible = false;    
    }
}