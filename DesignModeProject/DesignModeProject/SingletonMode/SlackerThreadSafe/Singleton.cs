namespace DesignModeProject.SingletonMode.SlackerThreadSafe
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instance = null;

        private static readonly object _lock=new object();

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (instance==null)
                {
                    instance=new Singleton();
                }
                return instance;
            }
        }
    }
}