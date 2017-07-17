namespace NCSAllHarvester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxDataDir = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTargetAtom = new System.Windows.Forms.ComboBox();
            this.comboBoxTensorComp = new System.Windows.Forms.ComboBox();
            this.comboBoxContribType = new System.Windows.Forms.ComboBox();
            this.comboBoxContribNLMO = new System.Windows.Forms.ComboBox();
            this.comboBoxField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddSeries = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonPlotNLMOs = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPlotAllIso = new System.Windows.Forms.Button();
            this.buttonAllAniso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPlotFieldIso = new System.Windows.Forms.Button();
            this.ColumnAtom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClipboardGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDataDir
            // 
            this.textBoxDataDir.Location = new System.Drawing.Point(76, 12);
            this.textBoxDataDir.Name = "textBoxDataDir";
            this.textBoxDataDir.Size = new System.Drawing.Size(599, 20);
            this.textBoxDataDir.TabIndex = 0;
            this.textBoxDataDir.Text = "G:\\Gaussian\\F-NMR\\MonteCarlo\\wb97xStudies\\4FTol-Water\\X";
            this.textBoxDataDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDataDir_KeyPress);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(76, 38);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Path:";
            // 
            // comboBoxTargetAtom
            // 
            this.comboBoxTargetAtom.FormattingEnabled = true;
            this.comboBoxTargetAtom.Location = new System.Drawing.Point(15, 135);
            this.comboBoxTargetAtom.Name = "comboBoxTargetAtom";
            this.comboBoxTargetAtom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTargetAtom.TabIndex = 4;
            // 
            // comboBoxTensorComp
            // 
            this.comboBoxTensorComp.FormattingEnabled = true;
            this.comboBoxTensorComp.Location = new System.Drawing.Point(142, 135);
            this.comboBoxTensorComp.Name = "comboBoxTensorComp";
            this.comboBoxTensorComp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTensorComp.TabIndex = 5;
            // 
            // comboBoxContribType
            // 
            this.comboBoxContribType.FormattingEnabled = true;
            this.comboBoxContribType.Location = new System.Drawing.Point(269, 135);
            this.comboBoxContribType.Name = "comboBoxContribType";
            this.comboBoxContribType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContribType.TabIndex = 6;
            // 
            // comboBoxContribNLMO
            // 
            this.comboBoxContribNLMO.FormattingEnabled = true;
            this.comboBoxContribNLMO.Location = new System.Drawing.Point(396, 135);
            this.comboBoxContribNLMO.Name = "comboBoxContribNLMO";
            this.comboBoxContribNLMO.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContribNLMO.TabIndex = 7;
            // 
            // comboBoxField
            // 
            this.comboBoxField.FormattingEnabled = true;
            this.comboBoxField.Location = new System.Drawing.Point(523, 135);
            this.comboBoxField.Name = "comboBoxField";
            this.comboBoxField.Size = new System.Drawing.Size(121, 21);
            this.comboBoxField.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Target Atom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tensor Comp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contribution Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Field Strength:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contributing NLMO:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(650, 135);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLabel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chart Label:";
            // 
            // buttonAddSeries
            // 
            this.buttonAddSeries.Location = new System.Drawing.Point(756, 133);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSeries.TabIndex = 16;
            this.buttonAddSeries.Text = "Add Series";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            this.buttonAddSeries.Click += new System.EventHandler(this.buttonAddSeries_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 220);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear Graph";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(616, 220);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGraph.TabIndex = 18;
            this.buttonSaveGraph.Text = "Save Graph";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // buttonPlotNLMOs
            // 
            this.buttonPlotNLMOs.Location = new System.Drawing.Point(418, 162);
            this.buttonPlotNLMOs.Name = "buttonPlotNLMOs";
            this.buttonPlotNLMOs.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotNLMOs.TabIndex = 19;
            this.buttonPlotNLMOs.Text = "Plot NLMOs";
            this.buttonPlotNLMOs.UseVisualStyleBackColor = true;
            this.buttonPlotNLMOs.Click += new System.EventHandler(this.buttonPlotNLMOs_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 249);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(679, 366);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // buttonPlotAllIso
            // 
            this.buttonPlotAllIso.Location = new System.Drawing.Point(140, 220);
            this.buttonPlotAllIso.Name = "buttonPlotAllIso";
            this.buttonPlotAllIso.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotAllIso.TabIndex = 21;
            this.buttonPlotAllIso.Text = "Plot All Iso";
            this.buttonPlotAllIso.UseVisualStyleBackColor = true;
            this.buttonPlotAllIso.Click += new System.EventHandler(this.buttonPlotIso_Click);
            // 
            // buttonAllAniso
            // 
            this.buttonAllAniso.Location = new System.Drawing.Point(221, 220);
            this.buttonAllAniso.Name = "buttonAllAniso";
            this.buttonAllAniso.Size = new System.Drawing.Size(75, 23);
            this.buttonAllAniso.TabIndex = 22;
            this.buttonAllAniso.Text = "Plot All Ani";
            this.buttonAllAniso.UseVisualStyleBackColor = true;
            this.buttonAllAniso.Click += new System.EventHandler(this.buttonAniso_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAtom,
            this.ColumnRange,
            this.ColumnMin,
            this.ColumnMax});
            this.dataGridView1.Location = new System.Drawing.Point(697, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(193, 366);
            this.dataGridView1.TabIndex = 23;
            // 
            // buttonPlotFieldIso
            // 
            this.buttonPlotFieldIso.Location = new System.Drawing.Point(302, 220);
            this.buttonPlotFieldIso.Name = "buttonPlotFieldIso";
            this.buttonPlotFieldIso.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotFieldIso.TabIndex = 24;
            this.buttonPlotFieldIso.Text = "Plot Field Iso";
            this.buttonPlotFieldIso.UseVisualStyleBackColor = true;
            this.buttonPlotFieldIso.Click += new System.EventHandler(this.buttonPlotFieldIso_Click);
            // 
            // ColumnAtom
            // 
            this.ColumnAtom.HeaderText = "Label";
            this.ColumnAtom.Name = "ColumnAtom";
            this.ColumnAtom.Width = 50;
            // 
            // ColumnRange
            // 
            this.ColumnRange.HeaderText = "Range";
            this.ColumnRange.Name = "ColumnRange";
            // 
            // ColumnMin
            // 
            this.ColumnMin.HeaderText = "Min";
            this.ColumnMin.Name = "ColumnMin";
            // 
            // ColumnMax
            // 
            this.ColumnMax.HeaderText = "Max";
            this.ColumnMax.Name = "ColumnMax";
            // 
            // buttonClipboardGraph
            // 
            this.buttonClipboardGraph.Location = new System.Drawing.Point(616, 191);
            this.buttonClipboardGraph.Name = "buttonClipboardGraph";
            this.buttonClipboardGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonClipboardGraph.TabIndex = 25;
            this.buttonClipboardGraph.Text = "Clipboard";
            this.buttonClipboardGraph.UseVisualStyleBackColor = true;
            this.buttonClipboardGraph.Click += new System.EventHandler(this.buttonClipboardGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 627);
            this.Controls.Add(this.buttonClipboardGraph);
            this.Controls.Add(this.buttonPlotFieldIso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAllAniso);
            this.Controls.Add(this.buttonPlotAllIso);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPlotNLMOs);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddSeries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxField);
            this.Controls.Add(this.comboBoxContribNLMO);
            this.Controls.Add(this.comboBoxContribType);
            this.Controls.Add(this.comboBoxTensorComp);
            this.Controls.Add(this.comboBoxTargetAtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxDataDir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDataDir;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTargetAtom;
        private System.Windows.Forms.ComboBox comboBoxTensorComp;
        private System.Windows.Forms.ComboBox comboBoxContribType;
        private System.Windows.Forms.ComboBox comboBoxContribNLMO;
        private System.Windows.Forms.ComboBox comboBoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddSeries;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonPlotNLMOs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonPlotAllIso;
        private System.Windows.Forms.Button buttonAllAniso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPlotFieldIso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMax;
        private System.Windows.Forms.Button buttonClipboardGraph;
    }
}

