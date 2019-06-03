namespace DesignModeProject.SingletonMode.DoubleCheck
{
    /// <summary>
    /// 双检锁
    /// 对于c#没有问题，对于JAVA有问题·（因为内存模型的原因,无序写入）
    /// </summary>
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instance = null;

        private static readonly object _lock=new object();

        public static Singleton GetInstance()
        {
            if (instance==null)
            {
                lock (_lock)
                {
                    if (instance==null)
                    {
                        instance=new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}