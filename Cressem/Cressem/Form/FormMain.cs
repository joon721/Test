using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CLS;

namespace Cressem
{
    public partial class FormMain : Form
    {
        public static class ButtonColor
        {
            public static Color normal = Color.White;
            public static Color selected = Color.Lime;
        }

        public bool isWorking = false;
        public static CXmlFile setupXml = new CXmlFile(System.Environment.CurrentDirectory + @"\Language.xml");
        public static string mainLanguage = "";
        public FormMain()
        {
            InitializeComponent();
            SetMainFormText();

            FormList.PageHome.TopLevel = false;
            FormList.PageManual.TopLevel = false;
            FormList.PageDevice.TopLevel = false;
            FormList.PageIO.TopLevel = false;
            FormList.PageMotor.TopLevel = false;
            FormList.PageDataView.TopLevel = false;
            FormList.PageUseSkip.TopLevel = false;
            FormList.PageLog.TopLevel = false;
            FormList.PageErrorList.TopLevel = false;
            FormList.PageUser.TopLevel = false;

            this.panelHome.Controls.Add(FormList.PageHome);
            this.panelHome.Controls.Add(FormList.PageManual);
            this.panelHome.Controls.Add(FormList.PageDevice);
            this.panelHome.Controls.Add(FormList.PageIO);
            this.panelHome.Controls.Add(FormList.PageMotor);
            this.panelHome.Controls.Add(FormList.PageDataView);
            this.panelHome.Controls.Add(FormList.PageUseSkip);
            this.panelHome.Controls.Add(FormList.PageLog);
            this.panelHome.Controls.Add(FormList.PageErrorList);
            this.panelHome.Controls.Add(FormList.PageUser);

            HideAllPage();
            FormList.PageHome.Show();
        }

        #region 프로그램 실행시 언어 선택에 맞는 버튼 텍스트 처리 private void SetMainFormText()
        private void SetMainFormText()
        {
            mainLanguage = setupXml.GetNodeVal("LanguageSetup/Language");

            #region Menu Button
            string textDefineNode = "LanguageSetup/MenuButton/" + mainLanguage;
            buttonMain.Text = setupXml.GetNodeVal(textDefineNode + "/Main");
            buttonManual.Text = setupXml.GetNodeVal(textDefineNode + "/Manual");
            buttonDevice.Text = setupXml.GetNodeVal(textDefineNode + "/Device");
            buttonIO.Text = setupXml.GetNodeVal(textDefineNode + "/IOMonitor");
            buttonMotor.Text = setupXml.GetNodeVal(textDefineNode + "/Motor");
            buttonDataView.Text = setupXml.GetNodeVal(textDefineNode + "/DataView");
            buttonUseSkip.Text = setupXml.GetNodeVal(textDefineNode + "/UseSkip");
            buttonLog.Text = setupXml.GetNodeVal(textDefineNode + "/Log");
            buttonErrorList.Text = setupXml.GetNodeVal(textDefineNode + "/ErrorList");
            buttonUser.Text = setupXml.GetNodeVal(textDefineNode + "/User");
            #endregion

            #region Manual 화면
            #endregion
        }
        #endregion

        #region 최소화/종료 버튼 처리
        private void labelClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            Application.Exit();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region button Hovering 처리
        private void labelMinimize_MouseHover(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.LightGray;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.Transparent;
        }

        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Transparent;
        }
        
        #endregion

        private void HideAllPage()
        {
            FormList.PageHome.Hide();
            FormList.PageManual.Hide();
            FormList.PageDevice.Hide();
            FormList.PageIO.Hide();
            FormList.PageMotor.Hide();
            FormList.PageDataView.Hide();
            FormList.PageUseSkip.Hide();
            FormList.PageLog.Hide();
            FormList.PageErrorList.Hide();
            FormList.PageUser.Hide();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            labelCurDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            #region 메뉴 버튼 활성화/비활성화 처리
            bool isWorking = false;
            isWorking = FormList.PageManual.isWorking;
            isWorking |= FormList.PageDevice.isWorking;
            isWorking |= FormList.PageIO.isWorking;
            isWorking |= FormList.PageMotor.isWorking;
            isWorking |= FormList.PageDataView.isWorking;
            isWorking |= FormList.PageUseSkip.isWorking;
            isWorking |= FormList.PageLog.isWorking;
            isWorking |= FormList.PageErrorList.isWorking;
            isWorking |= FormList.PageUser.isWorking;

            if (isWorking)
                DisableAllMenuButton();
            else
                EnableAllMenuButton();
            #endregion

            ChangeMenuButtonColor();

        }

        public void EnableAllMenuButton()
        {
            buttonMain.Enabled = true;
            buttonManual.Enabled = true;
            buttonDevice.Enabled = true;
            buttonIO.Enabled = true;
            buttonMotor.Enabled = true;
            buttonDataView.Enabled = true;
            buttonUseSkip.Enabled = true;
            buttonLog.Enabled = true;
            buttonErrorList.Enabled = true;
            buttonUser.Enabled = true;
        }

