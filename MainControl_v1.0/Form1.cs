using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Timer = System.Threading.Timer;

namespace MainControl_v1._0
{
    public partial class MainControl : Form
    {
        //private SerialPort serialPort_PCM = new SerialPort();
        //private SerialPort serialPort_IOT = new SerialPort();
        //private SerialPort serialPort_TRM = new SerialPort();

        public MainControl()
        {
            InitializeComponent();
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
                serialPort_PCM.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
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
            string data_pcm = serialPort_PCM.ReadTo("\n");     //원래:ReadExisting 으로 사용햇음    //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //tb_serialPort_PCM.AppendText("RAW: " + data_pcm+"why"+"\r\n");
            if (data_pcm.StartsWith("lb"))
            {
                //Console.WriteLine(data_pcm);
                lb_string_split(data_pcm);
            }
            else
            {
                if ((data_pcm.Substring(data_pcm.Length - 2)).Contains("\b"))
                {
                    tb_serialPort_PCM.AppendText(data_pcm.Substring(0,data_pcm.Length - 2));
                }
                else
                {
                    tb_serialPort_PCM.AppendText(data_pcm + "\r\n");
                }//텍스트 박스에 시리얼 통신으로 받은 데이터 출력     
            }
        }
        private void lb_string_split(String PCM_STR)
        {
            String[] pcm_str = PCM_STR.Split('_');
            String lb_name = "";
            lb_name += pcm_str[0];
            lb_name += '_';
            lb_name += pcm_str[1];
            lb_name += "_state";

            switch (pcm_str[2][0])
            {
                case 'A':
                    lb_color_change(lb_name, "장치 연결",Color.Red, Color.White);
                    break;

                case 'R':
                    lb_color_change(lb_name, "장치 활성", Color.Yellow, Color.Black);
                    break;

                case 'S':
                    lb_color_change(lb_name, "장치 세팅", Color.White, Color.Black);
                    break;

                case 'B':
                    lb_color_change(lb_name, "봉쇄 가능", Color.Purple, Color.White);
                    break;
            }
        }
        private void lb_color_change(String lb_name, String text, Color lb_BackColor, Color lb_FontColor)
        {
            this.Controls.Find(lb_name, true).FirstOrDefault().Text = text;
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

                lb_serialPort_PCM.Text = "포트가 열렸습니다.";
                tb_serialPort_PCM.Text = "FuzzyLine Studio presents \r\nHIDE AND SEEK OS v1.0 \r\nprogramed by BBangJun\r\n";
                cb_serialPort_PCM.Enabled = false;                                                  //COM포트설정 콤보박스 비활성화
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
            string data_iot = serialPort_IOT.ReadTo("\n");                                        //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //char ReceiveData = (char)serialPort_IOT.ReadByte();                                   //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //textBox1.Text = "\r\n" + ReceiveData.ToString();
            tb_serialPort_IOT.AppendText(data_iot);                                                 //텍스트 박스에 시리얼 통신으로 받은 데이터 출력                                             
            //textBox1.Text = textBox1.Text + string.Format("{0:X2}", ReceiveData);                 //int 형식을 string형식으로 변환하여 출력
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
                serialPort_TRM.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
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
            string data_trm = serialPort_TRM.ReadTo("\n");                                  //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //char ReceiveData = (char)serialPort_TRM.ReadByte();                                   //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //textBox1.Text = "\r\n" + ReceiveData.ToString();
            tb_serialPort_TRM.AppendText(data_trm);                                                 //텍스트 박스에 시리얼 통신으로 받은 데이터 출력                                             
            //textBox1.Text = textBox1.Text + string.Format("{0:X2}", ReceiveData);                 //int 형식을 string형식으로 변환하여 출력
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
        int game_remaing_time = GAMETIME * 60;                                                           //35*60; 남은시간 전체 초로 카운팅 저장하고 있는 변수
        int game_remaing_min = 0;                                                                        //0;     남은시간 MIN으로 가지고 있는 변수
        int game_remaing_sec = 0;                                                                        //0;     남은시간 SEC으로 가지고 있는 변수
        bool OS_start = false;                                                                      //fasle; OS시작했는지 안했는지 확인하는 변수
        uint headcount = 5;                                                                         //5;     몇명에서 플레이 하는지 저장하는 변수 기본세팅은 5명
        uint playmode = 1;                                                                          //1;     플레이 모드설정 easymode = 0; normalMode = 1; HardMode = 2; 
        uint playgroup = 1;                                                                         //1;     플레이 그룹설정 G1 = 1; G2 = 2; G3 = 3; 
        private void timer_GameSys_Tick(object sender, EventArgs e)
        {
            game_remaing_time -= 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            game_remaing_min = game_remaing_time / 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            game_remaing_sec = game_remaing_time % 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = game_remaing_min.ToString("00") + ":" + game_remaing_sec.ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            lb_GameSys_Clock.Text = remaing_show;                                                   //남은 시간 출력
            Gamesys_TimeAction();
        }

        private void Gamesys_TimeAction()
        {
            if (OS_start == true)
            {
                //처음 게임시작하고 나레이션if문
                switch (game_remaing_time)
                {
                    case ( (34 * 60) + 52):                              //34분 52초 일때
                        serialPort_PCM.Write("VO2\n");                      //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                        break;
                    case ((34 * 60) + 43):                              //34분 43초 일때
                        serialPort_PCM.Write("VO3\n");                      //(나레이션) VO3; 흩어져서 경계하세요
                        break;
                    case ((33 * 60) + 52):                              //33분 52초 일때
                        serialPort_PCM.Write("VO2\n");                      //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                        break;
                    case ((33 * 60) + 43):                              //33분 43초 일때
                        serialPort_PCM.Write("VO3\n");                      //(나레이션) VO3; 흩어져서 경계하세요
                        break;
                    case ((32 * 60) + 52):                              //32분 52초 일때
                        serialPort_PCM.Write("VO2\n");                      //(나레이션) VO2; 술래등장 전 까지는 장치사용이 불가합니다.
                        break;
                    case ((32 * 60) + 43):                              //32분 43초 일때
                        serialPort_PCM.Write("VO3\n");                      //(나레이션) VO3; 흩어져서 경계하세요
                        break;
                    case ((32 * 60) + 30):                              //32분 30초 일때
                        serialPort_PCM.Write("VO4\n");                      //(나레이션) VO4; 술래결정까지 30초 남았습니다. 
                        break;
                    case ((32 * 60) + 7):                               //32분 07초 일때
                        serialPort_PCM.Write("VO5\n");                      //(나레이션) VO5; 술래결정까지 5초 남았습니다. 
                        break;
                    case ((32 * 60) + 0):                               //32분 00초 일때
                        serialPort_PCM.Write("VO6\n");                      //(나레이션) VO6; 술래가 결정되었습니다. 
                        serialPort_PCM.Write("AA _G\n");
                        break;
                    case ((30 * 60) + 0):                               //30분 00초 일때
                        serialPort_PCM.Write("VN30\n");                     //(나레이션) 30분 남았습니다. 
                        break;
                    case ((29 * 60) + 0):                                 //29분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((26 * 60) + 0):                               //26분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((25 * 60) + 0):                               //25분 00초 일때
                        serialPort_PCM.Write("BLOCK_ON1\n");                //(통신) 술래의 1번째 능력 활성화   
                        break;
                    case ((23 * 60) + 0):                               //23분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((20 * 60) + 0):                               //20분 00초 일때
                        serialPort_PCM.Write("VN20\n");                      //(나레이션) 20분 남았습니다.
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        serialPort_PCM.Write("BLOCK_ON2\n");                //(통신) 술래의 2번째 능력 활성화 
                        break;
                    case ((17 * 60) + 0):                               //17분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((15 * 60) + 0):                               //15분 00초 일때
                        serialPort_PCM.Write("BLOCK_ON3\n");                //(통신) 술래의 3번째 능력 활성화
                        break;
                    case ((14 * 60) + 0):                               //14분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((11 * 60) + 0):                               //11분 00초 일때
                        serialPort_PCM.Write("R_on\n");                     //(통신) 생명장치 한개 활성화 
                        break;
                    case ((10 * 60) + 0):                               //10분 00초 일때
                        serialPort_PCM.Write("VN10\n");                      //(나레이션) 10분 남았습니다
                        break;
                    case ((5 * 60) + 0):                                //5분 00초 일때
                        serialPort_PCM.Write("VN5\n");                       //(나레이션) 5분 남았습니다
                        break;
                    case ((3 * 60) + 0):                                //3분 00초 일때
                        serialPort_PCM.Write("VN3\n");                       //(나레이션) 3분 남았습니다
                        break;
                    case ((1 * 60) + 0):                                //1분 00초 일때
                        serialPort_PCM.Write("VN1\n");                       //(나레이션) 1분 남았습니다
                        break;
                    case (0):                                           //0분 00초 일때
                        serialPort_PCM.Write("VO14\n");                     //(나레이션) 탈출제한 시간이 끝났습니다. 
                        serialPort_PCM.Write("AF\n");                       //(통신) 전체 장치 세팅모드로 전환
                        OS_start = false;                                   // OS_START BOOL변수 종료
                        timer_GameSys.Enabled = false;                      // 게임 타이머 정지
                        MessageBox.Show((String)"TIME OVER");               // 타임 오버 메세지창 출력
                        break;
                }
            }
        }
        private void Radiobutton_PlayPeople()
        {
            if (rb_GameSys_4P.Checked == true)                            // 4p모드가 선택되어있을때
            {
                headcount = 4;                                              //플레이 멤버 4명                
                PCM_send("PP_4\n");                                         //(통신) 플레이 멤버 4명 전송
            }
            else if (rb_GameSys_5P.Checked == true)                     // 5p모드가 선택되어있을때
            {
                headcount = 5;                                              //플레이 멤버 5명          
                PCM_send("PP_5\n");                                         //(통신) 플레이 멤버 5명 전송
            }
            else if (rb_GameSys_6P.Checked == true)                     // 6p모드가 선택되어있을때
            {
                headcount = 6;                                              //플레이 멤버 6명
                PCM_send("PP_6\n");                                         //(통신) 플레이 멤버 6명 전송
            }
        }
        private void Radiobutton_PlayMode()
        {
            if (rb_GameSys_EasyMode.Checked == true)                    // 뉴비 모드가 선택되어있을때
            {
                playmode = 1;                                               // 뉴비모드 = 0;
                PCM_send("PM_1\n");                                         // (통신) 플레이 모드 PM_0으로 전송
            }
            else if (rb_GameSys_NormalMode.Checked == true)             // 일반 모드가 선택되어있을때
            {
                playmode = 2;                                               // 뉴비모드 = 1;
                PCM_send("PM_2\n");                                         // (통신) 플레이 모드 PM_1으로 전송
            }
            else if (rb_GameSys_HardMode.Checked == true)               // 고인물 모드가 선택되어있을때
            {
                playmode = 3;                                               // 뉴비모드 = 2;
                PCM_send("PM_3\n");                                         // (통신) 플레이 모드 PM_2으로 전송
            }
        }
        private void Radiobutton_PlayGroup()
        {
            timer_IotSys.Enabled = true;                                //(타이머) iot타이머 시작
            if (rb_IOT_Group1.Checked == true)                          // IOT그룹 G1이 선택되었을때
            {
                playgroup = 1;                                              // IOT GROUP 1번으로 저장
                IOT_send("PG_1\n");                                         //(IOT통신) IOT통신으로 PG1 전송
                Radiobutton_Group1();                                       //(IOT함수) 그룹 1번에서 누가 술래인지 결정해주는 함수
            }
            else if (rb_IOT_Group2.Checked == true)                     // IOT그룹 G2이 선택되었을때
            {
                playgroup = 2;                                              // IOT GROUP 2번으로 저장
                IOT_send("PG_2\n");                                         //(IOT통신) IOT통신으로 PG2 전송
                Radiobutton_Group2();                                       //(IOT함수) 그룹 2번에서 누가 술래인지 결정해주는 함수
            }
            else if (rb_IOT_Group3.Checked == true)                     // IOT그룹 G3이 선택되었을때
            {
                playgroup = 3;                                              // IOT GROUP 3번으로 저장
                IOT_send("PG_3\n");                                         //(IOT통신) IOT통신으로 PG3 전송
                Radiobutton_Group3();                                       //(IOT함수) 그룹 3번에서 누가 술래인지 결정해주는 함수
            }
        }
        private void btn_GameSys_GameStart_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
            {
                Radiobutton_PlayGroup();                                        //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                Radiobutton_PlayPeople();                                       //(함수) 플레이 인원 설정된데로 통신 보내기
                Radiobutton_PlayMode();                                         //(함수) 플레이 모드 설정된데도 통신 보내기
                switch (playgroup)
                {
                    case 1:
                        serialPort_IOT.Write("P1GA_A\n");                                   //(IOT통신) iot글러브 3분 술래결정
                        break;
                    case 2:
                        serialPort_IOT.Write("P2GA_A\n");                                   //(IOT통신) iot글러브 3분 술래결정
                        break;
                    case 3:
                        serialPort_IOT.Write("P3GA_A\n");                                   //(IOT통신) iot글러브 3분 술래결정
                        break;
                }
                serialPort_PCM.Write("VO1\n");                                  //(나레이션)탈출제한 시간이 끝났습니다.
                timer_GameSys.Enabled = true;                                   //(타이머) 타이머 시작
                OS_start = true;                                                //(변수) OS시작
                game_remaing_time = GAMETIME * 60;                              //(변수) 남은시간 초기화
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");

        }

        private void btn_GameSys_ReadyMode_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
            {
                serialPort_PCM.Write("AA_R\n");                                   //(통신) 전체장치 연결 (비활성화)
                game_remaing_time = GAMETIME * 60;                              //(변수) 남은시간 초기화
                lb_GameSys_Clock.Text = "35:00";                                //남은시간 35:00로 출력
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_GameSys_SetupMode_Click(object sender, EventArgs e)
        {
            PCM_send("AA_S\n");                                                   //(통신) 전체장치 세팅 모드 (비활성화)
        }

        private void btn_GameSys_GameStop_Click(object sender, EventArgs e)
        {
            serialPort_PCM.Write("AA_S\n");                                       //(통신) 전체장치 세팅 모드 (비활성화)
            timer_GameSys.Enabled = false;                                      //(타이머) 타이머 정지
            OS_start = false;                                                   //(변수) OS종료
        }

        private void btn_GameSys_VideoPlay_Click(object sender, EventArgs e)
        {
            PCM_send("WP_P\n");                                                   //(통신) 영상재생
        }

        private void btn_GameSys_OS_Start_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
            {
                Radiobutton_PlayGroup();                                        //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                Radiobutton_PlayPeople();                                       //(함수) 플레이 인원 설정된데로 통신 보내기
                Radiobutton_PlayMode();                                         //(함수) 플레이 모드 설정된데도 통신 보내기
                serialPort_PCM.Write("VO1\n");                                  //(나레이션)탈출제한 시간이 끝났습니다.
                timer_GameSys.Enabled = true;                                   //(타이머) 타이머 시작
                OS_start = true;                                                //(변수) OS시작
                game_remaing_time = GAMETIME * 60;                              //(변수) 남은시간 초기화
            }
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_GameSys_SelfRevive_Click(object sender, EventArgs e)
        {
            PCM_send("AR_B\n");                                                 //(통신) 부활장치 전체 자가부활 모드
        }

        private void btn_GameSys_5min_add_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                game_remaing_time += (5 * 60);                                  //(타이머) 타이머 5분 추가 
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }
        private void btn_GameSys_1min_add_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                game_remaing_time += (1 * 60);                                  //(타이머) 타이머 1분 추가
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");

        }

