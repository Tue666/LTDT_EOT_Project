﻿namespace EOT_LTĐT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnOpenFile = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.txbMatrix = new System.Windows.Forms.TextBox();
            this.btnDrawGraph = new DevComponents.DotNetBar.ButtonX();
            this.btnAddEdge = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbVertexFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVertexTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.btnDeleteEdge = new DevComponents.DotNetBar.ButtonX();
            this.btnChangeWeight = new DevComponents.DotNetBar.ButtonX();
            this.btnAddVertex = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteVertex = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVertex = new System.Windows.Forms.ComboBox();
            this.btnBFS = new DevComponents.DotNetBar.ButtonX();
            this.btnDFS = new DevComponents.DotNetBar.ButtonX();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.btnCheckConnect = new DevComponents.DotNetBar.ButtonX();
            this.btnHamilton = new DevComponents.DotNetBar.ButtonX();
            this.btnDFS2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(944, 49);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "Đồ thị vô hướng";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Icon = ((System.Drawing.Icon)(resources.GetObject("office2007StartButton1.Icon")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.btnOpenFile,
            this.btnExit});
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "&New";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOpenFile.ImagePaddingHorizontal = 8;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.SubItemsExpandWidth = 24;
            this.btnOpenFile.Text = "&Open File...";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.BeginGroup = true;
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.ImagePaddingHorizontal = 8;
            this.btnExit.Name = "btnExit";
            this.btnExit.SubItemsExpandWidth = 24;
            this.btnExit.Text = "&Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9});
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem8
            // 
            this.buttonItem8.ImagePaddingHorizontal = 8;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.ImagePaddingHorizontal = 8;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.ImagePaddingHorizontal = 8;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.ImagePaddingHorizontal = 8;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ForeColor = System.Drawing.Color.Red;
            this.buttonItem1.HotForeColor = System.Drawing.Color.DarkRed;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Designed by 9hT";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // txbMatrix
            // 
            this.txbMatrix.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatrix.Location = new System.Drawing.Point(24, 55);
            this.txbMatrix.Multiline = true;
            this.txbMatrix.Name = "txbMatrix";
            this.txbMatrix.ReadOnly = true;
            this.txbMatrix.Size = new System.Drawing.Size(137, 178);
            this.txbMatrix.TabIndex = 1;
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDrawGraph.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDrawGraph.Location = new System.Drawing.Point(24, 256);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(127, 23);
            this.btnDrawGraph.TabIndex = 2;
            this.btnDrawGraph.Text = "Vẽ đồ thị";
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddEdge.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddEdge.Location = new System.Drawing.Point(16, 372);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(73, 26);
            this.btnAddEdge.TabIndex = 3;
            this.btnAddEdge.Text = "Thêm cạnh";
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 1);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 1);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đỉnh đi: ";
            // 
            // txbVertexFrom
            // 
            this.txbVertexFrom.Location = new System.Drawing.Point(81, 292);
            this.txbVertexFrom.Name = "txbVertexFrom";
            this.txbVertexFrom.Size = new System.Drawing.Size(51, 20);
            this.txbVertexFrom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đỉnh đến: ";
            // 
            // txbVertexTo
            // 
            this.txbVertexTo.Location = new System.Drawing.Point(81, 319);
            this.txbVertexTo.Name = "txbVertexTo";
            this.txbVertexTo.Size = new System.Drawing.Size(51, 20);
            this.txbVertexTo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trọng số: ";
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(81, 345);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(51, 20);
            this.txbWeight.TabIndex = 7;
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteEdge.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteEdge.Location = new System.Drawing.Point(94, 372);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(61, 26);
            this.btnDeleteEdge.TabIndex = 3;
            this.btnDeleteEdge.Text = "Xóa cạnh";
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeWeight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeWeight.Location = new System.Drawing.Point(16, 401);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(73, 26);
            this.btnChangeWeight.TabIndex = 3;
            this.btnChangeWeight.Text = "Đổi trọng số";
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click);
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddVertex.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddVertex.Location = new System.Drawing.Point(16, 458);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(73, 26);
            this.btnAddVertex.TabIndex = 3;
            this.btnAddVertex.Text = "Thêm đỉnh";
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // btnDeleteVertex
            // 
            this.btnDeleteVertex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteVertex.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteVertex.Location = new System.Drawing.Point(94, 458);
            this.btnDeleteVertex.Name = "btnDeleteVertex";
            this.btnDeleteVertex.Size = new System.Drawing.Size(61, 26);
            this.btnDeleteVertex.TabIndex = 3;
            this.btnDeleteVertex.Text = "Xóa đỉnh";
            this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(21, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 1);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(21, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 1);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chọn đỉnh: ";
            // 
            // cbVertex
            // 
            this.cbVertex.FormattingEnabled = true;
            this.cbVertex.Location = new System.Drawing.Point(89, 433);
            this.cbVertex.Name = "cbVertex";
            this.cbVertex.Size = new System.Drawing.Size(57, 21);
            this.cbVertex.TabIndex = 10;
            // 
            // btnBFS
            // 
            this.btnBFS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBFS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBFS.Location = new System.Drawing.Point(16, 492);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(42, 26);
            this.btnBFS.TabIndex = 3;
            this.btnBFS.Text = "BFS";
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDFS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDFS.Location = new System.Drawing.Point(64, 492);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(43, 26);
            this.btnDFS.TabIndex = 3;
            this.btnDFS.Text = "DFS 1";
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(16, 597);
            this.txbPath.Multiline = true;
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(145, 92);
            this.txbPath.TabIndex = 11;
            // 
            // btnCheckConnect
            // 
            this.btnCheckConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckConnect.Location = new System.Drawing.Point(16, 524);
            this.btnCheckConnect.Name = "btnCheckConnect";
            this.btnCheckConnect.Size = new System.Drawing.Size(91, 26);
            this.btnCheckConnect.TabIndex = 3;
            this.btnCheckConnect.Text = "Xét liên thông";
            this.btnCheckConnect.Click += new System.EventHandler(this.btnCheckConnect_Click);
            // 
            // btnHamilton
            // 
            this.btnHamilton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHamilton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHamilton.Location = new System.Drawing.Point(16, 558);
            this.btnHamilton.Name = "btnHamilton";
            this.btnHamilton.Size = new System.Drawing.Size(116, 26);
            this.btnHamilton.TabIndex = 3;
            this.btnHamilton.Text = "Chu trình Hamilton";
            this.btnHamilton.Click += new System.EventHandler(this.btnHamilton_Click);
            // 
            // btnDFS2
            // 
            this.btnDFS2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDFS2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDFS2.Location = new System.Drawing.Point(113, 492);
            this.btnDFS2.Name = "btnDFS2";
            this.btnDFS2.Size = new System.Drawing.Size(43, 26);
            this.btnDFS2.TabIndex = 3;
            this.btnDFS2.Text = "DFS 2";
            this.btnDFS2.Click += new System.EventHandler(this.btnDFS2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 723);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.cbVertex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.txbVertexTo);
            this.Controls.Add(this.txbVertexFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDFS2);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnDeleteVertex);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.btnChangeWeight);
            this.Controls.Add(this.btnHamilton);
            this.Controls.Add(this.btnCheckConnect);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.txbMatrix);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lý thuyết đồ thị - Nhóm DOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnOpenFile;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private System.Windows.Forms.TextBox txbMatrix;
        private DevComponents.DotNetBar.ButtonX btnDrawGraph;
        private DevComponents.DotNetBar.ButtonX btnAddEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbVertexFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVertexTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbWeight;
        private DevComponents.DotNetBar.ButtonX btnDeleteEdge;
        private DevComponents.DotNetBar.ButtonX btnChangeWeight;
        private DevComponents.DotNetBar.ButtonX btnAddVertex;
        private DevComponents.DotNetBar.ButtonX btnDeleteVertex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVertex;
        private DevComponents.DotNetBar.ButtonX btnBFS;
        private DevComponents.DotNetBar.ButtonX btnDFS;
        private System.Windows.Forms.TextBox txbPath;
        private DevComponents.DotNetBar.ButtonX btnCheckConnect;
        private DevComponents.DotNetBar.ButtonX btnHamilton;
        private DevComponents.DotNetBar.ButtonX btnDFS2;
    }
}

