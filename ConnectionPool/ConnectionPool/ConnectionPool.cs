using System.Reflection;

namespace Singleton
{
    public class ConnectionPool
    {
        private static ConnectionPool _instance;
        private ConnectionPool() { }
        public static ConnectionPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnectionPool();
                }
                return _instance;
            }
        }
    }

    public class TestableConnectionPool : ConnectionPool
    {
        public TestableConnectionPool()
        {
            FieldInfo fieldInfo = typeof(ConnectionPool).GetField("_instance", BindingFlags.Static | BindingFlags.NonPublic);
            fieldInfo.SetValue(Instance, this);
        }
    }
}