        private void btn_GameSys_timerStart_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                timer_GameSys.Enabled = true;                                   //(타이머) 타이머 시작
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_GameSys_timerStop_Click(object sender, EventArgs e)
        {
            if (serialPort_PCM.IsOpen)
                timer_GameSys.Enabled = false;                                   //(타이머) 타이머 정지
            else
                MessageBox.Show((String)"PCM 통신 연결을 먼저 진행해주세요!");
        }

        private char one_itemforROOM(ComboBox cb_device_room)
        {
            switch (cb_device_room.SelectedIndex)
            {
                case 0: //ALL
                    return 'A';

                case 1: //BG
                    return 'B';

                case 2: //LG
                    return 'L';

                case 3: //CG
                    return 'C';

                case 4: //SG
                    return 'S';

                case 5: //TG
                    return 'T';

                default:
                    return 'A';
            }
        }
        private char two_itemforROOM(ComboBox cb_device_room)
        {
            switch (cb_device_room.SelectedIndex)
            {
                case 0: //ALL
                    return 'A';

                case 1: //BAMBOO
                    return 'B';
                case 2: //BAMBOO
                    return 'B';

                case 3: //LIVING
                    return 'L';
                case 4: //LIVING
                    return 'L';

                case 5: //CELLERAGE
                    return 'C';
                case 6: //CELLERAGE
                    return 'C';

                case 7: //SLEEPING
                    return 'S';
                case 8: //SLEEPING
                    return 'S';

                case 9: //TOILET
                    return 'T';
                case 10: //TOILET
                    return 'T';

                default:
                    return 'A';
            }
        }
        private char itemforState(ComboBox cb_device_state)
        {
            switch (cb_device_state.SelectedIndex)
            {
                case 0: //장치 연결
                    return 'A';

                case 1: //장치 활성화 
                    return 'R';

                case 2: //장치 세팅
                    return 'S';

                case 3: //장치 연결확인
                    return 'C';

                case 4: //봉쇄 활성화
                    return 'B';

                default:
                    return 'A';
            }
        }
        private void btn_Generator_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += one_itemforROOM(cb_Generator_name);
            send_Arduio += "G _";
            send_Arduio += itemforState(cb_Generator_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
        }

