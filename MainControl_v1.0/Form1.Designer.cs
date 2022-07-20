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
            this.btn_setting_light = new System.Windows.Forms.Button();
            this.btn_serialPort_PCMerr_clipboardcopy = new System.Windows.Forms.Button();
            this.tb_serialPort_PCM_err = new System.Windows.Forms.TextBox();
            this.cb_silentStart = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_Temple_autokiller = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_gameModeAuto = new System.Windows.Forms.CheckBox();
            this.btn_GameSys_currentState = new System.Windows.Forms.Button();
            this.btn_GameSys_ModeSetting = new System.Windows.Forms.Button();
            this.gp_IotSys_Animation = new System.Windows.Forms.GroupBox();
            this.btn_ExerciseSys_VideoStart = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_AnimationOn = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_VideoStop = new System.Windows.Forms.Button();
            this.lb_GameSys_mode = new System.Windows.Forms.Label();
            this.lb_hard_duct_cooltime = new System.Windows.Forms.TabControl();
            this.tp_easymode = new System.Windows.Forms.TabPage();
            this.tc_easy_device = new System.Windows.Forms.TabControl();
            this.tp_easy_generator = new System.Windows.Forms.TabPage();
            this.tb_easy_generator_B3 = new System.Windows.Forms.TextBox();
            this.tb_easy_generator_B2 = new System.Windows.Forms.TextBox();
            this.lb_easy_generator_B3 = new System.Windows.Forms.Label();
            this.lb_easy_generator_B2 = new System.Windows.Forms.Label();
            this.tb_easy_generator_B1 = new System.Windows.Forms.TextBox();
            this.lb_easy_generator_B1 = new System.Windows.Forms.Label();
            this.lb_easy_generator_starter = new System.Windows.Forms.Label();
            this.tb_easy_generator_starter = new System.Windows.Forms.TextBox();
            this.tp_easy_Escape = new System.Windows.Forms.TabPage();
            this.lb_easy_escape_Btime = new System.Windows.Forms.Label();
            this.tb_easy_escape_Btime = new System.Windows.Forms.TextBox();
            this.tp_easy_itembox = new System.Windows.Forms.TabPage();
            this.tb_easy_itembox_Btime = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_Btime = new System.Windows.Forms.Label();
            this.tb_easy_itembox_ansarea = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_ansarea = new System.Windows.Forms.Label();
            this.lb_easy_itembox_anscnt = new System.Windows.Forms.Label();
            this.tb_easy_itembox_anscnt = new System.Windows.Forms.TextBox();
            this.tb_easy_itembox_ans5 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_ans5 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_ans4 = new System.Windows.Forms.TextBox();
            this.tb_easy_itembox_ans3 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_ans4 = new System.Windows.Forms.Label();
            this.lb_easy_itembox_ans3 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_ans2 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_ans2 = new System.Windows.Forms.Label();
            this.lb_easy_itembox_ans1 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_ans1 = new System.Windows.Forms.TextBox();
            this.tb_easy_itembox_vibe5 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_vibe5 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_vibe4 = new System.Windows.Forms.TextBox();
            this.tb_easy_itembox_vibe3 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_vibe4 = new System.Windows.Forms.Label();
            this.lb_easy_itembox_vibe3 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_vibe2 = new System.Windows.Forms.TextBox();
            this.lb_easy_itembox_vibe2 = new System.Windows.Forms.Label();
            this.lb_easy_itembox_vibe1 = new System.Windows.Forms.Label();
            this.tb_easy_itembox_vibe1 = new System.Windows.Forms.TextBox();
            this.tp_easy_gamedoor = new System.Windows.Forms.TabPage();
            this.lb_easy_door_autolock = new System.Windows.Forms.Label();
            this.tb_easy_door_autolock = new System.Windows.Forms.TextBox();
            this.tp_easy_duct = new System.Windows.Forms.TabPage();
            this.tb_easy_vent_cooltime_addup = new System.Windows.Forms.TextBox();
            this.lb_easy_vent_cooltime_addup = new System.Windows.Forms.Label();
            this.lb_easy_vent_cooltime = new System.Windows.Forms.Label();
            this.tb_easy_vent_cooltime = new System.Windows.Forms.TextBox();
            this.tp_normalmode = new System.Windows.Forms.TabPage();
            this.tc_normal_device = new System.Windows.Forms.TabControl();
            this.tp_normal_generator = new System.Windows.Forms.TabPage();
            this.tb_normal_generator_B3 = new System.Windows.Forms.TextBox();
            this.tb_normal_generator_B2 = new System.Windows.Forms.TextBox();
            this.lb_normal_generator_B3 = new System.Windows.Forms.Label();
            this.lb_normal_generator_B2 = new System.Windows.Forms.Label();
            this.tb_normal_generator_B1 = new System.Windows.Forms.TextBox();
            this.lb_normal_generator_B1 = new System.Windows.Forms.Label();
            this.lb_normal_generator_starter = new System.Windows.Forms.Label();
            this.tb_normal_generator_starter = new System.Windows.Forms.TextBox();
            this.tp_normal_escape = new System.Windows.Forms.TabPage();
            this.lb_normal_escape_Btime = new System.Windows.Forms.Label();
            this.tb_normal_escape_Btime = new System.Windows.Forms.TextBox();
            this.tp_normal_itembox = new System.Windows.Forms.TabPage();
            this.tb_normal_itembox_Btime = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_Btime = new System.Windows.Forms.Label();
            this.tb_normal_itembox_ansarea = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_ansarea = new System.Windows.Forms.Label();
            this.lb_normal_itembox_anscnt = new System.Windows.Forms.Label();
            this.tb_normal_itembox_anscnt = new System.Windows.Forms.TextBox();
            this.tb_normal_itembox_ans5 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_ans5 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_ans4 = new System.Windows.Forms.TextBox();
            this.tb_normal_itembox_ans3 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_ans4 = new System.Windows.Forms.Label();
            this.lb_normal_itembox_ans3 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_ans2 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_ans2 = new System.Windows.Forms.Label();
            this.lb_normal_itembox_ans1 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_ans1 = new System.Windows.Forms.TextBox();
            this.tb_normal_itembox_vibe5 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_vibe5 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_vibe4 = new System.Windows.Forms.TextBox();
            this.tb_normal_itembox_vibe3 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_vibe4 = new System.Windows.Forms.Label();
            this.lb_normal_itembox_vibe3 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_vibe2 = new System.Windows.Forms.TextBox();
            this.lb_normal_itembox_vibe2 = new System.Windows.Forms.Label();
            this.lb_normal_itembox_vibe1 = new System.Windows.Forms.Label();
            this.tb_normal_itembox_vibe1 = new System.Windows.Forms.TextBox();
            this.tp_normal_door = new System.Windows.Forms.TabPage();
            this.lb_noraml_door_autolock = new System.Windows.Forms.Label();
            this.tb_noraml_door_autolock = new System.Windows.Forms.TextBox();
            this.tp_normal_duct = new System.Windows.Forms.TabPage();
            this.tb_normal_vent_cooltime_addup = new System.Windows.Forms.TextBox();
            this.lb_normal_vent_cooltime_addup = new System.Windows.Forms.Label();
            this.lb_noraml_duct_cooltime = new System.Windows.Forms.Label();
            this.tb_normal_vent_cooltime = new System.Windows.Forms.TextBox();
            this.tp_hardmode = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_hard_generator = new System.Windows.Forms.TabPage();
            this.tb_hard_generator_B3 = new System.Windows.Forms.TextBox();
            this.tb_hard_generator_B2 = new System.Windows.Forms.TextBox();
            this.lb_hard_generator_B3 = new System.Windows.Forms.Label();
            this.lb_hard_generator_B2 = new System.Windows.Forms.Label();
            this.tb_hard_generator_B1 = new System.Windows.Forms.TextBox();
            this.lb_hard_generator_B1 = new System.Windows.Forms.Label();
            this.lb_hard_generator_starter = new System.Windows.Forms.Label();
            this.tb_hard_generator_starter = new System.Windows.Forms.TextBox();
            this.tp_hard_escape = new System.Windows.Forms.TabPage();
            this.lb_hard_escape_Btime = new System.Windows.Forms.Label();
            this.tb_hard_escape_Btime = new System.Windows.Forms.TextBox();
            this.tp_hard_itembox = new System.Windows.Forms.TabPage();
            this.tb_hard_itembox_Btime = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_Btime = new System.Windows.Forms.Label();
            this.tb_hard_itembox_ansarea = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_ansarea = new System.Windows.Forms.Label();
            this.lb_hard_itembox_anscnt = new System.Windows.Forms.Label();
            this.tb_hard_itembox_anscnt = new System.Windows.Forms.TextBox();
            this.tb_hard_itembox_ans5 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_ans5 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_ans4 = new System.Windows.Forms.TextBox();
            this.tb_hard_itembox_ans3 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_ans4 = new System.Windows.Forms.Label();
            this.lb_hard_itembox_ans3 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_ans2 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_ans2 = new System.Windows.Forms.Label();
            this.lb_hard_itembox_ans1 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_ans1 = new System.Windows.Forms.TextBox();
            this.tb_hard_itembox_vibe5 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_vibe5 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_vibe4 = new System.Windows.Forms.TextBox();
            this.tb_hard_itembox_vibe3 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_vibe4 = new System.Windows.Forms.Label();
            this.lb_hard_itembox_vibe3 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_vibe2 = new System.Windows.Forms.TextBox();
            this.lb_hard_itembox_vibe2 = new System.Windows.Forms.Label();
            this.lb_hard_itembox_vibe1 = new System.Windows.Forms.Label();
            this.tb_hard_itembox_vibe1 = new System.Windows.Forms.TextBox();
            this.tp_hard_door = new System.Windows.Forms.TabPage();
            this.lb_hard_door_autolock = new System.Windows.Forms.Label();
            this.tb_hard_door_autolock = new System.Windows.Forms.TextBox();
            this.tp_hard_duct = new System.Windows.Forms.TabPage();
            this.tb_hard_vent_cooltime_addup = new System.Windows.Forms.TextBox();
            this.lb_hard_vent_cooltime_addup = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_hard_vent_cooltime = new System.Windows.Forms.TextBox();
            this.cb_videoAfter_autoStart = new System.Windows.Forms.CheckBox();
            this.btn_GameSys_GameStart = new System.Windows.Forms.Button();
            this.cb_selfRevive_auto = new System.Windows.Forms.CheckBox();
            this.cb_iotAUTO = new System.Windows.Forms.CheckBox();
            this.gp_IotSys_waitingroom = new System.Windows.Forms.GroupBox();
            this.btn_ExerciseSys_DoorOpen = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_ES = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_ScreenDown = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_EP_State = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_ScreenUp = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_EP = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_DoorClose = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_ES_State = new System.Windows.Forms.Label();
            this.gp_light_setup = new System.Windows.Forms.GroupBox();
            this.cb_GameSys_deviceLight_auto = new System.Windows.Forms.CheckBox();
            this.rb_GameSys_DayMode = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_NightMode = new System.Windows.Forms.RadioButton();
            this.btn_GameSys_AL_Off = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_GameSys_AL_ON = new System.Windows.Forms.Button();
            this.lb_TL_state = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_SL_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CL_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_LL_state = new System.Windows.Forms.Label();
            this.lb_BL_name = new System.Windows.Forms.Label();
            this.lb_BL_state = new System.Windows.Forms.Label();
            this.gb_revive_rnd = new System.Windows.Forms.GroupBox();
            this.lb_revive_9 = new System.Windows.Forms.Label();
            this.lb_revive_8 = new System.Windows.Forms.Label();
            this.lb_revive_1 = new System.Windows.Forms.Label();
            this.lb_revive_2 = new System.Windows.Forms.Label();
            this.lb_revive_14min = new System.Windows.Forms.Label();
            this.lb_revive_11min = new System.Windows.Forms.Label();
            this.lb_revive_7 = new System.Windows.Forms.Label();
            this.lb_revive_17min = new System.Windows.Forms.Label();
            this.lb_revive_5 = new System.Windows.Forms.Label();
            this.lb_revive_23min = new System.Windows.Forms.Label();
            this.lb_revive_4 = new System.Windows.Forms.Label();
            this.lb_revive_3 = new System.Windows.Forms.Label();
            this.lb_revive_6 = new System.Windows.Forms.Label();
            this.lb_revive_0 = new System.Windows.Forms.Label();
            this.lb_revive_26min = new System.Windows.Forms.Label();
            this.lb_revive_29min = new System.Windows.Forms.Label();
            this.lb_revive_20min = new System.Windows.Forms.Label();
            this.lb_revive_32min = new System.Windows.Forms.Label();
            this.gb_BlockTree = new System.Windows.Forms.GroupBox();
            this.btn_TaggerSkill_timereset = new System.Windows.Forms.Button();
            this.btn_TaggerSkill_timesubraction = new System.Windows.Forms.Button();
            this.btn_TaggerSkill_timeadd = new System.Windows.Forms.Button();
            this.lb_TaggerSkill_timer = new System.Windows.Forms.Label();
            this.btn_GameSys_rndBlock = new System.Windows.Forms.Button();
            this.lb_block_4 = new System.Windows.Forms.Label();
            this.lb_block_15min = new System.Windows.Forms.Label();
            this.lb_block_3 = new System.Windows.Forms.Label();
            this.lb_block_2 = new System.Windows.Forms.Label();
            this.lb_block_5 = new System.Windows.Forms.Label();
            this.lb_block_1 = new System.Windows.Forms.Label();
            this.lb_block_20min = new System.Windows.Forms.Label();
            this.lb_block_25min = new System.Windows.Forms.Label();
            this.lb_block_10min = new System.Windows.Forms.Label();
            this.lb_block_30min = new System.Windows.Forms.Label();
            this.gp_IotGroup = new System.Windows.Forms.GroupBox();
            this.rb_IOT_Group3 = new System.Windows.Forms.RadioButton();
            this.rb_IOT_Group2 = new System.Windows.Forms.RadioButton();
            this.rb_IOT_Group1 = new System.Windows.Forms.RadioButton();
            this.btn_GameSys_SetupMode = new System.Windows.Forms.Button();
            this.gp_GameSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.btn_GameSys_NarrantionPlay = new System.Windows.Forms.Button();
            this.cb_GameSys_Narration = new System.Windows.Forms.ComboBox();
            this.btn_GameSys_OSReset = new System.Windows.Forms.Button();
            this.btn_GameSys_SelfRevive = new System.Windows.Forms.Button();
            this.btn_GameSys_OS_Start = new System.Windows.Forms.Button();
            this.btn_GameSys_GameStop = new System.Windows.Forms.Button();
            this.btn_GameSys_VideoPlay = new System.Windows.Forms.Button();
            this.gp_MemeberSetup = new System.Windows.Forms.GroupBox();
            this.btn_GameSys_playPeople = new System.Windows.Forms.Button();
            this.rb_GameSys_7P = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_6P = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_5P = new System.Windows.Forms.RadioButton();
            this.rb_GameSys_4P = new System.Windows.Forms.RadioButton();
            this.btn_GameSys_ReadyMode = new System.Windows.Forms.Button();
            this.gp_GameSys_Progress = new System.Windows.Forms.GroupBox();
            this.lb_GameSys_CollectedTemple_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_CollectedTemple = new System.Windows.Forms.Label();
            this.lb_GameSys_SelfReviveTime = new System.Windows.Forms.Label();
            this.lb_GameSys_FixedGenerator_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_UsedRevive_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_OpenItembox_cnt = new System.Windows.Forms.Label();
            this.lb_GameSys_SelfRevive = new System.Windows.Forms.Label();
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
            this.lb_BD_name = new System.Windows.Forms.Label();
            this.btn_Door_send = new System.Windows.Forms.Button();
            this.lb_BD_state = new System.Windows.Forms.Label();
            this.lb_CD_name = new System.Windows.Forms.Label();
            this.cb_Door_state = new System.Windows.Forms.ComboBox();
            this.cb_Door_name = new System.Windows.Forms.ComboBox();
            this.lb_CD_state = new System.Windows.Forms.Label();
            this.gp_Temple = new System.Windows.Forms.GroupBox();
            this.btn_Temple_send = new System.Windows.Forms.Button();
            this.lb_LT_name = new System.Windows.Forms.Label();
            this.cb_Temple_state = new System.Windows.Forms.ComboBox();
            this.cb_Temple_name = new System.Windows.Forms.ComboBox();
            this.lb_LT_state = new System.Windows.Forms.Label();
            this.gp_ExerciseSys = new System.Windows.Forms.GroupBox();
            this.btn_ExerciseSys_trainroomMode = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_SkipMode = new System.Windows.Forms.Button();
            this.cb_TRM_Temple_autokiller = new System.Windows.Forms.CheckBox();
            this.gb_ExercisSys_iotMode = new System.Windows.Forms.GroupBox();
            this.rb_ExercisSys_hardMode = new System.Windows.Forms.RadioButton();
            this.rb_ExercisSys_easyMode = new System.Windows.Forms.RadioButton();
            this.rb_ExercisSys_normalMode = new System.Windows.Forms.RadioButton();
            this.gp_ExercisSys_iotGroup = new System.Windows.Forms.GroupBox();
            this.rb_ExerciseSys_iotG1 = new System.Windows.Forms.RadioButton();
            this.rb_ExerciseSys_iotG3 = new System.Windows.Forms.RadioButton();
            this.rb_ExerciseSys_iotG2 = new System.Windows.Forms.RadioButton();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.gp_ExerciseSys_Machine = new System.Windows.Forms.GroupBox();
            this.lb_ExerciseSys_ELW = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ELW_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EC_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EC = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EM_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EM = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ELE_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ELE = new System.Windows.Forms.Label();
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
            this.lb_ExerciseSys_ER_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_ER = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI2_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI1_State = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI2 = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_EI1 = new System.Windows.Forms.Label();
            this.gp_ExerciseSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.lb_Scenario = new System.Windows.Forms.Label();
            this.cb_ExerciseSys_Scenario = new System.Windows.Forms.ComboBox();
            this.btn_ExerciseSys_ScenarioSend = new System.Windows.Forms.Button();
            this.button26btn_ExerciseSys_LightOff = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_DeviceSend = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_ExerciseRmOn = new System.Windows.Forms.Button();
            this.cb_ExerciseSys_DeivceState = new System.Windows.Forms.ComboBox();
            this.btn_ExerciseSys_funcA = new System.Windows.Forms.Button();
            this.cb_ExerciseSys_DeviceName = new System.Windows.Forms.ComboBox();
            this.btn_ExerciseSys_Stop = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_MovingOn = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_WaitRmOff = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_SetupMode = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_ReadyMode = new System.Windows.Forms.Button();
            this.btn_ExerciseSys_Start = new System.Windows.Forms.Button();
            this.gp_ExerciseSys_timer = new System.Windows.Forms.GroupBox();
            this.lb_Exercise_progress = new System.Windows.Forms.Label();
            this.lb_Exercise_progress_name = new System.Windows.Forms.Label();
            this.lb_Exercise_device_time = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_timerStop = new System.Windows.Forms.Button();
            this.lb_Exercise_trm_time = new System.Windows.Forms.Label();
            this.btn_ExerciseSys_timerStart = new System.Windows.Forms.Button();
            this.lb_ExerciseSys_subtime = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_maintime = new System.Windows.Forms.Label();
            this.lb_ExerciseSys_Clock = new System.Windows.Forms.Label();
            this.cb_serialPort_TRM = new System.Windows.Forms.ComboBox();
            this.lb_serialPort_TRM = new System.Windows.Forms.Label();
            this.btn_serialPort_TRM_conn = new System.Windows.Forms.Button();
            this.btn_serialPort_TRM_disconn = new System.Windows.Forms.Button();
            this.tb_serialPort_TRM = new System.Windows.Forms.TextBox();
            this.gp_IotSys = new System.Windows.Forms.GroupBox();
            this.gp_IotSys_iotGroup = new System.Windows.Forms.GroupBox();
            this.rb_iotSys_iotG1 = new System.Windows.Forms.RadioButton();
            this.rb_iotSys_iotG2 = new System.Windows.Forms.RadioButton();
            this.gp_IotSys_ManualMode = new System.Windows.Forms.GroupBox();
            this.cb_IOTTemple_autokiller = new System.Windows.Forms.CheckBox();
            this.btn_IOTnightmode = new System.Windows.Forms.Button();
            this.btn_IOTdaymode = new System.Windows.Forms.Button();
            this.btn_IOTreset = new System.Windows.Forms.Button();
            this.btn_IOTtagON = new System.Windows.Forms.Button();
            this.btn_IOTVibeOFF = new System.Windows.Forms.Button();
            this.btn_IOTVibeON = new System.Windows.Forms.Button();
            this.btn_IotTest = new System.Windows.Forms.Button();
            this.btn_TagSel = new System.Windows.Forms.Button();
            this.btn_IOTVibeTest = new System.Windows.Forms.Button();
            this.btn_TagReSel = new System.Windows.Forms.Button();
            this.lb_programmedbyBBangJun = new System.Windows.Forms.Label();
            this.gp_IotSys_timer = new System.Windows.Forms.GroupBox();
            this.btn_IotSys_timerReset = new System.Windows.Forms.Button();
            this.btn_IotSys_timerStart = new System.Windows.Forms.Button();
            this.btn_IotSys_timerStop = new System.Windows.Forms.Button();
            this.lb_IotSys_Clock = new System.Windows.Forms.Label();
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
            this.lb_G2P9_state = new System.Windows.Forms.Label();
            this.lb_G2P7_state = new System.Windows.Forms.Label();
            this.lb_G2P6_state = new System.Windows.Forms.Label();
            this.lb_G2P5_state = new System.Windows.Forms.Label();
            this.lb_G2P4_state = new System.Windows.Forms.Label();
            this.lb_G2P3_state = new System.Windows.Forms.Label();
            this.lb_G2P2_state = new System.Windows.Forms.Label();
            this.lb_G2P1_state = new System.Windows.Forms.Label();
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
            this.serialPort_PCM = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_IOT = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_TRM = new System.IO.Ports.SerialPort(this.components);
            this.lb_BD_mode = new System.Windows.Forms.Label();
            this.lb_CD_mode = new System.Windows.Forms.Label();
            this.lb_SD_mode = new System.Windows.Forms.Label();
            this.lb_TD_mode = new System.Windows.Forms.Label();
            this.lb_BD_showtime = new System.Windows.Forms.Label();
            this.lb_CD_showtime = new System.Windows.Forms.Label();
            this.lb_SD_showtime = new System.Windows.Forms.Label();
            this.lb_TD_showtime = new System.Windows.Forms.Label();
            this.lb_BD_taggertime = new System.Windows.Forms.Label();
            this.lb_CD_taggertime = new System.Windows.Forms.Label();
            this.lb_SD_taggertime = new System.Windows.Forms.Label();
            this.lb_TD_taggertime = new System.Windows.Forms.Label();
            this.lb_LT_destroy = new System.Windows.Forms.Label();
            this.lb_LT_mode = new System.Windows.Forms.Label();
            this.gp_GameSys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_IotSys_Animation.SuspendLayout();
            this.lb_hard_duct_cooltime.SuspendLayout();
            this.tp_easymode.SuspendLayout();
            this.tc_easy_device.SuspendLayout();
            this.tp_easy_generator.SuspendLayout();
            this.tp_easy_Escape.SuspendLayout();
            this.tp_easy_itembox.SuspendLayout();
            this.tp_easy_gamedoor.SuspendLayout();
            this.tp_easy_duct.SuspendLayout();
            this.tp_normalmode.SuspendLayout();
            this.tc_normal_device.SuspendLayout();
            this.tp_normal_generator.SuspendLayout();
            this.tp_normal_escape.SuspendLayout();
            this.tp_normal_itembox.SuspendLayout();
            this.tp_normal_door.SuspendLayout();
            this.tp_normal_duct.SuspendLayout();
            this.tp_hardmode.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_hard_generator.SuspendLayout();
            this.tp_hard_escape.SuspendLayout();
            this.tp_hard_itembox.SuspendLayout();
            this.tp_hard_door.SuspendLayout();
            this.tp_hard_duct.SuspendLayout();
            this.gp_IotSys_waitingroom.SuspendLayout();
            this.gp_light_setup.SuspendLayout();
            this.gb_revive_rnd.SuspendLayout();
            this.gb_BlockTree.SuspendLayout();
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
            this.gb_ExercisSys_iotMode.SuspendLayout();
            this.gp_ExercisSys_iotGroup.SuspendLayout();
            this.gp_ExerciseSys_Machine.SuspendLayout();
            this.gp_ExerciseSys_ManualMode.SuspendLayout();
            this.gp_ExerciseSys_timer.SuspendLayout();
            this.gp_IotSys.SuspendLayout();
            this.gp_IotSys_iotGroup.SuspendLayout();
            this.gp_IotSys_ManualMode.SuspendLayout();
            this.gp_IotSys_timer.SuspendLayout();
            this.tc_serialPort_IOT.SuspendLayout();
            this.tp_G1.SuspendLayout();
            this.tp_G2.SuspendLayout();
            this.tp_G3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_serialPort_PCM_conn
            // 
            this.btn_serialPort_PCM_conn.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_PCM_conn.Location = new System.Drawing.Point(6, 617);
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
            this.btn_serialPort_PCM_disconn.Location = new System.Drawing.Point(166, 617);
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
            this.tb_serialPort_PCM.Size = new System.Drawing.Size(270, 415);
            this.tb_serialPort_PCM.TabIndex = 2;
            // 
            // gp_GameSys
            // 
            this.gp_GameSys.Controls.Add(this.btn_setting_light);
            this.gp_GameSys.Controls.Add(this.btn_serialPort_PCMerr_clipboardcopy);
            this.gp_GameSys.Controls.Add(this.tb_serialPort_PCM_err);
            this.gp_GameSys.Controls.Add(this.cb_silentStart);
            this.gp_GameSys.Controls.Add(this.button2);
            this.gp_GameSys.Controls.Add(this.comboBox1);
            this.gp_GameSys.Controls.Add(this.cb_Temple_autokiller);
            this.gp_GameSys.Controls.Add(this.groupBox1);
            this.gp_GameSys.Controls.Add(this.cb_gameModeAuto);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_currentState);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_ModeSetting);
            this.gp_GameSys.Controls.Add(this.gp_IotSys_Animation);
            this.gp_GameSys.Controls.Add(this.lb_GameSys_mode);
            this.gp_GameSys.Controls.Add(this.lb_hard_duct_cooltime);
            this.gp_GameSys.Controls.Add(this.cb_videoAfter_autoStart);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_GameStart);
            this.gp_GameSys.Controls.Add(this.cb_selfRevive_auto);
            this.gp_GameSys.Controls.Add(this.cb_iotAUTO);
            this.gp_GameSys.Controls.Add(this.gp_IotSys_waitingroom);
            this.gp_GameSys.Controls.Add(this.gp_light_setup);
            this.gp_GameSys.Controls.Add(this.gb_revive_rnd);
            this.gp_GameSys.Controls.Add(this.gb_BlockTree);
            this.gp_GameSys.Controls.Add(this.gp_IotGroup);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_SetupMode);
            this.gp_GameSys.Controls.Add(this.gp_GameSys_ManualMode);
            this.gp_GameSys.Controls.Add(this.gp_MemeberSetup);
            this.gp_GameSys.Controls.Add(this.btn_GameSys_ReadyMode);
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
            // btn_setting_light
            // 
            this.btn_setting_light.BackColor = System.Drawing.Color.Green;
            this.btn_setting_light.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setting_light.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_setting_light.Location = new System.Drawing.Point(781, 786);
            this.btn_setting_light.Name = "btn_setting_light";
            this.btn_setting_light.Size = new System.Drawing.Size(205, 28);
            this.btn_setting_light.TabIndex = 93;
            this.btn_setting_light.Text = "청소등 ON";
            this.btn_setting_light.UseVisualStyleBackColor = false;
            this.btn_setting_light.Click += new System.EventHandler(this.btn_setting_light_Click);
            // 
            // btn_serialPort_PCMerr_clipboardcopy
            // 
            this.btn_serialPort_PCMerr_clipboardcopy.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serialPort_PCMerr_clipboardcopy.Location = new System.Drawing.Point(212, 584);
            this.btn_serialPort_PCMerr_clipboardcopy.Name = "btn_serialPort_PCMerr_clipboardcopy";
            this.btn_serialPort_PCMerr_clipboardcopy.Size = new System.Drawing.Size(64, 27);
            this.btn_serialPort_PCMerr_clipboardcopy.TabIndex = 96;
            this.btn_serialPort_PCMerr_clipboardcopy.Text = "오류 복사";
            this.btn_serialPort_PCMerr_clipboardcopy.UseVisualStyleBackColor = true;
            this.btn_serialPort_PCMerr_clipboardcopy.Click += new System.EventHandler(this.btn_serialPort_PCMerr_clipboardcopy_Click);
            // 
            // tb_serialPort_PCM_err
            // 
            this.tb_serialPort_PCM_err.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_serialPort_PCM_err.Location = new System.Drawing.Point(6, 442);
            this.tb_serialPort_PCM_err.Multiline = true;
            this.tb_serialPort_PCM_err.Name = "tb_serialPort_PCM_err";
            this.tb_serialPort_PCM_err.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serialPort_PCM_err.Size = new System.Drawing.Size(270, 136);
            this.tb_serialPort_PCM_err.TabIndex = 95;
            // 
            // cb_silentStart
            // 
            this.cb_silentStart.AutoSize = true;
            this.cb_silentStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_silentStart.ForeColor = System.Drawing.Color.Red;
            this.cb_silentStart.Location = new System.Drawing.Point(891, 656);
            this.cb_silentStart.Name = "cb_silentStart";
            this.cb_silentStart.Size = new System.Drawing.Size(117, 17);
            this.cb_silentStart.TabIndex = 94;
            this.cb_silentStart.Text = "쉿! 침묵의 007빵!";
            this.cb_silentStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_silentStart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(989, 963);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 93;
            this.button2.Text = "대표전용 나레이션";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0001 기획자가 잡혔쥬",
            "0002 대표가 입장합니다",
            "0003 어쩔티비송",
            "0004 응 못죽이죠~",
            "0005 응 대표가 게임 이해 못했쥬"});
            this.comboBox1.Location = new System.Drawing.Point(988, 930);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
            this.comboBox1.TabIndex = 92;
            this.comboBox1.Text = "태겸용";
            // 
            // cb_Temple_autokiller
            // 
            this.cb_Temple_autokiller.AutoSize = true;
            this.cb_Temple_autokiller.Checked = true;
            this.cb_Temple_autokiller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Temple_autokiller.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Temple_autokiller.Location = new System.Drawing.Point(891, 684);
            this.cb_Temple_autokiller.Name = "cb_Temple_autokiller";
            this.cb_Temple_autokiller.Size = new System.Drawing.Size(95, 17);
            this.cb_Temple_autokiller.TabIndex = 91;
            this.cb_Temple_autokiller.Text = "제단 술래결정";
            this.cb_Temple_autokiller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Temple_autokiller.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(780, 816);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 85);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "마우스 보관함";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(173, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_gameModeAuto
            // 
            this.cb_gameModeAuto.AutoSize = true;
            this.cb_gameModeAuto.Checked = true;
            this.cb_gameModeAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gameModeAuto.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_gameModeAuto.Location = new System.Drawing.Point(891, 705);
            this.cb_gameModeAuto.Name = "cb_gameModeAuto";
            this.cb_gameModeAuto.Size = new System.Drawing.Size(73, 17);
            this.cb_gameModeAuto.TabIndex = 89;
            this.cb_gameModeAuto.Text = "자동 모드";
            this.cb_gameModeAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_gameModeAuto.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_currentState
            // 
            this.btn_GameSys_currentState.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_GameSys_currentState.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_currentState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GameSys_currentState.Location = new System.Drawing.Point(988, 674);
            this.btn_GameSys_currentState.Name = "btn_GameSys_currentState";
            this.btn_GameSys_currentState.Size = new System.Drawing.Size(156, 45);
            this.btn_GameSys_currentState.TabIndex = 88;
            this.btn_GameSys_currentState.Text = "전체 장치확인";
            this.btn_GameSys_currentState.UseVisualStyleBackColor = false;
            this.btn_GameSys_currentState.Click += new System.EventHandler(this.btn_GameSys_currentState_Click);
            // 
            // btn_GameSys_ModeSetting
            // 
            this.btn_GameSys_ModeSetting.BackColor = System.Drawing.Color.Gray;
            this.btn_GameSys_ModeSetting.Font = new System.Drawing.Font("타이포_쌍문동 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_ModeSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GameSys_ModeSetting.Location = new System.Drawing.Point(1062, 594);
            this.btn_GameSys_ModeSetting.Name = "btn_GameSys_ModeSetting";
            this.btn_GameSys_ModeSetting.Size = new System.Drawing.Size(87, 59);
            this.btn_GameSys_ModeSetting.TabIndex = 87;
            this.btn_GameSys_ModeSetting.Text = "게임모드 \r\n설정";
            this.btn_GameSys_ModeSetting.UseVisualStyleBackColor = false;
            this.btn_GameSys_ModeSetting.Click += new System.EventHandler(this.btn_GameSys_ModeSetting_Click);
            // 
            // gp_IotSys_Animation
            // 
            this.gp_IotSys_Animation.Controls.Add(this.btn_ExerciseSys_VideoStart);
            this.gp_IotSys_Animation.Controls.Add(this.btn_ExerciseSys_AnimationOn);
            this.gp_IotSys_Animation.Controls.Add(this.btn_ExerciseSys_VideoStop);
            this.gp_IotSys_Animation.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotSys_Animation.Location = new System.Drawing.Point(781, 659);
            this.gp_IotSys_Animation.Name = "gp_IotSys_Animation";
            this.gp_IotSys_Animation.Size = new System.Drawing.Size(106, 128);
            this.gp_IotSys_Animation.TabIndex = 72;
            this.gp_IotSys_Animation.TabStop = false;
            this.gp_IotSys_Animation.Text = "영상관리";
            // 
            // btn_ExerciseSys_VideoStart
            // 
            this.btn_ExerciseSys_VideoStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ExerciseSys_VideoStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_VideoStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ExerciseSys_VideoStart.Location = new System.Drawing.Point(6, 25);
            this.btn_ExerciseSys_VideoStart.Name = "btn_ExerciseSys_VideoStart";
            this.btn_ExerciseSys_VideoStart.Size = new System.Drawing.Size(94, 40);
            this.btn_ExerciseSys_VideoStart.TabIndex = 77;
            this.btn_ExerciseSys_VideoStart.Text = "영상시작";
            this.btn_ExerciseSys_VideoStart.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_VideoStart.Click += new System.EventHandler(this.btn_ExerciseSys_VideoStart_Click);
            // 
            // btn_ExerciseSys_AnimationOn
            // 
            this.btn_ExerciseSys_AnimationOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_AnimationOn.Location = new System.Drawing.Point(6, 67);
            this.btn_ExerciseSys_AnimationOn.Name = "btn_ExerciseSys_AnimationOn";
            this.btn_ExerciseSys_AnimationOn.Size = new System.Drawing.Size(94, 28);
            this.btn_ExerciseSys_AnimationOn.TabIndex = 72;
            this.btn_ExerciseSys_AnimationOn.Text = "애니 ON";
            this.btn_ExerciseSys_AnimationOn.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_AnimationOn.Click += new System.EventHandler(this.btn_ExerciseSys_AnimationOn_Click);
            // 
            // btn_ExerciseSys_VideoStop
            // 
            this.btn_ExerciseSys_VideoStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_VideoStop.Location = new System.Drawing.Point(6, 96);
            this.btn_ExerciseSys_VideoStop.Name = "btn_ExerciseSys_VideoStop";
            this.btn_ExerciseSys_VideoStop.Size = new System.Drawing.Size(94, 27);
            this.btn_ExerciseSys_VideoStop.TabIndex = 71;
            this.btn_ExerciseSys_VideoStop.Text = "영상스탑";
            this.btn_ExerciseSys_VideoStop.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_VideoStop.Click += new System.EventHandler(this.btn_ExerciseSys_VideoStop_Click);
            // 
            // lb_GameSys_mode
            // 
            this.lb_GameSys_mode.AutoSize = true;
            this.lb_GameSys_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GameSys_mode.Location = new System.Drawing.Point(1060, 568);
            this.lb_GameSys_mode.Name = "lb_GameSys_mode";
            this.lb_GameSys_mode.Size = new System.Drawing.Size(89, 19);
            this.lb_GameSys_mode.TabIndex = 86;
            this.lb_GameSys_mode.Text = "일반 MODE";
            // 
            // lb_hard_duct_cooltime
            // 
            this.lb_hard_duct_cooltime.Controls.Add(this.tp_easymode);
            this.lb_hard_duct_cooltime.Controls.Add(this.tp_normalmode);
            this.lb_hard_duct_cooltime.Controls.Add(this.tp_hardmode);
            this.lb_hard_duct_cooltime.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hard_duct_cooltime.Location = new System.Drawing.Point(6, 795);
            this.lb_hard_duct_cooltime.Name = "lb_hard_duct_cooltime";
            this.lb_hard_duct_cooltime.SelectedIndex = 0;
            this.lb_hard_duct_cooltime.Size = new System.Drawing.Size(377, 198);
            this.lb_hard_duct_cooltime.TabIndex = 0;
            // 
            // tp_easymode
            // 
            this.tp_easymode.Controls.Add(this.tc_easy_device);
            this.tp_easymode.Location = new System.Drawing.Point(4, 22);
            this.tp_easymode.Name = "tp_easymode";
            this.tp_easymode.Padding = new System.Windows.Forms.Padding(3);
            this.tp_easymode.Size = new System.Drawing.Size(369, 172);
            this.tp_easymode.TabIndex = 0;
            this.tp_easymode.Text = "뉴비모드";
            this.tp_easymode.UseVisualStyleBackColor = true;
            // 
            // tc_easy_device
            // 
            this.tc_easy_device.Controls.Add(this.tp_easy_generator);
            this.tc_easy_device.Controls.Add(this.tp_easy_Escape);
            this.tc_easy_device.Controls.Add(this.tp_easy_itembox);
            this.tc_easy_device.Controls.Add(this.tp_easy_gamedoor);
            this.tc_easy_device.Controls.Add(this.tp_easy_duct);
            this.tc_easy_device.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tc_easy_device.Location = new System.Drawing.Point(6, 6);
            this.tc_easy_device.Name = "tc_easy_device";
            this.tc_easy_device.SelectedIndex = 0;
            this.tc_easy_device.Size = new System.Drawing.Size(360, 163);
            this.tc_easy_device.TabIndex = 86;
            // 
            // tp_easy_generator
            // 
            this.tp_easy_generator.Controls.Add(this.tb_easy_generator_B3);
            this.tp_easy_generator.Controls.Add(this.tb_easy_generator_B2);
            this.tp_easy_generator.Controls.Add(this.lb_easy_generator_B3);
            this.tp_easy_generator.Controls.Add(this.lb_easy_generator_B2);
            this.tp_easy_generator.Controls.Add(this.tb_easy_generator_B1);
            this.tp_easy_generator.Controls.Add(this.lb_easy_generator_B1);
            this.tp_easy_generator.Controls.Add(this.lb_easy_generator_starter);
            this.tp_easy_generator.Controls.Add(this.tb_easy_generator_starter);
            this.tp_easy_generator.Location = new System.Drawing.Point(4, 22);
            this.tp_easy_generator.Name = "tp_easy_generator";
            this.tp_easy_generator.Padding = new System.Windows.Forms.Padding(3);
            this.tp_easy_generator.Size = new System.Drawing.Size(352, 137);
            this.tp_easy_generator.TabIndex = 0;
            this.tp_easy_generator.Text = "발전기";
            this.tp_easy_generator.UseVisualStyleBackColor = true;
            // 
            // tb_easy_generator_B3
            // 
            this.tb_easy_generator_B3.Location = new System.Drawing.Point(123, 89);
            this.tb_easy_generator_B3.Name = "tb_easy_generator_B3";
            this.tb_easy_generator_B3.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_generator_B3.TabIndex = 8;
            this.tb_easy_generator_B3.Text = "180";
            // 
            // tb_easy_generator_B2
            // 
            this.tb_easy_generator_B2.Location = new System.Drawing.Point(123, 62);
            this.tb_easy_generator_B2.Name = "tb_easy_generator_B2";
            this.tb_easy_generator_B2.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_generator_B2.TabIndex = 7;
            this.tb_easy_generator_B2.Text = "120";
            // 
            // lb_easy_generator_B3
            // 
            this.lb_easy_generator_B3.AutoSize = true;
            this.lb_easy_generator_B3.Location = new System.Drawing.Point(11, 93);
            this.lb_easy_generator_B3.Name = "lb_easy_generator_B3";
            this.lb_easy_generator_B3.Size = new System.Drawing.Size(110, 13);
            this.lb_easy_generator_B3.TabIndex = 5;
            this.lb_easy_generator_B3.Text = "봉쇄 3단계 시간(초):";
            // 
            // lb_easy_generator_B2
            // 
            this.lb_easy_generator_B2.AutoSize = true;
            this.lb_easy_generator_B2.Location = new System.Drawing.Point(11, 66);
            this.lb_easy_generator_B2.Name = "lb_easy_generator_B2";
            this.lb_easy_generator_B2.Size = new System.Drawing.Size(110, 13);
            this.lb_easy_generator_B2.TabIndex = 4;
            this.lb_easy_generator_B2.Text = "봉쇄 2단계 시간(초):";
            // 
            // tb_easy_generator_B1
            // 
            this.tb_easy_generator_B1.Location = new System.Drawing.Point(123, 35);
            this.tb_easy_generator_B1.Name = "tb_easy_generator_B1";
            this.tb_easy_generator_B1.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_generator_B1.TabIndex = 3;
            this.tb_easy_generator_B1.Text = "60";
            // 
            // lb_easy_generator_B1
            // 
            this.lb_easy_generator_B1.AutoSize = true;
            this.lb_easy_generator_B1.Location = new System.Drawing.Point(11, 39);
            this.lb_easy_generator_B1.Name = "lb_easy_generator_B1";
            this.lb_easy_generator_B1.Size = new System.Drawing.Size(110, 13);
            this.lb_easy_generator_B1.TabIndex = 2;
            this.lb_easy_generator_B1.Text = "봉쇄 1단계 시간(초):";
            // 
            // lb_easy_generator_starter
            // 
            this.lb_easy_generator_starter.AutoSize = true;
            this.lb_easy_generator_starter.Location = new System.Drawing.Point(52, 11);
            this.lb_easy_generator_starter.Name = "lb_easy_generator_starter";
            this.lb_easy_generator_starter.Size = new System.Drawing.Size(69, 13);
            this.lb_easy_generator_starter.TabIndex = 1;
            this.lb_easy_generator_starter.Text = "스타터 횟수:";
            // 
            // tb_easy_generator_starter
            // 
            this.tb_easy_generator_starter.Location = new System.Drawing.Point(123, 7);
            this.tb_easy_generator_starter.Name = "tb_easy_generator_starter";
            this.tb_easy_generator_starter.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_generator_starter.TabIndex = 0;
            this.tb_easy_generator_starter.Text = "2";
            // 
            // tp_easy_Escape
            // 
            this.tp_easy_Escape.Controls.Add(this.lb_easy_escape_Btime);
            this.tp_easy_Escape.Controls.Add(this.tb_easy_escape_Btime);
            this.tp_easy_Escape.Location = new System.Drawing.Point(4, 22);
            this.tp_easy_Escape.Name = "tp_easy_Escape";
            this.tp_easy_Escape.Padding = new System.Windows.Forms.Padding(3);
            this.tp_easy_Escape.Size = new System.Drawing.Size(352, 137);
            this.tp_easy_Escape.TabIndex = 1;
            this.tp_easy_Escape.Text = "탈출장치";
            this.tp_easy_Escape.UseVisualStyleBackColor = true;
            // 
            // lb_easy_escape_Btime
            // 
            this.lb_easy_escape_Btime.AutoSize = true;
            this.lb_easy_escape_Btime.Location = new System.Drawing.Point(11, 11);
            this.lb_easy_escape_Btime.Name = "lb_easy_escape_Btime";
            this.lb_easy_escape_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_easy_escape_Btime.TabIndex = 3;
            this.lb_easy_escape_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_easy_escape_Btime
            // 
            this.tb_easy_escape_Btime.Location = new System.Drawing.Point(90, 7);
            this.tb_easy_escape_Btime.Name = "tb_easy_escape_Btime";
            this.tb_easy_escape_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_escape_Btime.TabIndex = 2;
            this.tb_easy_escape_Btime.Text = "120";
            // 
            // tp_easy_itembox
            // 
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_Btime);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_Btime);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ansarea);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ansarea);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_anscnt);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_anscnt);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ans5);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ans5);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ans4);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ans3);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ans4);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ans3);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ans2);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ans2);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_ans1);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_ans1);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_vibe5);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_vibe5);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_vibe4);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_vibe3);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_vibe4);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_vibe3);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_vibe2);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_vibe2);
            this.tp_easy_itembox.Controls.Add(this.lb_easy_itembox_vibe1);
            this.tp_easy_itembox.Controls.Add(this.tb_easy_itembox_vibe1);
            this.tp_easy_itembox.Location = new System.Drawing.Point(4, 22);
            this.tp_easy_itembox.Name = "tp_easy_itembox";
            this.tp_easy_itembox.Size = new System.Drawing.Size(352, 137);
            this.tp_easy_itembox.TabIndex = 2;
            this.tp_easy_itembox.Text = "아이템박스";
            this.tp_easy_itembox.UseVisualStyleBackColor = true;
            // 
            // tb_easy_itembox_Btime
            // 
            this.tb_easy_itembox_Btime.Location = new System.Drawing.Point(310, 58);
            this.tb_easy_itembox_Btime.Name = "tb_easy_itembox_Btime";
            this.tb_easy_itembox_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_Btime.TabIndex = 35;
            this.tb_easy_itembox_Btime.Text = "180";
            // 
            // lb_easy_itembox_Btime
            // 
            this.lb_easy_itembox_Btime.AutoSize = true;
            this.lb_easy_itembox_Btime.Location = new System.Drawing.Point(231, 62);
            this.lb_easy_itembox_Btime.Name = "lb_easy_itembox_Btime";
            this.lb_easy_itembox_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_easy_itembox_Btime.TabIndex = 33;
            this.lb_easy_itembox_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_easy_itembox_ansarea
            // 
            this.tb_easy_itembox_ansarea.Location = new System.Drawing.Point(310, 31);
            this.tb_easy_itembox_ansarea.Name = "tb_easy_itembox_ansarea";
            this.tb_easy_itembox_ansarea.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ansarea.TabIndex = 32;
            this.tb_easy_itembox_ansarea.Text = "3";
            // 
            // lb_easy_itembox_ansarea
            // 
            this.lb_easy_itembox_ansarea.AutoSize = true;
            this.lb_easy_itembox_ansarea.Location = new System.Drawing.Point(250, 35);
            this.lb_easy_itembox_ansarea.Name = "lb_easy_itembox_ansarea";
            this.lb_easy_itembox_ansarea.Size = new System.Drawing.Size(58, 13);
            this.lb_easy_itembox_ansarea.TabIndex = 31;
            this.lb_easy_itembox_ansarea.Text = "정답 범위:";
            // 
            // lb_easy_itembox_anscnt
            // 
            this.lb_easy_itembox_anscnt.AutoSize = true;
            this.lb_easy_itembox_anscnt.Location = new System.Drawing.Point(250, 8);
            this.lb_easy_itembox_anscnt.Name = "lb_easy_itembox_anscnt";
            this.lb_easy_itembox_anscnt.Size = new System.Drawing.Size(58, 13);
            this.lb_easy_itembox_anscnt.TabIndex = 30;
            this.lb_easy_itembox_anscnt.Text = "정답 개수:";
            // 
            // tb_easy_itembox_anscnt
            // 
            this.tb_easy_itembox_anscnt.Location = new System.Drawing.Point(310, 4);
            this.tb_easy_itembox_anscnt.Name = "tb_easy_itembox_anscnt";
            this.tb_easy_itembox_anscnt.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_anscnt.TabIndex = 29;
            this.tb_easy_itembox_anscnt.Text = "2";
            // 
            // tb_easy_itembox_ans5
            // 
            this.tb_easy_itembox_ans5.Location = new System.Drawing.Point(192, 112);
            this.tb_easy_itembox_ans5.Name = "tb_easy_itembox_ans5";
            this.tb_easy_itembox_ans5.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ans5.TabIndex = 28;
            this.tb_easy_itembox_ans5.Text = "0";
            // 
            // lb_easy_itembox_ans5
            // 
            this.lb_easy_itembox_ans5.AutoSize = true;
            this.lb_easy_itembox_ans5.Location = new System.Drawing.Point(110, 116);
            this.lb_easy_itembox_ans5.Name = "lb_easy_itembox_ans5";
            this.lb_easy_itembox_ans5.Size = new System.Drawing.Size(80, 13);
            this.lb_easy_itembox_ans5.TabIndex = 27;
            this.lb_easy_itembox_ans5.Text = "다섯번째 정답:";
            // 
            // tb_easy_itembox_ans4
            // 
            this.tb_easy_itembox_ans4.Location = new System.Drawing.Point(192, 85);
            this.tb_easy_itembox_ans4.Name = "tb_easy_itembox_ans4";
            this.tb_easy_itembox_ans4.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ans4.TabIndex = 26;
            this.tb_easy_itembox_ans4.Text = "0";
            // 
            // tb_easy_itembox_ans3
            // 
            this.tb_easy_itembox_ans3.Location = new System.Drawing.Point(192, 58);
            this.tb_easy_itembox_ans3.Name = "tb_easy_itembox_ans3";
            this.tb_easy_itembox_ans3.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ans3.TabIndex = 25;
            this.tb_easy_itembox_ans3.Text = "15";
            // 
            // lb_easy_itembox_ans4
            // 
            this.lb_easy_itembox_ans4.AutoSize = true;
            this.lb_easy_itembox_ans4.Location = new System.Drawing.Point(121, 89);
            this.lb_easy_itembox_ans4.Name = "lb_easy_itembox_ans4";
            this.lb_easy_itembox_ans4.Size = new System.Drawing.Size(69, 13);
            this.lb_easy_itembox_ans4.TabIndex = 24;
            this.lb_easy_itembox_ans4.Text = "네번째 정답:";
            // 
            // lb_easy_itembox_ans3
            // 
            this.lb_easy_itembox_ans3.AutoSize = true;
            this.lb_easy_itembox_ans3.Location = new System.Drawing.Point(121, 62);
            this.lb_easy_itembox_ans3.Name = "lb_easy_itembox_ans3";
            this.lb_easy_itembox_ans3.Size = new System.Drawing.Size(69, 13);
            this.lb_easy_itembox_ans3.TabIndex = 23;
            this.lb_easy_itembox_ans3.Text = "세번째 정답:";
            // 
            // tb_easy_itembox_ans2
            // 
            this.tb_easy_itembox_ans2.Location = new System.Drawing.Point(192, 31);
            this.tb_easy_itembox_ans2.Name = "tb_easy_itembox_ans2";
            this.tb_easy_itembox_ans2.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ans2.TabIndex = 22;
            this.tb_easy_itembox_ans2.Text = "10";
            // 
            // lb_easy_itembox_ans2
            // 
            this.lb_easy_itembox_ans2.AutoSize = true;
            this.lb_easy_itembox_ans2.Location = new System.Drawing.Point(121, 35);
            this.lb_easy_itembox_ans2.Name = "lb_easy_itembox_ans2";
            this.lb_easy_itembox_ans2.Size = new System.Drawing.Size(69, 13);
            this.lb_easy_itembox_ans2.TabIndex = 21;
            this.lb_easy_itembox_ans2.Text = "두번째 정답:";
            // 
            // lb_easy_itembox_ans1
            // 
            this.lb_easy_itembox_ans1.AutoSize = true;
            this.lb_easy_itembox_ans1.Location = new System.Drawing.Point(121, 8);
            this.lb_easy_itembox_ans1.Name = "lb_easy_itembox_ans1";
            this.lb_easy_itembox_ans1.Size = new System.Drawing.Size(69, 13);
            this.lb_easy_itembox_ans1.TabIndex = 20;
            this.lb_easy_itembox_ans1.Text = "첫번째 정답:";
            // 
            // tb_easy_itembox_ans1
            // 
            this.tb_easy_itembox_ans1.Location = new System.Drawing.Point(192, 4);
            this.tb_easy_itembox_ans1.Name = "tb_easy_itembox_ans1";
            this.tb_easy_itembox_ans1.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_ans1.TabIndex = 19;
            this.tb_easy_itembox_ans1.Text = "5";
            // 
            // tb_easy_itembox_vibe5
            // 
            this.tb_easy_itembox_vibe5.Location = new System.Drawing.Point(70, 112);
            this.tb_easy_itembox_vibe5.Name = "tb_easy_itembox_vibe5";
            this.tb_easy_itembox_vibe5.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_vibe5.TabIndex = 18;
            this.tb_easy_itembox_vibe5.Text = "0";
            // 
            // lb_easy_itembox_vibe5
            // 
            this.lb_easy_itembox_vibe5.AutoSize = true;
            this.lb_easy_itembox_vibe5.Location = new System.Drawing.Point(2, 116);
            this.lb_easy_itembox_vibe5.Name = "lb_easy_itembox_vibe5";
            this.lb_easy_itembox_vibe5.Size = new System.Drawing.Size(66, 13);
            this.lb_easy_itembox_vibe5.TabIndex = 17;
            this.lb_easy_itembox_vibe5.Text = "4범위 진동:";
            // 
            // tb_easy_itembox_vibe4
            // 
            this.tb_easy_itembox_vibe4.Location = new System.Drawing.Point(70, 85);
            this.tb_easy_itembox_vibe4.Name = "tb_easy_itembox_vibe4";
            this.tb_easy_itembox_vibe4.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_vibe4.TabIndex = 16;
            this.tb_easy_itembox_vibe4.Text = "0";
            // 
            // tb_easy_itembox_vibe3
            // 
            this.tb_easy_itembox_vibe3.Location = new System.Drawing.Point(70, 58);
            this.tb_easy_itembox_vibe3.Name = "tb_easy_itembox_vibe3";
            this.tb_easy_itembox_vibe3.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_vibe3.TabIndex = 15;
            this.tb_easy_itembox_vibe3.Text = "0";
            // 
            // lb_easy_itembox_vibe4
            // 
            this.lb_easy_itembox_vibe4.AutoSize = true;
            this.lb_easy_itembox_vibe4.Location = new System.Drawing.Point(2, 89);
            this.lb_easy_itembox_vibe4.Name = "lb_easy_itembox_vibe4";
            this.lb_easy_itembox_vibe4.Size = new System.Drawing.Size(66, 13);
            this.lb_easy_itembox_vibe4.TabIndex = 14;
            this.lb_easy_itembox_vibe4.Text = "3범위 진동:";
            // 
            // lb_easy_itembox_vibe3
            // 
            this.lb_easy_itembox_vibe3.AutoSize = true;
            this.lb_easy_itembox_vibe3.Location = new System.Drawing.Point(2, 62);
            this.lb_easy_itembox_vibe3.Name = "lb_easy_itembox_vibe3";
            this.lb_easy_itembox_vibe3.Size = new System.Drawing.Size(66, 13);
            this.lb_easy_itembox_vibe3.TabIndex = 13;
            this.lb_easy_itembox_vibe3.Text = "2범위 진동:";
            // 
            // tb_easy_itembox_vibe2
            // 
            this.tb_easy_itembox_vibe2.Location = new System.Drawing.Point(70, 31);
            this.tb_easy_itembox_vibe2.Name = "tb_easy_itembox_vibe2";
            this.tb_easy_itembox_vibe2.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_vibe2.TabIndex = 12;
            this.tb_easy_itembox_vibe2.Text = "0";
            // 
            // lb_easy_itembox_vibe2
            // 
            this.lb_easy_itembox_vibe2.AutoSize = true;
            this.lb_easy_itembox_vibe2.Location = new System.Drawing.Point(2, 35);
            this.lb_easy_itembox_vibe2.Name = "lb_easy_itembox_vibe2";
            this.lb_easy_itembox_vibe2.Size = new System.Drawing.Size(66, 13);
            this.lb_easy_itembox_vibe2.TabIndex = 11;
            this.lb_easy_itembox_vibe2.Text = "1범위 진동:";
            // 
            // lb_easy_itembox_vibe1
            // 
            this.lb_easy_itembox_vibe1.AutoSize = true;
            this.lb_easy_itembox_vibe1.Location = new System.Drawing.Point(10, 8);
            this.lb_easy_itembox_vibe1.Name = "lb_easy_itembox_vibe1";
            this.lb_easy_itembox_vibe1.Size = new System.Drawing.Size(58, 13);
            this.lb_easy_itembox_vibe1.TabIndex = 10;
            this.lb_easy_itembox_vibe1.Text = "정답 진동:";
            // 
            // tb_easy_itembox_vibe1
            // 
            this.tb_easy_itembox_vibe1.Location = new System.Drawing.Point(70, 4);
            this.tb_easy_itembox_vibe1.Name = "tb_easy_itembox_vibe1";
            this.tb_easy_itembox_vibe1.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_itembox_vibe1.TabIndex = 9;
            this.tb_easy_itembox_vibe1.Text = "200";
            // 
            // tp_easy_gamedoor
            // 
            this.tp_easy_gamedoor.Controls.Add(this.lb_easy_door_autolock);
            this.tp_easy_gamedoor.Controls.Add(this.tb_easy_door_autolock);
            this.tp_easy_gamedoor.Location = new System.Drawing.Point(4, 22);
            this.tp_easy_gamedoor.Name = "tp_easy_gamedoor";
            this.tp_easy_gamedoor.Size = new System.Drawing.Size(352, 137);
            this.tp_easy_gamedoor.TabIndex = 3;
            this.tp_easy_gamedoor.Text = "게임도어";
            this.tp_easy_gamedoor.UseVisualStyleBackColor = true;
            // 
            // lb_easy_door_autolock
            // 
            this.lb_easy_door_autolock.AutoSize = true;
            this.lb_easy_door_autolock.Location = new System.Drawing.Point(11, 11);
            this.lb_easy_door_autolock.Name = "lb_easy_door_autolock";
            this.lb_easy_door_autolock.Size = new System.Drawing.Size(102, 13);
            this.lb_easy_door_autolock.TabIndex = 12;
            this.lb_easy_door_autolock.Text = "자동 잠금 주기(초):";
            // 
            // tb_easy_door_autolock
            // 
            this.tb_easy_door_autolock.Location = new System.Drawing.Point(115, 7);
            this.tb_easy_door_autolock.Name = "tb_easy_door_autolock";
            this.tb_easy_door_autolock.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_door_autolock.TabIndex = 11;
            this.tb_easy_door_autolock.Text = "180";
            // 
            // tp_easy_duct
            // 
            this.tp_easy_duct.Controls.Add(this.tb_easy_vent_cooltime_addup);
            this.tp_easy_duct.Controls.Add(this.lb_easy_vent_cooltime_addup);
            this.tp_easy_duct.Controls.Add(this.lb_easy_vent_cooltime);
            this.tp_easy_duct.Controls.Add(this.tb_easy_vent_cooltime);
            this.tp_easy_duct.Location = new System.Drawing.Point(4, 22);
            this.tp_easy_duct.Name = "tp_easy_duct";
            this.tp_easy_duct.Size = new System.Drawing.Size(352, 137);
            this.tp_easy_duct.TabIndex = 4;
            this.tp_easy_duct.Text = "덕트";
            this.tp_easy_duct.UseVisualStyleBackColor = true;
            // 
            // tb_easy_vent_cooltime_addup
            // 
            this.tb_easy_vent_cooltime_addup.Location = new System.Drawing.Point(112, 32);
            this.tb_easy_vent_cooltime_addup.Name = "tb_easy_vent_cooltime_addup";
            this.tb_easy_vent_cooltime_addup.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_vent_cooltime_addup.TabIndex = 16;
            this.tb_easy_vent_cooltime_addup.Text = "0";
            // 
            // lb_easy_vent_cooltime_addup
            // 
            this.lb_easy_vent_cooltime_addup.AutoSize = true;
            this.lb_easy_vent_cooltime_addup.Location = new System.Drawing.Point(11, 36);
            this.lb_easy_vent_cooltime_addup.Name = "lb_easy_vent_cooltime_addup";
            this.lb_easy_vent_cooltime_addup.Size = new System.Drawing.Size(99, 13);
            this.lb_easy_vent_cooltime_addup.TabIndex = 15;
            this.lb_easy_vent_cooltime_addup.Text = "쿨타임 증가량(초):";
            // 
            // lb_easy_vent_cooltime
            // 
            this.lb_easy_vent_cooltime.AutoSize = true;
            this.lb_easy_vent_cooltime.Location = new System.Drawing.Point(47, 11);
            this.lb_easy_vent_cooltime.Name = "lb_easy_vent_cooltime";
            this.lb_easy_vent_cooltime.Size = new System.Drawing.Size(63, 13);
            this.lb_easy_vent_cooltime.TabIndex = 14;
            this.lb_easy_vent_cooltime.Text = "쿨타임(초):";
            // 
            // tb_easy_vent_cooltime
            // 
            this.tb_easy_vent_cooltime.Location = new System.Drawing.Point(112, 7);
            this.tb_easy_vent_cooltime.Name = "tb_easy_vent_cooltime";
            this.tb_easy_vent_cooltime.Size = new System.Drawing.Size(35, 21);
            this.tb_easy_vent_cooltime.TabIndex = 13;
            this.tb_easy_vent_cooltime.Text = "10";
            // 
            // tp_normalmode
            // 
            this.tp_normalmode.Controls.Add(this.tc_normal_device);
            this.tp_normalmode.Location = new System.Drawing.Point(4, 22);
            this.tp_normalmode.Name = "tp_normalmode";
            this.tp_normalmode.Padding = new System.Windows.Forms.Padding(3);
            this.tp_normalmode.Size = new System.Drawing.Size(369, 172);
            this.tp_normalmode.TabIndex = 1;
            this.tp_normalmode.Text = "일반모드";
            this.tp_normalmode.UseVisualStyleBackColor = true;
            // 
            // tc_normal_device
            // 
            this.tc_normal_device.Controls.Add(this.tp_normal_generator);
            this.tc_normal_device.Controls.Add(this.tp_normal_escape);
            this.tc_normal_device.Controls.Add(this.tp_normal_itembox);
            this.tc_normal_device.Controls.Add(this.tp_normal_door);
            this.tc_normal_device.Controls.Add(this.tp_normal_duct);
            this.tc_normal_device.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tc_normal_device.Location = new System.Drawing.Point(6, 6);
            this.tc_normal_device.Name = "tc_normal_device";
            this.tc_normal_device.SelectedIndex = 0;
            this.tc_normal_device.Size = new System.Drawing.Size(357, 160);
            this.tc_normal_device.TabIndex = 87;
            // 
            // tp_normal_generator
            // 
            this.tp_normal_generator.Controls.Add(this.tb_normal_generator_B3);
            this.tp_normal_generator.Controls.Add(this.tb_normal_generator_B2);
            this.tp_normal_generator.Controls.Add(this.lb_normal_generator_B3);
            this.tp_normal_generator.Controls.Add(this.lb_normal_generator_B2);
            this.tp_normal_generator.Controls.Add(this.tb_normal_generator_B1);
            this.tp_normal_generator.Controls.Add(this.lb_normal_generator_B1);
            this.tp_normal_generator.Controls.Add(this.lb_normal_generator_starter);
            this.tp_normal_generator.Controls.Add(this.tb_normal_generator_starter);
            this.tp_normal_generator.Location = new System.Drawing.Point(4, 22);
            this.tp_normal_generator.Name = "tp_normal_generator";
            this.tp_normal_generator.Padding = new System.Windows.Forms.Padding(3);
            this.tp_normal_generator.Size = new System.Drawing.Size(349, 134);
            this.tp_normal_generator.TabIndex = 0;
            this.tp_normal_generator.Text = "발전기";
            this.tp_normal_generator.UseVisualStyleBackColor = true;
            // 
            // tb_normal_generator_B3
            // 
            this.tb_normal_generator_B3.Location = new System.Drawing.Point(121, 90);
            this.tb_normal_generator_B3.Name = "tb_normal_generator_B3";
            this.tb_normal_generator_B3.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_generator_B3.TabIndex = 16;
            this.tb_normal_generator_B3.Text = "180";
            // 
            // tb_normal_generator_B2
            // 
            this.tb_normal_generator_B2.Location = new System.Drawing.Point(121, 63);
            this.tb_normal_generator_B2.Name = "tb_normal_generator_B2";
            this.tb_normal_generator_B2.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_generator_B2.TabIndex = 15;
            this.tb_normal_generator_B2.Text = "120";
            // 
            // lb_normal_generator_B3
            // 
            this.lb_normal_generator_B3.AutoSize = true;
            this.lb_normal_generator_B3.Location = new System.Drawing.Point(9, 94);
            this.lb_normal_generator_B3.Name = "lb_normal_generator_B3";
            this.lb_normal_generator_B3.Size = new System.Drawing.Size(110, 13);
            this.lb_normal_generator_B3.TabIndex = 14;
            this.lb_normal_generator_B3.Text = "봉쇄 3단계 시간(초):";
            // 
            // lb_normal_generator_B2
            // 
            this.lb_normal_generator_B2.AutoSize = true;
            this.lb_normal_generator_B2.Location = new System.Drawing.Point(9, 67);
            this.lb_normal_generator_B2.Name = "lb_normal_generator_B2";
            this.lb_normal_generator_B2.Size = new System.Drawing.Size(110, 13);
            this.lb_normal_generator_B2.TabIndex = 13;
            this.lb_normal_generator_B2.Text = "봉쇄 2단계 시간(초):";
            // 
            // tb_normal_generator_B1
            // 
            this.tb_normal_generator_B1.Location = new System.Drawing.Point(121, 36);
            this.tb_normal_generator_B1.Name = "tb_normal_generator_B1";
            this.tb_normal_generator_B1.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_generator_B1.TabIndex = 12;
            this.tb_normal_generator_B1.Text = "60";
            // 
            // lb_normal_generator_B1
            // 
            this.lb_normal_generator_B1.AutoSize = true;
            this.lb_normal_generator_B1.Location = new System.Drawing.Point(9, 40);
            this.lb_normal_generator_B1.Name = "lb_normal_generator_B1";
            this.lb_normal_generator_B1.Size = new System.Drawing.Size(110, 13);
            this.lb_normal_generator_B1.TabIndex = 11;
            this.lb_normal_generator_B1.Text = "봉쇄 1단계 시간(초):";
            // 
            // lb_normal_generator_starter
            // 
            this.lb_normal_generator_starter.AutoSize = true;
            this.lb_normal_generator_starter.Location = new System.Drawing.Point(50, 12);
            this.lb_normal_generator_starter.Name = "lb_normal_generator_starter";
            this.lb_normal_generator_starter.Size = new System.Drawing.Size(69, 13);
            this.lb_normal_generator_starter.TabIndex = 10;
            this.lb_normal_generator_starter.Text = "스타터 횟수:";
            // 
            // tb_normal_generator_starter
            // 
            this.tb_normal_generator_starter.Location = new System.Drawing.Point(121, 8);
            this.tb_normal_generator_starter.Name = "tb_normal_generator_starter";
            this.tb_normal_generator_starter.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_generator_starter.TabIndex = 9;
            this.tb_normal_generator_starter.Text = "6";
            // 
            // tp_normal_escape
            // 
            this.tp_normal_escape.Controls.Add(this.lb_normal_escape_Btime);
            this.tp_normal_escape.Controls.Add(this.tb_normal_escape_Btime);
            this.tp_normal_escape.Location = new System.Drawing.Point(4, 22);
            this.tp_normal_escape.Name = "tp_normal_escape";
            this.tp_normal_escape.Padding = new System.Windows.Forms.Padding(3);
            this.tp_normal_escape.Size = new System.Drawing.Size(349, 134);
            this.tp_normal_escape.TabIndex = 1;
            this.tp_normal_escape.Text = "탈출장치";
            this.tp_normal_escape.UseVisualStyleBackColor = true;
            // 
            // lb_normal_escape_Btime
            // 
            this.lb_normal_escape_Btime.AutoSize = true;
            this.lb_normal_escape_Btime.Location = new System.Drawing.Point(6, 11);
            this.lb_normal_escape_Btime.Name = "lb_normal_escape_Btime";
            this.lb_normal_escape_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_normal_escape_Btime.TabIndex = 5;
            this.lb_normal_escape_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_normal_escape_Btime
            // 
            this.tb_normal_escape_Btime.Location = new System.Drawing.Point(85, 7);
            this.tb_normal_escape_Btime.Name = "tb_normal_escape_Btime";
            this.tb_normal_escape_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_escape_Btime.TabIndex = 4;
            this.tb_normal_escape_Btime.Text = "120";
            // 
            // tp_normal_itembox
            // 
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_Btime);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_Btime);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ansarea);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ansarea);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_anscnt);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_anscnt);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ans5);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ans5);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ans4);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ans3);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ans4);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ans3);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ans2);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ans2);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_ans1);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_ans1);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_vibe5);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_vibe5);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_vibe4);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_vibe3);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_vibe4);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_vibe3);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_vibe2);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_vibe2);
            this.tp_normal_itembox.Controls.Add(this.lb_normal_itembox_vibe1);
            this.tp_normal_itembox.Controls.Add(this.tb_normal_itembox_vibe1);
            this.tp_normal_itembox.Location = new System.Drawing.Point(4, 22);
            this.tp_normal_itembox.Name = "tp_normal_itembox";
            this.tp_normal_itembox.Size = new System.Drawing.Size(349, 134);
            this.tp_normal_itembox.TabIndex = 2;
            this.tp_normal_itembox.Text = "아이템박스";
            this.tp_normal_itembox.UseVisualStyleBackColor = true;
            // 
            // tb_normal_itembox_Btime
            // 
            this.tb_normal_itembox_Btime.Location = new System.Drawing.Point(311, 57);
            this.tb_normal_itembox_Btime.Name = "tb_normal_itembox_Btime";
            this.tb_normal_itembox_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_Btime.TabIndex = 61;
            this.tb_normal_itembox_Btime.Text = "180";
            // 
            // lb_normal_itembox_Btime
            // 
            this.lb_normal_itembox_Btime.AutoSize = true;
            this.lb_normal_itembox_Btime.Location = new System.Drawing.Point(232, 61);
            this.lb_normal_itembox_Btime.Name = "lb_normal_itembox_Btime";
            this.lb_normal_itembox_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_normal_itembox_Btime.TabIndex = 60;
            this.lb_normal_itembox_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_normal_itembox_ansarea
            // 
            this.tb_normal_itembox_ansarea.Location = new System.Drawing.Point(311, 30);
            this.tb_normal_itembox_ansarea.Name = "tb_normal_itembox_ansarea";
            this.tb_normal_itembox_ansarea.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ansarea.TabIndex = 59;
            this.tb_normal_itembox_ansarea.Text = "1";
            // 
            // lb_normal_itembox_ansarea
            // 
            this.lb_normal_itembox_ansarea.AutoSize = true;
            this.lb_normal_itembox_ansarea.Location = new System.Drawing.Point(251, 34);
            this.lb_normal_itembox_ansarea.Name = "lb_normal_itembox_ansarea";
            this.lb_normal_itembox_ansarea.Size = new System.Drawing.Size(58, 13);
            this.lb_normal_itembox_ansarea.TabIndex = 58;
            this.lb_normal_itembox_ansarea.Text = "정답 범위:";
            // 
            // lb_normal_itembox_anscnt
            // 
            this.lb_normal_itembox_anscnt.AutoSize = true;
            this.lb_normal_itembox_anscnt.Location = new System.Drawing.Point(251, 7);
            this.lb_normal_itembox_anscnt.Name = "lb_normal_itembox_anscnt";
            this.lb_normal_itembox_anscnt.Size = new System.Drawing.Size(58, 13);
            this.lb_normal_itembox_anscnt.TabIndex = 57;
            this.lb_normal_itembox_anscnt.Text = "정답 개수:";
            // 
            // tb_normal_itembox_anscnt
            // 
            this.tb_normal_itembox_anscnt.Location = new System.Drawing.Point(311, 3);
            this.tb_normal_itembox_anscnt.Name = "tb_normal_itembox_anscnt";
            this.tb_normal_itembox_anscnt.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_anscnt.TabIndex = 56;
            this.tb_normal_itembox_anscnt.Text = "3";
            // 
            // tb_normal_itembox_ans5
            // 
            this.tb_normal_itembox_ans5.Location = new System.Drawing.Point(193, 111);
            this.tb_normal_itembox_ans5.Name = "tb_normal_itembox_ans5";
            this.tb_normal_itembox_ans5.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ans5.TabIndex = 55;
            this.tb_normal_itembox_ans5.Text = "0";
            // 
            // lb_normal_itembox_ans5
            // 
            this.lb_normal_itembox_ans5.AutoSize = true;
            this.lb_normal_itembox_ans5.Location = new System.Drawing.Point(111, 115);
            this.lb_normal_itembox_ans5.Name = "lb_normal_itembox_ans5";
            this.lb_normal_itembox_ans5.Size = new System.Drawing.Size(80, 13);
            this.lb_normal_itembox_ans5.TabIndex = 54;
            this.lb_normal_itembox_ans5.Text = "다섯번째 정답:";
            // 
            // tb_normal_itembox_ans4
            // 
            this.tb_normal_itembox_ans4.Location = new System.Drawing.Point(193, 84);
            this.tb_normal_itembox_ans4.Name = "tb_normal_itembox_ans4";
            this.tb_normal_itembox_ans4.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ans4.TabIndex = 53;
            this.tb_normal_itembox_ans4.Text = "30";
            // 
            // tb_normal_itembox_ans3
            // 
            this.tb_normal_itembox_ans3.Location = new System.Drawing.Point(193, 57);
            this.tb_normal_itembox_ans3.Name = "tb_normal_itembox_ans3";
            this.tb_normal_itembox_ans3.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ans3.TabIndex = 52;
            this.tb_normal_itembox_ans3.Text = "7";
            // 
            // lb_normal_itembox_ans4
            // 
            this.lb_normal_itembox_ans4.AutoSize = true;
            this.lb_normal_itembox_ans4.Location = new System.Drawing.Point(122, 88);
            this.lb_normal_itembox_ans4.Name = "lb_normal_itembox_ans4";
            this.lb_normal_itembox_ans4.Size = new System.Drawing.Size(69, 13);
            this.lb_normal_itembox_ans4.TabIndex = 51;
            this.lb_normal_itembox_ans4.Text = "네번째 정답:";
            // 
            // lb_normal_itembox_ans3
            // 
            this.lb_normal_itembox_ans3.AutoSize = true;
            this.lb_normal_itembox_ans3.Location = new System.Drawing.Point(122, 61);
            this.lb_normal_itembox_ans3.Name = "lb_normal_itembox_ans3";
            this.lb_normal_itembox_ans3.Size = new System.Drawing.Size(69, 13);
            this.lb_normal_itembox_ans3.TabIndex = 50;
            this.lb_normal_itembox_ans3.Text = "세번째 정답:";
            // 
            // tb_normal_itembox_ans2
            // 
            this.tb_normal_itembox_ans2.Location = new System.Drawing.Point(193, 30);
            this.tb_normal_itembox_ans2.Name = "tb_normal_itembox_ans2";
            this.tb_normal_itembox_ans2.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ans2.TabIndex = 49;
            this.tb_normal_itembox_ans2.Text = "25";
            // 
            // lb_normal_itembox_ans2
            // 
            this.lb_normal_itembox_ans2.AutoSize = true;
            this.lb_normal_itembox_ans2.Location = new System.Drawing.Point(122, 34);
            this.lb_normal_itembox_ans2.Name = "lb_normal_itembox_ans2";
            this.lb_normal_itembox_ans2.Size = new System.Drawing.Size(69, 13);
            this.lb_normal_itembox_ans2.TabIndex = 48;
            this.lb_normal_itembox_ans2.Text = "두번째 정답:";
            // 
            // lb_normal_itembox_ans1
            // 
            this.lb_normal_itembox_ans1.AutoSize = true;
            this.lb_normal_itembox_ans1.Location = new System.Drawing.Point(122, 7);
            this.lb_normal_itembox_ans1.Name = "lb_normal_itembox_ans1";
            this.lb_normal_itembox_ans1.Size = new System.Drawing.Size(69, 13);
            this.lb_normal_itembox_ans1.TabIndex = 47;
            this.lb_normal_itembox_ans1.Text = "첫번째 정답:";
            // 
            // tb_normal_itembox_ans1
            // 
            this.tb_normal_itembox_ans1.Location = new System.Drawing.Point(193, 3);
            this.tb_normal_itembox_ans1.Name = "tb_normal_itembox_ans1";
            this.tb_normal_itembox_ans1.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_ans1.TabIndex = 46;
            this.tb_normal_itembox_ans1.Text = "5";
            // 
            // tb_normal_itembox_vibe5
            // 
            this.tb_normal_itembox_vibe5.Location = new System.Drawing.Point(71, 111);
            this.tb_normal_itembox_vibe5.Name = "tb_normal_itembox_vibe5";
            this.tb_normal_itembox_vibe5.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_vibe5.TabIndex = 45;
            this.tb_normal_itembox_vibe5.Text = "0";
            // 
            // lb_normal_itembox_vibe5
            // 
            this.lb_normal_itembox_vibe5.AutoSize = true;
            this.lb_normal_itembox_vibe5.Location = new System.Drawing.Point(3, 115);
            this.lb_normal_itembox_vibe5.Name = "lb_normal_itembox_vibe5";
            this.lb_normal_itembox_vibe5.Size = new System.Drawing.Size(66, 13);
            this.lb_normal_itembox_vibe5.TabIndex = 44;
            this.lb_normal_itembox_vibe5.Text = "4범위 진동:";
            // 
            // tb_normal_itembox_vibe4
            // 
            this.tb_normal_itembox_vibe4.Location = new System.Drawing.Point(71, 84);
            this.tb_normal_itembox_vibe4.Name = "tb_normal_itembox_vibe4";
            this.tb_normal_itembox_vibe4.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_vibe4.TabIndex = 43;
            this.tb_normal_itembox_vibe4.Text = "40";
            // 
            // tb_normal_itembox_vibe3
            // 
            this.tb_normal_itembox_vibe3.Location = new System.Drawing.Point(71, 57);
            this.tb_normal_itembox_vibe3.Name = "tb_normal_itembox_vibe3";
            this.tb_normal_itembox_vibe3.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_vibe3.TabIndex = 42;
            this.tb_normal_itembox_vibe3.Text = "70";
            // 
            // lb_normal_itembox_vibe4
            // 
            this.lb_normal_itembox_vibe4.AutoSize = true;
            this.lb_normal_itembox_vibe4.Location = new System.Drawing.Point(3, 88);
            this.lb_normal_itembox_vibe4.Name = "lb_normal_itembox_vibe4";
            this.lb_normal_itembox_vibe4.Size = new System.Drawing.Size(66, 13);
            this.lb_normal_itembox_vibe4.TabIndex = 41;
            this.lb_normal_itembox_vibe4.Text = "3범위 진동:";
            // 
            // lb_normal_itembox_vibe3
            // 
            this.lb_normal_itembox_vibe3.AutoSize = true;
            this.lb_normal_itembox_vibe3.Location = new System.Drawing.Point(3, 61);
            this.lb_normal_itembox_vibe3.Name = "lb_normal_itembox_vibe3";
            this.lb_normal_itembox_vibe3.Size = new System.Drawing.Size(66, 13);
            this.lb_normal_itembox_vibe3.TabIndex = 40;
            this.lb_normal_itembox_vibe3.Text = "2범위 진동:";
            // 
            // tb_normal_itembox_vibe2
            // 
            this.tb_normal_itembox_vibe2.Location = new System.Drawing.Point(71, 30);
            this.tb_normal_itembox_vibe2.Name = "tb_normal_itembox_vibe2";
            this.tb_normal_itembox_vibe2.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_vibe2.TabIndex = 39;
            this.tb_normal_itembox_vibe2.Text = "100";
            // 
            // lb_normal_itembox_vibe2
            // 
            this.lb_normal_itembox_vibe2.AutoSize = true;
            this.lb_normal_itembox_vibe2.Location = new System.Drawing.Point(3, 34);
            this.lb_normal_itembox_vibe2.Name = "lb_normal_itembox_vibe2";
            this.lb_normal_itembox_vibe2.Size = new System.Drawing.Size(66, 13);
            this.lb_normal_itembox_vibe2.TabIndex = 38;
            this.lb_normal_itembox_vibe2.Text = "1범위 진동:";
            // 
            // lb_normal_itembox_vibe1
            // 
            this.lb_normal_itembox_vibe1.AutoSize = true;
            this.lb_normal_itembox_vibe1.Location = new System.Drawing.Point(11, 7);
            this.lb_normal_itembox_vibe1.Name = "lb_normal_itembox_vibe1";
            this.lb_normal_itembox_vibe1.Size = new System.Drawing.Size(58, 13);
            this.lb_normal_itembox_vibe1.TabIndex = 37;
            this.lb_normal_itembox_vibe1.Text = "정답 진동:";
            // 
            // tb_normal_itembox_vibe1
            // 
            this.tb_normal_itembox_vibe1.Location = new System.Drawing.Point(71, 3);
            this.tb_normal_itembox_vibe1.Name = "tb_normal_itembox_vibe1";
            this.tb_normal_itembox_vibe1.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_itembox_vibe1.TabIndex = 36;
            this.tb_normal_itembox_vibe1.Text = "250";
            // 
            // tp_normal_door
            // 
            this.tp_normal_door.Controls.Add(this.lb_noraml_door_autolock);
            this.tp_normal_door.Controls.Add(this.tb_noraml_door_autolock);
            this.tp_normal_door.Location = new System.Drawing.Point(4, 22);
            this.tp_normal_door.Name = "tp_normal_door";
            this.tp_normal_door.Size = new System.Drawing.Size(349, 134);
            this.tp_normal_door.TabIndex = 3;
            this.tp_normal_door.Text = "게임도어";
            this.tp_normal_door.UseVisualStyleBackColor = true;
            // 
            // lb_noraml_door_autolock
            // 
            this.lb_noraml_door_autolock.AutoSize = true;
            this.lb_noraml_door_autolock.Location = new System.Drawing.Point(11, 12);
            this.lb_noraml_door_autolock.Name = "lb_noraml_door_autolock";
            this.lb_noraml_door_autolock.Size = new System.Drawing.Size(102, 13);
            this.lb_noraml_door_autolock.TabIndex = 14;
            this.lb_noraml_door_autolock.Text = "자동 잠금 주기(초):";
            // 
            // tb_noraml_door_autolock
            // 
            this.tb_noraml_door_autolock.Location = new System.Drawing.Point(115, 8);
            this.tb_noraml_door_autolock.Name = "tb_noraml_door_autolock";
            this.tb_noraml_door_autolock.Size = new System.Drawing.Size(35, 21);
            this.tb_noraml_door_autolock.TabIndex = 13;
            this.tb_noraml_door_autolock.Text = "180";
            // 
            // tp_normal_duct
            // 
            this.tp_normal_duct.Controls.Add(this.tb_normal_vent_cooltime_addup);
            this.tp_normal_duct.Controls.Add(this.lb_normal_vent_cooltime_addup);
            this.tp_normal_duct.Controls.Add(this.lb_noraml_duct_cooltime);
            this.tp_normal_duct.Controls.Add(this.tb_normal_vent_cooltime);
            this.tp_normal_duct.Location = new System.Drawing.Point(4, 22);
            this.tp_normal_duct.Name = "tp_normal_duct";
            this.tp_normal_duct.Size = new System.Drawing.Size(349, 134);
            this.tp_normal_duct.TabIndex = 4;
            this.tp_normal_duct.Text = "덕트";
            this.tp_normal_duct.UseVisualStyleBackColor = true;
            // 
            // tb_normal_vent_cooltime_addup
            // 
            this.tb_normal_vent_cooltime_addup.Location = new System.Drawing.Point(110, 31);
            this.tb_normal_vent_cooltime_addup.Name = "tb_normal_vent_cooltime_addup";
            this.tb_normal_vent_cooltime_addup.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_vent_cooltime_addup.TabIndex = 20;
            this.tb_normal_vent_cooltime_addup.Text = "35";
            // 
            // lb_normal_vent_cooltime_addup
            // 
            this.lb_normal_vent_cooltime_addup.AutoSize = true;
            this.lb_normal_vent_cooltime_addup.Location = new System.Drawing.Point(9, 35);
            this.lb_normal_vent_cooltime_addup.Name = "lb_normal_vent_cooltime_addup";
            this.lb_normal_vent_cooltime_addup.Size = new System.Drawing.Size(99, 13);
            this.lb_normal_vent_cooltime_addup.TabIndex = 19;
            this.lb_normal_vent_cooltime_addup.Text = "쿨타임 증가량(초):";
            // 
            // lb_noraml_duct_cooltime
            // 
            this.lb_noraml_duct_cooltime.AutoSize = true;
            this.lb_noraml_duct_cooltime.Location = new System.Drawing.Point(45, 10);
            this.lb_noraml_duct_cooltime.Name = "lb_noraml_duct_cooltime";
            this.lb_noraml_duct_cooltime.Size = new System.Drawing.Size(63, 13);
            this.lb_noraml_duct_cooltime.TabIndex = 18;
            this.lb_noraml_duct_cooltime.Text = "쿨타임(초):";
            // 
            // tb_normal_vent_cooltime
            // 
            this.tb_normal_vent_cooltime.Location = new System.Drawing.Point(110, 6);
            this.tb_normal_vent_cooltime.Name = "tb_normal_vent_cooltime";
            this.tb_normal_vent_cooltime.Size = new System.Drawing.Size(35, 21);
            this.tb_normal_vent_cooltime.TabIndex = 17;
            this.tb_normal_vent_cooltime.Text = "35";
            // 
            // tp_hardmode
            // 
            this.tp_hardmode.Controls.Add(this.tabControl1);
            this.tp_hardmode.Location = new System.Drawing.Point(4, 22);
            this.tp_hardmode.Name = "tp_hardmode";
            this.tp_hardmode.Size = new System.Drawing.Size(369, 172);
            this.tp_hardmode.TabIndex = 2;
            this.tp_hardmode.Text = "찌발모드";
            this.tp_hardmode.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_hard_generator);
            this.tabControl1.Controls.Add(this.tp_hard_escape);
            this.tabControl1.Controls.Add(this.tp_hard_itembox);
            this.tabControl1.Controls.Add(this.tp_hard_door);
            this.tabControl1.Controls.Add(this.tp_hard_duct);
            this.tabControl1.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 163);
            this.tabControl1.TabIndex = 87;
            // 
            // tp_hard_generator
            // 
            this.tp_hard_generator.Controls.Add(this.tb_hard_generator_B3);
            this.tp_hard_generator.Controls.Add(this.tb_hard_generator_B2);
            this.tp_hard_generator.Controls.Add(this.lb_hard_generator_B3);
            this.tp_hard_generator.Controls.Add(this.lb_hard_generator_B2);
            this.tp_hard_generator.Controls.Add(this.tb_hard_generator_B1);
            this.tp_hard_generator.Controls.Add(this.lb_hard_generator_B1);
            this.tp_hard_generator.Controls.Add(this.lb_hard_generator_starter);
            this.tp_hard_generator.Controls.Add(this.tb_hard_generator_starter);
            this.tp_hard_generator.Location = new System.Drawing.Point(4, 22);
            this.tp_hard_generator.Name = "tp_hard_generator";
            this.tp_hard_generator.Padding = new System.Windows.Forms.Padding(3);
            this.tp_hard_generator.Size = new System.Drawing.Size(352, 137);
            this.tp_hard_generator.TabIndex = 0;
            this.tp_hard_generator.Text = "발전기";
            this.tp_hard_generator.UseVisualStyleBackColor = true;
            // 
            // tb_hard_generator_B3
            // 
            this.tb_hard_generator_B3.Location = new System.Drawing.Point(123, 89);
            this.tb_hard_generator_B3.Name = "tb_hard_generator_B3";
            this.tb_hard_generator_B3.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_generator_B3.TabIndex = 8;
            this.tb_hard_generator_B3.Text = "180";
            // 
            // tb_hard_generator_B2
            // 
            this.tb_hard_generator_B2.Location = new System.Drawing.Point(123, 62);
            this.tb_hard_generator_B2.Name = "tb_hard_generator_B2";
            this.tb_hard_generator_B2.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_generator_B2.TabIndex = 7;
            this.tb_hard_generator_B2.Text = "120";
            // 
            // lb_hard_generator_B3
            // 
            this.lb_hard_generator_B3.AutoSize = true;
            this.lb_hard_generator_B3.Location = new System.Drawing.Point(11, 93);
            this.lb_hard_generator_B3.Name = "lb_hard_generator_B3";
            this.lb_hard_generator_B3.Size = new System.Drawing.Size(110, 13);
            this.lb_hard_generator_B3.TabIndex = 5;
            this.lb_hard_generator_B3.Text = "봉쇄 3단계 시간(초):";
            // 
            // lb_hard_generator_B2
            // 
            this.lb_hard_generator_B2.AutoSize = true;
            this.lb_hard_generator_B2.Location = new System.Drawing.Point(11, 66);
            this.lb_hard_generator_B2.Name = "lb_hard_generator_B2";
            this.lb_hard_generator_B2.Size = new System.Drawing.Size(110, 13);
            this.lb_hard_generator_B2.TabIndex = 4;
            this.lb_hard_generator_B2.Text = "봉쇄 2단계 시간(초):";
            // 
            // tb_hard_generator_B1
            // 
            this.tb_hard_generator_B1.Location = new System.Drawing.Point(123, 35);
            this.tb_hard_generator_B1.Name = "tb_hard_generator_B1";
            this.tb_hard_generator_B1.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_generator_B1.TabIndex = 3;
            this.tb_hard_generator_B1.Text = "60";
            // 
            // lb_hard_generator_B1
            // 
            this.lb_hard_generator_B1.AutoSize = true;
            this.lb_hard_generator_B1.Location = new System.Drawing.Point(11, 39);
            this.lb_hard_generator_B1.Name = "lb_hard_generator_B1";
            this.lb_hard_generator_B1.Size = new System.Drawing.Size(110, 13);
            this.lb_hard_generator_B1.TabIndex = 2;
            this.lb_hard_generator_B1.Text = "봉쇄 1단계 시간(초):";
            // 
            // lb_hard_generator_starter
            // 
            this.lb_hard_generator_starter.AutoSize = true;
            this.lb_hard_generator_starter.Location = new System.Drawing.Point(52, 11);
            this.lb_hard_generator_starter.Name = "lb_hard_generator_starter";
            this.lb_hard_generator_starter.Size = new System.Drawing.Size(69, 13);
            this.lb_hard_generator_starter.TabIndex = 1;
            this.lb_hard_generator_starter.Text = "스타터 횟수:";
            // 
            // tb_hard_generator_starter
            // 
            this.tb_hard_generator_starter.Location = new System.Drawing.Point(123, 7);
            this.tb_hard_generator_starter.Name = "tb_hard_generator_starter";
            this.tb_hard_generator_starter.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_generator_starter.TabIndex = 0;
            this.tb_hard_generator_starter.Text = "10";
            // 
            // tp_hard_escape
            // 
            this.tp_hard_escape.Controls.Add(this.lb_hard_escape_Btime);
            this.tp_hard_escape.Controls.Add(this.tb_hard_escape_Btime);
            this.tp_hard_escape.Location = new System.Drawing.Point(4, 22);
            this.tp_hard_escape.Name = "tp_hard_escape";
            this.tp_hard_escape.Padding = new System.Windows.Forms.Padding(3);
            this.tp_hard_escape.Size = new System.Drawing.Size(352, 137);
            this.tp_hard_escape.TabIndex = 1;
            this.tp_hard_escape.Text = "탈출장치";
            this.tp_hard_escape.UseVisualStyleBackColor = true;
            // 
            // lb_hard_escape_Btime
            // 
            this.lb_hard_escape_Btime.AutoSize = true;
            this.lb_hard_escape_Btime.Location = new System.Drawing.Point(11, 11);
            this.lb_hard_escape_Btime.Name = "lb_hard_escape_Btime";
            this.lb_hard_escape_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_hard_escape_Btime.TabIndex = 3;
            this.lb_hard_escape_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_hard_escape_Btime
            // 
            this.tb_hard_escape_Btime.Location = new System.Drawing.Point(90, 7);
            this.tb_hard_escape_Btime.Name = "tb_hard_escape_Btime";
            this.tb_hard_escape_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_escape_Btime.TabIndex = 2;
            this.tb_hard_escape_Btime.Text = "180";
            // 
            // tp_hard_itembox
            // 
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_Btime);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_Btime);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ansarea);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ansarea);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_anscnt);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_anscnt);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ans5);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ans5);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ans4);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ans3);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ans4);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ans3);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ans2);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ans2);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_ans1);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_ans1);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_vibe5);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_vibe5);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_vibe4);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_vibe3);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_vibe4);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_vibe3);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_vibe2);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_vibe2);
            this.tp_hard_itembox.Controls.Add(this.lb_hard_itembox_vibe1);
            this.tp_hard_itembox.Controls.Add(this.tb_hard_itembox_vibe1);
            this.tp_hard_itembox.Location = new System.Drawing.Point(4, 22);
            this.tp_hard_itembox.Name = "tp_hard_itembox";
            this.tp_hard_itembox.Size = new System.Drawing.Size(352, 137);
            this.tp_hard_itembox.TabIndex = 2;
            this.tp_hard_itembox.Text = "아이템박스";
            this.tp_hard_itembox.UseVisualStyleBackColor = true;
            // 
            // tb_hard_itembox_Btime
            // 
            this.tb_hard_itembox_Btime.Location = new System.Drawing.Point(310, 58);
            this.tb_hard_itembox_Btime.Name = "tb_hard_itembox_Btime";
            this.tb_hard_itembox_Btime.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_Btime.TabIndex = 35;
            this.tb_hard_itembox_Btime.Text = "180";
            // 
            // lb_hard_itembox_Btime
            // 
            this.lb_hard_itembox_Btime.AutoSize = true;
            this.lb_hard_itembox_Btime.Location = new System.Drawing.Point(231, 62);
            this.lb_hard_itembox_Btime.Name = "lb_hard_itembox_Btime";
            this.lb_hard_itembox_Btime.Size = new System.Drawing.Size(77, 13);
            this.lb_hard_itembox_Btime.TabIndex = 33;
            this.lb_hard_itembox_Btime.Text = "봉쇄 시간(초):";
            // 
            // tb_hard_itembox_ansarea
            // 
            this.tb_hard_itembox_ansarea.Location = new System.Drawing.Point(310, 31);
            this.tb_hard_itembox_ansarea.Name = "tb_hard_itembox_ansarea";
            this.tb_hard_itembox_ansarea.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ansarea.TabIndex = 32;
            this.tb_hard_itembox_ansarea.Text = "1";
            // 
            // lb_hard_itembox_ansarea
            // 
            this.lb_hard_itembox_ansarea.AutoSize = true;
            this.lb_hard_itembox_ansarea.Location = new System.Drawing.Point(250, 35);
            this.lb_hard_itembox_ansarea.Name = "lb_hard_itembox_ansarea";
            this.lb_hard_itembox_ansarea.Size = new System.Drawing.Size(58, 13);
            this.lb_hard_itembox_ansarea.TabIndex = 31;
            this.lb_hard_itembox_ansarea.Text = "정답 범위:";
            // 
            // lb_hard_itembox_anscnt
            // 
            this.lb_hard_itembox_anscnt.AutoSize = true;
            this.lb_hard_itembox_anscnt.Location = new System.Drawing.Point(250, 8);
            this.lb_hard_itembox_anscnt.Name = "lb_hard_itembox_anscnt";
            this.lb_hard_itembox_anscnt.Size = new System.Drawing.Size(58, 13);
            this.lb_hard_itembox_anscnt.TabIndex = 30;
            this.lb_hard_itembox_anscnt.Text = "정답 개수:";
            // 
            // tb_hard_itembox_anscnt
            // 
            this.tb_hard_itembox_anscnt.Location = new System.Drawing.Point(310, 4);
            this.tb_hard_itembox_anscnt.Name = "tb_hard_itembox_anscnt";
            this.tb_hard_itembox_anscnt.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_anscnt.TabIndex = 29;
            this.tb_hard_itembox_anscnt.Text = "5";
            // 
            // tb_hard_itembox_ans5
            // 
            this.tb_hard_itembox_ans5.Location = new System.Drawing.Point(192, 112);
            this.tb_hard_itembox_ans5.Name = "tb_hard_itembox_ans5";
            this.tb_hard_itembox_ans5.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ans5.TabIndex = 28;
            this.tb_hard_itembox_ans5.Text = "8";
            // 
            // lb_hard_itembox_ans5
            // 
            this.lb_hard_itembox_ans5.AutoSize = true;
            this.lb_hard_itembox_ans5.Location = new System.Drawing.Point(110, 116);
            this.lb_hard_itembox_ans5.Name = "lb_hard_itembox_ans5";
            this.lb_hard_itembox_ans5.Size = new System.Drawing.Size(80, 13);
            this.lb_hard_itembox_ans5.TabIndex = 27;
            this.lb_hard_itembox_ans5.Text = "다섯번째 정답:";
            // 
            // tb_hard_itembox_ans4
            // 
            this.tb_hard_itembox_ans4.Location = new System.Drawing.Point(192, 85);
            this.tb_hard_itembox_ans4.Name = "tb_hard_itembox_ans4";
            this.tb_hard_itembox_ans4.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ans4.TabIndex = 26;
            this.tb_hard_itembox_ans4.Text = "47";
            // 
            // tb_hard_itembox_ans3
            // 
            this.tb_hard_itembox_ans3.Location = new System.Drawing.Point(192, 58);
            this.tb_hard_itembox_ans3.Name = "tb_hard_itembox_ans3";
            this.tb_hard_itembox_ans3.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ans3.TabIndex = 25;
            this.tb_hard_itembox_ans3.Text = "3";
            // 
            // lb_hard_itembox_ans4
            // 
            this.lb_hard_itembox_ans4.AutoSize = true;
            this.lb_hard_itembox_ans4.Location = new System.Drawing.Point(121, 89);
            this.lb_hard_itembox_ans4.Name = "lb_hard_itembox_ans4";
            this.lb_hard_itembox_ans4.Size = new System.Drawing.Size(69, 13);
            this.lb_hard_itembox_ans4.TabIndex = 24;
            this.lb_hard_itembox_ans4.Text = "네번째 정답:";
            // 
            // lb_hard_itembox_ans3
            // 
            this.lb_hard_itembox_ans3.AutoSize = true;
            this.lb_hard_itembox_ans3.Location = new System.Drawing.Point(121, 62);
            this.lb_hard_itembox_ans3.Name = "lb_hard_itembox_ans3";
            this.lb_hard_itembox_ans3.Size = new System.Drawing.Size(69, 13);
            this.lb_hard_itembox_ans3.TabIndex = 23;
            this.lb_hard_itembox_ans3.Text = "세번째 정답:";
            // 
            // tb_hard_itembox_ans2
            // 
            this.tb_hard_itembox_ans2.Location = new System.Drawing.Point(192, 31);
            this.tb_hard_itembox_ans2.Name = "tb_hard_itembox_ans2";
            this.tb_hard_itembox_ans2.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ans2.TabIndex = 22;
            this.tb_hard_itembox_ans2.Text = "45";
            // 
            // lb_hard_itembox_ans2
            // 
            this.lb_hard_itembox_ans2.AutoSize = true;
            this.lb_hard_itembox_ans2.Location = new System.Drawing.Point(121, 35);
            this.lb_hard_itembox_ans2.Name = "lb_hard_itembox_ans2";
            this.lb_hard_itembox_ans2.Size = new System.Drawing.Size(69, 13);
            this.lb_hard_itembox_ans2.TabIndex = 21;
            this.lb_hard_itembox_ans2.Text = "두번째 정답:";
            // 
            // lb_hard_itembox_ans1
            // 
            this.lb_hard_itembox_ans1.AutoSize = true;
            this.lb_hard_itembox_ans1.Location = new System.Drawing.Point(121, 8);
            this.lb_hard_itembox_ans1.Name = "lb_hard_itembox_ans1";
            this.lb_hard_itembox_ans1.Size = new System.Drawing.Size(69, 13);
            this.lb_hard_itembox_ans1.TabIndex = 20;
            this.lb_hard_itembox_ans1.Text = "첫번째 정답:";
            // 
            // tb_hard_itembox_ans1
            // 
            this.tb_hard_itembox_ans1.Location = new System.Drawing.Point(192, 4);
            this.tb_hard_itembox_ans1.Name = "tb_hard_itembox_ans1";
            this.tb_hard_itembox_ans1.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_ans1.TabIndex = 19;
            this.tb_hard_itembox_ans1.Text = "5";
            // 
            // tb_hard_itembox_vibe5
            // 
            this.tb_hard_itembox_vibe5.Location = new System.Drawing.Point(70, 112);
            this.tb_hard_itembox_vibe5.Name = "tb_hard_itembox_vibe5";
            this.tb_hard_itembox_vibe5.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_vibe5.TabIndex = 18;
            this.tb_hard_itembox_vibe5.Text = "0";
            // 
            // lb_hard_itembox_vibe5
            // 
            this.lb_hard_itembox_vibe5.AutoSize = true;
            this.lb_hard_itembox_vibe5.Location = new System.Drawing.Point(2, 116);
            this.lb_hard_itembox_vibe5.Name = "lb_hard_itembox_vibe5";
            this.lb_hard_itembox_vibe5.Size = new System.Drawing.Size(66, 13);
            this.lb_hard_itembox_vibe5.TabIndex = 17;
            this.lb_hard_itembox_vibe5.Text = "4범위 진동:";
            // 
            // tb_hard_itembox_vibe4
            // 
            this.tb_hard_itembox_vibe4.Location = new System.Drawing.Point(70, 85);
            this.tb_hard_itembox_vibe4.Name = "tb_hard_itembox_vibe4";
            this.tb_hard_itembox_vibe4.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_vibe4.TabIndex = 16;
            this.tb_hard_itembox_vibe4.Text = "40";
            // 
            // tb_hard_itembox_vibe3
            // 
            this.tb_hard_itembox_vibe3.Location = new System.Drawing.Point(70, 58);
            this.tb_hard_itembox_vibe3.Name = "tb_hard_itembox_vibe3";
            this.tb_hard_itembox_vibe3.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_vibe3.TabIndex = 15;
            this.tb_hard_itembox_vibe3.Text = "75";
            // 
            // lb_hard_itembox_vibe4
            // 
            this.lb_hard_itembox_vibe4.AutoSize = true;
            this.lb_hard_itembox_vibe4.Location = new System.Drawing.Point(2, 89);
            this.lb_hard_itembox_vibe4.Name = "lb_hard_itembox_vibe4";
            this.lb_hard_itembox_vibe4.Size = new System.Drawing.Size(66, 13);
            this.lb_hard_itembox_vibe4.TabIndex = 14;
            this.lb_hard_itembox_vibe4.Text = "3범위 진동:";
            // 
            // lb_hard_itembox_vibe3
            // 
            this.lb_hard_itembox_vibe3.AutoSize = true;
            this.lb_hard_itembox_vibe3.Location = new System.Drawing.Point(2, 62);
            this.lb_hard_itembox_vibe3.Name = "lb_hard_itembox_vibe3";
            this.lb_hard_itembox_vibe3.Size = new System.Drawing.Size(66, 13);
            this.lb_hard_itembox_vibe3.TabIndex = 13;
            this.lb_hard_itembox_vibe3.Text = "2범위 진동:";
            // 
            // tb_hard_itembox_vibe2
            // 
            this.tb_hard_itembox_vibe2.Location = new System.Drawing.Point(70, 31);
            this.tb_hard_itembox_vibe2.Name = "tb_hard_itembox_vibe2";
            this.tb_hard_itembox_vibe2.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_vibe2.TabIndex = 12;
            this.tb_hard_itembox_vibe2.Text = "150";
            // 
            // lb_hard_itembox_vibe2
            // 
            this.lb_hard_itembox_vibe2.AutoSize = true;
            this.lb_hard_itembox_vibe2.Location = new System.Drawing.Point(2, 35);
            this.lb_hard_itembox_vibe2.Name = "lb_hard_itembox_vibe2";
            this.lb_hard_itembox_vibe2.Size = new System.Drawing.Size(66, 13);
            this.lb_hard_itembox_vibe2.TabIndex = 11;
            this.lb_hard_itembox_vibe2.Text = "1범위 진동:";
            // 
            // lb_hard_itembox_vibe1
            // 
            this.lb_hard_itembox_vibe1.AutoSize = true;
            this.lb_hard_itembox_vibe1.Location = new System.Drawing.Point(10, 8);
            this.lb_hard_itembox_vibe1.Name = "lb_hard_itembox_vibe1";
            this.lb_hard_itembox_vibe1.Size = new System.Drawing.Size(58, 13);
            this.lb_hard_itembox_vibe1.TabIndex = 10;
            this.lb_hard_itembox_vibe1.Text = "정답 진동:";
            // 
            // tb_hard_itembox_vibe1
            // 
            this.tb_hard_itembox_vibe1.Location = new System.Drawing.Point(70, 4);
            this.tb_hard_itembox_vibe1.Name = "tb_hard_itembox_vibe1";
            this.tb_hard_itembox_vibe1.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_itembox_vibe1.TabIndex = 9;
            this.tb_hard_itembox_vibe1.Text = "250";
            // 
            // tp_hard_door
            // 
            this.tp_hard_door.Controls.Add(this.lb_hard_door_autolock);
            this.tp_hard_door.Controls.Add(this.tb_hard_door_autolock);
            this.tp_hard_door.Location = new System.Drawing.Point(4, 22);
            this.tp_hard_door.Name = "tp_hard_door";
            this.tp_hard_door.Size = new System.Drawing.Size(352, 137);
            this.tp_hard_door.TabIndex = 3;
            this.tp_hard_door.Text = "게임도어";
            this.tp_hard_door.UseVisualStyleBackColor = true;
            // 
            // lb_hard_door_autolock
            // 
            this.lb_hard_door_autolock.AutoSize = true;
            this.lb_hard_door_autolock.Location = new System.Drawing.Point(11, 11);
            this.lb_hard_door_autolock.Name = "lb_hard_door_autolock";
            this.lb_hard_door_autolock.Size = new System.Drawing.Size(102, 13);
            this.lb_hard_door_autolock.TabIndex = 12;
            this.lb_hard_door_autolock.Text = "자동 잠금 주기(초):";
            // 
            // tb_hard_door_autolock
            // 
            this.tb_hard_door_autolock.Location = new System.Drawing.Point(115, 7);
            this.tb_hard_door_autolock.Name = "tb_hard_door_autolock";
            this.tb_hard_door_autolock.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_door_autolock.TabIndex = 11;
            this.tb_hard_door_autolock.Text = "180";
            // 
            // tp_hard_duct
            // 
            this.tp_hard_duct.Controls.Add(this.tb_hard_vent_cooltime_addup);
            this.tp_hard_duct.Controls.Add(this.lb_hard_vent_cooltime_addup);
            this.tp_hard_duct.Controls.Add(this.label25);
            this.tp_hard_duct.Controls.Add(this.tb_hard_vent_cooltime);
            this.tp_hard_duct.Location = new System.Drawing.Point(4, 22);
            this.tp_hard_duct.Name = "tp_hard_duct";
            this.tp_hard_duct.Size = new System.Drawing.Size(352, 137);
            this.tp_hard_duct.TabIndex = 4;
            this.tp_hard_duct.Text = "덕트";
            this.tp_hard_duct.UseVisualStyleBackColor = true;
            // 
            // tb_hard_vent_cooltime_addup
            // 
            this.tb_hard_vent_cooltime_addup.Location = new System.Drawing.Point(112, 32);
            this.tb_hard_vent_cooltime_addup.Name = "tb_hard_vent_cooltime_addup";
            this.tb_hard_vent_cooltime_addup.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_vent_cooltime_addup.TabIndex = 16;
            this.tb_hard_vent_cooltime_addup.Text = "50";
            // 
            // lb_hard_vent_cooltime_addup
            // 
            this.lb_hard_vent_cooltime_addup.AutoSize = true;
            this.lb_hard_vent_cooltime_addup.Location = new System.Drawing.Point(11, 36);
            this.lb_hard_vent_cooltime_addup.Name = "lb_hard_vent_cooltime_addup";
            this.lb_hard_vent_cooltime_addup.Size = new System.Drawing.Size(99, 13);
            this.lb_hard_vent_cooltime_addup.TabIndex = 15;
            this.lb_hard_vent_cooltime_addup.Text = "쿨타임 증가량(초):";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(47, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "쿨타임(초):";
            // 
            // tb_hard_vent_cooltime
            // 
            this.tb_hard_vent_cooltime.Location = new System.Drawing.Point(112, 7);
            this.tb_hard_vent_cooltime.Name = "tb_hard_vent_cooltime";
            this.tb_hard_vent_cooltime.Size = new System.Drawing.Size(35, 21);
            this.tb_hard_vent_cooltime.TabIndex = 13;
            this.tb_hard_vent_cooltime.Text = "50";
            // 
            // cb_videoAfter_autoStart
            // 
            this.cb_videoAfter_autoStart.AutoSize = true;
            this.cb_videoAfter_autoStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_videoAfter_autoStart.Location = new System.Drawing.Point(891, 765);
            this.cb_videoAfter_autoStart.Name = "cb_videoAfter_autoStart";
            this.cb_videoAfter_autoStart.Size = new System.Drawing.Size(92, 17);
            this.cb_videoAfter_autoStart.TabIndex = 85;
            this.cb_videoAfter_autoStart.Text = "게임자동시작\r\n";
            this.cb_videoAfter_autoStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_videoAfter_autoStart.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_GameStart
            // 
            this.btn_GameSys_GameStart.BackColor = System.Drawing.Color.Green;
            this.btn_GameSys_GameStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_GameStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GameSys_GameStart.Location = new System.Drawing.Point(989, 824);
            this.btn_GameSys_GameStart.Name = "btn_GameSys_GameStart";
            this.btn_GameSys_GameStart.Size = new System.Drawing.Size(155, 100);
            this.btn_GameSys_GameStart.TabIndex = 47;
            this.btn_GameSys_GameStart.Text = "GAME START";
            this.btn_GameSys_GameStart.UseVisualStyleBackColor = false;
            this.btn_GameSys_GameStart.Click += new System.EventHandler(this.btn_GameSys_GameStart_Click);
            // 
            // cb_selfRevive_auto
            // 
            this.cb_selfRevive_auto.AutoSize = true;
            this.cb_selfRevive_auto.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_selfRevive_auto.Location = new System.Drawing.Point(891, 746);
            this.cb_selfRevive_auto.Name = "cb_selfRevive_auto";
            this.cb_selfRevive_auto.Size = new System.Drawing.Size(92, 17);
            this.cb_selfRevive_auto.TabIndex = 84;
            this.cb_selfRevive_auto.Text = "자동자가부활\r\n";
            this.cb_selfRevive_auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_selfRevive_auto.UseVisualStyleBackColor = true;
            // 
            // cb_iotAUTO
            // 
            this.cb_iotAUTO.AutoSize = true;
            this.cb_iotAUTO.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_iotAUTO.Location = new System.Drawing.Point(891, 726);
            this.cb_iotAUTO.Name = "cb_iotAUTO";
            this.cb_iotAUTO.Size = new System.Drawing.Size(92, 17);
            this.cb_iotAUTO.TabIndex = 83;
            this.cb_iotAUTO.Text = "IOT자동 리셋";
            this.cb_iotAUTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_iotAUTO.UseVisualStyleBackColor = true;
            // 
            // gp_IotSys_waitingroom
            // 
            this.gp_IotSys_waitingroom.Controls.Add(this.btn_ExerciseSys_DoorOpen);
            this.gp_IotSys_waitingroom.Controls.Add(this.lb_ExerciseSys_ES);
            this.gp_IotSys_waitingroom.Controls.Add(this.btn_ExerciseSys_ScreenDown);
            this.gp_IotSys_waitingroom.Controls.Add(this.lb_ExerciseSys_EP_State);
            this.gp_IotSys_waitingroom.Controls.Add(this.btn_ExerciseSys_ScreenUp);
            this.gp_IotSys_waitingroom.Controls.Add(this.lb_ExerciseSys_EP);
            this.gp_IotSys_waitingroom.Controls.Add(this.btn_ExerciseSys_DoorClose);
            this.gp_IotSys_waitingroom.Controls.Add(this.lb_ExerciseSys_ES_State);
            this.gp_IotSys_waitingroom.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotSys_waitingroom.Location = new System.Drawing.Point(503, 852);
            this.gp_IotSys_waitingroom.Name = "gp_IotSys_waitingroom";
            this.gp_IotSys_waitingroom.Size = new System.Drawing.Size(134, 128);
            this.gp_IotSys_waitingroom.TabIndex = 82;
            this.gp_IotSys_waitingroom.TabStop = false;
            this.gp_IotSys_waitingroom.Text = "대기실관리";
            // 
            // btn_ExerciseSys_DoorOpen
            // 
            this.btn_ExerciseSys_DoorOpen.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_DoorOpen.Location = new System.Drawing.Point(69, 61);
            this.btn_ExerciseSys_DoorOpen.Name = "btn_ExerciseSys_DoorOpen";
            this.btn_ExerciseSys_DoorOpen.Size = new System.Drawing.Size(63, 27);
            this.btn_ExerciseSys_DoorOpen.TabIndex = 81;
            this.btn_ExerciseSys_DoorOpen.Text = "OPEN";
            this.btn_ExerciseSys_DoorOpen.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_DoorOpen.Click += new System.EventHandler(this.btn_ExerciseSys_DoorOpen_Click);
            // 
            // lb_ExerciseSys_ES
            // 
            this.lb_ExerciseSys_ES.AutoSize = true;
            this.lb_ExerciseSys_ES.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ES.Location = new System.Drawing.Point(6, 26);
            this.lb_ExerciseSys_ES.Name = "lb_ExerciseSys_ES";
            this.lb_ExerciseSys_ES.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_ES.TabIndex = 74;
            this.lb_ExerciseSys_ES.Text = "ES";
            // 
            // btn_ExerciseSys_ScreenDown
            // 
            this.btn_ExerciseSys_ScreenDown.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ScreenDown.Location = new System.Drawing.Point(2, 92);
            this.btn_ExerciseSys_ScreenDown.Name = "btn_ExerciseSys_ScreenDown";
            this.btn_ExerciseSys_ScreenDown.Size = new System.Drawing.Size(63, 27);
            this.btn_ExerciseSys_ScreenDown.TabIndex = 80;
            this.btn_ExerciseSys_ScreenDown.Text = "DOWN";
            this.btn_ExerciseSys_ScreenDown.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_ScreenDown.Click += new System.EventHandler(this.btn_ExerciseSys_ScreenDown_Click);
            // 
            // lb_ExerciseSys_EP_State
            // 
            this.lb_ExerciseSys_EP_State.AutoSize = true;
            this.lb_ExerciseSys_EP_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EP_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EP_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EP_State.Location = new System.Drawing.Point(38, 44);
            this.lb_ExerciseSys_EP_State.Name = "lb_ExerciseSys_EP_State";
            this.lb_ExerciseSys_EP_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EP_State.TabIndex = 68;
            this.lb_ExerciseSys_EP_State.Text = "Offline";
            // 
            // btn_ExerciseSys_ScreenUp
            // 
            this.btn_ExerciseSys_ScreenUp.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ScreenUp.Location = new System.Drawing.Point(2, 61);
            this.btn_ExerciseSys_ScreenUp.Name = "btn_ExerciseSys_ScreenUp";
            this.btn_ExerciseSys_ScreenUp.Size = new System.Drawing.Size(63, 27);
            this.btn_ExerciseSys_ScreenUp.TabIndex = 79;
            this.btn_ExerciseSys_ScreenUp.Text = "UP";
            this.btn_ExerciseSys_ScreenUp.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_ScreenUp.Click += new System.EventHandler(this.btn_ExerciseSys_ScreenUp_Click);
            // 
            // lb_ExerciseSys_EP
            // 
            this.lb_ExerciseSys_EP.AutoSize = true;
            this.lb_ExerciseSys_EP.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EP.Location = new System.Drawing.Point(6, 44);
            this.lb_ExerciseSys_EP.Name = "lb_ExerciseSys_EP";
            this.lb_ExerciseSys_EP.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_EP.TabIndex = 69;
            this.lb_ExerciseSys_EP.Text = "EP";
            // 
            // btn_ExerciseSys_DoorClose
            // 
            this.btn_ExerciseSys_DoorClose.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_DoorClose.Location = new System.Drawing.Point(69, 92);
            this.btn_ExerciseSys_DoorClose.Name = "btn_ExerciseSys_DoorClose";
            this.btn_ExerciseSys_DoorClose.Size = new System.Drawing.Size(63, 27);
            this.btn_ExerciseSys_DoorClose.TabIndex = 78;
            this.btn_ExerciseSys_DoorClose.Text = "CLOSE";
            this.btn_ExerciseSys_DoorClose.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_DoorClose.Click += new System.EventHandler(this.btn_ExerciseSys_DoorClose_Click);
            // 
            // lb_ExerciseSys_ES_State
            // 
            this.lb_ExerciseSys_ES_State.AutoSize = true;
            this.lb_ExerciseSys_ES_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ES_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ES_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ES_State.Location = new System.Drawing.Point(38, 26);
            this.lb_ExerciseSys_ES_State.Name = "lb_ExerciseSys_ES_State";
            this.lb_ExerciseSys_ES_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ES_State.TabIndex = 73;
            this.lb_ExerciseSys_ES_State.Text = "Offline";
            // 
            // gp_light_setup
            // 
            this.gp_light_setup.Controls.Add(this.cb_GameSys_deviceLight_auto);
            this.gp_light_setup.Controls.Add(this.rb_GameSys_DayMode);
            this.gp_light_setup.Controls.Add(this.rb_GameSys_NightMode);
            this.gp_light_setup.Controls.Add(this.btn_GameSys_AL_Off);
            this.gp_light_setup.Controls.Add(this.label7);
            this.gp_light_setup.Controls.Add(this.btn_GameSys_AL_ON);
            this.gp_light_setup.Controls.Add(this.lb_TL_state);
            this.gp_light_setup.Controls.Add(this.label5);
            this.gp_light_setup.Controls.Add(this.lb_SL_state);
            this.gp_light_setup.Controls.Add(this.label3);
            this.gp_light_setup.Controls.Add(this.lb_CL_state);
            this.gp_light_setup.Controls.Add(this.label1);
            this.gp_light_setup.Controls.Add(this.lb_LL_state);
            this.gp_light_setup.Controls.Add(this.lb_BL_name);
            this.gp_light_setup.Controls.Add(this.lb_BL_state);
            this.gp_light_setup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_light_setup.Location = new System.Drawing.Point(642, 658);
            this.gp_light_setup.Name = "gp_light_setup";
            this.gp_light_setup.Size = new System.Drawing.Size(133, 231);
            this.gp_light_setup.TabIndex = 73;
            this.gp_light_setup.TabStop = false;
            this.gp_light_setup.Text = "조명관리";
            // 
            // cb_GameSys_deviceLight_auto
            // 
            this.cb_GameSys_deviceLight_auto.AutoSize = true;
            this.cb_GameSys_deviceLight_auto.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_GameSys_deviceLight_auto.Location = new System.Drawing.Point(14, 204);
            this.cb_GameSys_deviceLight_auto.Name = "cb_GameSys_deviceLight_auto";
            this.cb_GameSys_deviceLight_auto.Size = new System.Drawing.Size(106, 17);
            this.cb_GameSys_deviceLight_auto.TabIndex = 97;
            this.cb_GameSys_deviceLight_auto.Text = "장치밝기 자동화";
            this.cb_GameSys_deviceLight_auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_GameSys_deviceLight_auto.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_DayMode
            // 
            this.rb_GameSys_DayMode.AutoSize = true;
            this.rb_GameSys_DayMode.Checked = true;
            this.rb_GameSys_DayMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_DayMode.Location = new System.Drawing.Point(14, 29);
            this.rb_GameSys_DayMode.Name = "rb_GameSys_DayMode";
            this.rb_GameSys_DayMode.Size = new System.Drawing.Size(92, 19);
            this.rb_GameSys_DayMode.TabIndex = 93;
            this.rb_GameSys_DayMode.TabStop = true;
            this.rb_GameSys_DayMode.Text = "Day MODE";
            this.rb_GameSys_DayMode.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_NightMode
            // 
            this.rb_GameSys_NightMode.AutoSize = true;
            this.rb_GameSys_NightMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_NightMode.Location = new System.Drawing.Point(14, 52);
            this.rb_GameSys_NightMode.Name = "rb_GameSys_NightMode";
            this.rb_GameSys_NightMode.Size = new System.Drawing.Size(100, 19);
            this.rb_GameSys_NightMode.TabIndex = 92;
            this.rb_GameSys_NightMode.Text = "Night MODE";
            this.rb_GameSys_NightMode.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_AL_Off
            // 
            this.btn_GameSys_AL_Off.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_AL_Off.Location = new System.Drawing.Point(69, 176);
            this.btn_GameSys_AL_Off.Name = "btn_GameSys_AL_Off";
            this.btn_GameSys_AL_Off.Size = new System.Drawing.Size(51, 22);
            this.btn_GameSys_AL_Off.TabIndex = 83;
            this.btn_GameSys_AL_Off.Text = "OFF";
            this.btn_GameSys_AL_Off.UseVisualStyleBackColor = true;
            this.btn_GameSys_AL_Off.Click += new System.EventHandler(this.btn_GameSys_AL_Off_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(9, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 91;
            this.label7.Text = "TL";
            // 
            // btn_GameSys_AL_ON
            // 
            this.btn_GameSys_AL_ON.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_AL_ON.Location = new System.Drawing.Point(12, 176);
            this.btn_GameSys_AL_ON.Name = "btn_GameSys_AL_ON";
            this.btn_GameSys_AL_ON.Size = new System.Drawing.Size(51, 22);
            this.btn_GameSys_AL_ON.TabIndex = 82;
            this.btn_GameSys_AL_ON.Text = "ON";
            this.btn_GameSys_AL_ON.UseVisualStyleBackColor = true;
            this.btn_GameSys_AL_ON.Click += new System.EventHandler(this.btn_GameSys_AL_ON_Click);
            // 
            // lb_TL_state
            // 
            this.lb_TL_state.AutoSize = true;
            this.lb_TL_state.BackColor = System.Drawing.Color.Black;
            this.lb_TL_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_TL_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_TL_state.Location = new System.Drawing.Point(36, 157);
            this.lb_TL_state.Name = "lb_TL_state";
            this.lb_TL_state.Size = new System.Drawing.Size(55, 16);
            this.lb_TL_state.TabIndex = 90;
            this.lb_TL_state.Text = "Offline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "SL";
            // 
            // lb_SL_state
            // 
            this.lb_SL_state.AutoSize = true;
            this.lb_SL_state.BackColor = System.Drawing.Color.Black;
            this.lb_SL_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_SL_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SL_state.Location = new System.Drawing.Point(36, 137);
            this.lb_SL_state.Name = "lb_SL_state";
            this.lb_SL_state.Size = new System.Drawing.Size(55, 16);
            this.lb_SL_state.TabIndex = 88;
            this.lb_SL_state.Text = "Offline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "CL";
            // 
            // lb_CL_state
            // 
            this.lb_CL_state.AutoSize = true;
            this.lb_CL_state.BackColor = System.Drawing.Color.Black;
            this.lb_CL_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CL_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CL_state.Location = new System.Drawing.Point(36, 117);
            this.lb_CL_state.Name = "lb_CL_state";
            this.lb_CL_state.Size = new System.Drawing.Size(55, 16);
            this.lb_CL_state.TabIndex = 86;
            this.lb_CL_state.Text = "Offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "LL";
            // 
            // lb_LL_state
            // 
            this.lb_LL_state.AutoSize = true;
            this.lb_LL_state.BackColor = System.Drawing.Color.Black;
            this.lb_LL_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_LL_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_LL_state.Location = new System.Drawing.Point(36, 97);
            this.lb_LL_state.Name = "lb_LL_state";
            this.lb_LL_state.Size = new System.Drawing.Size(55, 16);
            this.lb_LL_state.TabIndex = 84;
            this.lb_LL_state.Text = "Offline";
            // 
            // lb_BL_name
            // 
            this.lb_BL_name.AutoSize = true;
            this.lb_BL_name.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BL_name.Location = new System.Drawing.Point(9, 78);
            this.lb_BL_name.Name = "lb_BL_name";
            this.lb_BL_name.Size = new System.Drawing.Size(25, 16);
            this.lb_BL_name.TabIndex = 83;
            this.lb_BL_name.Text = "BL";
            // 
            // lb_BL_state
            // 
            this.lb_BL_state.AutoSize = true;
            this.lb_BL_state.BackColor = System.Drawing.Color.Black;
            this.lb_BL_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BL_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BL_state.Location = new System.Drawing.Point(36, 78);
            this.lb_BL_state.Name = "lb_BL_state";
            this.lb_BL_state.Size = new System.Drawing.Size(55, 16);
            this.lb_BL_state.TabIndex = 82;
            this.lb_BL_state.Text = "Offline";
            // 
            // gb_revive_rnd
            // 
            this.gb_revive_rnd.BackColor = System.Drawing.SystemColors.Control;
            this.gb_revive_rnd.Controls.Add(this.lb_revive_9);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_8);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_1);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_2);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_14min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_11min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_7);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_17min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_5);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_23min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_4);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_3);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_6);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_0);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_26min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_29min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_20min);
            this.gb_revive_rnd.Controls.Add(this.lb_revive_32min);
            this.gb_revive_rnd.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_revive_rnd.Location = new System.Drawing.Point(524, 657);
            this.gb_revive_rnd.Name = "gb_revive_rnd";
            this.gb_revive_rnd.Size = new System.Drawing.Size(112, 192);
            this.gb_revive_rnd.TabIndex = 48;
            this.gb_revive_rnd.TabStop = false;
            this.gb_revive_rnd.Text = "부활장치";
            // 
            // lb_revive_9
            // 
            this.lb_revive_9.AutoSize = true;
            this.lb_revive_9.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_9.Location = new System.Drawing.Point(52, 169);
            this.lb_revive_9.Name = "lb_revive_9";
            this.lb_revive_9.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_9.TabIndex = 19;
            this.lb_revive_9.Text = "0";
            // 
            // lb_revive_8
            // 
            this.lb_revive_8.AutoSize = true;
            this.lb_revive_8.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_8.Location = new System.Drawing.Point(52, 153);
            this.lb_revive_8.Name = "lb_revive_8";
            this.lb_revive_8.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_8.TabIndex = 18;
            this.lb_revive_8.Text = "0";
            // 
            // lb_revive_1
            // 
            this.lb_revive_1.AutoSize = true;
            this.lb_revive_1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_1.Location = new System.Drawing.Point(52, 42);
            this.lb_revive_1.Name = "lb_revive_1";
            this.lb_revive_1.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_1.TabIndex = 17;
            this.lb_revive_1.Text = "0";
            // 
            // lb_revive_2
            // 
            this.lb_revive_2.AutoSize = true;
            this.lb_revive_2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_2.Location = new System.Drawing.Point(52, 57);
            this.lb_revive_2.Name = "lb_revive_2";
            this.lb_revive_2.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_2.TabIndex = 16;
            this.lb_revive_2.Text = "0";
            // 
            // lb_revive_14min
            // 
            this.lb_revive_14min.AutoSize = true;
            this.lb_revive_14min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_14min.Location = new System.Drawing.Point(6, 154);
            this.lb_revive_14min.Name = "lb_revive_14min";
            this.lb_revive_14min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_14min.TabIndex = 15;
            this.lb_revive_14min.Text = "14분:";
            // 
            // lb_revive_11min
            // 
            this.lb_revive_11min.AutoSize = true;
            this.lb_revive_11min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_11min.Location = new System.Drawing.Point(6, 170);
            this.lb_revive_11min.Name = "lb_revive_11min";
            this.lb_revive_11min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_11min.TabIndex = 14;
            this.lb_revive_11min.Text = "11분:";
            // 
            // lb_revive_7
            // 
            this.lb_revive_7.AutoSize = true;
            this.lb_revive_7.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_7.Location = new System.Drawing.Point(52, 137);
            this.lb_revive_7.Name = "lb_revive_7";
            this.lb_revive_7.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_7.TabIndex = 13;
            this.lb_revive_7.Text = "0";
            // 
            // lb_revive_17min
            // 
            this.lb_revive_17min.AutoSize = true;
            this.lb_revive_17min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_17min.Location = new System.Drawing.Point(6, 138);
            this.lb_revive_17min.Name = "lb_revive_17min";
            this.lb_revive_17min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_17min.TabIndex = 12;
            this.lb_revive_17min.Text = "17분:";
            // 
            // lb_revive_5
            // 
            this.lb_revive_5.AutoSize = true;
            this.lb_revive_5.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_5.Location = new System.Drawing.Point(52, 105);
            this.lb_revive_5.Name = "lb_revive_5";
            this.lb_revive_5.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_5.TabIndex = 11;
            this.lb_revive_5.Text = "0";
            // 
            // lb_revive_23min
            // 
            this.lb_revive_23min.AutoSize = true;
            this.lb_revive_23min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_23min.Location = new System.Drawing.Point(6, 106);
            this.lb_revive_23min.Name = "lb_revive_23min";
            this.lb_revive_23min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_23min.TabIndex = 6;
            this.lb_revive_23min.Text = "23분:";
            // 
            // lb_revive_4
            // 
            this.lb_revive_4.AutoSize = true;
            this.lb_revive_4.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_4.Location = new System.Drawing.Point(52, 89);
            this.lb_revive_4.Name = "lb_revive_4";
            this.lb_revive_4.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_4.TabIndex = 10;
            this.lb_revive_4.Text = "0";
            // 
            // lb_revive_3
            // 
            this.lb_revive_3.AutoSize = true;
            this.lb_revive_3.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_3.Location = new System.Drawing.Point(52, 73);
            this.lb_revive_3.Name = "lb_revive_3";
            this.lb_revive_3.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_3.TabIndex = 9;
            this.lb_revive_3.Text = "0";
            // 
            // lb_revive_6
            // 
            this.lb_revive_6.AutoSize = true;
            this.lb_revive_6.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_6.Location = new System.Drawing.Point(52, 121);
            this.lb_revive_6.Name = "lb_revive_6";
            this.lb_revive_6.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_6.TabIndex = 8;
            this.lb_revive_6.Text = "0";
            // 
            // lb_revive_0
            // 
            this.lb_revive_0.AutoSize = true;
            this.lb_revive_0.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_0.Location = new System.Drawing.Point(52, 26);
            this.lb_revive_0.Name = "lb_revive_0";
            this.lb_revive_0.Size = new System.Drawing.Size(17, 16);
            this.lb_revive_0.TabIndex = 7;
            this.lb_revive_0.Text = "0";
            // 
            // lb_revive_26min
            // 
            this.lb_revive_26min.AutoSize = true;
            this.lb_revive_26min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_26min.Location = new System.Drawing.Point(6, 89);
            this.lb_revive_26min.Name = "lb_revive_26min";
            this.lb_revive_26min.Size = new System.Drawing.Size(40, 16);
            this.lb_revive_26min.TabIndex = 3;
            this.lb_revive_26min.Text = "26분";
            // 
            // lb_revive_29min
            // 
            this.lb_revive_29min.AutoSize = true;
            this.lb_revive_29min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_29min.Location = new System.Drawing.Point(6, 73);
            this.lb_revive_29min.Name = "lb_revive_29min";
            this.lb_revive_29min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_29min.TabIndex = 2;
            this.lb_revive_29min.Text = "29분:";
            // 
            // lb_revive_20min
            // 
            this.lb_revive_20min.AutoSize = true;
            this.lb_revive_20min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_20min.Location = new System.Drawing.Point(6, 122);
            this.lb_revive_20min.Name = "lb_revive_20min";
            this.lb_revive_20min.Size = new System.Drawing.Size(45, 16);
            this.lb_revive_20min.TabIndex = 1;
            this.lb_revive_20min.Text = "20분:";
            // 
            // lb_revive_32min
            // 
            this.lb_revive_32min.AutoSize = true;
            this.lb_revive_32min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_revive_32min.Location = new System.Drawing.Point(6, 26);
            this.lb_revive_32min.Name = "lb_revive_32min";
            this.lb_revive_32min.Size = new System.Drawing.Size(40, 16);
            this.lb_revive_32min.TabIndex = 0;
            this.lb_revive_32min.Text = "32분";
            // 
            // gb_BlockTree
            // 
            this.gb_BlockTree.BackColor = System.Drawing.SystemColors.Control;
            this.gb_BlockTree.Controls.Add(this.btn_TaggerSkill_timereset);
            this.gb_BlockTree.Controls.Add(this.btn_TaggerSkill_timesubraction);
            this.gb_BlockTree.Controls.Add(this.btn_TaggerSkill_timeadd);
            this.gb_BlockTree.Controls.Add(this.lb_TaggerSkill_timer);
            this.gb_BlockTree.Controls.Add(this.btn_GameSys_rndBlock);
            this.gb_BlockTree.Controls.Add(this.lb_block_4);
            this.gb_BlockTree.Controls.Add(this.lb_block_15min);
            this.gb_BlockTree.Controls.Add(this.lb_block_3);
            this.gb_BlockTree.Controls.Add(this.lb_block_2);
            this.gb_BlockTree.Controls.Add(this.lb_block_5);
            this.gb_BlockTree.Controls.Add(this.lb_block_1);
            this.gb_BlockTree.Controls.Add(this.lb_block_20min);
            this.gb_BlockTree.Controls.Add(this.lb_block_25min);
            this.gb_BlockTree.Controls.Add(this.lb_block_10min);
            this.gb_BlockTree.Controls.Add(this.lb_block_30min);
            this.gb_BlockTree.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_BlockTree.Location = new System.Drawing.Point(385, 790);
            this.gb_BlockTree.Name = "gb_BlockTree";
            this.gb_BlockTree.Size = new System.Drawing.Size(112, 206);
            this.gb_BlockTree.TabIndex = 47;
            this.gb_BlockTree.TabStop = false;
            this.gb_BlockTree.Text = "봉쇄 트리";
            // 
            // btn_TaggerSkill_timereset
            // 
            this.btn_TaggerSkill_timereset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaggerSkill_timereset.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TaggerSkill_timereset.Location = new System.Drawing.Point(75, 148);
            this.btn_TaggerSkill_timereset.Name = "btn_TaggerSkill_timereset";
            this.btn_TaggerSkill_timereset.Size = new System.Drawing.Size(20, 23);
            this.btn_TaggerSkill_timereset.TabIndex = 95;
            this.btn_TaggerSkill_timereset.Text = "R";
            this.btn_TaggerSkill_timereset.UseVisualStyleBackColor = true;
            this.btn_TaggerSkill_timereset.Click += new System.EventHandler(this.btn_TaggerSkill_timereset_Click);
            // 
            // btn_TaggerSkill_timesubraction
            // 
            this.btn_TaggerSkill_timesubraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaggerSkill_timesubraction.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TaggerSkill_timesubraction.Location = new System.Drawing.Point(40, 148);
            this.btn_TaggerSkill_timesubraction.Name = "btn_TaggerSkill_timesubraction";
            this.btn_TaggerSkill_timesubraction.Size = new System.Drawing.Size(20, 23);
            this.btn_TaggerSkill_timesubraction.TabIndex = 94;
            this.btn_TaggerSkill_timesubraction.Text = "-";
            this.btn_TaggerSkill_timesubraction.UseVisualStyleBackColor = true;
            this.btn_TaggerSkill_timesubraction.Click += new System.EventHandler(this.btn_TaggerSkill_timesubraction_Click);
            // 
            // btn_TaggerSkill_timeadd
            // 
            this.btn_TaggerSkill_timeadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaggerSkill_timeadd.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TaggerSkill_timeadd.Location = new System.Drawing.Point(14, 148);
            this.btn_TaggerSkill_timeadd.Name = "btn_TaggerSkill_timeadd";
            this.btn_TaggerSkill_timeadd.Size = new System.Drawing.Size(20, 23);
            this.btn_TaggerSkill_timeadd.TabIndex = 93;
            this.btn_TaggerSkill_timeadd.Text = "+";
            this.btn_TaggerSkill_timeadd.UseVisualStyleBackColor = true;
            this.btn_TaggerSkill_timeadd.Click += new System.EventHandler(this.btn_TaggerSkill_timeadd_Click);
            // 
            // lb_TaggerSkill_timer
            // 
            this.lb_TaggerSkill_timer.AutoSize = true;
            this.lb_TaggerSkill_timer.Font = new System.Drawing.Font("HelveticaInserat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaggerSkill_timer.Location = new System.Drawing.Point(6, 110);
            this.lb_TaggerSkill_timer.Name = "lb_TaggerSkill_timer";
            this.lb_TaggerSkill_timer.Size = new System.Drawing.Size(100, 44);
            this.lb_TaggerSkill_timer.TabIndex = 92;
            this.lb_TaggerSkill_timer.Text = "32:00";
            // 
            // btn_GameSys_rndBlock
            // 
            this.btn_GameSys_rndBlock.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_rndBlock.Location = new System.Drawing.Point(3, 175);
            this.btn_GameSys_rndBlock.Name = "btn_GameSys_rndBlock";
            this.btn_GameSys_rndBlock.Size = new System.Drawing.Size(103, 26);
            this.btn_GameSys_rndBlock.TabIndex = 78;
            this.btn_GameSys_rndBlock.Text = "봉쇄 랜덤설정";
            this.btn_GameSys_rndBlock.UseVisualStyleBackColor = true;
            this.btn_GameSys_rndBlock.Click += new System.EventHandler(this.btn_GameSys_rndBlock_Click);
            // 
            // lb_block_4
            // 
            this.lb_block_4.AutoSize = true;
            this.lb_block_4.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_4.Location = new System.Drawing.Point(51, 73);
            this.lb_block_4.Name = "lb_block_4";
            this.lb_block_4.Size = new System.Drawing.Size(59, 16);
            this.lb_block_4.TabIndex = 11;
            this.lb_block_4.Text = "태그머신";
            // 
            // lb_block_15min
            // 
            this.lb_block_15min.AutoSize = true;
            this.lb_block_15min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_15min.Location = new System.Drawing.Point(6, 72);
            this.lb_block_15min.Name = "lb_block_15min";
            this.lb_block_15min.Size = new System.Drawing.Size(45, 16);
            this.lb_block_15min.TabIndex = 6;
            this.lb_block_15min.Text = "12분:";
            // 
            // lb_block_3
            // 
            this.lb_block_3.AutoSize = true;
            this.lb_block_3.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_3.Location = new System.Drawing.Point(51, 56);
            this.lb_block_3.Name = "lb_block_3";
            this.lb_block_3.Size = new System.Drawing.Size(33, 16);
            this.lb_block_3.TabIndex = 10;
            this.lb_block_3.Text = "덕트";
            // 
            // lb_block_2
            // 
            this.lb_block_2.AutoSize = true;
            this.lb_block_2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_2.Location = new System.Drawing.Point(51, 40);
            this.lb_block_2.Name = "lb_block_2";
            this.lb_block_2.Size = new System.Drawing.Size(46, 16);
            this.lb_block_2.TabIndex = 9;
            this.lb_block_2.Text = "발전기";
            // 
            // lb_block_5
            // 
            this.lb_block_5.AutoSize = true;
            this.lb_block_5.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_5.Location = new System.Drawing.Point(51, 88);
            this.lb_block_5.Name = "lb_block_5";
            this.lb_block_5.Size = new System.Drawing.Size(59, 16);
            this.lb_block_5.TabIndex = 8;
            this.lb_block_5.Text = "탈출장치";
            // 
            // lb_block_1
            // 
            this.lb_block_1.AutoSize = true;
            this.lb_block_1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_1.Location = new System.Drawing.Point(51, 23);
            this.lb_block_1.Name = "lb_block_1";
            this.lb_block_1.Size = new System.Drawing.Size(33, 16);
            this.lb_block_1.TabIndex = 7;
            this.lb_block_1.Text = "랜덤";
            // 
            // lb_block_20min
            // 
            this.lb_block_20min.AutoSize = true;
            this.lb_block_20min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_20min.Location = new System.Drawing.Point(6, 56);
            this.lb_block_20min.Name = "lb_block_20min";
            this.lb_block_20min.Size = new System.Drawing.Size(45, 16);
            this.lb_block_20min.TabIndex = 3;
            this.lb_block_20min.Text = "17분:";
            // 
            // lb_block_25min
            // 
            this.lb_block_25min.AutoSize = true;
            this.lb_block_25min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_25min.Location = new System.Drawing.Point(6, 40);
            this.lb_block_25min.Name = "lb_block_25min";
            this.lb_block_25min.Size = new System.Drawing.Size(45, 16);
            this.lb_block_25min.TabIndex = 2;
            this.lb_block_25min.Text = "22분:";
            // 
            // lb_block_10min
            // 
            this.lb_block_10min.AutoSize = true;
            this.lb_block_10min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_10min.Location = new System.Drawing.Point(6, 88);
            this.lb_block_10min.Name = "lb_block_10min";
            this.lb_block_10min.Size = new System.Drawing.Size(45, 16);
            this.lb_block_10min.TabIndex = 1;
            this.lb_block_10min.Text = "07분:";
            // 
            // lb_block_30min
            // 
            this.lb_block_30min.AutoSize = true;
            this.lb_block_30min.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_block_30min.Location = new System.Drawing.Point(6, 24);
            this.lb_block_30min.Name = "lb_block_30min";
            this.lb_block_30min.Size = new System.Drawing.Size(49, 16);
            this.lb_block_30min.TabIndex = 0;
            this.lb_block_30min.Text = "27분: ";
            // 
            // gp_IotGroup
            // 
            this.gp_IotGroup.BackColor = System.Drawing.SystemColors.Control;
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group3);
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group2);
            this.gp_IotGroup.Controls.Add(this.rb_IOT_Group1);
            this.gp_IotGroup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotGroup.Location = new System.Drawing.Point(948, 566);
            this.gp_IotGroup.Name = "gp_IotGroup";
            this.gp_IotGroup.Size = new System.Drawing.Size(110, 87);
            this.gp_IotGroup.TabIndex = 46;
            this.gp_IotGroup.TabStop = false;
            this.gp_IotGroup.Text = "IOT그룹";
            // 
            // rb_IOT_Group3
            // 
            this.rb_IOT_Group3.AutoSize = true;
            this.rb_IOT_Group3.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_IOT_Group3.Location = new System.Drawing.Point(9, 67);
            this.rb_IOT_Group3.Name = "rb_IOT_Group3";
            this.rb_IOT_Group3.Size = new System.Drawing.Size(88, 17);
            this.rb_IOT_Group3.TabIndex = 2;
            this.rb_IOT_Group3.Text = "IOT테스트용";
            this.rb_IOT_Group3.UseVisualStyleBackColor = true;
            // 
            // rb_IOT_Group2
            // 
            this.rb_IOT_Group2.AutoSize = true;
            this.rb_IOT_Group2.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_IOT_Group2.Location = new System.Drawing.Point(9, 44);
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
            this.rb_IOT_Group1.Location = new System.Drawing.Point(9, 21);
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
            this.btn_GameSys_SetupMode.Location = new System.Drawing.Point(988, 773);
            this.btn_GameSys_SetupMode.Name = "btn_GameSys_SetupMode";
            this.btn_GameSys_SetupMode.Size = new System.Drawing.Size(156, 45);
            this.btn_GameSys_SetupMode.TabIndex = 52;
            this.btn_GameSys_SetupMode.Text = "장치 세팅모드";
            this.btn_GameSys_SetupMode.UseVisualStyleBackColor = false;
            this.btn_GameSys_SetupMode.Click += new System.EventHandler(this.btn_GameSys_SetupMode_Click);
            // 
            // gp_GameSys_ManualMode
            // 
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_NarrantionPlay);
            this.gp_GameSys_ManualMode.Controls.Add(this.cb_GameSys_Narration);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_OSReset);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_SelfRevive);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_OS_Start);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_GameStop);
            this.gp_GameSys_ManualMode.Controls.Add(this.btn_GameSys_VideoPlay);
            this.gp_GameSys_ManualMode.Font = new System.Drawing.Font("HelveticaInserat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_GameSys_ManualMode.Location = new System.Drawing.Point(645, 894);
            this.gp_GameSys_ManualMode.Name = "gp_GameSys_ManualMode";
            this.gp_GameSys_ManualMode.Size = new System.Drawing.Size(340, 102);
            this.gp_GameSys_ManualMode.TabIndex = 51;
            this.gp_GameSys_ManualMode.TabStop = false;
            this.gp_GameSys_ManualMode.Text = "Manual Mode";
            // 
            // btn_GameSys_NarrantionPlay
            // 
            this.btn_GameSys_NarrantionPlay.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_NarrantionPlay.Location = new System.Drawing.Point(266, 73);
            this.btn_GameSys_NarrantionPlay.Name = "btn_GameSys_NarrantionPlay";
            this.btn_GameSys_NarrantionPlay.Size = new System.Drawing.Size(61, 25);
            this.btn_GameSys_NarrantionPlay.TabIndex = 57;
            this.btn_GameSys_NarrantionPlay.Text = "출력";
            this.btn_GameSys_NarrantionPlay.UseVisualStyleBackColor = true;
            this.btn_GameSys_NarrantionPlay.Click += new System.EventHandler(this.btn_GameSys_NarrantionPlay_Click);
            // 
            // cb_GameSys_Narration
            // 
            this.cb_GameSys_Narration.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GameSys_Narration.FormattingEnabled = true;
            this.cb_GameSys_Narration.Items.AddRange(new object[] {
            "(VO7_1)한개의 전원공급장치가 수리 되었습니다",
            "(VO22)모든 전원공급장치의 수리가 완료되었습니다.",
            "(VO23)탈출 장치가 활성화 됩니다",
            "(VO23)생명장치 활성화",
            "(VO39)자가부활 모드 음원",
            "(VO8-1)생존자가 사망했습니다. ",
            "(VO11)모든 생명조각이 모였습니다.술래가 승리했습니다",
            "(VO13)제단이 활성화 됩니다.술래가 승리했습니다",
            "(VO14)탈출제한 시간이 씉났습니다.술래가 승리했습니다",
            "(VO25)탈출에 성공하였습니다. 생존자가 승리했습니다.",
            "(VO31)술래능력 개방 아이템박스 봉쇄가 가능합니다. ",
            "(VO32)술래능력 개방 생명장치 봉쇄가 가능합니다. ",
            "(VO33)술래능력 개방 전원공급장치 봉쇄가 가능합니다. ",
            "(VO34)술래능력 개방 덕트 봉쇄가 가능합니다. ",
            "(VO36)술래능력 개방 태그머신 봉쇄가 가능합니다. ",
            "(VO35)술래능력 개방 탈출장치 봉쇄가 가능합니다. ",
            "(VO10) 생존자들의 마지막 생명이 남았습니다."});
            this.cb_GameSys_Narration.Location = new System.Drawing.Point(6, 73);
            this.cb_GameSys_Narration.Name = "cb_GameSys_Narration";
            this.cb_GameSys_Narration.Size = new System.Drawing.Size(257, 24);
            this.cb_GameSys_Narration.TabIndex = 56;
            this.cb_GameSys_Narration.Text = "나레이션 선택";
            // 
            // btn_GameSys_OSReset
            // 
            this.btn_GameSys_OSReset.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_OSReset.Location = new System.Drawing.Point(275, 25);
            this.btn_GameSys_OSReset.Name = "btn_GameSys_OSReset";
            this.btn_GameSys_OSReset.Size = new System.Drawing.Size(62, 45);
            this.btn_GameSys_OSReset.TabIndex = 54;
            this.btn_GameSys_OSReset.Text = "OS\r\n리셋";
            this.btn_GameSys_OSReset.UseVisualStyleBackColor = true;
            this.btn_GameSys_OSReset.Click += new System.EventHandler(this.btn_GameSys_OSReset_Click);
            // 
            // btn_GameSys_SelfRevive
            // 
            this.btn_GameSys_SelfRevive.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_SelfRevive.Location = new System.Drawing.Point(209, 25);
            this.btn_GameSys_SelfRevive.Name = "btn_GameSys_SelfRevive";
            this.btn_GameSys_SelfRevive.Size = new System.Drawing.Size(62, 45);
            this.btn_GameSys_SelfRevive.TabIndex = 53;
            this.btn_GameSys_SelfRevive.Text = "자가\r\n부활";
            this.btn_GameSys_SelfRevive.UseVisualStyleBackColor = true;
            this.btn_GameSys_SelfRevive.Click += new System.EventHandler(this.btn_GameSys_SelfRevive_Click);
            // 
            // btn_GameSys_OS_Start
            // 
            this.btn_GameSys_OS_Start.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_OS_Start.Location = new System.Drawing.Point(141, 25);
            this.btn_GameSys_OS_Start.Name = "btn_GameSys_OS_Start";
            this.btn_GameSys_OS_Start.Size = new System.Drawing.Size(62, 45);
            this.btn_GameSys_OS_Start.TabIndex = 52;
            this.btn_GameSys_OS_Start.Text = "아이템\r\n오픈";
            this.btn_GameSys_OS_Start.UseVisualStyleBackColor = true;
            this.btn_GameSys_OS_Start.Click += new System.EventHandler(this.btn_GameSys_OS_Start_Click);
            // 
            // btn_GameSys_GameStop
            // 
            this.btn_GameSys_GameStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_GameStop.Location = new System.Drawing.Point(6, 25);
            this.btn_GameSys_GameStop.Name = "btn_GameSys_GameStop";
            this.btn_GameSys_GameStop.Size = new System.Drawing.Size(62, 45);
            this.btn_GameSys_GameStop.TabIndex = 51;
            this.btn_GameSys_GameStop.Text = "GAME STOP";
            this.btn_GameSys_GameStop.UseVisualStyleBackColor = true;
            this.btn_GameSys_GameStop.Click += new System.EventHandler(this.btn_GameSys_GameStop_Click);
            // 
            // btn_GameSys_VideoPlay
            // 
            this.btn_GameSys_VideoPlay.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_VideoPlay.Location = new System.Drawing.Point(73, 25);
            this.btn_GameSys_VideoPlay.Name = "btn_GameSys_VideoPlay";
            this.btn_GameSys_VideoPlay.Size = new System.Drawing.Size(62, 45);
            this.btn_GameSys_VideoPlay.TabIndex = 49;
            this.btn_GameSys_VideoPlay.Text = "덕트\r\n테스트\r\n";
            this.btn_GameSys_VideoPlay.UseVisualStyleBackColor = true;
            this.btn_GameSys_VideoPlay.Click += new System.EventHandler(this.btn_GameSys_VideoPlay_Click);
            // 
            // gp_MemeberSetup
            // 
            this.gp_MemeberSetup.BackColor = System.Drawing.SystemColors.Control;
            this.gp_MemeberSetup.Controls.Add(this.btn_GameSys_playPeople);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_7P);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_6P);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_5P);
            this.gp_MemeberSetup.Controls.Add(this.rb_GameSys_4P);
            this.gp_MemeberSetup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_MemeberSetup.Location = new System.Drawing.Point(832, 566);
            this.gp_MemeberSetup.Name = "gp_MemeberSetup";
            this.gp_MemeberSetup.Size = new System.Drawing.Size(110, 87);
            this.gp_MemeberSetup.TabIndex = 45;
            this.gp_MemeberSetup.TabStop = false;
            this.gp_MemeberSetup.Text = "인원설정";
            // 
            // btn_GameSys_playPeople
            // 
            this.btn_GameSys_playPeople.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_playPeople.Location = new System.Drawing.Point(7, 62);
            this.btn_GameSys_playPeople.Name = "btn_GameSys_playPeople";
            this.btn_GameSys_playPeople.Size = new System.Drawing.Size(94, 22);
            this.btn_GameSys_playPeople.TabIndex = 78;
            this.btn_GameSys_playPeople.Text = "인원설정";
            this.btn_GameSys_playPeople.UseVisualStyleBackColor = true;
            this.btn_GameSys_playPeople.Click += new System.EventHandler(this.btn_GameSys_playPeople_Click);
            // 
            // rb_GameSys_7P
            // 
            this.rb_GameSys_7P.AutoSize = true;
            this.rb_GameSys_7P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_7P.Location = new System.Drawing.Point(58, 43);
            this.rb_GameSys_7P.Name = "rb_GameSys_7P";
            this.rb_GameSys_7P.Size = new System.Drawing.Size(44, 17);
            this.rb_GameSys_7P.TabIndex = 3;
            this.rb_GameSys_7P.Text = "7인";
            this.rb_GameSys_7P.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_6P
            // 
            this.rb_GameSys_6P.AutoSize = true;
            this.rb_GameSys_6P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_6P.Location = new System.Drawing.Point(58, 22);
            this.rb_GameSys_6P.Name = "rb_GameSys_6P";
            this.rb_GameSys_6P.Size = new System.Drawing.Size(44, 17);
            this.rb_GameSys_6P.TabIndex = 2;
            this.rb_GameSys_6P.Text = "6인";
            this.rb_GameSys_6P.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_5P
            // 
            this.rb_GameSys_5P.AutoSize = true;
            this.rb_GameSys_5P.Checked = true;
            this.rb_GameSys_5P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_5P.Location = new System.Drawing.Point(7, 44);
            this.rb_GameSys_5P.Name = "rb_GameSys_5P";
            this.rb_GameSys_5P.Size = new System.Drawing.Size(44, 17);
            this.rb_GameSys_5P.TabIndex = 1;
            this.rb_GameSys_5P.TabStop = true;
            this.rb_GameSys_5P.Text = "5인";
            this.rb_GameSys_5P.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_4P
            // 
            this.rb_GameSys_4P.AutoSize = true;
            this.rb_GameSys_4P.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_4P.Location = new System.Drawing.Point(7, 23);
            this.rb_GameSys_4P.Name = "rb_GameSys_4P";
            this.rb_GameSys_4P.Size = new System.Drawing.Size(44, 17);
            this.rb_GameSys_4P.TabIndex = 0;
            this.rb_GameSys_4P.Text = "4인";
            this.rb_GameSys_4P.UseVisualStyleBackColor = true;
            // 
            // btn_GameSys_ReadyMode
            // 
            this.btn_GameSys_ReadyMode.BackColor = System.Drawing.Color.Red;
            this.btn_GameSys_ReadyMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_ReadyMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GameSys_ReadyMode.Location = new System.Drawing.Point(988, 722);
            this.btn_GameSys_ReadyMode.Name = "btn_GameSys_ReadyMode";
            this.btn_GameSys_ReadyMode.Size = new System.Drawing.Size(156, 45);
            this.btn_GameSys_ReadyMode.TabIndex = 14;
            this.btn_GameSys_ReadyMode.Text = "장치 준비모드";
            this.btn_GameSys_ReadyMode.UseVisualStyleBackColor = false;
            this.btn_GameSys_ReadyMode.Click += new System.EventHandler(this.btn_GameSys_ReadyMode_Click);
            // 
            // gp_GameSys_Progress
            // 
            this.gp_GameSys_Progress.BackColor = System.Drawing.SystemColors.Control;
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_CollectedTemple_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_CollectedTemple);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_SelfReviveTime);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_FixedGenerator_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_UsedRevive_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_OpenItembox_cnt);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_SelfRevive);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_FixedGenerator);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_UsedRevive);
            this.gp_GameSys_Progress.Controls.Add(this.lb_GameSys_OpenItembox);
            this.gp_GameSys_Progress.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_GameSys_Progress.Location = new System.Drawing.Point(385, 657);
            this.gp_GameSys_Progress.Name = "gp_GameSys_Progress";
            this.gp_GameSys_Progress.Size = new System.Drawing.Size(133, 128);
            this.gp_GameSys_Progress.TabIndex = 46;
            this.gp_GameSys_Progress.TabStop = false;
            this.gp_GameSys_Progress.Text = "게임 진행도";
            // 
            // lb_GameSys_CollectedTemple_cnt
            // 
            this.lb_GameSys_CollectedTemple_cnt.AutoSize = true;
            this.lb_GameSys_CollectedTemple_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_CollectedTemple_cnt.Location = new System.Drawing.Point(112, 60);
            this.lb_GameSys_CollectedTemple_cnt.Name = "lb_GameSys_CollectedTemple_cnt";
            this.lb_GameSys_CollectedTemple_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_CollectedTemple_cnt.TabIndex = 11;
            this.lb_GameSys_CollectedTemple_cnt.Text = "0";
            // 
            // lb_GameSys_CollectedTemple
            // 
            this.lb_GameSys_CollectedTemple.AutoSize = true;
            this.lb_GameSys_CollectedTemple.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_CollectedTemple.Location = new System.Drawing.Point(6, 60);
            this.lb_GameSys_CollectedTemple.Name = "lb_GameSys_CollectedTemple";
            this.lb_GameSys_CollectedTemple.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_CollectedTemple.TabIndex = 6;
            this.lb_GameSys_CollectedTemple.Text = "제단 생명칩개수:";
            // 
            // lb_GameSys_SelfReviveTime
            // 
            this.lb_GameSys_SelfReviveTime.AutoSize = true;
            this.lb_GameSys_SelfReviveTime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_SelfReviveTime.Location = new System.Drawing.Point(71, 99);
            this.lb_GameSys_SelfReviveTime.Name = "lb_GameSys_SelfReviveTime";
            this.lb_GameSys_SelfReviveTime.Size = new System.Drawing.Size(42, 16);
            this.lb_GameSys_SelfReviveTime.TabIndex = 10;
            this.lb_GameSys_SelfReviveTime.Text = "1:30";
            // 
            // lb_GameSys_FixedGenerator_cnt
            // 
            this.lb_GameSys_FixedGenerator_cnt.AutoSize = true;
            this.lb_GameSys_FixedGenerator_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_FixedGenerator_cnt.Location = new System.Drawing.Point(112, 44);
            this.lb_GameSys_FixedGenerator_cnt.Name = "lb_GameSys_FixedGenerator_cnt";
            this.lb_GameSys_FixedGenerator_cnt.Size = new System.Drawing.Size(17, 16);
            this.lb_GameSys_FixedGenerator_cnt.TabIndex = 9;
            this.lb_GameSys_FixedGenerator_cnt.Text = "0";
            // 
            // lb_GameSys_UsedRevive_cnt
            // 
            this.lb_GameSys_UsedRevive_cnt.AutoSize = true;
            this.lb_GameSys_UsedRevive_cnt.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_UsedRevive_cnt.Location = new System.Drawing.Point(112, 78);
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
            // lb_GameSys_SelfRevive
            // 
            this.lb_GameSys_SelfRevive.AutoSize = true;
            this.lb_GameSys_SelfRevive.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_SelfRevive.Location = new System.Drawing.Point(6, 99);
            this.lb_GameSys_SelfRevive.Name = "lb_GameSys_SelfRevive";
            this.lb_GameSys_SelfRevive.Size = new System.Drawing.Size(64, 16);
            this.lb_GameSys_SelfRevive.TabIndex = 3;
            this.lb_GameSys_SelfRevive.Text = "자가부활:";
            // 
            // lb_GameSys_FixedGenerator
            // 
            this.lb_GameSys_FixedGenerator.AutoSize = true;
            this.lb_GameSys_FixedGenerator.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_FixedGenerator.Location = new System.Drawing.Point(6, 44);
            this.lb_GameSys_FixedGenerator.Name = "lb_GameSys_FixedGenerator";
            this.lb_GameSys_FixedGenerator.Size = new System.Drawing.Size(107, 16);
            this.lb_GameSys_FixedGenerator.TabIndex = 2;
            this.lb_GameSys_FixedGenerator.Text = "수리완료 발전기:";
            // 
            // lb_GameSys_UsedRevive
            // 
            this.lb_GameSys_UsedRevive.AutoSize = true;
            this.lb_GameSys_UsedRevive.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_GameSys_UsedRevive.Location = new System.Drawing.Point(6, 78);
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
            this.gp_GameSys_time.Location = new System.Drawing.Point(6, 658);
            this.gp_GameSys_time.Name = "gp_GameSys_time";
            this.gp_GameSys_time.Size = new System.Drawing.Size(373, 137);
            this.gp_GameSys_time.TabIndex = 45;
            this.gp_GameSys_time.TabStop = false;
            this.gp_GameSys_time.Text = "Playing Time";
            // 
            // btn_GameSys_timerStop
            // 
            this.btn_GameSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_timerStop.Location = new System.Drawing.Point(286, 105);
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
            this.btn_GameSys_timerStart.Location = new System.Drawing.Point(286, 76);
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
            this.btn_GameSys_1min_add.Location = new System.Drawing.Point(286, 47);
            this.btn_GameSys_1min_add.Name = "btn_GameSys_1min_add";
            this.btn_GameSys_1min_add.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_1min_add.TabIndex = 39;
            this.btn_GameSys_1min_add.Text = "30초 감소";
            this.btn_GameSys_1min_add.UseVisualStyleBackColor = true;
            this.btn_GameSys_1min_add.Click += new System.EventHandler(this.btn_GameSys_1min_add_Click);
            // 
            // btn_GameSys_5min_add
            // 
            this.btn_GameSys_5min_add.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GameSys_5min_add.Location = new System.Drawing.Point(286, 18);
            this.btn_GameSys_5min_add.Name = "btn_GameSys_5min_add";
            this.btn_GameSys_5min_add.Size = new System.Drawing.Size(81, 23);
            this.btn_GameSys_5min_add.TabIndex = 38;
            this.btn_GameSys_5min_add.Text = "1분 추가";
            this.btn_GameSys_5min_add.UseVisualStyleBackColor = true;
            this.btn_GameSys_5min_add.Click += new System.EventHandler(this.btn_GameSys_5min_add_Click);
            // 
            // lb_GameSys_Clock
            // 
            this.lb_GameSys_Clock.AutoSize = true;
            this.lb_GameSys_Clock.BackColor = System.Drawing.Color.Transparent;
            this.lb_GameSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GameSys_Clock.Location = new System.Drawing.Point(-3, 14);
            this.lb_GameSys_Clock.Name = "lb_GameSys_Clock";
            this.lb_GameSys_Clock.Size = new System.Drawing.Size(296, 133);
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
            this.gp_ModeSetup.Location = new System.Drawing.Point(715, 566);
            this.gp_ModeSetup.Name = "gp_ModeSetup";
            this.gp_ModeSetup.Size = new System.Drawing.Size(110, 87);
            this.gp_ModeSetup.TabIndex = 44;
            this.gp_ModeSetup.TabStop = false;
            this.gp_ModeSetup.Text = "모드설정";
            // 
            // rb_GameSys_HardMode
            // 
            this.rb_GameSys_HardMode.AutoSize = true;
            this.rb_GameSys_HardMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_HardMode.Location = new System.Drawing.Point(11, 67);
            this.rb_GameSys_HardMode.Name = "rb_GameSys_HardMode";
            this.rb_GameSys_HardMode.Size = new System.Drawing.Size(83, 17);
            this.rb_GameSys_HardMode.TabIndex = 2;
            this.rb_GameSys_HardMode.Text = "찌발 MODE";
            this.rb_GameSys_HardMode.UseVisualStyleBackColor = true;
            // 
            // rb_GameSys_NormalMode
            // 
            this.rb_GameSys_NormalMode.AutoSize = true;
            this.rb_GameSys_NormalMode.Checked = true;
            this.rb_GameSys_NormalMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_GameSys_NormalMode.Location = new System.Drawing.Point(11, 44);
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
            this.rb_GameSys_EasyMode.Location = new System.Drawing.Point(11, 21);
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
            this.panel6.Size = new System.Drawing.Size(2, 510);
            this.panel6.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(1001, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 510);
            this.panel5.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(854, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 510);
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
            this.gp_Revive.Text = "생명장치(R)";
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
            this.btn_Revive_send.Click += new System.EventHandler(this.btn_Revive_send_Click);
            // 
            // cb_Revive_state
            // 
            this.cb_Revive_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Revive_state.FormattingEnabled = true;
            this.cb_Revive_state.Items.AddRange(new object[] {
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)장치 연결상태확인",
            "(B)봉쇄 활성화",
            "(O)장치오픈",
            "(E)자가부활모드",
            "(N)나이트 모드",
            "(D)데이모드",
            "(W)리셋(와치독)"});
            this.cb_Revive_state.Location = new System.Drawing.Point(6, 50);
            this.cb_Revive_state.Name = "cb_Revive_state";
            this.cb_Revive_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Revive_state.TabIndex = 11;
            this.cb_Revive_state.Text = "(A)장치연결";
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
            this.cb_Revive_name.Text = "ALL";
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
            this.btn_Escape_send.Click += new System.EventHandler(this.btn_Escape_send_Click);
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
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)현재상태",
            "(B)봉쇄 단계",
            "(E)탈출 완료",
            "(W)리셋(와치독)"});
            this.cb_Escape_state.Location = new System.Drawing.Point(6, 50);
            this.cb_Escape_state.Name = "cb_Escape_state";
            this.cb_Escape_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Escape_state.TabIndex = 37;
            this.cb_Escape_state.Text = "(A)장치연결";
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
            this.cb_Escape_name.Text = "ALL";
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
            this.lb_LE_state.BackColor = System.Drawing.Color.DimGray;
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
            this.lb_BE_state.BackColor = System.Drawing.Color.DimGray;
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
            this.btn_Itembox_send.Click += new System.EventHandler(this.btn_Itembox_send_Click);
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
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)장치 연결상태확인",
            "(B)봉쇄 활성화",
            "(O)장치오픈",
            "(M) 뉴비모드",
            "(M) 일반모드",
            "(M) 찌발모드",
            "(N)나이트 모드",
            "(D)데이모드",
            "(W)리셋(와치독)",
            "(Q)아이템박스 빠른리셋"});
            this.cb_Itembox_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Itembox_state.Name = "cb_Itembox_state";
            this.cb_Itembox_state.Size = new System.Drawing.Size(116, 23);
            this.cb_Itembox_state.TabIndex = 31;
            this.cb_Itembox_state.Text = "(A)장치연결";
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
            this.cb_Itembox_name.Text = "ALL";
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
            this.btn_Generator_send.Click += new System.EventHandler(this.btn_Generator_send_Click);
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
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)현재상태",
            "(B1)봉쇄 1단계",
            "(B2)봉쇄 2단계",
            "(B3)봉쇄 3단계",
            "(O)장치오픈",
            "(M) 뉴비 모드",
            "(M) 일반 모드",
            "(E)배선수리 완료",
            "(F)발전기수리 완료",
            "(N)나이트 모드",
            "(D)데이모드",
            "(W)리셋(와치독)"});
            this.cb_Generator_state.Location = new System.Drawing.Point(6, 49);
            this.cb_Generator_state.Name = "cb_Generator_state";
            this.cb_Generator_state.Size = new System.Drawing.Size(116, 23);
            this.cb_Generator_state.TabIndex = 34;
            this.cb_Generator_state.Text = "(A)장치연결";
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
            this.cb_Generator_name.Text = "ALL";
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
            this.cb_serialPort_PCM.Location = new System.Drawing.Point(6, 584);
            this.cb_serialPort_PCM.Name = "cb_serialPort_PCM";
            this.cb_serialPort_PCM.Size = new System.Drawing.Size(186, 27);
            this.cb_serialPort_PCM.TabIndex = 4;
            this.cb_serialPort_PCM.Text = "기본세팅: COM17";
            // 
            // lb_serialPort_PCM
            // 
            this.lb_serialPort_PCM.AutoSize = true;
            this.lb_serialPort_PCM.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_serialPort_PCM.Location = new System.Drawing.Point(6, 562);
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
            this.gp_Vent.TabIndex = 0;
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
            this.btn_Vent_send.Click += new System.EventHandler(this.btn_Vent_send_Click);
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
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)현재상태",
            "(B1)봉쇄 1단계",
            "(B2)봉쇄 2단계",
            "(B3)봉쇄 3단계",
            "(O)장치오픈",
            "(M)뉴비모드",
            "(M)일반모드",
            "(N)나이트 모드",
            "(D)데이모드",
            "(W)리셋(와치독)"});
            this.cb_Vent_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Vent_state.Name = "cb_Vent_state";
            this.cb_Vent_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Vent_state.TabIndex = 40;
            this.cb_Vent_state.Text = "(A)장치연결";
            // 
            // cb_Vent_name
            // 
            this.cb_Vent_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vent_name.FormattingEnabled = true;
            this.cb_Vent_name.Items.AddRange(new object[] {
            "ALL",
            "BV1",
            "CV",
            "TV",
            "BV2",
            "LV",
            "SV"});
            this.cb_Vent_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Vent_name.Name = "cb_Vent_name";
            this.cb_Vent_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Vent_name.TabIndex = 39;
            this.cb_Vent_name.Text = "ALL";
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
            this.gp_Door.Controls.Add(this.lb_TD_taggertime);
            this.gp_Door.Controls.Add(this.lb_SD_taggertime);
            this.gp_Door.Controls.Add(this.lb_CD_taggertime);
            this.gp_Door.Controls.Add(this.lb_BD_taggertime);
            this.gp_Door.Controls.Add(this.lb_TD_showtime);
            this.gp_Door.Controls.Add(this.lb_SD_showtime);
            this.gp_Door.Controls.Add(this.lb_CD_showtime);
            this.gp_Door.Controls.Add(this.lb_BD_showtime);
            this.gp_Door.Controls.Add(this.lb_TD_mode);
            this.gp_Door.Controls.Add(this.lb_SD_mode);
            this.gp_Door.Controls.Add(this.lb_CD_mode);
            this.gp_Door.Controls.Add(this.lb_BD_mode);
            this.gp_Door.Controls.Add(this.lb_TD_name);
            this.gp_Door.Controls.Add(this.lb_TD_state);
            this.gp_Door.Controls.Add(this.lb_SD_name);
            this.gp_Door.Controls.Add(this.lb_SD_state);
            this.gp_Door.Controls.Add(this.lb_BD_name);
            this.gp_Door.Controls.Add(this.btn_Door_send);
            this.gp_Door.Controls.Add(this.lb_BD_state);
            this.gp_Door.Controls.Add(this.lb_CD_name);
            this.gp_Door.Controls.Add(this.cb_Door_state);
            this.gp_Door.Controls.Add(this.cb_Door_name);
            this.gp_Door.Controls.Add(this.lb_CD_state);
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
            this.lb_TD_name.Location = new System.Drawing.Point(733, 29);
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
            this.lb_TD_state.Location = new System.Drawing.Point(764, 49);
            this.lb_TD_state.Name = "lb_TD_state";
            this.lb_TD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_TD_state.TabIndex = 40;
            this.lb_TD_state.Text = "OFFLINE";
            // 
            // lb_SD_name
            // 
            this.lb_SD_name.AutoSize = true;
            this.lb_SD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SD_name.Location = new System.Drawing.Point(584, 28);
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
            this.lb_SD_state.Location = new System.Drawing.Point(614, 48);
            this.lb_SD_state.Name = "lb_SD_state";
            this.lb_SD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_SD_state.TabIndex = 40;
            this.lb_SD_state.Text = "OFFLINE";
            // 
            // lb_BD_name
            // 
            this.lb_BD_name.AutoSize = true;
            this.lb_BD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BD_name.Location = new System.Drawing.Point(142, 28);
            this.lb_BD_name.Name = "lb_BD_name";
            this.lb_BD_name.Size = new System.Drawing.Size(123, 19);
            this.lb_BD_name.TabIndex = 39;
            this.lb_BD_name.Text = "_______BD_______";
            // 
            // btn_Door_send
            // 
            this.btn_Door_send.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Door_send.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Door_send.Location = new System.Drawing.Point(67, 22);
            this.btn_Door_send.Name = "btn_Door_send";
            this.btn_Door_send.Size = new System.Drawing.Size(56, 23);
            this.btn_Door_send.TabIndex = 41;
            this.btn_Door_send.Text = "전송";
            this.btn_Door_send.UseVisualStyleBackColor = true;
            this.btn_Door_send.Click += new System.EventHandler(this.btn_Door_send_Click);
            // 
            // lb_BD_state
            // 
            this.lb_BD_state.AutoSize = true;
            this.lb_BD_state.BackColor = System.Drawing.Color.Black;
            this.lb_BD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_BD_state.Location = new System.Drawing.Point(172, 48);
            this.lb_BD_state.Name = "lb_BD_state";
            this.lb_BD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_BD_state.TabIndex = 40;
            this.lb_BD_state.Text = "OFFLINE";
            // 
            // lb_CD_name
            // 
            this.lb_CD_name.AutoSize = true;
            this.lb_CD_name.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CD_name.Location = new System.Drawing.Point(434, 28);
            this.lb_CD_name.Name = "lb_CD_name";
            this.lb_CD_name.Size = new System.Drawing.Size(130, 19);
            this.lb_CD_name.TabIndex = 1;
            this.lb_CD_name.Text = "________CD_______";
            // 
            // cb_Door_state
            // 
            this.cb_Door_state.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Door_state.FormattingEnabled = true;
            this.cb_Door_state.Items.AddRange(new object[] {
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)현재상태",
            "(B1)봉쇄 1단계",
            "(B2)봉쇄 2단계",
            "(B3)봉쇄 3단계",
            "(O)장치오픈",
            "(L)도어잠금",
            "(N)나이트 모드",
            "(D)데이 모드",
            "(W)리셋(와치독)",
            "(H)하드모드",
            "(TON)쇼타임 시작",
            "(TOF)쇼타임 끝",
            "(TL_5)술래잠금해제5초",
            "(TL_10)술래잠금해제10초"});
            this.cb_Door_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Door_state.Name = "cb_Door_state";
            this.cb_Door_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Door_state.TabIndex = 40;
            this.cb_Door_state.Text = "(A)장치연결";
            // 
            // cb_Door_name
            // 
            this.cb_Door_name.Font = new System.Drawing.Font("Helvetica75", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Door_name.FormattingEnabled = true;
            this.cb_Door_name.Items.AddRange(new object[] {
            "ALL",
            "BD",
            "CD",
            "SD1",
            "TD"});
            this.cb_Door_name.Location = new System.Drawing.Point(6, 22);
            this.cb_Door_name.Name = "cb_Door_name";
            this.cb_Door_name.Size = new System.Drawing.Size(55, 23);
            this.cb_Door_name.TabIndex = 39;
            this.cb_Door_name.Text = "ALL";
            // 
            // lb_CD_state
            // 
            this.lb_CD_state.AutoSize = true;
            this.lb_CD_state.BackColor = System.Drawing.Color.Black;
            this.lb_CD_state.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CD_state.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CD_state.Location = new System.Drawing.Point(470, 48);
            this.lb_CD_state.Name = "lb_CD_state";
            this.lb_CD_state.Size = new System.Drawing.Size(64, 16);
            this.lb_CD_state.TabIndex = 6;
            this.lb_CD_state.Text = "OFFLINE";
            // 
            // gp_Temple
            // 
            this.gp_Temple.BackColor = System.Drawing.Color.LightGray;
            this.gp_Temple.Controls.Add(this.lb_LT_mode);
            this.gp_Temple.Controls.Add(this.lb_LT_destroy);
            this.gp_Temple.Controls.Add(this.btn_Temple_send);
            this.gp_Temple.Controls.Add(this.lb_LT_name);
            this.gp_Temple.Controls.Add(this.cb_Temple_state);
            this.gp_Temple.Controls.Add(this.cb_Temple_name);
            this.gp_Temple.Controls.Add(this.lb_LT_state);
            this.gp_Temple.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_Temple.Location = new System.Drawing.Point(282, 571);
            this.gp_Temple.Name = "gp_Temple";
            this.gp_Temple.Size = new System.Drawing.Size(428, 80);
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
            this.btn_Temple_send.Click += new System.EventHandler(this.btn_Temple_send_Click);
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
            "(A)장치연결",
            "(R)장치활성화",
            "(S)장치세팅",
            "(C)현재상태",
            "(N)나이트 모드",
            "(D)데이 모드",
            "(B)술래자동결정 대기",
            "(W)리셋(와치독)",
            "(H)하드모드",
            "(D)제단파괴",
            "(F)제단수리"});
            this.cb_Temple_state.Location = new System.Drawing.Point(6, 51);
            this.cb_Temple_state.Name = "cb_Temple_state";
            this.cb_Temple_state.Size = new System.Drawing.Size(117, 23);
            this.cb_Temple_state.TabIndex = 40;
            this.cb_Temple_state.Text = "(A)장치연결";
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
            this.cb_Temple_name.Text = "LT";
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
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_trainroomMode);
            this.gp_ExerciseSys.Controls.Add(this.btn_ExerciseSys_SkipMode);
            this.gp_ExerciseSys.Controls.Add(this.cb_TRM_Temple_autokiller);
            this.gp_ExerciseSys.Controls.Add(this.gb_ExercisSys_iotMode);
            this.gp_ExerciseSys.Controls.Add(this.gp_ExercisSys_iotGroup);
            this.gp_ExerciseSys.Controls.Add(this.label66);
            this.gp_ExerciseSys.Controls.Add(this.label64);
            this.gp_ExerciseSys.Controls.Add(this.lb_logo);
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
            // btn_ExerciseSys_trainroomMode
            // 
            this.btn_ExerciseSys_trainroomMode.BackColor = System.Drawing.Color.Gray;
            this.btn_ExerciseSys_trainroomMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_trainroomMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ExerciseSys_trainroomMode.Location = new System.Drawing.Point(642, 495);
            this.btn_ExerciseSys_trainroomMode.Name = "btn_ExerciseSys_trainroomMode";
            this.btn_ExerciseSys_trainroomMode.Size = new System.Drawing.Size(87, 59);
            this.btn_ExerciseSys_trainroomMode.TabIndex = 97;
            this.btn_ExerciseSys_trainroomMode.Text = "훈련소\r\n모드 설정";
            this.btn_ExerciseSys_trainroomMode.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_trainroomMode.Click += new System.EventHandler(this.btn_ExerciseSys_trainroomMode_Click);
            // 
            // btn_ExerciseSys_SkipMode
            // 
            this.btn_ExerciseSys_SkipMode.BackColor = System.Drawing.Color.Gold;
            this.btn_ExerciseSys_SkipMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_SkipMode.ForeColor = System.Drawing.Color.Black;
            this.btn_ExerciseSys_SkipMode.Location = new System.Drawing.Point(541, 24);
            this.btn_ExerciseSys_SkipMode.Name = "btn_ExerciseSys_SkipMode";
            this.btn_ExerciseSys_SkipMode.Size = new System.Drawing.Size(188, 31);
            this.btn_ExerciseSys_SkipMode.TabIndex = 93;
            this.btn_ExerciseSys_SkipMode.Text = "훈련소 스킵 모드";
            this.btn_ExerciseSys_SkipMode.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_SkipMode.Click += new System.EventHandler(this.btn_ExerciseSys_SkipMode_Click);
            // 
            // cb_TRM_Temple_autokiller
            // 
            this.cb_TRM_Temple_autokiller.AutoSize = true;
            this.cb_TRM_Temple_autokiller.Checked = true;
            this.cb_TRM_Temple_autokiller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TRM_Temple_autokiller.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_TRM_Temple_autokiller.Location = new System.Drawing.Point(530, 494);
            this.cb_TRM_Temple_autokiller.Name = "cb_TRM_Temple_autokiller";
            this.cb_TRM_Temple_autokiller.Size = new System.Drawing.Size(87, 30);
            this.cb_TRM_Temple_autokiller.TabIndex = 92;
            this.cb_TRM_Temple_autokiller.Text = "훈련소 제단 \r\n술래결정";
            this.cb_TRM_Temple_autokiller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_TRM_Temple_autokiller.UseVisualStyleBackColor = true;
            // 
            // gb_ExercisSys_iotMode
            // 
            this.gb_ExercisSys_iotMode.Controls.Add(this.rb_ExercisSys_hardMode);
            this.gb_ExercisSys_iotMode.Controls.Add(this.rb_ExercisSys_easyMode);
            this.gb_ExercisSys_iotMode.Controls.Add(this.rb_ExercisSys_normalMode);
            this.gb_ExercisSys_iotMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ExercisSys_iotMode.Location = new System.Drawing.Point(531, 388);
            this.gb_ExercisSys_iotMode.Name = "gb_ExercisSys_iotMode";
            this.gb_ExercisSys_iotMode.Size = new System.Drawing.Size(106, 101);
            this.gb_ExercisSys_iotMode.TabIndex = 75;
            this.gb_ExercisSys_iotMode.TabStop = false;
            this.gb_ExercisSys_iotMode.Text = "모드설정";
            // 
            // rb_ExercisSys_hardMode
            // 
            this.rb_ExercisSys_hardMode.AutoSize = true;
            this.rb_ExercisSys_hardMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExercisSys_hardMode.Location = new System.Drawing.Point(6, 74);
            this.rb_ExercisSys_hardMode.Name = "rb_ExercisSys_hardMode";
            this.rb_ExercisSys_hardMode.Size = new System.Drawing.Size(96, 20);
            this.rb_ExercisSys_hardMode.TabIndex = 75;
            this.rb_ExercisSys_hardMode.Text = "찌발 MODE";
            this.rb_ExercisSys_hardMode.UseVisualStyleBackColor = true;
            // 
            // rb_ExercisSys_easyMode
            // 
            this.rb_ExercisSys_easyMode.AutoSize = true;
            this.rb_ExercisSys_easyMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExercisSys_easyMode.Location = new System.Drawing.Point(6, 27);
            this.rb_ExercisSys_easyMode.Name = "rb_ExercisSys_easyMode";
            this.rb_ExercisSys_easyMode.Size = new System.Drawing.Size(96, 20);
            this.rb_ExercisSys_easyMode.TabIndex = 72;
            this.rb_ExercisSys_easyMode.Text = "뉴비 MODE";
            this.rb_ExercisSys_easyMode.UseVisualStyleBackColor = true;
            // 
            // rb_ExercisSys_normalMode
            // 
            this.rb_ExercisSys_normalMode.AutoSize = true;
            this.rb_ExercisSys_normalMode.Checked = true;
            this.rb_ExercisSys_normalMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExercisSys_normalMode.Location = new System.Drawing.Point(6, 51);
            this.rb_ExercisSys_normalMode.Name = "rb_ExercisSys_normalMode";
            this.rb_ExercisSys_normalMode.Size = new System.Drawing.Size(96, 20);
            this.rb_ExercisSys_normalMode.TabIndex = 74;
            this.rb_ExercisSys_normalMode.TabStop = true;
            this.rb_ExercisSys_normalMode.Text = "일반 MODE";
            this.rb_ExercisSys_normalMode.UseVisualStyleBackColor = true;
            // 
            // gp_ExercisSys_iotGroup
            // 
            this.gp_ExercisSys_iotGroup.Controls.Add(this.rb_ExerciseSys_iotG1);
            this.gp_ExercisSys_iotGroup.Controls.Add(this.rb_ExerciseSys_iotG3);
            this.gp_ExercisSys_iotGroup.Controls.Add(this.rb_ExerciseSys_iotG2);
            this.gp_ExercisSys_iotGroup.Font = new System.Drawing.Font("타이포_쌍문동 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_ExercisSys_iotGroup.Location = new System.Drawing.Point(643, 388);
            this.gp_ExercisSys_iotGroup.Name = "gp_ExercisSys_iotGroup";
            this.gp_ExercisSys_iotGroup.Size = new System.Drawing.Size(86, 101);
            this.gp_ExercisSys_iotGroup.TabIndex = 73;
            this.gp_ExercisSys_iotGroup.TabStop = false;
            this.gp_ExercisSys_iotGroup.Text = "IOT그룹";
            // 
            // rb_ExerciseSys_iotG1
            // 
            this.rb_ExerciseSys_iotG1.AutoSize = true;
            this.rb_ExerciseSys_iotG1.Checked = true;
            this.rb_ExerciseSys_iotG1.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExerciseSys_iotG1.Location = new System.Drawing.Point(6, 20);
            this.rb_ExerciseSys_iotG1.Name = "rb_ExerciseSys_iotG1";
            this.rb_ExerciseSys_iotG1.Size = new System.Drawing.Size(45, 20);
            this.rb_ExerciseSys_iotG1.TabIndex = 72;
            this.rb_ExerciseSys_iotG1.TabStop = true;
            this.rb_ExerciseSys_iotG1.Text = "G1";
            this.rb_ExerciseSys_iotG1.UseVisualStyleBackColor = true;
            // 
            // rb_ExerciseSys_iotG3
            // 
            this.rb_ExerciseSys_iotG3.AutoSize = true;
            this.rb_ExerciseSys_iotG3.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExerciseSys_iotG3.Location = new System.Drawing.Point(6, 72);
            this.rb_ExerciseSys_iotG3.Name = "rb_ExerciseSys_iotG3";
            this.rb_ExerciseSys_iotG3.Size = new System.Drawing.Size(64, 20);
            this.rb_ExerciseSys_iotG3.TabIndex = 74;
            this.rb_ExerciseSys_iotG3.Text = "테스트";
            this.rb_ExerciseSys_iotG3.UseVisualStyleBackColor = true;
            // 
            // rb_ExerciseSys_iotG2
            // 
            this.rb_ExerciseSys_iotG2.AutoSize = true;
            this.rb_ExerciseSys_iotG2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_ExerciseSys_iotG2.Location = new System.Drawing.Point(6, 46);
            this.rb_ExerciseSys_iotG2.Name = "rb_ExerciseSys_iotG2";
            this.rb_ExerciseSys_iotG2.Size = new System.Drawing.Size(45, 20);
            this.rb_ExerciseSys_iotG2.TabIndex = 73;
            this.rb_ExerciseSys_iotG2.Text = "G2";
            this.rb_ExerciseSys_iotG2.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Location = new System.Drawing.Point(602, 603);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(130, 19);
            this.label66.TabIndex = 66;
            this.label66.Text = "Main Controller v2.0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Location = new System.Drawing.Point(458, 546);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(159, 19);
            this.label64.TabIndex = 64;
            this.label64.Text = "fuzzyline Studio presents";
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Font = new System.Drawing.Font("HelveticaInserat", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(452, 558);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(290, 54);
            this.lb_logo.TabIndex = 65;
            this.lb_logo.Text = "HIDE AND SEEK";
            this.lb_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gp_ExerciseSys_Machine
            // 
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ELW);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ELW_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EC_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EC);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EM_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EM);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ELE_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ELE);
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
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ER_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_ER);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI2_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI1_State);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI2);
            this.gp_ExerciseSys_Machine.Controls.Add(this.lb_ExerciseSys_EI1);
            this.gp_ExerciseSys_Machine.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_ExerciseSys_Machine.Location = new System.Drawing.Point(282, 388);
            this.gp_ExerciseSys_Machine.Name = "gp_ExerciseSys_Machine";
            this.gp_ExerciseSys_Machine.Size = new System.Drawing.Size(243, 155);
            this.gp_ExerciseSys_Machine.TabIndex = 61;
            this.gp_ExerciseSys_Machine.TabStop = false;
            this.gp_ExerciseSys_Machine.Text = "훈련소 장치 (E)";
            // 
            // lb_ExerciseSys_ELW
            // 
            this.lb_ExerciseSys_ELW.AutoSize = true;
            this.lb_ExerciseSys_ELW.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ELW.Location = new System.Drawing.Point(130, 127);
            this.lb_ExerciseSys_ELW.Name = "lb_ExerciseSys_ELW";
            this.lb_ExerciseSys_ELW.Size = new System.Drawing.Size(36, 16);
            this.lb_ExerciseSys_ELW.TabIndex = 23;
            this.lb_ExerciseSys_ELW.Text = "ELW";
            // 
            // lb_ExerciseSys_ELW_State
            // 
            this.lb_ExerciseSys_ELW_State.AutoSize = true;
            this.lb_ExerciseSys_ELW_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ELW_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ELW_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ELW_State.Location = new System.Drawing.Point(174, 127);
            this.lb_ExerciseSys_ELW_State.Name = "lb_ExerciseSys_ELW_State";
            this.lb_ExerciseSys_ELW_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ELW_State.TabIndex = 22;
            this.lb_ExerciseSys_ELW_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EC_State
            // 
            this.lb_ExerciseSys_EC_State.AutoSize = true;
            this.lb_ExerciseSys_EC_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EC_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EC_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EC_State.Location = new System.Drawing.Point(174, 86);
            this.lb_ExerciseSys_EC_State.Name = "lb_ExerciseSys_EC_State";
            this.lb_ExerciseSys_EC_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EC_State.TabIndex = 21;
            this.lb_ExerciseSys_EC_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EC
            // 
            this.lb_ExerciseSys_EC.AutoSize = true;
            this.lb_ExerciseSys_EC.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EC.Location = new System.Drawing.Point(130, 86);
            this.lb_ExerciseSys_EC.Name = "lb_ExerciseSys_EC";
            this.lb_ExerciseSys_EC.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_EC.TabIndex = 20;
            this.lb_ExerciseSys_EC.Text = "EC";
            // 
            // lb_ExerciseSys_EM_State
            // 
            this.lb_ExerciseSys_EM_State.AutoSize = true;
            this.lb_ExerciseSys_EM_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EM_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EM_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EM_State.Location = new System.Drawing.Point(174, 67);
            this.lb_ExerciseSys_EM_State.Name = "lb_ExerciseSys_EM_State";
            this.lb_ExerciseSys_EM_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EM_State.TabIndex = 19;
            this.lb_ExerciseSys_EM_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EM
            // 
            this.lb_ExerciseSys_EM.AutoSize = true;
            this.lb_ExerciseSys_EM.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EM.Location = new System.Drawing.Point(130, 67);
            this.lb_ExerciseSys_EM.Name = "lb_ExerciseSys_EM";
            this.lb_ExerciseSys_EM.Size = new System.Drawing.Size(28, 16);
            this.lb_ExerciseSys_EM.TabIndex = 18;
            this.lb_ExerciseSys_EM.Text = "EM";
            // 
            // lb_ExerciseSys_ELE_State
            // 
            this.lb_ExerciseSys_ELE_State.AutoSize = true;
            this.lb_ExerciseSys_ELE_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ELE_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ELE_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ELE_State.Location = new System.Drawing.Point(174, 106);
            this.lb_ExerciseSys_ELE_State.Name = "lb_ExerciseSys_ELE_State";
            this.lb_ExerciseSys_ELE_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ELE_State.TabIndex = 17;
            this.lb_ExerciseSys_ELE_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ELE
            // 
            this.lb_ExerciseSys_ELE.AutoSize = true;
            this.lb_ExerciseSys_ELE.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ELE.Location = new System.Drawing.Point(130, 106);
            this.lb_ExerciseSys_ELE.Name = "lb_ExerciseSys_ELE";
            this.lb_ExerciseSys_ELE.Size = new System.Drawing.Size(33, 16);
            this.lb_ExerciseSys_ELE.TabIndex = 16;
            this.lb_ExerciseSys_ELE.Text = "ELE";
            // 
            // lb_ExerciseSys_ET_State
            // 
            this.lb_ExerciseSys_ET_State.AutoSize = true;
            this.lb_ExerciseSys_ET_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ET_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ET_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ET_State.Location = new System.Drawing.Point(174, 46);
            this.lb_ExerciseSys_ET_State.Name = "lb_ExerciseSys_ET_State";
            this.lb_ExerciseSys_ET_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ET_State.TabIndex = 15;
            this.lb_ExerciseSys_ET_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ET
            // 
            this.lb_ExerciseSys_ET.AutoSize = true;
            this.lb_ExerciseSys_ET.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ET.Location = new System.Drawing.Point(130, 46);
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
            this.lb_ExerciseSys_EV_State.Location = new System.Drawing.Point(174, 26);
            this.lb_ExerciseSys_EV_State.Name = "lb_ExerciseSys_EV_State";
            this.lb_ExerciseSys_EV_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EV_State.TabIndex = 13;
            this.lb_ExerciseSys_EV_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EV
            // 
            this.lb_ExerciseSys_EV.AutoSize = true;
            this.lb_ExerciseSys_EV.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EV.Location = new System.Drawing.Point(130, 26);
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
            this.lb_ExerciseSys_ED_State.Location = new System.Drawing.Point(49, 127);
            this.lb_ExerciseSys_ED_State.Name = "lb_ExerciseSys_ED_State";
            this.lb_ExerciseSys_ED_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ED_State.TabIndex = 11;
            this.lb_ExerciseSys_ED_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ED
            // 
            this.lb_ExerciseSys_ED.AutoSize = true;
            this.lb_ExerciseSys_ED.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ED.Location = new System.Drawing.Point(6, 127);
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
            this.lb_ExerciseSys_EE_State.Location = new System.Drawing.Point(49, 47);
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
            this.lb_ExerciseSys_EG_State.Location = new System.Drawing.Point(49, 26);
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
            // lb_ExerciseSys_ER_State
            // 
            this.lb_ExerciseSys_ER_State.AutoSize = true;
            this.lb_ExerciseSys_ER_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_ER_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ER_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_ER_State.Location = new System.Drawing.Point(49, 107);
            this.lb_ExerciseSys_ER_State.Name = "lb_ExerciseSys_ER_State";
            this.lb_ExerciseSys_ER_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_ER_State.TabIndex = 5;
            this.lb_ExerciseSys_ER_State.Text = "Offline";
            // 
            // lb_ExerciseSys_ER
            // 
            this.lb_ExerciseSys_ER.AutoSize = true;
            this.lb_ExerciseSys_ER.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_ER.Location = new System.Drawing.Point(6, 106);
            this.lb_ExerciseSys_ER.Name = "lb_ExerciseSys_ER";
            this.lb_ExerciseSys_ER.Size = new System.Drawing.Size(26, 16);
            this.lb_ExerciseSys_ER.TabIndex = 4;
            this.lb_ExerciseSys_ER.Text = "ER";
            // 
            // lb_ExerciseSys_EI2_State
            // 
            this.lb_ExerciseSys_EI2_State.AutoSize = true;
            this.lb_ExerciseSys_EI2_State.BackColor = System.Drawing.Color.Black;
            this.lb_ExerciseSys_EI2_State.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI2_State.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ExerciseSys_EI2_State.Location = new System.Drawing.Point(49, 87);
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
            this.lb_ExerciseSys_EI1_State.Location = new System.Drawing.Point(49, 67);
            this.lb_ExerciseSys_EI1_State.Name = "lb_ExerciseSys_EI1_State";
            this.lb_ExerciseSys_EI1_State.Size = new System.Drawing.Size(55, 16);
            this.lb_ExerciseSys_EI1_State.TabIndex = 2;
            this.lb_ExerciseSys_EI1_State.Text = "Offline";
            // 
            // lb_ExerciseSys_EI2
            // 
            this.lb_ExerciseSys_EI2.AutoSize = true;
            this.lb_ExerciseSys_EI2.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ExerciseSys_EI2.Location = new System.Drawing.Point(6, 86);
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
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.lb_Scenario);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.cb_ExerciseSys_Scenario);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_ScenarioSend);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.button26btn_ExerciseSys_LightOff);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_DeviceSend);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_ExerciseRmOn);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.cb_ExerciseSys_DeivceState);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_funcA);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.cb_ExerciseSys_DeviceName);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_Stop);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_MovingOn);
            this.gp_ExerciseSys_ManualMode.Controls.Add(this.btn_ExerciseSys_WaitRmOff);
            this.gp_ExerciseSys_ManualMode.Font = new System.Drawing.Font("HelveticaInserat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ExerciseSys_ManualMode.Location = new System.Drawing.Point(282, 217);
            this.gp_ExerciseSys_ManualMode.Name = "gp_ExerciseSys_ManualMode";
            this.gp_ExerciseSys_ManualMode.Size = new System.Drawing.Size(447, 165);
            this.gp_ExerciseSys_ManualMode.TabIndex = 60;
            this.gp_ExerciseSys_ManualMode.TabStop = false;
            this.gp_ExerciseSys_ManualMode.Text = "Manual Mode";
            // 
            // lb_Scenario
            // 
            this.lb_Scenario.AutoSize = true;
            this.lb_Scenario.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Scenario.Location = new System.Drawing.Point(290, 110);
            this.lb_Scenario.Name = "lb_Scenario";
            this.lb_Scenario.Size = new System.Drawing.Size(103, 19);
            this.lb_Scenario.TabIndex = 66;
            this.lb_Scenario.Text = "시나리오 스킵";
            // 
            // cb_ExerciseSys_Scenario
            // 
            this.cb_ExerciseSys_Scenario.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ExerciseSys_Scenario.FormattingEnabled = true;
            this.cb_ExerciseSys_Scenario.Items.AddRange(new object[] {
            "생명장치 스킵",
            "아이템박스 스킵",
            "발전기 스킵",
            "도어 잠금 스킵",
            "탈출장치 스킵",
            "덕트 스킵"});
            this.cb_ExerciseSys_Scenario.Location = new System.Drawing.Point(251, 132);
            this.cb_ExerciseSys_Scenario.Name = "cb_ExerciseSys_Scenario";
            this.cb_ExerciseSys_Scenario.Size = new System.Drawing.Size(104, 24);
            this.cb_ExerciseSys_Scenario.TabIndex = 65;
            this.cb_ExerciseSys_Scenario.Text = "NUMBER";
            // 
            // btn_ExerciseSys_ScenarioSend
            // 
            this.btn_ExerciseSys_ScenarioSend.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ScenarioSend.Location = new System.Drawing.Point(363, 132);
            this.btn_ExerciseSys_ScenarioSend.Name = "btn_ExerciseSys_ScenarioSend";
            this.btn_ExerciseSys_ScenarioSend.Size = new System.Drawing.Size(61, 25);
            this.btn_ExerciseSys_ScenarioSend.TabIndex = 64;
            this.btn_ExerciseSys_ScenarioSend.Text = "전송";
            this.btn_ExerciseSys_ScenarioSend.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_ScenarioSend.Click += new System.EventHandler(this.btn_ExerciseSys_ScenarioSend_Click);
            // 
            // button26btn_ExerciseSys_LightOff
            // 
            this.button26btn_ExerciseSys_LightOff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button26btn_ExerciseSys_LightOff.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button26btn_ExerciseSys_LightOff.Location = new System.Drawing.Point(226, 30);
            this.button26btn_ExerciseSys_LightOff.Name = "button26btn_ExerciseSys_LightOff";
            this.button26btn_ExerciseSys_LightOff.Size = new System.Drawing.Size(62, 65);
            this.button26btn_ExerciseSys_LightOff.TabIndex = 58;
            this.button26btn_ExerciseSys_LightOff.Text = "훈련소\r\n조명\r\nOFF";
            this.button26btn_ExerciseSys_LightOff.UseVisualStyleBackColor = false;
            this.button26btn_ExerciseSys_LightOff.Click += new System.EventHandler(this.button26btn_ExerciseSys_LightOff_Click);
            // 
            // btn_ExerciseSys_DeviceSend
            // 
            this.btn_ExerciseSys_DeviceSend.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_DeviceSend.Location = new System.Drawing.Point(184, 101);
            this.btn_ExerciseSys_DeviceSend.Name = "btn_ExerciseSys_DeviceSend";
            this.btn_ExerciseSys_DeviceSend.Size = new System.Drawing.Size(61, 25);
            this.btn_ExerciseSys_DeviceSend.TabIndex = 59;
            this.btn_ExerciseSys_DeviceSend.Text = "전송";
            this.btn_ExerciseSys_DeviceSend.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_DeviceSend.Click += new System.EventHandler(this.btn_ExerciseSys_DeviceSend_Click);
            // 
            // btn_ExerciseSys_ExerciseRmOn
            // 
            this.btn_ExerciseSys_ExerciseRmOn.BackColor = System.Drawing.Color.Khaki;
            this.btn_ExerciseSys_ExerciseRmOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_ExerciseRmOn.Location = new System.Drawing.Point(158, 30);
            this.btn_ExerciseSys_ExerciseRmOn.Name = "btn_ExerciseSys_ExerciseRmOn";
            this.btn_ExerciseSys_ExerciseRmOn.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_ExerciseRmOn.TabIndex = 54;
            this.btn_ExerciseSys_ExerciseRmOn.Text = "훈련소\r\n조명\r\nON";
            this.btn_ExerciseSys_ExerciseRmOn.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_ExerciseRmOn.Click += new System.EventHandler(this.btn_ExerciseSys_ExerciseRmOn_Click);
            // 
            // cb_ExerciseSys_DeivceState
            // 
            this.cb_ExerciseSys_DeivceState.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ExerciseSys_DeivceState.FormattingEnabled = true;
            this.cb_ExerciseSys_DeivceState.Items.AddRange(new object[] {
            "(A) 장치연결",
            "(R) 장치활성화",
            "(S) 장치세팅",
            "(C) 연결상태확인",
            "(B) 봉쇄 활성화",
            "(O) 장치 오픈",
            "(L) 도어 락",
            "(V) 도어 침입시도",
            "(E) 발전기 EL와이어 완료",
            "(F) 발전기 수리 완료",
            "(E) 탈출장치 탈출/태그머신 훈련소모드",
            "(K) 술래 침입 ",
            "(N)나이트모드",
            "(D)데이 모드",
            "(EC)캐비넷 열기",
            "(EC)캐비넷 닫기",
            "(W)장치리셋",
            "(Q)아이템박스 빠른리셋",
            "(I) 도어 침입시도 멈추기",
            "(!) 훈련소 도어 리셋"});
            this.cb_ExerciseSys_DeivceState.Location = new System.Drawing.Point(22, 132);
            this.cb_ExerciseSys_DeivceState.Name = "cb_ExerciseSys_DeivceState";
            this.cb_ExerciseSys_DeivceState.Size = new System.Drawing.Size(223, 24);
            this.cb_ExerciseSys_DeivceState.TabIndex = 63;
            this.cb_ExerciseSys_DeivceState.Text = "장치 행동";
            // 
            // btn_ExerciseSys_funcA
            // 
            this.btn_ExerciseSys_funcA.BackColor = System.Drawing.Color.Khaki;
            this.btn_ExerciseSys_funcA.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_funcA.Location = new System.Drawing.Point(294, 30);
            this.btn_ExerciseSys_funcA.Name = "btn_ExerciseSys_funcA";
            this.btn_ExerciseSys_funcA.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_funcA.TabIndex = 53;
            this.btn_ExerciseSys_funcA.Text = "대기룸\r\n조명\r\nON";
            this.btn_ExerciseSys_funcA.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_funcA.Click += new System.EventHandler(this.btn_ExerciseSys_funcA_Click);
            // 
            // cb_ExerciseSys_DeviceName
            // 
            this.cb_ExerciseSys_DeviceName.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ExerciseSys_DeviceName.FormattingEnabled = true;
            this.cb_ExerciseSys_DeviceName.Items.AddRange(new object[] {
            "ALL",
            "EG ",
            "EE ",
            "EI1",
            "EI2",
            "ER ",
            "ED ",
            "EV ",
            "ET ",
            "EM ",
            "EC"});
            this.cb_ExerciseSys_DeviceName.Location = new System.Drawing.Point(22, 101);
            this.cb_ExerciseSys_DeviceName.Name = "cb_ExerciseSys_DeviceName";
            this.cb_ExerciseSys_DeviceName.Size = new System.Drawing.Size(156, 24);
            this.cb_ExerciseSys_DeviceName.TabIndex = 62;
            this.cb_ExerciseSys_DeviceName.Text = "장치 종류";
            // 
            // btn_ExerciseSys_Stop
            // 
            this.btn_ExerciseSys_Stop.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_Stop.Location = new System.Drawing.Point(22, 30);
            this.btn_ExerciseSys_Stop.Name = "btn_ExerciseSys_Stop";
            this.btn_ExerciseSys_Stop.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_Stop.TabIndex = 52;
            this.btn_ExerciseSys_Stop.Text = "훈련소 리셋";
            this.btn_ExerciseSys_Stop.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_Stop.Click += new System.EventHandler(this.btn_ExerciseSys_Stop_Click);
            // 
            // btn_ExerciseSys_MovingOn
            // 
            this.btn_ExerciseSys_MovingOn.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_MovingOn.Location = new System.Drawing.Point(90, 30);
            this.btn_ExerciseSys_MovingOn.Name = "btn_ExerciseSys_MovingOn";
            this.btn_ExerciseSys_MovingOn.Size = new System.Drawing.Size(62, 65);
            this.btn_ExerciseSys_MovingOn.TabIndex = 51;
            this.btn_ExerciseSys_MovingOn.Text = "아이템\r\n오픈\r\n";
            this.btn_ExerciseSys_MovingOn.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_MovingOn.Click += new System.EventHandler(this.btn_ExerciseSys_MovingOn_Click);
            // 
            // btn_ExerciseSys_WaitRmOff
            // 
            this.btn_ExerciseSys_WaitRmOff.BackColor = System.Drawing.Color.DimGray;
            this.btn_ExerciseSys_WaitRmOff.Font = new System.Drawing.Font("타이포_쌍문동 B", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExerciseSys_WaitRmOff.Location = new System.Drawing.Point(362, 30);
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
            this.btn_ExerciseSys_SetupMode.Location = new System.Drawing.Point(541, 98);
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
            this.btn_ExerciseSys_ReadyMode.Location = new System.Drawing.Point(541, 61);
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
            this.btn_ExerciseSys_Start.Location = new System.Drawing.Point(540, 135);
            this.btn_ExerciseSys_Start.Name = "btn_ExerciseSys_Start";
            this.btn_ExerciseSys_Start.Size = new System.Drawing.Size(189, 76);
            this.btn_ExerciseSys_Start.TabIndex = 53;
            this.btn_ExerciseSys_Start.Text = "훈련소\r\n시작";
            this.btn_ExerciseSys_Start.UseVisualStyleBackColor = false;
            this.btn_ExerciseSys_Start.Click += new System.EventHandler(this.btn_ExerciseSys_Start_Click);
            // 
            // gp_ExerciseSys_timer
            // 
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_Exercise_progress);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_Exercise_progress_name);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_Exercise_device_time);
            this.gp_ExerciseSys_timer.Controls.Add(this.btn_ExerciseSys_timerStop);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_Exercise_trm_time);
            this.gp_ExerciseSys_timer.Controls.Add(this.btn_ExerciseSys_timerStart);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_ExerciseSys_subtime);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_ExerciseSys_maintime);
            this.gp_ExerciseSys_timer.Controls.Add(this.lb_ExerciseSys_Clock);
            this.gp_ExerciseSys_timer.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ExerciseSys_timer.Location = new System.Drawing.Point(281, 25);
            this.gp_ExerciseSys_timer.Name = "gp_ExerciseSys_timer";
            this.gp_ExerciseSys_timer.Size = new System.Drawing.Size(253, 186);
            this.gp_ExerciseSys_timer.TabIndex = 46;
            this.gp_ExerciseSys_timer.TabStop = false;
            this.gp_ExerciseSys_timer.Text = "훈련소 투입 후";
            // 
            // lb_Exercise_progress
            // 
            this.lb_Exercise_progress.AutoSize = true;
            this.lb_Exercise_progress.Location = new System.Drawing.Point(178, 158);
            this.lb_Exercise_progress.Name = "lb_Exercise_progress";
            this.lb_Exercise_progress.Size = new System.Drawing.Size(69, 19);
            this.lb_Exercise_progress.TabIndex = 43;
            this.lb_Exercise_progress.Text = "정비모드";
            // 
            // lb_Exercise_progress_name
            // 
            this.lb_Exercise_progress_name.AutoSize = true;
            this.lb_Exercise_progress_name.Location = new System.Drawing.Point(184, 130);
            this.lb_Exercise_progress_name.Name = "lb_Exercise_progress_name";
            this.lb_Exercise_progress_name.Size = new System.Drawing.Size(54, 19);
            this.lb_Exercise_progress_name.TabIndex = 42;
            this.lb_Exercise_progress_name.Text = "진행률";
            // 
            // lb_Exercise_device_time
            // 
            this.lb_Exercise_device_time.AutoSize = true;
            this.lb_Exercise_device_time.Location = new System.Drawing.Point(83, 130);
            this.lb_Exercise_device_time.Name = "lb_Exercise_device_time";
            this.lb_Exercise_device_time.Size = new System.Drawing.Size(69, 19);
            this.lb_Exercise_device_time.TabIndex = 41;
            this.lb_Exercise_device_time.Text = "인식대기";
            // 
            // btn_ExerciseSys_timerStop
            // 
            this.btn_ExerciseSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExerciseSys_timerStop.Location = new System.Drawing.Point(182, 56);
            this.btn_ExerciseSys_timerStop.Name = "btn_ExerciseSys_timerStop";
            this.btn_ExerciseSys_timerStop.Size = new System.Drawing.Size(65, 25);
            this.btn_ExerciseSys_timerStop.TabIndex = 19;
            this.btn_ExerciseSys_timerStop.Text = "STOP";
            this.btn_ExerciseSys_timerStop.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_timerStop.Click += new System.EventHandler(this.btn_ExerciseSys_timerStop_Click);
            // 
            // lb_Exercise_trm_time
            // 
            this.lb_Exercise_trm_time.AutoSize = true;
            this.lb_Exercise_trm_time.Location = new System.Drawing.Point(8, 130);
            this.lb_Exercise_trm_time.Name = "lb_Exercise_trm_time";
            this.lb_Exercise_trm_time.Size = new System.Drawing.Size(69, 19);
            this.lb_Exercise_trm_time.TabIndex = 40;
            this.lb_Exercise_trm_time.Text = "시나리오";
            // 
            // btn_ExerciseSys_timerStart
            // 
            this.btn_ExerciseSys_timerStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExerciseSys_timerStart.Location = new System.Drawing.Point(182, 25);
            this.btn_ExerciseSys_timerStart.Name = "btn_ExerciseSys_timerStart";
            this.btn_ExerciseSys_timerStart.Size = new System.Drawing.Size(65, 25);
            this.btn_ExerciseSys_timerStart.TabIndex = 20;
            this.btn_ExerciseSys_timerStart.Text = "START";
            this.btn_ExerciseSys_timerStart.UseVisualStyleBackColor = true;
            this.btn_ExerciseSys_timerStart.Click += new System.EventHandler(this.btn_ExerciseSys_timerStart_Click);
            // 
            // lb_ExerciseSys_subtime
            // 
            this.lb_ExerciseSys_subtime.AutoSize = true;
            this.lb_ExerciseSys_subtime.Font = new System.Drawing.Font("HelveticaInserat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExerciseSys_subtime.Location = new System.Drawing.Point(82, 149);
            this.lb_ExerciseSys_subtime.Name = "lb_ExerciseSys_subtime";
            this.lb_ExerciseSys_subtime.Size = new System.Drawing.Size(74, 34);
            this.lb_ExerciseSys_subtime.TabIndex = 39;
            this.lb_ExerciseSys_subtime.Text = "00:00";
            this.lb_ExerciseSys_subtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ExerciseSys_maintime
            // 
            this.lb_ExerciseSys_maintime.AutoSize = true;
            this.lb_ExerciseSys_maintime.Font = new System.Drawing.Font("HelveticaInserat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExerciseSys_maintime.Location = new System.Drawing.Point(6, 149);
            this.lb_ExerciseSys_maintime.Name = "lb_ExerciseSys_maintime";
            this.lb_ExerciseSys_maintime.Size = new System.Drawing.Size(74, 34);
            this.lb_ExerciseSys_maintime.TabIndex = 38;
            this.lb_ExerciseSys_maintime.Text = "00:00";
            this.lb_ExerciseSys_maintime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ExerciseSys_Clock
            // 
            this.lb_ExerciseSys_Clock.AutoSize = true;
            this.lb_ExerciseSys_Clock.BackColor = System.Drawing.Color.Transparent;
            this.lb_ExerciseSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExerciseSys_Clock.Location = new System.Drawing.Point(-6, 22);
            this.lb_ExerciseSys_Clock.Name = "lb_ExerciseSys_Clock";
            this.lb_ExerciseSys_Clock.Size = new System.Drawing.Size(200, 90);
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
            this.gp_IotSys.Controls.Add(this.gp_IotSys_iotGroup);
            this.gp_IotSys.Controls.Add(this.gp_IotSys_ManualMode);
            this.gp_IotSys.Controls.Add(this.lb_programmedbyBBangJun);
            this.gp_IotSys.Controls.Add(this.gp_IotSys_timer);
            this.gp_IotSys.Controls.Add(this.tc_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.cb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.lb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.tb_serialPort_IOT);
            this.gp_IotSys.Controls.Add(this.btn_serialPort_IOT_conn);
            this.gp_IotSys.Controls.Add(this.btn_serialPort_IOT_disconn);
            this.gp_IotSys.Font = new System.Drawing.Font("HelveticaInserat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_IotSys.Location = new System.Drawing.Point(1172, 12);
            this.gp_IotSys.Name = "gp_IotSys";
            this.gp_IotSys.Size = new System.Drawing.Size(735, 373);
            this.gp_IotSys.TabIndex = 4;
            this.gp_IotSys.TabStop = false;
            this.gp_IotSys.Text = "IOT GLOVE SYSTEM";
            // 
            // gp_IotSys_iotGroup
            // 
            this.gp_IotSys_iotGroup.Controls.Add(this.rb_iotSys_iotG1);
            this.gp_IotSys_iotGroup.Controls.Add(this.rb_iotSys_iotG2);
            this.gp_IotSys_iotGroup.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_IotSys_iotGroup.Location = new System.Drawing.Point(284, 254);
            this.gp_IotSys_iotGroup.Name = "gp_IotSys_iotGroup";
            this.gp_IotSys_iotGroup.Size = new System.Drawing.Size(114, 57);
            this.gp_IotSys_iotGroup.TabIndex = 74;
            this.gp_IotSys_iotGroup.TabStop = false;
            this.gp_IotSys_iotGroup.Text = "IOT 그룹";
            // 
            // rb_iotSys_iotG1
            // 
            this.rb_iotSys_iotG1.AutoSize = true;
            this.rb_iotSys_iotG1.Checked = true;
            this.rb_iotSys_iotG1.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_iotSys_iotG1.Location = new System.Drawing.Point(6, 28);
            this.rb_iotSys_iotG1.Name = "rb_iotSys_iotG1";
            this.rb_iotSys_iotG1.Size = new System.Drawing.Size(49, 23);
            this.rb_iotSys_iotG1.TabIndex = 72;
            this.rb_iotSys_iotG1.TabStop = true;
            this.rb_iotSys_iotG1.Text = "G1";
            this.rb_iotSys_iotG1.UseVisualStyleBackColor = true;
            // 
            // rb_iotSys_iotG2
            // 
            this.rb_iotSys_iotG2.AutoSize = true;
            this.rb_iotSys_iotG2.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_iotSys_iotG2.Location = new System.Drawing.Point(61, 27);
            this.rb_iotSys_iotG2.Name = "rb_iotSys_iotG2";
            this.rb_iotSys_iotG2.Size = new System.Drawing.Size(49, 23);
            this.rb_iotSys_iotG2.TabIndex = 73;
            this.rb_iotSys_iotG2.Text = "G2";
            this.rb_iotSys_iotG2.UseVisualStyleBackColor = true;
            // 
            // gp_IotSys_ManualMode
            // 
            this.gp_IotSys_ManualMode.Controls.Add(this.cb_IOTTemple_autokiller);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTnightmode);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTdaymode);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTreset);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTtagON);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTVibeOFF);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTVibeON);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IotTest);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_TagSel);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_IOTVibeTest);
            this.gp_IotSys_ManualMode.Controls.Add(this.btn_TagReSel);
            this.gp_IotSys_ManualMode.Font = new System.Drawing.Font("타이포_쌍문동 B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gp_IotSys_ManualMode.Location = new System.Drawing.Point(404, 254);
            this.gp_IotSys_ManualMode.Name = "gp_IotSys_ManualMode";
            this.gp_IotSys_ManualMode.Size = new System.Drawing.Size(322, 110);
            this.gp_IotSys_ManualMode.TabIndex = 68;
            this.gp_IotSys_ManualMode.TabStop = false;
            this.gp_IotSys_ManualMode.Text = "Manual Mode";
            // 
            // cb_IOTTemple_autokiller
            // 
            this.cb_IOTTemple_autokiller.AutoSize = true;
            this.cb_IOTTemple_autokiller.Checked = true;
            this.cb_IOTTemple_autokiller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_IOTTemple_autokiller.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_IOTTemple_autokiller.Location = new System.Drawing.Point(241, 30);
            this.cb_IOTTemple_autokiller.Name = "cb_IOTTemple_autokiller";
            this.cb_IOTTemple_autokiller.Size = new System.Drawing.Size(70, 30);
            this.cb_IOTTemple_autokiller.TabIndex = 92;
            this.cb_IOTTemple_autokiller.Text = "제단\r\n술래결정";
            this.cb_IOTTemple_autokiller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IOTTemple_autokiller.UseVisualStyleBackColor = true;
            // 
            // btn_IOTnightmode
            // 
            this.btn_IOTnightmode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTnightmode.Location = new System.Drawing.Point(212, 69);
            this.btn_IOTnightmode.Name = "btn_IOTnightmode";
            this.btn_IOTnightmode.Size = new System.Drawing.Size(50, 35);
            this.btn_IOTnightmode.TabIndex = 21;
            this.btn_IOTnightmode.Text = "IOT\r\n나이트";
            this.btn_IOTnightmode.UseVisualStyleBackColor = true;
            this.btn_IOTnightmode.Click += new System.EventHandler(this.btn_IOTnightmode_Click);
            // 
            // btn_IOTdaymode
            // 
            this.btn_IOTdaymode.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTdaymode.Location = new System.Drawing.Point(266, 69);
            this.btn_IOTdaymode.Name = "btn_IOTdaymode";
            this.btn_IOTdaymode.Size = new System.Drawing.Size(50, 35);
            this.btn_IOTdaymode.TabIndex = 20;
            this.btn_IOTdaymode.Text = "IOT\r\n데이";
            this.btn_IOTdaymode.UseVisualStyleBackColor = true;
            this.btn_IOTdaymode.Click += new System.EventHandler(this.btn_IOTdaymode_Click);
            // 
            // btn_IOTreset
            // 
            this.btn_IOTreset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_IOTreset.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTreset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_IOTreset.Location = new System.Drawing.Point(184, 27);
            this.btn_IOTreset.Name = "btn_IOTreset";
            this.btn_IOTreset.Size = new System.Drawing.Size(50, 35);
            this.btn_IOTreset.TabIndex = 19;
            this.btn_IOTreset.Text = "IOT\r\n리셋";
            this.btn_IOTreset.UseVisualStyleBackColor = false;
            this.btn_IOTreset.Click += new System.EventHandler(this.btn_IOTreset_Click);
            // 
            // btn_IOTtagON
            // 
            this.btn_IOTtagON.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTtagON.Location = new System.Drawing.Point(65, 69);
            this.btn_IOTtagON.Name = "btn_IOTtagON";
            this.btn_IOTtagON.Size = new System.Drawing.Size(45, 35);
            this.btn_IOTtagON.TabIndex = 18;
            this.btn_IOTtagON.Text = "술래 ON";
            this.btn_IOTtagON.UseVisualStyleBackColor = true;
            this.btn_IOTtagON.Click += new System.EventHandler(this.btn_IOTtagON_Click);
            // 
            // btn_IOTVibeOFF
            // 
            this.btn_IOTVibeOFF.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTVibeOFF.Location = new System.Drawing.Point(163, 69);
            this.btn_IOTVibeOFF.Name = "btn_IOTVibeOFF";
            this.btn_IOTVibeOFF.Size = new System.Drawing.Size(45, 35);
            this.btn_IOTVibeOFF.TabIndex = 17;
            this.btn_IOTVibeOFF.Text = "진동 OFF";
            this.btn_IOTVibeOFF.UseVisualStyleBackColor = true;
            this.btn_IOTVibeOFF.Click += new System.EventHandler(this.btn_IOTVibeOFF_Click);
            // 
            // btn_IOTVibeON
            // 
            this.btn_IOTVibeON.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTVibeON.Location = new System.Drawing.Point(114, 69);
            this.btn_IOTVibeON.Name = "btn_IOTVibeON";
            this.btn_IOTVibeON.Size = new System.Drawing.Size(45, 35);
            this.btn_IOTVibeON.TabIndex = 16;
            this.btn_IOTVibeON.Text = "진동\r\nON";
            this.btn_IOTVibeON.UseVisualStyleBackColor = true;
            this.btn_IOTVibeON.Click += new System.EventHandler(this.btn_IOTVibeON_Click);
            // 
            // btn_IotTest
            // 
            this.btn_IotTest.BackColor = System.Drawing.Color.Gold;
            this.btn_IotTest.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IotTest.ForeColor = System.Drawing.Color.Black;
            this.btn_IotTest.Location = new System.Drawing.Point(6, 28);
            this.btn_IotTest.Name = "btn_IotTest";
            this.btn_IotTest.Size = new System.Drawing.Size(55, 35);
            this.btn_IotTest.TabIndex = 12;
            this.btn_IotTest.Text = "IOT\r\n테스트";
            this.btn_IotTest.UseVisualStyleBackColor = false;
            this.btn_IotTest.Click += new System.EventHandler(this.btn_IotTest_Click);
            // 
            // btn_TagSel
            // 
            this.btn_TagSel.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TagSel.Location = new System.Drawing.Point(65, 28);
            this.btn_TagSel.Name = "btn_TagSel";
            this.btn_TagSel.Size = new System.Drawing.Size(60, 35);
            this.btn_TagSel.TabIndex = 13;
            this.btn_TagSel.Text = "술래결정 (3분)";
            this.btn_TagSel.UseVisualStyleBackColor = true;
            this.btn_TagSel.Click += new System.EventHandler(this.btn_TagSel_Click);
            // 
            // btn_IOTVibeTest
            // 
            this.btn_IOTVibeTest.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IOTVibeTest.Location = new System.Drawing.Point(6, 69);
            this.btn_IOTVibeTest.Name = "btn_IOTVibeTest";
            this.btn_IOTVibeTest.Size = new System.Drawing.Size(55, 35);
            this.btn_IOTVibeTest.TabIndex = 14;
            this.btn_IOTVibeTest.Text = "진동 TEST";
            this.btn_IOTVibeTest.UseVisualStyleBackColor = true;
            this.btn_IOTVibeTest.Click += new System.EventHandler(this.btn_IOTVibeTest_Click);
            // 
            // btn_TagReSel
            // 
            this.btn_TagReSel.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TagReSel.Location = new System.Drawing.Point(129, 28);
            this.btn_TagReSel.Name = "btn_TagReSel";
            this.btn_TagReSel.Size = new System.Drawing.Size(50, 35);
            this.btn_TagReSel.TabIndex = 15;
            this.btn_TagReSel.Text = "술래\r\n재결정 ";
            this.btn_TagReSel.UseVisualStyleBackColor = true;
            this.btn_TagReSel.Click += new System.EventHandler(this.btn_TagReSel_Click);
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
            this.gp_IotSys_timer.Controls.Add(this.btn_IotSys_timerReset);
            this.gp_IotSys_timer.Controls.Add(this.btn_IotSys_timerStart);
            this.gp_IotSys_timer.Controls.Add(this.btn_IotSys_timerStop);
            this.gp_IotSys_timer.Controls.Add(this.lb_IotSys_Clock);
            this.gp_IotSys_timer.Font = new System.Drawing.Font("타이포_쌍문동 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_IotSys_timer.Location = new System.Drawing.Point(282, 114);
            this.gp_IotSys_timer.Name = "gp_IotSys_timer";
            this.gp_IotSys_timer.Size = new System.Drawing.Size(211, 138);
            this.gp_IotSys_timer.TabIndex = 19;
            this.gp_IotSys_timer.TabStop = false;
            this.gp_IotSys_timer.Text = "술래결정까지";
            // 
            // btn_IotSys_timerReset
            // 
            this.btn_IotSys_timerReset.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IotSys_timerReset.Location = new System.Drawing.Point(146, 103);
            this.btn_IotSys_timerReset.Name = "btn_IotSys_timerReset";
            this.btn_IotSys_timerReset.Size = new System.Drawing.Size(59, 25);
            this.btn_IotSys_timerReset.TabIndex = 19;
            this.btn_IotSys_timerReset.Text = "RESET";
            this.btn_IotSys_timerReset.UseVisualStyleBackColor = true;
            this.btn_IotSys_timerReset.Click += new System.EventHandler(this.btn_IotSys_timerReset_Click);
            // 
            // btn_IotSys_timerStart
            // 
            this.btn_IotSys_timerStart.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IotSys_timerStart.Location = new System.Drawing.Point(6, 103);
            this.btn_IotSys_timerStart.Name = "btn_IotSys_timerStart";
            this.btn_IotSys_timerStart.Size = new System.Drawing.Size(59, 25);
            this.btn_IotSys_timerStart.TabIndex = 18;
            this.btn_IotSys_timerStart.Text = "START";
            this.btn_IotSys_timerStart.UseVisualStyleBackColor = true;
            this.btn_IotSys_timerStart.Click += new System.EventHandler(this.btn_IotSys_timerStart_Click);
            // 
            // btn_IotSys_timerStop
            // 
            this.btn_IotSys_timerStop.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IotSys_timerStop.Location = new System.Drawing.Point(77, 103);
            this.btn_IotSys_timerStop.Name = "btn_IotSys_timerStop";
            this.btn_IotSys_timerStop.Size = new System.Drawing.Size(59, 25);
            this.btn_IotSys_timerStop.TabIndex = 17;
            this.btn_IotSys_timerStop.Text = "STOP";
            this.btn_IotSys_timerStop.UseVisualStyleBackColor = true;
            this.btn_IotSys_timerStop.Click += new System.EventHandler(this.btn_IotSys_timerStop_Click);
            // 
            // lb_IotSys_Clock
            // 
            this.lb_IotSys_Clock.AutoSize = true;
            this.lb_IotSys_Clock.BackColor = System.Drawing.Color.Transparent;
            this.lb_IotSys_Clock.Font = new System.Drawing.Font("HelveticaInserat", 66.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IotSys_Clock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_IotSys_Clock.Location = new System.Drawing.Point(3, 6);
            this.lb_IotSys_Clock.Name = "lb_IotSys_Clock";
            this.lb_IotSys_Clock.Size = new System.Drawing.Size(204, 110);
            this.lb_IotSys_Clock.TabIndex = 16;
            this.lb_IotSys_Clock.Text = "3:00";
            this.lb_IotSys_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lb_G1P4_state.Location = new System.Drawing.Point(165, 82);
            this.lb_G1P4_state.Name = "lb_G1P4_state";
            this.lb_G1P4_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G1P4_state.TabIndex = 11;
            this.lb_G1P4_state.Text = "Offline";
            // 
            // lb_G1P3_state
            // 
            this.lb_G1P3_state.AutoSize = true;
            this.lb_G1P3_state.Location = new System.Drawing.Point(165, 57);
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
            this.tp_G2.Controls.Add(this.lb_G2P9_state);
            this.tp_G2.Controls.Add(this.lb_G2P7_state);
            this.tp_G2.Controls.Add(this.lb_G2P6_state);
            this.tp_G2.Controls.Add(this.lb_G2P5_state);
            this.tp_G2.Controls.Add(this.lb_G2P4_state);
            this.tp_G2.Controls.Add(this.lb_G2P3_state);
            this.tp_G2.Controls.Add(this.lb_G2P2_state);
            this.tp_G2.Controls.Add(this.lb_G2P1_state);
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
            // lb_G2P9_state
            // 
            this.lb_G2P9_state.AutoSize = true;
            this.lb_G2P9_state.Location = new System.Drawing.Point(165, 183);
            this.lb_G2P9_state.Name = "lb_G2P9_state";
            this.lb_G2P9_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P9_state.TabIndex = 23;
            this.lb_G2P9_state.Text = "Offline";
            // 
            // lb_G2P7_state
            // 
            this.lb_G2P7_state.AutoSize = true;
            this.lb_G2P7_state.Location = new System.Drawing.Point(165, 158);
            this.lb_G2P7_state.Name = "lb_G2P7_state";
            this.lb_G2P7_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P7_state.TabIndex = 22;
            this.lb_G2P7_state.Text = "Offline";
            // 
            // lb_G2P6_state
            // 
            this.lb_G2P6_state.AutoSize = true;
            this.lb_G2P6_state.Location = new System.Drawing.Point(165, 133);
            this.lb_G2P6_state.Name = "lb_G2P6_state";
            this.lb_G2P6_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P6_state.TabIndex = 21;
            this.lb_G2P6_state.Text = "Offline";
            // 
            // lb_G2P5_state
            // 
            this.lb_G2P5_state.AutoSize = true;
            this.lb_G2P5_state.Location = new System.Drawing.Point(165, 108);
            this.lb_G2P5_state.Name = "lb_G2P5_state";
            this.lb_G2P5_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P5_state.TabIndex = 20;
            this.lb_G2P5_state.Text = "Offline";
            // 
            // lb_G2P4_state
            // 
            this.lb_G2P4_state.AutoSize = true;
            this.lb_G2P4_state.Location = new System.Drawing.Point(165, 82);
            this.lb_G2P4_state.Name = "lb_G2P4_state";
            this.lb_G2P4_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P4_state.TabIndex = 19;
            this.lb_G2P4_state.Text = "Offline";
            // 
            // lb_G2P3_state
            // 
            this.lb_G2P3_state.AutoSize = true;
            this.lb_G2P3_state.Location = new System.Drawing.Point(165, 57);
            this.lb_G2P3_state.Name = "lb_G2P3_state";
            this.lb_G2P3_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P3_state.TabIndex = 18;
            this.lb_G2P3_state.Text = "Offline";
            // 
            // lb_G2P2_state
            // 
            this.lb_G2P2_state.AutoSize = true;
            this.lb_G2P2_state.Location = new System.Drawing.Point(165, 33);
            this.lb_G2P2_state.Name = "lb_G2P2_state";
            this.lb_G2P2_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P2_state.TabIndex = 17;
            this.lb_G2P2_state.Text = "Offline";
            // 
            // lb_G2P1_state
            // 
            this.lb_G2P1_state.AutoSize = true;
            this.lb_G2P1_state.Location = new System.Drawing.Point(165, 8);
            this.lb_G2P1_state.Name = "lb_G2P1_state";
            this.lb_G2P1_state.Size = new System.Drawing.Size(51, 14);
            this.lb_G2P1_state.TabIndex = 16;
            this.lb_G2P1_state.Text = "Offline";
            // 
            // rb_G2P8
            // 
            this.rb_G2P8.AutoSize = true;
            this.rb_G2P8.Font = new System.Drawing.Font("타이포_쌍문동 B", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_G2P8.Location = new System.Drawing.Point(6, 181);
            this.rb_G2P8.Name = "rb_G2P8";
            this.rb_G2P8.Size = new System.Drawing.Size(112, 19);
            this.rb_G2P8.TabIndex = 8;
            this.rb_G2P8.Text = "G2_PLAYER8";
            this.rb_G2P8.UseVisualStyleBackColor = true;
            // 
            // rb_G2P1
            // 
            this.rb_G2P1.AutoSize = true;
            this.rb_G2P1.Checked = true;
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
            // serialPort_PCM
            // 
            this.serialPort_PCM.DtrEnable = true;
            // 
            // serialPort_IOT
            // 
            this.serialPort_IOT.DtrEnable = true;
            this.serialPort_IOT.RtsEnable = true;
            // 
            // serialPort_TRM
            // 
            this.serialPort_TRM.DtrEnable = true;
            // 
            // lb_BD_mode
            // 
            this.lb_BD_mode.AutoSize = true;
            this.lb_BD_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_BD_mode.Location = new System.Drawing.Point(244, 3);
            this.lb_BD_mode.Name = "lb_BD_mode";
            this.lb_BD_mode.Size = new System.Drawing.Size(31, 15);
            this.lb_BD_mode.TabIndex = 42;
            this.lb_BD_mode.Text = "일반";
            // 
            // lb_CD_mode
            // 
            this.lb_CD_mode.AutoSize = true;
            this.lb_CD_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CD_mode.Location = new System.Drawing.Point(540, 3);
            this.lb_CD_mode.Name = "lb_CD_mode";
            this.lb_CD_mode.Size = new System.Drawing.Size(31, 15);
            this.lb_CD_mode.TabIndex = 43;
            this.lb_CD_mode.Text = "일반";
            // 
            // lb_SD_mode
            // 
            this.lb_SD_mode.AutoSize = true;
            this.lb_SD_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_SD_mode.Location = new System.Drawing.Point(687, 3);
            this.lb_SD_mode.Name = "lb_SD_mode";
            this.lb_SD_mode.Size = new System.Drawing.Size(31, 15);
            this.lb_SD_mode.TabIndex = 44;
            this.lb_SD_mode.Text = "일반";
            // 
            // lb_TD_mode
            // 
            this.lb_TD_mode.AutoSize = true;
            this.lb_TD_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_TD_mode.Location = new System.Drawing.Point(831, 3);
            this.lb_TD_mode.Name = "lb_TD_mode";
            this.lb_TD_mode.Size = new System.Drawing.Size(31, 15);
            this.lb_TD_mode.TabIndex = 45;
            this.lb_TD_mode.Text = "일반";
            // 
            // lb_BD_showtime
            // 
            this.lb_BD_showtime.AutoSize = true;
            this.lb_BD_showtime.BackColor = System.Drawing.Color.Gold;
            this.lb_BD_showtime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_BD_showtime.ForeColor = System.Drawing.Color.Black;
            this.lb_BD_showtime.Location = new System.Drawing.Point(134, 1);
            this.lb_BD_showtime.Name = "lb_BD_showtime";
            this.lb_BD_showtime.Size = new System.Drawing.Size(43, 15);
            this.lb_BD_showtime.TabIndex = 46;
            this.lb_BD_showtime.Text = "쇼타임";
            this.lb_BD_showtime.Visible = false;
            // 
            // lb_CD_showtime
            // 
            this.lb_CD_showtime.AutoSize = true;
            this.lb_CD_showtime.BackColor = System.Drawing.Color.Gold;
            this.lb_CD_showtime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CD_showtime.ForeColor = System.Drawing.Color.Black;
            this.lb_CD_showtime.Location = new System.Drawing.Point(428, 1);
            this.lb_CD_showtime.Name = "lb_CD_showtime";
            this.lb_CD_showtime.Size = new System.Drawing.Size(43, 15);
            this.lb_CD_showtime.TabIndex = 48;
            this.lb_CD_showtime.Text = "쇼타임";
            this.lb_CD_showtime.Visible = false;
            // 
            // lb_SD_showtime
            // 
            this.lb_SD_showtime.AutoSize = true;
            this.lb_SD_showtime.BackColor = System.Drawing.Color.Gold;
            this.lb_SD_showtime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_SD_showtime.ForeColor = System.Drawing.Color.Black;
            this.lb_SD_showtime.Location = new System.Drawing.Point(576, 2);
            this.lb_SD_showtime.Name = "lb_SD_showtime";
            this.lb_SD_showtime.Size = new System.Drawing.Size(43, 15);
            this.lb_SD_showtime.TabIndex = 49;
            this.lb_SD_showtime.Text = "쇼타임";
            this.lb_SD_showtime.Visible = false;
            // 
            // lb_TD_showtime
            // 
            this.lb_TD_showtime.AutoSize = true;
            this.lb_TD_showtime.BackColor = System.Drawing.Color.Gold;
            this.lb_TD_showtime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_TD_showtime.ForeColor = System.Drawing.Color.Black;
            this.lb_TD_showtime.Location = new System.Drawing.Point(722, 2);
            this.lb_TD_showtime.Name = "lb_TD_showtime";
            this.lb_TD_showtime.Size = new System.Drawing.Size(43, 15);
            this.lb_TD_showtime.TabIndex = 50;
            this.lb_TD_showtime.Text = "쇼타임";
            this.lb_TD_showtime.Visible = false;
            // 
            // lb_BD_taggertime
            // 
            this.lb_BD_taggertime.AutoSize = true;
            this.lb_BD_taggertime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_BD_taggertime.Location = new System.Drawing.Point(250, 65);
            this.lb_BD_taggertime.Name = "lb_BD_taggertime";
            this.lb_BD_taggertime.Size = new System.Drawing.Size(28, 15);
            this.lb_BD_taggertime.TabIndex = 51;
            this.lb_BD_taggertime.Text = "7초";
            // 
            // lb_CD_taggertime
            // 
            this.lb_CD_taggertime.AutoSize = true;
            this.lb_CD_taggertime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CD_taggertime.Location = new System.Drawing.Point(546, 66);
            this.lb_CD_taggertime.Name = "lb_CD_taggertime";
            this.lb_CD_taggertime.Size = new System.Drawing.Size(28, 15);
            this.lb_CD_taggertime.TabIndex = 52;
            this.lb_CD_taggertime.Text = "7초";
            // 
            // lb_SD_taggertime
            // 
            this.lb_SD_taggertime.AutoSize = true;
            this.lb_SD_taggertime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_SD_taggertime.Location = new System.Drawing.Point(693, 66);
            this.lb_SD_taggertime.Name = "lb_SD_taggertime";
            this.lb_SD_taggertime.Size = new System.Drawing.Size(28, 15);
            this.lb_SD_taggertime.TabIndex = 53;
            this.lb_SD_taggertime.Text = "7초";
            // 
            // lb_TD_taggertime
            // 
            this.lb_TD_taggertime.AutoSize = true;
            this.lb_TD_taggertime.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_TD_taggertime.Location = new System.Drawing.Point(838, 66);
            this.lb_TD_taggertime.Name = "lb_TD_taggertime";
            this.lb_TD_taggertime.Size = new System.Drawing.Size(28, 15);
            this.lb_TD_taggertime.TabIndex = 54;
            this.lb_TD_taggertime.Text = "7초";
            // 
            // lb_LT_destroy
            // 
            this.lb_LT_destroy.AutoSize = true;
            this.lb_LT_destroy.BackColor = System.Drawing.Color.Gold;
            this.lb_LT_destroy.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LT_destroy.ForeColor = System.Drawing.Color.Black;
            this.lb_LT_destroy.Location = new System.Drawing.Point(281, 1);
            this.lb_LT_destroy.Name = "lb_LT_destroy";
            this.lb_LT_destroy.Size = new System.Drawing.Size(55, 15);
            this.lb_LT_destroy.TabIndex = 55;
            this.lb_LT_destroy.Text = "제단파괴";
            this.lb_LT_destroy.Visible = false;
            // 
            // lb_LT_mode
            // 
            this.lb_LT_mode.AutoSize = true;
            this.lb_LT_mode.Font = new System.Drawing.Font("타이포_쌍문동 B", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LT_mode.Location = new System.Drawing.Point(396, 0);
            this.lb_LT_mode.Name = "lb_LT_mode";
            this.lb_LT_mode.Size = new System.Drawing.Size(31, 15);
            this.lb_LT_mode.TabIndex = 55;
            this.lb_LT_mode.Text = "일반";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1919, 1041);
            this.Controls.Add(this.gp_ExerciseSys);
            this.Controls.Add(this.gp_IotSys);
            this.Controls.Add(this.gp_GameSys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainControl";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.gp_GameSys.ResumeLayout(false);
            this.gp_GameSys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gp_IotSys_Animation.ResumeLayout(false);
            this.lb_hard_duct_cooltime.ResumeLayout(false);
            this.tp_easymode.ResumeLayout(false);
            this.tc_easy_device.ResumeLayout(false);
            this.tp_easy_generator.ResumeLayout(false);
            this.tp_easy_generator.PerformLayout();
            this.tp_easy_Escape.ResumeLayout(false);
            this.tp_easy_Escape.PerformLayout();
            this.tp_easy_itembox.ResumeLayout(false);
            this.tp_easy_itembox.PerformLayout();
            this.tp_easy_gamedoor.ResumeLayout(false);
            this.tp_easy_gamedoor.PerformLayout();
            this.tp_easy_duct.ResumeLayout(false);
            this.tp_easy_duct.PerformLayout();
            this.tp_normalmode.ResumeLayout(false);
            this.tc_normal_device.ResumeLayout(false);
            this.tp_normal_generator.ResumeLayout(false);
            this.tp_normal_generator.PerformLayout();
            this.tp_normal_escape.ResumeLayout(false);
            this.tp_normal_escape.PerformLayout();
            this.tp_normal_itembox.ResumeLayout(false);
            this.tp_normal_itembox.PerformLayout();
            this.tp_normal_door.ResumeLayout(false);
            this.tp_normal_door.PerformLayout();
            this.tp_normal_duct.ResumeLayout(false);
            this.tp_normal_duct.PerformLayout();
            this.tp_hardmode.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_hard_generator.ResumeLayout(false);
            this.tp_hard_generator.PerformLayout();
            this.tp_hard_escape.ResumeLayout(false);
            this.tp_hard_escape.PerformLayout();
            this.tp_hard_itembox.ResumeLayout(false);
            this.tp_hard_itembox.PerformLayout();
            this.tp_hard_door.ResumeLayout(false);
            this.tp_hard_door.PerformLayout();
            this.tp_hard_duct.ResumeLayout(false);
            this.tp_hard_duct.PerformLayout();
            this.gp_IotSys_waitingroom.ResumeLayout(false);
            this.gp_IotSys_waitingroom.PerformLayout();
            this.gp_light_setup.ResumeLayout(false);
            this.gp_light_setup.PerformLayout();
            this.gb_revive_rnd.ResumeLayout(false);
            this.gb_revive_rnd.PerformLayout();
            this.gb_BlockTree.ResumeLayout(false);
            this.gb_BlockTree.PerformLayout();
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
            this.gb_ExercisSys_iotMode.ResumeLayout(false);
            this.gb_ExercisSys_iotMode.PerformLayout();
            this.gp_ExercisSys_iotGroup.ResumeLayout(false);
            this.gp_ExercisSys_iotGroup.PerformLayout();
            this.gp_ExerciseSys_Machine.ResumeLayout(false);
            this.gp_ExerciseSys_Machine.PerformLayout();
            this.gp_ExerciseSys_ManualMode.ResumeLayout(false);
            this.gp_ExerciseSys_ManualMode.PerformLayout();
            this.gp_ExerciseSys_timer.ResumeLayout(false);
            this.gp_ExerciseSys_timer.PerformLayout();
            this.gp_IotSys.ResumeLayout(false);
            this.gp_IotSys.PerformLayout();
            this.gp_IotSys_iotGroup.ResumeLayout(false);
            this.gp_IotSys_iotGroup.PerformLayout();
            this.gp_IotSys_ManualMode.ResumeLayout(false);
            this.gp_IotSys_ManualMode.PerformLayout();
            this.gp_IotSys_timer.ResumeLayout(false);
            this.gp_IotSys_timer.PerformLayout();
            this.tc_serialPort_IOT.ResumeLayout(false);
            this.tp_G1.ResumeLayout(false);
            this.tp_G1.PerformLayout();
            this.tp_G2.ResumeLayout(false);
            this.tp_G2.PerformLayout();
            this.tp_G3.ResumeLayout(false);
            this.tp_G3.PerformLayout();
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
        private System.Windows.Forms.Button btn_IOTVibeTest;
        private System.Windows.Forms.Button btn_TagSel;
        private System.Windows.Forms.Button btn_IotTest;
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
        private System.Windows.Forms.Label lb_BD_name;
        private System.Windows.Forms.Button btn_Door_send;
        private System.Windows.Forms.Label lb_BD_state;
        private System.Windows.Forms.Label lb_CD_name;
        private System.Windows.Forms.ComboBox cb_Door_state;
        private System.Windows.Forms.ComboBox cb_Door_name;
        private System.Windows.Forms.Label lb_CD_state;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gp_GameSys_time;
        private System.Windows.Forms.Button btn_GameSys_timerStop;
        private System.Windows.Forms.Button btn_GameSys_timerStart;
        private System.Windows.Forms.Button btn_GameSys_1min_add;
        private System.Windows.Forms.Button btn_GameSys_5min_add;
        private System.Windows.Forms.GroupBox gp_ModeSetup;
        private System.Windows.Forms.RadioButton rb_GameSys_NormalMode;
        private System.Windows.Forms.RadioButton rb_GameSys_EasyMode;
        private System.Windows.Forms.Button btn_GameSys_GameStart;
        private System.Windows.Forms.GroupBox gp_GameSys_Progress;
        private System.Windows.Forms.Label lb_GameSys_CollectedTemple_cnt;
        private System.Windows.Forms.Label lb_GameSys_SelfReviveTime;
        private System.Windows.Forms.Label lb_GameSys_FixedGenerator_cnt;
        private System.Windows.Forms.Label lb_GameSys_UsedRevive_cnt;
        private System.Windows.Forms.Label lb_GameSys_OpenItembox_cnt;
        private System.Windows.Forms.Label lb_GameSys_CollectedTemple;
        private System.Windows.Forms.Label lb_GameSys_SelfRevive;
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
        private System.Windows.Forms.Button btn_GameSys_OSReset;
        private System.Windows.Forms.Button btn_GameSys_SelfRevive;
        private System.Windows.Forms.Button btn_GameSys_OS_Start;
        private System.Windows.Forms.Button btn_GameSys_GameStop;
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
        private System.Windows.Forms.GroupBox gp_ExerciseSys_ManualMode;
        private System.Windows.Forms.Button button26btn_ExerciseSys_LightOff;
        private System.Windows.Forms.Button btn_ExerciseSys_ExerciseRmOn;
        private System.Windows.Forms.Button btn_ExerciseSys_funcA;
        private System.Windows.Forms.Button btn_ExerciseSys_Stop;
        private System.Windows.Forms.Button btn_ExerciseSys_MovingOn;
        private System.Windows.Forms.Button btn_ExerciseSys_WaitRmOff;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Button btn_ExerciseSys_DeviceSend;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_DeivceState;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_DeviceName;
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
        private System.Windows.Forms.Label lb_ExerciseSys_ER_State;
        private System.Windows.Forms.Label lb_ExerciseSys_ER;
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
        private System.IO.Ports.SerialPort serialPort_PCM;
        private System.IO.Ports.SerialPort serialPort_IOT;
        private System.IO.Ports.SerialPort serialPort_TRM;
        private System.Windows.Forms.GroupBox gb_BlockTree;
        private System.Windows.Forms.Label lb_block_4;
        private System.Windows.Forms.Label lb_block_15min;
        private System.Windows.Forms.Label lb_block_3;
        private System.Windows.Forms.Label lb_block_2;
        private System.Windows.Forms.Label lb_block_5;
        private System.Windows.Forms.Label lb_block_1;
        private System.Windows.Forms.Label lb_block_20min;
        private System.Windows.Forms.Label lb_block_25min;
        private System.Windows.Forms.Label lb_block_10min;
        private System.Windows.Forms.Label lb_block_30min;
        private System.Windows.Forms.GroupBox gb_revive_rnd;
        private System.Windows.Forms.Label lb_revive_5;
        private System.Windows.Forms.Label lb_revive_23min;
        private System.Windows.Forms.Label lb_revive_4;
        private System.Windows.Forms.Label lb_revive_3;
        private System.Windows.Forms.Label lb_revive_6;
        private System.Windows.Forms.Label lb_revive_0;
        private System.Windows.Forms.Label lb_revive_26min;
        private System.Windows.Forms.Label lb_revive_29min;
        private System.Windows.Forms.Label lb_revive_20min;
        private System.Windows.Forms.Label lb_revive_32min;
        private System.Windows.Forms.Label lb_ExerciseSys_ELW_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EC_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EC;
        private System.Windows.Forms.Label lb_ExerciseSys_EM_State;
        private System.Windows.Forms.Label lb_ExerciseSys_EM;
        private System.Windows.Forms.Label lb_ExerciseSys_ELE_State;
        private System.Windows.Forms.Label lb_ExerciseSys_ELE;
        private System.Windows.Forms.ComboBox cb_ExerciseSys_Scenario;
        private System.Windows.Forms.Button btn_ExerciseSys_ScenarioSend;
        private System.Windows.Forms.Label lb_Scenario;
        private System.Windows.Forms.Label lb_ExerciseSys_ELW;
        private System.Windows.Forms.Label lb_ExerciseSys_subtime;
        private System.Windows.Forms.Label lb_ExerciseSys_maintime;
        private System.Windows.Forms.Label lb_ExerciseSys_EP;
        private System.Windows.Forms.Label lb_ExerciseSys_EP_State;
        private System.Windows.Forms.Button btn_ExerciseSys_VideoStop;
        private System.Windows.Forms.Label lb_Exercise_device_time;
        private System.Windows.Forms.Label lb_Exercise_trm_time;
        private System.Windows.Forms.RadioButton rb_ExerciseSys_iotG3;
        private System.Windows.Forms.GroupBox gp_IotSys_Animation;
        private System.Windows.Forms.GroupBox gp_ExercisSys_iotGroup;
        private System.Windows.Forms.RadioButton rb_ExerciseSys_iotG1;
        private System.Windows.Forms.RadioButton rb_ExerciseSys_iotG2;
        private System.Windows.Forms.GroupBox gp_IotSys_iotGroup;
        private System.Windows.Forms.RadioButton rb_iotSys_iotG1;
        private System.Windows.Forms.RadioButton rb_iotSys_iotG2;
        private System.Windows.Forms.TabControl tc_serialPort_IOT;
        private System.Windows.Forms.TabPage tp_G1;
        private System.Windows.Forms.Label lb_G1P8_state;
        private System.Windows.Forms.Label lb_G1P7_state;
        private System.Windows.Forms.Label lb_G1P6_state;
        private System.Windows.Forms.Label lb_G1P5_state;
        private System.Windows.Forms.Label lb_G1P4_state;
        private System.Windows.Forms.Label lb_G1P3_state;
        private System.Windows.Forms.Label lb_G1P2_state;
        private System.Windows.Forms.Label lb_G1P1_state;
        private System.Windows.Forms.RadioButton rb_G1P8;
        private System.Windows.Forms.RadioButton rb_G1P1;
        private System.Windows.Forms.RadioButton rb_G1P7;
        private System.Windows.Forms.RadioButton rb_G1P2;
        private System.Windows.Forms.RadioButton rb_G1P6;
        private System.Windows.Forms.RadioButton rb_G1P3;
        private System.Windows.Forms.RadioButton rb_G1P5;
        private System.Windows.Forms.RadioButton rb_G1P4;
        private System.Windows.Forms.TabPage tp_G2;
        private System.Windows.Forms.Label lb_G2P9_state;
        private System.Windows.Forms.Label lb_G2P7_state;
        private System.Windows.Forms.Label lb_G2P6_state;
        private System.Windows.Forms.Label lb_G2P5_state;
        private System.Windows.Forms.Label lb_G2P4_state;
        private System.Windows.Forms.Label lb_G2P3_state;
        private System.Windows.Forms.Label lb_G2P2_state;
        private System.Windows.Forms.Label lb_G2P1_state;
        private System.Windows.Forms.RadioButton rb_G2P8;
        private System.Windows.Forms.RadioButton rb_G2P1;
        private System.Windows.Forms.RadioButton rb_G2P7;
        private System.Windows.Forms.RadioButton rb_G2P2;
        private System.Windows.Forms.RadioButton rb_G2P6;
        private System.Windows.Forms.RadioButton rb_G2P3;
        private System.Windows.Forms.RadioButton rb_G2P5;
        private System.Windows.Forms.RadioButton rb_G2P4;
        private System.Windows.Forms.TabPage tp_G3;
        private System.Windows.Forms.RadioButton rb_G3P8;
        private System.Windows.Forms.RadioButton rb_G3P1;
        private System.Windows.Forms.RadioButton rb_G3P7;
        private System.Windows.Forms.RadioButton rb_G3P2;
        private System.Windows.Forms.RadioButton rb_G3P6;
        private System.Windows.Forms.RadioButton rb_G3P3;
        private System.Windows.Forms.RadioButton rb_G3P5;
        private System.Windows.Forms.RadioButton rb_G3P4;
        private System.Windows.Forms.Button btn_ExerciseSys_AnimationOn;
        private System.Windows.Forms.Label lb_revive_9;
        private System.Windows.Forms.Label lb_revive_8;
        private System.Windows.Forms.Label lb_revive_1;
        private System.Windows.Forms.Label lb_revive_2;
        private System.Windows.Forms.Label lb_revive_14min;
        private System.Windows.Forms.Label lb_revive_11min;
        private System.Windows.Forms.Label lb_revive_7;
        private System.Windows.Forms.Label lb_revive_17min;
        private System.Windows.Forms.Label lb_ExerciseSys_ES;
        private System.Windows.Forms.Label lb_ExerciseSys_ES_State;
        private System.Windows.Forms.Button btn_ExerciseSys_DoorOpen;
        private System.Windows.Forms.Button btn_ExerciseSys_ScreenDown;
        private System.Windows.Forms.Button btn_ExerciseSys_ScreenUp;
        private System.Windows.Forms.Button btn_ExerciseSys_DoorClose;
        private System.Windows.Forms.Button btn_ExerciseSys_VideoStart;
        private System.Windows.Forms.GroupBox gp_light_setup;
        private System.Windows.Forms.GroupBox gp_IotSys_waitingroom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TL_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_SL_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CL_state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_LL_state;
        private System.Windows.Forms.Label lb_BL_name;
        private System.Windows.Forms.Label lb_BL_state;
        private System.Windows.Forms.Button btn_GameSys_AL_Off;
        private System.Windows.Forms.Button btn_GameSys_AL_ON;
        private System.Windows.Forms.CheckBox cb_iotAUTO;
        private System.Windows.Forms.CheckBox cb_videoAfter_autoStart;
        private System.Windows.Forms.CheckBox cb_selfRevive_auto;
        private System.Windows.Forms.TabControl lb_hard_duct_cooltime;
        private System.Windows.Forms.TabPage tp_easymode;
        private System.Windows.Forms.TabControl tc_easy_device;
        private System.Windows.Forms.TabPage tp_easy_generator;
        private System.Windows.Forms.TabPage tp_easy_Escape;
        private System.Windows.Forms.TabPage tp_easy_itembox;
        private System.Windows.Forms.TabPage tp_easy_gamedoor;
        private System.Windows.Forms.TabPage tp_easy_duct;
        private System.Windows.Forms.TabPage tp_normalmode;
        private System.Windows.Forms.TabControl tc_normal_device;
        private System.Windows.Forms.TabPage tp_normal_generator;
        private System.Windows.Forms.TabPage tp_normal_escape;
        private System.Windows.Forms.TabPage tp_normal_itembox;
        private System.Windows.Forms.TabPage tp_normal_door;
        private System.Windows.Forms.TabPage tp_normal_duct;
        private System.Windows.Forms.TabPage tp_hardmode;
        private System.Windows.Forms.TextBox tb_easy_generator_B3;
        private System.Windows.Forms.TextBox tb_easy_generator_B2;
        private System.Windows.Forms.Label lb_easy_generator_B3;
        private System.Windows.Forms.Label lb_easy_generator_B2;
        private System.Windows.Forms.TextBox tb_easy_generator_B1;
        private System.Windows.Forms.Label lb_easy_generator_B1;
        private System.Windows.Forms.Label lb_easy_generator_starter;
        private System.Windows.Forms.TextBox tb_easy_generator_starter;
        private System.Windows.Forms.Label lb_easy_escape_Btime;
        private System.Windows.Forms.TextBox tb_easy_escape_Btime;
        private System.Windows.Forms.TextBox tb_easy_itembox_vibe4;
        private System.Windows.Forms.TextBox tb_easy_itembox_vibe3;
        private System.Windows.Forms.Label lb_easy_itembox_vibe4;
        private System.Windows.Forms.Label lb_easy_itembox_vibe3;
        private System.Windows.Forms.TextBox tb_easy_itembox_vibe2;
        private System.Windows.Forms.Label lb_easy_itembox_vibe2;
        private System.Windows.Forms.Label lb_easy_itembox_vibe1;
        private System.Windows.Forms.TextBox tb_easy_itembox_vibe1;
        private System.Windows.Forms.TextBox tb_easy_itembox_Btime;
        private System.Windows.Forms.Label lb_easy_itembox_Btime;
        private System.Windows.Forms.TextBox tb_easy_itembox_ansarea;
        private System.Windows.Forms.Label lb_easy_itembox_ansarea;
        private System.Windows.Forms.Label lb_easy_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_easy_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_easy_itembox_ans5;
        private System.Windows.Forms.Label lb_easy_itembox_ans5;
        private System.Windows.Forms.TextBox tb_easy_itembox_ans4;
        private System.Windows.Forms.TextBox tb_easy_itembox_ans3;
        private System.Windows.Forms.Label lb_easy_itembox_ans4;
        private System.Windows.Forms.Label lb_easy_itembox_ans3;
        private System.Windows.Forms.TextBox tb_easy_itembox_ans2;
        private System.Windows.Forms.Label lb_easy_itembox_ans2;
        private System.Windows.Forms.Label lb_easy_itembox_ans1;
        private System.Windows.Forms.TextBox tb_easy_itembox_ans1;
        private System.Windows.Forms.TextBox tb_easy_itembox_vibe5;
        private System.Windows.Forms.Label lb_easy_itembox_vibe5;
        private System.Windows.Forms.Label lb_easy_door_autolock;
        private System.Windows.Forms.TextBox tb_easy_door_autolock;
        private System.Windows.Forms.TextBox tb_easy_vent_cooltime_addup;
        private System.Windows.Forms.Label lb_easy_vent_cooltime_addup;
        private System.Windows.Forms.Label lb_easy_vent_cooltime;
        private System.Windows.Forms.TextBox tb_easy_vent_cooltime;
        private System.Windows.Forms.TextBox tb_normal_generator_B3;
        private System.Windows.Forms.TextBox tb_normal_generator_B2;
        private System.Windows.Forms.Label lb_normal_generator_B3;
        private System.Windows.Forms.Label lb_normal_generator_B2;
        private System.Windows.Forms.TextBox tb_normal_generator_B1;
        private System.Windows.Forms.Label lb_normal_generator_B1;
        private System.Windows.Forms.Label lb_normal_generator_starter;
        private System.Windows.Forms.TextBox tb_normal_generator_starter;
        private System.Windows.Forms.Label lb_normal_escape_Btime;
        private System.Windows.Forms.TextBox tb_normal_escape_Btime;
        private System.Windows.Forms.TextBox tb_normal_itembox_Btime;
        private System.Windows.Forms.Label lb_normal_itembox_Btime;
        private System.Windows.Forms.TextBox tb_normal_itembox_ansarea;
        private System.Windows.Forms.Label lb_normal_itembox_ansarea;
        private System.Windows.Forms.Label lb_normal_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_normal_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_normal_itembox_ans5;
        private System.Windows.Forms.Label lb_normal_itembox_ans5;
        private System.Windows.Forms.TextBox tb_normal_itembox_ans4;
        private System.Windows.Forms.TextBox tb_normal_itembox_ans3;
        private System.Windows.Forms.Label lb_normal_itembox_ans4;
        private System.Windows.Forms.Label lb_normal_itembox_ans3;
        private System.Windows.Forms.TextBox tb_normal_itembox_ans2;
        private System.Windows.Forms.Label lb_normal_itembox_ans2;
        private System.Windows.Forms.Label lb_normal_itembox_ans1;
        private System.Windows.Forms.TextBox tb_normal_itembox_ans1;
        private System.Windows.Forms.TextBox tb_normal_itembox_vibe5;
        private System.Windows.Forms.Label lb_normal_itembox_vibe5;
        private System.Windows.Forms.TextBox tb_normal_itembox_vibe4;
        private System.Windows.Forms.TextBox tb_normal_itembox_vibe3;
        private System.Windows.Forms.Label lb_normal_itembox_vibe4;
        private System.Windows.Forms.Label lb_normal_itembox_vibe3;
        private System.Windows.Forms.TextBox tb_normal_itembox_vibe2;
        private System.Windows.Forms.Label lb_normal_itembox_vibe2;
        private System.Windows.Forms.Label lb_normal_itembox_vibe1;
        private System.Windows.Forms.TextBox tb_normal_itembox_vibe1;
        private System.Windows.Forms.Label lb_noraml_door_autolock;
        private System.Windows.Forms.TextBox tb_noraml_door_autolock;
        private System.Windows.Forms.TextBox tb_normal_vent_cooltime_addup;
        private System.Windows.Forms.Label lb_normal_vent_cooltime_addup;
        private System.Windows.Forms.Label lb_noraml_duct_cooltime;
        private System.Windows.Forms.TextBox tb_normal_vent_cooltime;
        private System.Windows.Forms.RadioButton rb_GameSys_NightMode;
        private System.Windows.Forms.RadioButton rb_GameSys_DayMode;
        private System.Windows.Forms.RadioButton rb_GameSys_HardMode;
        private System.Windows.Forms.Button btn_IotSys_timerReset;
        private System.Windows.Forms.GroupBox gb_ExercisSys_iotMode;
        private System.Windows.Forms.RadioButton rb_ExercisSys_easyMode;
        private System.Windows.Forms.RadioButton rb_ExercisSys_normalMode;
        private System.Windows.Forms.Button btn_GameSys_rndBlock;
        private System.Windows.Forms.Label lb_GameSys_mode;
        private System.Windows.Forms.Button btn_GameSys_currentState;
        private System.Windows.Forms.Button btn_GameSys_ModeSetting;
        private System.Windows.Forms.CheckBox cb_gameModeAuto;
        private System.Windows.Forms.RadioButton rb_GameSys_7P;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_hard_generator;
        private System.Windows.Forms.TextBox tb_hard_generator_B3;
        private System.Windows.Forms.TextBox tb_hard_generator_B2;
        private System.Windows.Forms.Label lb_hard_generator_B3;
        private System.Windows.Forms.Label lb_hard_generator_B2;
        private System.Windows.Forms.TextBox tb_hard_generator_B1;
        private System.Windows.Forms.Label lb_hard_generator_B1;
        private System.Windows.Forms.Label lb_hard_generator_starter;
        private System.Windows.Forms.TextBox tb_hard_generator_starter;
        private System.Windows.Forms.TabPage tp_hard_escape;
        private System.Windows.Forms.Label lb_hard_escape_Btime;
        private System.Windows.Forms.TextBox tb_hard_escape_Btime;
        private System.Windows.Forms.TabPage tp_hard_itembox;
        private System.Windows.Forms.TextBox tb_hard_itembox_Btime;
        private System.Windows.Forms.Label lb_hard_itembox_Btime;
        private System.Windows.Forms.TextBox tb_hard_itembox_ansarea;
        private System.Windows.Forms.Label lb_hard_itembox_ansarea;
        private System.Windows.Forms.Label lb_hard_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_hard_itembox_anscnt;
        private System.Windows.Forms.TextBox tb_hard_itembox_ans5;
        private System.Windows.Forms.Label lb_hard_itembox_ans5;
        private System.Windows.Forms.TextBox tb_hard_itembox_ans4;
        private System.Windows.Forms.TextBox tb_hard_itembox_ans3;
        private System.Windows.Forms.Label lb_hard_itembox_ans4;
        private System.Windows.Forms.Label lb_hard_itembox_ans3;
        private System.Windows.Forms.TextBox tb_hard_itembox_ans2;
        private System.Windows.Forms.Label lb_hard_itembox_ans2;
        private System.Windows.Forms.Label lb_hard_itembox_ans1;
        private System.Windows.Forms.TextBox tb_hard_itembox_ans1;
        private System.Windows.Forms.TextBox tb_hard_itembox_vibe5;
        private System.Windows.Forms.Label lb_hard_itembox_vibe5;
        private System.Windows.Forms.TextBox tb_hard_itembox_vibe4;
        private System.Windows.Forms.TextBox tb_hard_itembox_vibe3;
        private System.Windows.Forms.Label lb_hard_itembox_vibe4;
        private System.Windows.Forms.Label lb_hard_itembox_vibe3;
        private System.Windows.Forms.TextBox tb_hard_itembox_vibe2;
        private System.Windows.Forms.Label lb_hard_itembox_vibe2;
        private System.Windows.Forms.Label lb_hard_itembox_vibe1;
        private System.Windows.Forms.TextBox tb_hard_itembox_vibe1;
        private System.Windows.Forms.TabPage tp_hard_door;
        private System.Windows.Forms.Label lb_hard_door_autolock;
        private System.Windows.Forms.TextBox tb_hard_door_autolock;
        private System.Windows.Forms.TabPage tp_hard_duct;
        private System.Windows.Forms.TextBox tb_hard_vent_cooltime_addup;
        private System.Windows.Forms.Label lb_hard_vent_cooltime_addup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_hard_vent_cooltime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_Temple_autokiller;
        private System.Windows.Forms.Button btn_TaggerSkill_timereset;
        private System.Windows.Forms.Button btn_TaggerSkill_timesubraction;
        private System.Windows.Forms.Button btn_TaggerSkill_timeadd;
        private System.Windows.Forms.Label lb_TaggerSkill_timer;
        private System.Windows.Forms.CheckBox cb_TRM_Temple_autokiller;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_IOTVibeOFF;
        private System.Windows.Forms.Button btn_IOTVibeON;
        private System.Windows.Forms.CheckBox cb_IOTTemple_autokiller;
        private System.Windows.Forms.Button btn_IOTtagON;
        private System.Windows.Forms.Button btn_IOTnightmode;
        private System.Windows.Forms.Button btn_IOTdaymode;
        private System.Windows.Forms.Button btn_IOTreset;
        private System.Windows.Forms.RadioButton rb_ExercisSys_hardMode;
        private System.Windows.Forms.Button btn_GameSys_playPeople;
        private System.Windows.Forms.CheckBox cb_silentStart;
        private System.Windows.Forms.TextBox tb_serialPort_PCM_err;
        private System.Windows.Forms.Button btn_serialPort_PCMerr_clipboardcopy;
        private System.Windows.Forms.Label lb_Exercise_progress;
        private System.Windows.Forms.Label lb_Exercise_progress_name;
        private System.Windows.Forms.Button btn_setting_light;
        private System.Windows.Forms.CheckBox cb_GameSys_deviceLight_auto;
        private System.Windows.Forms.Button btn_ExerciseSys_SkipMode;
        private System.Windows.Forms.Button btn_ExerciseSys_trainroomMode;
        private System.Windows.Forms.Label lb_TD_showtime;
        private System.Windows.Forms.Label lb_SD_showtime;
        private System.Windows.Forms.Label lb_CD_showtime;
        private System.Windows.Forms.Label lb_BD_showtime;
        private System.Windows.Forms.Label lb_TD_mode;
        private System.Windows.Forms.Label lb_SD_mode;
        private System.Windows.Forms.Label lb_CD_mode;
        private System.Windows.Forms.Label lb_BD_mode;
        private System.Windows.Forms.Label lb_TD_taggertime;
        private System.Windows.Forms.Label lb_SD_taggertime;
        private System.Windows.Forms.Label lb_CD_taggertime;
        private System.Windows.Forms.Label lb_BD_taggertime;
        private System.Windows.Forms.Label lb_LT_mode;
        private System.Windows.Forms.Label lb_LT_destroy;
    }
}

