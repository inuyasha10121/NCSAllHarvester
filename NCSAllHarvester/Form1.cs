using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCSAllHarvester
{
    public partial class Form1 : Form
    {
        //Things that must be known before the array can be made:
        int numAtoms = 0;
        int numFields = 0;
        int numAngles = 0;

        //[Target Atom][Tensor Component][Contribution Type][Contribution Atom][Field Strength][Angle]
        List<List<List<List<List<List<decimal>>>>>> harvesteddata = new List<List<List<List<List<List<decimal>>>>>>(5);

        string[] tensorComponents = { "Isotropic", "XX", "YX", "ZX", "YX", "YY", "ZY", "XZ", "YZ", "ZZ" };
        string[] contributionTypes = { "Total", "SO/Para", "SO/Dia", "AO/Para", "AO/Dia" };

        public Form1()
        {
            InitializeComponent();
            foreach(var tc in  tensorComponents)
            {
                comboBoxTensorComp.Items.Add(tc);
            }
            foreach(var ct in contributionTypes)
            {
                comboBoxContribType.Items.Add(ct);
            }
            comboBoxTensorComp.SelectedIndex = 0;
            comboBoxContribType.SelectedIndex = 0;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //Do some cleaning up, just in case.
            chart1.Series.Clear();
            comboBoxTargetAtom.Items.Clear();
            comboBoxContribAtom.Items.Clear();
            textBoxLabel.Clear();

            //Get field strength directories
            var fielddirs = Directory.GetDirectories(textBoxDataDir.Text);
            numFields = fielddirs.Length;
            foreach(var fd in fielddirs)
            {
                comboBoxField.Items.Add(fd.Substring(fd.LastIndexOf("\\") + 3));
            }
            comboBoxField.SelectedIndex = 0;

            //Find out how many angles we have now
            var tempouts = Directory.GetFiles(fielddirs[0] + "\\ncsall\\", "*.out");
            numAngles = tempouts.Length;
            var angles = new int[numAngles];
            for(int i = 0; i < numAngles; ++i)
            {
                var nums = tempouts[i].Substring(tempouts[i].LastIndexOf("\\") + 1).Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                angles[i] = int.Parse(nums[0]) + int.Parse(nums[1]) + int.Parse(nums[2]);
            }

            //Find out how many atoms there are
            var atoms = new List<string>();
            var tempdata = File.ReadAllLines(tempouts[0]);
            var chargesec = false;
            for(int i = 0; i < tempdata.Length; ++i)
            {
                if (tempdata[i].Contains("Sum of Mulliken"))
                    break;
                if (chargesec)
                {
                    atoms.Add(tempdata[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[1]);
                    comboBoxTargetAtom.Items.Add(atoms.Count + "-" + atoms[atoms.Count - 1]);
                    comboBoxContribAtom.Items.Add(atoms.Count + "-" + atoms[atoms.Count - 1]);
                }
                else
                {
                    if (tempdata[i].Contains("Mulliken atomic charges:"))
                    {
                        chargesec = true;
                        ++i;
                    }
                }
            }
            numAtoms = atoms.Count;
            comboBoxTargetAtom.SelectedIndex = 0;
            comboBoxContribAtom.SelectedIndex = 0;

            //Prep the array (Never, EVER, do this shit again.  Christ.)
            for(int a = 0; a < numAtoms; ++a)
            {
                harvesteddata.Add(new List<List<List<List<List<decimal>>>>>());
                for (int b = 0; b < 10; ++b)
                {
                    harvesteddata[a].Add(new List<List<List<List<decimal>>>>());
                    for (int c = 0; c < 5; ++c)
                    {
                        harvesteddata[a][b].Add(new List<List<List<decimal>>>());
                        for (int d = 0; d < numAtoms; ++d)
                        {
                            harvesteddata[a][b][c].Add(new List<List<decimal>>());
                            for (int f = 0; f < numFields; ++f)
                            {
                                harvesteddata[a][b][c][d].Add(new List<decimal>());
                                for(int g = 0; g < numAngles; ++g)
                                {
                                    harvesteddata[a][b][c][d][f].Add(0.0m);
                                }
                            }
                        }
                    }
                }
            }



            MessageBox.Show("Loaded");
        }
    }
}
