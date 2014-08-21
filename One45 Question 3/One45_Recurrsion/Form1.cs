using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace One45_Recurrsion
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private string GetTabs(int t)
        {
            string tString = "";
            for (int i = 0; i < t; i++)
                tString += "   ";
            return tString;
        }

        private void PrintArray(string[] arr, int level)
        {
            int maxSize = arr.Length-1;
            string tab = GetTabs(level);
            lbRecur.Items.Add(tab + "<" + arr[level] + ">");
            if (level < maxSize)
            {
                PrintArray(arr, ++level);
                lbRecur.Items.Add(tab + "</" + arr[level] + ">");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] theArray = { "a", "b", "c", "d", "e", "f" };
            PrintArray(theArray, 0);
        }
    }
}
