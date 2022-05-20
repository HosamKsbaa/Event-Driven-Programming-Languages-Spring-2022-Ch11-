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
         
            Automobile v2=new WindowsFormsApplication4.Automobile(); 
            v2.printSpeed();
           

        }
    }
   abstract class  Automobile
    {
        // Constructor
        public Automobile()
        {
            Make = "a";
            Model = "";
            Mileage = 0;
            Price = 0m;
        }

        public virtual void printSpeed() {
            Console.WriteLine("50 ");
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
        public override void printSpeed()
        {
            Console.WriteLine(" 1100");
        }

        // Doors property
        public int Doors { get; set; }
    }
}
