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
using System.Windows.Forms.DataVisualization.Charting;

namespace NCSAllHarvester
{
    public partial class Form1 : Form
    {
        //Things that must be known before the array can be made:
        int numAtoms = 0;
        int numNLMOs = 0;
        int numFields = 0;
        int numAngles = 0;

        List<int> angles = new List<int>();

        //[Target Atom][Tensor Component][Contribution Type][Contribution Atom][Field Strength][Angle]
        List<List<List<List<List<List<double>>>>>> datatable = new List<List<List<List<List<List<double>>>>>>();
        //[Target Atom][Iso/Aniso][Field Strength][Angle]
        List<List<List<List<double>>>> basicnmr = new List<List<List<List<double>>>>();

        string[] tensorComponents = { "Isotropic", "XX", "YX", "ZX", "XY", "YY", "ZY", "XZ", "YZ", "ZZ" };
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
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            saveFileDialog1.Filter = "CSV File | *.csv";
            saveFileDialog1.DefaultExt = "csv";

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //Do some cleaning up, just in case.
            chart1.Series.Clear();
            comboBoxTargetAtom.Items.Clear();
            comboBoxContribNLMO.Items.Clear();
            comboBoxField.Items.Clear();
            textBoxLabel.Clear();
            datatable = new List<List<List<List<List<List<double>>>>>>();

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
            var tempangles = new int[numAngles];
            for(int i = 0; i < numAngles; ++i)
            {
                tempouts[i] = tempouts[i].Substring(tempouts[i].LastIndexOf("\\") + 1, tempouts[i].LastIndexOf('_') - tempouts[i].LastIndexOf('\\') - 1);
                var nums = tempouts[i].Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                tempangles[i] = int.Parse(nums[0]) + int.Parse(nums[1]) + int.Parse(nums[2]);
            }

            Array.Sort(tempangles, tempouts);
            angles = tempangles.ToList();

