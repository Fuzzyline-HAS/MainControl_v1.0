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

namespace MainControl_v1._0
{
    public partial class MainControl : Form
    {
        private SerialPort serialPort_PCM = new SerialPort();
        private SerialPort serialPort_IOT = new SerialPort();
        private SerialPort serialPort_TRM = new SerialPort();
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
        private void dataSend_PCM(string data_input)                                                //PCM_DATA SEND 함수
        {
            if (serialPort_PCM.IsOpen)
            {
                serialPort_PCM.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"통신 연결을 먼저 진행해주세요!");
        }//PCM_DATA SEND 함수
        private void serialPort_PCM_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_PCM));                                        //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_PCM(object s, EventArgs e)                                        //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_pcm = serialPort_PCM.ReadExisting();                                        //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //char ReceiveData = (char)serialPort1.ReadByte();                                      //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //textBox1.Text = "\r\n" + ReceiveData.ToString();
            tb_serialPort_PCM.AppendText(data_pcm);                                                 //텍스트 박스에 시리얼 통신으로 받은 데이터 출력                                             
            //textBox1.Text = textBox1.Text + string.Format("{0:X2}", ReceiveData);                 //int 형식을 string형식으로 변환하여 출력
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
        private void dataSend_IOT(string data_input)                                                //PCM_DATA SEND 함수
        {
            if (serialPort_IOT.IsOpen)
            {
                serialPort_IOT.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"통신 연결을 먼저 진행해주세요!");
        }//PCM_DATA SEND 함수
        private void serialPort_IOT_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_IOT));                                        //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_IOT(object s, EventArgs e)                                        //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_iot = serialPort_IOT.ReadExisting();                                        //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //char ReceiveData = (char)serialPort1.ReadByte();                                      //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
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
        private void dataSend_TRM(string data_input)                                                //PCM_DATA SEND 함수
        {
            if (serialPort_TRM.IsOpen)
            {
                serialPort_TRM.Write(data_input);                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"통신 연결을 먼저 진행해주세요!");
        }//PCM_DATA SEND 함수
        private void serialPort_TRM_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived_TRM));                                        //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived_TRM(object s, EventArgs e)                                        //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string data_trm = serialPort_TRM.ReadExisting();                                        //시리얼 통신으로 들어온 데이터 data_pcm에 저장
            //char ReceiveData = (char)serialPort1.ReadByte();                                      //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
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
    }
}
