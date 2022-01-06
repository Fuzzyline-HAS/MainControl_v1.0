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
            this.gp_IotGroup = new System.Windows.Forms.GroupBox();
            this.rb_IOT_Group3 = new System.Windows.Forms.RadioButton();
            this.rb_IOT_Group2 = new System.Windows.Forms.RadioButton();
            this.rb_IOT_Group1 = new System.Windows.Forms.RadioButton();
            this.btn_GameSys_SetupMode = new System.Windows.Forms.Button();
            this.gp_GameSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.btn_GameSys_funcC = new System.Windows.Forms.Button();
            this.btn_GameSys_funcB = new System.Windows.Forms.Button();
            this.btn_GameSys_NarrantionPlay = new System.Windows.Forms.Button();
            this.cb_GameSys_Narration = new System.Windows.Forms.ComboBox();
            this.btn_GameSys_funcA = new System.Windows.Forms.Button();
            this.btn_GameSys_SelfRevive = new System.Windows.Forms.Button();
            this.btn_GameSys_OS_Start = new System.Windows.Forms.Button();
            this.btn_GameSys_GameStop = new System.Windows.Forms.Button();
            this.btn_GameSys_VideoPlay = new System.Windows.Forms.Button();
            this.gp_MemeberSetup = new System.Windows.Forms.GroupBox();
            this.rb_GameSys_6P = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_5P = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_4P = new System.Windows.Forms.RadioButton();
            this.btn_GameSys_ReadyMode = new System.Windows.Forms.Button();
            this.btn_GameSys_GameStart = new System.Windows.Forms.Button();
            this.gp_GameSys_Progress = new System.Windows.Forms.GroupBox();
            this.lb_GameSys_CollectedTemple_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_CollectedTemple = new System.Windows.Forms.Label();
            this.lb_GameSys_ActivateEscape_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_FixedGenerator_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_UsedRevive_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_OpenItembox_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_ActivateEscape = new System.Windows.Forms.Label();
            this.lb_GameSys_FixedGenerator = new System.Windows.Forms.Label();
            this.lb_GameSys_UsedRevive = new System.Windows.Forms.Label();
            this.lb_GameSys_OpenItembox = new System.Windows.Forms.Label();
            this.gp_GameSys_time = new System.Windows.Forms.GroupBox();
            this.btn_GameSys_timerStop = new System.Windows.Forms.Button();
            this.btn_GameSys_timerStart = new System.Windows.Forms.Button();
            this.btn_GameSys_1min_add = new System.Windows.Forms.Button();
            this.btn_GameSys_5min_add = new System.Windows.Forms.Button();
            this.lb_GameSys_Clock = new System.Windows.Forms.Label();
            this.gp_ModeSetup = new System.Windows.Forms.GroupBox();
            this.rb_GameSys_HardMode = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_NormalMode = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_EasyMode = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Toilet_name = new System.Windows.Forms.Label();
            this.lb_SleepingRoom_name = new System.Windows.Forms.Label();
            this.lb_Cellarge_name = new System.Windows.Forms.Label();
            this.lb_LivingRoom_name = new System.Windows.Forms.Label();
            this.lb_Bamboo_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gp_Revive = new System.Windows.Forms.GroupBox();
            this.lb_TR2_name = new System.Windows.Forms.Label();
            this.lb_TR2_state = new System.Windows.Forms.Label();
            this.lb_TR1_name = new System.Windows.Forms.Label();
            this.lb_TR1_state = new System.Windows.Forms.Label();
            this.lb_SR2_name = new System.Windows.Forms.Label();
            this.lb_SR2_state = new System.Windows.Forms.Label();
            this.lb_SR1_name = new System.Windows.Forms.Label();
            this.lb_SR1_state = new System.Windows.Forms.Label();
            this.lb_CR2_name = new System.Windows.Forms.Label();
            this.lb_CR2_state = new System.Windows.Forms.Label();
            this.lb_CR1_name = new System.Windows.Forms.Label();
            this.lb_CR1_state = new System.Windows.Forms.Label();
            this.lb_LR2_name = new System.Windows.Forms.Label();
            this.lb_LR2_state = new System.Windows.Forms.Label();
            this.lb_LR1_name = new System.Windows.Forms.Label();
            this.lb_LR1_state = new System.Windows.Forms.Label();
            this.lb_BR2_name = new System.Windows.Forms.Label();
            this.lb_BR2_state = new System.Windows.Forms.Label();
            this.btn_Revive_send = new System.Windows.Forms.Button();
            this.cb_Revive_state = new System.Windows.Forms.ComboBox();
            this.cb_Revive_name = new System.Windows.Forms.ComboBox();
            this.lb_BR1_name = new System.Windows.Forms.Label();
            this.lb_BR1_state = new System.Windows.Forms.Label();
            this.gp_escape = new System.Windows.Forms.GroupBox();
            this.btn_Escape_send = new System.Windows.Forms.Button();
            this.lb_TE_name = new System.Windows.Forms.Label();
            this.cb_Escape_state = new System.Windows.Forms.ComboBox();
            this.lb_TE_state = new System.Windows.Forms.Label();
            this.cb_Escape_name = new System.Windows.Forms.ComboBox();
            this.lb_SE_name = new System.Windows.Forms.Label();
            this.lb_CE_name = new System.Windows.Forms.Label();
            this.lb_LE_name = new System.Windows.Forms.Label();
            this.lb_BE_name = new System.Windows.Forms.Label();
            this.lb_SE_state = new System.Windows.Forms.Label();
            this.lb_CE_state = new System.Windows.Forms.Label();
            this.lb_LE_state = new System.Windows.Forms.Label();
            this.lb_BE_state = new System.Windows.Forms.Label();
            this.gp_Itembox = new System.Windows.Forms.GroupBox();
            this.btn_Itembox_send = new System.Windows.Forms.Button();
            this.lb_TI2_name = new System.Windows.Forms.Label();
            this.cb_Itembox_state = new System.Windows.Forms.ComboBox();
            this.lb_TI2_state = new System.Windows.Forms.Label();
            this.cb_Itembox_name = new System.Windows.Forms.ComboBox();
            this.lb_TI1_name = new System.Windows.Forms.Label();
            this.lb_TI1_state = new System.Windows.Forms.Label();
            this.lb_SI2_name = new System.Windows.Forms.Label();
            this.lb_SI2_state = new System.Windows.Forms.Label();
            this.lb_SI1_name = new System.Windows.Forms.Label();
            this.lb_SI1_state = new System.Windows.Forms.Label();
            this.lb_CI2_name = new System.Windows.Forms.Label();
            this.lb_CI2_state = new System.Windows.Forms.Label();
            this.lb_CI1_name = new System.Windows.Forms.Label();
            this.lb_CI1_state = new System.Windows.Forms.Label();
            this.lb_LI2_name = new System.Windows.Forms.Label();
            this.lb_LI2_state = new System.Windows.Forms.Label();
            this.lb_LI1_name = new System.Windows.Forms.Label();
            this.lb_LI1_state = new System.Windows.Forms.Label();
            this.lb_BI2_name = new System.Windows.Forms.Label();
            this.lb_BI2_state = new System.Windows.Forms.Label();
            this.lb_BI1_name = new System.Windows.Forms.Label();
            this.lb_BI1_state = new System.Windows.Forms.Label();
            this.gp_Generator = new System.Windows.Forms.GroupBox();
            this.btn_Generator_send = new System.Windows.Forms.Button();
            this.lb_TG_name = new System.Windows.Forms.Label();
            this.cb_Generator_state = new System.Windows.Forms.ComboBox();
            this.lb_TG_state = new System.Windows.Forms.Label();
            this.cb_Generator_name = new System.Windows.Forms.ComboBox();
            this.lb_SG_name = new System.Windows.Forms.Label();
            this.lb_CG_name = new System.Windows.Forms.Label();
            this.lb_LG_name = new System.Windows.Forms.Label();
            this.lb_BG_name = new System.Windows.Forms.Label();
            this.lb_SG_state = new System.Windows.Forms.Label();
            this.lb_CG_state = new System.Windows.Forms.Label();
            this.lb_LG_state = new System.Windows.Forms.Label();
            this.lb_BG_state = new System.Windows.Forms.Label();
            this.cb_serialPort_PCM = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_PCM = new System.Windows.Forms.Label();
            this.gp_Vent = new System.Windows.Forms.GroupBox();
            this.lb_CV_name = new System.Windows.Forms.Label();
            this.lb_CV_state = new System.Windows.Forms.Label();
            this.lb_TV_name = new System.Windows.Forms.Label();
            this.lb_TV_state = new System.Windows.Forms.Label();
            this.lb_SV_name = new System.Windows.Forms.Label();
            this.lb_SV_state = new System.Windows.Forms.Label();
            this.lb_BV2_name = new System.Windows.Forms.Label();
            this.btn_Vent_send = new System.Windows.Forms.Button();
            this.lb_BV2_state = new System.Windows.Forms.Label();
            this.lb_LV_name = new System.Windows.Forms.Label();
            this.lb_BV1_name = new System.Windows.Forms.Label();
            this.lb_BV1_state = new System.Windows.Forms.Label();
            this.cb_Vent_state = new System.Windows.Forms.ComboBox();
            this.cb_Vent_name = new System.Windows.Forms.ComboBox();
            this.lb_LV_state = new System.Windows.Forms.Label();
            this.gp_Door = new System.Windows.Forms.GroupBox();
            this.lb_TD_name = new System.Windows.Forms.Label();
            this.lb_TD_state = new System.Windows.Forms.Label();
            this.lb_SD_name = new System.Windows.Forms.Label();
            this.lb_SD_state = new System.Windows.Forms.Label();
            this.lb_GD_name = new System.Windows.Forms.Label();
            this.btn_Door_send = new System.Windows.Forms.Button();
            this.lb_GD_state = new System.Windows.Forms.Label();
            this.lb_LD_name = new System.Windows.Forms.Label();
            this.cb_Door_state = new System.Windows.Forms.ComboBox();
            this.cb_Door_name = new System.Windows.Forms.ComboBox();
            this.lb_LD_state = new System.Windows.Forms.Label();
            this.gp_Temple = new System.Windows.Forms.GroupBox();
            this.btn_Temple_send = new System.Windows.Forms.Button();
            this.lb_LT_name = new System.Windows.Forms.Label();
            this.cb_Temple_state = new System.Windows.Forms.ComboBox();
            this.cb_Temple_name = new System.Windows.Forms.ComboBox();
            this.lb_LT_state = new System.Windows.Forms.Label();
            this.gp_ExerciseSys = new System.Windows.Forms.GroupBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_MachineSend = new System.Windows.Forms.Button();
            this.cb_ExerciseSys_MachineState = new System.Windows.Forms.ComboBox();
            this.cb_ExerciseSys_MachineName = new System.Windows.Forms.ComboBox();
            this.gp_ExerciseSys_Machine = new System.Windows.Forms.GroupBox();
            this.lb_ExerciseSys_ET_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ET = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EV_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EV = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ED_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ED = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EE_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EE = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EG_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EG = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ER1_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ER1 = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI2_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI1_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI2 = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI1 = new System.Windows.Forms.Label();
            this.gp_ExerciseSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.button26btn_ExerciseSys_LightOff = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_NarrationPlay = new System.Windows.Forms.Button();
            this.cb_ExerciseSys_Narration = new System.Windows.Forms.ComboBox();
            this.btn_ExerciseSys_ExerciseRmOn = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_funcA = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_Stop = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_MovingOn = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_WaitRmOff = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_SetupMode = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_ReadyMode = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_Start = new System.Windows.Forms.Button();
            this.gp_ExerciseSys_timer = new System.Windows.Forms.GroupBox();
            this.btn_ExerciseSys_timerStart = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_timerStop = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_Clock = new System.Windows.Forms.Label();
            this.cb_serialPort_TRM = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_TRM = new System.Windows.Forms.Label();
            this.btn_serialPort_TRM_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_TRM_disconn = new System.Windows.Forms.Button();
            this.tb_serialPort_TRM = new System.Windows.Forms.TextBox();
            this.gp_IotSys = new System.Windows.Forms.GroupBox();
            this.lb_programmedbyBBangJun = new System.Windows.Forms.Label();
            this.gp_IotSys_timer = new System.Windows.Forms.GroupBox();
            this.btn_IotSys_timerStart = new System.Windows.Forms.Button();
            this.btn_IotSys_timerStop = new System.Windows.Forms.Button();
            this.lb_IotSys_Clock = new System.Windows.Forms.Label();
            this.btn_TagReSel = new System.Windows.Forms.Button();
            this.btn_WaitRmOn = new System.Windows.Forms.Button();
            this.btn_TagSel = new System.Windows.Forms.Button();
            this.btn_IotTest = new System.Windows.Forms.Button();
            this.tc_serialPort_IOT = new System.Windows.Forms.TabControl();
            this.tp_G1 = new System.Windows.Forms.TabPage();
            this.lb_G1P8_state = new System.Windows.Forms.Label();
            this.lb_G1P7_state = new System.Windows.Forms.Label();
            this.lb_G1P6_state = new System.Windows.Forms.Label();
            this.lb_G1P5_state = new System.Windows.Forms.Label();
            this.lb_G1P4_state = new System.Windows.Forms.Label();
            this.lb_G1P3_state = new System.Windows.Forms.Label();
            this.lb_G1P2_state = new System.Windows.Forms.Label();
            this.lb_G1P1_state = new System.Windows.Forms.Label();
            this.rb_G1P8 = new System.Windows.Forms.RadioButton();
            this.rb_G1P1 = new System.Windows.Forms.RadioButton();
            this.rb_G1P7 = new System.Windows.Forms.RadioButton();
            this.rb_G1P2 = new System.Windows.Forms.RadioButton();
            this.rb_G1P6 = new System.Windows.Forms.RadioButton();
            this.rb_G1P3 = new System.Windows.Forms.RadioButton();
            this.rb_G1P5 = new System.Windows.Forms.RadioButton();
            this.rb_G1P4 = new System.Windows.Forms.RadioButton();
            this.tp_G2 = new System.Windows.Forms.TabPage();
            this.rb_G2P8 = new System.Windows.Forms.RadioButton();
            this.rb_G2P1 = new System.Windows.Forms.RadioButton();
            this.rb_G2P7 = new System.Windows.Forms.RadioButton();
            this.rb_G2P2 = new System.Windows.Forms.RadioButton();
            this.rb_G2P6 = new System.Windows.Forms.RadioButton();
            this.rb_G2P3 = new System.Windows.Forms.RadioButton();
            this.rb_G2P5 = new System.Windows.Forms.RadioButton();
            this.rb_G2P4 = new System.Windows.Forms.RadioButton();
            this.tp_G3 = new System.Windows.Forms.TabPage();
            this.rb_G3P8 = new System.Windows.Forms.RadioButton();
            this.rb_G3P1 = new System.Windows.Forms.RadioButton();
            this.rb_G3P7 = new System.Windows.Forms.RadioButton();
            this.rb_G3P2 = new System.Windows.Forms.RadioButton();
            this.rb_G3P6 = new System.Windows.Forms.RadioButton();
            this.rb_G3P3 = new System.Windows.Forms.RadioButton();
            this.rb_G3P5 = new System.Windows.Forms.RadioButton();
            this.rb_G3P4 = new System.Windows.Forms.RadioButton();
            this.cb_serialPort_IOT = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_IOT = new System.Windows.Forms.Label();
            this.tb_serialPort_IOT = new System.Windows.Forms.TextBox();
            this.btn_serialPort_IOT_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_IOT_disconn = new System.Windows.Forms.Button();
            this.timer_IotSys = new System.Windows.Forms.Timer(this.components);
            this.timer_GameSys = new System.Windows.Forms.Timer(this.components);
            this.timer_ExerciseSys = new System.Windows.Forms.Timer(this.components);
            this.gp_IotSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.gp_GameSys.SuspendLayout();
            this.gp_IotGroup.SuspendLayout();
            this.gp_GameSys_ManualMode.SuspendLayout();
            this.gp_MemeberSetup.SuspendLayout();
            this.gp_GameSys_Progress.SuspendLayout();
            this.gp_GameSys_time.SuspendLayout();
            this.gp_ModeSetup.SuspendLayout();
            this.gp_Revive.SuspendLayout();
            this.gp_escape.SuspendLayout();
            this.gp_Itembox.SuspendLayout();
            this.gp_Generator.SuspendLayout();
            this.gp_Vent.SuspendLayout();
            this.gp_Door.SuspendLayout();
            this.gp_Temple.SuspendLayout();
            this.gp_ExerciseSys.SuspendLayout();
            this.gp_ExerciseSys_Machine.SuspendLayout();
            this.gp_ExerciseSys_ManualMode.SuspendLayout();
            this.gp_ExerciseSys_timer.SuspendLayout();
            this.gp_IotSys.SuspendLayout();
            this.gp_IotSys_timer.SuspendLayout();
            this.tc_serialPort_IOT.SuspendLayout();
            this.tp_G1.SuspendLayout();
            this.tp_G2.SuspendLayout();
            this.tp_G3.SuspendLayout();
            this.gp_IotSys_ManualMode.SuspendLayout();
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
            this.gp_GameSys.Controls.Add(this.gp_IotGroup);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_SetupMode);
            this.gp_GameSys.Controls.Add(this.gp_GameSys_ManualMode);
            this.gp_GameSys.Controls.Add(this.gp_MemeberSetup);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_ReadyMode);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_GameStart);
            this.gp_GameSys.Controls.Add(this.gp_GameSys_Progress);
            this.gp_GameSys.Controls.Add(this.gp_GameSys_time);
            this.gp_GameSys.Controls.Add(this.gp_ModeSetup);
            this.gp_GameSys.Controls.Add(this.panel7);
            this.gp_GameSys.Controls.Add(this.panel6);
            this.gp_GameSys.Controls.Add(this.panel5);
            this.gp_GameSys.Controls.Add(this.panel4);
            this.gp_GameSys.Controls.Add(this.panel3);
            this.gp_GameSys.Controls.Add(this.panel2);
            this.gp_GameSys.Controls.Add(this.lb_Toilet_name);
            this.gp_GameSys.Controls.Add(this.lb_SleepingRoom_name);
            this.gp_GameSys.Controls.Add(this.lb_Cellarge_name);
            this.gp_GameSys.Controls.Add(this.lb_LivingRoom_name);
            this.gp_GameSys.Controls.Add(this.lb_Bamboo_name);
            this.gp_GameSys.Controls.Add(this.panel1);
            this.gp_GameSys.Controls.Add(this.gp_Revive);
            this.gp_GameSys.Controls.Add(this.gp_escape);
            this.gp_GameSys.Controls.Add(this.gp_Itembox);
            this.gp_GameSys.Controls.Add(this.gp_Generator);
            this.gp_GameSys.Controls.Add(this.cb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.lb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.tb_serialPort_PCM);
            this.gp_GameSys.Controls.Add(this.btn_serialPort_PCM_conn);
            this.gp_GameSys.Controls.Add(this.btn_serialPort_PCM_disconn);
            this.gp_GameSys.Controls.Add(this.gp_Vent);
            this.gp_GameSys.Controls.Add(this.gp_Door);
            this.gp_GameSys.Controls.Add(this.gp_Temple);
            this.gp_GameSys.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_GameSys.Location = new System.Drawing.Point(12, 12);
            this.gp_GameSys.Name = "gp_GameSys";
            this.gp_GameSys.Size = new System.Drawing.Size(1154, 1002);
            this.gp_GameSys.TabIndex = 3;
            this.gp_GameSys.TabStop = false;
            this.gp_GameSys.Text = "GAME SYSTEM";
            // 
            // gp_IotGroup
            // 
            this.gp_IotGroup.BackColor = System.Drawing.SystemColors.Control;
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group3);
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group2);
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group1);
            this.gp_IotGroup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotGroup.Location = new System.Drawing.Point(800, 764);
            this.gp_IotGroup.Name = "gp_IotGroup";
            this.gp_IotGroup.Size = new System.Drawing.Size(84, 97);
            this.gp_IotGroup.TabIndex = 46;
            this.gp_IotGroup.TabStop = false;
            this.gp_IotGroup.Text = "그룹";
            // 
            // rb_IOT_Group3
            // 
            this.rb_IOT_Group3.AutoSize = true;
            this.rb_IOT_Group3.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_IOT_Group3.Location = new System.Drawing.Point(6, 75);
            this.rb_IOT_Group3.Name = "rb_IOT_Group3";
            this.rb_IOT_Group3.Size = new System.Drawing.Size(73, 17);
            this.rb_IOT_Group3.TabIndex = 2;
            this.rb_IOT_Group3.Text = "Group 3";
            this.rb_IOT_Group3.UseVisualStyleBackColor = true;
            // 
            // rb_IOT_Group2
            // 
            this.rb_IOT_Group2.AutoSize = true;
            this.rb_IOT_Group2.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_IOT_Group2.Location = new System.Drawing.Point(6, 52);
            this.rb_IOT_Group2.Name = "rb_IOT_Group2";
            this.rb_IOT_Group2.Size = new System.Drawing.Size(73, 17);
            this.rb_IOT_Group2.TabIndex = 1;
            this.rb_IOT_Group2.Text = "Group 2";
            this.rb_IOT_Group2.UseVisualStyleBackColor = true;
            // 
            // rb_IOT_Group1
            // 
            this.rb_IOT_Group1.AutoSize = true;
            this.rb_IOT_Group1.Checked = true;
            this.rb_IOT_Group1.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_IOT_Group1.Location = new System.Drawing.Point(6, 29);
            this.rb_IOT_Group1.Name = "rb_IOT_Group1";
            this.rb_IOT_Group1.Size = new System.Drawing.Size(73, 17);
            this.rb_IOT_Group1.TabIndex = 0;
            this.rb_IOT_Group1.TabStop = true;
            this.rb_IOT_Group1.Text = "Group 1";
            this.rb_IOT_Group1.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_SetupMode
            // 
            this.btn_GameSys_SetupMode.BackColor = System.Drawing.Color.Snow;
            this.btn_GameSys_SetupMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_SetupMode.Location = new System.Drawing.Point(800, 712);
            this.btn_GameSys_SetupMode.Name = "btn_GameSys_SetupMode";
            this.btn_GameSys_SetupMode.Size = new System.Drawing.Size(168, 46);
            this.btn_GameSys_SetupMode.TabIndex = 52;
            this.btn_GameSys_SetupMode.Text = "장치 정비 모드";
            this.btn_GameSys_SetupMode.UseVisualStyleBackColor = false;
            this.btn_GameSys_SetupMode.Click += new System.EventHandler(this.btn_GameSys_SetupMode_Click);
            // 
            // gp_GameSys_ManualMode
            // 
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_funcC);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_funcB);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_NarrantionPlay);
            this.gp_GameSys_ManualMode.Controls.Add(this.cb_GameSys_Narration);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_funcA);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_SelfRevive);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_OS_Start);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_GameStop);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_VideoPlay);
            this.gp_GameSys_ManualMode.Font = new System.Drawing.Font("HelveticaInserat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_GameSys_ManualMode.Location = new System.Drawing.Point(661, 867);
            this.gp_GameSys_ManualMode.Name = "gp_GameSys_ManualMode";
            this.gp_GameSys_ManualMode.Size = new System.Drawing.Size(487, 126);
            this.gp_GameSys_ManualMode.TabIndex = 51;
            this.gp_GameSys_ManualMode.TabStop = false;
            this.gp_GameSys_ManualMode.Text = "Manual Mode";
            // 
            // btn_GameSys_funcC
            // 
            this.btn_GameSys_funcC.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_funcC.Location = new System.Drawing.Point(415, 25);
            this.btn_GameSys_funcC.Name = "btn_GameSys_funcC";
            this.btn_GameSys_funcC.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_funcC.TabIndex = 59;
            this.btn_GameSys_funcC.Text = "기능\r\nC";
            this.btn_GameSys_funcC.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_funcB
            // 
            this.btn_GameSys_funcB.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_funcB.Location = new System.Drawing.Point(346, 25);
            this.btn_GameSys_funcB.Name = "btn_GameSys_funcB";
            this.btn_GameSys_funcB.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_funcB.TabIndex = 58;
            this.btn_GameSys_funcB.Text = "기능\r\nB\r\n";
            this.btn_GameSys_funcB.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_NarrantionPlay
            // 
            this.btn_GameSys_NarrantionPlay.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_NarrantionPlay.Location = new System.Drawing.Point(415, 96);
            this.btn_GameSys_NarrantionPlay.Name = "btn_GameSys_NarrantionPlay";
            this.btn_GameSys_NarrantionPlay.Size = new System.Drawing.Size(61, 25);
            this.btn_GameSys_NarrantionPlay.TabIndex = 57;
            this.btn_GameSys_NarrantionPlay.Text = "출력";
            this.btn_GameSys_NarrantionPlay.UseVisualStyleBackColor = true;
            // 
            // cb_GameSys_Narration
            // 
            this.cb_GameSys_Narration.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GameSys_Narration.FormattingEnabled = true;
            this.cb_GameSys_Narration.Items.AddRange(new object[] {
            "한개의 발전기가 수리 되었습니다",
            "탈출 장치 활성화",
            "생명장치 활성화",
            "자가부활 모드 활성화",
            "생존자가 사망했습니다. ",
            "제단이 활성화 됩니다.",
            "술래가 승리했습니다",
            "탈출에 성공했습니다",
            "플레이어가 승리했습니다."});
            this.cb_GameSys_Narration.Location = new System.Drawing.Point(6, 96);
            this.cb_GameSys_Narration.Name = "cb_GameSys_Narration";
            this.cb_GameSys_Narration.Size = new System.Drawing.Size(402, 24);
            this.cb_GameSys_Narration.TabIndex = 56;
            this.cb_GameSys_Narration.Text = "나레이션 선택";
            // 
            // btn_GameSys_funcA
            // 
            this.btn_GameSys_funcA.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_funcA.Location = new System.Drawing.Point(278, 25);
            this.btn_GameSys_funcA.Name = "btn_GameSys_funcA";
            this.btn_GameSys_funcA.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_funcA.TabIndex = 54;
            this.btn_GameSys_funcA.Text = "기능\r\nA";
            this.btn_GameSys_funcA.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_SelfRevive
            // 
            this.btn_GameSys_SelfRevive.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_SelfRevive.Location = new System.Drawing.Point(210, 25);
            this.btn_GameSys_SelfRevive.Name = "btn_GameSys_SelfRevive";
            this.btn_GameSys_SelfRevive.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_SelfRevive.TabIndex = 53;
            this.btn_GameSys_SelfRevive.Text = "자가\r\n부활";
            this.btn_GameSys_SelfRevive.UseVisualStyleBackColor = true;
            this.btn_GameSys_SelfRevive.Click += new System.EventHandler(this.btn_GameSys_SelfRevive_Click);
            // 
            // btn_GameSys_OS_Start
            // 
            this.btn_GameSys_OS_Start.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_OS_Start.Location = new System.Drawing.Point(142, 25);
            this.btn_GameSys_OS_Start.Name = "btn_GameSys_OS_Start";
            this.btn_GameSys_OS_Start.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_OS_Start.TabIndex = 52;
            this.btn_GameSys_OS_Start.Text = "OS\r\n시작";
            this.btn_GameSys_OS_Start.UseVisualStyleBackColor = true;
            this.btn_GameSys_OS_Start.Click += new System.EventHandler(this.btn_GameSys_OS_Start_Click);
            // 
            // btn_GameSys_GameStop
            // 
            this.btn_GameSys_GameStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_GameStop.Location = new System.Drawing.Point(6, 25);
            this.btn_GameSys_GameStop.Name = "btn_GameSys_GameStop";
            this.btn_GameSys_GameStop.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_GameStop.TabIndex = 51;
            this.btn_GameSys_GameStop.Text = "GAME STOP";
            this.btn_GameSys_GameStop.UseVisualStyleBackColor = true;
            this.btn_GameSys_GameStop.Click += new System.EventHandler(this.btn_GameSys_GameStop_Click);
            // 
            // btn_GameSys_VideoPlay
            // 
            this.btn_GameSys_VideoPlay.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_VideoPlay.Location = new System.Drawing.Point(74, 25);
            this.btn_GameSys_VideoPlay.Name = "btn_GameSys_VideoPlay";
            this.btn_GameSys_VideoPlay.Size = new System.Drawing.Size(62, 65);
            this.btn_GameSys_VideoPlay.TabIndex = 49;
            this.btn_GameSys_VideoPlay.Text = "영상\r\n재생";
            this.btn_GameSys_VideoPlay.UseVisualStyleBackColor = true;
            this.btn_GameSys_VideoPlay.Click += new System.EventHandler(this.btn_GameSys_VideoPlay_Click);
            // 
            // gp_MemeberSetup
            // 
            this.gp_MemeberSetup.BackColor = System.Drawing.SystemColors.Control;
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_6P);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_5P);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_4P);
            this.gp_MemeberSetup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_MemeberSetup.Location = new System.Drawing.Point(661, 764);
            this.gp_MemeberSetup.Name = "gp_MemeberSetup";
            this.gp_MemeberSetup.Size = new System.Drawing.Size(133, 97);
            this.gp_MemeberSetup.TabIndex = 45;
            this.gp_MemeberSetup.TabStop = false;
            this.gp_MemeberSetup.Text = "인원 설정";
            // 
            // rb_GameSys_6P
            // 
            this.rb_GameSys_6P.AutoSize = true;
            this.rb_GameSys_6P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_6P.Location = new System.Drawing.Point(11, 75);
            this.rb_GameSys_6P.Name = "rb_GameSys_6P";
            this.rb_GameSys_6P.Size = new System.Drawing.Size(79, 17);
            this.rb_GameSys_6P.TabIndex = 2;
            this.rb_GameSys_6P.Text = "6인 PLAY";
            this.rb_GameSys_6P.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_5P
            // 
            this.rb_GameSys_5P.AutoSize = true;
            this.rb_GameSys_5P.Checked = true;
            this.rb_GameSys_5P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_5P.Location = new System.Drawing.Point(11, 52);
            this.rb_GameSys_5P.Name = "rb_GameSys_5P";
            this.rb_GameSys_5P.Size = new System.Drawing.Size(79, 17);
            this.rb_GameSys_5P.TabIndex = 1;
            this.rb_GameSys_5P.TabStop = true;
            this.rb_GameSys_5P.Text = "5인 PLAY";
            this.rb_GameSys_5P.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_4P
            // 
            this.rb_GameSys_4P.AutoSize = true;
            this.rb_GameSys_4P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_4P.Location = new System.Drawing.Point(11, 29);
            this.rb_GameSys_4P.Name = "rb_GameSys_4P";
            this.rb_GameSys_4P.Size = new System.Drawing.Size(79, 17);
            this.rb_GameSys_4P.TabIndex = 0;
            this.rb_GameSys_4P.Text = "4인 PLAY";
            this.rb_GameSys_4P.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_ReadyMode
            // 
            this.btn_GameSys_ReadyMode.BackColor = System.Drawing.Color.Red;
            this.btn_GameSys_ReadyMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_ReadyMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GameSys_ReadyMode.Location = new System.Drawing.Point(800, 658);
            this.btn_GameSys_ReadyMode.Name = "btn_GameSys_ReadyMode";
            this.btn_GameSys_ReadyMode.Size = new System.Drawing.Size(168, 46);
            this.btn_GameSys_ReadyMode.TabIndex = 14;
            this.btn_GameSys_ReadyMode.Text = "장치 준비 모드";
            this.btn_GameSys_ReadyMode.UseVisualStyleBackColor = false;
            this.btn_GameSys_ReadyMode.Click += new System.EventHandler(this.btn_GameSys_ReadyMode_Click);
            // 
            // btn_GameSys_GameStart
            // 
            this.btn_GameSys_GameStart.BackColor = System.Drawing.Color.Green;
            this.btn_GameSys_GameStart.Font = new System.Drawing.Font("HelveticaInserat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GameSys_GameStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GameSys_GameStart.Location = new System.Drawing.Point(974, 656);
            this.btn_GameSys_GameStart.Name = "btn_GameSys_GameStart";
            this.btn_GameSys_GameStart.Size = new System.Drawing.Size(174, 102);
            this.btn_GameSys_GameStart.TabIndex = 47;
            this.btn_GameSys_GameStart.Text = "GAME START";
            this.btn_GameSys_GameStart.UseVisualStyleBackColor = false;
            this.btn_GameSys_GameStart.Click += new System.EventHandler(this.btn_GameSys_GameStart_Click);
            // 
            // gp_GameSys_Progress
            // 
            this.gp_GameSys_Progress.BackColor = System.Drawing.SystemColors.Control;
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_CollectedTemple_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_CollectedTemple);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_ActivateEscape_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_FixedGenerator_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_UsedRevive_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_OpenItembox_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_ActivateEscape);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_FixedGenerator);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_UsedRevive);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_OpenItembox);
            this.gp_GameSys_Progress.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_GameSys_Progress.Location = new System.Drawing.Point(890, 764);
            this.gp_GameSys_Progress.Name = "gp_GameSys_Progress";
            this.gp_GameSys_Progress.Size = new System.Drawing.Size(258, 97);
            this.gp_GameSys_Progress.TabIndex = 46;
            this.gp_GameSys_Progress.TabStop = false;
            this.gp_GameSys_Progress.Text = "게임 진행도";
            // 
            // lb_GameSys_CollectedTemple_cnt
            // 
            this.lb_GameSys_CollectedTemple_cnt.AutoSize = true;
            this.lb_GameSys_CollectedTemple_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_CollectedTemple_cnt.Location = new System.Drawing.Point(240, 26);
            this.lb_GameSys_CollectedTemple_cnt.Name = "lb_GameSys_CollectedTemple_cnt";
            this.lb_GameSys_CollectedTemple_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_CollectedTemple_cnt.TabIndex = 11;
            this.lb_GameSys_CollectedTemple_cnt.Text = "0";
            // 
            // lb_GameSys_CollectedTemple
            // 
            this.lb_GameSys_CollectedTemple.AutoSize = true;
            this.lb_GameSys_CollectedTemple.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_CollectedTemple.Location = new System.Drawing.Point(135, 26);
            this.lb_GameSys_CollectedTemple.Name = "lb_GameSys_CollectedTemple";
            this.lb_GameSys_CollectedTemple.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_CollectedTemple.TabIndex = 6;
            this.lb_GameSys_CollectedTemple.Text = "제단 생명칩개수:";
            // 
            // lb_GameSys_ActivateEscape_cnt
            // 
            this.lb_GameSys_ActivateEscape_cnt.AutoSize = true;
            this.lb_GameSys_ActivateEscape_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_ActivateEscape_cnt.Location = new System.Drawing.Point(112, 59);
            this.lb_GameSys_ActivateEscape_cnt.Name = "lb_GameSys_ActivateEscape_cnt";
            this.lb_GameSys_ActivateEscape_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_ActivateEscape_cnt.TabIndex = 10;
            this.lb_GameSys_ActivateEscape_cnt.Text = "0";
            // 
            // lb_GameSys_FixedGenerator_cnt
            // 
            this.lb_GameSys_FixedGenerator_cnt.AutoSize = true;
            this.lb_GameSys_FixedGenerator_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_FixedGenerator_cnt.Location = new System.Drawing.Point(112, 42);
            this.lb_GameSys_FixedGenerator_cnt.Name = "lb_GameSys_FixedGenerator_cnt";
            this.lb_GameSys_FixedGenerator_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_FixedGenerator_cnt.TabIndex = 9;
            this.lb_GameSys_FixedGenerator_cnt.Text = "0";
            // 
            // lb_GameSys_UsedRevive_cnt
            // 
            this.lb_GameSys_UsedRevive_cnt.AutoSize = true;
            this.lb_GameSys_UsedRevive_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_UsedRevive_cnt.Location = new System.Drawing.Point(240, 42);
            this.lb_GameSys_UsedRevive_cnt.Name = "lb_GameSys_UsedRevive_cnt";
            this.lb_GameSys_UsedRevive_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_UsedRevive_cnt.TabIndex = 8;
            this.lb_GameSys_UsedRevive_cnt.Text = "0";
            // 
            // lb_GameSys_OpenItembox_cnt
            // 
            this.lb_GameSys_OpenItembox_cnt.AutoSize = true;
            this.lb_GameSys_OpenItembox_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_OpenItembox_cnt.Location = new System.Drawing.Point(112, 26);
            this.lb_GameSys_OpenItembox_cnt.Name = "lb_GameSys_OpenItembox_cnt";
            this.lb_GameSys_OpenItembox_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_OpenItembox_cnt.TabIndex = 7;
            this.lb_GameSys_OpenItembox_cnt.Text = "0";
            // 
            // lb_GameSys_ActivateEscape
            // 
            this.lb_GameSys_ActivateEscape.AutoSize = true;
            this.lb_GameSys_ActivateEscape.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_ActivateEscape.Location = new System.Drawing.Point(6, 59);
            this.lb_GameSys_ActivateEscape.Name = "lb_GameSys_ActivateEscape";
            this.lb_GameSys_ActivateEscape.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_ActivateEscape.TabIndex = 3;
            this.lb_GameSys_ActivateEscape.Text = "탈출장치 활성화:";
            // 
            // lb_GameSys_FixedGenerator
            // 
            this.lb_GameSys_FixedGenerator.AutoSize = true;
            this.lb_GameSys_FixedGenerator.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_FixedGenerator.Location = new System.Drawing.Point(6, 42);
            this.lb_GameSys_FixedGenerator.Name = "lb_GameSys_FixedGenerator";
            this.lb_GameSys_FixedGenerator.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_FixedGenerator.TabIndex = 2;
            this.lb_GameSys_FixedGenerator.Text = "수리완료 발전기:";
            // 
            // lb_GameSys_UsedRevive
            // 
            this.lb_GameSys_UsedRevive.AutoSize = true;
            this.lb_GameSys_UsedRevive.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_UsedRevive.Location = new System.Drawing.Point(135, 42);
            this.lb_GameSys_UsedRevive.Name = "lb_GameSys_UsedRevive";
            this.lb_GameSys_UsedRevive.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_UsedRevive.TabIndex = 1;
            this.lb_GameSys_UsedRevive.Text = "사용된 부활장치:";
            // 
            // lb_GameSys_OpenItembox
            // 
            this.lb_GameSys_OpenItembox.AutoSize = true;
            this.lb_GameSys_OpenItembox.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_OpenItembox.Location = new System.Drawing.Point(6, 26);
            this.lb_GameSys_OpenItembox.Name = "lb_GameSys_OpenItembox";
            this.lb_GameSys_OpenItembox.Size = new System.Drawing.Size(111, 16);
            this.lb_GameSys_OpenItembox.TabIndex = 0;
            this.lb_GameSys_OpenItembox.Text = "열린 아이템박스: ";
            // 
            // gp_GameSys_time
            // 
            this.gp_GameSys_time.Controls.Add(this.btn_GameSys_timerStop);
            this.gp_GameSys_time.Controls.Add(this.btn_GameSys_timerStart);
            this.gp_GameSys_time.Controls.Add(this.btn_GameSys_1min_add);
            this.gp_GameSys_time.Controls.Add(this.btn_GameSys_5min_add);
            this.gp_GameSys_time.Controls.Add(this.lb_GameSys_Clock);
            this.gp_GameSys_time.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_GameSys_time.Location = new System.Drawing.Point(282, 657);
            this.gp_GameSys_time.Name = "gp_GameSys_time";
            this.gp_GameSys_time.Size = new System.Drawing.Size(373, 336);
            this.gp_GameSys_time.TabIndex = 45;
            this.gp_GameSys_time.TabStop = false;
            this.gp_GameSys_time.Text = "Playing Time";
            // 
            // btn_GameSys_timerStop
            // 
            this.btn_GameSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_timerStop.Location = new System.Drawing.Point(286, 307);
            this.btn_GameSys_timerStop.Name = "btn_GameSys_timerStop";
            this.btn_GameSys_timerStop.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_timerStop.TabIndex = 41;
            this.btn_GameSys_timerStop.Text = "타이머 정지";
            this.btn_GameSys_timerStop.UseVisualStyleBackColor = true;
            this.btn_GameSys_timerStop.Click += new System.EventHandler(this.btn_GameSys_timerStop_Click);
            // 
            // btn_GameSys_timerStart
            // 
            this.btn_GameSys_timerStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_timerStart.Location = new System.Drawing.Point(199, 307);
            this.btn_GameSys_timerStart.Name = "btn_GameSys_timerStart";
            this.btn_GameSys_timerStart.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_timerStart.TabIndex = 40;
            this.btn_GameSys_timerStart.Text = "타이머 시작";
            this.btn_GameSys_timerStart.UseVisualStyleBackColor = true;
            this.btn_GameSys_timerStart.Click += new System.EventHandler(this.btn_GameSys_timerStart_Click);
            // 
            // btn_GameSys_1min_add
            // 
            this.btn_GameSys_1min_add.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_1min_add.Location = new System.Drawing.Point(93, 307);
            this.btn_GameSys_1min_add.Name = "btn_GameSys_1min_add";
            this.btn_GameSys_1min_add.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_1min_add.TabIndex = 39;
            this.btn_GameSys_1min_add.Text = "1분 추가";
            this.btn_GameSys_1min_add.UseVisualStyleBackColor = true;
            this.btn_GameSys_1min_add.Click += new System.EventHandler(this.btn_GameSys_1min_add_Click);
            // 
            // btn_GameSys_5min_add
            // 
            this.btn_GameSys_5min_add.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_5min_add.Location = new System.Drawing.Point(6, 307);
            this.btn_GameSys_5min_add.Name = "btn_GameSys_5min_add";
            this.btn_GameSys_5min_add.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_5min_add.TabIndex = 38;
            this.btn_GameSys_5min_add.Text = "5분 추가";
            this.btn_GameSys_5min_add.UseVisualStyleBackColor = true;
            this.btn_GameSys_5min_add.Click += new System.EventHandler(this.btn_GameSys_5min_add_Click);
            // 
            // lb_GameSys_Clock
            // 
            this.lb_GameSys_Clock.AutoSize = true;
            this.lb_GameSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GameSys_Clock.Location = new System.Drawing.Point(4, 78);
            this.lb_GameSys_Clock.Name = "lb_GameSys_Clock";
            this.lb_GameSys_Clock.Size = new System.Drawing.Size(367, 165);
            this.lb_GameSys_Clock.TabIndex = 37;
            this.lb_GameSys_Clock.Text = "35:00";
            this.lb_GameSys_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gp_ModeSetup
            // 
            this.gp_ModeSetup.BackColor = System.Drawing.SystemColors.Control;
            this.gp_ModeSetup.Controls.Add(this.rb_GameSys_HardMode);
            this.gp_ModeSetup.Controls.Add(this.rb_GameSys_NormalMode);
            this.gp_ModeSetup.Controls.Add(this.rb_GameSys_EasyMode);
            this.gp_ModeSetup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_ModeSetup.Location = new System.Drawing.Point(661, 658);
            this.gp_ModeSetup.Name = "gp_ModeSetup";
            this.gp_ModeSetup.Size = new System.Drawing.Size(133, 100);
            this.gp_ModeSetup.TabIndex = 44;
            this.gp_ModeSetup.TabStop = false;
            this.gp_ModeSetup.Text = "MODE 설정";
            // 
            // rb_GameSys_HardMode
            // 
            this.rb_GameSys_HardMode.AutoSize = true;
            this.rb_GameSys_HardMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_HardMode.Location = new System.Drawing.Point(11, 75);
            this.rb_GameSys_HardMode.Name = "rb_GameSys_HardMode";
            this.rb_GameSys_HardMode.Size = new System.Drawing.Size(94, 17);
            this.rb_GameSys_HardMode.TabIndex = 2;
            this.rb_GameSys_HardMode.Text = "고인물 MODE";
            this.rb_GameSys_HardMode.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_NormalMode
            // 
            this.rb_GameSys_NormalMode.AutoSize = true;
            this.rb_GameSys_NormalMode.Checked = true;
            this.rb_GameSys_NormalMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_NormalMode.Location = new System.Drawing.Point(11, 52);
            this.rb_GameSys_NormalMode.Name = "rb_GameSys_NormalMode";
            this.rb_GameSys_NormalMode.Size = new System.Drawing.Size(83, 17);
            this.rb_GameSys_NormalMode.TabIndex = 1;
            this.rb_GameSys_NormalMode.TabStop = true;
            this.rb_GameSys_NormalMode.Text = "일반 MODE";
            this.rb_GameSys_NormalMode.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_EasyMode
            // 
            this.rb_GameSys_EasyMode.AutoSize = true;
            this.rb_GameSys_EasyMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_EasyMode.Location = new System.Drawing.Point(11, 29);
            this.rb_GameSys_EasyMode.Name = "rb_GameSys_EasyMode";
            this.rb_GameSys_EasyMode.Size = new System.Drawing.Size(83, 17);
            this.rb_GameSys_EasyMode.TabIndex = 0;
            this.rb_GameSys_EasyMode.Text = "뉴비 MODE";
            this.rb_GameSys_EasyMode.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(280, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 595);
            this.panel7.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(1146, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 595);
            this.panel6.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(1001, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 595);
            this.panel5.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(854, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 595);
            this.panel4.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(707, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 595);
            this.panel3.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(560, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 595);
            this.panel2.TabIndex = 32;
            // 
            // lb_Toilet_name
            // 
            this.lb_Toilet_name.AutoSize = true;
            this.lb_Toilet_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Toilet_name.Location = new System.Drawing.Point(1041, 22);
            this.lb_Toilet_name.Name = "lb_Toilet_name";
            this.lb_Toilet_name.Size = new System.Drawing.Size(70, 24);
            this.lb_Toilet_name.TabIndex = 36;
            this.lb_Toilet_name.Text = "화장실";
            // 
            // lb_SleepingRoom_name
            // 
            this.lb_SleepingRoom_name.AutoSize = true;
            this.lb_SleepingRoom_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_SleepingRoom_name.Location = new System.Drawing.Point(904, 22);
            this.lb_SleepingRoom_name.Name = "lb_SleepingRoom_name";
            this.lb_SleepingRoom_name.Size = new System.Drawing.Size(50, 24);
            this.lb_SleepingRoom_name.TabIndex = 35;
            this.lb_SleepingRoom_name.Text = "침실";
            // 
            // lb_Cellarge_name
            // 
            this.lb_Cellarge_name.AutoSize = true;
            this.lb_Cellarge_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cellarge_name.Location = new System.Drawing.Point(748, 22);
            this.lb_Cellarge_name.Name = "lb_Cellarge_name";
            this.lb_Cellarge_name.Size = new System.Drawing.Size(70, 24);
            this.lb_Cellarge_name.TabIndex = 34;
            this.lb_Cellarge_name.Text = "지하실";
            // 
            // lb_LivingRoom_name
            // 
            this.lb_LivingRoom_name.AutoSize = true;
            this.lb_LivingRoom_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_LivingRoom_name.Location = new System.Drawing.Point(603, 22);
            this.lb_LivingRoom_name.Name = "lb_LivingRoom_name";
            this.lb_LivingRoom_name.Size = new System.Drawing.Size(50, 24);
            this.lb_LivingRoom_name.TabIndex = 33;
            this.lb_LivingRoom_name.Text = "거실";
            // 
            // lb_Bamboo_name
            // 
            this.lb_Bamboo_name.AutoSize = true;
            this.lb_Bamboo_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Bamboo_name.Location = new System.Drawing.Point(440, 22);
            this.lb_Bamboo_name.Name = "lb_Bamboo_name";
            this.lb_Bamboo_name.Size = new System.Drawing.Size(90, 24);
            this.lb_Bamboo_name.TabIndex = 32;
            this.lb_Bamboo_name.Text = "대나무숲";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(413, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 595);
            this.panel1.TabIndex = 31;
            // 
            // gp_Revive
            // 
            this.gp_Revive.BackColor = System.Drawing.Color.LightGray;
            this.gp_Revive.Controls.Add(this.lb_TR2_name);
            this.gp_Revive.Controls.Add(this.lb_TR2_state);
            this.gp_Revive.Controls.Add(this.lb_TR1_name);
            this.gp_Revive.Controls.Add(this.lb_TR1_state);
            this.gp_Revive.Controls.Add(this.lb_SR2_name);
            this.gp_Revive.Controls.Add(this.lb_SR2_state);
            this.gp_Revive.Controls.Add(this.lb_SR1_name);
            this.gp_Revive.Controls.Add(this.lb_SR1_state);
            this.gp_Revive.Controls.Add(this.lb_CR2_name);
            this.gp_Revive.Controls.Add(this.lb_CR2_state);
            this.gp_Revive.Controls.Add(this.lb_CR1_name);
            this.gp_Revive.Controls.Add(this.lb_CR1_state);
            this.gp_Revive.Controls.Add(this.lb_LR2_name);
            this.gp_Revive.Controls.Add(this.lb_LR2_state);
            this.gp_Revive.Controls.Add(this.lb_LR1_name);
            this.gp_Revive.Controls.Add(this.lb_LR1_state);
            this.gp_Revive.Controls.Add(this.lb_BR2_name);
            this.gp_Revive.Controls.Add(this.lb_BR2_state);
            this.gp_Revive.Controls.Add(this.btn_Revive_send);
            this.gp_Revive.Controls.Add(this.cb_Revive_state);
            this.gp_Revive.Controls.Add(this.cb_Revive_name);
            this.gp_Revive.Controls.Add(this.lb_BR1_name);
            this.gp_Revive.Controls.Add(this.lb_BR1_state);
            this.gp_Revive.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Revive.Location = new System.Drawing.Point(282, 227);
            this.gp_Revive.Name = "gp_Revive";
            this.gp_Revive.Size = new System.Drawing.Size(866, 80);
            this.gp_Revive.TabIndex = 12;
            this.gp_Revive.TabStop = false;
            this.gp_Revive.Text = "부활장치(R)";
            // 
            // lb_TR2_name
            // 
            this.lb_TR2_name.AutoSize = true;
            this.lb_TR2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TR2_name.Location = new System.Drawing.Point(803, 21);
            this.lb_TR2_name.Name = "lb_TR2_name";
            this.lb_TR2_name.Size = new System.Drawing.Size(59, 19);
            this.lb_TR2_name.TabIndex = 28;
            this.lb_TR2_name.Text = "__TR2__";
            // 
            // lb_TR2_state
            // 
            this.lb_TR2_state.AutoSize = true;
            this.lb_TR2_state.BackColor = System.Drawing.Color.Black;
            this.lb_TR2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TR2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TR2_state.Location = new System.Drawing.Point(800, 42);
            this.lb_TR2_state.Name = "lb_TR2_state";
            this.lb_TR2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TR2_state.TabIndex = 29;
            this.lb_TR2_state.Text = "OFFLINE";
            // 
            // lb_TR1_name
            // 
            this.lb_TR1_name.AutoSize = true;
            this.lb_TR1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TR1_name.Location = new System.Drawing.Point(729, 21);
            this.lb_TR1_name.Name = "lb_TR1_name";
            this.lb_TR1_name.Size = new System.Drawing.Size(59, 19);
            this.lb_TR1_name.TabIndex = 26;
            this.lb_TR1_name.Text = "__TR1__";
            // 
            // lb_TR1_state
            // 
            this.lb_TR1_state.AutoSize = true;
            this.lb_TR1_state.BackColor = System.Drawing.Color.Black;
            this.lb_TR1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TR1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TR1_state.Location = new System.Drawing.Point(727, 41);
            this.lb_TR1_state.Name = "lb_TR1_state";
            this.lb_TR1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TR1_state.TabIndex = 27;
            this.lb_TR1_state.Text = "OFFLINE";
            // 
            // lb_SR2_name
            // 
            this.lb_SR2_name.AutoSize = true;
            this.lb_SR2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SR2_name.Location = new System.Drawing.Point(655, 21);
            this.lb_SR2_name.Name = "lb_SR2_name";
            this.lb_SR2_name.Size = new System.Drawing.Size(60, 19);
            this.lb_SR2_name.TabIndex = 24;
            this.lb_SR2_name.Text = "__SR2__";
            // 
            // lb_SR2_state
            // 
            this.lb_SR2_state.AutoSize = true;
            this.lb_SR2_state.BackColor = System.Drawing.Color.Black;
            this.lb_SR2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SR2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SR2_state.Location = new System.Drawing.Point(653, 42);
            this.lb_SR2_state.Name = "lb_SR2_state";
            this.lb_SR2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SR2_state.TabIndex = 25;
            this.lb_SR2_state.Text = "OFFLINE";
            // 
            // lb_SR1_name
            // 
            this.lb_SR1_name.AutoSize = true;
            this.lb_SR1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SR1_name.Location = new System.Drawing.Point(582, 21);
            this.lb_SR1_name.Name = "lb_SR1_name";
            this.lb_SR1_name.Size = new System.Drawing.Size(60, 19);
            this.lb_SR1_name.TabIndex = 22;
            this.lb_SR1_name.Text = "__SR1__";
            // 
            // lb_SR1_state
            // 
            this.lb_SR1_state.AutoSize = true;
            this.lb_SR1_state.BackColor = System.Drawing.Color.Black;
            this.lb_SR1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SR1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SR1_state.Location = new System.Drawing.Point(581, 42);
            this.lb_SR1_state.Name = "lb_SR1_state";
            this.lb_SR1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SR1_state.TabIndex = 23;
            this.lb_SR1_state.Text = "OFFLINE";
            // 
            // lb_CR2_name
            // 
            this.lb_CR2_name.AutoSize = true;
            this.lb_CR2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CR2_name.Location = new System.Drawing.Point(508, 21);
            this.lb_CR2_name.Name = "lb_CR2_name";
            this.lb_CR2_name.Size = new System.Drawing.Size(60, 19);
            this.lb_CR2_name.TabIndex = 20;
            this.lb_CR2_name.Text = "__CR2__";
            // 
            // lb_CR2_state
            // 
            this.lb_CR2_state.AutoSize = true;
            this.lb_CR2_state.BackColor = System.Drawing.Color.Black;
            this.lb_CR2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CR2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CR2_state.Location = new System.Drawing.Point(507, 42);
            this.lb_CR2_state.Name = "lb_CR2_state";
            this.lb_CR2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CR2_state.TabIndex = 21;
            this.lb_CR2_state.Text = "OFFLINE";
            // 
            // lb_CR1_name
            // 
            this.lb_CR1_name.AutoSize = true;
            this.lb_CR1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CR1_name.Location = new System.Drawing.Point(435, 20);
            this.lb_CR1_name.Name = "lb_CR1_name";
            this.lb_CR1_name.Size = new System.Drawing.Size(60, 19);
            this.lb_CR1_name.TabIndex = 18;
            this.lb_CR1_name.Text = "__CR1__";
            // 
            // lb_CR1_state
            // 
            this.lb_CR1_state.AutoSize = true;
            this.lb_CR1_state.BackColor = System.Drawing.Color.Black;
            this.lb_CR1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CR1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CR1_state.Location = new System.Drawing.Point(434, 41);
            this.lb_CR1_state.Name = "lb_CR1_state";
            this.lb_CR1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CR1_state.TabIndex = 19;
            this.lb_CR1_state.Text = "OFFLINE";
            // 
            // lb_LR2_name
            // 
            this.lb_LR2_name.AutoSize = true;
            this.lb_LR2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LR2_name.Location = new System.Drawing.Point(362, 21);
            this.lb_LR2_name.Name = "lb_LR2_name";
            this.lb_LR2_name.Size = new System.Drawing.Size(59, 19);
            this.lb_LR2_name.TabIndex = 16;
            this.lb_LR2_name.Text = "__LR2__";
            // 
            // lb_LR2_state
            // 
            this.lb_LR2_state.AutoSize = true;
            this.lb_LR2_state.BackColor = System.Drawing.Color.Black;
            this.lb_LR2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LR2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LR2_state.Location = new System.Drawing.Point(360, 42);
            this.lb_LR2_state.Name = "lb_LR2_state";
            this.lb_LR2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LR2_state.TabIndex = 17;
            this.lb_LR2_state.Text = "OFFLINE";
            // 
            // lb_LR1_name
            // 
            this.lb_LR1_name.AutoSize = true;
            this.lb_LR1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LR1_name.Location = new System.Drawing.Point(288, 21);
            this.lb_LR1_name.Name = "lb_LR1_name";
            this.lb_LR1_name.Size = new System.Drawing.Size(59, 19);
            this.lb_LR1_name.TabIndex = 14;
            this.lb_LR1_name.Text = "__LR1__";
            // 
            // lb_LR1_state
            // 
            this.lb_LR1_state.AutoSize = true;
            this.lb_LR1_state.BackColor = System.Drawing.Color.Black;
            this.lb_LR1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LR1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LR1_state.Location = new System.Drawing.Point(285, 42);
            this.lb_LR1_state.Name = "lb_LR1_state";
            this.lb_LR1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LR1_state.TabIndex = 15;
            this.lb_LR1_state.Text = "OFFLINE";
            // 
            // lb_BR2_name
            // 
            this.lb_BR2_name.AutoSize = true;
            this.lb_BR2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BR2_name.Location = new System.Drawing.Point(215, 21);
            this.lb_BR2_name.Name = "lb_BR2_name";
            this.lb_BR2_name.Size = new System.Drawing.Size(60, 19);
            this.lb_BR2_name.TabIndex = 12;
            this.lb_BR2_name.Text = "__BR2__";
            // 
            // lb_BR2_state
            // 
            this.lb_BR2_state.AutoSize = true;
            this.lb_BR2_state.BackColor = System.Drawing.Color.Black;
            this.lb_BR2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BR2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BR2_state.Location = new System.Drawing.Point(214, 41);
            this.lb_BR2_state.Name = "lb_BR2_state";
            this.lb_BR2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BR2_state.TabIndex = 13;
            this.lb_BR2_state.Text = "OFFLINE";
            // 
            // btn_Revive_send
            // 
            this.btn_Revive_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Revive_send.Location = new System.Drawing.Point(67, 21);
            this.btn_Revive_send.Name = "btn_Revive_send";
            this.btn_Revive_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Revive_send.TabIndex = 11;
            this.btn_Revive_send.Text = "전송";
            this.btn_Revive_send.UseVisualStyleBackColor = true;
            // 
            // cb_Revive_state
            // 
            this.cb_Revive_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Revive_state.FormattingEnabled = true;
            this.cb_Revive_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "생명장치 봉쇄",
            "자가부활 모드"});
            this.cb_Revive_state.Location = new System.Drawing.Point(6, 50);
            this.cb_Revive_state.Name = "cb_Revive_state";
            this.cb_Revive_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Revive_state.TabIndex = 11;
            // 
            // cb_Revive_name
            // 
            this.cb_Revive_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Revive_name.FormattingEnabled = true;
            this.cb_Revive_name.Items.AddRange(new object[] {
            "ALL",
            "BR1",
            "BR2",
            "LR1",
            "LR2",
            "CR1",
            "CR2",
            "SR1",
            "SR2",
            "TR1",
            "TR2"});
            this.cb_Revive_name.Location = new System.Drawing.Point(6, 21);
            this.cb_Revive_name.Name = "cb_Revive_name";
            this.cb_Revive_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Revive_name.TabIndex = 10;
            // 
            // lb_BR1_name
            // 
            this.lb_BR1_name.AutoSize = true;
            this.lb_BR1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BR1_name.Location = new System.Drawing.Point(139, 21);
            this.lb_BR1_name.Name = "lb_BR1_name";
            this.lb_BR1_name.Size = new System.Drawing.Size(60, 19);
            this.lb_BR1_name.TabIndex = 0;
            this.lb_BR1_name.Text = "__BR1__";
            // 
            // lb_BR1_state
            // 
            this.lb_BR1_state.AutoSize = true;
            this.lb_BR1_state.BackColor = System.Drawing.Color.Black;
            this.lb_BR1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BR1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BR1_state.Location = new System.Drawing.Point(138, 42);
            this.lb_BR1_state.Name = "lb_BR1_state";
            this.lb_BR1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BR1_state.TabIndex = 5;
            this.lb_BR1_state.Text = "OFFLINE";
            // 
            // gp_escape
            // 
            this.gp_escape.BackColor = System.Drawing.Color.LightGray;
            this.gp_escape.Controls.Add(this.btn_Escape_send);
            this.gp_escape.Controls.Add(this.lb_TE_name);
            this.gp_escape.Controls.Add(this.cb_Escape_state);
            this.gp_escape.Controls.Add(this.lb_TE_state);
            this.gp_escape.Controls.Add(this.cb_Escape_name);
            this.gp_escape.Controls.Add(this.lb_SE_name);
            this.gp_escape.Controls.Add(this.lb_CE_name);
            this.gp_escape.Controls.Add(this.lb_LE_name);
            this.gp_escape.Controls.Add(this.lb_BE_name);
            this.gp_escape.Controls.Add(this.lb_SE_state);
            this.gp_escape.Controls.Add(this.lb_CE_state);
            this.gp_escape.Controls.Add(this.lb_LE_state);
            this.gp_escape.Controls.Add(this.lb_BE_state);
            this.gp_escape.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_escape.Location = new System.Drawing.Point(282, 141);
            this.gp_escape.Name = "gp_escape";
            this.gp_escape.Size = new System.Drawing.Size(866, 80);
            this.gp_escape.TabIndex = 12;
            this.gp_escape.TabStop = false;
            this.gp_escape.Text = "탈출장치 (E)";
            // 
            // btn_Escape_send
            // 
            this.btn_Escape_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Escape_send.Location = new System.Drawing.Point(67, 21);
            this.btn_Escape_send.Name = "btn_Escape_send";
            this.btn_Escape_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Escape_send.TabIndex = 38;
            this.btn_Escape_send.Text = "전송";
            this.btn_Escape_send.UseVisualStyleBackColor = true;
            // 
            // lb_TE_name
            // 
            this.lb_TE_name.AutoSize = true;
            this.lb_TE_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TE_name.Location = new System.Drawing.Point(731, 21);
            this.lb_TE_name.Name = "lb_TE_name";
            this.lb_TE_name.Size = new System.Drawing.Size(121, 19);
            this.lb_TE_name.TabIndex = 4;
            this.lb_TE_name.Text = "_______TE_______";
            // 
            // cb_Escape_state
            // 
            this.cb_Escape_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Escape_state.FormattingEnabled = true;
            this.cb_Escape_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "탈출성공"});
            this.cb_Escape_state.Location = new System.Drawing.Point(6, 50);
            this.cb_Escape_state.Name = "cb_Escape_state";
            this.cb_Escape_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Escape_state.TabIndex = 37;
            // 
            // lb_TE_state
            // 
            this.lb_TE_state.AutoSize = true;
            this.lb_TE_state.BackColor = System.Drawing.Color.Black;
            this.lb_TE_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TE_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TE_state.Location = new System.Drawing.Point(761, 42);
            this.lb_TE_state.Name = "lb_TE_state";
            this.lb_TE_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TE_state.TabIndex = 9;
            this.lb_TE_state.Text = "OFFLINE";
            // 
            // cb_Escape_name
            // 
            this.cb_Escape_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Escape_name.FormattingEnabled = true;
            this.cb_Escape_name.Items.AddRange(new object[] {
            "ALL",
            "BE",
            "LE",
            "CE",
            "SE",
            "TE"});
            this.cb_Escape_name.Location = new System.Drawing.Point(6, 21);
            this.cb_Escape_name.Name = "cb_Escape_name";
            this.cb_Escape_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Escape_name.TabIndex = 36;
            // 
            // lb_SE_name
            // 
            this.lb_SE_name.AutoSize = true;
            this.lb_SE_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SE_name.Location = new System.Drawing.Point(582, 21);
            this.lb_SE_name.Name = "lb_SE_name";
            this.lb_SE_name.Size = new System.Drawing.Size(122, 19);
            this.lb_SE_name.TabIndex = 3;
            this.lb_SE_name.Text = "_______SE_______";
            // 
            // lb_CE_name
            // 
            this.lb_CE_name.AutoSize = true;
            this.lb_CE_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CE_name.Location = new System.Drawing.Point(434, 21);
            this.lb_CE_name.Name = "lb_CE_name";
            this.lb_CE_name.Size = new System.Drawing.Size(129, 19);
            this.lb_CE_name.TabIndex = 2;
            this.lb_CE_name.Text = "________CE_______";
            // 
            // lb_LE_name
            // 
            this.lb_LE_name.AutoSize = true;
            this.lb_LE_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LE_name.Location = new System.Drawing.Point(289, 21);
            this.lb_LE_name.Name = "lb_LE_name";
            this.lb_LE_name.Size = new System.Drawing.Size(128, 19);
            this.lb_LE_name.TabIndex = 1;
            this.lb_LE_name.Text = "________LE_______";
            // 
            // lb_BE_name
            // 
            this.lb_BE_name.AutoSize = true;
            this.lb_BE_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BE_name.Location = new System.Drawing.Point(142, 21);
            this.lb_BE_name.Name = "lb_BE_name";
            this.lb_BE_name.Size = new System.Drawing.Size(122, 19);
            this.lb_BE_name.TabIndex = 0;
            this.lb_BE_name.Text = "_______GE_______";
            // 
            // lb_SE_state
            // 
            this.lb_SE_state.AutoSize = true;
            this.lb_SE_state.BackColor = System.Drawing.Color.Black;
            this.lb_SE_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SE_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SE_state.Location = new System.Drawing.Point(612, 42);
            this.lb_SE_state.Name = "lb_SE_state";
            this.lb_SE_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SE_state.TabIndex = 8;
            this.lb_SE_state.Text = "OFFLINE";
            // 
            // lb_CE_state
            // 
            this.lb_CE_state.AutoSize = true;
            this.lb_CE_state.BackColor = System.Drawing.Color.Black;
            this.lb_CE_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CE_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CE_state.Location = new System.Drawing.Point(471, 42);
            this.lb_CE_state.Name = "lb_CE_state";
            this.lb_CE_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CE_state.TabIndex = 7;
            this.lb_CE_state.Text = "OFFLINE";
            // 
            // lb_LE_state
            // 
            this.lb_LE_state.AutoSize = true;
            this.lb_LE_state.BackColor = System.Drawing.Color.Black;
            this.lb_LE_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LE_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LE_state.Location = new System.Drawing.Point(325, 42);
            this.lb_LE_state.Name = "lb_LE_state";
            this.lb_LE_state.Size = new System.Drawing.Size(59, 16);
            this.lb_LE_state.TabIndex = 6;
            this.lb_LE_state.Text = "사용안함";
            // 
            // lb_BE_state
            // 
            this.lb_BE_state.AutoSize = true;
            this.lb_BE_state.BackColor = System.Drawing.Color.Black;
            this.lb_BE_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BE_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BE_state.Location = new System.Drawing.Point(173, 44);
            this.lb_BE_state.Name = "lb_BE_state";
            this.lb_BE_state.Size = new System.Drawing.Size(59, 16);
            this.lb_BE_state.TabIndex = 5;
            this.lb_BE_state.Text = "사용안함";
            // 
            // gp_Itembox
            // 
            this.gp_Itembox.BackColor = System.Drawing.Color.LightGray;
            this.gp_Itembox.Controls.Add(this.btn_Itembox_send);
            this.gp_Itembox.Controls.Add(this.lb_TI2_name);
            this.gp_Itembox.Controls.Add(this.cb_Itembox_state);
            this.gp_Itembox.Controls.Add(this.lb_TI2_state);
            this.gp_Itembox.Controls.Add(this.cb_Itembox_name);
            this.gp_Itembox.Controls.Add(this.lb_TI1_name);
            this.gp_Itembox.Controls.Add(this.lb_TI1_state);
            this.gp_Itembox.Controls.Add(this.lb_SI2_name);
            this.gp_Itembox.Controls.Add(this.lb_SI2_state);
            this.gp_Itembox.Controls.Add(this.lb_SI1_name);
            this.gp_Itembox.Controls.Add(this.lb_SI1_state);
            this.gp_Itembox.Controls.Add(this.lb_CI2_name);
            this.gp_Itembox.Controls.Add(this.lb_CI2_state);
            this.gp_Itembox.Controls.Add(this.lb_CI1_name);
            this.gp_Itembox.Controls.Add(this.lb_CI1_state);
            this.gp_Itembox.Controls.Add(this.lb_LI2_name);
            this.gp_Itembox.Controls.Add(this.lb_LI2_state);
            this.gp_Itembox.Controls.Add(this.lb_LI1_name);
            this.gp_Itembox.Controls.Add(this.lb_LI1_state);
            this.gp_Itembox.Controls.Add(this.lb_BI2_name);
            this.gp_Itembox.Controls.Add(this.lb_BI2_state);
            this.gp_Itembox.Controls.Add(this.lb_BI1_name);
            this.gp_Itembox.Controls.Add(this.lb_BI1_state);
            this.gp_Itembox.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Itembox.Location = new System.Drawing.Point(282, 313);
            this.gp_Itembox.Name = "gp_Itembox";
            this.gp_Itembox.Size = new System.Drawing.Size(866, 80);
            this.gp_Itembox.TabIndex = 30;
            this.gp_Itembox.TabStop = false;
            this.gp_Itembox.Text = "아이템박스(I)";
            // 
            // btn_Itembox_send
            // 
            this.btn_Itembox_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Itembox_send.Location = new System.Drawing.Point(66, 22);
            this.btn_Itembox_send.Name = "btn_Itembox_send";
            this.btn_Itembox_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Itembox_send.TabIndex = 32;
            this.btn_Itembox_send.Text = "전송";
            this.btn_Itembox_send.UseVisualStyleBackColor = true;
            // 
            // lb_TI2_name
            // 
            this.lb_TI2_name.AutoSize = true;
            this.lb_TI2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TI2_name.Location = new System.Drawing.Point(807, 22);
            this.lb_TI2_name.Name = "lb_TI2_name";
            this.lb_TI2_name.Size = new System.Drawing.Size(55, 19);
            this.lb_TI2_name.TabIndex = 28;
            this.lb_TI2_name.Text = "__TI2__";
            // 
            // cb_Itembox_state
            // 
            this.cb_Itembox_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Itembox_state.FormattingEnabled = true;
            this.cb_Itembox_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "아이템박스 봉쇄",
            "아이템박스 오픈"});
            this.cb_Itembox_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Itembox_state.Name = "cb_Itembox_state";
            this.cb_Itembox_state.Size = new System.Drawing.Size(116, 23);
            this.cb_Itembox_state.TabIndex = 31;
            // 
            // lb_TI2_state
            // 
            this.lb_TI2_state.AutoSize = true;
            this.lb_TI2_state.BackColor = System.Drawing.Color.DimGray;
            this.lb_TI2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TI2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TI2_state.Location = new System.Drawing.Point(802, 42);
            this.lb_TI2_state.Name = "lb_TI2_state";
            this.lb_TI2_state.Size = new System.Drawing.Size(59, 16);
            this.lb_TI2_state.TabIndex = 29;
            this.lb_TI2_state.Text = "사용안함";
            // 
            // cb_Itembox_name
            // 
            this.cb_Itembox_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Itembox_name.FormattingEnabled = true;
            this.cb_Itembox_name.Items.AddRange(new object[] {
            "ALL",
            "BI1",
            "BI2",
            "LI1",
            "LI2",
            "CI1",
            "CI2",
            "SI1",
            "SI2",
            "TI1",
            "TI2"});
            this.cb_Itembox_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Itembox_name.Name = "cb_Itembox_name";
            this.cb_Itembox_name.Size = new System.Drawing.Size(54, 23);
            this.cb_Itembox_name.TabIndex = 30;
            // 
            // lb_TI1_name
            // 
            this.lb_TI1_name.AutoSize = true;
            this.lb_TI1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TI1_name.Location = new System.Drawing.Point(729, 22);
            this.lb_TI1_name.Name = "lb_TI1_name";
            this.lb_TI1_name.Size = new System.Drawing.Size(55, 19);
            this.lb_TI1_name.TabIndex = 26;
            this.lb_TI1_name.Text = "__TI1__";
            // 
            // lb_TI1_state
            // 
            this.lb_TI1_state.AutoSize = true;
            this.lb_TI1_state.BackColor = System.Drawing.Color.Black;
            this.lb_TI1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TI1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TI1_state.Location = new System.Drawing.Point(725, 42);
            this.lb_TI1_state.Name = "lb_TI1_state";
            this.lb_TI1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TI1_state.TabIndex = 27;
            this.lb_TI1_state.Text = "OFFLINE";
            // 
            // lb_SI2_name
            // 
            this.lb_SI2_name.AutoSize = true;
            this.lb_SI2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SI2_name.Location = new System.Drawing.Point(659, 22);
            this.lb_SI2_name.Name = "lb_SI2_name";
            this.lb_SI2_name.Size = new System.Drawing.Size(56, 19);
            this.lb_SI2_name.TabIndex = 24;
            this.lb_SI2_name.Text = "__SI2__";
            // 
            // lb_SI2_state
            // 
            this.lb_SI2_state.AutoSize = true;
            this.lb_SI2_state.BackColor = System.Drawing.Color.Black;
            this.lb_SI2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SI2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SI2_state.Location = new System.Drawing.Point(654, 41);
            this.lb_SI2_state.Name = "lb_SI2_state";
            this.lb_SI2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SI2_state.TabIndex = 25;
            this.lb_SI2_state.Text = "OFFLINE";
            // 
            // lb_SI1_name
            // 
            this.lb_SI1_name.AutoSize = true;
            this.lb_SI1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SI1_name.Location = new System.Drawing.Point(582, 22);
            this.lb_SI1_name.Name = "lb_SI1_name";
            this.lb_SI1_name.Size = new System.Drawing.Size(56, 19);
            this.lb_SI1_name.TabIndex = 22;
            this.lb_SI1_name.Text = "__SI1__";
            // 
            // lb_SI1_state
            // 
            this.lb_SI1_state.AutoSize = true;
            this.lb_SI1_state.BackColor = System.Drawing.Color.Black;
            this.lb_SI1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SI1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SI1_state.Location = new System.Drawing.Point(577, 42);
            this.lb_SI1_state.Name = "lb_SI1_state";
            this.lb_SI1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SI1_state.TabIndex = 23;
            this.lb_SI1_state.Text = "OFFLINE";
            // 
            // lb_CI2_name
            // 
            this.lb_CI2_name.AutoSize = true;
            this.lb_CI2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CI2_name.Location = new System.Drawing.Point(512, 22);
            this.lb_CI2_name.Name = "lb_CI2_name";
            this.lb_CI2_name.Size = new System.Drawing.Size(56, 19);
            this.lb_CI2_name.TabIndex = 20;
            this.lb_CI2_name.Text = "__CI2__";
            // 
            // lb_CI2_state
            // 
            this.lb_CI2_state.AutoSize = true;
            this.lb_CI2_state.BackColor = System.Drawing.Color.Black;
            this.lb_CI2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CI2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CI2_state.Location = new System.Drawing.Point(507, 41);
            this.lb_CI2_state.Name = "lb_CI2_state";
            this.lb_CI2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CI2_state.TabIndex = 21;
            this.lb_CI2_state.Text = "OFFLINE";
            // 
            // lb_CI1_name
            // 
            this.lb_CI1_name.AutoSize = true;
            this.lb_CI1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CI1_name.Location = new System.Drawing.Point(442, 22);
            this.lb_CI1_name.Name = "lb_CI1_name";
            this.lb_CI1_name.Size = new System.Drawing.Size(56, 19);
            this.lb_CI1_name.TabIndex = 18;
            this.lb_CI1_name.Text = "__CI1__";
            // 
            // lb_CI1_state
            // 
            this.lb_CI1_state.AutoSize = true;
            this.lb_CI1_state.BackColor = System.Drawing.Color.Black;
            this.lb_CI1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CI1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CI1_state.Location = new System.Drawing.Point(437, 42);
            this.lb_CI1_state.Name = "lb_CI1_state";
            this.lb_CI1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CI1_state.TabIndex = 19;
            this.lb_CI1_state.Text = "OFFLINE";
            // 
            // lb_LI2_name
            // 
            this.lb_LI2_name.AutoSize = true;
            this.lb_LI2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LI2_name.Location = new System.Drawing.Point(366, 22);
            this.lb_LI2_name.Name = "lb_LI2_name";
            this.lb_LI2_name.Size = new System.Drawing.Size(55, 19);
            this.lb_LI2_name.TabIndex = 16;
            this.lb_LI2_name.Text = "__LI2__";
            // 
            // lb_LI2_state
            // 
            this.lb_LI2_state.AutoSize = true;
            this.lb_LI2_state.BackColor = System.Drawing.Color.DimGray;
            this.lb_LI2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LI2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LI2_state.Location = new System.Drawing.Point(364, 42);
            this.lb_LI2_state.Name = "lb_LI2_state";
            this.lb_LI2_state.Size = new System.Drawing.Size(59, 16);
            this.lb_LI2_state.TabIndex = 17;
            this.lb_LI2_state.Text = "사용안함";
            // 
            // lb_LI1_name
            // 
            this.lb_LI1_name.AutoSize = true;
            this.lb_LI1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LI1_name.Location = new System.Drawing.Point(288, 22);
            this.lb_LI1_name.Name = "lb_LI1_name";
            this.lb_LI1_name.Size = new System.Drawing.Size(55, 19);
            this.lb_LI1_name.TabIndex = 14;
            this.lb_LI1_name.Text = "__LI1__";
            // 
            // lb_LI1_state
            // 
            this.lb_LI1_state.AutoSize = true;
            this.lb_LI1_state.BackColor = System.Drawing.Color.Black;
            this.lb_LI1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LI1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LI1_state.Location = new System.Drawing.Point(284, 42);
            this.lb_LI1_state.Name = "lb_LI1_state";
            this.lb_LI1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LI1_state.TabIndex = 15;
            this.lb_LI1_state.Text = "OFFLINE";
            // 
            // lb_BI2_name
            // 
            this.lb_BI2_name.AutoSize = true;
            this.lb_BI2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BI2_name.Location = new System.Drawing.Point(213, 22);
            this.lb_BI2_name.Name = "lb_BI2_name";
            this.lb_BI2_name.Size = new System.Drawing.Size(56, 19);
            this.lb_BI2_name.TabIndex = 12;
            this.lb_BI2_name.Text = "__BI2__";
            // 
            // lb_BI2_state
            // 
            this.lb_BI2_state.AutoSize = true;
            this.lb_BI2_state.BackColor = System.Drawing.Color.Black;
            this.lb_BI2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BI2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BI2_state.Location = new System.Drawing.Point(211, 42);
            this.lb_BI2_state.Name = "lb_BI2_state";
            this.lb_BI2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BI2_state.TabIndex = 13;
            this.lb_BI2_state.Text = "OFFLINE";
            // 
            // lb_BI1_name
            // 
            this.lb_BI1_name.AutoSize = true;
            this.lb_BI1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BI1_name.Location = new System.Drawing.Point(139, 22);
            this.lb_BI1_name.Name = "lb_BI1_name";
            this.lb_BI1_name.Size = new System.Drawing.Size(56, 19);
            this.lb_BI1_name.TabIndex = 0;
            this.lb_BI1_name.Text = "__BI1__";
            // 
            // lb_BI1_state
            // 
            this.lb_BI1_state.AutoSize = true;
            this.lb_BI1_state.BackColor = System.Drawing.Color.Black;
            this.lb_BI1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BI1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BI1_state.Location = new System.Drawing.Point(136, 42);
            this.lb_BI1_state.Name = "lb_BI1_state";
            this.lb_BI1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BI1_state.TabIndex = 5;
            this.lb_BI1_state.Text = "OFFLINE";
            // 
            // gp_Generator
            // 
            this.gp_Generator.BackColor = System.Drawing.Color.LightGray;
            this.gp_Generator.Controls.Add(this.btn_Generator_send);
            this.gp_Generator.Controls.Add(this.lb_TG_name);
            this.gp_Generator.Controls.Add(this.cb_Generator_state);
            this.gp_Generator.Controls.Add(this.lb_TG_state);
            this.gp_Generator.Controls.Add(this.cb_Generator_name);
            this.gp_Generator.Controls.Add(this.lb_SG_name);
            this.gp_Generator.Controls.Add(this.lb_CG_name);
            this.gp_Generator.Controls.Add(this.lb_LG_name);
            this.gp_Generator.Controls.Add(this.lb_BG_name);
            this.gp_Generator.Controls.Add(this.lb_SG_state);
            this.gp_Generator.Controls.Add(this.lb_CG_state);
            this.gp_Generator.Controls.Add(this.lb_LG_state);
            this.gp_Generator.Controls.Add(this.lb_BG_state);
            this.gp_Generator.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Generator.Location = new System.Drawing.Point(282, 55);
            this.gp_Generator.Name = "gp_Generator";
            this.gp_Generator.Size = new System.Drawing.Size(866, 80);
            this.gp_Generator.TabIndex = 5;
            this.gp_Generator.TabStop = false;
            this.gp_Generator.Text = "발전기(G)";
            // 
            // btn_Generator_send
            // 
            this.btn_Generator_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generator_send.Location = new System.Drawing.Point(66, 20);
            this.btn_Generator_send.Name = "btn_Generator_send";
            this.btn_Generator_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Generator_send.TabIndex = 35;
            this.btn_Generator_send.Text = "전송";
            this.btn_Generator_send.UseVisualStyleBackColor = true;
            // 
            // lb_TG_name
            // 
            this.lb_TG_name.AutoSize = true;
            this.lb_TG_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TG_name.Location = new System.Drawing.Point(734, 21);
            this.lb_TG_name.Name = "lb_TG_name";
            this.lb_TG_name.Size = new System.Drawing.Size(122, 19);
            this.lb_TG_name.TabIndex = 4;
            this.lb_TG_name.Text = "_______TG_______";
            // 
            // cb_Generator_state
            // 
            this.cb_Generator_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Generator_state.FormattingEnabled = true;
            this.cb_Generator_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "배선수리 완료",
            "전체수리 완료",
            "발전기 봉쇄"});
            this.cb_Generator_state.Location = new System.Drawing.Point(6, 49);
            this.cb_Generator_state.Name = "cb_Generator_state";
            this.cb_Generator_state.Size = new System.Drawing.Size(116, 23);
            this.cb_Generator_state.TabIndex = 34;
            // 
            // lb_TG_state
            // 
            this.lb_TG_state.AutoSize = true;
            this.lb_TG_state.BackColor = System.Drawing.Color.Black;
            this.lb_TG_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_TG_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TG_state.Location = new System.Drawing.Point(763, 41);
            this.lb_TG_state.Name = "lb_TG_state";
            this.lb_TG_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TG_state.TabIndex = 9;
            this.lb_TG_state.Text = "OFFLINE";
            // 
            // cb_Generator_name
            // 
            this.cb_Generator_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Generator_name.FormattingEnabled = true;
            this.cb_Generator_name.Items.AddRange(new object[] {
            "ALL",
            "BG",
            "LG",
            "CG",
            "SG",
            "TG"});
            this.cb_Generator_name.Location = new System.Drawing.Point(6, 21);
            this.cb_Generator_name.Name = "cb_Generator_name";
            this.cb_Generator_name.Size = new System.Drawing.Size(54, 23);
            this.cb_Generator_name.TabIndex = 33;
            // 
            // lb_SG_name
            // 
            this.lb_SG_name.AutoSize = true;
            this.lb_SG_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SG_name.Location = new System.Drawing.Point(585, 21);
            this.lb_SG_name.Name = "lb_SG_name";
            this.lb_SG_name.Size = new System.Drawing.Size(123, 19);
            this.lb_SG_name.TabIndex = 3;
            this.lb_SG_name.Text = "_______SG_______";
            // 
            // lb_CG_name
            // 
            this.lb_CG_name.AutoSize = true;
            this.lb_CG_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CG_name.Location = new System.Drawing.Point(437, 21);
            this.lb_CG_name.Name = "lb_CG_name";
            this.lb_CG_name.Size = new System.Drawing.Size(130, 19);
            this.lb_CG_name.TabIndex = 2;
            this.lb_CG_name.Text = "________CG_______";
            // 
            // lb_LG_name
            // 
            this.lb_LG_name.AutoSize = true;
            this.lb_LG_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LG_name.Location = new System.Drawing.Point(292, 21);
            this.lb_LG_name.Name = "lb_LG_name";
            this.lb_LG_name.Size = new System.Drawing.Size(122, 19);
            this.lb_LG_name.TabIndex = 1;
            this.lb_LG_name.Text = "_______LG_______";
            // 
            // lb_BG_name
            // 
            this.lb_BG_name.AutoSize = true;
            this.lb_BG_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BG_name.Location = new System.Drawing.Point(142, 21);
            this.lb_BG_name.Name = "lb_BG_name";
            this.lb_BG_name.Size = new System.Drawing.Size(123, 19);
            this.lb_BG_name.TabIndex = 0;
            this.lb_BG_name.Text = "_______BG_______";
            // 
            // lb_SG_state
            // 
            this.lb_SG_state.AutoSize = true;
            this.lb_SG_state.BackColor = System.Drawing.Color.Black;
            this.lb_SG_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_SG_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SG_state.Location = new System.Drawing.Point(614, 41);
            this.lb_SG_state.Name = "lb_SG_state";
            this.lb_SG_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SG_state.TabIndex = 8;
            this.lb_SG_state.Text = "OFFLINE";
            // 
            // lb_CG_state
            // 
            this.lb_CG_state.AutoSize = true;
            this.lb_CG_state.BackColor = System.Drawing.Color.Black;
            this.lb_CG_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CG_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CG_state.Location = new System.Drawing.Point(474, 41);
            this.lb_CG_state.Name = "lb_CG_state";
            this.lb_CG_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CG_state.TabIndex = 7;
            this.lb_CG_state.Text = "OFFLINE";
            // 
            // lb_LG_state
            // 
            this.lb_LG_state.AutoSize = true;
            this.lb_LG_state.BackColor = System.Drawing.Color.Black;
            this.lb_LG_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_LG_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LG_state.Location = new System.Drawing.Point(320, 42);
            this.lb_LG_state.Name = "lb_LG_state";
            this.lb_LG_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LG_state.TabIndex = 6;
            this.lb_LG_state.Text = "OFFLINE";
            // 
            // lb_BG_state
            // 
            this.lb_BG_state.AutoSize = true;
            this.lb_BG_state.BackColor = System.Drawing.Color.Black;
            this.lb_BG_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BG_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BG_state.Location = new System.Drawing.Point(172, 42);
            this.lb_BG_state.Name = "lb_BG_state";
            this.lb_BG_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BG_state.TabIndex = 5;
            this.lb_BG_state.Text = "OFFLINE";
            // 
            // cb_serialPort_PCM
            // 
            this.cb_serialPort_PCM.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_serialPort_PCM.FormattingEnabled = true;
            this.cb_serialPort_PCM.Location = new System.Drawing.Point(6, 928);
            this.cb_serialPort_PCM.Name = "cb_serialPort_PCM";
            this.cb_serialPort_PCM.Size = new System.Drawing.Size(270, 27);
            this.cb_serialPort_PCM.TabIndex = 4;
            this.cb_serialPort_PCM.Text = "기본세팅: COM17";
            // 
            // lb_serialPort_PCM
            // 
            this.lb_serialPort_PCM.AutoSize = true;
            this.lb_serialPort_PCM.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_serialPort_PCM.Location = new System.Drawing.Point(6, 906);
            this.lb_serialPort_PCM.Name = "lb_serialPort_PCM";
            this.lb_serialPort_PCM.Size = new System.Drawing.Size(186, 16);
            this.lb_serialPort_PCM.TabIndex = 3;
            this.lb_serialPort_PCM.Text = "GAME 시스템을 연결해주세요";
            // 
            // gp_Vent
            // 
            this.gp_Vent.BackColor = System.Drawing.Color.LightGray;
            this.gp_Vent.Controls.Add(this.lb_CV_name);
            this.gp_Vent.Controls.Add(this.lb_CV_state);
            this.gp_Vent.Controls.Add(this.lb_TV_name);
            this.gp_Vent.Controls.Add(this.lb_TV_state);
            this.gp_Vent.Controls.Add(this.lb_SV_name);
            this.gp_Vent.Controls.Add(this.lb_SV_state);
            this.gp_Vent.Controls.Add(this.lb_BV2_name);
            this.gp_Vent.Controls.Add(this.btn_Vent_send);
            this.gp_Vent.Controls.Add(this.lb_BV2_state);
            this.gp_Vent.Controls.Add(this.lb_LV_name);
            this.gp_Vent.Controls.Add(this.lb_BV1_name);
            this.gp_Vent.Controls.Add(this.lb_BV1_state);
            this.gp_Vent.Controls.Add(this.cb_Vent_state);
            this.gp_Vent.Controls.Add(this.cb_Vent_name);
            this.gp_Vent.Controls.Add(this.lb_LV_state);
            this.gp_Vent.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Vent.Location = new System.Drawing.Point(282, 485);
            this.gp_Vent.Name = "gp_Vent";
            this.gp_Vent.Size = new System.Drawing.Size(866, 80);
            this.gp_Vent.TabIndex = 43;
            this.gp_Vent.TabStop = false;
            this.gp_Vent.Text = "덕트 (V)";
            // 
            // lb_CV_name
            // 
            this.lb_CV_name.AutoSize = true;
            this.lb_CV_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CV_name.Location = new System.Drawing.Point(436, 22);
            this.lb_CV_name.Name = "lb_CV_name";
            this.lb_CV_name.Size = new System.Drawing.Size(129, 19);
            this.lb_CV_name.TabIndex = 44;
            this.lb_CV_name.Text = "________CV_______";
            // 
            // lb_CV_state
            // 
            this.lb_CV_state.AutoSize = true;
            this.lb_CV_state.BackColor = System.Drawing.Color.Black;
            this.lb_CV_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CV_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CV_state.Location = new System.Drawing.Point(472, 42);
            this.lb_CV_state.Name = "lb_CV_state";
            this.lb_CV_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CV_state.TabIndex = 45;
            this.lb_CV_state.Text = "OFFLINE";
            // 
            // lb_TV_name
            // 
            this.lb_TV_name.AutoSize = true;
            this.lb_TV_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TV_name.Location = new System.Drawing.Point(734, 22);
            this.lb_TV_name.Name = "lb_TV_name";
            this.lb_TV_name.Size = new System.Drawing.Size(121, 19);
            this.lb_TV_name.TabIndex = 42;
            this.lb_TV_name.Text = "_______TV_______";
            // 
            // lb_TV_state
            // 
            this.lb_TV_state.AutoSize = true;
            this.lb_TV_state.BackColor = System.Drawing.Color.Black;
            this.lb_TV_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TV_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TV_state.Location = new System.Drawing.Point(764, 42);
            this.lb_TV_state.Name = "lb_TV_state";
            this.lb_TV_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TV_state.TabIndex = 43;
            this.lb_TV_state.Text = "OFFLINE";
            // 
            // lb_SV_name
            // 
            this.lb_SV_name.AutoSize = true;
            this.lb_SV_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SV_name.Location = new System.Drawing.Point(584, 22);
            this.lb_SV_name.Name = "lb_SV_name";
            this.lb_SV_name.Size = new System.Drawing.Size(122, 19);
            this.lb_SV_name.TabIndex = 42;
            this.lb_SV_name.Text = "_______SV_______";
            // 
            // lb_SV_state
            // 
            this.lb_SV_state.AutoSize = true;
            this.lb_SV_state.BackColor = System.Drawing.Color.Black;
            this.lb_SV_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SV_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SV_state.Location = new System.Drawing.Point(615, 42);
            this.lb_SV_state.Name = "lb_SV_state";
            this.lb_SV_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SV_state.TabIndex = 43;
            this.lb_SV_state.Text = "OFFLINE";
            // 
            // lb_BV2_name
            // 
            this.lb_BV2_name.AutoSize = true;
            this.lb_BV2_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BV2_name.Location = new System.Drawing.Point(213, 22);
            this.lb_BV2_name.Name = "lb_BV2_name";
            this.lb_BV2_name.Size = new System.Drawing.Size(59, 19);
            this.lb_BV2_name.TabIndex = 35;
            this.lb_BV2_name.Text = "__BV2__";
            // 
            // btn_Vent_send
            // 
            this.btn_Vent_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vent_send.Location = new System.Drawing.Point(67, 22);
            this.btn_Vent_send.Name = "btn_Vent_send";
            this.btn_Vent_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Vent_send.TabIndex = 41;
            this.btn_Vent_send.Text = "전송";
            this.btn_Vent_send.UseVisualStyleBackColor = true;
            // 
            // lb_BV2_state
            // 
            this.lb_BV2_state.AutoSize = true;
            this.lb_BV2_state.BackColor = System.Drawing.Color.Black;
            this.lb_BV2_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BV2_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BV2_state.Location = new System.Drawing.Point(212, 41);
            this.lb_BV2_state.Name = "lb_BV2_state";
            this.lb_BV2_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BV2_state.TabIndex = 36;
            this.lb_BV2_state.Text = "OFFLINE";
            // 
            // lb_LV_name
            // 
            this.lb_LV_name.AutoSize = true;
            this.lb_LV_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LV_name.Location = new System.Drawing.Point(290, 22);
            this.lb_LV_name.Name = "lb_LV_name";
            this.lb_LV_name.Size = new System.Drawing.Size(128, 19);
            this.lb_LV_name.TabIndex = 1;
            this.lb_LV_name.Text = "________LV_______";
            // 
            // lb_BV1_name
            // 
            this.lb_BV1_name.AutoSize = true;
            this.lb_BV1_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BV1_name.Location = new System.Drawing.Point(139, 22);
            this.lb_BV1_name.Name = "lb_BV1_name";
            this.lb_BV1_name.Size = new System.Drawing.Size(59, 19);
            this.lb_BV1_name.TabIndex = 33;
            this.lb_BV1_name.Text = "__BV1__";
            // 
            // lb_BV1_state
            // 
            this.lb_BV1_state.AutoSize = true;
            this.lb_BV1_state.BackColor = System.Drawing.Color.Black;
            this.lb_BV1_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BV1_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BV1_state.Location = new System.Drawing.Point(137, 42);
            this.lb_BV1_state.Name = "lb_BV1_state";
            this.lb_BV1_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BV1_state.TabIndex = 34;
            this.lb_BV1_state.Text = "OFFLINE";
            // 
            // cb_Vent_state
            // 
            this.cb_Vent_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vent_state.FormattingEnabled = true;
            this.cb_Vent_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "덕트 봉쇄",
            "덕트 오픈"});
            this.cb_Vent_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Vent_state.Name = "cb_Vent_state";
            this.cb_Vent_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Vent_state.TabIndex = 40;
            // 
            // cb_Vent_name
            // 
            this.cb_Vent_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vent_name.FormattingEnabled = true;
            this.cb_Vent_name.Items.AddRange(new object[] {
            "ALL",
            "BV1",
            "BV2",
            "LV",
            "CV",
            "SV",
            "TV"});
            this.cb_Vent_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Vent_name.Name = "cb_Vent_name";
            this.cb_Vent_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Vent_name.TabIndex = 39;
            // 
            // lb_LV_state
            // 
            this.lb_LV_state.AutoSize = true;
            this.lb_LV_state.BackColor = System.Drawing.Color.Black;
            this.lb_LV_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LV_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LV_state.Location = new System.Drawing.Point(326, 42);
            this.lb_LV_state.Name = "lb_LV_state";
            this.lb_LV_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LV_state.TabIndex = 6;
            this.lb_LV_state.Text = "OFFLINE";
            // 
            // gp_Door
            // 
            this.gp_Door.BackColor = System.Drawing.Color.LightGray;
            this.gp_Door.Controls.Add(this.lb_TD_name);
            this.gp_Door.Controls.Add(this.lb_TD_state);
            this.gp_Door.Controls.Add(this.lb_SD_name);
            this.gp_Door.Controls.Add(this.lb_SD_state);
            this.gp_Door.Controls.Add(this.lb_GD_name);
            this.gp_Door.Controls.Add(this.btn_Door_send);
            this.gp_Door.Controls.Add(this.lb_GD_state);
            this.gp_Door.Controls.Add(this.lb_LD_name);
            this.gp_Door.Controls.Add(this.cb_Door_state);
            this.gp_Door.Controls.Add(this.cb_Door_name);
            this.gp_Door.Controls.Add(this.lb_LD_state);
            this.gp_Door.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Door.Location = new System.Drawing.Point(282, 399);
            this.gp_Door.Name = "gp_Door";
            this.gp_Door.Size = new System.Drawing.Size(866, 80);
            this.gp_Door.TabIndex = 42;
            this.gp_Door.TabStop = false;
            this.gp_Door.Text = "게임도어 (D)";
            // 
            // lb_TD_name
            // 
            this.lb_TD_name.AutoSize = true;
            this.lb_TD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TD_name.Location = new System.Drawing.Point(733, 23);
            this.lb_TD_name.Name = "lb_TD_name";
            this.lb_TD_name.Size = new System.Drawing.Size(122, 19);
            this.lb_TD_name.TabIndex = 39;
            this.lb_TD_name.Text = "_______TD_______";
            // 
            // lb_TD_state
            // 
            this.lb_TD_state.AutoSize = true;
            this.lb_TD_state.BackColor = System.Drawing.Color.Black;
            this.lb_TD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TD_state.Location = new System.Drawing.Point(764, 43);
            this.lb_TD_state.Name = "lb_TD_state";
            this.lb_TD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TD_state.TabIndex = 40;
            this.lb_TD_state.Text = "OFFLINE";
            // 
            // lb_SD_name
            // 
            this.lb_SD_name.AutoSize = true;
            this.lb_SD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SD_name.Location = new System.Drawing.Point(584, 22);
            this.lb_SD_name.Name = "lb_SD_name";
            this.lb_SD_name.Size = new System.Drawing.Size(123, 19);
            this.lb_SD_name.TabIndex = 39;
            this.lb_SD_name.Text = "_______SD_______";
            // 
            // lb_SD_state
            // 
            this.lb_SD_state.AutoSize = true;
            this.lb_SD_state.BackColor = System.Drawing.Color.Black;
            this.lb_SD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SD_state.Location = new System.Drawing.Point(614, 42);
            this.lb_SD_state.Name = "lb_SD_state";
            this.lb_SD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SD_state.TabIndex = 40;
            this.lb_SD_state.Text = "OFFLINE";
            // 
            // lb_GD_name
            // 
            this.lb_GD_name.AutoSize = true;
            this.lb_GD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GD_name.Location = new System.Drawing.Point(142, 22);
            this.lb_GD_name.Name = "lb_GD_name";
            this.lb_GD_name.Size = new System.Drawing.Size(123, 19);
            this.lb_GD_name.TabIndex = 39;
            this.lb_GD_name.Text = "_______GD_______";
            // 
            // btn_Door_send
            // 
            this.btn_Door_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Door_send.Location = new System.Drawing.Point(67, 22);
            this.btn_Door_send.Name = "btn_Door_send";
            this.btn_Door_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Door_send.TabIndex = 41;
            this.btn_Door_send.Text = "전송";
            this.btn_Door_send.UseVisualStyleBackColor = true;
            // 
            // lb_GD_state
            // 
            this.lb_GD_state.AutoSize = true;
            this.lb_GD_state.BackColor = System.Drawing.Color.Black;
            this.lb_GD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_GD_state.Location = new System.Drawing.Point(172, 42);
            this.lb_GD_state.Name = "lb_GD_state";
            this.lb_GD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_GD_state.TabIndex = 40;
            this.lb_GD_state.Text = "OFFLINE";
            // 
            // lb_LD_name
            // 
            this.lb_LD_name.AutoSize = true;
            this.lb_LD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LD_name.Location = new System.Drawing.Point(289, 22);
            this.lb_LD_name.Name = "lb_LD_name";
            this.lb_LD_name.Size = new System.Drawing.Size(129, 19);
            this.lb_LD_name.TabIndex = 1;
            this.lb_LD_name.Text = "________LD_______";
            // 
            // cb_Door_state
            // 
            this.cb_Door_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Door_state.FormattingEnabled = true;
            this.cb_Door_state.Items.AddRange(new object[] {
            "술래결정 전",
            "술래결정 후",
            "게임 종료",
            "테스트",
            "생명장치 봉쇄",
            "자가부활 모드",
            ""});
            this.cb_Door_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Door_state.Name = "cb_Door_state";
            this.cb_Door_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Door_state.TabIndex = 40;
            // 
            // cb_Door_name
            // 
            this.cb_Door_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Door_name.FormattingEnabled = true;
            this.cb_Door_name.Items.AddRange(new object[] {
            "ALL",
            "BR1",
            "BR2",
            "LR1",
            "LR2",
            "CR1",
            "CR2",
            "SR1",
            "SR2",
            "TR1",
            "TR2"});
            this.cb_Door_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Door_name.Name = "cb_Door_name";
            this.cb_Door_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Door_name.TabIndex = 39;
            // 
            // lb_LD_state
            // 
            this.lb_LD_state.AutoSize = true;
            this.lb_LD_state.BackColor = System.Drawing.Color.Black;
            this.lb_LD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LD_state.Location = new System.Drawing.Point(326, 42);
            this.lb_LD_state.Name = "lb_LD_state";
            this.lb_LD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LD_state.TabIndex = 6;
            this.lb_LD_state.Text = "OFFLINE";
            // 
            // gp_Temple
            // 
            this.gp_Temple.BackColor = System.Drawing.Color.LightGray;
            this.gp_Temple.Controls.Add(this.btn_Temple_send);
            this.gp_Temple.Controls.Add(this.lb_LT_name);
            this.gp_Temple.Controls.Add(this.cb_Temple_state);
            this.gp_Temple.Controls.Add(this.cb_Temple_name);
            this.gp_Temple.Controls.Add(this.lb_LT_state);
            this.gp_Temple.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Temple.Location = new System.Drawing.Point(282, 571);
            this.gp_Temple.Name = "gp_Temple";
            this.gp_Temple.Size = new System.Drawing.Size(866, 80);
            this.gp_Temple.TabIndex = 12;
            this.gp_Temple.TabStop = false;
            this.gp_Temple.Text = "제단 (T)";
            // 
            // btn_Temple_send
            // 
            this.btn_Temple_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Temple_send.Location = new System.Drawing.Point(67, 22);
            this.btn_Temple_send.Name = "btn_Temple_send";
            this.btn_Temple_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Temple_send.TabIndex = 41;
            this.btn_Temple_send.Text = "전송";
            this.btn_Temple_send.UseVisualStyleBackColor = true;
            // 
            // lb_LT_name
            // 
            this.lb_LT_name.AutoSize = true;
            this.lb_LT_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LT_name.Location = new System.Drawing.Point(290, 22);
            this.lb_LT_name.Name = "lb_LT_name";
            this.lb_LT_name.Size = new System.Drawing.Size(128, 19);
            this.lb_LT_name.TabIndex = 1;
            this.lb_LT_name.Text = "________LT_______";
            // 
            // cb_Temple_state
            // 
            this.cb_Temple_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Temple_state.FormattingEnabled = true;
            this.cb_Temple_state.Items.AddRange(new object[] {
            "비활성화",
            "활성화",
            "세팅모드",
            "상태확인",
            "제단 활성화"});
            this.cb_Temple_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Temple_state.Name = "cb_Temple_state";
            this.cb_Temple_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Temple_state.TabIndex = 40;
            // 
            // cb_Temple_name
            // 
            this.cb_Temple_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Temple_name.FormattingEnabled = true;
            this.cb_Temple_name.Items.AddRange(new object[] {
            "LT"});
            this.cb_Temple_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Temple_name.Name = "cb_Temple_name";
            this.cb_Temple_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Temple_name.TabIndex = 39;
            // 
            // lb_LT_state
            // 
            this.lb_LT_state.AutoSize = true;
            this.lb_LT_state.BackColor = System.Drawing.Color.Black;
            this.lb_LT_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LT_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LT_state.Location = new System.Drawing.Point(326, 43);
            this.lb_LT_state.Name = "lb_LT_state";
            this.lb_LT_state.Size = new System.Drawing.Size(64, 16);
            this.lb_LT_state.TabIndex = 6;
            this.lb_LT_state.Text = "OFFLINE";
            // 
            // gp_ExerciseSys
            // 
            this.gp_ExerciseSys.Controls.Add(this.label66);
            this.gp_ExerciseSys.Controls.Add(this.label64);
            this.gp_ExerciseSys.Controls.Add(this.lb_logo);
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_MachineSend);
            this.gp_ExerciseSys.Controls.Add(this.cb_ExerciseSys_MachineState);
            this.gp_ExerciseSys.Controls.Add(this.cb_ExerciseSys_MachineName);
            this.gp_ExerciseSys.Controls.Add(this.gp_ExerciseSys_Machine);
            this.gp_ExerciseSys.Controls.Add(this.gp_ExerciseSys_ManualMode);
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_SetupMode);
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_ReadyMode);
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_Start);
            this.gp_ExerciseSys.Controls.Add(this.gp_ExerciseSys_timer);
            this.gp_ExerciseSys.Controls.Add(this.cb_serialPort_TRM);
            this.gp_ExerciseSys.Controls.Add(this.lb_serialPort_TRM);
            this.gp_ExerciseSys.Controls.Add(this.btn_serialPort_TRM_conn);
            this.gp_ExerciseSys.Controls.Add(this.btn_serialPort_TRM_disconn);
            this.gp_ExerciseSys.Controls.Add(this.tb_serialPort_TRM);
            this.gp_ExerciseSys.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ExerciseSys.Location = new System.Drawing.Point(1172, 391);
            this.gp_ExerciseSys.Name = "gp_ExerciseSys";
            this.gp_ExerciseSys.Size = new System.Drawing.Size(735, 623);
            this.gp_ExerciseSys.TabIndex = 8;
            this.gp_ExerciseSys.TabStop = false;
            this.gp_ExerciseSys.Text = "EXERCISE ROOM SYSTEM";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(589, 601);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(130, 19);
            this.label66.TabIndex = 66;
            this.label66.Text = "Main Controller v2.0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(411, 542);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(159, 19);
            this.label64.TabIndex = 64;
            this.label64.Text = "fuzzyline Studio presents";
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Font = new System.Drawing.Font("HelveticaInserat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(404, 552);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(325, 60);
            this.lb_logo.TabIndex = 65;
            this.lb_logo.Text = "HIDE AND SEEK";
            this.lb_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ExerciseSys_MachineSend
            // 
            this.btn_ExerciseSys_MachineSend.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_MachineSend.Location = new System.Drawing.Point(619, 325);
            this.btn_ExerciseSys_MachineSend.Name = "btn_ExerciseSys_MachineSend";
            this.btn_ExerciseSys_MachineSend.Size = new System.Drawing.Size(109, 27);
            this.btn_ExerciseSys_MachineSend.TabIndex = 59;
            this.btn_ExerciseSys_MachineSend.Text = "전송";
            this.btn_ExerciseSys_MachineSend.UseVisualStyleBackColor = true;
            // 
            // cb_ExerciseSys_MachineState
            // 
            this.cb_ExerciseSys_MachineState.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ExerciseSys_MachineState.FormattingEnabled = true;
            this.cb_ExerciseSys_MachineState.Items.AddRange(new object[] {
            "장치 비활성화",
            "장치 활성화",
            "장치 봉쇄",
            "장치 정비 모드"});
            this.cb_ExerciseSys_MachineState.Location = new System.Drawing.Point(457, 356);
            this.cb_ExerciseSys_MachineState.Name = "cb_ExerciseSys_MachineState";
            this.cb_ExerciseSys_MachineState.Size = new System.Drawing.Size(271, 27);
            this.cb_ExerciseSys_MachineState.TabIndex = 63;
            this.cb_ExerciseSys_MachineState.Text = "장치 행동";
            // 
            // cb_ExerciseSys_MachineName
            // 
            this.cb_ExerciseSys_MachineName.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ExerciseSys_MachineName.FormattingEnabled = true;
            this.cb_ExerciseSys_MachineName.Items.AddRange(new object[] {
            "ALL",
            "EG",
            "EE",
            "EI1",
            "EI2",
            "ER1",
            "ED",
            "EV",
            "ET"});
            this.cb_ExerciseSys_MachineName.Location = new System.Drawing.Point(457, 325);
            this.cb_ExerciseSys_MachineName.Name = "cb_ExerciseSys_MachineName";
            this.cb_ExerciseSys_MachineName.Size = new System.Drawing.Size(156, 27);
            this.cb_ExerciseSys_MachineName.TabIndex = 62;
            this.cb_ExerciseSys_MachineName.Text = "장치 종류";
            // 
            // gp_ExerciseSys_Machine
            // 
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ET_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ET);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EV_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EV);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ED_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ED);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EE_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EE);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EG_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EG);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ER1_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ER1);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI2_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI1_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI2);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI1);
            this.gp_ExerciseSys_Machine.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_ExerciseSys_Machine.Location = new System.Drawing.Point(282, 317);
            this.gp_ExerciseSys_Machine.Name = "gp_ExerciseSys_Machine";
            this.gp_ExerciseSys_Machine.Size = new System.Drawing.Size(169, 204);
            this.gp_ExerciseSys_Machine.TabIndex = 61;
            this.gp_ExerciseSys_Machine.TabStop = false;
            this.gp_ExerciseSys_Machine.Text = "훈련소 장치 (E)";
            // 
            // lb_ExerciseSys_ET_State
            // 
            this.lb_ExerciseSys_ET_State.AutoSize = true;
            this.lb_ExerciseSys_ET_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ET_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ET_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ET_State.Location = new System.Drawing.Point(98, 162);
            this.lb_ExerciseSys_ET_State.Name = "lb_ExerciseSys_ET_State";
            this.lb_ExerciseSys_ET_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ET_State.TabIndex = 15;
            this.lb_ExerciseSys_ET_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ET
            // 
            this.lb_ExerciseSys_ET.AutoSize = true;
            this.lb_ExerciseSys_ET.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ET.Location = new System.Drawing.Point(7, 162);
            this.lb_ExerciseSys_ET.Name = "lb_ExerciseSys_ET";
            this.lb_ExerciseSys_ET.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_ET.TabIndex = 14;
            this.lb_ExerciseSys_ET.Text = "ET";
            // 
            // lb_ExerciseSys_EV_State
            // 
            this.lb_ExerciseSys_EV_State.AutoSize = true;
            this.lb_ExerciseSys_EV_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EV_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EV_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EV_State.Location = new System.Drawing.Point(98, 142);
            this.lb_ExerciseSys_EV_State.Name = "lb_ExerciseSys_EV_State";
            this.lb_ExerciseSys_EV_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EV_State.TabIndex = 13;
            this.lb_ExerciseSys_EV_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EV
            // 
            this.lb_ExerciseSys_EV.AutoSize = true;
            this.lb_ExerciseSys_EV.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EV.Location = new System.Drawing.Point(7, 142);
            this.lb_ExerciseSys_EV.Name = "lb_ExerciseSys_EV";
            this.lb_ExerciseSys_EV.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_EV.TabIndex = 12;
            this.lb_ExerciseSys_EV.Text = "EV";
            // 
            // lb_ExerciseSys_ED_State
            // 
            this.lb_ExerciseSys_ED_State.AutoSize = true;
            this.lb_ExerciseSys_ED_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ED_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ED_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ED_State.Location = new System.Drawing.Point(97, 122);
            this.lb_ExerciseSys_ED_State.Name = "lb_ExerciseSys_ED_State";
            this.lb_ExerciseSys_ED_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ED_State.TabIndex = 11;
            this.lb_ExerciseSys_ED_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ED
            // 
            this.lb_ExerciseSys_ED.AutoSize = true;
            this.lb_ExerciseSys_ED.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ED.Location = new System.Drawing.Point(6, 122);
            this.lb_ExerciseSys_ED.Name = "lb_ExerciseSys_ED";
            this.lb_ExerciseSys_ED.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_ED.TabIndex = 10;
            this.lb_ExerciseSys_ED.Text = "ED";
            // 
            // lb_ExerciseSys_EE_State
            // 
            this.lb_ExerciseSys_EE_State.AutoSize = true;
            this.lb_ExerciseSys_EE_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EE_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EE_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EE_State.Location = new System.Drawing.Point(97, 46);
            this.lb_ExerciseSys_EE_State.Name = "lb_ExerciseSys_EE_State";
            this.lb_ExerciseSys_EE_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EE_State.TabIndex = 9;
            this.lb_ExerciseSys_EE_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EE
            // 
            this.lb_ExerciseSys_EE.AutoSize = true;
            this.lb_ExerciseSys_EE.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EE.Location = new System.Drawing.Point(6, 46);
            this.lb_ExerciseSys_EE.Name = "lb_ExerciseSys_EE";
            this.lb_ExerciseSys_EE.Size = new System.Drawing.Size(25, 16);
            this.lb_ExerciseSys_EE.TabIndex = 8;
            this.lb_ExerciseSys_EE.Text = "EE";
            // 
            // lb_ExerciseSys_EG_State
            // 
            this.lb_ExerciseSys_EG_State.AutoSize = true;
            this.lb_ExerciseSys_EG_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EG_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EG_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EG_State.Location = new System.Drawing.Point(97, 26);
            this.lb_ExerciseSys_EG_State.Name = "lb_ExerciseSys_EG_State";
            this.lb_ExerciseSys_EG_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EG_State.TabIndex = 7;
            this.lb_ExerciseSys_EG_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EG
            // 
            this.lb_ExerciseSys_EG.AutoSize = true;
            this.lb_ExerciseSys_EG.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EG.Location = new System.Drawing.Point(6, 26);
            this.lb_ExerciseSys_EG.Name = "lb_ExerciseSys_EG";
            this.lb_ExerciseSys_EG.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_EG.TabIndex = 6;
            this.lb_ExerciseSys_EG.Text = "EG";
            // 
            // lb_ExerciseSys_ER1_State
            // 
            this.lb_ExerciseSys_ER1_State.AutoSize = true;
            this.lb_ExerciseSys_ER1_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ER1_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ER1_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ER1_State.Location = new System.Drawing.Point(97, 102);
            this.lb_ExerciseSys_ER1_State.Name = "lb_ExerciseSys_ER1_State";
            this.lb_ExerciseSys_ER1_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ER1_State.TabIndex = 5;
            this.lb_ExerciseSys_ER1_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ER1
            // 
            this.lb_ExerciseSys_ER1.AutoSize = true;
            this.lb_ExerciseSys_ER1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ER1.Location = new System.Drawing.Point(6, 102);
            this.lb_ExerciseSys_ER1.Name = "lb_ExerciseSys_ER1";
            this.lb_ExerciseSys_ER1.Size = new System.Drawing.Size(36, 16);
            this.lb_ExerciseSys_ER1.TabIndex = 4;
            this.lb_ExerciseSys_ER1.Text = "ER1";
            // 
            // lb_ExerciseSys_EI2_State
            // 
            this.lb_ExerciseSys_EI2_State.AutoSize = true;
            this.lb_ExerciseSys_EI2_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EI2_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI2_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EI2_State.Location = new System.Drawing.Point(97, 82);
            this.lb_ExerciseSys_EI2_State.Name = "lb_ExerciseSys_EI2_State";
            this.lb_ExerciseSys_EI2_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EI2_State.TabIndex = 3;
            this.lb_ExerciseSys_EI2_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EI1_State
            // 
            this.lb_ExerciseSys_EI1_State.AutoSize = true;
            this.lb_ExerciseSys_EI1_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EI1_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI1_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EI1_State.Location = new System.Drawing.Point(97, 66);
            this.lb_ExerciseSys_EI1_State.Name = "lb_ExerciseSys_EI1_State";
            this.lb_ExerciseSys_EI1_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EI1_State.TabIndex = 2;
            this.lb_ExerciseSys_EI1_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EI2
            // 
            this.lb_ExerciseSys_EI2.AutoSize = true;
            this.lb_ExerciseSys_EI2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI2.Location = new System.Drawing.Point(6, 82);
            this.lb_ExerciseSys_EI2.Name = "lb_ExerciseSys_EI2";
            this.lb_ExerciseSys_EI2.Size = new System.Drawing.Size(34, 16);
            this.lb_ExerciseSys_EI2.TabIndex = 1;
            this.lb_ExerciseSys_EI2.Text = "EI 2";
            // 
            // lb_ExerciseSys_EI1
            // 
            this.lb_ExerciseSys_EI1.AutoSize = true;
            this.lb_ExerciseSys_EI1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI1.Location = new System.Drawing.Point(6, 66);
            this.lb_ExerciseSys_EI1.Name = "lb_ExerciseSys_EI1";
            this.lb_ExerciseSys_EI1.Size = new System.Drawing.Size(34, 16);
            this.lb_ExerciseSys_EI1.TabIndex = 0;
            this.lb_ExerciseSys_EI1.Text = "EI 1";
            // 
            // gp_ExerciseSys_ManualMode
            // 
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.button26btn_ExerciseSys_LightOff);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_NarrationPlay);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.cb_ExerciseSys_Narration);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_ExerciseRmOn);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_funcA);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_Stop);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_MovingOn);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_WaitRmOff);
            this.gp_ExerciseSys_ManualMode.Font = new System.Drawing.Font("HelveticaInserat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ExerciseSys_ManualMode.Location = new System.Drawing.Point(282, 192);
            this.gp_ExerciseSys_ManualMode.Name = "gp_ExerciseSys_ManualMode";
            this.gp_ExerciseSys_ManualMode.Size = new System.Drawing.Size(447, 126);
            this.gp_ExerciseSys_ManualMode.TabIndex = 60;
            this.gp_ExerciseSys_ManualMode.TabStop = false;
            this.gp_ExerciseSys_ManualMode.Text = "Manual Mode";
            // 
            // button26btn_ExerciseSys_LightOff
            // 
            this.button26btn_ExerciseSys_LightOff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button26btn_ExerciseSys_LightOff.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button26btn_ExerciseSys_LightOff.Location = new System.Drawing.Point(226, 24);
            this.button26btn_ExerciseSys_LightOff.Name = "button26btn_ExerciseSys_LightOff";
            this.button26btn_ExerciseSys_LightOff.Size = new System.Drawing.Size(62, 65);
            this.button26btn_ExerciseSys_LightOff.TabIndex = 58;
            this.button26btn_ExerciseSys_LightOff.Text = "훈련소\r\n조명\r\nOFF";
            this.button26btn_ExerciseSys_LightOff.UseVisualStyleBackColor = false;
            this.button26btn_ExerciseSys_LightOff.Click += new System.EventHandler(this.button26btn_ExerciseSys_LightOff_Click);
            // 
            // btn_ExerciseSys_NarrationPlay
            // 
            this.btn_ExerciseSys_NarrationPlay.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_NarrationPlay.Location = new System.Drawing.Point(363, 95);
            this.btn_ExerciseSys_NarrationPlay.Name = "btn_ExerciseSys_NarrationPlay";
            this.btn_ExerciseSys_NarrationPlay.Size = new System.Drawing.Size(61, 25);
            this.btn_ExerciseSys_NarrationPlay.TabIndex = 57;
            this.btn_ExerciseSys_NarrationPlay.Text = "출력";
            this.btn_ExerciseSys_NarrationPlay.UseVisualStyleBackColor = true;
            // 
            // cb_ExerciseSys_Narration
            // 
            this.cb_ExerciseSys_Narration.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ExerciseSys_Narration.FormattingEnabled = true;
            this.cb_ExerciseSys_Narration.Items.AddRange(new object[] {
            "한개의 발전기가 수리 되었습니다",
            "탈출 장치 활성화",
            "생명장치 활성화",
            "자가부활 모드 활성화",
            "생존자가 사망했습니다. ",
            "제단이 활성화 됩니다.",
            "술래가 승리했습니다",
            "탈출에 성공했습니다",
            "플레이어가 승리했습니다."});
            this.cb_ExerciseSys_Narration.Location = new System.Drawing.Point(22, 95);
            this.cb_ExerciseSys_Narration.Name = "cb_ExerciseSys_Narration";
            this.cb_ExerciseSys_Narration.Size = new System.Drawing.Size(333, 24);
            this.cb_ExerciseSys_Narration.TabIndex = 56;
            this.cb_ExerciseSys_Narration.Text = "나레이션 선택";
            // 
            // btn_ExerciseSys_ExerciseRmOn
            // 
            this.btn_ExerciseSys_ExerciseRmOn.BackColor = System.Drawing.Color.Khaki;
            this.btn_ExerciseSys_ExerciseRmOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ExerciseRmOn.Location = new System.Drawing.Point(158, 24);
            this.btn_ExerciseSys_ExerciseRmOn.Name = "btn_ExerciseSys_ExerciseRmOn";
            this.btn_ExerciseSys_ExerciseRmOn.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_ExerciseRmOn.TabIndex = 54;
            this.btn_ExerciseSys_ExerciseRmOn.Text = "훈련소\r\n조명\r\nON";
            this.btn_ExerciseSys_ExerciseRmOn.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_ExerciseRmOn.Click += new System.EventHandler(this.btn_ExerciseSys_ExerciseRmOn_Click);
            // 
            // btn_ExerciseSys_funcA
            // 
            this.btn_ExerciseSys_funcA.BackColor = System.Drawing.Color.Khaki;
            this.btn_ExerciseSys_funcA.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_funcA.Location = new System.Drawing.Point(294, 24);
            this.btn_ExerciseSys_funcA.Name = "btn_ExerciseSys_funcA";
            this.btn_ExerciseSys_funcA.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_funcA.TabIndex = 53;
            this.btn_ExerciseSys_funcA.Text = "대기룸\r\n조명\r\nON";
            this.btn_ExerciseSys_funcA.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_funcA.Click += new System.EventHandler(this.btn_ExerciseSys_funcA_Click);
            // 
            // btn_ExerciseSys_Stop
            // 
            this.btn_ExerciseSys_Stop.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_Stop.Location = new System.Drawing.Point(90, 24);
            this.btn_ExerciseSys_Stop.Name = "btn_ExerciseSys_Stop";
            this.btn_ExerciseSys_Stop.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_Stop.TabIndex = 52;
            this.btn_ExerciseSys_Stop.Text = "훈련소 정지";
            this.btn_ExerciseSys_Stop.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_Stop.Click += new System.EventHandler(this.btn_ExerciseSys_Stop_Click);
            // 
            // btn_ExerciseSys_MovingOn
            // 
            this.btn_ExerciseSys_MovingOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_MovingOn.Location = new System.Drawing.Point(22, 24);
            this.btn_ExerciseSys_MovingOn.Name = "btn_ExerciseSys_MovingOn";
            this.btn_ExerciseSys_MovingOn.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_MovingOn.TabIndex = 51;
            this.btn_ExerciseSys_MovingOn.Text = "무빙\r\nON";
            this.btn_ExerciseSys_MovingOn.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_MovingOn.Click += new System.EventHandler(this.btn_ExerciseSys_MovingOn_Click);
            // 
            // btn_ExerciseSys_WaitRmOff
            // 
            this.btn_ExerciseSys_WaitRmOff.BackColor = System.Drawing.Color.DimGray;
            this.btn_ExerciseSys_WaitRmOff.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_WaitRmOff.Location = new System.Drawing.Point(362, 24);
            this.btn_ExerciseSys_WaitRmOff.Name = "btn_ExerciseSys_WaitRmOff";
            this.btn_ExerciseSys_WaitRmOff.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_WaitRmOff.TabIndex = 49;
            this.btn_ExerciseSys_WaitRmOff.Text = "대기룸\r\n조명\r\nOFF";
            this.btn_ExerciseSys_WaitRmOff.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_WaitRmOff.Click += new System.EventHandler(this.btn_ExerciseSys_WaitRmOff_Click);
            // 
            // btn_ExerciseSys_SetupMode
            // 
            this.btn_ExerciseSys_SetupMode.BackColor = System.Drawing.Color.Snow;
            this.btn_ExerciseSys_SetupMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_SetupMode.Location = new System.Drawing.Point(541, 73);
            this.btn_ExerciseSys_SetupMode.Name = "btn_ExerciseSys_SetupMode";
            this.btn_ExerciseSys_SetupMode.Size = new System.Drawing.Size(188, 31);
            this.btn_ExerciseSys_SetupMode.TabIndex = 53;
            this.btn_ExerciseSys_SetupMode.Text = "훈련소 정비 모드";
            this.btn_ExerciseSys_SetupMode.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_SetupMode.Click += new System.EventHandler(this.btn_ExerciseSys_SetupMode_Click);
            // 
            // btn_ExerciseSys_ReadyMode
            // 
            this.btn_ExerciseSys_ReadyMode.BackColor = System.Drawing.Color.Red;
            this.btn_ExerciseSys_ReadyMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ReadyMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ExerciseSys_ReadyMode.Location = new System.Drawing.Point(541, 36);
            this.btn_ExerciseSys_ReadyMode.Name = "btn_ExerciseSys_ReadyMode";
            this.btn_ExerciseSys_ReadyMode.Size = new System.Drawing.Size(188, 31);
            this.btn_ExerciseSys_ReadyMode.TabIndex = 53;
            this.btn_ExerciseSys_ReadyMode.Text = "훈련소 장치 준비";
            this.btn_ExerciseSys_ReadyMode.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_ReadyMode.Click += new System.EventHandler(this.btn_ExerciseSys_ReadyMode_Click);
            // 
            // btn_ExerciseSys_Start
            // 
            this.btn_ExerciseSys_Start.BackColor = System.Drawing.Color.Green;
            this.btn_ExerciseSys_Start.Font = new System.Drawing.Font("타이포_쌍문동 B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_Start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ExerciseSys_Start.Location = new System.Drawing.Point(540, 110);
            this.btn_ExerciseSys_Start.Name = "btn_ExerciseSys_Start";
            this.btn_ExerciseSys_Start.Size = new System.Drawing.Size(188, 76);
            this.btn_ExerciseSys_Start.TabIndex = 53;
            this.btn_ExerciseSys_Start.Text = "훈련소\r\n시작";
            this.btn_ExerciseSys_Start.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_Start.Click += new System.EventHandler(this.btn_ExerciseSys_Start_Click);
            // 
            // gp_ExerciseSys_timer
            // 
            this.gp_ExerciseSys_timer.Controls.Add(this.btn_ExerciseSys_timerStart);
            this.gp_ExerciseSys_timer.Controls.Add(this.btn_ExerciseSys_timerStop);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_ExerciseSys_Clock);
            this.gp_ExerciseSys_timer.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_ExerciseSys_timer.Location = new System.Drawing.Point(282, 25);
            this.gp_ExerciseSys_timer.Name = "gp_ExerciseSys_timer";
            this.gp_ExerciseSys_timer.Size = new System.Drawing.Size(253, 161);
            this.gp_ExerciseSys_timer.TabIndex = 46;
            this.gp_ExerciseSys_timer.TabStop = false;
            this.gp_ExerciseSys_timer.Text = "훈련소 투입 후";
            // 
            // btn_ExerciseSys_timerStart
            // 
            this.btn_ExerciseSys_timerStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExerciseSys_timerStart.Location = new System.Drawing.Point(6, 130);
            this.btn_ExerciseSys_timerStart.Name = "btn_ExerciseSys_timerStart";
            this.btn_ExerciseSys_timerStart.Size = new System.Drawing.Size(98, 25);
            this.btn_ExerciseSys_timerStart.TabIndex = 20;
            this.btn_ExerciseSys_timerStart.Text = "타이머 시작";
            this.btn_ExerciseSys_timerStart.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_timerStart.Click += new System.EventHandler(this.btn_ExerciseSys_timerStart_Click);
            // 
            // btn_ExerciseSys_timerStop
            // 
            this.btn_ExerciseSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExerciseSys_timerStop.Location = new System.Drawing.Point(149, 130);
            this.btn_ExerciseSys_timerStop.Name = "btn_ExerciseSys_timerStop";
            this.btn_ExerciseSys_timerStop.Size = new System.Drawing.Size(98, 25);
            this.btn_ExerciseSys_timerStop.TabIndex = 19;
            this.btn_ExerciseSys_timerStop.Text = "타이머 정지";
            this.btn_ExerciseSys_timerStop.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_timerStop.Click += new System.EventHandler(this.btn_ExerciseSys_timerStop_Click);
            // 
            // lb_ExerciseSys_Clock
            // 
            this.lb_ExerciseSys_Clock.AutoSize = true;
            this.lb_ExerciseSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 66.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExerciseSys_Clock.Location = new System.Drawing.Point(3, 26);
            this.lb_ExerciseSys_Clock.Name = "lb_ExerciseSys_Clock";
            this.lb_ExerciseSys_Clock.Size = new System.Drawing.Size(249, 110);
            this.lb_ExerciseSys_Clock.TabIndex = 37;
            this.lb_ExerciseSys_Clock.Text = "00:00";
            this.lb_ExerciseSys_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_serialPort_TRM
            // 
            this.cb_serialPort_TRM.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_serialPort_TRM.FormattingEnabled = true;
            this.cb_serialPort_TRM.Location = new System.Drawing.Point(6, 546);
            this.cb_serialPort_TRM.Name = "cb_serialPort_TRM";
            this.cb_serialPort_TRM.Size = new System.Drawing.Size(270, 27);
            this.cb_serialPort_TRM.TabIndex = 9;
            this.cb_serialPort_TRM.Text = "기본세팅: COM15";
            // 
            // lb_serialPort_TRM
            // 
            this.lb_serialPort_TRM.AutoSize = true;
            this.lb_serialPort_TRM.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_serialPort_TRM.Location = new System.Drawing.Point(6, 527);
            this.lb_serialPort_TRM.Name = "lb_serialPort_TRM";
            this.lb_serialPort_TRM.Size = new System.Drawing.Size(184, 16);
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
            // tb_serialPort_TRM
            // 
            this.tb_serialPort_TRM.Location = new System.Drawing.Point(6, 25);
            this.tb_serialPort_TRM.Multiline = true;
            this.tb_serialPort_TRM.Name = "tb_serialPort_TRM";
            this.tb_serialPort_TRM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serialPort_TRM.Size = new System.Drawing.Size(270, 496);
            this.tb_serialPort_TRM.TabIndex = 6;
            // 
            // gp_IotSys
            // 
            this.gp_IotSys.Controls.Add(this.gp_IotSys_ManualMode);
            this.gp_IotSys.Controls.Add(this.lb_programmedbyBBangJun);
            this.gp_IotSys.Controls.Add(this.gp_IotSys_timer);
            this.gp_IotSys.Controls.Add(this.tc_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.cb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.lb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.tb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.btn_serialPort_IOT_conn);
            this.gp_IotSys.Controls.Add(this.btn_serialPort_IOT_disconn);
            this.gp_IotSys.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_IotSys.Location = new System.Drawing.Point(1172, 12);
            this.gp_IotSys.Name = "gp_IotSys";
            this.gp_IotSys.Size = new System.Drawing.Size(735, 373);
            this.gp_IotSys.TabIndex = 4;
            this.gp_IotSys.TabStop = false;
            this.gp_IotSys.Text = "IOT GLOVE SYSTEM";
            // 
            // lb_programmedbyBBangJun
            // 
            this.lb_programmedbyBBangJun.AutoSize = true;
            this.lb_programmedbyBBangJun.Font = new System.Drawing.Font("Helvetica-Black", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_programmedbyBBangJun.Location = new System.Drawing.Point(549, -3);
            this.lb_programmedbyBBangJun.Name = "lb_programmedbyBBangJun";
            this.lb_programmedbyBBangJun.Size = new System.Drawing.Size(187, 15);
            this.lb_programmedbyBBangJun.TabIndex = 67;
            this.lb_programmedbyBBangJun.Text = "programmed by BBANGJUN";
            // 
            // gp_IotSys_timer
            // 
            this.gp_IotSys_timer.Controls.Add(this.btn_IotSys_timerStart);
            this.gp_IotSys_timer.Controls.Add(this.btn_IotSys_timerStop);
            this.gp_IotSys_timer.Controls.Add(this.lb_IotSys_Clock);
            this.gp_IotSys_timer.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_IotSys_timer.Location = new System.Drawing.Point(282, 114);
            this.gp_IotSys_timer.Name = "gp_IotSys_timer";
            this.gp_IotSys_timer.Size = new System.Drawing.Size(211, 250);
            this.gp_IotSys_timer.TabIndex = 19;
            this.gp_IotSys_timer.TabStop = false;
            this.gp_IotSys_timer.Text = "술래결정까지";
            // 
            // btn_IotSys_timerStart
            // 
            this.btn_IotSys_timerStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IotSys_timerStart.Location = new System.Drawing.Point(6, 219);
            this.btn_IotSys_timerStart.Name = "btn_IotSys_timerStart";
            this.btn_IotSys_timerStart.Size = new System.Drawing.Size(92, 25);
            this.btn_IotSys_timerStart.TabIndex = 18;
            this.btn_IotSys_timerStart.Text = "타이머 시작";
            this.btn_IotSys_timerStart.UseVisualStyleBackColor = true;
            this.btn_IotSys_timerStart.Click += new System.EventHandler(this.btn_IotSys_timerStart_Click);
            // 
            // btn_IotSys_timerStop
            // 
            this.btn_IotSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IotSys_timerStop.Location = new System.Drawing.Point(113, 219);
            this.btn_IotSys_timerStop.Name = "btn_IotSys_timerStop";
            this.btn_IotSys_timerStop.Size = new System.Drawing.Size(92, 25);
            this.btn_IotSys_timerStop.TabIndex = 17;
            this.btn_IotSys_timerStop.Text = "타이머 정지";
            this.btn_IotSys_timerStop.UseVisualStyleBackColor = true;
            this.btn_IotSys_timerStop.Click += new System.EventHandler(this.btn_IotSys_timerStop_Click);
            // 
            // lb_IotSys_Clock
            // 
            this.lb_IotSys_Clock.AutoSize = true;
            this.lb_IotSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 66.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IotSys_Clock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_IotSys_Clock.Location = new System.Drawing.Point(3, 67);
            this.lb_IotSys_Clock.Name = "lb_IotSys_Clock";
            this.lb_IotSys_Clock.Size = new System.Drawing.Size(204, 110);
            this.lb_IotSys_Clock.TabIndex = 16;
            this.lb_IotSys_Clock.Text = "3:00";
            this.lb_IotSys_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TagReSel
            // 
            this.btn_TagReSel.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TagReSel.Location = new System.Drawing.Point(120, 69);
            this.btn_TagReSel.Name = "btn_TagReSel";
            this.btn_TagReSel.Size = new System.Drawing.Size(100, 35);
            this.btn_TagReSel.TabIndex = 15;
            this.btn_TagReSel.Text = "술래 재결정 ";
            this.btn_TagReSel.UseVisualStyleBackColor = true;
            this.btn_TagReSel.Click += new System.EventHandler(this.btn_TagReSel_Click);
            // 
            // btn_WaitRmOn
            // 
            this.btn_WaitRmOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaitRmOn.Location = new System.Drawing.Point(6, 69);
            this.btn_WaitRmOn.Name = "btn_WaitRmOn";
            this.btn_WaitRmOn.Size = new System.Drawing.Size(100, 35);
            this.btn_WaitRmOn.TabIndex = 14;
            this.btn_WaitRmOn.Text = "대기공간 ON";
            this.btn_WaitRmOn.UseVisualStyleBackColor = true;
            this.btn_WaitRmOn.Click += new System.EventHandler(this.btn_WaitRmOn_Click);
            // 
            // btn_TagSel
            // 
            this.btn_TagSel.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TagSel.Location = new System.Drawing.Point(120, 29);
            this.btn_TagSel.Name = "btn_TagSel";
            this.btn_TagSel.Size = new System.Drawing.Size(100, 35);
            this.btn_TagSel.TabIndex = 13;
            this.btn_TagSel.Text = "술래결정 (3분)";
            this.btn_TagSel.UseVisualStyleBackColor = true;
            this.btn_TagSel.Click += new System.EventHandler(this.btn_TagSel_Click);
            // 
            // btn_IotTest
            // 
            this.btn_IotTest.BackColor = System.Drawing.Color.Red;
            this.btn_IotTest.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IotTest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_IotTest.Location = new System.Drawing.Point(6, 29);
            this.btn_IotTest.Name = "btn_IotTest";
            this.btn_IotTest.Size = new System.Drawing.Size(100, 35);
            this.btn_IotTest.TabIndex = 12;
            this.btn_IotTest.Text = "IOT 테스트";
            this.btn_IotTest.UseVisualStyleBackColor = false;
            this.btn_IotTest.Click += new System.EventHandler(this.btn_IotTest_Click);
            // 
            // tc_serialPort_IOT
            // 
            this.tc_serialPort_IOT.Controls.Add(this.tp_G1);
            this.tc_serialPort_IOT.Controls.Add(this.tp_G2);
            this.tc_serialPort_IOT.Controls.Add(this.tp_G3);
            this.tc_serialPort_IOT.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_serialPort_IOT.Location = new System.Drawing.Point(499, 22);
            this.tc_serialPort_IOT.Name = "tc_serialPort_IOT";
            this.tc_serialPort_IOT.SelectedIndex = 0;
            this.tc_serialPort_IOT.Size = new System.Drawing.Size(230, 230);
            this.tc_serialPort_IOT.TabIndex = 11;
            // 
            // tp_G1
            // 
            this.tp_G1.Controls.Add(this.lb_G1P8_state);
            this.tp_G1.Controls.Add(this.lb_G1P7_state);
            this.tp_G1.Controls.Add(this.lb_G1P6_state);
            this.tp_G1.Controls.Add(this.lb_G1P5_state);
            this.tp_G1.Controls.Add(this.lb_G1P4_state);
            this.tp_G1.Controls.Add(this.lb_G1P3_state);
            this.tp_G1.Controls.Add(this.lb_G1P2_state);
            this.tp_G1.Controls.Add(this.lb_G1P1_state);
            this.tp_G1.Controls.Add(this.rb_G1P8);
            this.tp_G1.Controls.Add(this.rb_G1P1);
            this.tp_G1.Controls.Add(this.rb_G1P7);
            this.tp_G1.Controls.Add(this.rb_G1P2);
            this.tp_G1.Controls.Add(this.rb_G1P6);
            this.tp_G1.Controls.Add(this.rb_G1P3);
            this.tp_G1.Controls.Add(this.rb_G1P5);
            this.tp_G1.Controls.Add(this.rb_G1P4);
            this.tp_G1.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_G1.Location = new System.Drawing.Point(4, 23);
            this.tp_G1.Name = "tp_G1";
            this.tp_G1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_G1.Size = new System.Drawing.Size(222, 203);
            this.tp_G1.TabIndex = 0;
            this.tp_G1.Text = "G1";
            this.tp_G1.UseVisualStyleBackColor = true;
            // 
            // lb_G1P8_state
            // 
            this.lb_G1P8_state.AutoSize = true;
            this.lb_G1P8_state.Location = new System.Drawing.Point(165, 183);
            this.lb_G1P8_state.Name = "lb_G1P8_state";
            this.lb_G1P8_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P8_state.TabIndex = 15;
            this.lb_G1P8_state.Text = "Offline";
            // 
            // lb_G1P7_state
            // 
            this.lb_G1P7_state.AutoSize = true;
            this.lb_G1P7_state.Location = new System.Drawing.Point(165, 158);
            this.lb_G1P7_state.Name = "lb_G1P7_state";
            this.lb_G1P7_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P7_state.TabIndex = 14;
            this.lb_G1P7_state.Text = "Offline";
            // 
            // lb_G1P6_state
            // 
            this.lb_G1P6_state.AutoSize = true;
            this.lb_G1P6_state.Location = new System.Drawing.Point(165, 133);
            this.lb_G1P6_state.Name = "lb_G1P6_state";
            this.lb_G1P6_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P6_state.TabIndex = 13;
            this.lb_G1P6_state.Text = "Offline";
            // 
            // lb_G1P5_state
            // 
            this.lb_G1P5_state.AutoSize = true;
            this.lb_G1P5_state.Location = new System.Drawing.Point(165, 108);
            this.lb_G1P5_state.Name = "lb_G1P5_state";
            this.lb_G1P5_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P5_state.TabIndex = 12;
            this.lb_G1P5_state.Text = "Offline";
            // 
            // lb_G1P4_state
            // 
            this.lb_G1P4_state.AutoSize = true;
            this.lb_G1P4_state.Location = new System.Drawing.Point(165, 83);
            this.lb_G1P4_state.Name = "lb_G1P4_state";
            this.lb_G1P4_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P4_state.TabIndex = 11;
            this.lb_G1P4_state.Text = "Offline";
            // 
            // lb_G1P3_state
            // 
            this.lb_G1P3_state.AutoSize = true;
            this.lb_G1P3_state.Location = new System.Drawing.Point(165, 58);
            this.lb_G1P3_state.Name = "lb_G1P3_state";
            this.lb_G1P3_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P3_state.TabIndex = 10;
            this.lb_G1P3_state.Text = "Offline";
            // 
            // lb_G1P2_state
            // 
            this.lb_G1P2_state.AutoSize = true;
            this.lb_G1P2_state.Location = new System.Drawing.Point(165, 33);
            this.lb_G1P2_state.Name = "lb_G1P2_state";
            this.lb_G1P2_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P2_state.TabIndex = 9;
            this.lb_G1P2_state.Text = "Offline";
            // 
            // lb_G1P1_state
            // 
            this.lb_G1P1_state.AutoSize = true;
            this.lb_G1P1_state.Location = new System.Drawing.Point(165, 8);
            this.lb_G1P1_state.Name = "lb_G1P1_state";
            this.lb_G1P1_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P1_state.TabIndex = 8;
            this.lb_G1P1_state.Text = "Offline";
            // 
            // rb_G1P8
            // 
            this.rb_G1P8.AutoSize = true;
            this.rb_G1P8.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P8.Location = new System.Drawing.Point(6, 181);
            this.rb_G1P8.Name = "rb_G1P8";
            this.rb_G1P8.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P8.TabIndex = 7;
            this.rb_G1P8.Text = "G1_PLAYER8";
            this.rb_G1P8.UseVisualStyleBackColor = true;
            // 
            // rb_G1P1
            // 
            this.rb_G1P1.AutoSize = true;
            this.rb_G1P1.Checked = true;
            this.rb_G1P1.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P1.Location = new System.Drawing.Point(6, 6);
            this.rb_G1P1.Name = "rb_G1P1";
            this.rb_G1P1.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P1.TabIndex = 0;
            this.rb_G1P1.TabStop = true;
            this.rb_G1P1.Text = "G1_PLAYER1";
            this.rb_G1P1.UseVisualStyleBackColor = true;
            // 
            // rb_G1P7
            // 
            this.rb_G1P7.AutoSize = true;
            this.rb_G1P7.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P7.Location = new System.Drawing.Point(6, 156);
            this.rb_G1P7.Name = "rb_G1P7";
            this.rb_G1P7.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P7.TabIndex = 6;
            this.rb_G1P7.Text = "G1_PLAYER7";
            this.rb_G1P7.UseVisualStyleBackColor = true;
            // 
            // rb_G1P2
            // 
            this.rb_G1P2.AutoSize = true;
            this.rb_G1P2.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P2.Location = new System.Drawing.Point(6, 31);
            this.rb_G1P2.Name = "rb_G1P2";
            this.rb_G1P2.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P2.TabIndex = 1;
            this.rb_G1P2.Text = "G1_PLAYER2";
            this.rb_G1P2.UseVisualStyleBackColor = true;
            // 
            // rb_G1P6
            // 
            this.rb_G1P6.AutoSize = true;
            this.rb_G1P6.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P6.Location = new System.Drawing.Point(6, 131);
            this.rb_G1P6.Name = "rb_G1P6";
            this.rb_G1P6.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P6.TabIndex = 5;
            this.rb_G1P6.Text = "G1_PLAYER6";
            this.rb_G1P6.UseVisualStyleBackColor = true;
            // 
            // rb_G1P3
            // 
            this.rb_G1P3.AutoSize = true;
            this.rb_G1P3.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P3.Location = new System.Drawing.Point(6, 56);
            this.rb_G1P3.Name = "rb_G1P3";
            this.rb_G1P3.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P3.TabIndex = 2;
            this.rb_G1P3.Text = "G1_PLAYER3";
            this.rb_G1P3.UseVisualStyleBackColor = true;
            // 
            // rb_G1P5
            // 
            this.rb_G1P5.AutoSize = true;
            this.rb_G1P5.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P5.Location = new System.Drawing.Point(6, 106);
            this.rb_G1P5.Name = "rb_G1P5";
            this.rb_G1P5.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P5.TabIndex = 4;
            this.rb_G1P5.Text = "G1_PLAYER5";
            this.rb_G1P5.UseVisualStyleBackColor = true;
            // 
            // rb_G1P4
            // 
            this.rb_G1P4.AutoSize = true;
            this.rb_G1P4.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G1P4.Location = new System.Drawing.Point(6, 81);
            this.rb_G1P4.Name = "rb_G1P4";
            this.rb_G1P4.Size = new System.Drawing.Size(112, 19);
            this.rb_G1P4.TabIndex = 3;
            this.rb_G1P4.Text = "G1_PLAYER4";
            this.rb_G1P4.UseVisualStyleBackColor = true;
            // 
            // tp_G2
            // 
            this.tp_G2.Controls.Add(this.rb_G2P8);
            this.tp_G2.Controls.Add(this.rb_G2P1);
            this.tp_G2.Controls.Add(this.rb_G2P7);
            this.tp_G2.Controls.Add(this.rb_G2P2);
            this.tp_G2.Controls.Add(this.rb_G2P6);
            this.tp_G2.Controls.Add(this.rb_G2P3);
            this.tp_G2.Controls.Add(this.rb_G2P5);
            this.tp_G2.Controls.Add(this.rb_G2P4);
            this.tp_G2.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_G2.Location = new System.Drawing.Point(4, 23);
            this.tp_G2.Name = "tp_G2";
            this.tp_G2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_G2.Size = new System.Drawing.Size(222, 203);
            this.tp_G2.TabIndex = 1;
            this.tp_G2.Text = "G2";
            this.tp_G2.UseVisualStyleBackColor = true;
            // 
            // rb_G2P8
            // 
            this.rb_G2P8.AutoSize = true;
            this.rb_G2P8.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P8.Location = new System.Drawing.Point(6, 181);
            this.rb_G2P8.Name = "rb_G2P8";
            this.rb_G2P8.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P8.TabIndex = 8;
            this.rb_G2P8.TabStop = true;
            this.rb_G2P8.Text = "G2_PLAYER8";
            this.rb_G2P8.UseVisualStyleBackColor = true;
            // 
            // rb_G2P1
            // 
            this.rb_G2P1.AutoSize = true;
            this.rb_G2P1.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P1.Location = new System.Drawing.Point(6, 6);
            this.rb_G2P1.Name = "rb_G2P1";
            this.rb_G2P1.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P1.TabIndex = 0;
            this.rb_G2P1.TabStop = true;
            this.rb_G2P1.Text = "G2_PLAYER1";
            this.rb_G2P1.UseVisualStyleBackColor = true;
            // 
            // rb_G2P7
            // 
            this.rb_G2P7.AutoSize = true;
            this.rb_G2P7.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P7.Location = new System.Drawing.Point(6, 156);
            this.rb_G2P7.Name = "rb_G2P7";
            this.rb_G2P7.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P7.TabIndex = 6;
            this.rb_G2P7.TabStop = true;
            this.rb_G2P7.Text = "G2_PLAYER7";
            this.rb_G2P7.UseVisualStyleBackColor = true;
            // 
            // rb_G2P2
            // 
            this.rb_G2P2.AutoSize = true;
            this.rb_G2P2.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P2.Location = new System.Drawing.Point(6, 31);
            this.rb_G2P2.Name = "rb_G2P2";
            this.rb_G2P2.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P2.TabIndex = 1;
            this.rb_G2P2.TabStop = true;
            this.rb_G2P2.Text = "G2_PLAYER2";
            this.rb_G2P2.UseVisualStyleBackColor = true;
            // 
            // rb_G2P6
            // 
            this.rb_G2P6.AutoSize = true;
            this.rb_G2P6.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P6.Location = new System.Drawing.Point(6, 131);
            this.rb_G2P6.Name = "rb_G2P6";
            this.rb_G2P6.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P6.TabIndex = 5;
            this.rb_G2P6.TabStop = true;
            this.rb_G2P6.Text = "G2_PLAYER6";
            this.rb_G2P6.UseVisualStyleBackColor = true;
            // 
            // rb_G2P3
            // 
            this.rb_G2P3.AutoSize = true;
            this.rb_G2P3.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P3.Location = new System.Drawing.Point(6, 56);
            this.rb_G2P3.Name = "rb_G2P3";
            this.rb_G2P3.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P3.TabIndex = 2;
            this.rb_G2P3.TabStop = true;
            this.rb_G2P3.Text = "G2_PLAYER3";
            this.rb_G2P3.UseVisualStyleBackColor = true;
            // 
            // rb_G2P5
            // 
            this.rb_G2P5.AutoSize = true;
            this.rb_G2P5.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P5.Location = new System.Drawing.Point(6, 106);
            this.rb_G2P5.Name = "rb_G2P5";
            this.rb_G2P5.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P5.TabIndex = 4;
            this.rb_G2P5.TabStop = true;
            this.rb_G2P5.Text = "G2_PLAYER5";
            this.rb_G2P5.UseVisualStyleBackColor = true;
            // 
            // rb_G2P4
            // 
            this.rb_G2P4.AutoSize = true;
            this.rb_G2P4.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P4.Location = new System.Drawing.Point(6, 81);
            this.rb_G2P4.Name = "rb_G2P4";
            this.rb_G2P4.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P4.TabIndex = 3;
            this.rb_G2P4.TabStop = true;
            this.rb_G2P4.Text = "G2_PLAYER4";
            this.rb_G2P4.UseVisualStyleBackColor = true;
            // 
            // tp_G3
            // 
            this.tp_G3.Controls.Add(this.rb_G3P8);
            this.tp_G3.Controls.Add(this.rb_G3P1);
            this.tp_G3.Controls.Add(this.rb_G3P7);
            this.tp_G3.Controls.Add(this.rb_G3P2);
            this.tp_G3.Controls.Add(this.rb_G3P6);
            this.tp_G3.Controls.Add(this.rb_G3P3);
            this.tp_G3.Controls.Add(this.rb_G3P5);
            this.tp_G3.Controls.Add(this.rb_G3P4);
            this.tp_G3.Font = new System.Drawing.Font("Helvetica95-Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_G3.Location = new System.Drawing.Point(4, 23);
            this.tp_G3.Name = "tp_G3";
            this.tp_G3.Size = new System.Drawing.Size(222, 203);
            this.tp_G3.TabIndex = 2;
            this.tp_G3.Text = "G3";
            this.tp_G3.UseVisualStyleBackColor = true;
            // 
            // rb_G3P8
            // 
            this.rb_G3P8.AutoSize = true;
            this.rb_G3P8.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P8.Location = new System.Drawing.Point(6, 181);
            this.rb_G3P8.Name = "rb_G3P8";
            this.rb_G3P8.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P8.TabIndex = 7;
            this.rb_G3P8.TabStop = true;
            this.rb_G3P8.Text = "G3_PLAYER8";
            this.rb_G3P8.UseVisualStyleBackColor = true;
            // 
            // rb_G3P1
            // 
            this.rb_G3P1.AutoSize = true;
            this.rb_G3P1.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P1.Location = new System.Drawing.Point(6, 6);
            this.rb_G3P1.Name = "rb_G3P1";
            this.rb_G3P1.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P1.TabIndex = 0;
            this.rb_G3P1.TabStop = true;
            this.rb_G3P1.Text = "G3_PLAYER1";
            this.rb_G3P1.UseVisualStyleBackColor = true;
            // 
            // rb_G3P7
            // 
            this.rb_G3P7.AutoSize = true;
            this.rb_G3P7.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P7.Location = new System.Drawing.Point(6, 156);
            this.rb_G3P7.Name = "rb_G3P7";
            this.rb_G3P7.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P7.TabIndex = 6;
            this.rb_G3P7.TabStop = true;
            this.rb_G3P7.Text = "G3_PLAYER7";
            this.rb_G3P7.UseVisualStyleBackColor = true;
            // 
            // rb_G3P2
            // 
            this.rb_G3P2.AutoSize = true;
            this.rb_G3P2.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P2.Location = new System.Drawing.Point(6, 31);
            this.rb_G3P2.Name = "rb_G3P2";
            this.rb_G3P2.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P2.TabIndex = 1;
            this.rb_G3P2.TabStop = true;
            this.rb_G3P2.Text = "G3_PLAYER2";
            this.rb_G3P2.UseVisualStyleBackColor = true;
            // 
            // rb_G3P6
            // 
            this.rb_G3P6.AutoSize = true;
            this.rb_G3P6.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P6.Location = new System.Drawing.Point(6, 131);
            this.rb_G3P6.Name = "rb_G3P6";
            this.rb_G3P6.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P6.TabIndex = 5;
            this.rb_G3P6.TabStop = true;
            this.rb_G3P6.Text = "G3_PLAYER6";
            this.rb_G3P6.UseVisualStyleBackColor = true;
            // 
            // rb_G3P3
            // 
            this.rb_G3P3.AutoSize = true;
            this.rb_G3P3.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P3.Location = new System.Drawing.Point(6, 56);
            this.rb_G3P3.Name = "rb_G3P3";
            this.rb_G3P3.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P3.TabIndex = 2;
            this.rb_G3P3.TabStop = true;
            this.rb_G3P3.Text = "G3_PLAYER3";
            this.rb_G3P3.UseVisualStyleBackColor = true;
            // 
            // rb_G3P5
            // 
            this.rb_G3P5.AutoSize = true;
            this.rb_G3P5.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P5.Location = new System.Drawing.Point(6, 106);
            this.rb_G3P5.Name = "rb_G3P5";
            this.rb_G3P5.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P5.TabIndex = 4;
            this.rb_G3P5.TabStop = true;
            this.rb_G3P5.Text = "G3_PLAYER5";
            this.rb_G3P5.UseVisualStyleBackColor = true;
            // 
            // rb_G3P4
            // 
            this.rb_G3P4.AutoSize = true;
            this.rb_G3P4.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G3P4.Location = new System.Drawing.Point(6, 81);
            this.rb_G3P4.Name = "rb_G3P4";
            this.rb_G3P4.Size = new System.Drawing.Size(112, 19);
            this.rb_G3P4.TabIndex = 3;
            this.rb_G3P4.TabStop = true;
            this.rb_G3P4.Text = "G3_PLAYER4";
            this.rb_G3P4.UseVisualStyleBackColor = true;
            // 
            // cb_serialPort_IOT
            // 
            this.cb_serialPort_IOT.FormattingEnabled = true;
            this.cb_serialPort_IOT.Location = new System.Drawing.Point(282, 40);
            this.cb_serialPort_IOT.Name = "cb_serialPort_IOT";
            this.cb_serialPort_IOT.Size = new System.Drawing.Size(211, 27);
            this.cb_serialPort_IOT.TabIndex = 5;
            this.cb_serialPort_IOT.Text = "기본세팅: COM25";
            // 
            // lb_serialPort_IOT
            // 
            this.lb_serialPort_IOT.AutoSize = true;
            this.lb_serialPort_IOT.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serialPort_IOT.Location = new System.Drawing.Point(282, 22);
            this.lb_serialPort_IOT.Name = "lb_serialPort_IOT";
            this.lb_serialPort_IOT.Size = new System.Drawing.Size(169, 16);
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
            this.btn_serialPort_IOT_conn.Size = new System.Drawing.Size(104, 35);
            this.btn_serialPort_IOT_conn.TabIndex = 4;
            this.btn_serialPort_IOT_conn.Text = "CONNECT";
            this.btn_serialPort_IOT_conn.UseVisualStyleBackColor = true;
            this.btn_serialPort_IOT_conn.Click += new System.EventHandler(this.btn_serialPort_IOT_conn_Click);
            // 
            // btn_serialPort_IOT_disconn
            // 
            this.btn_serialPort_IOT_disconn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_IOT_disconn.Location = new System.Drawing.Point(390, 73);
            this.btn_serialPort_IOT_disconn.Name = "btn_serialPort_IOT_disconn";
            this.btn_serialPort_IOT_disconn.Size = new System.Drawing.Size(103, 35);
            this.btn_serialPort_IOT_disconn.TabIndex = 5;
            this.btn_serialPort_IOT_disconn.Text = "DISCONNECT";
            this.btn_serialPort_IOT_disconn.UseVisualStyleBackColor = true;
            this.btn_serialPort_IOT_disconn.Click += new System.EventHandler(this.btn_serialPort_IOT_disconn_Click);
            // 
            // timer_IotSys
            // 
            this.timer_IotSys.Interval = 1000;
            this.timer_IotSys.Tick += new System.EventHandler(this.timer_IotSys_Tick);
            // 
            // timer_GameSys
            // 
            this.timer_GameSys.Interval = 1000;
            this.timer_GameSys.Tick += new System.EventHandler(this.timer_GameSys_Tick);
            // 
            // timer_ExerciseSys
            // 
            this.timer_ExerciseSys.Interval = 1000;
            this.timer_ExerciseSys.Tick += new System.EventHandler(this.timer_ExerciseSys_Tick);
            // 
            // gp_IotSys_ManualMode
            // 
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IotTest);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_TagSel);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_WaitRmOn);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_TagReSel);
            this.gp_IotSys_ManualMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotSys_ManualMode.Location = new System.Drawing.Point(499, 254);
            this.gp_IotSys_ManualMode.Name = "gp_IotSys_ManualMode";
            this.gp_IotSys_ManualMode.Size = new System.Drawing.Size(226, 110);
            this.gp_IotSys_ManualMode.TabIndex = 68;
            this.gp_IotSys_ManualMode.TabStop = false;
            this.gp_IotSys_ManualMode.Text = "Manual Mode";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 1041);
            this.Controls.Add(this.gp_ExerciseSys);
            this.Controls.Add(this.gp_IotSys);
            this.Controls.Add(this.gp_GameSys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainControl";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.gp_GameSys.ResumeLayout(false);
            this.gp_GameSys.PerformLayout();
            this.gp_IotGroup.ResumeLayout(false);
            this.gp_IotGroup.PerformLayout();
            this.gp_GameSys_ManualMode.ResumeLayout(false);
            this.gp_MemeberSetup.ResumeLayout(false);
            this.gp_MemeberSetup.PerformLayout();
            this.gp_GameSys_Progress.ResumeLayout(false);
            this.gp_GameSys_Progress.PerformLayout();
            this.gp_GameSys_time.ResumeLayout(false);
            this.gp_GameSys_time.PerformLayout();
            this.gp_ModeSetup.ResumeLayout(false);
            this.gp_ModeSetup.PerformLayout();
            this.gp_Revive.ResumeLayout(false);
            this.gp_Revive.PerformLayout();
            this.gp_escape.ResumeLayout(false);
            this.gp_escape.PerformLayout();
            this.gp_Itembox.ResumeLayout(false);
            this.gp_Itembox.PerformLayout();
            this.gp_Generator.ResumeLayout(false);
            this.gp_Generator.PerformLayout();
            this.gp_Vent.ResumeLayout(false);
            this.gp_Vent.PerformLayout();
            this.gp_Door.ResumeLayout(false);
            this.gp_Door.PerformLayout();
            this.gp_Temple.ResumeLayout(false);
            this.gp_Temple.PerformLayout();
            this.gp_ExerciseSys.ResumeLayout(false);
            this.gp_ExerciseSys.PerformLayout();
            this.gp_ExerciseSys_Machine.ResumeLayout(false);
            this.gp_ExerciseSys_Machine.PerformLayout();
            this.gp_ExerciseSys_ManualMode.ResumeLayout(false);
            this.gp_ExerciseSys_timer.ResumeLayout(false);
            this.gp_ExerciseSys_timer.PerformLayout();
            this.gp_IotSys.ResumeLayout(false);
            this.gp_IotSys.PerformLayout();
            this.gp_IotSys_timer.ResumeLayout(false);
            this.gp_IotSys_timer.PerformLayout();
            this.tc_serialPort_IOT.ResumeLayout(false);
            this.tp_G1.ResumeLayout(false);
            this.tp_G1.PerformLayout();
            this.tp_G2.ResumeLayout(false);
            this.tp_G2.PerformLayout();
            this.tp_G3.ResumeLayout(false);
            this.tp_G3.PerformLayout();
            this.gp_IotSys_ManualMode.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gp_IotSys;
        private System.Windows.Forms.Button btn_IotSys_timerStart;
        private System.Windows.Forms.Button btn_IotSys_timerStop;
        private System.Windows.Forms.Button btn_TagReSel;
        private System.Windows.Forms.Button btn_WaitRmOn;
        private System.Windows.Forms.Button btn_TagSel;
        private System.Windows.Forms.Button btn_IotTest;
        private System.Windows.Forms.TabControl tc_serialPort_IOT;
        private System.Windows.Forms.TabPage tp_G1;
        private System.Windows.Forms.RadioButton rb_G1P6;
        private System.Windows.Forms.RadioButton rb_G1P5;
        private System.Windows.Forms.RadioButton rb_G1P4;
        private System.Windows.Forms.RadioButton rb_G1P3;
        private System.Windows.Forms.RadioButton rb_G1P2;
        private System.Windows.Forms.RadioButton rb_G1P1;
        private System.Windows.Forms.TabPage tp_G2;
        private System.Windows.Forms.RadioButton rb_G2P6;
        private System.Windows.Forms.RadioButton rb_G2P5;
        private System.Windows.Forms.RadioButton rb_G2P4;
        private System.Windows.Forms.RadioButton rb_G2P3;
        private System.Windows.Forms.RadioButton rb_G2P2;
        private System.Windows.Forms.RadioButton rb_G2P1;
        private System.Windows.Forms.TabPage tp_G3;
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
        private System.Windows.Forms.Label lb_IotSys_Clock;
        private System.Windows.Forms.Timer timer_IotSys;
        private System.Windows.Forms.ComboBox cb_serialPort_TRM;
        private System.Windows.Forms.Label lb_serialPort_TRM;
        private System.Windows.Forms.Button btn_serialPort_TRM_conn;
        private System.Windows.Forms.Button btn_serialPort_TRM_disconn;
        private System.Windows.Forms.RadioButton rb_G1P7;
        private System.Windows.Forms.RadioButton rb_G2P7;
        private System.Windows.Forms.RadioButton rb_G3P7;
        private System.Windows.Forms.GroupBox gp_Generator;
        private System.Windows.Forms.Label lb_TG_state;
        private System.Windows.Forms.Label lb_SG_state;
        private System.Windows.Forms.Label lb_CG_state;
        private System.Windows.Forms.Label lb_LG_state;
        private System.Windows.Forms.Label lb_BG_state;
        private System.Windows.Forms.Label lb_TG_name;
        private System.Windows.Forms.Label lb_SG_name;
        private System.Windows.Forms.Label lb_CG_name;
        private System.Windows.Forms.Label lb_LG_name;
        private System.Windows.Forms.Label lb_BG_name;
        private System.Windows.Forms.GroupBox gp_Revive;
        private System.Windows.Forms.Label lb_TR2_name;
        private System.Windows.Forms.Label lb_TR2_state;
        private System.Windows.Forms.Label lb_TR1_name;
        private System.Windows.Forms.Label lb_TR1_state;
        private System.Windows.Forms.Label lb_SR2_name;
        private System.Windows.Forms.Label lb_SR2_state;
        private System.Windows.Forms.Label lb_SR1_name;
        private System.Windows.Forms.Label lb_SR1_state;
        private System.Windows.Forms.Label lb_CR2_name;
        private System.Windows.Forms.Label lb_CR2_state;
        private System.Windows.Forms.Label lb_CR1_name;
        private System.Windows.Forms.Label lb_CR1_state;
        private System.Windows.Forms.Label lb_LR2_name;
        private System.Windows.Forms.Label lb_LR2_state;
        private System.Windows.Forms.Label lb_LR1_name;
        private System.Windows.Forms.Label lb_LR1_state;
        private System.Windows.Forms.Label lb_BR2_name;
        private System.Windows.Forms.Label lb_BR2_state;
        private System.Windows.Forms.Button btn_Revive_send;
        private System.Windows.Forms.ComboBox cb_Revive_state;
        private System.Windows.Forms.ComboBox cb_Revive_name;
        private System.Windows.Forms.Label lb_BR1_name;
        private System.Windows.Forms.Label lb_BR1_state;
        private System.Windows.Forms.GroupBox gp_Itembox;
        private System.Windows.Forms.Label lb_TI2_name;
        private System.Windows.Forms.Label lb_TI2_state;
        private System.Windows.Forms.Label lb_TI1_name;
        private System.Windows.Forms.Label lb_TI1_state;
        private System.Windows.Forms.Label lb_SI2_name;
        private System.Windows.Forms.Label lb_SI2_state;
        private System.Windows.Forms.Label lb_SI1_name;
        private System.Windows.Forms.Label lb_SI1_state;
        private System.Windows.Forms.Label lb_CI2_name;
        private System.Windows.Forms.Label lb_CI2_state;
        private System.Windows.Forms.Label lb_CI1_name;
        private System.Windows.Forms.Label lb_CI1_state;
        private System.Windows.Forms.Label lb_LI2_name;
        private System.Windows.Forms.Label lb_LI2_state;
        private System.Windows.Forms.Label lb_LI1_name;
        private System.Windows.Forms.Label lb_LI1_state;
        private System.Windows.Forms.Label lb_BI2_name;
        private System.Windows.Forms.Label lb_BI2_state;
        private System.Windows.Forms.Label lb_BI1_name;
        private System.Windows.Forms.Label lb_BI1_state;
        private System.Windows.Forms.GroupBox gp_escape;
        private System.Windows.Forms.Label lb_TE_name;
        private System.Windows.Forms.Label lb_TE_state;
        private System.Windows.Forms.Label lb_SE_name;
        private System.Windows.Forms.Label lb_CE_name;
        private System.Windows.Forms.Label lb_LE_name;
        private System.Windows.Forms.Label lb_SE_state;
        private System.Windows.Forms.Label lb_CE_state;
        private System.Windows.Forms.Label lb_LE_state;
        private System.Windows.Forms.GroupBox gp_Temple;
        private System.Windows.Forms.Label lb_LT_name;
        private System.Windows.Forms.Label lb_LT_state;
        private System.Windows.Forms.Button btn_Temple_send;
        private System.Windows.Forms.ComboBox cb_Temple_state;
        private System.Windows.Forms.ComboBox cb_Temple_name;
        private System.Windows.Forms.Button btn_Escape_send;
        private System.Windows.Forms.ComboBox cb_Escape_state;
        private System.Windows.Forms.ComboBox cb_Escape_name;
        private System.Windows.Forms.Button btn_Itembox_send;
        private System.Windows.Forms.ComboBox cb_Itembox_state;
        private System.Windows.Forms.ComboBox cb_Itembox_name;
        private System.Windows.Forms.Button btn_Generator_send;
        private System.Windows.Forms.ComboBox cb_Generator_state;
        private System.Windows.Forms.ComboBox cb_Generator_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Toilet_name;
        private System.Windows.Forms.Label lb_SleepingRoom_name;
        private System.Windows.Forms.Label lb_Cellarge_name;
        private System.Windows.Forms.Label lb_LivingRoom_name;
        private System.Windows.Forms.Label lb_Bamboo_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_GameSys_Clock;
        private System.Windows.Forms.Label lb_BE_name;
        private System.Windows.Forms.Label lb_BE_state;
        private System.Windows.Forms.GroupBox gp_Vent;
        private System.Windows.Forms.Label lb_TV_name;
        private System.Windows.Forms.Label lb_TV_state;
        private System.Windows.Forms.Label lb_SV_name;
        private System.Windows.Forms.Label lb_SV_state;
        private System.Windows.Forms.Label lb_BV2_name;
        private System.Windows.Forms.Button btn_Vent_send;
        private System.Windows.Forms.Label lb_BV2_state;
        private System.Windows.Forms.Label lb_LV_name;
        private System.Windows.Forms.Label lb_BV1_name;
        private System.Windows.Forms.Label lb_BV1_state;
        private System.Windows.Forms.ComboBox cb_Vent_state;
        private System.Windows.Forms.ComboBox cb_Vent_name;
        private System.Windows.Forms.Label lb_LV_state;
        private System.Windows.Forms.GroupBox gp_Door;
        private System.Windows.Forms.Label lb_TD_name;
        private System.Windows.Forms.Label lb_TD_state;
        private System.Windows.Forms.Label lb_SD_name;
        private System.Windows.Forms.Label lb_SD_state;
        private System.Windows.Forms.Label lb_GD_name;
        private System.Windows.Forms.Button btn_Door_send;
        private System.Windows.Forms.Label lb_GD_state;
        private System.Windows.Forms.Label lb_LD_name;
        private System.Windows.Forms.ComboBox cb_Door_state;
        private System.Windows.Forms.ComboBox cb_Door_name;
        private System.Windows.Forms.Label lb_LD_state;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gp_GameSys_time;
        private System.Windows.Forms.Button btn_GameSys_timerStop;
        private System.Windows.Forms.Button btn_GameSys_timerStart;
        private System.Windows.Forms.Button btn_GameSys_1min_add;
        private System.Windows.Forms.Button btn_GameSys_5min_add;
        private System.Windows.Forms.GroupBox gp_ModeSetup;
        private System.Windows.Forms.RadioButton rb_GameSys_HardMode;
        private System.Windows.Forms.RadioButton rb_GameSys_NormalMode;
        private System.Windows.Forms.RadioButton rb_GameSys_EasyMode;
        private System.Windows.Forms.Button btn_GameSys_GameStart;
        private System.Windows.Forms.GroupBox gp_GameSys_Progress;
        private System.Windows.Forms.Label lb_GameSys_CollectedTemple_cnt;
        private System.Windows.Forms.Label lb_GameSys_ActivateEscape_cnt;
        private System.Windows.Forms.Label lb_GameSys_FixedGenerator_cnt;
        private System.Windows.Forms.Label lb_GameSys_UsedRevive_cnt;
        private System.Windows.Forms.Label lb_GameSys_OpenItembox_cnt;
        private System.Windows.Forms.Label lb_GameSys_CollectedTemple;
        private System.Windows.Forms.Label lb_GameSys_ActivateEscape;
        private System.Windows.Forms.Label lb_GameSys_FixedGenerator;
        private System.Windows.Forms.Label lb_GameSys_UsedRevive;
        private System.Windows.Forms.Label lb_GameSys_OpenItembox;
        private System.Windows.Forms.Timer timer_GameSys;
        private System.Windows.Forms.Button btn_GameSys_VideoPlay;
        private System.Windows.Forms.Button btn_GameSys_ReadyMode;
        private System.Windows.Forms.GroupBox gp_MemeberSetup;
        private System.Windows.Forms.RadioButton rb_GameSys_6P;
        private System.Windows.Forms.RadioButton rb_GameSys_5P;
        private System.Windows.Forms.RadioButton rb_GameSys_4P;
        private System.Windows.Forms.Button btn_GameSys_SetupMode;
        private System.Windows.Forms.GroupBox gp_GameSys_ManualMode;
        private System.Windows.Forms.Button btn_GameSys_NarrantionPlay;
        private System.Windows.Forms.ComboBox cb_GameSys_Narration;
        private System.Windows.Forms.Button btn_GameSys_funcA;
        private System.Windows.Forms.Button btn_GameSys_SelfRevive;
        private System.Windows.Forms.Button btn_GameSys_OS_Start;
        private System.Windows.Forms.Button btn_GameSys_GameStop;
        private System.Windows.Forms.Button btn_GameSys_funcC;
        private System.Windows.Forms.Button btn_GameSys_funcB;
        private System.Windows.Forms.RadioButton rb_G1P8;
        private System.Windows.Forms.Label lb_CV_name;
        private System.Windows.Forms.Label lb_CV_state;
        private System.Windows.Forms.Button btn_ExerciseSys_SetupMode;
        private System.Windows.Forms.Button btn_ExerciseSys_ReadyMode;
        private System.Windows.Forms.Button btn_ExerciseSys_Start;
        private System.Windows.Forms.GroupBox gp_ExerciseSys_timer;
        private System.Windows.Forms.Button btn_ExerciseSys_timerStart;
        private System.Windows.Forms.Button btn_ExerciseSys_timerStop;
        private System.Windows.Forms.Label lb_ExerciseSys_Clock;
        private System.Windows.Forms.GroupBox gp_IotSys_timer;
        private System.Windows.Forms.RadioButton rb_G2P8;
        private System.Windows.Forms.RadioButton rb_G3P8;
        private System.Windows.Forms.Label lb_G1P1_state;
        private System.Windows.Forms.Label lb_G1P8_state;
        private System.Windows.Forms.Label lb_G1P7_state;
        private System.Windows.Forms.Label lb_G1P6_state;
        private System.Windows.Forms.Label lb_G1P5_state;
        private System.Windows.Forms.Label lb_G1P4_state;
        private System.Windows.Forms.Label lb_G1P3_state;
        private System.Windows.Forms.Label lb_G1P2_state;
        private System.Windows.Forms.GroupBox gp_ExerciseSys_ManualMode;
        private System.Windows.Forms.Button button26btn_ExerciseSys_LightOff;
        private System.Windows.Forms.Button btn_ExerciseSys_NarrationPlay;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_Narration;
        private System.Windows.Forms.Button btn_ExerciseSys_ExerciseRmOn;
        private System.Windows.Forms.Button btn_ExerciseSys_funcA;
        private System.Windows.Forms.Button btn_ExerciseSys_Stop;
        private System.Windows.Forms.Button btn_ExerciseSys_MovingOn;
        private System.Windows.Forms.Button btn_ExerciseSys_WaitRmOff;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Button btn_ExerciseSys_MachineSend;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_MachineState;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_MachineName;
        private System.Windows.Forms.GroupBox gp_ExerciseSys_Machine;
        private System.Windows.Forms.Label lb_ExerciseSys_ET_State;
        private System.Windows.Forms.Label lb_ExerciseSys_ET;
        private System.Windows.Forms.Label lb_ExerciseSys_EV_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EV;
        private System.Windows.Forms.Label lb_ExerciseSys_ED_State;
        private System.Windows.Forms.Label lb_ExerciseSys_ED;
        private System.Windows.Forms.Label lb_ExerciseSys_EE_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EE;
        private System.Windows.Forms.Label lb_ExerciseSys_EG_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EG;
        private System.Windows.Forms.Label lb_ExerciseSys_ER1_State;
        private System.Windows.Forms.Label lb_ExerciseSys_ER1;
        private System.Windows.Forms.Label lb_ExerciseSys_EI2_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EI1_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EI2;
        private System.Windows.Forms.Label lb_ExerciseSys_EI1;
        private System.Windows.Forms.Label lb_programmedbyBBangJun;
        private System.Windows.Forms.Timer timer_ExerciseSys;
        private System.Windows.Forms.GroupBox gp_IotGroup;
        private System.Windows.Forms.RadioButton rb_IOT_Group3;
        private System.Windows.Forms.RadioButton rb_IOT_Group2;
        private System.Windows.Forms.RadioButton rb_IOT_Group1;
        private System.Windows.Forms.GroupBox gp_IotSys_ManualMode;
    }
}

