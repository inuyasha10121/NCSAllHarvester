namespace NCSAllHarvester
{
    partial class StretchForm
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
            this.checkBoxClipboardIgnoreX = new System.Windows.Forms.CheckBox();
            this.ColumnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAllAniso = new System.Windows.Forms.Button();
            this.buttonPlotAllIso = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlotNLMOs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonClipboardGraph = new System.Windows.Forms.Button();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddSeries = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxContribNLMO = new System.Windows.Forms.ComboBox();
            this.comboBoxContribType = new System.Windows.Forms.ComboBox();
            this.comboBoxTensorComp = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetAtom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxDataDir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxClipboardIgnoreX
            // 
            this.checkBoxClipboardIgnoreX.AutoSize = true;
            this.checkBoxClipboardIgnoreX.Location = new System.Drawing.Point(928, 236);
            this.checkBoxClipboardIgnoreX.Name = "checkBoxClipboardIgnoreX";
            this.checkBoxClipboardIgnoreX.Size = new System.Drawing.Size(83, 21);
            this.checkBoxClipboardIgnoreX.TabIndex = 53;
            this.checkBoxClipboardIgnoreX.Text = "Ignore X";
            this.checkBoxClipboardIgnoreX.UseVisualStyleBackColor = true;
            // 
            // ColumnMax
            // 
            this.ColumnMax.HeaderText = "Max";
            this.ColumnMax.Name = "ColumnMax";
            // 
            // ColumnMin
            // 
            this.ColumnMin.HeaderText = "Min";
            this.ColumnMin.Name = "ColumnMin";
            // 
            // ColumnRange
            // 
            this.ColumnRange.HeaderText = "Range";
            this.ColumnRange.Name = "ColumnRange";
            // 
            // ColumnAtom
            // 
            this.ColumnAtom.HeaderText = "Label";
            this.ColumnAtom.Name = "ColumnAtom";
            this.ColumnAtom.Width = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAtom,
            this.ColumnRange,
            this.ColumnMin,
            this.ColumnMax});
            this.dataGridView1.Location = new System.Drawing.Point(929, 307);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 450);
            this.dataGridView1.TabIndex = 50;
            // 
            // buttonAllAniso
            // 
            this.buttonAllAniso.Location = new System.Drawing.Point(295, 272);
            this.buttonAllAniso.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllAniso.Name = "buttonAllAniso";
            this.buttonAllAniso.Size = new System.Drawing.Size(100, 28);
            this.buttonAllAniso.TabIndex = 49;
            this.buttonAllAniso.Text = "Plot All Ani";
            this.buttonAllAniso.UseVisualStyleBackColor = true;
            this.buttonAllAniso.Click += new System.EventHandler(this.buttonAllAniso_Click);
            // 
            // buttonPlotAllIso
            // 
            this.buttonPlotAllIso.Location = new System.Drawing.Point(187, 272);
            this.buttonPlotAllIso.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlotAllIso.Name = "buttonPlotAllIso";
            this.buttonPlotAllIso.Size = new System.Drawing.Size(100, 28);
            this.buttonPlotAllIso.TabIndex = 48;
            this.buttonPlotAllIso.Text = "Plot All Iso";
            this.buttonPlotAllIso.UseVisualStyleBackColor = true;
            this.buttonPlotAllIso.Click += new System.EventHandler(this.buttonPlotAllIso_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 307);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(905, 450);
            this.chart1.TabIndex = 47;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // buttonPlotNLMOs
            // 
            this.buttonPlotNLMOs.Location = new System.Drawing.Point(557, 200);
            this.buttonPlotNLMOs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlotNLMOs.Name = "buttonPlotNLMOs";
            this.buttonPlotNLMOs.Size = new System.Drawing.Size(100, 28);
            this.buttonPlotNLMOs.TabIndex = 46;
            this.buttonPlotNLMOs.Text = "Plot NLMOs";
            this.buttonPlotNLMOs.UseVisualStyleBackColor = true;
            // 
            // buttonClipboardGraph
            // 
            this.buttonClipboardGraph.Location = new System.Drawing.Point(821, 236);
            this.buttonClipboardGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClipboardGraph.Name = "buttonClipboardGraph";
            this.buttonClipboardGraph.Size = new System.Drawing.Size(100, 28);
            this.buttonClipboardGraph.TabIndex = 52;
            this.buttonClipboardGraph.Text = "Clipboard";
            this.buttonClipboardGraph.UseVisualStyleBackColor = true;
            this.buttonClipboardGraph.Click += new System.EventHandler(this.buttonClipboardGraph_Click);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(821, 272);
            this.buttonSaveGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveGraph.TabIndex = 45;
            this.buttonSaveGraph.Text = "Save Graph";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(20, 272);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 44;
            this.buttonClear.Text = "Clear Graph";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddSeries
            // 
            this.buttonAddSeries.Location = new System.Drawing.Point(836, 161);
            this.buttonAddSeries.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(100, 28);
            this.buttonAddSeries.TabIndex = 43;
            this.buttonAddSeries.Text = "Add Series";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            this.buttonAddSeries.Click += new System.EventHandler(this.buttonAddSeries_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Chart Label:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(696, 167);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(132, 22);
            this.textBoxLabel.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Contributing NLMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Contribution Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tensor Comp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Target Atom:";
            // 
            // comboBoxContribNLMO
            // 
            this.comboBoxContribNLMO.FormattingEnabled = true;
            this.comboBoxContribNLMO.Location = new System.Drawing.Point(528, 167);
            this.comboBoxContribNLMO.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContribNLMO.Name = "comboBoxContribNLMO";
            this.comboBoxContribNLMO.Size = new System.Drawing.Size(160, 24);
            this.comboBoxContribNLMO.TabIndex = 34;
            // 
            // comboBoxContribType
            // 
            this.comboBoxContribType.FormattingEnabled = true;
            this.comboBoxContribType.Location = new System.Drawing.Point(359, 167);
            this.comboBoxContribType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContribType.Name = "comboBoxContribType";
            this.comboBoxContribType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxContribType.TabIndex = 33;
            // 
            // comboBoxTensorComp
            // 
            this.comboBoxTensorComp.FormattingEnabled = true;
            this.comboBoxTensorComp.Location = new System.Drawing.Point(189, 167);
            this.comboBoxTensorComp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTensorComp.Name = "comboBoxTensorComp";
            this.comboBoxTensorComp.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTensorComp.TabIndex = 32;
            // 
            // comboBoxTargetAtom
            // 
            this.comboBoxTargetAtom.FormattingEnabled = true;
            this.comboBoxTargetAtom.Location = new System.Drawing.Point(20, 167);
            this.comboBoxTargetAtom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTargetAtom.Name = "comboBoxTargetAtom";
            this.comboBoxTargetAtom.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTargetAtom.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data Path:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(101, 48);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 29;
            this.buttonLoad.Text = "Load Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxDataDir
            // 
            this.textBoxDataDir.Location = new System.Drawing.Point(101, 16);
            this.textBoxDataDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDataDir.Name = "textBoxDataDir";
            this.textBoxDataDir.Size = new System.Drawing.Size(797, 22);
            this.textBoxDataDir.TabIndex = 28;
            this.textBoxDataDir.Text = "G:\\Gaussian\\MOStretch\\NMIP-ADRestrict\\2F\\Pi-Anion";
            this.textBoxDataDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDataDir_KeyPress);
            // 
            // StretchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 772);
            this.Controls.Add(this.checkBoxClipboardIgnoreX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAllAniso);
            this.Controls.Add(this.buttonPlotAllIso);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPlotNLMOs);
            this.Controls.Add(this.buttonClipboardGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddSeries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxContribNLMO);
            this.Controls.Add(this.comboBoxContribType);
            this.Controls.Add(this.comboBoxTensorComp);
            this.Controls.Add(this.comboBoxTargetAtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxDataDir);
            this.Name = "StretchForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClipboardIgnoreX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAllAniso;
        private System.Windows.Forms.Button buttonPlotAllIso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonPlotNLMOs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonClipboardGraph;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddSeries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxContribNLMO;
        private System.Windows.Forms.ComboBox comboBoxContribType;
        private System.Windows.Forms.ComboBox comboBoxTensorComp;
        private System.Windows.Forms.ComboBox comboBoxTargetAtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxDataDir;
    }
}