            //Find out how many atoms there are
            var atoms = new List<string>();
            var fieldsuffix = fielddirs[0].Substring(fielddirs[0].LastIndexOf('\\') + 3);
            var tempdata = File.ReadAllLines(fielddirs[0] + "\\ncsall\\" + tempouts[0] + "_" + fieldsuffix + ".out");
            var chargesec = false;
            for(int i = 0; i < tempdata.Length; ++i)
            {
                if (tempdata[i].Contains("Sum of Mulliken"))
                    break;
                if (chargesec)
                {
                    atoms.Add(tempdata[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[1]);
                    comboBoxTargetAtom.Items.Add(atoms.Count + "-" + atoms[atoms.Count - 1]);
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

            //Find out how many NLMOs there are
            for(int i = 0; i < tempdata.Length; ++i)
            {
                if(tempdata[i].Contains("Natural Chemical Shielding Analysis"))
                {
                    i -= 2;
                    while(numNLMOs == 0)
                    {
                        --i;
                        if(tempdata[i][6].Equals('.'))
                        {
                            numNLMOs = int.Parse(tempdata[i].Substring(0, 6).Trim());
                        }
                    }
                    break;
                }
            }

            for(int i = 0; i < numNLMOs; ++i)
            {
                comboBoxContribNLMO.Items.Add(i + 1);
            }
            comboBoxContribNLMO.SelectedIndex = 0;
            //Prep the array (Never, EVER, do this shit again.  Christ.)
            for(int a = 0; a < numAtoms; ++a)
            {
                basicnmr.Add(new List<List<List<double>>>());
                datatable.Add(new List<List<List<List<List<double>>>>>());
                for (int b = 0; b < 10; ++b)
                {
                    datatable[a].Add(new List<List<List<List<double>>>>());
                    for (int c = 0; c < 5; ++c)
                    {
                        datatable[a][b].Add(new List<List<List<double>>>());
                        for (int d = 0; d < numNLMOs; ++d)
                        {
                            datatable[a][b][c].Add(new List<List<double>>());
                            for (int f = 0; f < numFields; ++f)
                            {
                                datatable[a][b][c][d].Add(new List<double>());
                                for(int g = 0; g < numAngles; ++g)
                                {
                                    datatable[a][b][c][d][f].Add(0.0);
                                }
                            }
                        }
                    }
                }
                for(int b = 0; b < 2; ++b)
                {
                    basicnmr[a].Add(new List<List<double>>());
                    for(int c = 0; c < numFields; c++)
                    {
                        basicnmr[a][b].Add(new List<double>());
                        for(int d = 0; d < numAngles; d++)
                        {
                            basicnmr[a][b][c].Add(0.0);
                        }
                    }
                }
            }

            for(int currF = 0; currF < numFields; ++currF)
            {
                fieldsuffix = fielddirs[currF].Substring(fielddirs[currF].LastIndexOf('\\') + 3);
                for(int currA = 0; currA < numAngles; ++currA)
                {
                    if (File.Exists(fielddirs[currF] + "\\ncsall\\" + tempouts[currA] + "_" + fieldsuffix + ".out"))
                    {
                        var data = File.ReadAllLines(fielddirs[currF] + "\\ncsall\\" + tempouts[currA] + "_" + fieldsuffix + ".out");
                        bool ncsa = false;
                        for (int line = 0; line < data.Length; ++line)
                        {
                            if (data[line].Contains("(ppm)"))
                            {
                                ++line;
                                while (data[line].Contains("Isotropic"))
                                {
                                    var sl = data[line].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                                    var currTarget = int.Parse(sl[0]) - 1;
                                    basicnmr[currTarget][0][currF][currA] = double.Parse(sl[4]);
                                    basicnmr[currTarget][1][currF][currA] = double.Parse(sl[7]);
                                    line += 5;
                                }
                            }

                            if (ncsa)
                            {
                                if (data[line].Contains("Contributions"))
                                {

                                    var sl = data[line].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                                    var currTarget = -1;
                                    var currTensor = -1;
                                    if (data[line].Contains("Isotropic"))
                                    {
                                        currTarget = int.Parse(sl[6]) - 1;
                                        currTensor = Array.IndexOf(tensorComponents, sl[2]);
                                    }
                                    else
                                    {
                                        currTarget = int.Parse(sl[3]) - 1;
                                        currTensor = Array.IndexOf(tensorComponents, sl[4].Substring(sl[4].LastIndexOf('-') + 1));
                                    }
                                    line += 3;
                                    while (!data[line].Contains("Sum"))
                                    {
                                        sl = data[line].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                                        var currContrib = int.Parse(sl[0]) - 1;
                                        var Tot = double.Parse(sl[1]);
                                        var SOP = double.Parse(sl[2]);
                                        var SOD = double.Parse(sl[3]);
                                        var AOP = double.Parse(sl[4]);
                                        var AOD = double.Parse(sl[5]);
                                        datatable[currTarget][currTensor][0][currContrib][currF][currA] = Tot;
                                        datatable[currTarget][currTensor][1][currContrib][currF][currA] = SOP;
                                        datatable[currTarget][currTensor][2][currContrib][currF][currA] = SOD;
                                        datatable[currTarget][currTensor][3][currContrib][currF][currA] = AOP;
                                        datatable[currTarget][currTensor][4][currContrib][currF][currA] = AOD;
                                        ++line;
                                    }
                                    ++line;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (data[line].Contains("Natural Chemical Shielding Analysis"))
                                {
                                    ncsa = true;
                                    line += 2;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found: " + fielddirs[currF] + "\\ncsall\\" + tempouts[currA] + "_" + fieldsuffix + ".out");
                    }
                }
            }

            MessageBox.Show("Loaded");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void buttonAddSeries_Click(object sender, EventArgs e)
        {
            var label = textBoxLabel.Text;
            if (label == String.Empty)
            {
                MessageBox.Show("ERROR: Label not defined");
                return;
            }
            if(!chart1.Series.IsUniqueName(label))
            {
                MessageBox.Show("ERROR: Label not unique");
                return;
            }
            chart1.Series.Add(label);
            chart1.Series[label].ChartType = SeriesChartType.Line;
            chart1.Series[label].MarkerStyle = MarkerStyle.Circle;
            var data = datatable[comboBoxTargetAtom.SelectedIndex][comboBoxTensorComp.SelectedIndex][comboBoxContribType.SelectedIndex][comboBoxContribNLMO.SelectedIndex][comboBoxField.SelectedIndex];
            for (int i = 0; i < numAngles; ++i)
            {
                chart1.Series[label].Points.AddXY(angles[i], data[i]);
            }
            populateTable();
        }

        private void buttonPlotNLMOs_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            for (int nlmo = 0; nlmo < numNLMOs; ++nlmo)
            {
                var data = datatable[comboBoxTargetAtom.SelectedIndex][comboBoxTensorComp.SelectedIndex][comboBoxContribType.SelectedIndex][nlmo][comboBoxField.SelectedIndex];
                if (data.Any(o => o != 0.0))
                {
                    chart1.Series.Add("NLMO-" + (nlmo + 1));
                    chart1.Series["NLMO-" + (nlmo + 1)].ChartType = SeriesChartType.Line;
                    chart1.Series["NLMO-" + (nlmo + 1)].MarkerStyle = MarkerStyle.Circle;
                    for (int i = 0; i < numAngles; ++i)
                    {
                        chart1.Series["NLMO-" + (nlmo + 1)].Points.AddXY(angles[i], data[i]);
                    }
                }
            }
            populateTable();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Right:
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
                    chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
                    break;
            }
        }

        //Taken/slightly modified from: https://stackoverflow.com/questions/10648828/see-values-of-chart-points-when-the-mouse-is-on-points
        Point? prevPosition = null;
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            toolTip1.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var label = result.Series.Name;
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            toolTip1.Show(label + " (" + prop.XValue + "," + prop.YValues[0] + ")", this.chart1,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void buttonSaveGraph_Click(object sender, EventArgs e)
        {
            if(chart1.Series.Count == 0)
            {
                MessageBox.Show("ERROR: No data in chart!");
                return;
            }
            var result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var outpath = saveFileDialog1.FileName;
            var data = "";
            data += "Angle:,";
            for (int ser = 0; ser < chart1.Series.Count; ++ser)
            {
                data += chart1.Series[ser].Name + ",";
            }
            data += "\n";
            for (int ang = 0; ang < numAngles; ++ang)
            {
                data += angles[ang] + ",";
                for (int ser = 0; ser < chart1.Series.Count; ++ser)
                {
                    data += chart1.Series[ser].Points[ang].YValues[0] + ",";
                }
                data += "\n";
            }
            File.WriteAllText(outpath, data);
            MessageBox.Show("Done!");
        }

        private void buttonPlotIso_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            for (int atom = 0; atom < numAtoms; ++atom)
            {
                var data = basicnmr[atom][0][comboBoxField.SelectedIndex];
                if (data.Any(o => o != 0.0))
                {
                    var label = comboBoxTargetAtom.Items[atom].ToString();
                    chart1.Series.Add(label);
                    chart1.Series[label].ChartType = SeriesChartType.Line;
                    chart1.Series[label].MarkerStyle = MarkerStyle.Circle;
                    for (int i = 0; i < numAngles; ++i)
                    {
                        chart1.Series[label].Points.AddXY(angles[i], data[i]);
                    }
                }
            }
            populateTable();

        }

        private void buttonAniso_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            for (int atom = 0; atom < numAtoms; ++atom)
            {
                var data = basicnmr[atom][1][comboBoxField.SelectedIndex];
                if (data.Any(o => o != 0.0))
                {
                    var label = comboBoxTargetAtom.Items[atom].ToString();
                    chart1.Series.Add(label);
                    chart1.Series[label].ChartType = SeriesChartType.Line;
                    chart1.Series[label].MarkerStyle = MarkerStyle.Circle;
                    for (int i = 0; i < numAngles; ++i)
                    {
                        chart1.Series[label].Points.AddXY(angles[i], data[i]);
                    }
                }
            }
            populateTable();
        }

        private void populateTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < chart1.Series.Count; ++i)
            {
                var min = double.MaxValue;
                var max = double.MinValue;
                for (int j = 0; j < chart1.Series[i].Points.Count; ++j)
                {
                    if (chart1.Series[i].Points[j].YValues[0] > max)
                        max = chart1.Series[i].Points[j].YValues[0];
                    if (chart1.Series[i].Points[j].YValues[0] < min)
                        min = chart1.Series[i].Points[j].YValues[0];
                }
                dataGridView1.Rows.Add(chart1.Series[i].Name, Math.Round(max - min, 4), Math.Round(min, 4), Math.Round(max, 4));
            }
        }
    }
}
