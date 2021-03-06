﻿namespace VivoosVR
{
    partial class New_Session_Controls_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Session_Controls_Page));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.commands_datagrid = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPresentationName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSUD = new System.Windows.Forms.TextBox();
            this.btnSUDSave = new System.Windows.Forms.Button();
            this.txtPresentationName = new System.Windows.Forms.TextBox();
            this.btnPresentationSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commands_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VivoosVR.Properties.Resources.logo2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.chart2, "chart2");
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "GSR";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart2.Series.Add(series1);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.chart2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.commands_datagrid, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // commands_datagrid
            // 
            this.commands_datagrid.AllowUserToAddRows = false;
            this.commands_datagrid.AllowUserToDeleteRows = false;
            this.commands_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commands_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.commands_datagrid, "commands_datagrid");
            this.commands_datagrid.Name = "commands_datagrid";
            this.commands_datagrid.ReadOnly = true;
            this.commands_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commands_datagrid_CellContentClick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.chart1, "chart1");
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Pulse";
            this.chart1.Series.Add(series2);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.lblPresentationName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSUD, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSUDSave, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPresentationName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnPresentationSave, 2, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // lblPresentationName
            // 
            resources.ApplyResources(this.lblPresentationName, "lblPresentationName");
            this.lblPresentationName.Name = "lblPresentationName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtSUD
            // 
            resources.ApplyResources(this.txtSUD, "txtSUD");
            this.txtSUD.Name = "txtSUD";
            // 
            // btnSUDSave
            // 
            resources.ApplyResources(this.btnSUDSave, "btnSUDSave");
            this.btnSUDSave.Name = "btnSUDSave";
            this.btnSUDSave.UseVisualStyleBackColor = true;
            this.btnSUDSave.Click += new System.EventHandler(this.btnSUDkaydet_Click);
            // 
            // txtPresentationName
            // 
            resources.ApplyResources(this.txtPresentationName, "txtPresentationName");
            this.txtPresentationName.Name = "txtPresentationName";
            // 
            // btnPresentationSave
            // 
            resources.ApplyResources(this.btnPresentationSave, "btnPresentationSave");
            this.btnPresentationSave.Name = "btnPresentationSave";
            this.btnPresentationSave.UseVisualStyleBackColor = true;
            this.btnPresentationSave.Click += new System.EventHandler(this.btnPresentationSave_Click);
            // 
            // New_Session_Controls_Page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "New_Session_Controls_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_SessionControls_Page_FormClosing);
            this.Load += new System.EventHandler(this.new_session_controls_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commands_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView commands_datagrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSUD;
        private System.Windows.Forms.Button btnSUDSave;
        private System.Windows.Forms.Label lblPresentationName;
        private System.Windows.Forms.TextBox txtPresentationName;
        private System.Windows.Forms.Button btnPresentationSave;
    }
}