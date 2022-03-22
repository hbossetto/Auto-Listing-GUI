using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        List<Auto> autos = new List<Auto>()
        {
            new Auto("2010 Jeep Liberty", 22000),
            new Auto("2007 Ford F150 XLT", 22500),
            new Auto("2004 Cadillac DeVille", 11800),
            new Auto("2006 Saturn Ion 2", 6375),
            new Auto("1970 Chevrolet Chevelle SS", 5400),
            new Auto("2002 Honda Civic", 2900),
            new Auto("1994 Jaguar", 2330),
            new Auto("2010 Dodge Nitro SXT", 22740),
            new Auto("2000 Pontiac Firebird", -3782),
            new Auto("1999 Ford Taurus", 2120),
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayAuto();
        }
        void DisplayAuto()
        {
            descriptionLabel.Text = autos[a].Description;
            listPriceLabel.Text = autos[a].ListPrice.ToString("C");
            profitLabel.Text = autos[a].Profit.ToString("C");
            autoNumberLabel.Text = (a + 1).ToString();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            a = 0;
            DisplayAuto();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a -= 1;
                DisplayAuto();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (a < autos.Count - 1)
            {
                a += 1;
                DisplayAuto();
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            a = autos.Count - 1;
            DisplayAuto();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            autoListBox.Items.Clear();
            for (int aa = 0; aa < autos.Count(); aa++)
            {
                if (autos[aa].ListPrice <= double.Parse(searchTextBox.Text))
                {
                    a = aa;
                    autoListBox.Items.Add(autos[a].Description);
                }
            }
        }

        private void autoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string target = autoListBox.Text;
            for(int aa = 0; aa < autos.Count; aa++)
            {
                if(autos[aa].Description == target)
                {
                    a = aa;
                    DisplayAuto();
                    break;
                }
            }
        }
    }
}
