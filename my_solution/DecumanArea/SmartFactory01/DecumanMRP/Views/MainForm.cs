using DecumanMRP.StaticInfo;
using DecumanMRP.UserControls;
using DecumanMRP.Views;
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Ribbon;
using Krypton.Toolkit;
using Krypton.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecumanMRP
{
    public partial class MainForm : KryptonForm //Form
    {
        #region Instance Fields

        private int _count = 1;
        private NavigatorMode _cellMode;
        private KryptonRibbonGroupButton[] _paletteButtons;
        private KryptonRibbonGroupButton[] _groupingButtons;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            _paletteButtons = new KryptonRibbonGroupButton[] { Btn2010Blue, Btn2010Silver, Btn2010Black,
                                                               Btn2007Blue, Btn2007Silver, Btn2007Black,
                                                               BtnSparkleBlue, BtnSparkleOrange, BtnSparklePurple,
                                                               BtnSystem, Btn2003Normal };

            //_groupingButtons = new KryptonRibbonGroupButton[]{buttonTabs, buttonRibbonTabs, buttonButtons,
            //                                                  buttonHeader, buttonHeaderButtons, buttonStack};

            #region SplashScreen 시작

            int sleepTime = 1000;
            Thread splashThread = new Thread(LoadingScreen.ShowSplashScreen);
            splashThread.IsBackground = true;
            splashThread.Start();

            #endregion SplashScreen 끝

            #region Loading 1

            Thread.Sleep(sleepTime);
            LoadingScreen.UdpateStatusText("Loading 1..");

            try
            {
                Thread.Sleep(sleepTime);
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 OK", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (System.Exception ex)
            {
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 Fail", TypeOfMessage.Error);
                Environment.Exit(0);
            }

            #endregion

            #region Loading 2

            //LoadingScreen.UdpateStatusText("Loading 2..");

            //try
            //{
            //    Thread.Sleep(sleepTime);
            //    LoadingScreen.UdpateStatusTextWithStatus("Loading 2 OK", TypeOfMessage.Success);
            //    Thread.Sleep(sleepTime);
            //}
            //catch (System.Exception ex)
            //{
            //    LoadingScreen.UdpateStatusTextWithStatus("Loading 2 Fail", TypeOfMessage.Error);
            //    Environment.Exit(0);
            //}

            #endregion

            LoadingScreen.CloseSplashScreen();

            var loginForm = new LoginForm();
            var result = loginForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 도킹기능 셋팅
            KryptonDockingWorkspace workspace = KdmMain.ManageWorkspace(KdwMain);
            KdmMain.ManageControl(KrpMain, workspace);
            KdmMain.ManageFloating(this);

            // 도킹페이지 추가
            KdmMain.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewProjectView() });
            KdmMain.AddAutoHiddenGroup("Control", DockingEdge.Right, new KryptonPage[] { NewPropertyView() });
            KdmMain.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewInputView(), NewInputView() });
            KdmMain.AddToWorkspace("Workspace", new KryptonPage[] { NewDocumentView(), NewDocumentView(), NewDocumentView() });
        }

        private KryptonPage NewProjectView()
        {
            return NewPage("Project View", 3, new CntProjectView());
        }

        private KryptonPage NewPropertyView()
        {
            return NewPage("Property View", 1, new CntPropertyView());
        }

        private KryptonPage NewInputView()
        {
            return NewPage("Input View", 4, new CntInputView());
        }

        private KryptonPage NewDocumentView()
        {
            return NewPage("Document View", 0, new CntDocumentView());
        }

        /// <summary>
        /// 페이지 생성하는 메서드. 프로젝트와 메인, 프로퍼티와 아래 콘솔별로 다시 처리해야 함
        /// _count 번호 등...
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = name + _count.ToString(),
                TextTitle = name + _count.ToString(),
                TextDescription = name + _count.ToString()
            };
            p.UniqueName = p.Text;
            p.ImageSmall = ImgListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private void BtnRbnNewWindow_Click(object sender, EventArgs e)
        {
            AddMDIChildWindow();
        }

        private void BtnRbnCloseWindow_Click(object sender, EventArgs e)
        {
            KdmMain.RemovePage("Document View6", true);
        }

        private void BtnRbnCloseAllWindow_Click(object sender, EventArgs e)
        {

        }

        private void BtnRbnCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void BtnRbnTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void BtnRbnTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void AddMDIChildWindow()
        {
            KdmMain.AddToWorkspace("Workspace", new KryptonPage[] { NewDocumentView() });
        }

        private void BtnPalette_Clicked(object sender, EventArgs e)
        {
            KryptonRibbonGroupButton button = (KryptonRibbonGroupButton)sender;
            KmnMain.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteModeManager), (string)button.Tag);
            UpdateButtonsFromPalette();
        }

        private void UpdateButtonsFromPalette()
        {
            // Get the string representation of the global palette
            string mode = KmnMain.GlobalPaletteMode.ToString();

            // Check the palette button that matches the global palette
            foreach (KryptonRibbonGroupButton button in _paletteButtons)
                button.Checked = (button.Tag.ToString().Equals(mode));
        }

        private void BtnGrouping_Clicked(object sender, EventArgs e)
        {
            KryptonRibbonGroupButton button = (KryptonRibbonGroupButton)sender;
            _cellMode = (NavigatorMode)Enum.Parse(typeof(NavigatorMode), (string)button.Tag);
            //UpdateCellsFromGrouping();
            //UpdateButtonsFromGrouping();
        }

        private void UpdateCellsFromGrouping()
        {
            /*KryptonWorkspaceCell cell = KryptonDockableWorkspace.FirstCell();
            while (cell != null)
            {
                cell.NavigatorMode = _cellMode;
                cell = kryptonWorkspace.NextCell(cell);
            }*/
        }
    }
}
