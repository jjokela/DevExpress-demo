namespace FirstDXDemo
{
    partial class ReportForm
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            this.courseDemoDataSet = new FirstDXDemo.CourseDemoDataSet();
            this.courseDemoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.courseDemoTableAdapter1 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoDataSet1 = new FirstDXDemo.CourseDemoDataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoDataSet2 = new FirstDXDemo.CourseDemoDataSet();
            this.courseDemoTableAdapter2 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoDataSet3 = new FirstDXDemo.CourseDemoDataSet();
            this.courseDemoTableAdapter3 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoDataSet5 = new FirstDXDemo.CourseDemoDataSet();
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoDataSet4 = new FirstDXDemo.CourseDemoDataSet();
            this.courseDemoTableAdapter4 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            this.bindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDemoTableAdapter5 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDemoDataSet
            // 
            this.courseDemoDataSet.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDemoDataSetBindingSource
            // 
            this.courseDemoDataSetBindingSource.DataSource = this.courseDemoDataSet;
            this.courseDemoDataSetBindingSource.Position = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartControl1.DataAdapter = this.courseDemoTableAdapter1;
            this.chartControl1.DataSource = this.bindingSource8;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Status";
            series1.ArgumentDataMember = "Status";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.Name = "Series 1";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Status";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Id";
            pieSeriesView2.RuntimeExploding = false;
            pieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            this.chartControl1.SeriesTemplate.View = pieSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(900, 565);
            this.chartControl1.TabIndex = 0;
            // 
            // courseDemoTableAdapter1
            // 
            this.courseDemoTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "CourseDemo";
            this.bindingSource1.DataSource = this.courseDemoDataSet1;
            this.bindingSource1.Sort = "";
            // 
            // courseDemoDataSet1
            // 
            this.courseDemoDataSet1.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "CourseDemo";
            this.bindingSource2.DataSource = this.courseDemoDataSet2;
            this.bindingSource2.Sort = "";
            // 
            // courseDemoDataSet2
            // 
            this.courseDemoDataSet2.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDemoTableAdapter2
            // 
            this.courseDemoTableAdapter2.ClearBeforeFill = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "CourseDemo";
            this.bindingSource3.DataSource = this.courseDemoDataSet3;
            this.bindingSource3.Sort = "";
            // 
            // courseDemoDataSet3
            // 
            this.courseDemoDataSet3.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDemoTableAdapter3
            // 
            this.courseDemoTableAdapter3.ClearBeforeFill = true;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Courses";
            this.bindingSource4.Sort = "";
            // 
            // bindingSource8
            // 
            this.bindingSource8.DataMember = "CourseDemo";
            this.bindingSource8.DataSource = this.courseDemoDataSet5;
            this.bindingSource8.Position = 0;
            this.bindingSource8.Sort = "";
            // 
            // courseDemoDataSet5
            // 
            this.courseDemoDataSet5.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource5
            // 
            this.bindingSource5.DataMember = "Courses";
            this.bindingSource5.Sort = "";
            // 
            // bindingSource6
            // 
            this.bindingSource6.DataMember = "CourseDemo";
            this.bindingSource6.DataSource = this.courseDemoDataSet4;
            this.bindingSource6.Sort = "";
            // 
            // courseDemoDataSet4
            // 
            this.courseDemoDataSet4.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDemoTableAdapter4
            // 
            this.courseDemoTableAdapter4.ClearBeforeFill = true;
            // 
            // courseDemoTableAdapter5
            // 
            this.courseDemoTableAdapter5.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 565);
            this.Controls.Add(this.chartControl1);
            this.Name = "ReportForm";
            this.Text = "Dummy Report";
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource courseDemoDataSetBindingSource;
        private CourseDemoDataSet courseDemoDataSet;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseDemoDataSet courseDemoDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private CourseDemoDataSet courseDemoDataSet2;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private CourseDemoDataSet courseDemoDataSet3;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource8;
        private CourseDemoDataSet courseDemoDataSet5;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.BindingSource bindingSource6;
        private CourseDemoDataSet courseDemoDataSet4;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter4;
        private System.Windows.Forms.BindingSource bindingSource7;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter5;
    }
}