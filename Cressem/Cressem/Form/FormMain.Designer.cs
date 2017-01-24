namespace Cressem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonErrorList = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonUseSkip = new System.Windows.Forms.Button();
            this.buttonDataView = new System.Windows.Forms.Button();
            this.buttonMotor = new System.Windows.Forms.Button();
            this.buttonIO = new System.Windows.Forms.Button();
            this.buttonDevice = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelStop = new System.Windows.Forms.Panel();
            this.panelReset = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCurDate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.panelStop.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonErrorList);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonUseSkip);
            this.panel1.Controls.Add(this.buttonDataView);
            this.panel1.Controls.Add(this.buttonMotor);
            this.panel1.Controls.Add(this.buttonIO);
            this.panel1.Controls.Add(this.buttonDevice);
            this.panel1.Controls.Add(this.buttonManual);
            this.panel1.Controls.Add(this.buttonMain);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 0;
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUser.Location = new System.Drawing.Point(0, 808);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(200, 80);
            this.buttonUser.TabIndex = 10;
            this.buttonUser.Text = "USER";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonErrorList
            // 
            this.buttonErrorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonErrorList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonErrorList.FlatAppearance.BorderSize = 0;
            this.buttonErrorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorList.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonErrorList.Location = new System.Drawing.Point(0, 728);
            this.buttonErrorList.Name = "buttonErrorList";
            this.buttonErrorList.Size = new System.Drawing.Size(200, 80);
            this.buttonErrorList.TabIndex = 9;
            this.buttonErrorList.Text = "ERROR LIST";
            this.buttonErrorList.UseVisualStyleBackColor = false;
            this.buttonErrorList.Click += new System.EventHandler(this.buttonErrorList_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLog.Location = new System.Drawing.Point(0, 648);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(200, 80);
            this.buttonLog.TabIndex = 8;
            this.buttonLog.Text = "LOG";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonUseSkip
            // 
            this.buttonUseSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonUseSkip.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUseSkip.FlatAppearance.BorderSize = 0;
            this.buttonUseSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUseSkip.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseSkip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUseSkip.Location = new System.Drawing.Point(0, 568);
            this.buttonUseSkip.Name = "buttonUseSkip";
            this.buttonUseSkip.Size = new System.Drawing.Size(200, 80);
            this.buttonUseSkip.TabIndex = 7;
            this.buttonUseSkip.Text = "USE/SKIP";
            this.buttonUseSkip.UseVisualStyleBackColor = false;
            this.buttonUseSkip.Click += new System.EventHandler(this.buttonUseSkip_Click);
            // 
            // buttonDataView
            // 
            this.buttonDataView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDataView.FlatAppearance.BorderSize = 0;
            this.buttonDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataView.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDataView.Location = new System.Drawing.Point(0, 488);
            this.buttonDataView.Name = "buttonDataView";
            this.buttonDataView.Size = new System.Drawing.Size(200, 80);
            this.buttonDataView.TabIndex = 6;
            this.buttonDataView.Text = "DATA VIEW";
            this.buttonDataView.UseVisualStyleBackColor = false;
            this.buttonDataView.Click += new System.EventHandler(this.buttonDataView_Click);
            // 
            // buttonMotor
            // 
            this.buttonMotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonMotor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMotor.FlatAppearance.BorderSize = 0;
            this.buttonMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMotor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMotor.Location = new System.Drawing.Point(0, 408);
            this.buttonMotor.Name = "buttonMotor";
            this.buttonMotor.Size = new System.Drawing.Size(200, 80);
            this.buttonMotor.TabIndex = 5;
            this.buttonMotor.Text = "MOTOR";
            this.buttonMotor.UseVisualStyleBackColor = false;
            this.buttonMotor.Click += new System.EventHandler(this.buttonMotor_Click);
            // 
            // buttonIO
            // 
            this.buttonIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIO.FlatAppearance.BorderSize = 0;
            this.buttonIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIO.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIO.Location = new System.Drawing.Point(0, 328);
            this.buttonIO.Name = "buttonIO";
            this.buttonIO.Size = new System.Drawing.Size(200, 80);
            this.buttonIO.TabIndex = 4;
            this.buttonIO.Text = "I/O\r\nMONTOR";
            this.buttonIO.UseVisualStyleBackColor = false;
            this.buttonIO.Click += new System.EventHandler(this.buttonIO_Click);
            // 
            // buttonDevice
            // 
            this.buttonDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDevice.FlatAppearance.BorderSize = 0;
            this.buttonDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevice.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDevice.Location = new System.Drawing.Point(0, 248);
            this.buttonDevice.Name = "buttonDevice";
            this.buttonDevice.Size = new System.Drawing.Size(200, 80);
            this.buttonDevice.TabIndex = 3;
            this.buttonDevice.Text = "DEVICE";
            this.buttonDevice.UseVisualStyleBackColor = false;
            this.buttonDevice.Click += new System.EventHandler(this.buttonDevice_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManual.FlatAppearance.BorderSize = 0;
            this.buttonManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonManual.Location = new System.Drawing.Point(0, 168);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(200, 80);
            this.buttonManual.TabIndex = 2;
            this.buttonManual.Text = "MANUAL";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMain.Location = new System.Drawing.Point(0, 88);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(200, 80);
            this.buttonMain.TabIndex = 1;
            this.buttonMain.Text = " MAIN";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 88);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 88);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panelStart);
            this.panel3.Controls.Add(this.panelStop);
            this.panel3.Controls.Add(this.panelReset);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 88);
            this.panel3.TabIndex = 1;
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelStart.Controls.Add(this.button3);
            this.panelStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStart.Location = new System.Drawing.Point(1182, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(150, 88);
            this.panelStart.TabIndex = 3;
            // 
            // panelStop
            // 
            this.panelStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelStop.Controls.Add(this.button4);
            this.panelStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStop.Location = new System.Drawing.Point(1332, 0);
            this.panelStop.Name = "panelStop";
            this.panelStop.Size = new System.Drawing.Size(150, 88);
            this.panelStop.TabIndex = 2;
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelReset.Controls.Add(this.button5);
            this.panelReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReset.Location = new System.Drawing.Point(1482, 0);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(150, 88);
            this.panelReset.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel5.Controls.Add(this.labelCurDate);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1632, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 88);
            this.panel5.TabIndex = 0;
            // 
            // labelCurDate
            // 
            this.labelCurDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurDate.Location = new System.Drawing.Point(0, 49);
            this.labelCurDate.Name = "labelCurDate";
            this.labelCurDate.Size = new System.Drawing.Size(85, 36);
            this.labelCurDate.TabIndex = 2;
            this.labelCurDate.Text = "Current Time";
            this.labelCurDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelMinimize);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(88, 30);
            this.panel6.TabIndex = 1;
            // 
            // labelMinimize
            // 
            this.labelMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.labelMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMinimize.Location = new System.Drawing.Point(0, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(43, 30);
            this.labelMinimize.TabIndex = 2;
            this.labelMinimize.Text = "─";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            this.labelMinimize.MouseHover += new System.EventHandler(this.labelMinimize_MouseHover);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelClose);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(43, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(45, 30);
            this.panel7.TabIndex = 2;
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.labelClose.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(0, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(45, 30);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            this.labelClose.MouseHover += new System.EventHandler(this.labelClose_MouseHover);
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(200, 88);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1720, 992);
            this.panelHome.TabIndex = 1;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 500;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel8.Controls.Add(this.textBoxDeviceName);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1182, 44);
            this.panel8.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "DEVICE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel9.Controls.Add(this.textBoxStatus);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1182, 44);
            this.panel9.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "STATUS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDeviceName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeviceName.Location = new System.Drawing.Point(169, 4);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(1000, 37);
            this.textBoxDeviceName.TabIndex = 1;
            this.textBoxDeviceName.Text = "Device 1";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxStatus.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(169, 4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(1000, 37);
            this.textBoxStatus.TabIndex = 2;
            this.textBoxStatus.Text = "STOP";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::Cressem.Properties.Resources.cressem_logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 88);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.DoubleClick += new System.EventHandler(this.pictureBoxLogo_DoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 88);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 88);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 88);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelStart.ResumeLayout(false);
            this.panelStop.ResumeLayout(false);
            this.panelReset.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonErrorList;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonUseSkip;
        private System.Windows.Forms.Button buttonDataView;
        private System.Windows.Forms.Button buttonMotor;
        private System.Windows.Forms.Button buttonIO;
        private System.Windows.Forms.Button buttonDevice;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label labelCurDate;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelStop;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