        private void btn_Escape_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += one_itemforROOM(cb_Escape_name);
            send_Arduio += "E _";
            send_Arduio += itemforState(cb_Escape_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
        }

        private void btn_Revive_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += two_itemforROOM(cb_Revive_name);

            Console.WriteLine(cb_Revive_name.SelectedIndex);

            if (cb_Revive_name.SelectedIndex == 0)
                send_Arduio += "R _";
            else if(cb_Revive_name.SelectedIndex%2 == 1)
                send_Arduio += "R1_";
            else if (cb_Revive_name.SelectedIndex % 2 == 0)
                send_Arduio += "R2_";
            else
                send_Arduio += "why_";
            send_Arduio += itemforState(cb_Revive_state);
            send_Arduio += '\n';
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
            send_Arduio += itemforState(cb_Itembox_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
        }

        private void btn_Door_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            switch (cb_Door_name.SelectedIndex)
            {
                case 0:
                    send_Arduio += 'A';
                    break;
                case 1:
                    send_Arduio += 'B';
                    break;
                case 2:
                    send_Arduio += 'L';
                    break;
                case 3:
                    send_Arduio += 'S';
                    break;
                case 4:
                    send_Arduio += 'T';
                    break;
            }
            send_Arduio += "D _";
            send_Arduio += itemforState(cb_Door_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
        }

