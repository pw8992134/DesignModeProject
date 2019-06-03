namespace DesignModeProject.SingletonMode.HungryMan
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instance=new Singleton();

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}