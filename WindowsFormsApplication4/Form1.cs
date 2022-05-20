using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car v = new WindowsFormsApplication4.Car();

        }
    }
    class Automobile
    {
        // Constructor
        public Automobile()
        {
            Make = "a";
            Model = "";
            Mileage = 0;
            Price = 0m;
        }

        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }

    class Car : Automobile
    {
        // Constructor
        public Car()
        {
            Doors = 0;
        }

        // Doors property
        public int Doors { get; set; }
    }
}
