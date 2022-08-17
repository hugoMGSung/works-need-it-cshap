using Bogus;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
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
using uPLibrary.Networking.M2Mqtt;

namespace BogusMqttWinformApp
{
    public partial class MainForm : MetroSetForm // Form
    {
        public MqttClient Client { get; private set; }

        private Thread MqttThread { get; set; }

        private Faker<SensorInfo> SensorFaker { get; set; }

        private string CurrValue { get; set; }

        public MainForm()
        {
            InitializeComponent();

            InitializeAll();        // 전체 초기화
        }

        private void InitializeAll()
        {
            var Rooms = new[] { "DiningRoom", "LivingRoom", "BedRoom", "BathRoom", "GuestRoom" };

            SensorFaker = new Faker<SensorInfo>()
                .RuleFor(o => o.Dev_Id, f => f.PickRandom(Rooms))
                .RuleFor(o => o.Curr_Time, f => f.Date.Past(0))
                .RuleFor(o => o.Temp, f => f.Random.Float(20.0f, 35.9f))
                .RuleFor(o => o.Humid, f => f.Random.Float(40.0f, 63.9f))
                .RuleFor(o => o.Press, f => f.Random.Float(899.0f, 1005.9f));
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ConnectMqttBroker();    // MQTT 브로커 접속
            StartPublish();         // fake 센싱 메시지 전송
        }

        private void StartPublish()
        {
            MqttThread = new Thread(() =>
            {
                while (true)
                {
                    SensorInfo ThisValue = SensorFaker.Generate();
                    CurrValue = JsonConvert.SerializeObject(ThisValue, Formatting.Indented);
                    Client.Publish("home/device/data/", Encoding.Default.GetBytes(CurrValue));
                    // Console.WriteLine($"Published : {CurrValue}");
                    // Rich TextBox에 값 보내기 Invoke로 변경
                    this.Invoke(new Action(delegate ()
                    {
                        RtbLog.AppendText($"Published : {CurrValue}\n");
                        RtbLog.ScrollToCaret();
                    }));
                    Thread.Sleep(1000);
                }
            });
            MqttThread.Start();
        }

        private void ConnectMqttBroker()
        {
            Client = new MqttClient(TxtMqttBrokerIp.Text);
            Client.Connect("FakerDaemon");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
