namespace DesignModeProject.FactoryMode.AbstractFactory
{
    /// <summary>
    /// 将工厂类也抽象出来
    /// 改动产品时不再违反开闭原则，直接增加工厂类实现即可
    /// </summary>
    public class SquareShapeFactory : AbstractShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Square();
        }
    }
}