using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        enum dagenVanDeWeek
        {
            maandag,
            dinsdag,
            woensdag,
            donderdag,
            vrijdag,
            zaterdag,
            zondag
        }

        bool formLoaded = false;

        public Form1()
        {
            InitializeComponent();

            cmbDagenVanDeWeek.DataSource = Enum.GetNames(typeof(dagenVanDeWeek));
        }

        private void cmbDagenVanDeWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                string dag = cmbDagenVanDeWeek.SelectedItem.ToString();
                string text = "Het is vandaag ";

                switch (dag)
                {
                    case "maandag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "dinsdag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "woensdag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "donderdag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "vrijdag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "zaterdag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    case "zondag":
                        text += dag;
                        MessageBox.Show(text);
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLoaded = true;
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int getal = objRandom.Next(1, 11);

            while(getal < 5)
            {
                getal = objRandom.Next(1, 11);
            }

            MessageBox.Show(getal.ToString());
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int getal = 1;
            Random objRandom = new Random();

            do
            {
                getal = objRandom.Next(1, 11);
            } while (getal < 5);
            MessageBox.Show(getal.ToString());
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int tafelVan;

            if (int.TryParse(tbTafelVan.Text, out tafelVan))
            {
                if (tafelVan > 0 && tafelVan < 11)
                {
                    int product;
                    string tafel = "";
                    for (int i = 1; i < 11; i++)
                    {
                        product = i * tafelVan;

                        tafel += i + " x " + tafelVan + " = " + product + "\r\n";
                    }

                tbTafel.Text = tafel;
                }
                else
                {
                    MessageBox.Show("Getal moet tussen 0 en 10 zijn");
                }
            }
            else
            {
                MessageBox.Show("Getal moet tussen 0 en 10 zijn");
            }
        }

        private void LARS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lars was hier en blijft hier!");
        }

        private void btnStan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stan was hier en blijft hier!");
        }
    }
}
