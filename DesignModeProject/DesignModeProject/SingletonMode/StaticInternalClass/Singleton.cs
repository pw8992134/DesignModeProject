namespace DesignModeProject.SingletonMode.StaticInternalClass
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static class SingletonHoder
        {
            //显式静态构造函数告诉C#编译器

            //不将类型标记为BeforeFieldInit
            static SingletonHoder() { }

            internal static readonly Singleton instance=new Singleton();
        }

        public static Singleton GetInstance()
        {
            return SingletonHoder.instance;
        }
    }
}