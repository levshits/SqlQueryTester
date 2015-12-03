using System;
using System.IO;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json;

namespace SqlQueryTester
{
    public partial class MainForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger("RootLogger");
        private string SETTINGS_FILE = @".\settings.json";
        private TestQueryTaskParameter _parameter;
        private bool _isRunning = false;
        private TestQueryTester _tester = new TestQueryTester();
        private const string STOP_LABEL = "Stop";
        private const string START_LABEL = "Start";

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _log.Debug("Start");
                _parameter = BindParameter();
                _isRunning = true;
                _tester.Start(_parameter);
                StartButton.Text = STOP_LABEL;
            }
            else
            {
                _log.Debug("Stop");
                StartButton.Text = START_LABEL;
                _tester.Stop();
                _isRunning = false;
            }

        }

        private TestQueryTaskParameter BindParameter()
        {
            var result = new TestQueryTaskParameter()
            {
                ConnectionString = ConnectionStringControl.Text,
                ConnectionsCount = (int) ConnectionsCountControl.Value,
                Timeout = (int) TimeoutControl.Value,
                Query = QueryControl.Text
            };
            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _parameter =
                    JsonConvert.DeserializeObject<TestQueryTaskParameter>(
                        File.ReadAllText(SETTINGS_FILE));
                ConnectionsCountControl.Value = _parameter.ConnectionsCount;
                TimeoutControl.Value = _parameter.Timeout;
                ConnectionStringControl.Text = _parameter.ConnectionString;
                QueryControl.Text = _parameter.Query;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _parameter = BindParameter();
                File.WriteAllText(SETTINGS_FILE, JsonConvert.SerializeObject(_parameter));
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}
