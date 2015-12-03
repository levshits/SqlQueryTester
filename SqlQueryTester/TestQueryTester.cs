using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using log4net;

namespace SqlQueryTester
{
    public class TestQueryTester
    {
        private static ILog _log = LogManager.GetLogger("RootLogger");
        private bool _isRunning = false;
        private TestQueryTaskParameter _parameter;
        private readonly List<Timer> _timers = new List<Timer>();
        public void Start(TestQueryTaskParameter parameter)
        {
            if (!_isRunning)
            {
                _isRunning = true;
                _parameter = parameter;
                for (int i = 0; i < _parameter.ConnectionsCount; i++)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(_parameter.ConnectionString);
                        connection.Open();
                        var timer = new Timer(TimerHandler, connection,0, _parameter.Timeout);
                        _timers.Add(timer);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Start testing exception.", ex);
                    }
                }
            }
            
        }

        public void Stop()
        {
            _isRunning = false;
            foreach (var timer in _timers)
            {
                timer.Change(-1, -1);
            }
            _timers.Clear();
        }

        private void TimerHandler(object parameter)
        {
            try
            {
                SqlConnection connection = parameter as SqlConnection;
                if (connection != null)
                {
                    SqlCommand command = new SqlCommand(_parameter.Query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}