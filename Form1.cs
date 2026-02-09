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
        vehcileTitle.Text = _currentVehicle.Name;

        startButton.Enabled = false;
        startButton.Visible = false;

        var location = Path.GetDirectoryName(Application.ExecutablePath);

        vehcilePictureBox.Image = Image.FromFile(Path.Combine(location!, "images", _currentVehicle.Image));

        listBoxIssues.Items.Clear();
        foreach (var issue in _currentVehicle.Issues)
        {
            listBoxIssues.Items.Add(issue.Attribute);
        }

        listBoxPositives.Items.Clear();
        listBoxPositives.Items.Add(_currentVehicle.Positive is null ? "None" : _currentVehicle.Positive.Attribute);

        listBoxPriceHistory.Items.Clear();
        listBoxPriceHistory.Items.Add($"Initial Price: £{_currentVehicle.Price}");
    }

    public void pictureBox1_Click(object sender, EventArgs e)
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
        //SetupVehicle();
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        _currentVehicle = VehicleGenerator.GenerateVehicleWithAdjustedPrice();
        SetupVehicle();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void raisePriceButton_Click(object sender, EventArgs e)
    {
        listBoxPriceHistory.Items.Add($"New Bid £{numericUpDownBid.Value + _currentVehicle.Price}");
    }
}