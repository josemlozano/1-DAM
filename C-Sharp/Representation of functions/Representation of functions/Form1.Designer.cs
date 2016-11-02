namespace Representation_of_functions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btExecute = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_File_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_File_Help_Functionality = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_File_Help_Guide = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.grBox_tablevalues = new System.Windows.Forms.GroupBox();
            this.lb_tablevaluesY = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_tablevaluesX = new System.Windows.Forms.Label();
            this.chck_tablevalues = new System.Windows.Forms.CheckBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grBox_tablevalues.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(384, 426);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(75, 23);
            this.btExecute.TabIndex = 0;
            this.btExecute.Text = "Plot";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 374);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Enter function";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(15, 32);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(444, 336);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tbFunction
            // 
            this.tbFunction.Location = new System.Drawing.Point(27, 400);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(259, 20);
            this.tbFunction.TabIndex = 5;
            this.tbFunction.TextChanged += new System.EventHandler(this.tbFunction_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(26, 426);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(259, 20);
            this.tbResult.TabIndex = 2;
            this.tbResult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_File_Help,
            this.aboutToolStripMenuItem,
            this.mn_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mn_File_Help
            // 
            this.mn_File_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_File_Help_Functionality,
            this.mn_File_Help_Guide});
            this.mn_File_Help.Name = "mn_File_Help";
            this.mn_File_Help.Size = new System.Drawing.Size(107, 22);
            this.mn_File_Help.Text = "Help";
            // 
            // mn_File_Help_Functionality
            // 
            this.mn_File_Help_Functionality.Name = "mn_File_Help_Functionality";
            this.mn_File_Help_Functionality.Size = new System.Drawing.Size(160, 22);
            this.mn_File_Help_Functionality.Text = "Functionality";
            this.mn_File_Help_Functionality.Click += new System.EventHandler(this.mn_File_Help_Functionality_Click);
            // 
            // mn_File_Help_Guide
            // 
            this.mn_File_Help_Guide.Name = "mn_File_Help_Guide";
            this.mn_File_Help_Guide.Size = new System.Drawing.Size(160, 22);
            this.mn_File_Help_Guide.Text = "Operators Guide";
            this.mn_File_Help_Guide.Click += new System.EventHandler(this.mn_File_Help_Guide_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mn_File_Exit
            // 
            this.mn_File_Exit.Name = "mn_File_Exit";
            this.mn_File_Exit.Size = new System.Drawing.Size(107, 22);
            this.mn_File_Exit.Text = "Exit";
            this.mn_File_Exit.Click += new System.EventHandler(this.mn_File_Exit_Click);
            // 
            // grBox_tablevalues
            // 
            this.grBox_tablevalues.Controls.Add(this.lb_tablevaluesY);
            this.grBox_tablevalues.Controls.Add(this.listBox1);
            this.grBox_tablevalues.Controls.Add(this.lb_tablevaluesX);
            this.grBox_tablevalues.Location = new System.Drawing.Point(498, 93);
            this.grBox_tablevalues.Name = "grBox_tablevalues";
            this.grBox_tablevalues.Size = new System.Drawing.Size(101, 202);
            this.grBox_tablevalues.TabIndex = 8;
            this.grBox_tablevalues.TabStop = false;
            this.grBox_tablevalues.Visible = false;
            this.grBox_tablevalues.Enter += new System.EventHandler(this.grBox_tablevalues_Enter);
            // 
            // lb_tablevaluesY
            // 
            this.lb_tablevaluesY.AutoSize = true;
            this.lb_tablevaluesY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tablevaluesY.Location = new System.Drawing.Point(57, 16);
            this.lb_tablevaluesY.Name = "lb_tablevaluesY";
            this.lb_tablevaluesY.Size = new System.Drawing.Size(17, 17);
            this.lb_tablevaluesY.TabIndex = 1;
            this.lb_tablevaluesY.Text = "Y";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(90, 147);
            this.listBox1.TabIndex = 3;
            // 
            // lb_tablevaluesX
            // 
            this.lb_tablevaluesX.AutoSize = true;
            this.lb_tablevaluesX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tablevaluesX.Location = new System.Drawing.Point(24, 16);
            this.lb_tablevaluesX.Name = "lb_tablevaluesX";
            this.lb_tablevaluesX.Size = new System.Drawing.Size(17, 17);
            this.lb_tablevaluesX.TabIndex = 0;
            this.lb_tablevaluesX.Text = "X";
            // 
            // chck_tablevalues
            // 
            this.chck_tablevalues.AutoSize = true;
            this.chck_tablevalues.Location = new System.Drawing.Point(489, 70);
            this.chck_tablevalues.Name = "chck_tablevalues";
            this.chck_tablevalues.Size = new System.Drawing.Size(99, 17);
            this.chck_tablevalues.TabIndex = 9;
            this.chck_tablevalues.Text = "Table of values";
            this.chck_tablevalues.UseVisualStyleBackColor = true;
            this.chck_tablevalues.CheckedChanged += new System.EventHandler(this.chck_tablevalues_CheckedChanged);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(632, 335);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 11;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(519, 335);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 504);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.chck_tablevalues);
            this.Controls.Add(this.grBox_tablevalues);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Representation of Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBox_tablevalues.ResumeLayout(false);
            this.grBox_tablevalues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_File_Help;
        private System.Windows.Forms.ToolStripMenuItem mn_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem mn_File_Help_Guide;
        private System.Windows.Forms.ToolStripMenuItem mn_File_Help_Functionality;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grBox_tablevalues;
        private System.Windows.Forms.Label lb_tablevaluesX;
        private System.Windows.Forms.Label lb_tablevaluesY;
        private System.Windows.Forms.CheckBox chck_tablevalues;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListBox listBox1;
    }
}

