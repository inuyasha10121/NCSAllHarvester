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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTargetAtom = new System.Windows.Forms.ComboBox();
            this.comboBoxTensorComp = new System.Windows.Forms.ComboBox();
            this.comboBoxContribType = new System.Windows.Forms.ComboBox();
            this.comboBoxContribAtom = new System.Windows.Forms.ComboBox();
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
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "G:\\Gaussian\\F-NMR\\MonteCarlo\\wb97xStudies\\4FTol-Water\\X";
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
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 242);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(878, 373);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
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
            // comboBoxContribAtom
            // 
            this.comboBoxContribAtom.FormattingEnabled = true;
            this.comboBoxContribAtom.Location = new System.Drawing.Point(396, 135);
            this.comboBoxContribAtom.Name = "comboBoxContribAtom";
            this.comboBoxContribAtom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContribAtom.TabIndex = 7;
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
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contributing Atom";
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
            this.buttonAddSeries.Location = new System.Drawing.Point(15, 162);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSeries.TabIndex = 16;
            this.buttonAddSeries.Text = "Add Series";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 213);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear Graph";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(815, 213);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 18;
            this.buttonSaveToFile.Text = "Save Data";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 627);
            this.Controls.Add(this.buttonSaveToFile);
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
            this.Controls.Add(this.comboBoxContribAtom);
            this.Controls.Add(this.comboBoxContribType);
            this.Controls.Add(this.comboBoxTensorComp);
            this.Controls.Add(this.comboBoxTargetAtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTargetAtom;
        private System.Windows.Forms.ComboBox comboBoxTensorComp;
        private System.Windows.Forms.ComboBox comboBoxContribType;
        private System.Windows.Forms.ComboBox comboBoxContribAtom;
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
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