        private void btn_Vent_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            switch (cb_Vent_name.SelectedIndex)
            {
                case 0: //장치 연결
                    send_Arduio += "AV _";
                    break;
                case 1: //장치 활성화 
                    send_Arduio += "BV1_";
                    break;
                case 2: //장치 세팅
                    send_Arduio += "BV2_";
                    break;
                case 3: //장치 연결확인
                    send_Arduio += "LV _";
                    break;
                case 4: //봉쇄 활성화
                    send_Arduio += "CV _";
                    break;
                case 5: //봉쇄 활성화
                    send_Arduio += "SV _";
                    break;
                case 6: //봉쇄 활성화
                    send_Arduio += "TV _";
                    break;
            }
            send_Arduio += itemforState(cb_Vent_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
        }

        private void btn_Temple_send_Click(object sender, EventArgs e)
        {
            String send_Arduio = "";
            send_Arduio += "LT _";
            send_Arduio += itemforState(cb_Temple_state);
            send_Arduio += '\n';
            PCM_send(send_Arduio);
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
            if (rb_G1P1.Checked == true)
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
        private void btn_IotTest_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                Radiobutton_PlayGroup();                                        //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                serialPort_IOT.Write("LR\n");                                   //(통신) IOT 글러브 통신 테스트
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");

        }

