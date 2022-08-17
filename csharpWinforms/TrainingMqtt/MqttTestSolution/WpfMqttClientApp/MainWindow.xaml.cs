using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MQTTnet;
using MQTTnet.Client;
using System.ComponentModel;
using MahApps.Metro.Controls.Dialogs;
using MQTTnet.Packets;

namespace WpfMqttClientApp
{
    public class TopicModel : INotifyPropertyChanged
    {
        public TopicModel()
        {

        }
        public TopicModel(string topic, string describe)
        {
            _isSelected = false;
            _topic = topic;
            _describe = describe;
        }
        private bool? _isSelected;

        public bool? IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged("IsSelected");
                }
            }
        }

        private string _topic;
        public string Topic
        {
            get { return _topic; }
            set
            {
                if (_topic != value)
                {
                    _topic = value;
                    OnPropertyChanged("Topic");
                }
            }
        }

        private string _describe;
        public string Describe
        {
            get { return _describe; }
            set
            {
                if (_describe != value)
                {
                    _describe = value;
                    OnPropertyChanged("Describe");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MainWindowModel : INotifyPropertyChanged
    {
        private List<TopicModel> _allTopics;

        public List<TopicModel> AllTopics
        {
            get { return _allTopics; }
            set
            {
                if (_allTopics != value)
                {
                    _allTopics = value;
                    OnPropertyChanged("AllTopics");
                }
            }
        }

        private List<MqttTopicFilter> _selectedTopics;

        public List<MqttTopicFilter> SelectedTopics
        {
            get { return _selectedTopics; }
            set
            {
                if (_selectedTopics != value)
                {
                    _selectedTopics = value;
                    OnPropertyChanged("SelectedTopics");
                }
            }
        }

        private string _serverUri;

        public string ServerUri
        {
            get { return _serverUri; }
            set
            {
                if (_serverUri != value)
                {
                    _serverUri = value;
                    OnPropertyChanged("ServerUri");
                }
            }
        }

        private int _serverPort;

        public int ServerPort
        {
            get { return _serverPort; }
            set
            {
                if (_serverPort != value)
                {
                    _serverPort = value;
                    OnPropertyChanged("ServerPort");
                }
            }
        }


        private string _clientId;

        public string ClientID
        {
            get { return _clientId; }
            set
            {
                if (_clientId != value)
                {
                    _clientId = value;
                    OnPropertyChanged("ClientID");
                }
            }
        }

        private MqttTopicFilter _currentTopic;

        public MqttTopicFilter CurrentTopic
        {
            get { return _currentTopic; }
            set
            {
                if (_currentTopic != value)
                {
                    _currentTopic = value;
                    OnPropertyChanged("CurrentTopic");
                }
            }
        }

        private bool? _isConnected = false;

        public bool? IsConnected
        {
            get { return _isConnected; }
            set
            {
                if (_isConnected != value)
                {
                    _isConnected = value;
                    OnPropertyChanged("IsConnected");
                }
            }
        }

        private bool _isDisConnected = true;

        public bool IsDisConnected
        {
            get { return _isDisConnected; }
            set
            {
                if (_isDisConnected != value)
                {
                    _isDisConnected = value;
                    this.OnPropertyChanged("IsDisConnected");
                }
            }
        }

        private string _userName = "admin";

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    this.OnPropertyChanged("UserName");
                }

            }
        }

        private string _password = "password";

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    this.OnPropertyChanged("Password");
                }

            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private MainWindowModel _model;
        private IMqttClient _client;

        public MainWindow()
        {
            InitializeComponent();
            _model = new MainWindowModel()
            {
                AllTopics = InitTopics(),
                SelectedTopics = new List<MqttTopicFilter>(),
                ServerUri = "127.0.0.1",
                CurrentTopic = null,
                ServerPort = 61613,
                ClientID = Guid.NewGuid().ToString("N")
            };
            this.DataContext = _model;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            this.flySub.IsOpen = !this.flySub.IsOpen;
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.flyLogin.IsOpen = !this.flyLogin.IsOpen;
        }

        private List<TopicModel> InitTopics()
        {
            List<TopicModel> topics = new List<TopicModel>();
            topics.Add(new TopicModel("/environ/temp", "환경-온도"));
            topics.Add(new TopicModel("/environ/hum", "환경-습도"));
            //topics.Add(new TopicModel("/environ/pm25", "환경-PM2.5"));
            //topics.Add(new TopicModel("/environ/CO2", "환경-이산화탄소"));
            //topics.Add(new TopicModel("/energy/electric", "에너지소비-전기"));
            //topics.Add(new TopicModel("/energy/water", "환경-물"));
            //topics.Add(new TopicModel("/energy/gas", "환경-전기"));
            topics.Add(new TopicModel("/data/alarm", "데이터-알람"));
            topics.Add(new TopicModel("/data/message", "데이터-메시지"));
            topics.Add(new TopicModel("/data/notify", "데이터-알림"));
            return topics;
        }

        private List<MqttTopicFilter> ConvertTopics(List<TopicModel> topics)
        {
            //MQTTnet.TopicFilter
            List<MqttTopicFilter> filters = new List<MqttTopicFilter>();
            foreach (TopicModel model in topics)
            {
                MqttTopicFilter filter = new MqttTopicFilter(); //
                                                                //(model.Topic, MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce);
                filter.Topic = model.Topic;
                filters.Add(filter);

            }
            return filters;
        }

        public void WriteToStatus(string message)
        {
            if (!(txtRich.CheckAccess()))
            {
                this.Dispatcher.Invoke(() =>
                    WriteToStatus(message)
                    );
                return;
            }
            string strTime = "[" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] ";
            txtRich.AppendText(strTime + message + "\r");
            if (txtRich.ExtentHeight > 200)
            {
                txtRich.Document.Blocks.Clear();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            List<TopicModel> topics = _model.AllTopics.Where(t => t.IsSelected == true).ToList();

            _model.SelectedTopics = ConvertTopics(topics);
            this.flySub.IsOpen = !this.flySub.IsOpen;
            SubscribeTopics(_model.SelectedTopics);
        }
        private void SubscribeTopics(List<MqttTopicFilter> filters)
        {
            if (_client != null)
            {
                // ERROR!!!
                _client.SubscribeAsync(null); // filters);  
                string tmp = "";
                foreach (var filter in filters)
                {
                    tmp += filter.Topic;
                    tmp += ",";
                }
                if (tmp.Length > 1)
                {
                    tmp = tmp.Substring(0, tmp.Length - 1);
                }
                WriteToStatus("Topic 구독 성공：" + tmp);
            }
            else
            {
                ShowDialog("오류", "서버 접속 후 토픽 구독 부탁드립니다！");
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (_model.ServerUri != null && _model.ServerPort > 0)
            {
                InitClient(_model.ClientID, _model.ServerUri, _model.ServerPort);
            }
            else
            {
                ShowDialog("오류", "서버 주소 또는 포트 번호는 비워둘 수 없습니다！");
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (_client != null)
            {
                _client.DisconnectAsync();
            }
        }

        private void InitClient(string id, string url = "127.0.0.1", int port = 1883)
        {
            var options = new MqttClientOptions()
            {
                ClientId = id
            };
            options.ChannelOptions = new MqttClientTcpOptions()
            {
                Server = url,
                Port = port
            };
            options.Credentials = new MqttClientCredentials(_model.UserName, Encoding.Default.GetBytes(_model.Password));
            options.CleanSession = true;
            options.KeepAlivePeriod = TimeSpan.FromSeconds(100);
            //options.KeepAliveSendInterval = TimeSpan.FromSeconds(10000);
            if (_client != null)
            {
                _client.DisconnectAsync();
                _client = null;
            }
            _client = new MQTTnet.MqttFactory().CreateMqttClient();
            _client.ApplicationMessageReceivedAsync += _client_ApplicationMessageReceivedAsync;
            _client.ConnectedAsync += _client_ConnectedAsync;
            _client.DisconnectedAsync += _client_DisconnectedAsync;
            _client.ConnectAsync(options);
        }

        private Task _client_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            _model.IsConnected = false;
            _model.IsDisConnected = true;
            WriteToStatus("서버에서 연결 해제！");
            return Task.CompletedTask;
        }

        private Task _client_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            _model.IsConnected = true;
            _model.IsDisConnected = false;
            WriteToStatus("서버와 연결 설정");
            return Task.CompletedTask;
        }

        private Task _client_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs e)
        {
            WriteToStatus("서버와 연결 설정" + e.ClientId + "，Topic > " + e.ApplicationMessage.Topic + " 메시지：" + Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
            return Task.CompletedTask;
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            if (_client != null)
            {
                if (this.comboTopics.SelectedIndex < 0)
                {
                    ShowDialog("오류", "게시할 주제를 선택하세요！");
                    return;
                }
                if (string.IsNullOrEmpty(txtContent.Text))
                {
                    ShowDialog("오류", "메시지 내용은 비워둘 수 없습니다!");
                    return;
                }
                string topic = comboTopics.SelectedValue as string;
                string content = txtContent.Text;
                MqttApplicationMessage msg = new MqttApplicationMessage
                {
                    Topic = topic,
                    Payload = Encoding.UTF8.GetBytes(content),
                    QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
                    Retain = false
                };
                _client.PublishAsync(msg);
                WriteToStatus("다음 주제로 게시" + topic + " Message！");
            }
            else
            {
                ShowDialog("오류", "서버 접속 후 글을 남겨주세요！");
                return;
            }
        }

        public void ShowDialog(string title, string content)
        {
            _showDialog(title, content);
        }

        private void _showDialog(string title, string content)
        {
            var mySetting = new MetroDialogSettings()
            {
                AffirmativeButtonText = "확정",
                //NegativeButtonText = "Go away!",
                //FirstAuxiliaryButtonText = "Cancel",
                ColorScheme = this.MetroDialogOptions.ColorScheme
            };

            MessageDialogResult result = this.ShowModalMessageExternal(title, content, MessageDialogStyle.Affirmative, mySetting);
        }

        private void btnSaveConfig_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
