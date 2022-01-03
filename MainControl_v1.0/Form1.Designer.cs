namespace MainControl_v1._0
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.btn_serialPort_PCM_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_PCM_disconn = new System.Windows.Forms.Button();
            this.tb_serialPort_PCM = new System.Windows.Forms.TextBox();
            this.gp_GameSys = new System.Windows.Forms.GroupBox();
            this.lb_serialPort_PCM = new System.Windows.Forms.Label();
            this.cb_serialPort_PCM = new System.Windows.Forms.ComboBox();
            this.gp_ExerciseSys = new System.Windows.Forms.GroupBox();
            this.tb_serialPort_TRM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TagReSel = new System.Windows.Forms.Button();
            this.btn_WaitRmOn = new System.Windows.Forms.Button();
            this.btn_TagSel = new System.Windows.Forms.Button();
            this.btn_IotTest = new System.Windows.Forms.Button();
            this.tc_serialPort_IOT = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_G1P6 = new System.Windows.Forms.RadioButton();
            this.rb_G1P5 = new System.Windows.Forms.RadioButton();
            this.rb_G1P4 = new System.Windows.Forms.RadioButton();
            this.rb_G1P3 = new System.Windows.Forms.RadioButton();
            this.rb_G1P2 = new System.Windows.Forms.RadioButton();
            this.rb_G1P1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_G3P6 = new System.Windows.Forms.RadioButton();
            this.rb_G3P5 = new System.Windows.Forms.RadioButton();
            this.rb_G3P4 = new System.Windows.Forms.RadioButton();
            this.rb_G3P3 = new System.Windows.Forms.RadioButton();
            this.rb_G3P2 = new System.Windows.Forms.RadioButton();
            this.rb_G3P1 = new System.Windows.Forms.RadioButton();
            this.cb_serialPort_IOT = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_IOT = new System.Windows.Forms.Label();
            this.tb_serialPort_IOT = new System.Windows.Forms.TextBox();
            this.btn_serialPort_IOT_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_IOT_disconn = new System.Windows.Forms.Button();
            this.timer_IotSys = new System.Windows.Forms.Timer(this.components);
            this.lb_IotTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_serialPort_TRM = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_TRM = new System.Windows.Forms.Label();
            this.btn_serialPort_TRM_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_TRM_disconn = new System.Windows.Forms.Button();
            this.rb_G1P7 = new System.Windows.Forms.RadioButton();
            this.rb_G2P7 = new System.Windows.Forms.RadioButton();
            this.rb_G3P7 = new System.Windows.Forms.RadioButton();
            this.gp_GameSys.SuspendLayout();
            this.gp_ExerciseSys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tc_serialPort_IOT.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_serialPort_PCM_conn
            // 
            this.btn_serialPort_PCM_conn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_PCM_conn.Location = new System.Drawing.Point(6, 961);
            this.btn_serialPort_PCM_conn.Name = "btn_serialPort_PCM_conn";
            this.btn_serialPort_PCM_conn.Size = new System.Drawing.Size(110, 35);
            this.btn_serialPort_PCM_conn.TabIndex = 0;
            this.btn_serialPort_PCM_conn.Text = "CONNECT";
            this.btn_serialPort_PCM_conn.UseVisualStyleBackColor = true;
            this.btn_serialPort_PCM_conn.Click += new System.EventHandler(this.btn_serialPort_PCM_conn_Click);
            // 
            // btn_serialPort_PCM_disconn
            // 
            this.btn_serialPort_PCM_disconn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_PCM_disconn.Location = new System.Drawing.Point(166, 961);
            this.btn_serialPort_PCM_disconn.Name = "btn_serialPort_PCM_disconn";
            this.btn_serialPort_PCM_disconn.Size = new System.Drawing.Size(110, 35);
            this.btn_serialPort_PCM_disconn.TabIndex = 1;
            this.btn_serialPort_PCM_disconn.Text = "DISCONNECT";
            this.btn_serialPort_PCM_disconn.UseVisualStyleBackColor = true;
            this.btn_serialPort_PCM_disconn.Click += new System.EventHandler(this.btn_serialPort_PCM_disconn_Click);
            // 
            // tb_serialPort_PCM
            // 
            this.tb_serialPort_PCM.Location = new System.Drawing.Point(6, 25);
            this.tb_serialPort_PCM.Multiline = true;
            this.tb_serialPort_PCM.Name = "tb_serialPort_PCM";
            this.tb_serialPort_PCM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serialPort_PCM.Size = new System.Drawing.Size(270, 875);
            this.tb_serialPort_PCM.TabIndex = 2;
            // 
            // gp_GameSys
            // 
            this.gp_GameSys.Controls.Add(this.cb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.lb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.tb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.btn_serialPort_PCM_conn);
            this.gp_GameSys.Controls.Add(this.btn_serialPort_PCM_disconn);
            this.gp_GameSys.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_GameSys.Location = new System.Drawing.Point(12, 12);
            this.gp_GameSys.Name = "gp_GameSys";
            this.gp_GameSys.Size = new System.Drawing.Size(1144, 1002);
            this.gp_GameSys.TabIndex = 3;
            this.gp_GameSys.TabStop = false;
            this.gp_GameSys.Text = "GAME SYSTEM";
            // 
            // lb_serialPort_PCM
            // 
            this.lb_serialPort_PCM.AutoSize = true;
            this.lb_serialPort_PCM.Font = new System.Drawing.Font("Helvetica95-Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serialPort_PCM.Location = new System.Drawing.Point(6, 906);
            this.lb_serialPort_PCM.Name = "lb_serialPort_PCM";
            this.lb_serialPort_PCM.Size = new System.Drawing.Size(189, 19);
            this.lb_serialPort_PCM.TabIndex = 3;
            this.lb_serialPort_PCM.Text = "GAME 시스템을 연결해주세요";
            // 
            // cb_serialPort_PCM
            // 
            this.cb_serialPort_PCM.FormattingEnabled = true;
            this.cb_serialPort_PCM.Location = new System.Drawing.Point(6, 928);
            this.cb_serialPort_PCM.Name = "cb_serialPort_PCM";
            this.cb_serialPort_PCM.Size = new System.Drawing.Size(270, 27);
            this.cb_serialPort_PCM.TabIndex = 4;
            // 
            // gp_ExerciseSys
            // 
            this.gp_ExerciseSys.Controls.Add(this.cb_serialPort_TRM);
            this.gp_ExerciseSys.Controls.Add(this.lb_serialPort_TRM);
            this.gp_ExerciseSys.Controls.Add(this.btn_serialPort_TRM_conn);
            this.gp_ExerciseSys.Controls.Add(this.btn_serialPort_TRM_disconn);
            this.gp_ExerciseSys.Controls.Add(this.tb_serialPort_TRM);
            this.gp_ExerciseSys.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ExerciseSys.Location = new System.Drawing.Point(1162, 391);
            this.gp_ExerciseSys.Name = "gp_ExerciseSys";
            this.gp_ExerciseSys.Size = new System.Drawing.Size(730, 623);
            this.gp_ExerciseSys.TabIndex = 8;
            this.gp_ExerciseSys.TabStop = false;
            this.gp_ExerciseSys.Text = "EXERCISE ROOM SYSTEM";
            // 
            // tb_serialPort_TRM
            // 
            this.tb_serialPort_TRM.Location = new System.Drawing.Point(6, 25);
            this.tb_serialPort_TRM.Multiline = true;
            this.tb_serialPort_TRM.Name = "tb_serialPort_TRM";
            this.tb_serialPort_TRM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serialPort_TRM.Size = new System.Drawing.Size(270, 496);
            this.tb_serialPort_TRM.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_TagReSel);
            this.groupBox1.Controls.Add(this.btn_WaitRmOn);
            this.groupBox1.Controls.Add(this.btn_TagSel);
            this.groupBox1.Controls.Add(this.btn_IotTest);
            this.groupBox1.Controls.Add(this.tc_serialPort_IOT);
            this.groupBox1.Controls.Add(this.cb_serialPort_IOT);
            this.groupBox1.Controls.Add(this.lb_serialPort_IOT);
            this.groupBox1.Controls.Add(this.tb_serialPort_IOT);
            this.groupBox1.Controls.Add(this.btn_serialPort_IOT_conn);
            this.groupBox1.Controls.Add(this.btn_serialPort_IOT_disconn);
            this.groupBox1.Controls.Add(this.lb_IotTimer);
            this.groupBox1.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1162, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 373);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IOT GLOVE SYSTEM";
            // 
            // btn_TagReSel
            // 
            this.btn_TagReSel.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TagReSel.Location = new System.Drawing.Point(624, 329);
            this.btn_TagReSel.Name = "btn_TagReSel";
            this.btn_TagReSel.Size = new System.Drawing.Size(100, 35);
            this.btn_TagReSel.TabIndex = 15;
            this.btn_TagReSel.Text = "술래 재결정 ";
            this.btn_TagReSel.UseVisualStyleBackColor = true;
            // 
            // btn_WaitRmOn
            // 
            this.btn_WaitRmOn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaitRmOn.Location = new System.Drawing.Point(518, 329);
            this.btn_WaitRmOn.Name = "btn_WaitRmOn";
            this.btn_WaitRmOn.Size = new System.Drawing.Size(100, 35);
            this.btn_WaitRmOn.TabIndex = 14;
            this.btn_WaitRmOn.Text = "대기공간 ON";
            this.btn_WaitRmOn.UseVisualStyleBackColor = true;
            // 
            // btn_TagSel
            // 
            this.btn_TagSel.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TagSel.Location = new System.Drawing.Point(624, 288);
            this.btn_TagSel.Name = "btn_TagSel";
            this.btn_TagSel.Size = new System.Drawing.Size(100, 35);
            this.btn_TagSel.TabIndex = 13;
            this.btn_TagSel.Text = "술래 결정 (3분)";
            this.btn_TagSel.UseVisualStyleBackColor = true;
            // 
            // btn_IotTest
            // 
            this.btn_IotTest.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IotTest.Location = new System.Drawing.Point(518, 288);
            this.btn_IotTest.Name = "btn_IotTest";
            this.btn_IotTest.Size = new System.Drawing.Size(100, 35);
            this.btn_IotTest.TabIndex = 12;
            this.btn_IotTest.Text = "IOT  테스트";
            this.btn_IotTest.UseVisualStyleBackColor = true;
            // 
            // tc_serialPort_IOT
            // 
            this.tc_serialPort_IOT.Controls.Add(this.tabPage1);
            this.tc_serialPort_IOT.Controls.Add(this.tabPage2);
            this.tc_serialPort_IOT.Controls.Add(this.tabPage3);
            this.tc_serialPort_IOT.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_serialPort_IOT.Location = new System.Drawing.Point(282, 133);
            this.tc_serialPort_IOT.Name = "tc_serialPort_IOT";
            this.tc_serialPort_IOT.SelectedIndex = 0;
            this.tc_serialPort_IOT.Size = new System.Drawing.Size(230, 231);
            this.tc_serialPort_IOT.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(222, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "G1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_G1P7);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Font = new System.Drawing.Font("Helvetica75", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 195);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GROUP 1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "G1_PLAYER6";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "G1_PLAYER5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(6, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "G1_PLAYER4";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 70);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(102, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "G1_PLAYER3";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(6, 45);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(102, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "G1_PLAYER2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(6, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(102, 19);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "G1_PLAYER1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(222, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "G2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_G2P7);
            this.groupBox3.Controls.Add(this.rb_G1P6);
            this.groupBox3.Controls.Add(this.rb_G1P5);
            this.groupBox3.Controls.Add(this.rb_G1P4);
            this.groupBox3.Controls.Add(this.rb_G1P3);
            this.groupBox3.Controls.Add(this.rb_G1P2);
            this.groupBox3.Controls.Add(this.rb_G1P1);
            this.groupBox3.Font = new System.Drawing.Font("Helvetica75", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 195);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GROUP 2";
            // 
            // rb_G1P6
            // 
            this.rb_G1P6.AutoSize = true;
            this.rb_G1P6.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P6.Location = new System.Drawing.Point(6, 145);
            this.rb_G1P6.Name = "rb_G1P6";
            this.rb_G1P6.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P6.TabIndex = 5;
            this.rb_G1P6.TabStop = true;
            this.rb_G1P6.Text = "G2_PLAYER6";
            this.rb_G1P6.UseVisualStyleBackColor = true;
            // 
            // rb_G1P5
            // 
            this.rb_G1P5.AutoSize = true;
            this.rb_G1P5.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P5.Location = new System.Drawing.Point(6, 120);
            this.rb_G1P5.Name = "rb_G1P5";
            this.rb_G1P5.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P5.TabIndex = 4;
            this.rb_G1P5.TabStop = true;
            this.rb_G1P5.Text = "G2_PLAYER5";
            this.rb_G1P5.UseVisualStyleBackColor = true;
            // 
            // rb_G1P4
            // 
            this.rb_G1P4.AutoSize = true;
            this.rb_G1P4.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P4.Location = new System.Drawing.Point(6, 95);
            this.rb_G1P4.Name = "rb_G1P4";
            this.rb_G1P4.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P4.TabIndex = 3;
            this.rb_G1P4.TabStop = true;
            this.rb_G1P4.Text = "G1_PLAYER4";
            this.rb_G1P4.UseVisualStyleBackColor = true;
            // 
            // rb_G1P3
            // 
            this.rb_G1P3.AutoSize = true;
            this.rb_G1P3.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P3.Location = new System.Drawing.Point(6, 70);
            this.rb_G1P3.Name = "rb_G1P3";
            this.rb_G1P3.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P3.TabIndex = 2;
            this.rb_G1P3.TabStop = true;
            this.rb_G1P3.Text = "G2_PLAYER3";
            this.rb_G1P3.UseVisualStyleBackColor = true;
            // 
            // rb_G1P2
            // 
            this.rb_G1P2.AutoSize = true;
            this.rb_G1P2.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P2.Location = new System.Drawing.Point(6, 45);
            this.rb_G1P2.Name = "rb_G1P2";
            this.rb_G1P2.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P2.TabIndex = 1;
            this.rb_G1P2.TabStop = true;
            this.rb_G1P2.Text = "G2_PLAYER2";
            this.rb_G1P2.UseVisualStyleBackColor = true;
            // 
            // rb_G1P1
            // 
            this.rb_G1P1.AutoSize = true;
            this.rb_G1P1.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P1.Location = new System.Drawing.Point(6, 20);
            this.rb_G1P1.Name = "rb_G1P1";
            this.rb_G1P1.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P1.TabIndex = 0;
            this.rb_G1P1.TabStop = true;
            this.rb_G1P1.Text = "G2_PLAYER1";
            this.rb_G1P1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(222, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "G3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_G3P7);
            this.groupBox4.Controls.Add(this.rb_G3P6);
            this.groupBox4.Controls.Add(this.rb_G3P5);
            this.groupBox4.Controls.Add(this.rb_G3P4);
            this.groupBox4.Controls.Add(this.rb_G3P3);
            this.groupBox4.Controls.Add(this.rb_G3P2);
            this.groupBox4.Controls.Add(this.rb_G3P1);
            this.groupBox4.Font = new System.Drawing.Font("Helvetica75", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 195);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GROUP 3";
            // 
            // rb_G3P6
            // 
            this.rb_G3P6.AutoSize = true;
            this.rb_G3P6.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P6.Location = new System.Drawing.Point(6, 146);
            this.rb_G3P6.Name = "rb_G3P6";
            this.rb_G3P6.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P6.TabIndex = 5;
            this.rb_G3P6.TabStop = true;
            this.rb_G3P6.Text = "G3_PLAYER6";
            this.rb_G3P6.UseVisualStyleBackColor = true;
            // 
            // rb_G3P5
            // 
            this.rb_G3P5.AutoSize = true;
            this.rb_G3P5.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P5.Location = new System.Drawing.Point(6, 121);
            this.rb_G3P5.Name = "rb_G3P5";
            this.rb_G3P5.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P5.TabIndex = 4;
            this.rb_G3P5.TabStop = true;
            this.rb_G3P5.Text = "G3_PLAYER5";
            this.rb_G3P5.UseVisualStyleBackColor = true;
            // 
            // rb_G3P4
            // 
            this.rb_G3P4.AutoSize = true;
            this.rb_G3P4.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P4.Location = new System.Drawing.Point(6, 96);
            this.rb_G3P4.Name = "rb_G3P4";
            this.rb_G3P4.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P4.TabIndex = 3;
            this.rb_G3P4.TabStop = true;
            this.rb_G3P4.Text = "G3_PLAYER4";
            this.rb_G3P4.UseVisualStyleBackColor = true;
            // 
            // rb_G3P3
            // 
            this.rb_G3P3.AutoSize = true;
            this.rb_G3P3.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P3.Location = new System.Drawing.Point(6, 71);
            this.rb_G3P3.Name = "rb_G3P3";
            this.rb_G3P3.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P3.TabIndex = 2;
            this.rb_G3P3.TabStop = true;
            this.rb_G3P3.Text = "G3_PLAYER3";
            this.rb_G3P3.UseVisualStyleBackColor = true;
            // 
            // rb_G3P2
            // 
            this.rb_G3P2.AutoSize = true;
            this.rb_G3P2.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P2.Location = new System.Drawing.Point(6, 46);
            this.rb_G3P2.Name = "rb_G3P2";
            this.rb_G3P2.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P2.TabIndex = 1;
            this.rb_G3P2.TabStop = true;
            this.rb_G3P2.Text = "G3_PLAYER2";
            this.rb_G3P2.UseVisualStyleBackColor = true;
            // 
            // rb_G3P1
            // 
            this.rb_G3P1.AutoSize = true;
            this.rb_G3P1.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P1.Location = new System.Drawing.Point(6, 21);
            this.rb_G3P1.Name = "rb_G3P1";
            this.rb_G3P1.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P1.TabIndex = 0;
            this.rb_G3P1.TabStop = true;
            this.rb_G3P1.Text = "G3_PLAYER1";
            this.rb_G3P1.UseVisualStyleBackColor = true;
            // 
            // cb_serialPort_IOT
            // 
            this.cb_serialPort_IOT.FormattingEnabled = true;
            this.cb_serialPort_IOT.Location = new System.Drawing.Point(282, 40);
            this.cb_serialPort_IOT.Name = "cb_serialPort_IOT";
            this.cb_serialPort_IOT.Size = new System.Drawing.Size(230, 27);
            this.cb_serialPort_IOT.TabIndex = 5;
            // 
            // lb_serialPort_IOT
            // 
            this.lb_serialPort_IOT.AutoSize = true;
            this.lb_serialPort_IOT.Font = new System.Drawing.Font("Helvetica95-Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serialPort_IOT.Location = new System.Drawing.Point(282, 18);
            this.lb_serialPort_IOT.Name = "lb_serialPort_IOT";
            this.lb_serialPort_IOT.Size = new System.Drawing.Size(168, 19);
            this.lb_serialPort_IOT.TabIndex = 7;
            this.lb_serialPort_IOT.Text = "IOT 시스템을 연결해주세요";
            // 
            // tb_serialPort_IOT
            // 
            this.tb_serialPort_IOT.Location = new System.Drawing.Point(6, 25);
            this.tb_serialPort_IOT.Multiline = true;
            this.tb_serialPort_IOT.Name = "tb_serialPort_IOT";
            this.tb_serialPort_IOT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serialPort_IOT.Size = new System.Drawing.Size(270, 339);
            this.tb_serialPort_IOT.TabIndex = 6;
            // 
            // btn_serialPort_IOT_conn
            // 
            this.btn_serialPort_IOT_conn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_IOT_conn.Location = new System.Drawing.Point(282, 73);
            this.btn_serialPort_IOT_conn.Name = "btn_serialPort_IOT_conn";
            this.btn_serialPort_IOT_conn.Size = new System.Drawing.Size(100, 35);
            this.btn_serialPort_IOT_conn.TabIndex = 4;
            this.btn_serialPort_IOT_conn.Text = "CONNECT";
            this.btn_serialPort_IOT_conn.UseVisualStyleBackColor = true;
            this.btn_serialPort_IOT_conn.Click += new System.EventHandler(this.btn_serialPort_IOT_conn_Click);
            // 
            // btn_serialPort_IOT_disconn
            // 
            this.btn_serialPort_IOT_disconn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_IOT_disconn.Location = new System.Drawing.Point(412, 73);
            this.btn_serialPort_IOT_disconn.Name = "btn_serialPort_IOT_disconn";
            this.btn_serialPort_IOT_disconn.Size = new System.Drawing.Size(100, 35);
            this.btn_serialPort_IOT_disconn.TabIndex = 5;
            this.btn_serialPort_IOT_disconn.Text = "DISCONNECT";
            this.btn_serialPort_IOT_disconn.UseVisualStyleBackColor = true;
            this.btn_serialPort_IOT_disconn.Click += new System.EventHandler(this.btn_serialPort_IOT_disconn_Click);
            // 
            // lb_IotTimer
            // 
            this.lb_IotTimer.AutoSize = true;
            this.lb_IotTimer.Font = new System.Drawing.Font("HelveticaInserat", 66.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IotTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_IotTimer.Location = new System.Drawing.Point(518, 175);
            this.lb_IotTimer.Name = "lb_IotTimer";
            this.lb_IotTimer.Size = new System.Drawing.Size(204, 110);
            this.lb_IotTimer.TabIndex = 16;
            this.lb_IotTimer.Text = "3:00";
            this.lb_IotTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(518, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(624, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_serialPort_TRM
            // 
            this.cb_serialPort_TRM.FormattingEnabled = true;
            this.cb_serialPort_TRM.Location = new System.Drawing.Point(6, 546);
            this.cb_serialPort_TRM.Name = "cb_serialPort_TRM";
            this.cb_serialPort_TRM.Size = new System.Drawing.Size(270, 27);
            this.cb_serialPort_TRM.TabIndex = 9;
            // 
            // lb_serialPort_TRM
            // 
            this.lb_serialPort_TRM.AutoSize = true;
            this.lb_serialPort_TRM.Font = new System.Drawing.Font("Helvetica95-Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serialPort_TRM.Location = new System.Drawing.Point(6, 524);
            this.lb_serialPort_TRM.Name = "lb_serialPort_TRM";
            this.lb_serialPort_TRM.Size = new System.Drawing.Size(175, 19);
            this.lb_serialPort_TRM.TabIndex = 11;
            this.lb_serialPort_TRM.Text = "훈련소 시스템을 연결해주세요";
            // 
            // btn_serialPort_TRM_conn
            // 
            this.btn_serialPort_TRM_conn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_TRM_conn.Location = new System.Drawing.Point(6, 579);
            this.btn_serialPort_TRM_conn.Name = "btn_serialPort_TRM_conn";
            this.btn_serialPort_TRM_conn.Size = new System.Drawing.Size(110, 35);
            this.btn_serialPort_TRM_conn.TabIndex = 8;
            this.btn_serialPort_TRM_conn.Text = "CONNECT";
            this.btn_serialPort_TRM_conn.UseVisualStyleBackColor = true;
            this.btn_serialPort_TRM_conn.Click += new System.EventHandler(this.btn_serialPort_TRM_conn_Click);
            // 
            // btn_serialPort_TRM_disconn
            // 
            this.btn_serialPort_TRM_disconn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_TRM_disconn.Location = new System.Drawing.Point(166, 579);
            this.btn_serialPort_TRM_disconn.Name = "btn_serialPort_TRM_disconn";
            this.btn_serialPort_TRM_disconn.Size = new System.Drawing.Size(110, 35);
            this.btn_serialPort_TRM_disconn.TabIndex = 10;
            this.btn_serialPort_TRM_disconn.Text = "DISCONNECT";
            this.btn_serialPort_TRM_disconn.UseVisualStyleBackColor = true;
            this.btn_serialPort_TRM_disconn.Click += new System.EventHandler(this.btn_serialPort_TRM_disconn_Click);
            // 
            // rb_G1P7
            // 
            this.rb_G1P7.AutoSize = true;
            this.rb_G1P7.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P7.Location = new System.Drawing.Point(6, 170);
            this.rb_G1P7.Name = "rb_G1P7";
            this.rb_G1P7.Size = new System.Drawing.Size(102, 19);
            this.rb_G1P7.TabIndex = 6;
            this.rb_G1P7.TabStop = true;
            this.rb_G1P7.Text = "G1_PLAYER7";
            this.rb_G1P7.UseVisualStyleBackColor = true;
            // 
            // rb_G2P7
            // 
            this.rb_G2P7.AutoSize = true;
            this.rb_G2P7.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P7.Location = new System.Drawing.Point(6, 170);
            this.rb_G2P7.Name = "rb_G2P7";
            this.rb_G2P7.Size = new System.Drawing.Size(102, 19);
            this.rb_G2P7.TabIndex = 6;
            this.rb_G2P7.TabStop = true;
            this.rb_G2P7.Text = "G2_PLAYER7";
            this.rb_G2P7.UseVisualStyleBackColor = true;
            // 
            // rb_G3P7
            // 
            this.rb_G3P7.AutoSize = true;
            this.rb_G3P7.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P7.Location = new System.Drawing.Point(6, 171);
            this.rb_G3P7.Name = "rb_G3P7";
            this.rb_G3P7.Size = new System.Drawing.Size(102, 19);
            this.rb_G3P7.TabIndex = 6;
            this.rb_G3P7.TabStop = true;
            this.rb_G3P7.Text = "G3_PLAYER7";
            this.rb_G3P7.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.gp_ExerciseSys);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gp_GameSys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainControl";
            this.Text = "MainControl_v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.gp_GameSys.ResumeLayout(false);
            this.gp_GameSys.PerformLayout();
            this.gp_ExerciseSys.ResumeLayout(false);
            this.gp_ExerciseSys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tc_serialPort_IOT.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_serialPort_PCM_conn;
        private System.Windows.Forms.Button btn_serialPort_PCM_disconn;
        private System.Windows.Forms.TextBox tb_serialPort_PCM;
        private System.Windows.Forms.GroupBox gp_GameSys;
        private System.Windows.Forms.Label lb_serialPort_PCM;
        private System.Windows.Forms.ComboBox cb_serialPort_PCM;
        private System.Windows.Forms.GroupBox gp_ExerciseSys;
        private System.Windows.Forms.TextBox tb_serialPort_TRM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_TagReSel;
        private System.Windows.Forms.Button btn_WaitRmOn;
        private System.Windows.Forms.Button btn_TagSel;
        private System.Windows.Forms.Button btn_IotTest;
        private System.Windows.Forms.TabControl tc_serialPort_IOT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_G1P6;
        private System.Windows.Forms.RadioButton rb_G1P5;
        private System.Windows.Forms.RadioButton rb_G1P4;
        private System.Windows.Forms.RadioButton rb_G1P3;
        private System.Windows.Forms.RadioButton rb_G1P2;
        private System.Windows.Forms.RadioButton rb_G1P1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_G3P6;
        private System.Windows.Forms.RadioButton rb_G3P5;
        private System.Windows.Forms.RadioButton rb_G3P4;
        private System.Windows.Forms.RadioButton rb_G3P3;
        private System.Windows.Forms.RadioButton rb_G3P2;
        private System.Windows.Forms.RadioButton rb_G3P1;
        private System.Windows.Forms.ComboBox cb_serialPort_IOT;
        private System.Windows.Forms.Label lb_serialPort_IOT;
        private System.Windows.Forms.TextBox tb_serialPort_IOT;
        private System.Windows.Forms.Button btn_serialPort_IOT_conn;
        private System.Windows.Forms.Button btn_serialPort_IOT_disconn;
        private System.Windows.Forms.Label lb_IotTimer;
        private System.Windows.Forms.Timer timer_IotSys;
        private System.Windows.Forms.ComboBox cb_serialPort_TRM;
        private System.Windows.Forms.Label lb_serialPort_TRM;
        private System.Windows.Forms.Button btn_serialPort_TRM_conn;
        private System.Windows.Forms.Button btn_serialPort_TRM_disconn;
        private System.Windows.Forms.RadioButton rb_G1P7;
        private System.Windows.Forms.RadioButton rb_G2P7;
        private System.Windows.Forms.RadioButton rb_G3P7;
    }
}

