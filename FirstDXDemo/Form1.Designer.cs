namespace FirstDXDemo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.coursesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navList = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navCards = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navReport = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.courseDemoDataSet = new FirstDXDemo.CourseDemoDataSet();
            this.courseDemoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.courseDemoDataSet1 = new FirstDXDemo.CourseDemoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.courseDemoTableAdapter1 = new FirstDXDemo.CourseDemoDataSetTableAdapters.CourseDemoTableAdapter();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colDescription = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colLink = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colImageLink = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colStatus = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImageLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1114, 155);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navList,
            this.navCards,
            this.navReport});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 661);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(1114, 52);
            this.officeNavigationBar1.TabIndex = 3;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.SelectedItemChanged += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.officeNavigationBar1_SelectedItemChanged);
            // 
            // navList
            // 
            this.navList.Name = "navList";
            this.navList.Text = "List";
            // 
            // navCards
            // 
            this.navCards.Name = "navCards";
            this.navCards.Text = "Cards";
            // 
            // navReport
            // 
            this.navReport.Name = "navReport";
            this.navReport.Text = "Report";
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataMember = "CourseDemo";
            this.gridControl1.DataSource = this.courseDemoDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "CourseDemo";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 155);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1114, 506);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1});
            // 
            // courseDemoDataSet1
            // 
            this.courseDemoDataSet1.DataSetName = "CourseDemoDataSet";
            this.courseDemoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colLink,
            this.colImageLink,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colLink
            // 
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 2;
            // 
            // colImageLink
            // 
            this.colImageLink.FieldName = "ImageLink";
            this.colImageLink.Name = "colImageLink";
            this.colImageLink.Visible = true;
            this.colImageLink.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(376, 290);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.FieldName = "Id";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colId;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.FieldName = "Name";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colName;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.ColumnEdit = this.repositoryItemMemoEdit1;
            this.layoutViewColumn3.FieldName = "Description";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_colDescription;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.FieldName = "Link";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colLink;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.FieldName = "ImageLink";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_colImageLink;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.FieldName = "Status";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_colStatus;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            // 
            // courseDemoTableAdapter1
            // 
            this.courseDemoTableAdapter1.ClearBeforeFill = true;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colName,
            this.layoutViewField_colDescription,
            this.layoutViewField_colLink,
            this.layoutViewField_colImageLink,
            this.layoutViewField_colStatus});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 279;
            this.layoutViewField_colName.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Size = new System.Drawing.Size(356, 26);
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colName.TextToControlDistance = 5;
            // 
            // layoutViewField_colDescription
            // 
            this.layoutViewField_colDescription.EditorPreferredWidth = 279;
            this.layoutViewField_colDescription.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colDescription.Name = "layoutViewField_colDescription";
            this.layoutViewField_colDescription.Size = new System.Drawing.Size(356, 144);
            this.layoutViewField_colDescription.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colDescription.TextToControlDistance = 5;
            // 
            // layoutViewField_colLink
            // 
            this.layoutViewField_colLink.EditorPreferredWidth = 279;
            this.layoutViewField_colLink.Location = new System.Drawing.Point(0, 170);
            this.layoutViewField_colLink.Name = "layoutViewField_colLink";
            this.layoutViewField_colLink.Size = new System.Drawing.Size(356, 26);
            this.layoutViewField_colLink.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colLink.TextToControlDistance = 5;
            // 
            // layoutViewField_colImageLink
            // 
            this.layoutViewField_colImageLink.EditorPreferredWidth = 279;
            this.layoutViewField_colImageLink.Location = new System.Drawing.Point(0, 196);
            this.layoutViewField_colImageLink.Name = "layoutViewField_colImageLink";
            this.layoutViewField_colImageLink.Size = new System.Drawing.Size(356, 26);
            this.layoutViewField_colImageLink.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colImageLink.TextToControlDistance = 5;
            // 
            // layoutViewField_colStatus
            // 
            this.layoutViewField_colStatus.EditorPreferredWidth = 279;
            this.layoutViewField_colStatus.Location = new System.Drawing.Point(0, 222);
            this.layoutViewField_colStatus.Name = "layoutViewField_colStatus";
            this.layoutViewField_colStatus.Size = new System.Drawing.Size(356, 26);
            this.layoutViewField_colStatus.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colStatus.TextToControlDistance = 5;
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 20;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(202, 153);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(68, 16);
            this.layoutViewField_colId.TextToControlDistance = 5;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 713);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.officeNavigationBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDemoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImageLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource coursesDataSetBindingSource;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navList;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navCards;
        private CourseDemoDataSet courseDemoDataSet;
        private System.Windows.Forms.BindingSource courseDemoDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CourseDemoDataSet courseDemoDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colImageLink;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private CourseDemoDataSetTableAdapters.CourseDemoTableAdapter courseDemoTableAdapter1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navReport;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDescription;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLink;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colImageLink;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colStatus;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

