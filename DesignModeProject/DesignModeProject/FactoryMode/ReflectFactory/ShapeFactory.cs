using System;
using System.Reflection;

namespace DesignModeProject.FactoryMode.ReflectFactory
{
    /// <summary>
    /// 使用反射构建工厂模式
    /// </summary>
    public static class ShapeFactory
    {
        public static IShape CreateShape(Type shapeType)
        {
            return Activator.CreateInstance(shapeType) as IShape;
        }

        public static IShape CreateShape(string shapeType)
        {
            Type type = Assembly.GetExecutingAssembly().GetType(shapeType);
            return Activator.CreateInstance(type) as IShape;
        }
    }
}