        public void DisableAllMenuButton()
        {
            if (!FormList.PageHome.Visible)
                buttonMain.Enabled = false;
            if (!FormList.PageManual.Visible)
                buttonManual.Enabled = false;
            if (!FormList.PageDevice.Visible)
                buttonDevice.Enabled = false;
            if (!FormList.PageIO.Visible)
                buttonIO.Enabled = false;
            if (!FormList.PageMotor.Visible)
                buttonMotor.Enabled = false;
            if (!FormList.PageDataView.Visible)
                buttonDataView.Enabled = false;
            if (!FormList.PageUseSkip.Visible)
                buttonUseSkip.Enabled = false;
            if (!FormList.PageLog.Visible)
                buttonLog.Enabled = false;
            if (!FormList.PageErrorList.Visible)
                buttonErrorList.Enabled = false;
            if (!FormList.PageUser.Visible)
                buttonUser.Enabled = false;
        }

        private void ChangeMenuButtonColor()
        {
            if(FormList.PageHome.Visible)
                buttonMain.ForeColor = ButtonColor.selected;
            else
                buttonMain.ForeColor = ButtonColor.normal;

            if(FormList.PageManual.Visible)
                buttonManual.ForeColor = ButtonColor.selected;
            else
                buttonManual.ForeColor = ButtonColor.normal;

            if(FormList.PageDevice.Visible)
                buttonDevice.ForeColor = ButtonColor.selected;
            else
                buttonDevice.ForeColor = ButtonColor.normal;

            if(FormList.PageIO.Visible)
                buttonIO.ForeColor = ButtonColor.selected;
            else
                buttonIO.ForeColor = ButtonColor.normal;

            if(FormList.PageMotor.Visible)
                buttonMotor.ForeColor = ButtonColor.selected;
            else
                buttonMotor.ForeColor = ButtonColor.normal;

            if(FormList.PageDataView.Visible)
                buttonDataView.ForeColor = ButtonColor.selected;
            else
                buttonDataView.ForeColor = ButtonColor.normal;

            if(FormList.PageUseSkip.Visible)
                buttonUseSkip.ForeColor = ButtonColor.selected;
            else
                buttonUseSkip.ForeColor = ButtonColor.normal;

            if(FormList.PageLog.Visible)
                buttonLog.ForeColor = ButtonColor.selected;
            else
                buttonLog.ForeColor = ButtonColor.normal;

            if(FormList.PageErrorList.Visible)
                buttonErrorList.ForeColor = ButtonColor.selected;
            else
                buttonErrorList.ForeColor = ButtonColor.normal;

            if(FormList.PageUser.Visible)
                buttonUser.ForeColor = ButtonColor.selected;
            else
                buttonUser.ForeColor = ButtonColor.normal;
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageHome.Show();
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageManual.Show();
        }
        
        private void buttonDevice_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageDevice.Show();
        }

        private void buttonIO_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageIO.Show();
        }

        private void buttonMotor_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageMotor.Show();
        }

        private void buttonDataView_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageDataView.Show();
        }

        private void buttonUseSkip_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageUseSkip.Show();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageLog.Show();
        }

        private void buttonErrorList_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageErrorList.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            HideAllPage();
            FormList.PageUser.Show();
        }

        private void pictureBoxLogo_DoubleClick(object sender, EventArgs e)
        {
            // 주화면의 크기 정보 읽기
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            // 2nd screen  = Screen.AllScreens[1]

            // 픽셀 포맷 정보 얻기 (optional)
            int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
            PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
            if (bitsPerPixel <= 16)
                pixelFormat = PixelFormat.Format16bppRgb565;
            if (bitsPerPixel == 24)
                pixelFormat = PixelFormat.Format24bppRgb;

            // 화면 크기만큼의 Bitmap 생성
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, pixelFormat);

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                // 화면을 그대로 카피해서 Bitmap 메모리에 저장
                gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }

            // Bitmap 데이터를 파일로 저장
            string curForm = "Home_";
            if (FormList.PageManual.Visible)
                curForm = "PageManual_";
            else if (FormList.PageDevice.Visible)
                curForm = "PageDevice_";
            else if (FormList.PageIO.Visible)
                curForm = "PageIO_";
            else if (FormList.PageDataView.Visible)
                curForm = "PageDataView_";
            else if (FormList.PageUseSkip.Visible)
                curForm = "PageUseSkip_";
            else if (FormList.PageLog.Visible)
                curForm = "PageLog_";
            else if (FormList.PageErrorList.Visible)
                curForm = "PageErrorList_";
            else if (FormList.PageUser.Visible)
                curForm = "PageUser_";
            else
                curForm = "PageHome_";

            string fileName = System.Environment.CurrentDirectory + @"\Capture\" + curForm + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".png";
            bmp.Save(fileName);
            bmp.Dispose();
        }
    }
}
