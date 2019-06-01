namespace DesignModeProject.FactoryMode.OrdinaryFactory
{
    public class ShapeFactory
    {
        /// <summary>
        /// 普通工厂模式
        /// 不符合开闭原则，需要外部出入指定信息
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IShape GetShape(string type)
        {
            switch (type)
            {
                case "Circle": return new Circle();
                case "Square": return new Square();
                default: return null;
            }
        }
    }
}