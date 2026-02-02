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
        LabelName.Text = _currentVehicle.Name;

        // You can set up other UI elements related to the vehicle here
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
