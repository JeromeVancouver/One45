using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Shape
        {
            public string type;
            public string length;
            public string perimeter;
            public string area;

            public Shape()
            {
            }

            public Shape(string t, string l)
            {
                type = t;
                length = l;
            }

            public string GetOutput()
            {
                string output;
                output = "A " + type + " with side length " + this.length + " u has a perimeter of " + this.perimeter +
                        " u and an area of " + this.area + " u^2";
                return output;
            }

        }

        public class Circle : Shape
        {

            public Circle(string l) 
                : base("circle", l)
            {
                double p = 2 * Math.PI * Convert.ToDouble(this.length);
                p = Math.Round(p, 2);
                perimeter = p.ToString();
                double a = Convert.ToDouble(this.length) * Convert.ToDouble(this.length) * Math.PI;
                a = Math.Round(a, 2);
                area = a.ToString();
            }

            public string GetOutput()
            {
                string output;
                output = "A circle with radius " + this.length + " u has a perimeter of " + this.perimeter +
                        " u and an area of " + this.area + " u^2";
                return output;
            }

        }

        public class Triangle : Shape
        {
            public Triangle(string l)
                : base("triangle", l)
            {
                double p = 3 * Convert.ToDouble(this.length);
                p = Math.Round(p, 2);
                perimeter = p.ToString();
                double a = (Math.Sqrt(3) / 4) * Convert.ToDouble(this.length) * Convert.ToDouble(this.length);
                a = Math.Round(a, 2);
                area = a.ToString();
            }

        }

        public class Square : Shape
        {
            public Square(string l)
                : base("square", l)
            {
                double p = 4 * Convert.ToDouble(this.length);
                p = Math.Round(p, 2);
                perimeter = p.ToString();
                double a = Convert.ToDouble(this.length) * Convert.ToDouble(this.length);
                a = Math.Round(a, 2);
                area = a.ToString();
            }

        }

        public class Pentagon : Shape
        {
            public Pentagon(string l)
                : base("pentagon", l)
            {
                double p = 5 * Convert.ToDouble(this.length);
                p = Math.Round(p, 2);
                perimeter = p.ToString();
                double sqr = 5 * (5 + 2 * Math.Sqrt(5));
                double a = (0.25) * Math.Sqrt(sqr) * ((Convert.ToDouble(this.length) * Convert.ToDouble(this.length)));
                a = Math.Round(a, 2);
                area = a.ToString();
            }

        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            tbFile.Text = "";
            lbOutput.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.csv | *.*";
            dialog.InitialDirectory = Directory.GetCurrentDirectory().ToString();
            dialog.Title = "Select CSV File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                string filename = dialog.FileName;
                tbFile.Text = filename;
                var reader = new System.IO.StreamReader(File.OpenRead(filename));
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string output = "Default";
                    if(line.Equals(""))
                    {
                        output = "No Data Found";
                    }
                    else
                    {
                        var values = line.Split(',');
                        string shape = values[0];
                        string length = values[1];
                        double n;
                        bool isNumeric = double.TryParse(length, out n);
                        if (isNumeric)
                        {
                            switch (shape)
                            {
                                case "circle":
                                    Circle c = new Circle(length);
                                    output = c.GetOutput();
                                    break;
                                case "triangle":
                                    Triangle t = new Triangle(length);
                                    output = t.GetOutput();
                                    break;
                                case "square":
                                    Square s = new Square(length);
                                    output = s.GetOutput();
                                    break;
                                case "pentagon":
                                    Pentagon p = new Pentagon(length);
                                    output = p.GetOutput();
                                    break;
                                default:
                                    // You can use the default case.
                                    output = "Shape " + shape + " is not a valid shape";
                                    break;
                            }
                        }
                        else
                            output = "Shape " + shape + " does not have a numeric value ( " +  length + " )";

                    }
                    lbOutput.Items.Add(output);
                }
            } 
        }
    }
}