        private void btn_TagSel_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                Radiobutton_PlayGroup();                                        //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                timer_IotSys.Enabled = true;                                    //(타이머) iot타이머 시작
                serialPort_IOT.Write("LN\n");                                   //(통신) IOT 글러브 술래결정 통신 보냄
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_WaitRmOn_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                serialPort_IOT.Write("AR_B\n");                                  //(나레이션)탈출제한 시간이 끝났습니다.
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_TagReSel_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                Radiobutton_PlayGroup();                                        //(함수) iot그룹에서 술래 정해진것 통신 보는 함수
                serialPort_IOT.Write("RR\n");                                   //(통신) IOT 글러브 술래 재 결정 통신 보냄
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IotSys_timerStart_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                timer_IotSys.Enabled = true;                                    //(타이머) iot타이머 시작
                iot_remaing_time = IOT_TIME * 60;                               //(변수) iot타이머 시간 리셋
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_IotSys_timerStop_Click(object sender, EventArgs e)
        {
            if (serialPort_IOT.IsOpen)
            {
                timer_IotSys.Enabled = false;                                    //(타이머) iot타이머 정지
            }
            else
                MessageBox.Show((String)"IOT 통신 연결을 먼저 진행해주세요!");
        }

        // **************************************************************       IOT sys MAIN CODE          *******************************************************************************************
        // **************************************************************      EXERCISE sys MAIN CODE      *******************************************************************************************
        const int TRM_TIME = 25;                                                                            //25분;     훈련소 총 머무는 시간 저장하는 변수 
        int trm_remaing_time = 0;                                                                           //0*60;     남은시간 전체 초로 카운팅 저장하고 있는 변수
        int trm_remaing_min = 0;                                                                            //0;        남은시간 MIN으로 가지고 있는 변수
        int trm_remaing_sec = 0;                                                                            //0;        남은시간 SEC으로 가지고 있는 변수
        bool TRM_start = false;
        private void timer_ExerciseSys_Tick(object sender, EventArgs e)
        {
            trm_remaing_time += 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            trm_remaing_min = trm_remaing_time / 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            trm_remaing_sec = trm_remaing_time % 60;                                                        //남은 시간 분과 초로 불리해주는 작업
            string remaing_show = trm_remaing_min.ToString("00") + ":" + trm_remaing_sec.ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            lb_ExerciseSys_Clock.Text = remaing_show;                                                   //남은 시간 출력
            Exercisesys_TimeAction();
        }
        private void Exercisesys_TimeAction()
        {
            if (TRM_start == true)
            {
                //처음 게임시작하고 나레이션if문
                switch (trm_remaing_time)
                {
                    case 0:
                        break;

                    case TRM_TIME * 60:
                        TRM_start = false;
                        break;
                }
            }
        }

