﻿namespace SpatialDBMS
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("2015年长沙市影像");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2010年长沙市影像");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("2005年长沙市影像");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("长沙市遥感影像", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("2015长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2010长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("2005长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("长沙市土地覆盖图", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("长沙市行政区矢量图");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2015长沙市建成区");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2010长沙市建成区");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("2005长沙市建成区");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("长沙市建成区", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("长沙市历年统计数据");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddShp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddGdb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScopeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCombineQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttributeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpatialQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPutInGdb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCoordinateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttributeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTopologyCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocationCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSurfaceCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axToolbarControl2 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.SuspendLayout();
            this.w.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1031, 572);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(148, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(140, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "资源列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "csimage2015";
            treeNode1.Text = "2015年长沙市影像";
            treeNode2.Name = "csimage2010";
            treeNode2.Text = "2010年长沙市影像";
            treeNode3.Name = "csimage2005";
            treeNode3.Text = "2005年长沙市影像";
            treeNode4.Name = "csimage";
            treeNode4.Text = "长沙市遥感影像";
            treeNode5.Name = "cslanduse2015";
            treeNode5.Text = "2015长沙市土地覆盖图";
            treeNode6.Name = "cslanduse2010";
            treeNode6.Text = "2010长沙市土地覆盖图";
            treeNode7.Name = "cslanduse2005";
            treeNode7.Text = "2005长沙市土地覆盖图";
            treeNode8.Name = "cslanduse";
            treeNode8.Text = "长沙市土地覆盖图";
            treeNode9.Name = "csadmin";
            treeNode9.Text = "长沙市行政区矢量图";
            treeNode10.Name = "csbuild2015";
            treeNode10.Text = "2015长沙市建成区";
            treeNode11.Name = "csbuild2010";
            treeNode11.Text = "2010长沙市建成区";
            treeNode12.Name = "csbuild2005";
            treeNode12.Text = "2005长沙市建成区";
            treeNode13.Name = "csbuild";
            treeNode13.Text = "长沙市建成区";
            treeNode14.Name = "csstasticinfo";
            treeNode14.Text = "长沙市历年统计数据";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode13,
            treeNode14});
            this.treeView2.Size = new System.Drawing.Size(134, 540);
            this.treeView2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(134, 540);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axTOCControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(140, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图层列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(3, 3);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(134, 540);
            this.axTOCControl1.TabIndex = 1;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox1);
            this.splitContainer3.Size = new System.Drawing.Size(879, 572);
            this.splitContainer3.SplitterDistance = 707;
            this.splitContainer3.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(707, 572);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(699, 546);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "地图视图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.axLicenseControl1);
            this.splitContainer4.Panel1.Controls.Add(this.axMapControl1);
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(693, 540);
            this.splitContainer4.SplitterDistance = 298;
            this.splitContainer4.TabIndex = 6;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(405, 103);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(693, 540);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(699, 546);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "其他视图";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dgvStatistic);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(693, 540);
            this.splitContainer5.SplitterDistance = 270;
            this.splitContainer5.TabIndex = 1;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowTemplate.Height = 23;
            this.dgvStatistic.Size = new System.Drawing.Size(693, 270);
            this.dgvStatistic.TabIndex = 0;
            this.dgvStatistic.Visible = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Panel2Collapsed = true;
            this.splitContainer6.Size = new System.Drawing.Size(693, 266);
            this.splitContainer6.SplitterDistance = 324;
            this.splitContainer6.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 572);
            this.textBox1.TabIndex = 0;
            // 
            // w
            // 
            this.w.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusScale,
            this.StatusCoordinate});
            this.w.Location = new System.Drawing.Point(0, 677);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(1031, 22);
            this.w.TabIndex = 7;
            this.w.Text = "                                                      ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(916, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                            ";
            // 
            // StatusScale
            // 
            this.StatusScale.Name = "StatusScale";
            this.StatusScale.Size = new System.Drawing.Size(44, 17);
            this.StatusScale.Text = "比例尺";
            // 
            // StatusCoordinate
            // 
            this.StatusCoordinate.Name = "StatusCoordinate";
            this.StatusCoordinate.Size = new System.Drawing.Size(56, 17);
            this.StatusCoordinate.Text = "当前坐标";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 677);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.axToolbarControl2);
            this.splitContainer7.Size = new System.Drawing.Size(1031, 101);
            this.splitContainer7.SplitterDistance = 69;
            this.splitContainer7.TabIndex = 2;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.axToolbarControl1);
            this.splitContainer8.Size = new System.Drawing.Size(1031, 69);
            this.splitContainer8.SplitterDistance = 33;
            this.splitContainer8.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuLogin,
            this.menuAddData,
            this.menuQuery,
            this.menuPutInGdb,
            this.menuCheck,
            this.menuStatistic,
            this.menuUserManager,
            this.menuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFile,
            this.menuSaveFile,
            this.menuSeparator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 29);
            this.menuFile.Text = "文件";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenFile.Image")));
            this.menuOpenFile.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(100, 22);
            this.menuOpenFile.Text = "打开";
            this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveFile.Image")));
            this.menuSaveFile.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(100, 22);
            this.menuSaveFile.Text = "保存";
            this.menuSaveFile.Click += new System.EventHandler(this.menuSaveFile_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(97, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(100, 22);
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(44, 29);
            this.menuLogin.Text = "登录";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuAddData
            // 
            this.menuAddData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddShp,
            this.menuAddImg,
            this.menuAddGdb});
            this.menuAddData.Name = "menuAddData";
            this.menuAddData.Size = new System.Drawing.Size(44, 29);
            this.menuAddData.Text = "导入";
            this.menuAddData.Visible = false;
            // 
            // menuAddShp
            // 
            this.menuAddShp.Name = "menuAddShp";
            this.menuAddShp.Size = new System.Drawing.Size(148, 22);
            this.menuAddShp.Text = "导入shp数据";
            this.menuAddShp.Click += new System.EventHandler(this.menuAddShp_Click);
            // 
            // menuAddImg
            // 
            this.menuAddImg.Name = "menuAddImg";
            this.menuAddImg.Size = new System.Drawing.Size(148, 22);
            this.menuAddImg.Text = "导入影像数据";
            this.menuAddImg.Click += new System.EventHandler(this.menuAddImg_Click);
            // 
            // menuAddGdb
            // 
            this.menuAddGdb.Name = "menuAddGdb";
            this.menuAddGdb.Size = new System.Drawing.Size(148, 22);
            this.menuAddGdb.Text = "导入gdb数据";
            this.menuAddGdb.Click += new System.EventHandler(this.menuAddGdb_Click);
            // 
            // menuQuery
            // 
            this.menuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimeQuery,
            this.menuScopeQuery,
            this.menuCombineQuery,
            this.menuAttributeQuery,
            this.menuSpatialQuery});
            this.menuQuery.Name = "menuQuery";
            this.menuQuery.Size = new System.Drawing.Size(44, 29);
            this.menuQuery.Text = "查询";
            this.menuQuery.Visible = false;
            // 
            // menuTimeQuery
            // 
            this.menuTimeQuery.Name = "menuTimeQuery";
            this.menuTimeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuTimeQuery.Text = "时间查询";
            this.menuTimeQuery.Click += new System.EventHandler(this.menuTimeQuery_Click);
            // 
            // menuScopeQuery
            // 
            this.menuScopeQuery.Name = "menuScopeQuery";
            this.menuScopeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuScopeQuery.Text = "图幅查询";
            this.menuScopeQuery.Click += new System.EventHandler(this.menuScopeQuery_Click);
            // 
            // menuCombineQuery
            // 
            this.menuCombineQuery.Name = "menuCombineQuery";
            this.menuCombineQuery.Size = new System.Drawing.Size(124, 22);
            this.menuCombineQuery.Text = "联合查询";
            this.menuCombineQuery.Click += new System.EventHandler(this.menuCombineQuery_Click);
            // 
            // menuAttributeQuery
            // 
            this.menuAttributeQuery.Name = "menuAttributeQuery";
            this.menuAttributeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuAttributeQuery.Text = "属性查询";
            this.menuAttributeQuery.Click += new System.EventHandler(this.menuAttributeQuery_Click);
            // 
            // menuSpatialQuery
            // 
            this.menuSpatialQuery.Name = "menuSpatialQuery";
            this.menuSpatialQuery.Size = new System.Drawing.Size(124, 22);
            this.menuSpatialQuery.Text = "空间查询";
            this.menuSpatialQuery.Click += new System.EventHandler(this.menuSpatialQuery_Click);
            // 
            // menuPutInGdb
            // 
            this.menuPutInGdb.Name = "menuPutInGdb";
            this.menuPutInGdb.Size = new System.Drawing.Size(44, 29);
            this.menuPutInGdb.Text = "入库";
            this.menuPutInGdb.Visible = false;
            this.menuPutInGdb.Click += new System.EventHandler(this.menuPutInGdb_Click);
            // 
            // menuCheck
            // 
            this.menuCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimeCheck,
            this.menuCoordinateCheck,
            this.menuAttributeCheck,
            this.menuTopologyCheck,
            this.menuLocationCheck,
            this.menuSurfaceCheck});
            this.menuCheck.Name = "menuCheck";
            this.menuCheck.Size = new System.Drawing.Size(68, 29);
            this.menuCheck.Text = "质量控制";
            this.menuCheck.Visible = false;
            // 
            // menuTimeCheck
            // 
            this.menuTimeCheck.Name = "menuTimeCheck";
            this.menuTimeCheck.Size = new System.Drawing.Size(160, 22);
            this.menuTimeCheck.Text = "现势性检查";
            this.menuTimeCheck.Click += new System.EventHandler(this.menuTimeCheck_Click);
            // 
            // menuCoordinateCheck
            // 
            this.menuCoordinateCheck.Name = "menuCoordinateCheck";
            this.menuCoordinateCheck.Size = new System.Drawing.Size(160, 22);
            this.menuCoordinateCheck.Text = "坐标检查";
            // 
            // menuAttributeCheck
            // 
            this.menuAttributeCheck.Name = "menuAttributeCheck";
            this.menuAttributeCheck.Size = new System.Drawing.Size(160, 22);
            this.menuAttributeCheck.Text = "属性检查";
            // 
            // menuTopologyCheck
            // 
            this.menuTopologyCheck.Name = "menuTopologyCheck";
            this.menuTopologyCheck.Size = new System.Drawing.Size(160, 22);
            this.menuTopologyCheck.Text = "拓扑一致性检查";
            // 
            // menuLocationCheck
            // 
            this.menuLocationCheck.Name = "menuLocationCheck";
            this.menuLocationCheck.Size = new System.Drawing.Size(160, 22);
            this.menuLocationCheck.Text = "位置精度检查";
            // 
            // menuSurfaceCheck
            // 
            this.menuSurfaceCheck.Name = "menuSurfaceCheck";
            this.menuSurfaceCheck.Size = new System.Drawing.Size(160, 22);
            this.menuSurfaceCheck.Text = "表征精度检查";
            // 
            // menuStatistic
            // 
            this.menuStatistic.Name = "menuStatistic";
            this.menuStatistic.Size = new System.Drawing.Size(44, 29);
            this.menuStatistic.Text = "统计";
            this.menuStatistic.Visible = false;
            // 
            // menuUserManager
            // 
            this.menuUserManager.Name = "menuUserManager";
            this.menuUserManager.Size = new System.Drawing.Size(68, 29);
            this.menuUserManager.Text = "用户管理";
            this.menuUserManager.Visible = false;
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(44, 29);
            this.menuLogout.Text = "登出";
            this.menuLogout.Visible = false;
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1031, 28);
            this.axToolbarControl1.TabIndex = 1;
            // 
            // axToolbarControl2
            // 
            this.axToolbarControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl2.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl2.Name = "axToolbarControl2";
            this.axToolbarControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl2.OcxState")));
            this.axToolbarControl2.Size = new System.Drawing.Size(1031, 28);
            this.axToolbarControl2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 699);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.w);
            this.Name = "MainForm";
            this.Text = "SpatialDBMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.w.ResumeLayout(false);
            this.w.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip w;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusScale;
        private System.Windows.Forms.ToolStripStatusLabel StatusCoordinate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuAddData;
        private System.Windows.Forms.ToolStripMenuItem menuAddShp;
        private System.Windows.Forms.ToolStripMenuItem menuAddImg;
        private System.Windows.Forms.ToolStripMenuItem menuAddGdb;
        private System.Windows.Forms.ToolStripMenuItem menuQuery;
        private System.Windows.Forms.ToolStripMenuItem menuTimeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuScopeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuCombineQuery;
        private System.Windows.Forms.ToolStripMenuItem menuAttributeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuSpatialQuery;
        private System.Windows.Forms.ToolStripMenuItem menuPutInGdb;
        private System.Windows.Forms.ToolStripMenuItem menuCheck;
        private System.Windows.Forms.ToolStripMenuItem menuTimeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuCoordinateCheck;
        private System.Windows.Forms.ToolStripMenuItem menuAttributeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuTopologyCheck;
        private System.Windows.Forms.ToolStripMenuItem menuLocationCheck;
        private System.Windows.Forms.ToolStripMenuItem menuSurfaceCheck;
        private System.Windows.Forms.ToolStripMenuItem menuStatistic;
        private System.Windows.Forms.ToolStripMenuItem menuUserManager;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl2;
    }
}

