using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stitch_Pattern
{
    public partial class Stiches : Form
    {
        public Stiches()
        {
            InitializeComponent();
            generate();
        }

        int StitchWidth = 0;
        int StitchHeight = 0;
        int NumColours = 2;
        List<Label> AllSquares = new List<Label>();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generate();
        }
        private void generate()
        {
            StitchWidth = tbrX.Value;
            StitchHeight = tbrY.Value;
            if (StitchWidth == 0 || StitchHeight == 0)
            {
                MessageBox.Show("Not a valid stitch. X and Y values must be 1 or more.");
                return;
            }
            if (StitchWidth > 30 || StitchHeight > 30)
            {
                MessageBox.Show("Not a valid stitch. X and Y values are too large and will cause significant delays");
                return;
            }
            //clear old selection of boxes
            if (AllSquares.Count > 0)
            {
                for (int i = 0; i < AllSquares.Count();)
                {
                    AllSquares[i].Controls.Remove(AllSquares[i]);
                    AllSquares[i].Dispose();
                    AllSquares.RemoveAt(i);

                }
            }

            //Generate a Hitomezashi Stitch 
            Random Rnd = new Random();
            string HitomezashiX = Rnd.Next(0, 2).ToString();
            string HitomezashiY = Rnd.Next(0, 2).ToString();
            for (int k = 0; k < StitchWidth; k++)
            {
                HitomezashiX = HitomezashiX + Rnd.Next(0, 2).ToString();
            }
            for (int l = 0; l < StitchHeight; l++)
            {
                HitomezashiY = HitomezashiY + Rnd.Next(0, 2).ToString();
            }
            Color[] ColourList = { Color.White, Color.Red, Color.Blue, Color.Green };
            //Color SquareColour = Color.FromArgb(0, 0, 0, 0);
            int currentCol = Rnd.Next(0, 2);
            int currentCol2 = 0;
            int checkNum = 0;

            //Generate gird acroding to size of inputted by used
            for (int i = 0; i < StitchHeight; i++)
            {
                for (int j = 0; j < StitchWidth; j++)
                {
                    //SquareColour = Color.FromArgb(255, 0, 0, 0);

                    Label NewLabel = new Label();
                    Controls.Add(NewLabel);
                    NewLabel.Location = new Point(j * 15, i * 15);
                    NewLabel.Width = 15;
                    NewLabel.Height = 15;
                    NewLabel.Parent = pnlStitchDisplay;
                    AllSquares.Add(NewLabel);


                    if (j != 0)
                    {
                        if (int.Parse(HitomezashiX[j - 1].ToString()) == checkNum)
                        {
                            currentCol = (currentCol + 1) % NumColours;
                        }
                    }

                    NewLabel.BackColor = ColourList[(currentCol + currentCol2) % NumColours];

                    //SquareColour = Color.FromArgb(SquareColour.A, 255, SquareColour.B, SquareColour.G);
                    //NewLabel.BackColor = SquareColour;
                }
                currentCol = 0;
                if (int.Parse(HitomezashiY[i].ToString()) == 0)
                {
                    currentCol2 = (currentCol2 + 1) % NumColours;
                }
                checkNum = (checkNum + 1) % NumColours;
            }
        }

        private void tbrX_Scroll(object sender, EventArgs e)
        {
            lblX.Text = tbrX.Value.ToString();
        }

        private void tbrY_Scroll(object sender, EventArgs e)
        {
            lblY.Text = tbrY.Value.ToString();
        }
    }
}
