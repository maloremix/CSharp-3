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
        ozh Ozh = new ozh();
        abstract class PrecStone
        {
            public double Weight { get; set; }
            public double Price { get; set; }
        }

        class Diamond : PrecStone
        {
            public Diamond()
            {
                Weight = 22;
                Price = 100;
            }

        }
        class Ruby : PrecStone
        {
            public Ruby()
            {
                Weight = 48;
                Price = 200;
            }

        }
        class Pal : PrecStone
        {
            public Pal()
            {
                Weight = 96;
                Price = 400;
            }

        }
        class ozh
        {
            List<PrecStone> list = new List<PrecStone>();
            public void addDiamond(Diamond diam)
            {
                list.Add(diam);
            }
            public void addRuby(Ruby ruby)
            {
                list.Add(ruby);
            }
            public void addPal(Pal pal)
            {
                list.Add(pal);
            }
            public double SumCost()
            {
                double sum = 0;
                foreach (PrecStone l in list)
                {
                    sum += l.Price;
                }
                return sum;
            }
            public double SumWeight()
            {
                double sumWeight = 0;
                foreach (PrecStone l in list)
                {
                    sumWeight += l.Weight;
                }
                return sumWeight;
            }
            public string printOzhCost()
            {
                string s = "";
                foreach (PrecStone l in list)
                {
                    s += l.Price;
                    s += "\n";
                }
                return s;
            }
            public void ozhSort()
            {
                list.Sort(new StoneComparer());
            }
        }
        class StoneComparer : IComparer<PrecStone>
        {
            public int Compare(PrecStone p1, PrecStone p2)
            {
                if (p1.Price > p2.Price)
                    return 1;
                else if (p1.Price < p2.Price)
                    return -1;
                else
                    return 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ozh.addDiamond(new Diamond());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ozh.addRuby(new Ruby());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ozh.addPal(new Pal());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ozh.SumWeight().ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ozh.SumCost().ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ozh.printOzhCost());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ozh.ozhSort();
            MessageBox.Show("Сортировка произведена");
        }
    }
}
