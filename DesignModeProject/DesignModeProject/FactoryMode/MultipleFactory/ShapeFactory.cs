namespace DesignModeProject.FactoryMode.MultipleFactory
{
    /// <summary>
    /// 多个工厂方法模式
    /// 违背开闭原则
    /// </summary>
    public class ShapeFactory
    {
        public IShape CreateCircle()
        {
            return new Circle();
        }

        public IShape CreateSquare()
        {
            return new Square();
        }
    }
}