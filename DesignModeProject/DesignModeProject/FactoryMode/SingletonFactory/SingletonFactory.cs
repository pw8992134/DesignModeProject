using System;

namespace DesignModeProject.FactoryMode.SingletonFactory
{
    /// <summary>
    /// 通过反射构建单例
    /// 不再违反迪米特原则
    /// 需要限定外部不再使用反射构建对象（虽然其他的单例也可以使用反射创建）
    /// </summary>
    public static class SingletonFactory
    {
        private static Singleton singleton;

        static SingletonFactory()
        {
            try
            {
                singleton = Activator.CreateInstance(typeof(Singleton)) as Singleton;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static Singleton CreateSingleton()
        {
            return singleton;
        }
    }
}