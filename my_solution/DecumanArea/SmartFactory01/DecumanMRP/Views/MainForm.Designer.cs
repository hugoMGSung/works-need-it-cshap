
namespace DecumanMRP
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonDockableWorkspace1 = new Krypton.Docking.KryptonDockableWorkspace();
            this.KdmMain = new Krypton.Docking.KryptonDockingManager();
            this.ImgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.KmnMain = new Krypton.Toolkit.KryptonManager(this.components);
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.KrtHome = new Krypton.Ribbon.KryptonRibbonTab();
            this.KrgOperations = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnRbnNewWindow = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnRbnCloseWindow = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnRbnCloseAllWindow = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.KrgArrange = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnRbnCascade = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnRbnTileHorizontal = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnRbnTileVertical = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.KrtAppearance = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.Btn2010Blue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.Btn2010Silver = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.Btn2010Black = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.Btn2007Blue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.Btn2007Silver = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.Btn2007Black = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple6 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnSparkleBlue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnSparkleOrange = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnSparklePurple = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple7 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnSystem = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.Btn2003Normal = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple8 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnTabs = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnRibbonTabs = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnButtons = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple9 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BtnHeader = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnHeaderButtons = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnStack = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.KdwMain = new Krypton.Docking.KryptonDockableWorkspace();
            this.KrpMain = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrpMain)).BeginInit();
            this.KrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.ActivePage = null;
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "2ac85be97cd04fadbb73f3042ebb28ce";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(200, 200);
            this.kryptonDockableWorkspace1.TabIndex = 0;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // ImgListSmall
            // 
            this.ImgListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListSmall.ImageStream")));
            this.ImgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListSmall.Images.SetKeyName(0, "new.png");
            this.ImgListSmall.Images.SetKeyName(1, "system.png");
            this.ImgListSmall.Images.SetKeyName(2, "information.png");
            this.ImgListSmall.Images.SetKeyName(3, "");
            this.ImgListSmall.Images.SetKeyName(4, "input.png");
            // 
            // KmnMain
            // 
            this.KmnMain.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // OfdMain
            // 
            this.OfdMain.FileName = "FileName";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.KrtHome,
            this.KrtAppearance});
            this.kryptonRibbon1.SelectedTab = this.KrtAppearance;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1062, 135);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // KrtHome
            // 
            this.KrtHome.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.KrgOperations,
            this.KrgArrange});
            this.KrtHome.Text = "Home";
            // 
            // KrgOperations
            // 
            this.KrgOperations.DialogBoxLauncher = false;
            this.KrgOperations.Image = ((System.Drawing.Image)(resources.GetObject("KrgOperations.Image")));
            this.KrgOperations.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple2});
            this.KrgOperations.KeyTipGroup = "O";
            this.KrgOperations.TextLine1 = "Operations";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnRbnNewWindow});
            // 
            // BtnRbnNewWindow
            // 
            this.BtnRbnNewWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnNewWindow.ImageLarge")));
            this.BtnRbnNewWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnNewWindow.ImageSmall")));
            this.BtnRbnNewWindow.KeyTip = "N";
            this.BtnRbnNewWindow.TextLine1 = "New";
            this.BtnRbnNewWindow.TextLine2 = "Window";
            this.BtnRbnNewWindow.Click += new System.EventHandler(this.BtnRbnNewWindow_Click);
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnRbnCloseWindow,
            this.BtnRbnCloseAllWindow});
            // 
            // BtnRbnCloseWindow
            // 
            this.BtnRbnCloseWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnCloseWindow.ImageLarge")));
            this.BtnRbnCloseWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnCloseWindow.ImageSmall")));
            this.BtnRbnCloseWindow.KeyTip = "X";
            this.BtnRbnCloseWindow.TextLine1 = "Close";
            this.BtnRbnCloseWindow.TextLine2 = "Window";
            this.BtnRbnCloseWindow.Click += new System.EventHandler(this.BtnRbnCloseWindow_Click);
            // 
            // BtnRbnCloseAllWindow
            // 
            this.BtnRbnCloseAllWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnCloseAllWindow.ImageLarge")));
            this.BtnRbnCloseAllWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnCloseAllWindow.ImageSmall")));
            this.BtnRbnCloseAllWindow.KeyTip = "A";
            this.BtnRbnCloseAllWindow.TextLine1 = "Close All";
            this.BtnRbnCloseAllWindow.TextLine2 = "Windows";
            this.BtnRbnCloseAllWindow.Click += new System.EventHandler(this.BtnRbnCloseAllWindow_Click);
            // 
            // KrgArrange
            // 
            this.KrgArrange.DialogBoxLauncher = false;
            this.KrgArrange.Image = ((System.Drawing.Image)(resources.GetObject("KrgArrange.Image")));
            this.KrgArrange.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            this.KrgArrange.KeyTipGroup = "A";
            this.KrgArrange.TextLine1 = "Arrange";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnRbnCascade,
            this.BtnRbnTileHorizontal,
            this.BtnRbnTileVertical});
            // 
            // BtnRbnCascade
            // 
            this.BtnRbnCascade.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnCascade.ImageLarge")));
            this.BtnRbnCascade.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnCascade.ImageSmall")));
            this.BtnRbnCascade.KeyTip = "C";
            this.BtnRbnCascade.TextLine1 = "Cascade";
            this.BtnRbnCascade.Click += new System.EventHandler(this.BtnRbnCascade_Click);
            // 
            // BtnRbnTileHorizontal
            // 
            this.BtnRbnTileHorizontal.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnTileHorizontal.ImageLarge")));
            this.BtnRbnTileHorizontal.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnTileHorizontal.ImageSmall")));
            this.BtnRbnTileHorizontal.KeyTip = "H";
            this.BtnRbnTileHorizontal.TextLine1 = "Tile";
            this.BtnRbnTileHorizontal.TextLine2 = "Horizontal";
            this.BtnRbnTileHorizontal.Click += new System.EventHandler(this.BtnRbnTileHorizontal_Click);
            // 
            // BtnRbnTileVertical
            // 
            this.BtnRbnTileVertical.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnRbnTileVertical.ImageLarge")));
            this.BtnRbnTileVertical.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRbnTileVertical.ImageSmall")));
            this.BtnRbnTileVertical.KeyTip = "V";
            this.BtnRbnTileVertical.TextLine1 = "Tile";
            this.BtnRbnTileVertical.TextLine2 = "Vertical";
            this.BtnRbnTileVertical.Click += new System.EventHandler(this.BtnRbnTileVertical_Click);
            // 
            // KrtAppearance
            // 
            this.KrtAppearance.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2});
            this.KrtAppearance.Text = "Appearance";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4,
            this.kryptonRibbonGroupTriple5,
            this.kryptonRibbonGroupTriple6,
            this.kryptonRibbonGroupTriple7});
            this.kryptonRibbonGroup1.TextLine1 = "Palette";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.Btn2010Blue,
            this.Btn2010Silver,
            this.Btn2010Black});
            this.kryptonRibbonGroupTriple4.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // Btn2010Blue
            // 
            this.Btn2010Blue.Tag = "Office2010Blue";
            this.Btn2010Blue.TextLine1 = "2010 Blue";
            this.Btn2010Blue.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // Btn2010Silver
            // 
            this.Btn2010Silver.Tag = "Office2010Silver";
            this.Btn2010Silver.TextLine1 = "2010 Silver";
            this.Btn2010Silver.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // Btn2010Black
            // 
            this.Btn2010Black.Tag = "Office2010Black";
            this.Btn2010Black.TextLine1 = "2010 Black";
            this.Btn2010Black.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.Btn2007Blue,
            this.Btn2007Silver,
            this.Btn2007Black});
            this.kryptonRibbonGroupTriple5.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // Btn2007Blue
            // 
            this.Btn2007Blue.Tag = "Office2007Blue";
            this.Btn2007Blue.TextLine1 = "2007 Blue";
            this.Btn2007Blue.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // Btn2007Silver
            // 
            this.Btn2007Silver.Tag = "Office2007Silver";
            this.Btn2007Silver.TextLine1 = "2007 Silver";
            this.Btn2007Silver.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // Btn2007Black
            // 
            this.Btn2007Black.Tag = "Office2007Black";
            this.Btn2007Black.TextLine1 = "2007 Black";
            this.Btn2007Black.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnSparkleBlue,
            this.BtnSparkleOrange,
            this.BtnSparklePurple});
            this.kryptonRibbonGroupTriple6.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // BtnSparkleBlue
            // 
            this.BtnSparkleBlue.Tag = "SparkleBlue";
            this.BtnSparkleBlue.TextLine1 = "Sparkle";
            this.BtnSparkleBlue.TextLine2 = "Blue";
            this.BtnSparkleBlue.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // BtnSparkleOrange
            // 
            this.BtnSparkleOrange.Tag = "SparkleOrange";
            this.BtnSparkleOrange.TextLine1 = "Sparkle Orange";
            this.BtnSparkleOrange.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // BtnSparklePurple
            // 
            this.BtnSparklePurple.Tag = "SparklePurple";
            this.BtnSparklePurple.TextLine1 = "Sparkle Purple";
            this.BtnSparklePurple.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnSystem,
            this.Btn2003Normal});
            this.kryptonRibbonGroupTriple7.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // BtnSystem
            // 
            this.BtnSystem.Tag = "ProfessionalSystem";
            this.BtnSystem.TextLine1 = "System";
            this.BtnSystem.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // Btn2003Normal
            // 
            this.Btn2003Normal.Tag = "ProfessionalOffice2003";
            this.Btn2003Normal.TextLine1 = "2003 Default";
            this.Btn2003Normal.Click += new System.EventHandler(this.BtnPalette_Clicked);
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple8,
            this.kryptonRibbonGroupTriple9});
            this.kryptonRibbonGroup2.TextLine1 = "Grouping";
            this.kryptonRibbonGroup2.Visible = false;
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnTabs,
            this.BtnRibbonTabs,
            this.BtnButtons});
            this.kryptonRibbonGroupTriple8.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // BtnTabs
            // 
            this.BtnTabs.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnTabs.ImageSmall")));
            this.BtnTabs.Tag = "BarTabGroup ";
            this.BtnTabs.TextLine1 = "Tabs";
            this.BtnTabs.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // BtnRibbonTabs
            // 
            this.BtnRibbonTabs.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnRibbonTabs.ImageSmall")));
            this.BtnRibbonTabs.Tag = "BarRibbonTabGroup";
            this.BtnRibbonTabs.TextLine1 = "Ribbon Tabs";
            this.BtnRibbonTabs.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // BtnButtons
            // 
            this.BtnButtons.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnButtons.ImageSmall")));
            this.BtnButtons.Tag = "BarCheckButtonGroupOutside";
            this.BtnButtons.TextLine1 = "Buttons";
            this.BtnButtons.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // kryptonRibbonGroupTriple9
            // 
            this.kryptonRibbonGroupTriple9.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BtnHeader,
            this.BtnHeaderButtons,
            this.BtnStack});
            this.kryptonRibbonGroupTriple9.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // BtnHeader
            // 
            this.BtnHeader.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnHeader.ImageSmall")));
            this.BtnHeader.Tag = "HeaderGroup";
            this.BtnHeader.TextLine1 = "Header";
            this.BtnHeader.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // BtnHeaderButtons
            // 
            this.BtnHeaderButtons.ImageSmall = ((System.Drawing.Image)(resources.GetObject("BtnHeaderButtons.ImageSmall")));
            this.BtnHeaderButtons.Tag = "HeaderBarCheckButtonHeaderGroup";
            this.BtnHeaderButtons.TextLine1 = "Header Buttons";
            this.BtnHeaderButtons.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // BtnStack
            // 
            this.BtnStack.Tag = "StackCheckButtonGroup";
            this.BtnStack.TextLine1 = "Stack";
            this.BtnStack.Click += new System.EventHandler(this.BtnGrouping_Clicked);
            // 
            // KdwMain
            // 
            this.KdwMain.ActivePage = null;
            this.KdwMain.AutoHiddenHost = false;
            this.KdwMain.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.KdwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KdwMain.Location = new System.Drawing.Point(0, 0);
            this.KdwMain.Name = "KdwMain";
            // 
            // 
            // 
            this.KdwMain.Root.UniqueName = "a25fadbf2c5d492dbc49b959b20fe617";
            this.KdwMain.Root.WorkspaceControl = this.KdwMain;
            this.KdwMain.ShowMaximizeButton = false;
            this.KdwMain.Size = new System.Drawing.Size(1062, 488);
            this.KdwMain.TabIndex = 2;
            this.KdwMain.TabStop = true;
            // 
            // KrpMain
            // 
            this.KrpMain.Controls.Add(this.KdwMain);
            this.KrpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KrpMain.Location = new System.Drawing.Point(0, 135);
            this.KrpMain.Name = "KrpMain";
            this.KrpMain.Size = new System.Drawing.Size(1062, 488);
            this.KrpMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.KrpMain);
            this.Controls.Add(this.kryptonRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decuman MRP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrpMain)).EndInit();
            this.KrpMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private Krypton.Docking.KryptonDockingManager KdmMain;
        private System.Windows.Forms.ImageList ImgListSmall;
        private Krypton.Toolkit.KryptonManager KmnMain;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.SaveFileDialog SfdMain;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Docking.KryptonDockableWorkspace KdwMain;
        private Krypton.Toolkit.KryptonPanel KrpMain;
        private Krypton.Ribbon.KryptonRibbonTab KrtHome;
        private Krypton.Ribbon.KryptonRibbonGroup KrgOperations;
        private Krypton.Ribbon.KryptonRibbonGroup KrgArrange;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnNewWindow;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnCloseWindow;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnCloseAllWindow;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnCascade;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnTileHorizontal;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRbnTileVertical;
        private Krypton.Ribbon.KryptonRibbonTab KrtAppearance;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2010Blue;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2010Silver;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2010Black;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2007Blue;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2007Silver;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2007Black;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnSparkleBlue;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnSparkleOrange;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnSparklePurple;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnSystem;
        private Krypton.Ribbon.KryptonRibbonGroupButton Btn2003Normal;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnTabs;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnRibbonTabs;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnButtons;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnHeader;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnHeaderButtons;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnStack;
    }
}

