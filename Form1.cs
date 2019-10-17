//**************************************************************
//Programmer : Asim Subedi
//Programming in Visual Studio 2019 
//Date : 16/09/2019
//Software : Microsoft Visual Studio 2019 Community Edition
//Platform : Microsoft Windows 10 Professional 64-bit
//Purpose : Creates window form application on a 1D array
//**************************************************************



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparator
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

       

        class Student : IComparable  //Creating Student class using Icomparable 
        {
            public string name { get; set; }        
            public int id { get; set; }
            public string address { get; set; }
            public decimal fee { get; set; }

            public int CompareTo(object obj)                                       
            {
                Student students = obj as Student;
                return this.id.CompareTo(students.id);                             //Comparing the id atributte.
            }

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string[] displayvalue = new string[4];               //creating an array to store the value
            displayvalue[0] = "Asim";
            displayvalue[1] = Convert.ToString(1);
            displayvalue[2] = "Fisher";
            displayvalue[3] = Convert.ToString(100.5);


            txtname.Text = displayvalue[0];          //displaying the values into the right text box
            txtid.Text = displayvalue[1];
            txtaddress.Text = displayvalue[2];
            txtfee.Text = displayvalue[3];

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
