using System;

namespace DesignModeProject.SingletonMode.Lazy
{
    public class Singleton
    {
        private Singleton() { }

        private static readonly Lazy<Singleton> instance=new Lazy<Singleton>(()=>new Singleton());

        public static Singleton Instance => instance.Value;
    }
}