namespace DesignModeProject.FactoryMode.StaticFactory
{
    /// <summary>
    /// 静态工厂方法模式
    /// </summary>
    public static class ShapeFactory
    {
        public static IShape CreateCircle()
        {
            return new Circle();
        }

        public static IShape CreateSquare()
        {
            return new Square();
        }
    }
}