using System.Reflection;

namespace Singleton
{
    public class TestableConnectionPool : ConnectionPool
    {

        public TestableConnectionPool()
        {
            FieldInfo fieldInfo = typeof(ConnectionPool).GetField("_instance", BindingFlags.Static | BindingFlags.NonPublic);
            fieldInfo.SetValue(Instance, this);
        }

    }
}