        private void btn_ExerciseSys_Start_Click(object sender, EventArgs e)        //'훈련소 시작' 버튼 클릭
        {
            if (serialPort_TRM.IsOpen)
            {
                timer_ExerciseSys.Enabled = true;                                   //(타이머) TRM타이머 시작    
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_ReadyMode_Click(object sender, EventArgs e)    //'훈련소 장치 준비' 버튼 클릭
        {
            if (serialPort_TRM.IsOpen)
            {
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_SetupMode_Click(object sender, EventArgs e)    //'훈련소 장치 정비' 버튼 클릭
        {
            if (serialPort_TRM.IsOpen)
            {
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_timerStart_Click(object sender, EventArgs e)   //'훈련소 타이머 시작' 버튼 클릭
        {
            if (serialPort_TRM.IsOpen)
            {
                timer_ExerciseSys.Enabled = true;                                   //(타이머) TRM타이머 시작    
                trm_remaing_time = 0;                                               //(타이머) 타이머 시간 초기화    
            }
            else
                MessageBox.Show((String)"TRM 통신 연결을 먼저 진행해주세요!");
        }

        private void btn_ExerciseSys_timerStop_Click(object sender, EventArgs e)    //'훈련소 타이머 정지' 버튼 클릭
        {
            timer_ExerciseSys.Enabled = false; ;                                    //(타이머) TRM타이머 정지    
        }

        private void btn_ExerciseSys_MovingOn_Click(object sender, EventArgs e)     //'훈련소 MOVING ON' 버튼 클릭
        {

        }

        private void btn_ExerciseSys_Stop_Click(object sender, EventArgs e)         //'훈련소 정지' 버튼 클릭
        {

        }

        private void btn_ExerciseSys_ExerciseRmOn_Click(object sender, EventArgs e) //'훈련소 조명 ON' 버튼 클릭
        {

        }

        private void button26btn_ExerciseSys_LightOff_Click(object sender, EventArgs e)//'훈련소 조명 OFF' 버튼 클릭
        {

        }

        private void btn_ExerciseSys_funcA_Click(object sender, EventArgs e)        //'대기공간 조명 ON' 버튼 클릭
        {

        }

        private void btn_ExerciseSys_WaitRmOff_Click(object sender, EventArgs e)    //'대기공간 조명 OFF' 버튼 클릭
        {

        }
    }
}
