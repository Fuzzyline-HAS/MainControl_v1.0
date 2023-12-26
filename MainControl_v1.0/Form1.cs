using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace MainControl_v1._0
{

    public partial class MainControl : Form
    {
        System.Threading.Timer PCM_ThreadTimer;
        System.Threading.Timer IOT_ThreadTimer;
        System.Threading.Timer TRM_ThreadTimer;
        System.Threading.Timer TRM_DeviceTimer;
        System.Threading.Timer TRM_MainTimer;
        System.Threading.Timer SelfRevive_Timer;
        System.Threading.Timer TaggerSkill_Timer;

        System.Threading.Timer BV1_Timer;
        System.Threading.Timer BV2_Timer;
        System.Threading.Timer LV_Timer;
        System.Threading.Timer CV_Timer;
        System.Threading.Timer SV_Timer;
        System.Threading.Timer TV_Timer;
        System.Threading.Timer ShowTime_Timer;

        delegate void TimerEventFiredDelegate_PCM();
        delegate void TimerEventFiredDelegate_IOT();
        delegate void TimerEventFiredDelegate_TRM();
        delegate void TimerEventFiredDelegate_DEVICE();
        delegate void TimerEventFiredDelegate_TRM_MAIN();
        delegate void TimerEventFiredDelegate_SelfRevive();
        delegate void TimerEventFiredDelegate_TaggerSkill_Timer();

        delegate void TimerEventFireDelelgate_BV1_Timer();
        delegate void TimerEventFireDelelgate_BV2_Timer();
        delegate void TimerEventFireDelelgate_LV_Timer();
        delegate void TimerEventFireDelelgate_CV_Timer();
        delegate void TimerEventFireDelelgate_SV_Timer();
        delegate void TimerEventFireDelelgate_TV_Timer();

        delegate void TimerEventFireDelelgate_ShowTime_Timer();
        DateTime dateTime = DateTime.Now;
        Random rand = new Random();
        bool modeSetting = false;
        int modeSettingCnt = 0;
        int blockdevice_rand1 = 0;  //생명장치 아이템박스 랜덤으로 정해주는 변수
        int blockdevice_rand2 = 0;  //태그머신 발전기 덕트 랜덤으로 정해주는 변수


        public struct machine
        {
            public string deviceName;
            public bool deviceState;
            public machine(string _deviceName, bool _deviceState)
            {
                this.deviceName = _deviceName;
                this.deviceState = _deviceState;
            }
        };
        static machine[] revivalMachine = new machine[10]
        {
            new machine("BR1", false),
            new machine("BR2", false),
            new machine("LR1", false),
            new machine("LR2", false),
            new machine("CR1", false),
            new machine("CR2", false),
            new machine("SR1", false),
            new machine("SR2", false),
            new machine("TR1", false),
            new machine("TR2", false)
        };
        static machine[] generatorMachine = new machine[5]
        {
            new machine("BG", false),
            new machine("LG", false),
            new machine("CG", false),
            new machine("SG", false),
            new machine("TG", false)
        };
        static machine[] escapeMachine = new machine[3]
        {
            new machine("CE", false),
            new machine("SE", false),
            new machine("TE", false),
        };
        //private SerialPort serialPort_PCM = new SerialPort();
        //private SerialPort serialPort_IOT = new SerialPort();
        //private SerialPort serialPort_TRM = new SerialPort();
        public MainControl()
        {
            InitializeComponent();
            PCM_ThreadTimer = new System.Threading.Timer(PCM_timerCallBack);
            IOT_ThreadTimer = new System.Threading.Timer(IOT_timerCallBack);
            TRM_ThreadTimer = new System.Threading.Timer(TRM_timerCallBack);
            TRM_DeviceTimer = new System.Threading.Timer(Device_timerCallBack);
            TRM_MainTimer = new System.Threading.Timer(TRM_MAIN_timerCallBack);
            SelfRevive_Timer = new System.Threading.Timer(SelfRevival_timerCallBack);
            TaggerSkill_Timer = new System.Threading.Timer(TaggerSkill_timerCallBack);
            BV1_Timer = new System.Threading.Timer(BV1_timerCallBack);
            BV2_Timer = new System.Threading.Timer(BV2_timerCallBack);
            LV_Timer = new System.Threading.Timer(LV_timerCallBack);
            CV_Timer = new System.Threading.Timer(CV_timerCallBack);
            SV_Timer = new System.Threading.Timer(SV_timerCallBack);
            TV_Timer = new System.Threading.Timer(TV_timerCallBack);
            ShowTime_Timer = new System.Threading.Timer(ShowTime_timerCallBack);

            PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TRM_MainTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            SelfRevive_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            ShowTime_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }
        private void MainControl_Load(object sender, EventArgs e)
        {
            cb_serialPort_PCM.DataSource = SerialPort.GetPortNames();
            cb_serialPort_IOT.DataSource = SerialPort.GetPortNames();
            cb_serialPort_TRM.DataSource = SerialPort.GetPortNames();
            
        }
        // **************************************************************GAME CONTORL 시리얼 통신 셋팅 부분*******************************************************************************************
        private void PCM_send(string data_input)                                                    //
        {
            if (serialPort_PCM.IsOpen)
            {
                serialPort_PCM.Write(data_input + "\n");                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }
        private void serialPort_PCM_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_PCM));                                    //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_PCM(object s, EventArgs e)                                    //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_temp = serialPort_PCM.ReadLine();   //data_pcm += data_temp;     //원래:ReadExisting 으로 사용햇음    //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            if (data_temp.StartsWith("lb"))
                lb_PCMstring_split(data_temp);
            else
            {
                if ((data_temp.Substring(data_temp.Length - 2)).Contains("\b"))
                {
                    tb_serialPort_PCM.AppendText(data_temp.Substring(0, data_temp.Length - 2));
                }
                else
                {
                    tb_serialPort_PCM.AppendText(data_temp + "\r\n");
                }//텍스트 박스에 시리얼 통신으로 받은 데이터 출력     
            }
        }
        private void lb_PCMstring_split(String PCM_STR)
        {
            String[] pcm_str = PCM_STR.Split('_');
            String lb_name = "";
            lb_name += pcm_str[0];
            lb_name += '_';
            lb_name += pcm_str[1];
            lb_name += "_state";

            String block_name = "lb_";
            block_name += pcm_str[1];       //pcm_str[0] = "lb" , pcm_str[1] = "장치이름(ex.BI1), pcm_str[2] = "장치상태(ex.A)"
            block_name += "_name";

            switch (pcm_str[2][0])
            {
                case 'A': lb_color_change(lb_name, "장치 준비", Color.Red, Color.White);     break;
                case 'B': lb_name_color_change(block_name, Color.Purple, Color.WhiteSmoke); break;
                case 'C':
                    if (pcm_str[2].Contains("CARD")){
                        if (pcm_str[3].Contains('O'))
                        {
                            lb_fogcard.Text = "카드 X";
                        }
                        else if (pcm_str[3].Contains('X'))
                        {
                            lb_fogcard.Text = "카드 O";
                        }
                    }
                    else {
                        lb_color_change(lb_name, "!리셋 필요!", Color.Black, Color.White);
                    } break;
                case 'D':
                    if (pcm_str[1].Contains("AL"))
                    {
                        lb_color_change("lb_BL_state", "DAY 모드", Color.Yellow, Color.Black);
                        lb_color_change("lb_LL_state", "DAY 모드", Color.Yellow, Color.Black);
                        lb_color_change("lb_CL_state", "DAY 모드", Color.Yellow, Color.Black);
                        lb_color_change("lb_SL_state", "DAY 모드", Color.Yellow, Color.Black);
                        lb_color_change("lb_TL_state", "DAY 모드", Color.Yellow, Color.Black);
                    }
                    else if (pcm_str[1].Contains("LT"))
                    {
                        if (rb_GameSys_HardMode.Checked == true)
                        {
                            lb_LT_destroy.Visible = true;
                            PCM_send(("AD _TL_"+ tb_hard_door_taggertime_templedestroy.Text));
                            PCM_send("VO58");
                            PCM_send("VO57");
                        }
                        else if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_LT_destroy.Visible = true;
                            PCM_send(("AD _TL_" + tb_hard_door_taggertime_templedestroy.Text));
                            PCM_send("VO58");
                            PCM_send("VO57");
                        }
                    }
                    else
                        lb_color_change(lb_name, "데이모트", Color.Yellow, Color.White);
                                                                                            break;
                case 'E':
                    if (pcm_str[1].Contains('G')) lb_color_change(lb_name, "배선 수리", Color.Green, Color.WhiteSmoke);
                    else if (pcm_str[1].Contains('E'))
                    {
                        OS_start = false; //게임종료
                        btn_GameSys_GameStart.Text = "GAME\nSTART";
                        btn_GameSys_GameStart.BackColor = Color.Green; btn_GameSys_GameStart.ForeColor = Color.WhiteSmoke;
                        PCM_send("VO25"); PCM_send("AD _S");
                        Radiobutton_PlayGroup("VIBE_OFF");
                        lb_color_change(lb_name, "탈출 성공", Color.Blue, Color.WhiteSmoke);                            //탈출장치 탈출 일때
                        PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);   //timer_GameSys.Enabled = false;                                      //(타이머) 타이머 정지
                        TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //술래스킬 타이머 정지
                        taggerskill_remaing_time = TAGGERSKILL_TIME * 60;                                               //술래스킬 타이머 리셋
                        lb_TaggerSkill_timer.Text = lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");   //술래스킬 타이머 리셋
                        if (cb_iotAUTO.Checked == true)
                            Radiobutton_PlayGroup("LR");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수

                        BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    }
                    else if (pcm_str[1].Contains('F'))
                    {
                        lb_color_change("lb_BF_state", "포그가능", Color.Green, Color.White);
                        
                    }
                    break;
                case 'F':
                    if (pcm_str[1].Contains('G'))
                    {
                        lb_color_change(lb_name, "수리 완료", Color.Blue, Color.White);
                        generatorFixedChk(pcm_str[1]);
                    }
                    else if (pcm_str[1][1] == 'L')
                    {
                        if (pcm_str[1].Contains('A'))
                        {
                            lb_color_change("lb_BL_state", "조명OFF", Color.Gray, Color.White);
                            lb_color_change("lb_LL_state", "조명OFF", Color.Gray, Color.White);
                            lb_color_change("lb_CL_state", "조명OFF", Color.Gray, Color.White);
                            lb_color_change("lb_SL_state", "조명OFF", Color.Gray, Color.White);
                            lb_color_change("lb_TL_state", "조명OFF", Color.Gray, Color.White);

                        }
                        else
                            lb_color_change(lb_name, "조명OFF", Color.Gray, Color.White);
                    }
                    else if (pcm_str[1].Contains("LT"))
                    {
                        if (rb_GameSys_HardMode.Checked == true)
                        {
                            lb_LT_destroy.Visible = false;
                            PCM_send("AD _TL_5");
                            PCM_send("VO59");
                        }
                        else if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_LT_destroy.Visible = false;
                            PCM_send("AD _TL_7");
                            PCM_send("VO59");
                        }
                        
                    }
                    else if (pcm_str[1][1] == 'I')
                    {
                        lb_color_change(lb_name, "해제중", Color.Pink, Color.White);
                    }
                    else if (pcm_str[1].Contains('F'))
                    {
                        if (pcm_str[2].Contains("FL"))
                        {
                            lb_fogtime.Text = "(초)" + pcm_str[3];                        
                        }
                        else
                        {
                            lb_color_change("lb_BF_state", "포그가동", Color.Blue, Color.White);
                        }
                    }
                    break;
                case 'G':
                    if (pcm_str[1].Contains('F'))
                    {
                        lb_color_change("lb_BF_state", "강제포그중", Color.Blue, Color.White);
                    }
                        break;
                case 'H':
                    if (pcm_str[1].Contains('T'))
                    {
                        if(rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_LT_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_LT_mode.Text = "하드";
                        }
                    }
                    if (pcm_str[1].Contains("AD"))
                    {
                        if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_BD_mode.Text = "7/8인";
                            lb_CD_mode.Text = "7/8인";
                            lb_SD_mode.Text = "7/8인";
                            lb_TD_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_BD_mode.Text = "하드";
                            lb_CD_mode.Text = "하드";
                            lb_SD_mode.Text = "하드";
                            lb_TD_mode.Text = "하드";
                        }
                    }
                    else if (pcm_str[1].Contains("BD"))
                    {
                        if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_BD_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_BD_mode.Text = "하드";
                        }
                    }
                    else if (pcm_str[1].Contains("CD"))
                    {
                        if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_CD_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_CD_mode.Text = "하드";
                        }
                    }
                    else if (pcm_str[1].Contains("SD"))
                    {
                        if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_SD_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_SD_mode.Text = "하드";
                        }
                    }
                    else if (pcm_str[1].Contains("TD"))
                    {
                        if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked)
                        {
                            lb_TD_mode.Text = "7/8인";
                        }
                        else
                        {
                            lb_TD_mode.Text = "하드";
                        }
                    }
                    break;
                case 'K':
                    if (pcm_str[1].Contains("I"))
                    {
                        lb_color_change(lb_name, "모이즈스킬", Color.Blue, Color.Black);
                    }break;
                case 'R':
                    if (pcm_str[1].Contains('R'))
                    {
                        lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                        revivalOpenShow(pcm_str[1], lb_name);
                    }
                    else if (pcm_str[1].Contains('V'))
                    {
                        lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                        if (pcm_str[1].Contains("BV1")) BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        else if (pcm_str[1].Contains("BV2")) BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        else if (pcm_str[1].Contains("LV")) LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        else if (pcm_str[1].Contains("CV")) CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        else if (pcm_str[1].Contains("SV")) SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        else if (pcm_str[1].Contains("TV")) TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    }
                    else lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                                                                                            break;
                case 'S':   
                    lb_color_change(lb_name, "장치 세팅", Color.White, Color.Black);
                    lb_name_color_change(block_name, Color.LightGray, Color.Black);
                    if (pcm_str[1].Contains('T'))
                    {
                        lb_LT_mode.Text = "일반";
                        lb_LT_destroy.Visible = false;
                    }
                    else if (pcm_str[1].Contains("AD"))
                    {
                        lb_BD_mode.Text = "일반";
                        lb_CD_mode.Text = "일반";
                        lb_SD_mode.Text = "일반";
                        lb_TD_mode.Text = "일반";
                    }
                    else if (pcm_str[1].Contains("BD"))
                    {
                        lb_BD_mode.Text = "일반";
                        lb_BD_taggertime.Text = "7초";
                        lb_BD_showtime.Visible = false;
                    }
                    else if (pcm_str[1].Contains("CD"))
                    {
                        lb_CD_mode.Text = "일반";
                        lb_CD_taggertime.Text = "7초";
                        lb_CD_showtime.Visible = false;
                    }
                    else if (pcm_str[1].Contains("SD"))
                    {
                        lb_SD_mode.Text = "일반";
                        lb_SD_taggertime.Text = "7초";
                        lb_SD_showtime.Visible = false;
                    }
                    else if (pcm_str[1].Contains("TD"))
                    {
                        lb_TD_mode.Text = "일반";
                        lb_TD_taggertime.Text = "7초";
                        lb_TD_showtime.Visible = false;
                    }
                    break;
                
                
                case 'L':
                    if (pcm_str[1][1] == 'D')
                    {
                        lb_color_change(lb_name, "도어 잠금", Color.Green, Color.White);
                    }
                    else if (pcm_str[1] == "BV1")
                    {
                        lb_color_change(lb_name, "쿨타임:"+pcm_str[3], Color.Green, Color.White);
                        BV1_cooltime = Convert.ToInt32(pcm_str[3]);
                        BV1_Timer.Change(0, 1000);
                    }
                    else if (pcm_str[1] == "BV2")
                    {
                        lb_color_change(lb_name, "쿨타임:" + pcm_str[3], Color.Green, Color.White);
                        BV2_cooltime = Convert.ToInt32(pcm_str[3]);
                        BV2_Timer.Change(0, 1000);
                    }
                    else if (pcm_str[1] == "LV")
                    {
                        lb_color_change(lb_name, "쿨타임:" + pcm_str[3], Color.Green, Color.White);
                        LV_cooltime = Convert.ToInt32(pcm_str[3]);
                        LV_Timer.Change(0, 1000);
                    }
                    else if (pcm_str[1] == "CV")
                    {
                        lb_color_change(lb_name, "쿨타임:" + pcm_str[3], Color.Green, Color.White);
                        CV_cooltime = Convert.ToInt32(pcm_str[3]);
                        CV_Timer.Change(0, 1000);
                    }
                    else if (pcm_str[1] == "SV")
                    {
                        lb_color_change(lb_name, "쿨타임:" + pcm_str[3], Color.Green, Color.White);
                        SV_cooltime = Convert.ToInt32(pcm_str[3]);
                        SV_Timer.Change(0, 1000);
                    }
                    else if (pcm_str[1] == "TV")
                    {
                        lb_color_change(lb_name, "쿨타임:" + pcm_str[3], Color.Green, Color.White);
                        TV_cooltime = Convert.ToInt32(pcm_str[3]);
                        TV_Timer.Change(0, 1000);
                    }
                    break;
                case 'T':
                    if (pcm_str[2].Contains("TL"))
                    {
                        String TLSeconds = "";
                        if(pcm_str[3].Contains("15"))
                            TLSeconds = "15";
                        else if (pcm_str[3].Contains("10"))
                            TLSeconds = "10";
                        else if (pcm_str[3].Contains("12"))
                            TLSeconds = "12";
                        else if (pcm_str[3].Contains("7"))
                            TLSeconds = "7";
                        else if (pcm_str[3].Contains("5"))
                            TLSeconds = "5";
                        else
                            TLSeconds = "x";
                        TLSeconds += "초";
                        if (pcm_str[1].Contains("AD"))
                        {
                            lb_BD_taggertime.Text = TLSeconds;
                            lb_CD_taggertime.Text = TLSeconds;
                            lb_SD_taggertime.Text = TLSeconds;
                            lb_TD_taggertime.Text = TLSeconds;
                        }
                        else if (pcm_str[1].Contains("BD"))
                        {
                            lb_BD_taggertime.Text = TLSeconds;
                        }
                        else if (pcm_str[1].Contains("CD"))
                        {
                            lb_CD_taggertime.Text = TLSeconds;
                        }
                        else if (pcm_str[1].Contains("SD"))
                        {
                            lb_SD_taggertime.Text = TLSeconds;
                        }
                        else if (pcm_str[1].Contains("TD"))
                        {
                            lb_TD_taggertime.Text = TLSeconds;
                        }                       
                    }
                    else if (pcm_str[2].Contains("TON"))
                    {
                        if (pcm_str[1].Contains("AD"))
                        {
                            lb_BD_showtime.Visible = true;
                            lb_CD_showtime.Visible = true;
                            lb_SD_showtime.Visible = true;
                            lb_TD_showtime.Visible = true;
                        }
                        else if (pcm_str[1].Contains("BD"))
                        {
                            lb_BD_showtime.Visible = true;
                        }
                        else if (pcm_str[1].Contains("CD"))
                        {
                            lb_CD_showtime.Visible = true;
                        }
                        else if (pcm_str[1].Contains("SD"))
                        {
                            lb_SD_showtime.Visible = true;
                        }
                        else if (pcm_str[1].Contains("TD"))
                        {
                            lb_TD_showtime.Visible = true;
                        }
                    }
                    else if (pcm_str[2].Contains("TOF")){
                        if (pcm_str[1].Contains("AD"))
                        {
                            lb_BD_showtime.Visible = false;
                            lb_CD_showtime.Visible = false;
                            lb_SD_showtime.Visible = false;
                            lb_TD_showtime.Visible = false;
                        }
                        else if (pcm_str[1].Contains("BD"))
                        {
                            lb_BD_showtime.Visible = false;
                        }
                        else if (pcm_str[1].Contains("CD"))
                        {
                            lb_CD_showtime.Visible = false;
                        }
                        else if (pcm_str[1].Contains("SD"))
                        {
                            lb_SD_showtime.Visible = false;
                        }
                        else if (pcm_str[1].Contains("TD"))
                        {
                            lb_TD_showtime.Visible = false;
                        }
                    }
                    else if (cb_Temple_autokiller.Checked)                                                                   //제단 술래결정일때
                    {
                        if (pcm_str[1][1] == 'T')                                                                      //제단 일때
                        {
                            lb_name_color_change(block_name, Color.LightGray, Color.Black);
                            lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                            PCM_send("VO51");
                            TaggerSkill_Timer.Change(0, 1000);
                            PCM_send("AV _R");
                            PCM_send("AG _R");
                            Radiobutton_PlayGroup("START");
                        }
                        else
                        {
                            lb_color_change(lb_name, "장치 봉쇄", Color.Purple, Color.White);
                            lb_name_color_change(block_name, Color.LightGray, Color.Black);
                        }
                    }
                    else                                                                                                //제단 술래결정아닐때
                    {
                        lb_color_change(lb_name, "장치 봉쇄", Color.Purple, Color.White);
                        lb_name_color_change(block_name, Color.LightGray, Color.Black);
                    }
                    break;
                
                case 'O': lb_color_change(lb_name, "장치 열림", Color.Blue, Color.White);
                    revivalOpenChk(pcm_str[1]); break;
                case 'Q':
                    if (pcm_str[1][1] == 'T')                                                                      //제단활성화 일때
                    {
                        OS_start = false; //게임종료
                        btn_GameSys_GameStart.Text = "GAME\nSTART";
                        btn_GameSys_GameStart.BackColor = Color.Green; btn_GameSys_GameStart.ForeColor = Color.WhiteSmoke;
                        PCM_send("VO13"); PCM_send("AD _S");
                        lb_color_change(lb_name, "제단 활성", Color.Purple, Color.White);
                        Radiobutton_PlayGroup("VIBE_OFF");
                        PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //술래스킬 타이머 정지
                        taggerskill_remaing_time = TAGGERSKILL_TIME * 60;                                               //술래스킬 타이머 리셋
                        lb_TaggerSkill_timer.Text = lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");   //술래스킬 타이머 리셋
                        if (cb_iotAUTO.Checked == true)
                            Radiobutton_PlayGroup("LR");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                        BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        }break;
                    case 'I': 
                    temple_collected_chip = Convert.ToInt32(pcm_str[2][1] - 48); 
                    lb_GameSys_CollectedTemple_cnt.Text = temple_collected_chip.ToString();
                    leftLifeChip();
                    if (rb_GameSys_NightMode.Checked == true)
                        PCM_send("LL _Z");
                    if (selfrevive_cnt == temple_collected_chip)
                    {
                        if (cb_selfRevive_auto.Checked == true)
                            btn_GameSys_SelfRevive.PerformClick();
                        MessageBox.Show((String)"!자가부활모드 확인!");

                    }
                    break;
                case 'N':
                    if (pcm_str[1].Contains("AL"))
                    {
                        lb_color_change("lb_BL_state", "조명ON", Color.Yellow, Color.Black);
                        lb_color_change("lb_LL_state", "조명ON", Color.Yellow, Color.Black);
                        lb_color_change("lb_CL_state", "조명ON", Color.Yellow, Color.Black);
                        lb_color_change("lb_SL_state", "조명ON", Color.Yellow, Color.Black);
                        lb_color_change("lb_TL_state", "조명ON", Color.Yellow, Color.Black);
                    }
                    else if(pcm_str[2].Contains("NFC"))
                    {
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_RFID 오류\r\n");
                    }
                    else
                        lb_color_change(lb_name, "나이트모트", Color.Gray, Color.Black);
                    break;
                case 'U':
                    if (pcm_str[1].Contains('F'))
                    {
                        lb_color_change("lb_Bf_state", "포그완료", Color.Red, Color.White);
                    }
                    break;
                case 'M':
                    if(pcm_str[2].Contains("MP3"))
                    {
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_MP3 오류\r\n");
                    }
                    break;
                    //case 'Z': lb_color_change(lb_name, "BLINK", Color.Purple, Color.White);                                                         break;
                case 'W':
                    tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                    tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_리셋됨\r\n");
                    lb_color_change(lb_name, "리셋됨", Color.Black, Color.White); break;
                case 'X':
                    tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                    tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_지그비 오류\r\n");
                    lb_color_change(lb_name, "OFFLINE", Color.Black, Color.White); break;

            }
        }
        int leftLifeChipCnt = 0;
        private void leftLifeChip()
        {
            if (rb_GameSys_4P.Checked) leftLifeChipCnt = 3;
            else if(rb_GameSys_5P.Checked) leftLifeChipCnt = 4;
            else if (rb_GameSys_6P.Checked) leftLifeChipCnt = 5;
            else if (rb_GameSys_7P.Checked) leftLifeChipCnt = 6;
            else if (rb_GameSys_8P.Checked) leftLifeChipCnt = 7;
            leftLifeChipCnt = leftLifeChipCnt + open_revive_cnt - temple_collected_chip;
            lb_GameSys_leftLifeChip_cnt.Text = leftLifeChipCnt.ToString();
        }
        private void revivalOpenChk(string reviveName)  //생명장치 열렸는지 확인하는 함수 부분
        {
            for (int i = 0; i < 10; i++)
            {
                if (reviveName.Contains(revivalMachine[i].deviceName))
                {
                    if (revivalMachine[i].deviceState == false)
                    {
                        revivalMachine[i].deviceState = true;
                        open_revive_cnt += 1;
                        selfrevive_cnt = headcount + open_revive_cnt;
                        lb_GameSys_UsedRevive_cnt.Text = open_revive_cnt.ToString();
                    }
                }
            }
            leftLifeChip();
        }
        private void revivalOpenShow(string reviveName, string label_name)
        {
            for (int i = 0; i < 10; i++)
            {
                if (reviveName.Contains(revivalMachine[i].deviceName))
                {
                    if (revivalMachine[i].deviceState == true)
                    {
                        lb_color_change(label_name, "장치 열림", Color.Blue, Color.White);
                    }
                }
            }
        }
        private void generatorFixedChk(string reviveName)
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (reviveName.Contains(generatorMachine[i].deviceName))
                {
                    if (generatorMachine[i].deviceState == false)
                    {
                        generatorMachine[i].deviceState = true;
                        fixed_generator_cnt++;
                        lb_GameSys_FixedGenerator_cnt.Text = fixed_generator_cnt.ToString();
                        switch (fixed_generator_cnt)
                        {
                            case 1: PCM_send("VO38"); break;
                            case 2: PCM_send("VO37"); break;
                            case 3: PCM_send("VO22"); PCM_send("VO23");
                                
                                if (cb_CE_except.Checked)
                                {
                                    if(cb_TE_except.Checked)
                                    {
                                        PCM_send("SE _R");
                                    }
                                    else if(cb_SE_except.Checked)
                                    {
                                        PCM_send("TE _R");
                                    }
                                    else
                                    {
                                        PCM_send("TE _R"); PCM_send("SE _R"); //지하실 탈출장치 안되서 화장실 침실 탈출장치 강제 오픈*/
                                    }
                                    
                                }
                                else if (cb_SE_except.Checked)
                                {
                                    if (cb_TE_except.Checked)
                                    {
                                        PCM_send("CE _R");
                                    }
                                    else if (cb_CE_except.Checked)
                                    {
                                        PCM_send("TE _R");
                                    }
                                    else
                                    {
                                        PCM_send("TE _R"); PCM_send("CE _R"); //지하실 탈출장치 안되서 화장실 침실 탈출장치 강제 오픈*/
                                    }

                                }
                                else if (cb_TE_except.Checked)
                                {
                                    if (cb_SE_except.Checked)
                                    {
                                        PCM_send("CE _R");
                                    }
                                    else if (cb_CE_except.Checked)
                                    {
                                        PCM_send("SE _R");
                                    }
                                    else
                                    {
                                        PCM_send("SE _R"); PCM_send("CE _R"); //지하실 탈출장치 안되서 화장실 침실 탈출장치 강제 오픈*/
                                    }

                                }
                                else
                                {
                                    PCM_send("TE _R");
                                    PCM_send(escapeMachine[rand.Next(0, 2)].deviceName + " _R");
                                }
                                break;
                        }
                    }
                }
            }
            if (rb_GameSys_HardMode.Checked == true)
            {
                PCM_send("VO56");
                showtime_remaing_time = Int32.Parse(tb_hard_door_showtime.Text);
                ShowTime_Timer.Change(0, 1000);                                    //timer_IotSys.Enabled = true; //(타이머) iot타이머 시작
                PCM_send("AL _F");
                PCM_send("AD _TON");
                Radiobutton_PlayGroup("STN");
            }
        }
        int BV1_cooltime = 0;
        int BV2_cooltime = 0;
        int LV_cooltime = 0;
        int CV_cooltime = 0;
        int SV_cooltime = 0;
        int TV_cooltime = 0;

        private void BV1_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(BV1_timerWork));
        }
        private void BV1_timerWork()
        {
            BV1_cooltime--;
            if(BV1_cooltime < 2)
            {
                BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_BV1_state.Text = "쿨타임종료";
            }
            else
            {
                lb_BV1_state.Text = "쿨타임" + BV1_cooltime.ToString();
            }
        }
        private void BV2_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(BV2_timerWork));
        }
        private void BV2_timerWork()
        {
            BV2_cooltime--;
            if (BV2_cooltime < 2)
            {
                BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_BV2_state.Text = "쿨타임종료";
            }
            else
            {
                lb_BV2_state.Text = "쿨타임" + BV2_cooltime.ToString();
            }
        }
        private void LV_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(LV_timerWork));
        }
        private void LV_timerWork()
        {
            LV_cooltime--;
            if (LV_cooltime < 2)
            {
                LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_LV_state.Text = "쿨타임종료";
            }
            else
            {
                lb_LV_state.Text = "쿨타임" + LV_cooltime.ToString();
            }
        }
        private void CV_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(CV_timerWork));
        }
        private void CV_timerWork()
        {
            CV_cooltime--;
            if (CV_cooltime < 2)
            {
                CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_CV_state.Text = "쿨타임종료";
            }
            else
            {
                lb_CV_state.Text = "쿨타임" + CV_cooltime.ToString();
            }
        }
        private void SV_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(SV_timerWork));
        }
        private void SV_timerWork()
        {
            SV_cooltime--;
            if (SV_cooltime < 2)
            {
                SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_SV_state.Text = "쿨타임종료";
            }
            else
            {
                lb_SV_state.Text = "쿨타임" + SV_cooltime.ToString();
            }
        }
        private void TV_timerCallBack(object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(TV_timerWork));
        }
        private void TV_timerWork()
        {
            TV_cooltime--;
            if (TV_cooltime < 2)
            {
                TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lb_TV_state.Text = "쿨타임종료";
            }
            else
            {
                lb_TV_state.Text = "쿨타임" + TV_cooltime.ToString();
            }
        }

        private void lb_color_change(String lb_name, String text, Color lb_BackColor, Color lb_FontColor)
        {
            this.Controls.Find(lb_name, true).FirstOrDefault().Text = text;
            this.Controls.Find(lb_name, true).FirstOrDefault().BackColor = lb_BackColor;
            this.Controls.Find(lb_name, true).FirstOrDefault().ForeColor = lb_FontColor;
        }
        private void lb_name_color_change(String lb_name, Color lb_BackColor, Color lb_FontColor)
        {
            this.Controls.Find(lb_name, true).FirstOrDefault().BackColor = lb_BackColor;
            this.Controls.Find(lb_name, true).FirstOrDefault().ForeColor = lb_FontColor;
        }
        private void btn_serialPort_PCM_conn_Click(object sender, EventArgs e)
        {
            if (!serialPort_PCM.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                serialPort_PCM.PortName = cb_serialPort_PCM.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort_PCM.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                serialPort_PCM.DataBits = 8;
                serialPort_PCM.StopBits = StopBits.One;
                serialPort_PCM.Parity = Parity.None;
                serialPort_PCM.DataReceived += new SerialDataReceivedEventHandler(serialPort_PCM_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                serialPort_PCM.Open();                                                              //시리얼포트 열기
                //serialPort_PCM.Write("\n");

                lb_serialPort_PCM.Text = "포트가 열렸습니다.";
                tb_serialPort_PCM.Text = "FuzzyLine Studio presents \r\nHIDE AND SEEK OS v1.0 \r\nprogramed by BBangJun\r\n";
                cb_serialPort_PCM.Enabled = false;                                                  //COM포트설정 콤보박스 비활성화

                tb_serialPort_PCM_err.AppendText("오류 로그\r\n");
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_serialPort_PCM.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void btn_serialPort_PCM_disconn_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)                                                              //시리얼포트가 열려 있으면
            {
                serialPort_PCM.Close();                                                             //시리얼포트 닫기

                lb_serialPort_PCM.Text = "포트가 닫혔습니다.";
                cb_serialPort_PCM.Enabled = true;                                                   //COM포트설정 콤보박스 활성화
            }
            else                                                                                    //시리얼포트가 닫혀 있으면
            {
                lb_serialPort_PCM.Text = "포트가 이미 닫혀 있습니다.";
            }
        }
      
            // **************************************************************GAME CONTORL 시리얼 통신 셋팅 부분*******************************************************************************************
            // **************************************************************IOT CONTORL 시리얼 통신 셋팅 부분 *******************************************************************************************
            private void IOT_send(string data_input)                                                    //
        {
            if (serialPort_IOT.IsOpen)
            {
                serialPort_IOT.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }
        private void serialPort_IOT_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_IOT));                                    //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_IOT(object s, EventArgs e)                                    //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_temp = serialPort_IOT.ReadLine();//원래:ReadExisting 으로 사용햇음          //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            if (data_temp.StartsWith("lb"))
                lb_PCMstring_split(data_temp);
            else if ((data_temp.Substring(data_temp.Length - 2)).Contains("\b"))
            {
                tb_serialPort_IOT.AppendText(data_temp.Substring(0, data_temp.Length - 2));
            }
            else
            {
                tb_serialPort_IOT.AppendText(data_temp + "\r\n");
            }
        }
        private void btn_serialPort_IOT_conn_Click(object sender, EventArgs e)
        {
            if (!serialPort_IOT.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                serialPort_IOT.PortName = cb_serialPort_IOT.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort_IOT.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                serialPort_IOT.DataBits = 8;
                serialPort_IOT.StopBits = StopBits.One;
                serialPort_IOT.Parity = Parity.None;
                serialPort_IOT.DataReceived += new SerialDataReceivedEventHandler(serialPort_IOT_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                serialPort_IOT.Open();                                                              //시리얼포트 열기

                lb_serialPort_IOT.Text = "포트가 열렸습니다.";
                tb_serialPort_IOT.Text = "FuzzyLine Studio presents \r\nHIDE AND SEEK OS v1.0 \r\nprogramed by BBangJun\r\n";
                cb_serialPort_IOT.Enabled = false;                                                  //COM포트설정 콤보박스 비활성화
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_serialPort_IOT.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void btn_serialPort_IOT_disconn_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)                                                              //시리얼포트가 열려 있으면
            {
                serialPort_IOT.Close();                                                             //시리얼포트 닫기

                lb_serialPort_IOT.Text = "포트가 닫혔습니다.";
                cb_serialPort_IOT.Enabled = true;                                                   //COM포트설정 콤보박스 활성화
            }
            else                                                                                    //시리얼포트가 닫혀 있으면
            {
                lb_serialPort_IOT.Text = "포트가 이미 닫혀 있습니다.";
            }
        }
        // **************************************************************IOT CONTORL 시리얼 통신 셋팅 부분 *******************************************************************************************
        // **************************************************************TRM CONTORL 시리얼 통신 셋팅 부분 *******************************************************************************************
        private void TRM_send(string data_input)                                                    //
        {
            if (serialPort_TRM.IsOpen)
            {
                serialPort_TRM.Write(data_input + "\n");                           //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }
        private void serialPort_TRM_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_TRM));                                    //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_TRM(object s, EventArgs e)                                    //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_temp = serialPort_TRM.ReadLine();//원래:ReadExisting 으로 사용햇음    //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            if (data_temp.StartsWith("lb"))
            {
                lb_TRMstring_split(data_temp);
            }
            else if ((data_temp.Substring(data_temp.Length - 2)).Contains("\b"))
            {
                tb_serialPort_TRM.AppendText(data_temp.Substring(0, data_temp.Length - 2));
            }
            else if (data_temp.Contains("waiting show"))
            {
                Radiobutton_PlayGroup("SHOW");
            }
            else if (data_temp.Contains("VIDEO CLOSE"))
            {
                //MessageBox.Show((String)"GAME START 늘러주세요!");
                lb_color_change("lb_ExerciseSys_EP_State", "영상종료", Color.Red, Color.White);
            }
            else if (data_temp.Contains("SCREEN UP"))
            {
                Radiobutton_PlayGroup("LR");
                TRM_send("ES _U");
                lb_color_change("lb_ExerciseSys_ES_State", "스크린UP", Color.Blue, Color.White);

            }
            else if (data_temp.Contains("waiting lightoff"))
            {
                TRM_send("ELW_WOFF");
                
            }
            else
            {
                tb_serialPort_TRM.AppendText(data_temp + "\r\n");
            }
        }
        private void lb_TRMstring_split(String TRM_STR)
        {
            //lb_ExerciseSys_EG_State 꼴로 만들기
            String[] pcm_str = TRM_STR.Split('_');
            String lb_name = "lb_ExerciseSys_"; lb_name += pcm_str[1]; lb_name += "_State";
            String block_name = "lb_ExerciseSys_"; block_name += pcm_str[1];
            switch (pcm_str[2][0])
            {
                case 'A': lb_color_change(lb_name, "장치 연결", Color.Red, Color.White); break;
                case 'C':
                    if (pcm_str[1].Contains("ES"))
                    {
                        lb_color_change(lb_name, "도어 닫힘", Color.Red, Color.White);
                    }
                    else
                    {
                        lb_color_change(lb_name, "!리셋 필요!", Color.Black, Color.White);
                    } break;
                case 'D':
                    if (pcm_str[1].Contains("ES"))
                    {
                        lb_color_change(lb_name, "스크린DOWN", Color.Red, Color.White);
                    }
                    else if (pcm_str[1].Contains("EP"))
                    {
                        lb_color_change(lb_name, "DAY영상재생", Color.Yellow, Color.Black);
                    }
                    else if (pcm_str[1].Contains("ET"))
                    {
                        lb_LT_destroy.Visible = true;
                        //TRM_send(("AD _TL_" + tb_hard_door_taggertime_templedestroy.Text));
                        TRM_send("VO58");
                        TRM_send("VO57");
                    }
                    break;
                case 'R': lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black); break;
                case 'S': lb_color_change(lb_name, "장치 세팅", Color.White, Color.Black);
                    lb_name_color_change(block_name, Color.LightGray, Color.Black); break;
                case 'B': lb_color_change(block_name, pcm_str[1], Color.Purple, Color.LightGray); break;
                case 'F':
                    if (pcm_str[1].Contains("EG"))
                    {
                        lb_color_change(lb_name, "수리 완료", Color.Blue, Color.White);
                        ExerciseRm_status = "Generator Fix";
                    }
                    else if (pcm_str[1].Contains("EI1"))
                    {
                        lb_color_change("lb_ExerciseSys_EI1_State", "해제 중", Color.Pink, Color.White);
                    }
                    else if (pcm_str[1].Contains("EI2"))
                    {
                        lb_color_change("lb_ExerciseSys_EI2_State", "해제 중", Color.Pink, Color.White);
                    }
                    else if (pcm_str[1].Contains("EB"))
                    {
                        btn_setting_light.BackColor = Color.Green;
                        btn_setting_light.Text = "청소등 ON";
                    }
                    else if (pcm_str[1].Contains("ET"))
                    {
                        //lb_LT_destroy.Visible = false;
                        //PCM_send("AD _TL_5");
                        TRM_send("VO59");
                    }
                    break;
                case 'L': 
                    if (pcm_str[1][1] == 'D')
                    {
                        lb_color_change(lb_name, "도어 잠금", Color.Green, Color.White);
                        if (pcm_str[1].Contains("ED"))
                        {
                            ExerciseRm_status = "Door Lock";
                        }
                    }
                    else if (pcm_str[1][1] == 'V')
                    {
                        lb_color_change(lb_name, "쿨:" + pcm_str[3], Color.Green, Color.White);
                    }
                    break;
                case 'T':
                    if (cb_TRM_Temple_autokiller.Checked)
                    {
                        if (pcm_str[1][1] == 'T')                                                                      //제단 일때
                        {
                            lb_name_color_change(block_name, Color.LightGray, Color.Black);
                            lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                            TRM_send("ET _H");
                            TRM_send("VO51");

                        }
                    }
                    else
                    {
                        lb_color_change(lb_name, "장치 봉쇄", Color.Purple, Color.White);
                        lb_color_change(block_name, pcm_str[1], Color.WhiteSmoke, Color.Black);
                    }
                    break;
                case 'E': if (pcm_str[2].Contains("EON")) lb_color_change("lb_ExerciseSys_ELE_State", "E조명ON", Color.Yellow, Color.Black);
                    else if (pcm_str[1].Contains("EG")) lb_color_change("lb_ExerciseSys_EG_State", "배선 수리", Color.Green, Color.White);
                    else if (pcm_str[1].Contains("EE")) ExerciseRm_status = "Escape Open";
                    else if (pcm_str[1].Contains("EP"))
                    {
                        //lb_color_change("lb_ExerciseSys_EI2_State", "해제 중", Color.Pink, Color.White);
                        MessageBox.Show((String)"영상 파일을 새로 시작해 주세요!");
                    }
                    else lb_color_change("lb_ExerciseSys_ELE_State", "E조명OFF", Color.Gray, Color.Black); break;
                
                case 'O':
                    if (pcm_str[1].Contains("ES"))
                    {
                        lb_color_change(lb_name, "도어 열림", Color.Blue, Color.White);
                    }
                    else
                    {
                        lb_color_change(lb_name, "장치 열림", Color.Blue, Color.White);
                        if (pcm_str[1].Contains("ER")) ExerciseRm_status = "Revival Open"; //if(ExerciseRm_status.Contains("Revival Open"))
                        else if (pcm_str[1].Contains("EI1")) ExerciseRm_status = "Itembox1 Open";
                        else if (pcm_str[1].Contains("EI2")) ExerciseRm_status = "Itembox2 Open";
                        else if (pcm_str[1].Contains("EV")) ExerciseRm_status = "Duct Open";
                    } break;
                case 'N':
                    if (pcm_str[1].Contains("EP"))
                    {
                        lb_color_change(lb_name, "나이트영상재생", Color.Gray, Color.White);
                    }
                    else if (pcm_str[1].Contains("EB")) {
                        btn_setting_light.BackColor = Color.Red;
                        btn_setting_light.Text = "청소등 OFF";
                    }
                    else if (pcm_str[2].Contains("NFC"))
                    {
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_RFID 오류\r\n");
                    }
                    break;
                case 'M':
                    if (pcm_str[2].Contains("MP3"))
                    {
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_MP3 오류\r\n");
                    }
                    break;
                case 'Q':
                    if (pcm_str[1].Contains("EP"))
                    {
                        //lb_color_change("lb_ExerciseSys_EI2_State", "해제 중", Color.Pink, Color.White);
                        MessageBox.Show((String)"영상 파일을 새로 시작해 주세요!");
                    }
                    break;
                case 'U':
                    if (pcm_str[1].Contains("ES"))
                    {
                        lb_color_change(lb_name, "스크린UP", Color.Blue, Color.White);
                    }                                                                               break;

                case 'W':
                    if (pcm_str[2].Contains("WON")) lb_color_change("lb_ExerciseSys_ELW_State", "W조명ON", Color.Yellow, Color.Black);
                    else if (pcm_str[2].Contains("WOFF")) lb_color_change("lb_ExerciseSys_ELW_State", "W조명OFF", Color.Gray, Color.Black);
                    else
                    {
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_리셋됨\r\n");
                        lb_color_change(lb_name, "리셋됨", Color.Black, Color.White);
                    }
                        break;
                case 'X':
                    if (pcm_str[1].Contains("EB"))
                    {
                        btn_setting_light.BackColor = Color.Black;
                        btn_setting_light.Text = "청소등 리셋";
                    }
                    else
                    {
                        lb_color_change(lb_name, "OFFLINE", Color.Black, Color.White);
                        tb_serialPort_PCM_err.AppendText(DateTime.Now.ToString("yy.MM.dd hh:mm:ss -> "));
                        tb_serialPort_PCM_err.AppendText(pcm_str[1] + "_지그비 오류\r\n");
                    }
                    break;

            }
        }
        private void btn_serialPort_TRM_conn_Click(object sender, EventArgs e)
        {
            if (!serialPort_TRM.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                serialPort_TRM.PortName = cb_serialPort_TRM.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort_TRM.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                serialPort_TRM.DataBits = 8;
                serialPort_TRM.StopBits = StopBits.One;
                serialPort_TRM.Parity = Parity.None;
                serialPort_TRM.DataReceived += new SerialDataReceivedEventHandler(serialPort_TRM_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                serialPort_TRM.Open();                                                              //시리얼포트 열기

                lb_serialPort_TRM.Text = "포트가 열렸습니다.";
                tb_serialPort_TRM.Text = "FuzzyLine Studio presents \r\nHIDE AND SEEK OS v1.0 \r\nprogramed by BBangJun\r\n";
                cb_serialPort_TRM.Enabled = false;                                                  //COM포트설정 콤보박스 비활성화
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_serialPort_TRM.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void btn_serialPort_TRM_disconn_Click(object sender, EventArgs e)
        {
            if (serialPort_TRM.IsOpen)                                                              //시리얼포트가 열려 있으면
            {
                serialPort_TRM.Close();                                                             //시리얼포트 닫기

                lb_serialPort_TRM.Text = "포트가 닫혔습니다.";
                cb_serialPort_TRM.Enabled = true;                                                   //COM포트설정 콤보박스 활성화
            }
            else                                                                                    //시리얼포트가 닫혀 있으면
            {
                lb_serialPort_TRM.Text = "포트가 이미 닫혀 있습니다.";
            }
        }
        // **************************************************************TRM CONTORL 시리얼 통신 셋팅 부분 *******************************************************************************************
        // **************************************************************       GAME sys MAIN CODE          *******************************************************************************************
        const int GAMETIME = 35;                                                                    //35분;  총 게임시간 저장 변수 
        const int REVIVE_TIME_TERM = 3;                                                             //3분;   부활장치 켜지는 시간 텀 변수
        const int TAGGERSKILL_TIME = 32;
        int game_remaing_time = GAMETIME * 60;                                                           //35*60; 남은시간 전체 초로 카운팅 저장하고 있는 변수
        int selfrevival_remaing_time = 90;
        int taggerskill_remaing_time = TAGGERSKILL_TIME * 60;
        bool OS_start = false;                                                                      //fasle; OS시작했는지 안했는지 확인하는 변수

        int headcount = 5;                                                                         //5;     몇명에서 플레이 하는지 저장하는 변수 기본세팅은 5명
        int playmode = 1;                                                                          //1;     플레이 모드설정 easymode = 0; normalMode = 1; HardMode = 2; 
        int playgroup = 1;                                                                         //1;     플레이 그룹설정 G1 = 1; G2 = 2; G3 = 3; 
        int selfrevive_cnt = 0;                                                                     //0;     자가부활모드 실행위한 제단에 꼽힌 생명칩 개수
        int temple_collected_chip = 0;                                                              //0;     제단에 꼽힌 생명칩 갯수
        int fixed_generator_cnt = 0;                                                                //0;     수리된 발전기의 개수 저장하는 변수
        int open_revive_cnt = 0;                                                                    //0;     열린 생명장치 개수 확인하는 변수
        int revive_rnd = 0;                                                                         //0;     랜덤 부활장치 변수
        int[,] revive_arr = new int[10, 10]{  {1,7,0,5,2,9,6,4,8,3},
                                                {2,1,8,4,7,5,0,3,6,9},
                                                {7,3,8,1,9,2,4,6,5,0},
                                                {9,2,7,3,5,1,8,6,0,4},
                                                {6,4,2,8,1,7,0,3,5,9},
                                                {8,0,5,6,2,9,4,1,3,7},
                                                {6,0,4,3,5,2,7,1,8,9},
                                                {9,7,2,6,5,3,0,4,8,1},
                                                {5,2,9,7,3,8,4,6,1,0},
                                                {3,7,4,5,0,8,1,9,6,2}};
        void SelfRevival_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(SelfRevival_timerWork));
        }
        private void SelfRevival_timerWork()
        {
            selfrevival_remaing_time -= 1;                                                                                                              //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_GameSys_SelfReviveTime.Text = (selfrevival_remaing_time / 60).ToString("0") + ":" + (selfrevival_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            switch (selfrevival_remaing_time)
            {
                case 60: PCM_send("AR _E"); break;
                case 30: PCM_send("AD _R"); PCM_send("VO24"); break;
                case 0: SelfRevive_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        PCM_send("VO61");
                        selfrevival_remaing_time = 90; lb_GameSys_SelfReviveTime.Text = "1:30"; break;

            }
        }
        void PCM_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(PCM_timerWork));
        }
        private void PCM_timerWork()
        {
            game_remaing_time -= 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_GameSys_Clock.Text = (game_remaing_time / 60).ToString("00") + ":" + (game_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            Gamesys_TimeAction();
        }
        private void timer_GameSys_Tick(object sender, EventArgs e)
        {
            game_remaing_time -= 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            string remaing_show = game_remaing_time.ToString("00") + ":" + game_remaing_time.ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            lb_GameSys_Clock.Text = remaing_show;                                                   //남은 시간 출력
            Gamesys_TimeAction();
        }
        void TaggerSkill_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TaggerSkill_Timer(TaggerSkill_timerWork));
        }
        private void TaggerSkill_timerWork()
        {
            taggerskill_remaing_time -= 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            TaggerSkill_TimeAction();
        }


        int showtime_remaing_time;
        void ShowTime_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_PCM(ShowTime_timerWork));
        }
        private void ShowTime_timerWork()
        {
            showtime_remaing_time -= 1;                                                                                                              //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_showtime_counter.Text = (showtime_remaing_time / 60).ToString("0") + ":" + (showtime_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            switch (showtime_remaing_time)
            {
                case 9: PCM_send("VO60"); break;

                case 0:
                    ShowTime_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    PCM_send("AD _TOF");
                    PCM_send("AL _N");
                    selfrevival_remaing_time = Int32.Parse(tb_hard_door_showtime.Text);
                    lb_showtime_counter.Text = (showtime_remaing_time / 60).ToString("0") + ":" + (showtime_remaing_time % 60).ToString("00"); 
                    break;

            }
        }
        private void Gamesys_TimeAction()
        {
            if (OS_start == true)
            {
                if (!(cb_silentStart.Checked))
                {
                    //뉴비 일반 모드일때 초반 나레이션
                    if (rb_GameSys_HardMode.Checked == false)
                    {
                        //처음 게임시작하고 나레이션if문
                        switch (game_remaing_time)
                        {
                            case ((34 * 60) + 59):  PCM_send("VO1"); break;  //34분 59초 일때    //(나레이션) VO1; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((34 * 60) + 52):  PCM_send("VO47"); break;  //34분 52초 일때    //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((34 * 60) + 35):  PCM_send("VO3"); break;  //34분 43초 일때    //(나레이션) VO3; 흩어져서 경계하세요
                            case ((34 * 60) + 30):  TRM_send("ES _C"); break;
                            case ((34 * 60) + 27):  TRM_send("ES _D"); break;
                            case ((33 * 60) + 52):  PCM_send("VO47"); break;  //33분 52초 일때    //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((33 * 60) + 2):   PCM_send("VO3"); break;  //33분 43초 일때    //(나레이션) VO3; 흩어져서 경계하세요
                            case ((32 * 60) + 52):  PCM_send("VO47"); break;  //32분 52초 일때    //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((32 * 60) + 37):  PCM_send("VO3"); break;  //32분 43초 일때    //(나레이션) VO3; 흩어져서 경계하세요
                            case ((32 * 60) + 30):  PCM_send("VO4"); break;  //32분 30초 일때    //(나레이션) VO4; 술래결정까지 30초 남았습니다.
                            case ((32 * 60) + 7):   PCM_send("VO5"); break;   //32분 07초 일때    //(나레이션) VO5; 술래결정까지 5초 남았습니다.
                            case ((32 * 60) + 0):                           //32분 00초 일때    
                                                                if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                                {
                                    PCM_send("VO6");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    //PCM_send("LT _R");
                                }
                                else if (cb_Temple_autokiller.Checked)      //술래 자동결정 일때
                                {
                                    PCM_send("VO48");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    //PCM_send("LT _B");
                                }
                                PCM_send("PG _R");
                                if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                                {
                                    //PCM_send("VO6");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    PCM_send("LT _R");
                                    PCM_send("AG _R");
                                    PCM_send("AV _R");
                                }
                                else if (cb_Temple_autokiller.Checked)      //술래 자동결정 일때
                                {
                                    //PCM_send("VO48");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    PCM_send("LT _B");
                                }
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 0]].deviceName + "_R");
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 1]].deviceName + "_R");
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 2]].deviceName + "_R");
                                
                                break;
                        }
                    }
                    //하드 모드일때 초반 나레이션
                    if (rb_GameSys_HardMode.Checked == true)
                    {
                        switch (game_remaing_time)
                        {
                            case ((34 * 60) + 59): PCM_send("VO54"); PCM_send("VO1"); break;  //34분 59초 일때    //(나레이션) VO1; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((34 * 60) + 52): PCM_send("VO47"); break;  //34분 52초 일때    //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((34 * 60) + 37): TRM_send("ES _C"); break;  //34분 43초 일때    //(나레이션) VO3; 흩어져서 경계하세요
                            case ((34 * 60) + 30): PCM_send("VO55"); PCM_send("VO3"); break;
                            case ((34 * 60) + 20): TRM_send("ES _D"); break;  //34분 59초 일때    //(나레이션) VO1; 술래등장 전 까지는 장치사용이 불가합니다.
                            case ((34 * 60) + 00): PCM_send("VO4"); break;  //32분 30초 일때    //(나레이션) VO4; 술래결정까지 30초 남았습니다.
                            case ((33 * 60) + 37): PCM_send("VO5"); break;   //32분 07초 일때    //(나레이션) VO5; 술래결정까지 5초 남았습니다.
                            case ((33 * 60) + 30):                           //32분 00초 일때    
                                if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                                {
                                    PCM_send("VO6");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    //PCM_send("LT _R");
                                }
                                else if (cb_Temple_autokiller.Checked)      //술래 자동결정 일때
                                {
                                    PCM_send("VO48");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    //PCM_send("LT _B");
                                }
                                PCM_send("PG _R");
                                if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                                {
                                    //PCM_send("VO6");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    PCM_send("LT _R");
                                    PCM_send("AG _R");
                                    PCM_send("AV _R");
                                }
                                else if (cb_Temple_autokiller.Checked)      //술래 자동결정 일때
                                {
                                    //PCM_send("VO48");                        //(나레이션) VO6; 술래가 결정되었습니다. 
                                    PCM_send("LT _B");
                                }
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 0]].deviceName + "_R");
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 1]].deviceName + "_R");
                                PCM_send(revivalMachine[revive_arr[revive_rnd, 2]].deviceName + "_R");
                                PCM_send("BF _R");                          //하드모드일때 포그머신 장치활성화
                                break;
                            case ((10 * 60) + 00): PCM_send("BF _A");break;
                        }
                    }
                    switch (game_remaing_time)
                    {
                        case ((30 * 60) + 0): PCM_send("VN30"); break;  //30분 00초 일때    //(나레이션) 30분 남았습니다.
                        case ((29 * 60) + 0): PCM_send(revivalMachine[revive_arr[revive_rnd, 3]].deviceName + "_R"); PCM_send("VO24"); break;  //29분 00초 일때    //(통신) 생명장치 한개 활성화 
                        case ((27 * 60) + 0):
                            if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                            {
                                switch (blockdevice_rand1)
                                {
                                    case 0: PCM_send("AI _B"); PCM_send("VO31"); break;
                                    case 1: PCM_send("AR _B"); PCM_send("VO32"); break;
                                }
                            }
                            break;  //27분 00초 일떄    //봉쇄 LV.0
                        case ((26 * 60) + 0): PCM_send(revivalMachine[revive_arr[revive_rnd, 4]].deviceName + "_R"); PCM_send("VO24"); break;  //26분 00초 일때    //(통신) 생명장치 한개 활성화 
                        case ((25 * 60) + 0): break;  //25분 00초 일때 
                        case ((23 * 60) + 0): PCM_send(revivalMachine[revive_arr[revive_rnd, 5]].deviceName + "_R"); PCM_send("VO24"); break;  //23분 00초 일때    //(통신) 생명장치 한개 활성화 
                        case ((22 * 60) + 0):
                            if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                            {
                                switch (blockdevice_rand2)
                                {
                                    case 0: PCM_send("AD _B1"); PCM_send("VO36"); break;
                                    case 1: PCM_send("AV _B1"); PCM_send("VO34"); break;
                                    case 2: PCM_send("AG _B1"); PCM_send("VO33"); break;
                                }
                            }
                            break;
                        case ((20 * 60) + 0):
                            //PCM_send("VN20");             //20분 00초 일때    //(나레이션) 20분 남았습니다.
                            PCM_send(revivalMachine[revive_arr[revive_rnd, 6]].deviceName + "_R"); PCM_send("VO24"); break;                       //(통신) 생명장치 한개 활성화 
                        case ((17 * 60) + 0):
                            PCM_send(revivalMachine[revive_arr[revive_rnd, 7]].deviceName + "_R"); PCM_send("VO24");         //17분 00초 일때     //(통신) 생명장치 한개 활성화
                            if (!(cb_Temple_autokiller.Checked))          //술래 자동결정 아닐때
                            {
                                switch (blockdevice_rand2)
                                {
                                    case 0: PCM_send("AD _B2"); PCM_send("VO43"); break;
                                    case 1: PCM_send("AV _B2"); PCM_send("VO45"); break;
                                    case 2: PCM_send("AG _B2"); PCM_send("VO41"); break;
                                }
                            }
                            break;
                        case ((15 * 60) + 0): break;  //15분 00초 일때    //(통신) 술래의 3번째 능력 활성화
                        case ((14 * 60) + 0): PCM_send(revivalMachine[revive_arr[revive_rnd, 8]].deviceName + "_R"); PCM_send("VO24"); break;  //14분 00초 일때    //(통신) 생명장치 한개 활성화
                        case ((12 * 60) + 0):
                            if (!(cb_Temple_autokiller.Checked))
                            {
                                switch (blockdevice_rand2)
                                {
                                    case 0: PCM_send("AD _B3"); PCM_send("VO44"); break;
                                    case 1: PCM_send("AV _B3"); PCM_send("VO46"); break;
                                    case 2: PCM_send("AG _B3"); PCM_send("VO42"); break;
                                }
                            }
                            break;                       //(통신) 봉쇄 LV.3
                        case ((11 * 60) + 0): PCM_send(revivalMachine[revive_arr[revive_rnd, 9]].deviceName + "_R"); PCM_send("VO24"); break;  //11분 00초 일때    //(통신) 생명장치 한개 활성화 
                        case ((10 * 60) + 0): PCM_send("VN10"); break;  //10분 00초 일때    //(나레이션) 10분 남았습니다
                        case ((7 * 60) + 0):
                            if (!(cb_Temple_autokiller.Checked))
                            {
                                PCM_send("AE _B");
                                PCM_send("VO35");
                            }
                            break;
                        case ((3 * 60) + 0): PCM_send("VN3"); break;  //3분 00초 일때     //(나레이션) 3분 남았습니다
                        case ((1 * 60) + 0): PCM_send("VN1"); break;  //1분 00초 일때     //(나레이션) 1분 남았습니다
                        case (0):
                            PCM_send("VO14");                                                               //0분 00초 일때     //(나레이션) 탈출제한 시간이 끝났습니다
                            Radiobutton_PlayGroup("VIBE_OFF");
                            PCM_send("AD _S");
                            OS_start = false;                                                                                   // OS_START BOOL변수 종료
                            btn_GameSys_GameStart.Text = "GAME\nSTART";
                            btn_GameSys_GameStart.BackColor = Color.Green; btn_GameSys_GameStart.ForeColor = Color.WhiteSmoke;

                            PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);       //timer_GameSys.Enabled = false;// 게임 타이머 정지
                            TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //술래스킬 타이머 정지
                            taggerskill_remaing_time = TAGGERSKILL_TIME * 60;                                               //술래스킬 타이머 리셋
                            lb_TaggerSkill_timer.Text = lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");   //술래스킬 타이머 리셋

                            if (cb_iotAUTO.Checked == true)
                                Radiobutton_PlayGroup("LR");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수

                            BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            break;                      // 타임 오버 메세지창 출력
                    }
                    if (rb_GameSys_EasyMode.Checked)
                    {
                        switch (game_remaing_time)
                        {
                            case ((30 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((27 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((24 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((21 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((18 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((15 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((12 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((9 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((6 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;
                            case ((3 * 60) + 30): PCM_send("VO52"); PCM_send("AD _L"); break;

                        }
                    }
                    
                }
            }
        }
        private void TaggerSkill_TimeAction()
        {
            if (cb_Temple_autokiller.Checked)
            {
                switch (taggerskill_remaing_time)
                {
                    case ((27 * 60) + 00):
                        switch (blockdevice_rand1)
                        {
                            case 0: PCM_send("AI _B"); PCM_send("VO31"); break;
                            case 1: PCM_send("AR _B"); PCM_send("VO32"); break;
                        }
                        break;                       //(통신) 아이템, 생명장치중 봉쇄
                    case ((22 * 60) + 00):
                        switch (blockdevice_rand2)
                        {
                            case 0: PCM_send("AD _B1"); PCM_send("VO36"); break;
                            case 1: PCM_send("AV _B1"); PCM_send("VO34"); break;
                            case 2: PCM_send("AG _B1"); PCM_send("VO33"); break;
                        }
                        break;                       //(통신) 봉쇄 LV.1
                    case ((17 * 60) + 00):
                        switch (blockdevice_rand2)
                        {
                            case 0: PCM_send("AD _B2"); PCM_send("VO43"); break;
                            case 1: PCM_send("AV _B2"); PCM_send("VO45"); break;
                            case 2: PCM_send("AG _B2"); PCM_send("VO41"); break;
                        }
                        break;                       //(통신) 봉쇄 LV.2
                    case ((12 * 60) + 00):
                        switch (blockdevice_rand2)
                        {
                            case 0: PCM_send("AD _B3"); PCM_send("VO44"); break;
                            case 1: PCM_send("AV _B3"); PCM_send("VO46"); break;
                            case 2: PCM_send("AG _B3"); PCM_send("VO42"); break;
                        }
                        break;                       //(통신) 봉쇄 LV.3
                    case ((7 * 60) + 00):
                        PCM_send("AE _B"); PCM_send("VO35"); break;
                    case ((0 * 60) + 00):
                        TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_GameSys.Enabled = false;                                      //(타이머) 타이머 정지
                        lb_TaggerSkill_timer.Text = "00:00";
                        taggerskill_remaing_time = TAGGERSKILL_TIME * 60;
                        //OS_start = false;
                        break;
                }
            }
        }
        private void Radiobutton_PlayPeople()
        {
            if (rb_GameSys_4P.Checked == true)                            // 4p모드가 선택되어있을때
            {
                headcount = 3;                                              //플레이 멤버 4명                
                PCM_send("PP _4");                                         //(통신) 플레이 멤버 4명 전송
            }
            else if (rb_GameSys_5P.Checked == true)                     // 5p모드가 선택되어있을때
            {
                headcount = 4;                                              //플레이 멤버 5명          
                PCM_send("PP _5");                                         //(통신) 플레이 멤버 5명 전송
            }
            else if (rb_GameSys_6P.Checked == true)                     // 6p모드가 선택되어있을때
            {
                headcount = 5;                                              //플레이 멤버 6명
                PCM_send("PP _6");                                         //(통신) 플레이 멤버 6명 전송
            }
            else if (rb_GameSys_7P.Checked == true)                     // 6p모드가 선택되어있을때
            {
                headcount = 6;                                              //플레이 멤버 6명
                PCM_send("PP _7");                                         //(통신) 플레이 멤버 6명 전송
            }
            else if (rb_GameSys_8P.Checked == true)                     // 6p모드가 선택되어있을때
            {
                headcount = 7;                                              //플레이 멤버 6명
                PCM_send("PP _8");                                         //(통신) 플레이 멤버 6명 전송
            }
            selfrevive_cnt = headcount;
        }
        private void btn_GameSys_playPeople_Click(object sender, EventArgs e)
        {
            Radiobutton_PlayPeople();
            leftLifeChip();
        }
        private void Radiobutton_PlayMode()
        {
            if (rb_GameSys_EasyMode.Checked == true)                    // 뉴비 모드가 선택되어있을때
            {
                playmode = 1;                                               // 뉴비모드 = 0;
                PCM_send("PM _1");                                         // (통신) 플레이 모드 PM_0으로 전송
            }
            else if (rb_GameSys_NormalMode.Checked == true)             // 일반 모드가 선택되어있을때
            {
                playmode = 2;                                               // 뉴비모드 = 1;
                PCM_send("PM _2");                                         // (통신) 플레이 모드 PM_1으로 전송
            }
            else if (rb_GameSys_NightMode.Checked == true)               // 고인물 모드가 선택되어있을때
            {
                playmode = 3;                                               // 뉴비모드 = 2;
                PCM_send("PM _3");                                         // (통신) 플레이 모드 PM_2으로 전송
            }
        }

        private void Radiobutton_PlayGroup(String iotData)
        {
            String iotSend = "";
            if (rb_IOT_Group1.Checked == true)                          // IOT그룹 G1이 선택되었을때
            {
                playgroup = 1;                                              // IOT GROUP 1번으로 저장
                iotSend = "G1_";                                         //(IOT통신) IOT통신으로 PG1 전송
                Radiobutton_Group1();                                       //(IOT함수) 그룹 1번에서 누가 술래인지 결정해주는 함수
            }
            else if (rb_IOT_Group2.Checked == true)                     // IOT그룹 G2이 선택되었을때
            {
                playgroup = 2;                                              // IOT GROUP 2번으로 저장
                iotSend = "G2_";                                         //(IOT통신) IOT통신으로 PG2 전송
                Radiobutton_Group2();                                       //(IOT함수) 그룹 2번에서 누가 술래인지 결정해주는 함수
            }
            else if (rb_IOT_Group3.Checked == true)                     // IOT그룹 G3이 선택되었을때
            {
                playgroup = 3;                                              // IOT GROUP 3번으로 저장
                iotSend = "G3_";                                         //(IOT통신) IOT통신으로 PG3 전송
                Radiobutton_Group3();                                       //(IOT함수) 그룹 3번에서 누가 술래인지 결정해주는 함수
            }
            iotSend += iotData;
            iotSend += '\n';
            IOT_send(iotSend);
        }
        private void btn_GameSys_GameStart_Click(object sender, EventArgs e)
        {
            
            if (OS_start == false)
            {
                if (serialPort_PCM.IsOpen)
                {
                    if (rb_GameSys_HardMode.Checked)
                    {
                        Radiobutton_PlayGroup("WT_89");
                        iot_remaing_time = 90;
                    }
                    else
                    {
                        Radiobutton_PlayGroup("WT_179");
                    }

                    btn_GameSys_GameStart.Text = "GAME\n진행중";
                    btn_GameSys_GameStart.BackColor = Color.Gold; btn_GameSys_GameStart.ForeColor = Color.Black;
                    Radiobutton_PlayPeople();                                           //(함수) 플레이 인원 설정된데로 통신 보내기
                    Radiobutton_PlayMode();                                             //(함수) 플레이 모드 설정된데도 통신 보내기
                    PCM_ThreadTimer.Change(0, 1000);                                    //timer_GameSys.Enabled = true;//(타이머) 타이머 시작
                    IOT_ThreadTimer.Change(0, 1000);                                    //timer_IotSys.Enabled = true; //(타이머) iot타이머 시작

                    if (cb_Temple_autokiller.Checked)
                        Radiobutton_PlayGroup("AT");
                    else
                        Radiobutton_PlayGroup("LN");                                    //(함수) iot그룹에서 술래 정해진것 통신 보는 함수

                    OS_start = true;                                                //(변수) OS시작
                    game_remaing_time = GAMETIME * 60;                              //(변수) 남은시간 초기화
                    TRM_send("ES _O");
                }
                else
                    MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
            }
            leftLifeChip();
        }

        private void btn_GameSys_ReadyMode_Click(object sender, EventArgs e)
        {
            
            OS_start = false;
            PCM_send("PT");         //덕트테스트
            if (rb_GameSys_HardMode.Checked) 
            {
                PCM_send("BF _A");                          //하드모드일때 포그머신 장치연결
            }
            if (cb_gameModeAuto.Checked)
            {
                modeChange();
            }
            blockdevice_rand1 = rand.Next(0, 2);
            switch (blockdevice_rand1)
            {
                case 0: lb_block_1.Text = "아이템"; break;
                case 1: lb_block_1.Text = "생명";   break;
            }
            blockdevice_rand2 = rand.Next(0, 3);
            switch (blockdevice_rand2)
            {
                case 0: lb_block_2.Text = "도어LV1"; lb_block_3.Text = "도어LV2"; lb_block_4.Text = "도어LV3"; break;
                case 1: lb_block_2.Text = "덕트LV1"; lb_block_3.Text = "덕트LV2"; lb_block_4.Text = "덕트LV3"; break;
                case 2: lb_block_2.Text = "발전LV1"; lb_block_3.Text = "발전LV2"; lb_block_4.Text = "발전LV3"; break;
            }
           
            if (serialPort_PCM.IsOpen)
            {
                serialPort_PCM.Write("AA _A\n");                                //(통신) 전체장치 연결 (비활성화)
                game_remaing_time = GAMETIME * 60;                              //(변수) 남은시간 초기화
                lb_GameSys_Clock.Text = "35:00";                                //남은시간 35:00로 출력
                revive_rnd = rand.Next(0, 9);
                for (int i = 0; i < 10; i++)
                {
                    string lb_name = "lb_revive_";
                    lb_name += i.ToString();
                    lb_text_change(lb_name, revivalMachine[revive_arr[revive_rnd, i]].deviceName);
                }

                lb_GameSys_SelfReviveTime.Text = "1:30";
                open_revive_cnt = 0;
                lb_GameSys_UsedRevive_cnt.Text = open_revive_cnt.ToString();
                fixed_generator_cnt = 0;
                lb_GameSys_FixedGenerator_cnt.Text = fixed_generator_cnt.ToString();
                temple_collected_chip = 0;
                selfrevive_cnt = 0;
                lb_GameSys_CollectedTemple_cnt.Text = temple_collected_chip.ToString();
                for (int i = 0; i < 10; i++)
                    revivalMachine[i].deviceState = false;
                for (int i = 0; i < 5; i++)
                    generatorMachine[i].deviceState = false;
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
            leftLifeChip();
        }
        private void lb_text_change(String lb_name, String text)
        {
            this.Controls.Find(lb_name, true).FirstOrDefault().Text = text;
        }
        private void btn_GameSys_SetupMode_Click(object sender, EventArgs e)
        {
            OS_start = false;
            PCM_send("PT"); //덕트테스트
            PCM_send("AA _S");                                                   //(통신) 전체장치 세팅 모드 (비활성화)
            if(rb_GameSys_HardMode.Checked)
            {
                PCM_send("BF _S");
            }
            leftLifeChip();
        }

        private void btn_GameSys_GameStop_Click(object sender, EventArgs e)
        {
            PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_GameSys.Enabled = false;                                      //(타이머) 타이머 정지                                               //(변수) OS종료
            TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_GameSys.Enabled = false;                                      //(타이머) 타이머 정지
            lb_TaggerSkill_timer.Text = "32:00";
            lb_GameSys_Clock.Text = "35:00";
            game_remaing_time = GAMETIME * 60;                              //(변수) 게임 남은시간 초기화
            taggerskill_remaing_time = TAGGERSKILL_TIME * 60;               //(변수) 술래스킬 시간 초기화
            OS_start = false; //게임종료 
            btn_GameSys_GameStart.Text = "GAME\nSTART";
            btn_GameSys_GameStart.BackColor = Color.Green; btn_GameSys_GameStart.ForeColor = Color.WhiteSmoke;
        }

        private void btn_GameSys_VideoPlay_Click(object sender, EventArgs e)
        {
            PCM_send("PT");
        }

        private void btn_GameSys_OS_Start_Click(object sender, EventArgs e)
        {
            PCM_send("AI _O");
        }

        private void btn_GameSys_SelfRevive_Click(object sender, EventArgs e)
        {
            SelfRevive_Timer.Change(0, 1000);                                    //(통신) 부활장치 전체 자가부활 모드
            PCM_send("VO40"); PCM_send("AD _A");
        }

        private void btn_GameSys_5min_add_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                game_remaing_time += (1 * 60);                                  //(타이머) 타이머 5분 추가 
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_GameSys_1min_add_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
            {
                game_remaing_time -= (1 * 30);                                  //(타이머) 타이머 1분 추가
                lb_GameSys_Clock.Text = (game_remaing_time / 60).ToString("00") + ":" + (game_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");

        }

        private void btn_GameSys_timerStart_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                PCM_ThreadTimer.Change(0, 1000);                                //timer_GameSys.Enabled = true; //(타이머) 타이머 시작
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");


        }

        private void btn_GameSys_timerStop_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                PCM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_GameSys.Enabled = false;//(타이머) 타이머 정지
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }

        private char one_itemforROOM(ComboBox cb_device_room)
        {
            switch (cb_device_room.SelectedIndex)
            {
                case 0: return 'A'; //ALL
                case 1: return 'B'; //BG
                case 2: return 'L'; //LG
                case 3: return 'C'; //CG
                case 4: return 'S'; //SG
                case 5: return 'T'; //TG
                default: return 'A';
            }
        }
        private char two_itemforROOM(ComboBox cb_device_room)
        {
            switch (cb_device_room.SelectedIndex)
            {
                case 0: return 'A'; //ALL
                case 1: return 'B'; //BAMBOO
                case 2: return 'B'; //BAMBOO
                case 3: return 'L'; //LIVING
                case 4: return 'L'; //LIVING
                case 5: return 'C'; //CELLERAGE
                case 6: return 'C'; //CELLERAGE
                case 7: return 'S'; //SLEEPING
                case 8: return 'S'; //SLEEPING
                case 9: return 'T'; //TOILET
                case 10: return 'T'; //TOILET
                default: return 'A';
            }
        }
        private void btn_Generator_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += one_itemforROOM(cb_Generator_name);
            send_Arduio += "G _";
            switch (cb_Generator_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;   //장치 연결
                case 1: send_Arduio += 'R'; break;   //장치 활성화
                case 2: send_Arduio += 'S'; break;   //장치 세팅
                case 3: send_Arduio += 'C'; break;   //장치 연결확인
                case 4: send_Arduio += "B1"; break;   //봉쇄1단계
                case 5: send_Arduio += "B2"; break;   //봉쇄2단계
                case 6: send_Arduio += "B3"; break;   //봉쇄3단계     
                case 7: send_Arduio += 'O'; break;   //장치 오픈  
                case 8:
                    String easymode = send_Arduio + "M1_" + tb_easy_generator_starter.Text;
                    PCM_send(easymode); ;
                    send_Arduio += 'A'; break;    //뉴비모드
                case 9:
                    String normalmode = send_Arduio + "M1_" + tb_normal_generator_starter.Text;
                    PCM_send(normalmode);
                    send_Arduio += 'A'; break; ;    //뉴비모드 break;   //뉴비모드 
                case 10: send_Arduio += 'E'; break;   //발전기 배선수리 완료  
                case 11: send_Arduio += 'F'; break;   //발전기 수리 완료
                case 12: send_Arduio += 'N'; break;   //발전기 수리 완료
                case 13: send_Arduio += 'D'; break;   //발전기 수리 완료
                case 14: send_Arduio += 'W'; break;
                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }

        private void btn_Escape_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += one_itemforROOM(cb_Escape_name);
            send_Arduio += "E _";
            switch (cb_Escape_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;   //장치 연결
                case 1: send_Arduio += 'R'; break;   //장치 활성화
                case 2: send_Arduio += 'S'; break;   //장치 세팅
                case 3: send_Arduio += 'C'; break;   //장치 연결확인
                case 4: send_Arduio += 'B'; break;   //봉쇄 활성화
                case 5: send_Arduio += 'E'; break;   //탈출 성공
                case 6: send_Arduio += 'W'; break;
                default: send_Arduio += 'A'; break;   //봉쇄 활성화     
            }
            PCM_send(send_Arduio);
        }

        private void btn_Revive_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += two_itemforROOM(cb_Revive_name);
            //Console.WriteLine(cb_Revive_name.SelectedIndex);
            if (cb_Revive_name.SelectedIndex == 0)
                send_Arduio += "R _";
            else if (cb_Revive_name.SelectedIndex % 2 == 1)
                send_Arduio += "R1_";
            else if (cb_Revive_name.SelectedIndex % 2 == 0)
                send_Arduio += "R2_";
            switch (cb_Revive_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;   //장치 연결
                case 1: send_Arduio += 'R'; break;   //장치 활성화
                case 2: send_Arduio += 'S'; break;   //장치 세팅
                case 3: send_Arduio += 'C'; break;   //장치 연결확인
                case 4: send_Arduio += 'B'; break;   //봉쇄 활성화
                case 5: send_Arduio += 'O'; break;   //장치 오픈
                case 6: send_Arduio += 'E'; break;   //자가부활 모드
                case 7: send_Arduio += 'N'; break;   //나이트 모드
                case 8: send_Arduio += 'D'; break;   //데이모드
                case 9: send_Arduio += 'W'; break;
                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }

        private void btn_Itembox_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += two_itemforROOM(cb_Itembox_name);
            if (cb_Itembox_name.SelectedIndex == 0)
                send_Arduio += "I _";
            else if (cb_Itembox_name.SelectedIndex % 2 == 1)
                send_Arduio += "I1_";
            else if (cb_Itembox_name.SelectedIndex % 2 == 0)
                send_Arduio += "I2_";
            switch (cb_Itembox_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;   //장치 연결
                case 1: send_Arduio += 'R'; break;   //장치 활성화
                case 2: send_Arduio += 'S'; break;   //장치 세팅
                case 3: send_Arduio += 'C'; break;   //장치 연결확인
                case 4: send_Arduio += 'B'; break;   //봉쇄 활성화
                case 5: send_Arduio += 'O'; break;   //장치 연결확인
                case 6:
                    String easymode = send_Arduio + "M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                    PCM_send(easymode);
                    easymode = send_Arduio + "M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                    PCM_send(easymode);
                    easymode = send_Arduio + "M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                    PCM_send(easymode);
                    send_Arduio += "A";                  break;   //뉴비모드
                case 7:
                    String normalmode = send_Arduio + "M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                    PCM_send(normalmode);
                    normalmode = send_Arduio + "M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                    PCM_send(normalmode);
                    normalmode = send_Arduio + "M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                    PCM_send(normalmode);
                    send_Arduio += "A"; break;          //일반 모드
                case 8:
                    String hardnode = send_Arduio + "M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                    PCM_send(hardnode);
                    hardnode = send_Arduio + "M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                    PCM_send(hardnode);
                    hardnode = send_Arduio + "M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                    PCM_send(hardnode);
                    send_Arduio += "A"; break;          //찌발 모드
                case 9: send_Arduio += 'N'; break;      //나이트 모드
                case 10: send_Arduio += 'D'; break;     //데이 모드
                case 11: send_Arduio += 'W'; break;     //와치독 리셋
                case 12: send_Arduio += 'Q'; break;     //아이템박스 빠른리셋
                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }

        private void btn_Door_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            switch (cb_Door_name.SelectedIndex)
            {
                case 0: send_Arduio += "AD _"; break;  //전체 장치
                case 1: send_Arduio += "BD _"; break;  //대나무숲 
                case 2: send_Arduio += "CD _"; break;  //지하실
                case 3: send_Arduio += "SD _"; break;  //침실
                case 4: send_Arduio += "TD _"; break;  //화장실
            }
            switch (cb_Door_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;  //장치 연결
                case 1: String str_temp = send_Arduio + 'A'; PCM_send(str_temp); send_Arduio += 'R'; break;  //장치 활성화
                case 2: send_Arduio += 'S'; break;  //장치 세팅
                case 3: send_Arduio += 'C'; break;  //장치 연결확인
                case 4: send_Arduio += "B1"; break;  //봉쇄1단계
                case 5: send_Arduio += "B2"; break;  //봉쇄2단계
                case 6: send_Arduio += "B3"; break;  //봉쇄3단계     
                case 7: send_Arduio += 'O'; break;  //장치 오픈 
                case 8: send_Arduio += 'L'; break;  //도어 잠금
                case 9: send_Arduio += 'N'; break;  //나이트 모드
                case 10: send_Arduio += 'D'; break;  //데이 모드
                case 11: send_Arduio += 'W'; break;
                case 12: send_Arduio += 'H'; break;     //하드모드
                case 13: send_Arduio += "TON"; break;   //쇼타임 시작
                case 14: send_Arduio += "TOF"; break;   //쇼타임 종료
                case 15: send_Arduio += ("TL_" + tb_hard_door_taggertime.Text); break;  //술래잠금해제시간5초
                case 16: send_Arduio += ("TL_" + tb_hard_door_taggertime_templedestroy.Text); break; //술래잠금해제시간10초


                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }

        private void btn_Vent_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            switch (cb_Vent_name.SelectedIndex)
            {
                case 0: send_Arduio += "AV _"; break;  //전체 장치
                case 1: send_Arduio += "BV1_"; break;  //대나무 숲 덕트1
                case 2: send_Arduio += "CV _"; break;  //지하실 덕트
                case 3: send_Arduio += "TV _"; break;  //화장실 덕트
                case 4: send_Arduio += "BV2_"; break;  //화장실 덕트
                case 5: send_Arduio += "LV _"; break;  //화장실 덕트
                case 6: send_Arduio += "SV _"; break;  //화장실 덕트

            }
            switch (cb_Vent_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;  //장치 연결
                case 1: send_Arduio += 'R'; break;  //장치 활성화
                case 2: send_Arduio += 'S'; break;  //장치 세팅
                case 3: send_Arduio += 'C'; break;  //장치 연결확인
                case 4: send_Arduio += "B1"; break;  //봉쇄 1단계
                case 5: send_Arduio += "B2"; break;  //봉쇄 2단계
                case 6: send_Arduio += "B3"; break;  //봉쇄 3단계
                case 7: send_Arduio += 'O'; break;  //장치 오픈
                case 8:
                    String easymode = send_Arduio + "M1_" + tb_easy_vent_cooltime.Text;
                    PCM_send(easymode);
                    easymode = send_Arduio + "M2_" + tb_easy_vent_cooltime_addup.Text;
                    PCM_send(easymode); ;
                    send_Arduio += "A";         break;  //뉴비 모드
                case 9:
                    String normalmode = send_Arduio + "M1_" + tb_normal_vent_cooltime.Text;
                    PCM_send(normalmode);
                    normalmode = send_Arduio + "M2_" + tb_normal_vent_cooltime_addup.Text;
                    PCM_send(normalmode); ;
                    send_Arduio += "A"; break;  // 일반 모드
                case 10: send_Arduio += "N"; break; // 나이트 모드
                case 11: send_Arduio += "D"; break; // 데이모드
                case 12: send_Arduio += 'W'; break;
                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }

        private void btn_Temple_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            switch (cb_Temple_name.SelectedIndex)
            {
                case 0: send_Arduio += "LT _"; break;  //제단
                case 1: send_Arduio += "BF _"; break;  //포그머신
            }
            switch (cb_Temple_state.SelectedIndex)
            {
                case 0: send_Arduio += 'A'; break;   //장치 연결
                case 1: send_Arduio += 'R'; break;   //장치 활성화
                case 2: send_Arduio += 'S'; break;   //장치 세팅
                case 3: send_Arduio += 'C'; break;   //장치 연결확인
                case 4: send_Arduio += 'N'; break;   //나이트 모드
                case 5: send_Arduio += 'D'; break;   //데이 모드
                case 6: send_Arduio += 'B'; break;   //데이 모드
                case 7: send_Arduio += 'W'; break;   //데이 모드
                case 8: send_Arduio += 'H'; break;   //하드 모드
                case 9: send_Arduio += 'D'; break;   //제단 파괴
                case 10: send_Arduio += 'F'; break;   //제단 수리
                case 11: send_Arduio += 'E'; break;   //포그 가능
                case 12: send_Arduio += 'F'; break;   //포그 작동
                case 13: send_Arduio += 'U'; break;   //포그 사용완료
                case 14: send_Arduio += 'T'; break;   //포그 테스트
                case 15: send_Arduio += "FL_" + tb_hard_fogtime.Text; lb_fogtime.Text = "(초)" + tb_hard_fogtime.Text;  break;   //제단 수리
                case 16: send_Arduio += 'G'; break;   //강제포그
                default: send_Arduio += 'A'; break;
            }
            PCM_send(send_Arduio);
        }
        private void btn_GameSys_OSReset_Click(object sender, EventArgs e)
        {
            
            lb_block_1.Text = "랜덤";
            lb_GameSys_SelfReviveTime.Text = "1:30";
            open_revive_cnt = 0;
            lb_GameSys_UsedRevive_cnt.Text = open_revive_cnt.ToString();
            fixed_generator_cnt = 0;
            lb_GameSys_FixedGenerator_cnt.Text = fixed_generator_cnt.ToString();
            temple_collected_chip = 0;
            selfrevive_cnt = 0;
            lb_GameSys_CollectedTemple_cnt.Text = temple_collected_chip.ToString();
            for (int i = 0; i < 10; i++)
                revivalMachine[i].deviceState = false;
            for (int i = 0; i < 5; i++)
                generatorMachine[i].deviceState = false;
            BV1_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            BV2_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            LV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            CV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            SV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            TV_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            leftLifeChip();
        }
        private void btn_GameSys_NarrantionPlay_Click(object sender, EventArgs e)
        {
            switch (cb_GameSys_Narration.SelectedIndex)
            {
                case 0:                                                         //남은 발전기 카운트해서 나레이션 나옴
                    switch (Int32.Parse(lb_GameSys_FixedGenerator_cnt.Text))
                    {
                        case 1: PCM_send("VO38"); break;
                        case 2: PCM_send("VO37"); break;
                        case 3: PCM_send("VO22"); PCM_send("VO23");break;
                    }
                    break;
                case 2: PCM_send("VO23"); break;
                case 3: PCM_send("VO24"); break;
                case 4: PCM_send("VO40"); break;
                case 5: PCM_send("VO8_1");                                      //남은 생명갯수만큼 카운트해서 나레이션 나옴
                    switch (Int32.Parse(lb_GameSys_CollectedTemple_cnt.Text))
                    {
                        case 1: PCM_send("VC9"); break;
                        case 2: PCM_send("VC8"); break;
                        case 3: PCM_send("VC7"); break;
                        case 4: PCM_send("VC6"); break;
                        case 5: PCM_send("VC5"); break;
                        case 6: PCM_send("VC4"); break;
                        case 7: PCM_send("VC3"); break;
                        case 8: PCM_send("VC2"); break;
                        case 9: PCM_send("VC1"); break;
                    }
                    PCM_send("VO8_2");
                    break;
                case 6: PCM_send("VO11"); break;
                case 7: PCM_send("VO13"); break;
                case 8: PCM_send("VO14"); break;
                case 9: PCM_send("VO25"); break;
                case 10: PCM_send("VO31"); break;
                case 11: PCM_send("VO32"); break;
                case 12: PCM_send("VO33"); break;
                case 13: PCM_send("VO34"); break;
                case 14: PCM_send("VO36"); break;
                case 15: PCM_send("VO35"); break;
                case 16: PCM_send("VO10"); break;
                case 17: PCM_send("VO52"); break;
                case 18: PCM_send("VO62"); break;
                default: break;
            }
        }

        private void btn_GameSys_ModeSetting_Click(object sender, EventArgs e)
        {
            modeChange();
        }
        private void btn_GameSys_currentState_Click(object sender, EventArgs e)
        {
            PCM_send("AI _C");
            PCM_send("AR _C");
            PCM_send("AG _C");
            PCM_send("AV _C");
            PCM_send("LT _C");
            PCM_send("AD _C");
            PCM_send("BF _C");
        }
        // **************************************************************       GAME sys MAIN CODE          *******************************************************************************************
        // **************************************************************       IOT sys MAIN CODE          *******************************************************************************************
        const int IOT_TIME = 3;                                                                             //3분;   총 IOT술래 결정까지 시간 저장 변수 
        int iot_remaing_time = IOT_TIME * 60;                                                               //3*60; 남은시간 전체 초로 카운팅 저장하고 있는 변수
        int iot_remaing_min = 0;                                                                            //0;     남은시간 MIN으로 가지고 있는 변수
        int iot_remaing_sec = 0;                                                                            //0;     남은시간 SEC으로 가지고 있는 변수
        uint playgroup1_tagger = 1;
        uint playgroup2_tagger = 2;
        uint playgroup3_tagger = 3;
        void IOT_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_IOT(IOT_timerWork));
        }
        private void IOT_timerWork()
        {
            iot_remaing_time -= 1;                                                                          //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            iot_remaing_min = iot_remaing_time / 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            iot_remaing_sec = iot_remaing_time % 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = iot_remaing_min.ToString("0") + ":" + iot_remaing_sec.ToString("00");     //남은 시간 uint -> String으로 변환하는 작업
            lb_IotSys_Clock.Text = remaing_show;                                                            //남은 시간 출력
            switch (iot_remaing_time)
            {
                case 0:
                    IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_IotSys.Enabled = false;                                                           //(타이머) iot타이머 정지
                    iot_remaing_time = IOT_TIME * 60;
                    lb_IotSys_Clock.Text = "3:00";
                    break;
            }
        }
        private void timer_IotSys_Tick(object sender, EventArgs e)
        {
            iot_remaing_time -= 1;                                                                          //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            iot_remaing_min = iot_remaing_time / 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            iot_remaing_sec = iot_remaing_time % 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = iot_remaing_min.ToString("0") + ":" + iot_remaing_sec.ToString("00");     //남은 시간 uint -> String으로 변환하는 작업
            lb_IotSys_Clock.Text = remaing_show;                                                            //남은 시간 출력
            switch (iot_remaing_time)
            {
                case 0:
                    timer_IotSys.Enabled = false;                                                           //(타이머) iot타이머 정지
                    iot_remaing_time = IOT_TIME * 60;
                    lb_IotSys_Clock.Text = "3:00";
                    break;
            }
        }
        private void Radiobutton_Group1()                                                                   //(함수) RADIOBTN에서 IOT 그룹 1번중에 술래 찾는 함수
        {
            if (rb_G1P1.Checked == true)                                                                    // G1P1이 술래 일때
            {
                playgroup1_tagger = 1;                                                                          // G1P1을 술래로 저장   
                IOT_send("G1_P1\n");                                                                            //(IOT통신) G1P1으로 통신 전송
                lb_G1P1_state.Text = "Tagger";
                lb_G1P1_state.ForeColor = Color.White;
                lb_G1P1_state.BackColor = Color.Purple;
            }
            else if (rb_G1P2.Checked == true)                                                               // G1P2이 술래 일때
            {
                playgroup1_tagger = 2;                                                                          // G1P2을 술래로 저장
                IOT_send("G1_P2\n");                                                                            //(IOT통신) G1P2으로 통신 전송
            }
            else if (rb_G1P3.Checked == true)                                                               // G1P3이 술래 일때
            {
                playgroup1_tagger = 3;                                                                          // G1P3을 술래로 저장
                IOT_send("G1_P3\n");                                                                            //(IOT통신) G1P3으로 통신 전송
            }
            else if (rb_G1P4.Checked == true)                                                               // G1P4이 술래 일때
            {
                playgroup1_tagger = 4;                                                                          // G1P4을 술래로 저장
                IOT_send("G1_P4\n");                                                                            //(IOT통신) G1P4으로 통신 전송
            }
            else if (rb_G1P5.Checked == true)                                                               // G1P5이 술래 일때
            {
                playgroup1_tagger = 5;                                                                          // G1P5을 술래로 저장
                IOT_send("G1_P5\n");                                                                            //(IOT통신) G1P5으로 통신 전송
            }
            else if (rb_G1P6.Checked == true)                                                               // G1P6이 술래 일때
            {
                playgroup1_tagger = 6;                                                                          // G1P6을 술래로 저장
                IOT_send("G1_P6\n");                                                                            //(IOT통신) G1P6으로 통신 전송
            }
            else if (rb_G1P7.Checked == true)                                                               // G1P7이 술래 일때
            {
                playgroup1_tagger = 7;                                                                          // G1P7을 술래로 저장
                IOT_send("G1_P7\n");                                                                            //(IOT통신) G1P7으로 통신 전송
            }
            else if (rb_G1P8.Checked == true)                                                               // G1P8이 술래 일때
            {
                playgroup1_tagger = 8;                                                                          // G1P1을 술래로 저장
                IOT_send("G1_P8\n");                                                                            //(IOT통신) G1P8으로 통신 전송
            }
        }
        private void Radiobutton_Group2()                                                                   //(함수) RADIOBTN에서 IOT 그룹 2번중에 술래 찾는 함수
        {
            if (rb_G2P1.Checked == true)
            {
                playgroup2_tagger = 1;
                IOT_send("G2_P1\n");
            }
            else if (rb_G2P2.Checked == true)
            {
                playgroup2_tagger = 2;
                IOT_send("G2_P2\n");
            }
            else if (rb_G2P3.Checked == true)
            {
                playgroup2_tagger = 3;
                IOT_send("G2_P3\n");
            }
            else if (rb_G2P4.Checked == true)
            {
                playgroup2_tagger = 4;
                IOT_send("G2_P4\n");
            }
            else if (rb_G2P5.Checked == true)
            {
                playgroup2_tagger = 5;
                IOT_send("G2_P5\n");
            }
            else if (rb_G2P6.Checked == true)
            {
                playgroup2_tagger = 6;
                IOT_send("G2_P6\n");
            }
            else if (rb_G2P7.Checked == true)
            {
                playgroup2_tagger = 7;
                IOT_send("G2_P7\n");
            }
            else if (rb_G2P8.Checked == true)
            {
                playgroup2_tagger = 8;
                IOT_send("G2_P8\n");
            }
        }
        private void Radiobutton_Group3()                                                                   //(함수) RADIOBTN에서 IOT 그룹 3번중에 술래 찾는 함수
        {
            if (rb_G3P1.Checked == true)
            {
                playgroup3_tagger = 1;
                IOT_send("G3_P1\n");
            }
            else if (rb_G3P2.Checked == true)
            {
                playgroup3_tagger = 2;
                IOT_send("G3_P2\n");
            }
            else if (rb_G3P3.Checked == true)
            {
                playgroup3_tagger = 3;
                IOT_send("G3_P3\n");
            }
            else if (rb_G3P4.Checked == true)
            {
                playgroup3_tagger = 4;
                IOT_send("G3_P4\n");
            }
            else if (rb_G3P5.Checked == true)
            {
                playgroup3_tagger = 5;
                IOT_send("G3_P5\n");
            }
            else if (rb_G3P6.Checked == true)
            {
                playgroup3_tagger = 6;
                IOT_send("G3_P6\n");
            }
            else if (rb_G3P7.Checked == true)
            {
                playgroup3_tagger = 7;
                IOT_send("G3_P7\n");
            }
            else if (rb_G3P8.Checked == true)
            {
                playgroup3_tagger = 8;
                IOT_send("G3_P8\n");
            }
        }
        private void iotSys_PlayGroup(String iotData)
        {
            String iotSend = "";
            if (rb_iotSys_iotG1.Checked == true)                          // IOT그룹 G1이 선택되었을때
            {
                playgroup = 1;                                              // IOT GROUP 1번으로 저장
                Radiobutton_Group1();                                       //(IOT함수) 그룹 1번에서 누가 술래인지 결정해주는 함수
                iotSend = "G1_";                                            //(IOT통신) IOT통신으로 PG1 전송
            }
            else if (rb_iotSys_iotG2.Checked == true)                     // IOT그룹 G2이 선택되었을때
            {
                playgroup = 2;                                              // IOT GROUP 2번으로 저장
                Radiobutton_Group2();                                       //(IOT함수) 그룹 2번에서 누가 술래인지 결정해주는 함수
                iotSend = "G2_";                                         //(IOT통신) IOT통신으로 PG2 전송
            }
            /*else if (rb_iotSys_iotG3.Checked == true)                     // IOT그룹 G3이 선택되었을때
            {
                playgroup = 3;                                              // IOT GROUP 3번으로 저장
                Radiobutton_Group3();                                       //(IOT함수) 그룹 3번에서 누가 술래인지 결정해주는 함수
                iotSend = "G3_";                                          //(IOT통신) IOT통신으로 PG2 전송
            }*/
            iotSend += iotData;
            iotSend += '\n';
            IOT_send(iotSend);
        }

        private void btn_IotTest_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("LR");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");

        }

        private void btn_TagSel_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                if (cb_IOTTemple_autokiller.Checked)
                    iotSys_PlayGroup("AT");
                else
                    iotSys_PlayGroup("LN");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                IOT_ThreadTimer.Change(0, 1000);                                //timer_IotSys.Enabled = true;  //(타이머) iot타이머 시작
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_TagReSel_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                if(cb_IOTTemple_autokiller.Checked)
                    iotSys_PlayGroup("RT");
                else
                    iotSys_PlayGroup("RR");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_IOTVibeTest_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("VIBE_TEST");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_IOTVibeON_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("VIBE_ON");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IOTVibeOFF_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("VIBE_OFF");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IOTtagON_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                if (cb_IOTTemple_autokiller.Checked)
                    iotSys_PlayGroup("START");
                IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IOTreset_Click(object sender, EventArgs e)
        {
            if (rb_iotSys_iotG2.Checked) { 
                if (serialPort_IOT.IsOpen)
                     iotSys_PlayGroup("WATCHDOG");
                else
                    MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
            }
            else
                MessageBox.Show((String)"G2 만 지원하는 기능입니다.");
        }

        private void btn_IOTnightmode_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("ALL_NIGHT");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IOTdaymode_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                iotSys_PlayGroup("ALL_DAY");                                             //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IotSys_timerReset_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_IotSys.Enabled = false; //(타이머) iot타이머 정지
                iot_remaing_time = IOT_TIME * 60;                               //(변수) iot타이머 시간 리셋
                lb_IotSys_Clock.Text = "3:00";
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IotSys_timerStart_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                IOT_ThreadTimer.Change(0, 1000);                                 //timer_IotSys.Enabled = true;//(타이머) iot타이머 시작
                iot_remaing_time = IOT_TIME * 60;                               //(변수) iot타이머 시간 리셋
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IotSys_timerStop_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                IOT_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //timer_IotSys.Enabled = false; //(타이머) iot타이머 정지
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        // **************************************************************       IOT sys MAIN CODE          *******************************************************************************************
        // **************************************************************      EXERCISE sys MAIN CODE      *******************************************************************************************
        String ExerciseRm_status = "";
        const int TRM_MAIN_TIME = 20;                                                               //25분;     훈련소 총 머무는 시간 저장하는 변수 
        int trm_main_time = 0;                                                                      //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
        int trm_main_min = 0;                                                                       //0;        남은시간 MIN으로 가지고 있는 변수
        int trm_main_sec = 0;                                                                       //0;        남은시간 SEC으로 가지고 있는 변수

        int trm_time = 0;                                                                           //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
        int trm_min = 0;                                                                            //0;        남은시간 MIN으로 가지고 있는 변수
        int trm_sec = 0;                                                                            //0;        남은시간 SEC으로 가지고 있는 변수
        bool TRM_start = false;

        int trm_device_time = 0;                                                                    //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
        int trm_device_min = 0;                                                                     //0;        남은시간 MIN으로 가지고 있는 변수
        int trm_device_sec = 0;                                                                     //0;        남은시간 SEC으로 가지고 있는 변수
        char using_device = ' ';
        bool itembox1 = false;                                                                      // 1번 아이템 박스 열렸는지 확인하는 변수
        bool itembox2 = false;                                                                      // 2번 아이템 박스 열렸는지 확인하는 변수
        private void ExerciseSys_PlayGroup(String iotData)
        {
            String iotSend = "";
            if (rb_ExerciseSys_iotG1.Checked == true)                          // IOT그룹 G1이 선택되었을때
            {
                iotSend = "G1_";                                            //(IOT통신) IOT통신으로 PG1 전송
            }
            else if (rb_ExerciseSys_iotG2.Checked == true)                     // IOT그룹 G2이 선택되었을때
            {
                iotSend = "G2_";                                         //(IOT통신) IOT통신으로 PG2 전송
            }
            else if (rb_ExerciseSys_iotG3.Checked == true)                     // IOT그룹 G3이 선택되었을때
            {
                iotSend = "G3_"; ;                                         //(IOT통신) IOT통신으로 PG2 전송
            }
            iotSend += iotData;
            iotSend += '\n';
            IOT_send(iotSend);
        }
        void TRM_MAIN_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TRM_MAIN(TRM_Main_timerWork));
        }
        private void TRM_Main_timerWork()
        {
            trm_main_time += 1;                                                                                 //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            trm_main_min = trm_main_time / 60;                                                                       //남은 시간 분과 초로 불리해주는 작업
            trm_main_sec = trm_main_time % 60;                                                                       //남은 시간 분과 초로 불리해주는 작업
            string remaing_main_show = trm_main_min.ToString("00") + ":" + trm_main_sec.ToString("00");         //남은 시간 uint -> String으로 변환하는 작업
            lb_ExerciseSys_Clock.Text = remaing_main_show;                                                      //남은 시간 출력
            switch (trm_main_time)
            {
                //case ((15 * 60) + 00):  TRM_send("VN10"); break;
                case ((15 * 60) + 00): TRM_send("VN5"); break;
                case ((28 * 60) + 00): TRM_send("VN3"); break;
                case ((19 * 60) + 00): TRM_send("VN1"); break;
            }
        }
        void TRM_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TRM(TRM_timerWork));
        }
        private void TRM_timerWork()
        {
            trm_time += 1;                                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            trm_min = trm_time / 60;                                                                            //남은 시간 분과 초로 불리해주는 작업
            trm_sec = trm_time % 60;                                                                            //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = trm_min.ToString("0") + ":" + trm_sec.ToString("00");                        //남은 시간 uint -> String으로 변환하는 작업
            lb_ExerciseSys_maintime.Text = remaing_show;                                                        //남은 시간 출력
            Exercisesys_TimeAction();
        }
        void Device_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_DEVICE(Device_timerWork));
        }
        private void Device_timerWork()
        {
            trm_device_time += 1;                                                                               //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            trm_device_min = trm_device_time / 60;                                                                     //남은 시간 분과 초로 불리해주는 작업
            trm_device_sec = trm_device_time % 60;                                                                     //남은 시간 분과 초로 불리해주는 작업
            string remaing_main_show = trm_device_min.ToString("0") + ":" + trm_device_sec.ToString("00");     //남은 시간 uint -> String으로 변환하는 작업
            lb_ExerciseSys_subtime.Text = remaing_main_show;                                                      //남은 시간 출력//초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            if (using_device == 'R')
            {
                if (ExerciseRm_status.Contains("Revival Open") && trm_device_time < 60)
                {
                    TRM_send("EC _OFF");
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    ExerciseSys_cbScenrio_sel(16);
                    trm_device_time = 0;
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 1): ExerciseSys_cbScenrio_sel(13); lb_Exercise_progress.Text = "생명장치"; break;
                    case ((0 * 60) + 6): TRM_send("ER _R"); break;
                    case ((0 * 60) + 30):
                        TRM_send("ER _O"); ExerciseSys_cbScenrio_sel(14); Console.Write("1분경과");
                        break;
                    case ((0 * 60) + 36):
                        ExerciseSys_cbScenrio_sel(15); trm_device_time = 0;
                        TRM_send("ER _S");
                        TRM_send("EC _OFF");
                        using_device = ' ';
                        TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                        TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                        break;
                }
            }
            else if (using_device == 'I')
            {
                if (ExerciseRm_status.Contains("Itembox1 Open")) itembox1 = true;
                if (ExerciseRm_status.Contains("Itembox2 Open")) itembox2 = true;
                if (itembox1 == true && itembox2 == true && trm_device_time < 180)
                {
                    ExerciseSys_cbScenrio_sel(24);
                    itembox1 = false;
                    itembox2 = false;
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    trm_device_time = 0;
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 1): ExerciseSys_cbScenrio_sel(19); lb_Exercise_progress.Text = "아이템박스"; break;
                    case ((0 * 60) + 10): ExerciseSys_cbScenrio_sel(20); ExerciseSys_cbScenrio_sel(100); break;
                    case ((0 * 60) + 16): ExerciseSys_cbScenrio_sel(21); break;
                    case ((0 * 60) + 26): ExerciseSys_cbScenrio_sel(22); break;
                    case ((1 * 60) + 00): ExerciseSys_cbScenrio_sel(23); break;
                    case ((1 * 60) + 8):
                        trm_device_time = 0; TRM_send("EI1_O"); TRM_send("EI2_O");
                        using_device = ' ';
                        TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                        TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                        break;
                }
            }
            else if (using_device == 'G')
            {
                if (ExerciseRm_status.Contains("Generator Fix") && trm_device_time < 180)
                {
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    ExerciseSys_cbScenrio_sel(31); TRM_send("EE _O");
                    trm_device_time = 0;
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 1): ExerciseSys_cbScenrio_sel(27); lb_Exercise_progress.Text = "발전기"; break;
                    case ((0 * 60) + 16): ExerciseSys_cbScenrio_sel(28); break;
                    case ((0 * 60) + 23): ExerciseSys_cbScenrio_sel(29); break;
                    case ((1 * 60) + 30):
                        ExerciseSys_cbScenrio_sel(30); trm_device_time = 0; TRM_send("EG _F"); TRM_send("EE _O");
                        using_device = ' ';
                        TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                        TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                        break;
                }
            }
            else if (using_device == 'D')
            {
                if (ExerciseRm_status.Contains("Door Lock") && trm_device_time < 120)
                {
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    ExerciseSys_cbScenrio_sel(38);
                    trm_device_time = 0;
                    TRM_send("EE _R");
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 1): ExerciseSys_cbScenrio_sel(34); lb_Exercise_progress.Text = "도어"; break;
                    case ((0 * 60) + 10): ExerciseSys_cbScenrio_sel(100); break;
                    case ((0 * 60) + 15): ExerciseSys_cbScenrio_sel(35); break;
                    case ((0 * 60) + 26): ExerciseSys_cbScenrio_sel(100); break;
                    case ((1 * 60) + 35): ExerciseSys_cbScenrio_sel(36); TRM_send("ER _A"); break;
                    case ((1 * 60) + 45): ExerciseSys_cbScenrio_sel(100); break;

                    case ((0 * 60) + 55):
                        ExerciseSys_cbScenrio_sel(37); break;
                    case ((1 * 60) + 00):
                        trm_device_time = 0; TRM_send("ED _L");
                        using_device = ' ';
                        TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                        TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                        TRM_send("EE _R");
                        break;
                }
            }
            else if (using_device == 'E')
            {
                if (ExerciseRm_status.Contains("Escape Open"))
                {
                    ExerciseSys_cbScenrio_sel(40);
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    trm_device_time = 0;
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 30): TRM_send("EE _E"); lb_Exercise_progress.Text = "탈출장치"; break;
                }
            }
            else if (using_device == 'V')
            {
                if (ExerciseRm_status.Contains("Duct Open"))
                {
                    //TRM_send("ED _I");
                    ExerciseSys_cbScenrio_sel(45);
                    TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM타이머 시작
                    TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
                    trm_device_time = 0;
                }
                switch (trm_device_time)
                {
                    case ((0 * 60) + 30): TRM_send("EV _O"); lb_Exercise_progress.Text = "덕트"; break;
                }
            }
        }
        private void timer_ExerciseSys_Tick(object sender, EventArgs e)
        {
            trm_time += 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            trm_min = trm_time / 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            trm_sec = trm_time % 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = trm_min.ToString("00") + ":" + trm_sec.ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            lb_ExerciseSys_Clock.Text = remaing_show;                                                   //남은 시간 출력
            Exercisesys_TimeAction();
        }
        private void Exercisesys_TimeAction()
        {
            if (TRM_start == true)
            {
                //처음 게임시작하고 나레이션if문
                switch (trm_time)
                {
                    case ((0 * 60) + 1): ExerciseSys_cbScenrio_sel(0); TRM_send("ED _E");break;
                    case ((0 * 60) + 12): ExerciseSys_cbScenrio_sel(1); break;
                    case ((0 * 60) + 21): ExerciseSys_cbScenrio_sel(2); break;
                    case ((0 * 60) + 27): ExerciseSys_cbScenrio_sel(100); break;
                    case ((0 * 60) + 28): ExerciseSys_cbScenrio_sel(3); break;
                    case ((0 * 60) + 35): ExerciseSys_cbScenrio_sel(100); break;
                    case ((0 * 60) + 36): ExerciseSys_cbScenrio_sel(4); break;
                    case ((0 * 60) + 45): ExerciseSys_cbScenrio_sel(5); break;
                    case ((0 * 60) + 56): ExerciseSys_cbScenrio_sel(100); break;
                    case ((0 * 60) + 57): ExerciseSys_cbScenrio_sel(6); break;
                    case ((1 * 60) + 4): ExerciseSys_cbScenrio_sel(7); break;
                    case ((1 * 60) + 7): ExerciseSys_PlayGroup("KILLER_COLOR"); break;
                    case ((1 * 60) + 11): ExerciseSys_cbScenrio_sel(100); ExerciseSys_PlayGroup("LR"); break;
                    case ((1 * 60) + 13): ExerciseSys_cbScenrio_sel(8); break;
                    case ((1 * 60) + 18): ExerciseSys_cbScenrio_sel(100); break;
                    case ((1 * 60) + 19): ExerciseSys_cbScenrio_sel(9); break;
                    case ((1 * 60) + 26): ExerciseSys_cbScenrio_sel(100); break;
                    case ((1 * 60) + 32): ExerciseSys_cbScenrio_sel(10); break;
                    //생명장치 동작
                    case ((1 * 60) + 52): ExerciseSys_cbScenrio_sel(11); break;
                    case ((2 * 60) + 7): ExerciseSys_cbScenrio_sel(12); break;
                    case ((2 * 60) + 14): TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); // 다른 타이머 동작 Device_timerWork
                        break;
                    //아이템상자 동작
                    case ((2 * 60) + 22): ExerciseSys_cbScenrio_sel(17); TRM_send("ER _A"); break;
                    case ((2 * 60) + 31): break;//ExerciseSys_cbScenrio_sel(100);     
                    case ((2 * 60) + 32): ExerciseSys_cbScenrio_sel(18); break;
                    case ((2 * 60) + 39): using_device = 'I'; TRM_send("EI1_R"); TRM_send("EI2_R");
                        TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); // 다른 타이머 동작 Device_timerWork
                        break;
                    //발전기
                    case ((2 * 60) + 50): ExerciseSys_cbScenrio_sel(25); TRM_send("EI1_O"); TRM_send("EI2_O"); break;
                    case ((3 * 60) + 0): ExerciseSys_cbScenrio_sel(26); TRM_send("EI1_A"); TRM_send("EI2_A");
                        using_device = 'G'; TRM_send("EG _R");
                        TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); // 다른 타이머 동작 Device_timerWork
                        break;
                    //도어
                    case ((3 * 60) + 10): ExerciseSys_cbScenrio_sel(32); break;
                    case ((3 * 60) + 17): ExerciseSys_cbScenrio_sel(100); break;
                    case ((3 * 60) + 21): ExerciseSys_cbScenrio_sel(33); break;
                    case ((3 * 60) + 27): ExerciseSys_cbScenrio_sel(100); TRM_send("ED _R"); lb_Exercise_progress.Text = "도어"; using_device = 'D'; TRM_send("EE _A");
                        TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); // 다른 타이머 동작 Device_timerWork
                        break;

                    //탈출장치
                    case ((3 * 60) + 38): ExerciseSys_cbScenrio_sel(39);lb_Exercise_progress.Text = "탈출장치"; break;
                    case ((3 * 60) + 48): TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); using_device = 'E'; TRM_send("EE _R"); // 다른 타이머 동작 Device_timerWork
                        break;

                    case ((3 * 60) + 55): ExerciseSys_cbScenrio_sel(41); break;
                    case ((3 * 60) + 57): TRM_send("ED _K"); TRM_send("EL _EOFF"); break;
                    case ((4 * 60) + 6): ExerciseSys_cbScenrio_sel(42); break;
                    case ((4 * 60) + 7): ExerciseSys_cbScenrio_sel(100); break;

                    //덕트
                    case ((4 * 60) + 12): TRM_send("ED _V"); TRM_send("EV _R"); break;
                    case ((4 * 60) + 13): ExerciseSys_cbScenrio_sel(43); break;
                    case ((4 * 60) + 15):   //ExerciseSys_cbScenrio_sel(100); TRM_send("ED _V"); 
                        TRM_send("EM _M12"); break;
                    case ((4 * 60) + 19): ExerciseSys_cbScenrio_sel(44); break;
                    case ((4 * 60) + 21): TRM_send("ED _V"); break;
                    case ((4 * 60) + 22):   //ExerciseSys_cbScenrio_sel(100); 
                                            //TRM_send("EM _M13\n");
                        TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM타이머 정지
                        TRM_DeviceTimer.Change(0, 1000); using_device = 'V';  lb_Exercise_progress.Text = "덕트";// 다른 타이머 동작 Device_timerWork
                        break;

                    case ((4 * 60) + 27): ExerciseSys_cbScenrio_sel(46); break;
                    case ((4 * 60) + 28): ExerciseSys_cbScenrio_sel(100); break;
                    case ((4 * 60) + 40): ExerciseSys_cbScenrio_sel(47); TRM_send("EL _EON"); TRM_send("EA _S"); break; //TRM_send("ED _!");
                    case ((4 * 60) + 45): TRM_send("EA _R"); TRM_send("EE _A"); TRM_send("ED _S"); TRM_send("ED _R"); TRM_send("ET _H"); TRM_send("ET _B"); lb_Exercise_progress.Text = "종료";
                        TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false;
                        break;
                }
            }
        }

        private void btn_ExerciseSys_Start_Click(object sender, EventArgs e)        //'훈련소 시작' 버튼 클릭
        {
            if (TRM_start == false)
            {
                if (serialPort_TRM.IsOpen)
                {
                    lb_Exercise_progress.Text = "나레이션";
                    TRM_start = true;
                    trm_main_time = 0;                                                  //  (타이머) TRM 메인 타이머 시간 초기화    
                    trm_time = 0;                                                       //  (타이머) TRM 장치 타이머 시간 초기화    
                    TRM_MainTimer.Change(0, 1000);                                      //  timer_ExerciseSys.Enabled = true;//(타이머) TRM 전체 시간타이머 시작    
                    TRM_ThreadTimer.Change(0, 1000);                                    //  timer_ExerciseSys.Enabled = true;//(타이머) TRM 장치 타이머 시작    
                    TRM_send("EL _WON");

                    btn_ExerciseSys_Start.Text = "훈련소\n진행중";
                    btn_ExerciseSys_Start.BackColor = Color.Gold; btn_ExerciseSys_Start.ForeColor = Color.Black;
                }
                else
                    MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
            }
        }

        private void btn_ExerciseSys_ReadyMode_Click(object sender, EventArgs e)    //'훈련소 장치 준비' 버튼 클릭
        {
            lb_Exercise_progress.Text = "준비모드";
            btn_ExerciseSys_Start.Text = "훈련소\n시작";
            btn_ExerciseSys_Start.BackColor = Color.Green; btn_ExerciseSys_Start.ForeColor = Color.White;
            TRM_start = false;
            if (serialPort_TRM.IsOpen)
            {
                if (rb_ExercisSys_normalMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_normal_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_normal_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_normal_vent_cooltime_addup.Text;
                    TRM_send(gamemode);
                }
                else if(rb_ExercisSys_easyMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_easy_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_easy_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_easy_vent_cooltime_addup.Text;
                    TRM_send(gamemode);
                
                }
                else if (rb_ExercisSys_hardMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_hard_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_hard_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_hard_vent_cooltime_addup.Text;
                    TRM_send(gamemode);

                }
                itembox1 = false;
                itembox2 = false;
                TRM_send("EA _A");
                TRM_send("EL _EOFF");
                TRM_send("ET _S");
                //TRM_send("EL _WON\n");
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_SetupMode_Click(object sender, EventArgs e)    //'훈련소 장치 정비' 버튼 클릭
        {
            lb_Exercise_progress.Text = "정비모드";
            btn_ExerciseSys_Start.Text = "훈련소\n시작";
            btn_ExerciseSys_Start.BackColor = Color.Green; btn_ExerciseSys_Start.ForeColor = Color.White;
            TRM_start = false;
            ExerciseRm_status = "";
            TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머 TRM 장치 타이머 정지
            TRM_MainTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM 전체 시간타이머 정지
            TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
            lb_ExerciseSys_Clock.Text = "00:00";                                                      //남은 시간 출력
            lb_ExerciseSys_maintime.Text = "0:00";
            lb_ExerciseSys_subtime.Text = "0:00";
            itembox1 = false;
            itembox2 = false;
            trm_main_time = 0;                                                                      //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
            trm_time = 0;                                                                           //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
            trm_device_time = 0;                                                                    //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수

            if (serialPort_TRM.IsOpen)
            {
                itembox1 = false;
                itembox2 = false;
                TRM_send("EA _S");
                TRM_send("EC _OFF");
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_timerStart_Click(object sender, EventArgs e)   //'훈련소 타이머 시작' 버튼 클릭
        {
            if (serialPort_TRM.IsOpen)
            {
                ExerciseRm_status = "";
                TRM_ThreadTimer.Change(0, 1000);                                    // timer_ExerciseSys.Enabled = true;//(타이머) TRM 장치 타이머 시작   
                TRM_MainTimer.Change(0, 1000);                                      // timer_ExerciseSys.Enabled = true;//(타이머) TRM 전체 시간타이머 시작 
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_timerStop_Click(object sender, EventArgs e)    //'훈련소 타이머 정지' 버튼 클릭
        {
            TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머 TRM 장치 타이머 정지
            TRM_MainTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM 전체 시간타이머 정지
            TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
        }

        private void btn_ExerciseSys_MovingOn_Click(object sender, EventArgs e)     //'훈련소 MOVING ON' 버튼 클릭
        {
            TRM_send("EI1_O");
            TRM_send("EI2_O");
        }

        private void btn_ExerciseSys_Stop_Click(object sender, EventArgs e)         //'훈련소 정지' 버튼 클릭
        {
            ExerciseRm_status = "";
            TRM_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머 TRM 장치 타이머 정지
            TRM_MainTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //TRM_start = false; //(타이머) TRM 전체 시간타이머 정지
            TRM_DeviceTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //decivetimer 동작 정지
            lb_ExerciseSys_Clock.Text = "00:00";                                                      //남은 시간 출력
            lb_ExerciseSys_maintime.Text = "0:00";
            lb_ExerciseSys_subtime.Text = "0:00";
            itembox1 = false;
            itembox2 = false;
            trm_main_time = 0;                                                                      //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
            trm_time = 0;                                                                           //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
            trm_device_time = 0;                                                                    //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
            TRM_start = false;
            btn_ExerciseSys_Start.Text = "훈련소\n시작";
            btn_ExerciseSys_Start.BackColor = Color.Green; btn_ExerciseSys_Start.ForeColor = Color.White;
        }

        private void btn_ExerciseSys_ExerciseRmOn_Click(object sender, EventArgs e) //'훈련소 조명 ON' 버튼 클릭
        {
            TRM_send("ELE_EON");
        }

        private void button26btn_ExerciseSys_LightOff_Click(object sender, EventArgs e)//'훈련소 조명 OFF' 버튼 클릭
        {
            TRM_send("ELE_EOFF");
        }

        private void btn_ExerciseSys_funcA_Click(object sender, EventArgs e)        //'대기공간 조명 ON' 버튼 클릭
        {
            TRM_send("ELW_WON");
        }

        private void btn_ExerciseSys_WaitRmOff_Click(object sender, EventArgs e)    //'대기공간 조명 OFF' 버튼 클릭
        {
            TRM_send("ELW_WOFF");
        }
        private String ExerciseSys_cbDevicceName_sel()
        {
            switch (cb_ExerciseSys_DeviceName.SelectedIndex)
            {
                case 0: return "A _";//ALL
                case 1: return "G _";
                case 2: return "E _";
                case 3: return "I1_";
                case 4: return "I2_";
                case 5: return "R _";
                case 6: return "D _";
                case 7: return "V _";
                case 8: return "T _";
                case 9: return "M _";
                case 10: return "C _";
                case 11: return "LE_";
                case 12: return "LT_";
                default: return "A _";
            }
        }
        private String ExerciseSys_cbDevicceState_sel()
        {
            switch (cb_ExerciseSys_DeivceState.SelectedIndex)
            {
                case 0: return "A"; //장치 연결
                case 1: return "R"; //장치 활성화
                case 2: return "S"; //장치 세팅
                case 3: return "C"; //장치 연결확인
                case 4: return "B"; //봉쇄 활성화
                case 5: return "O"; //장치 오픈
                case 6: return "L"; //장치 세팅
                case 7: return "V"; //장치 연결확인
                case 8: return "E"; //봉쇄 활성화
                case 9: return "F"; //장치 오픈
                case 10: return "E";//장치 오픈
                case 11: return "K";//
                case 12: return "N";//
                case 13: return "D";//
                case 14: return "ON";
                case 15: return "OFF";
                case 16: return "W";    //워치독 리셋
                case 17: return "Q";    //아이템박스 빠른 리셋
                case 18: return "I"; // 도어 침입시도 멈추기
                case 19: PCM_send("ED _!"); return "S"; //훈련소 도어 일반모드로 리셋

                default: return "A";
            }
        }

        private void btn_ExerciseSys_DeviceSend_Click(object sender, EventArgs e)
        {
            String send_Arduio = "E";
            send_Arduio += ExerciseSys_cbDevicceName_sel();
            send_Arduio += ExerciseSys_cbDevicceState_sel();
            if(send_Arduio.Equals("ED _R"))
                TRM_send("ED _A");
            else if (send_Arduio.Equals("ET _R"))
                TRM_send("ET _H");
            TRM_send(send_Arduio);
            Console.WriteLine(send_Arduio);
        }
        private void ExerciseSys_cbScenrio_sel(int ScenarioIndex)
        {
            switch (ScenarioIndex)
            {
                case 0: TRM_send("VE1"); TRM_send("EA _A"); TRM_send("EL _EOFF"); TRM_send("EL _WON"); TRM_send("ED _E"); break;  //#1
                case 1: TRM_send("VE2"); TRM_send("ED _E"); break;  //#2
                case 2: TRM_send("VE3"); TRM_send("EM _M1");break;  //#3
                case 3: TRM_send("VE4"); TRM_send("EM _M2"); break;  //#4
                case 4: TRM_send("VE5"); break;  //#5
                case 5: TRM_send("VE6"); TRM_send("EM _M3"); break;  //#6
                case 6: TRM_send("VE7_1"); break;  //#7-1
                case 7: TRM_send("VE7_2"); break;  //#7-2
                case 8: TRM_send("VE7_3"); break;  //#7-3
                case 9: TRM_send("VE8"); TRM_send("EM _M4"); break;  //#8
                case 10: TRM_send("VE9_1"); TRM_send("EM _M4-2"); TRM_send("EC _ON"); lb_Exercise_progress.Text = "캐비넷오픈"; break;  //#9-1
                case 11: TRM_send("VE9_2"); TRM_send("EM _M4-3"); TRM_send("EL _EON"); break;  //#9-2
                case 12: TRM_send("VE9_3"); TRM_send("EL _EOFF"); TRM_send("EM _M4-4"); using_device = 'R'; break;  //#9-3
                case 13: TRM_send("VE9_4"); TRM_send("EM _M4-5"); TRM_send("EL _EON"); break;  //#9-4
                case 14: TRM_send("VE9_5"); break;  //#9-5
                case 15: TRM_send("VE9_6"); break;  //#9-6
                case 16: TRM_send("VE9_7"); break;  //#9-7
                case 17: TRM_send("VE10"); TRM_send("EL _EOFF"); TRM_send("EM _M5"); break;  //#10
                case 18: TRM_send("VE11"); break;  //#11
                case 19: TRM_send("VE12"); break;  //#12
                case 20: TRM_send("VE13"); TRM_send("EL _EON"); break;  //#13
                case 21: TRM_send("VE14"); break;  //#14
                case 22: TRM_send("VE15"); break;  //#15
                case 23: TRM_send("VE16_1"); TRM_send("EM _M6"); break;  //#16-1
                case 24: TRM_send("VE16_2"); TRM_send("EM _M6"); break;  //#16-2
                case 25: TRM_send("VE17"); break;  //#17
                case 26: TRM_send("VE18"); TRM_send("EL _EOFF"); TRM_send("EM _M7"); break;  //#18
                case 27: TRM_send("VE19"); break;  //#19
                case 28: TRM_send("VE20"); TRM_send("EL _EON"); break;  //#20
                case 29: TRM_send("VE21"); break;  //#21
                case 30: TRM_send("VE22_1"); break;  //#22-1
                case 31: TRM_send("VE22_2"); TRM_send("EL _EOFF"); TRM_send("EM _M8"); break;  //#22-2
                case 32: TRM_send("VE23"); TRM_send("EM _M9"); break;  //#23
                case 33: TRM_send("VE24"); TRM_send("EM _M9-2"); break;  //#24
                case 34: TRM_send("VE25_1"); TRM_send("EL _EON"); TRM_send("EM _M9-3"); break;  //#25-1
                case 35: TRM_send("VE25_2"); TRM_send("EM _M9-3"); break;  //#25-2
                case 36: TRM_send("VE25_3"); TRM_send("EM _M9-3"); break;  //#25-3
                case 37: TRM_send("VE26_1"); TRM_send("EL _EON"); break;  //#26-1
                case 38: TRM_send("VE26_2"); TRM_send("EM _M9-4"); break;  //#26-2
                case 39: TRM_send("VE27"); TRM_send("EM _M10"); break;  //#27
                case 40: TRM_send("VE28"); break;  //#28
                case 41: TRM_send("VE29"); break;  //#29
                case 42: TRM_send("VE30"); TRM_send("EM _M11"); break;  //#30
                case 43: TRM_send("VE31"); break;  //#31
                case 44: TRM_send("VE32"); break;  //#32
                case 45: TRM_send("VE33"); TRM_send("EM _M12-2"); break;  //#33
                case 46: TRM_send("VE34"); TRM_send("EM _M13"); break;  //#34
                case 47: TRM_send("VE35"); break;  //#35
                case 48: TRM_send("VE36"); break;  //#36
                case 100: TRM_send("EM _OFF"); break; //#1000
            }
        }
        private void btn_ExerciseSys_ScenarioSend_Click(object sender, EventArgs e)
        {
            if (serialPort_TRM.IsOpen)
            {
                switch (cb_ExerciseSys_Scenario.SelectedIndex)
                {
                    case 0: ExerciseRm_status = "Revival Open"; break;
                    case 1: ExerciseRm_status = "Itembox1 Open Itembox2 Open"; break;
                    case 2: ExerciseRm_status = "Generator Fix"; break;
                    case 3: ExerciseRm_status = "Door Lock"; break;
                    case 4: ExerciseRm_status = "Escape Open"; break;
                    case 5: ExerciseRm_status = "Duct Open"; break;
                }
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_ExerciseSys_VideoStart_Click(object sender, EventArgs e)
        {
            string btnname = btn_ExerciseSys_VideoStart.Text;
            /*
            if (btnname == "영상시작")
            {
                btn_ExerciseSys_VideoStart.Text = "애니ON";
            }
            else if(btnname == "애니ON")
            {
                btn_ExerciseSys_VideoStart.Text ="영상시작";
            }
            */
        
            if (rb_GameSys_DayMode.Checked == true)
            {
                TRM_send("EP _D");
            }
            else if (rb_GameSys_NightMode.Checked == true)
            {
                TRM_send("EP _N");
            }
        }
        private void btn_ExerciseSys_AnimationOn_Click(object sender, EventArgs e)
        {
            TRM_send("EP _F");
        }

        private void btn_ExerciseSys_VideoStop_Click(object sender, EventArgs e)
        {
            TRM_send("EP _R");
        }

        private void btn_ExerciseSys_ScreenUp_Click(object sender, EventArgs e)
        {
            TRM_send("ES _U");
        }

        private void btn_ExerciseSys_ScreenDown_Click(object sender, EventArgs e)
        {
            TRM_send("ES _D");
        }

        private void btn_ExerciseSys_DoorOpen_Click(object sender, EventArgs e)
        {
            TRM_send("ES _O");
        }

        private void btn_ExerciseSys_DoorClose_Click(object sender, EventArgs e)
        {
            TRM_send("ES _C");
        }

        private void btn_GameSys_AL_ON_Click(object sender, EventArgs e)
        {
            PCM_send("AL _N");
        }

        private void btn_GameSys_AL_Off_Click(object sender, EventArgs e)
        {
            PCM_send("AL _F");
        }
        private void modeChange()
        {
            if (rb_GameSys_NormalMode.Checked == true)
            {
                lb_GameSys_mode.Text = "일반 MODE";
                String gamemode = "";
                gamemode = "AG _M1_" + tb_normal_generator_starter.Text;
                PCM_send(gamemode);
                gamemode = "AG _M2_" + tb_normal_generator_B1.Text + "," + tb_normal_generator_B2.Text + "," + tb_normal_generator_B3.Text;
                PCM_send(gamemode);

                gamemode = "AI _M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AE _M1_" + tb_normal_escape_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AV _M1_" + tb_normal_vent_cooltime.Text;
                PCM_send(gamemode);
                gamemode = "AV _M2_" + tb_normal_vent_cooltime_addup.Text;
                PCM_send(gamemode);
                PCM_send("AD _TL_7");

                if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked) //7,8인 모드시에 제단 파괴 가능하게 하기 위해
                {
                    PCM_send("AD _H");
                    PCM_send("LT _H");
                }
            }
            else if (rb_GameSys_EasyMode.Checked == true)
            {
                lb_GameSys_mode.Text = "뉴비 MODE";
                String gamemode = "";
                gamemode = "AG _M1_" + tb_easy_generator_starter.Text;
                PCM_send(gamemode);
                gamemode = "AG _M2_" + tb_easy_generator_B1.Text + "," + tb_easy_generator_B2.Text + "," + tb_easy_generator_B3.Text;
                PCM_send(gamemode);

                gamemode = "AI _M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AE _M1_" + tb_easy_escape_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AV _M1_" + tb_easy_vent_cooltime.Text;
                PCM_send(gamemode);
                gamemode = "AV _M2_" + tb_easy_vent_cooltime_addup.Text;
                PCM_send(gamemode);
                PCM_send("AD _TL_7");

                if (rb_GameSys_7P.Checked || rb_GameSys_8P.Checked) //7,8인 모드시에 제단 파괴 가능하게 하기 위해
                {
                    PCM_send("AD _H");
                    PCM_send("LT _H");
                }
            }
            else if (rb_GameSys_HardMode.Checked == true)
            { 
                lb_GameSys_mode.Text = "찌발 MODE";
                String gamemode = "";
                PCM_send("AG _N");
                gamemode = "AG _M1_" + tb_hard_generator_starter.Text;
                PCM_send(gamemode);
                gamemode = "AG _M2_" + tb_hard_generator_B1.Text + "," + tb_hard_generator_B2.Text + "," + tb_hard_generator_B3.Text;
                PCM_send(gamemode);

                PCM_send("AI _N");
                gamemode = "AI _M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                PCM_send(gamemode);
                gamemode = "AI _M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AE _M1_" + tb_hard_escape_Btime.Text;
                PCM_send(gamemode);

                gamemode = "AV _M1_" + tb_hard_vent_cooltime.Text;
                PCM_send(gamemode);
                gamemode = "AV _M2_" + tb_hard_vent_cooltime_addup.Text;
                PCM_send(gamemode);


                PCM_send("BF _FL_" + tb_hard_fogtime.Text);
                showtime_remaing_time = Int32.Parse(tb_hard_door_showtime.Text);
                lb_showtime_counter.Text = (showtime_remaing_time / 60).ToString("0") + ":" + (showtime_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업

                PCM_send("AD _N");
                PCM_send(("AD _TL_" + tb_hard_door_taggertime.Text));
                PCM_send("LT _H");
                PCM_send("AD _H");

                PCM_send("AR _N");
            }
            if (rb_GameSys_HardMode.Checked == false)
            {
                if (cb_GameSys_deviceLight_auto.Checked)
                {
                    if (rb_GameSys_DayMode.Checked == true)
                    {
                        PCM_send("AG _D");
                        PCM_send("AI _D");
                        PCM_send("AR _D");
                        PCM_send("AD _D");
                        PCM_send("AL _N");
                    }
                    else if (rb_GameSys_NightMode.Checked == true)
                    {
                        PCM_send("AG _N");
                        PCM_send("AI _N");
                        PCM_send("AR _N");
                        PCM_send("AD _N");
                        PCM_send("AL _F");
                    }
                }
            }
        }

        private void btn_GameSys_rndBlock_Click(object sender, EventArgs e)
        {
            blockdevice_rand1 = rand.Next(0, 2);
            switch (blockdevice_rand1)
            {
                case 0: lb_block_1.Text = "아이템"; break;
                case 1: lb_block_1.Text = "생명"; break;
            }
            blockdevice_rand2 = rand.Next(0, 3);
            switch (blockdevice_rand2)
            {
                case 0: lb_block_2.Text = "도어LV1"; lb_block_3.Text = "도어LV2"; lb_block_4.Text = "도어LV3"; break;
                case 1: lb_block_2.Text = "덕트LV1"; lb_block_3.Text = "덕트LV2"; lb_block_4.Text = "덕트LV3"; break;
                case 2: lb_block_2.Text = "발전LV1"; lb_block_3.Text = "발전LV2"; lb_block_4.Text = "발전LV3"; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((String)"IDEA by 씨영");
        }

        private void btn_TaggerSkill_timeadd_Click(object sender, EventArgs e)
        {
            taggerskill_remaing_time += 30;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
        }

        private void btn_TaggerSkill_timesubraction_Click(object sender, EventArgs e)
        {
            taggerskill_remaing_time -= 30;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
        }

        private void btn_TaggerSkill_timereset_Click(object sender, EventArgs e)
        {
            TaggerSkill_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); //술래스킬 타이머 정지
            taggerskill_remaing_time = TAGGERSKILL_TIME * 60;                                               //술래스킬 타이머 리셋
            lb_TaggerSkill_timer.Text = lb_TaggerSkill_timer.Text = (taggerskill_remaing_time / 60).ToString("00") + ":" + (taggerskill_remaing_time % 60).ToString("00");   //술래스킬 타이머 리셋
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: PCM_send("VS1"); break;
                case 1: PCM_send("VS2"); break;
                case 2: PCM_send("VS3"); break;
                case 3: PCM_send("VS4"); break;
                case 4: PCM_send("VS5"); break;

            }
        }

        private void btn_serialPort_PCMerr_clipboardcopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_serialPort_PCM_err.Text);
            MessageBox.Show((String)"클립보드에 복사되었습니다.");
        }

        private void btn_setting_light_Click(object sender, EventArgs e)
        {
            if (btn_setting_light.Text == "청소등 ON")
            {
                TRM_send("EB _N");
                btn_setting_light.BackColor = Color.Red;
                btn_setting_light.Text = "청소등 OFF";
            }
            else if(btn_setting_light.Text == "청소등 OFF"){ 
                TRM_send("EB _F");
                btn_setting_light.BackColor = Color.Green;
                btn_setting_light.Text = "청소등 ON"; 
            }
            else if (btn_setting_light.Text == "청소등 리셋")
            {
                TRM_send("EB _N");
                btn_setting_light.BackColor = Color.Black;
                btn_setting_light.Text = "청소등 리셋";
            }
        }

        private void btn_ExerciseSys_SkipMode_Click(object sender, EventArgs e)
        {
            TRM_send("EA _R");
            TRM_send("ET _H");
            TRM_send("ET _B");
            TRM_send("ELE_EON");
            TRM_send("ELW_WON");
            TRM_MainTimer.Change(0, 1000);
        }

        private void btn_ExerciseSys_trainroomMode_Click(object sender, EventArgs e)
        {
            if (serialPort_TRM.IsOpen)
            {
                if (rb_ExercisSys_normalMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_normal_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_normal_itembox_vibe1.Text + "," + tb_normal_itembox_vibe2.Text + "," + tb_normal_itembox_vibe3.Text + "," + tb_normal_itembox_vibe4.Text + "," + tb_normal_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_normal_itembox_ans1.Text + "," + tb_normal_itembox_ans2.Text + "," + tb_normal_itembox_ans3.Text + "," + tb_normal_itembox_ans4.Text + "," + tb_normal_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_normal_itembox_anscnt.Text + "," + tb_normal_itembox_ansarea.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text + "," + tb_normal_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_normal_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_normal_vent_cooltime_addup.Text;
                    TRM_send(gamemode);
                }
                else if (rb_ExercisSys_easyMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_easy_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_easy_itembox_vibe1.Text + "," + tb_easy_itembox_vibe2.Text + "," + tb_easy_itembox_vibe3.Text + "," + tb_easy_itembox_vibe4.Text + "," + tb_easy_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_easy_itembox_ans1.Text + "," + tb_easy_itembox_ans2.Text + "," + tb_easy_itembox_ans3.Text + "," + tb_easy_itembox_ans4.Text + "," + tb_easy_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_easy_itembox_anscnt.Text + "," + tb_easy_itembox_ansarea.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text + "," + tb_easy_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_easy_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_easy_vent_cooltime_addup.Text;
                    TRM_send(gamemode);

                }
                else if (rb_ExercisSys_hardMode.Checked)
                {
                    String gamemode = "";
                    gamemode = "EG _M1_" + tb_hard_generator_starter.Text;
                    TRM_send(gamemode);

                    gamemode = "EI1_M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI1_M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EI2_M1_" + tb_hard_itembox_vibe1.Text + "," + tb_hard_itembox_vibe2.Text + "," + tb_hard_itembox_vibe3.Text + "," + tb_hard_itembox_vibe4.Text + "," + tb_hard_itembox_vibe5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M2_" + tb_hard_itembox_ans1.Text + "," + tb_hard_itembox_ans2.Text + "," + tb_hard_itembox_ans3.Text + "," + tb_hard_itembox_ans4.Text + "," + tb_hard_itembox_ans5.Text;
                    TRM_send(gamemode);
                    gamemode = "EI2_M3_" + tb_hard_itembox_anscnt.Text + "," + tb_hard_itembox_ansarea.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text + "," + tb_hard_itembox_Btime.Text;
                    TRM_send(gamemode);

                    gamemode = "EV _M1_" + tb_hard_vent_cooltime.Text;
                    TRM_send(gamemode);
                    gamemode = "EV _M2_" + tb_hard_vent_cooltime_addup.Text;
                    TRM_send(gamemode);


                }
            }
        }

        private void tb_hard_door_showtime_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_showtime_Click(object sender, EventArgs e)
        {
            showtime_remaing_time = Int32.Parse(tb_hard_door_showtime.Text);
            lb_showtime_counter.Text = (showtime_remaing_time / 60).ToString("0") + ":" + (showtime_remaing_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
        }
    }
}
