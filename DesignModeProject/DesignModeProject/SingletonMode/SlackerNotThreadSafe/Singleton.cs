namespace DesignModeProject.SingletonMode.SlackerNotThreadSafe
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instance = null;

        public static Singleton GetInstance()
        {
            if (instance==null)
            {
                instance=new Singleton();
            }
            return instance;
        }
    }
}