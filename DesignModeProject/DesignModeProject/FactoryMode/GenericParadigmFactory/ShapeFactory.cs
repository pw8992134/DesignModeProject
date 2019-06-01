namespace DesignModeProject.FactoryMode.GenericParadigmFactory
{
    /// <summary>
    /// 泛型工厂类，不违反开闭原则，类数量少
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ShapeFactory<T> where T:IShape,new()
    {
        public static IShape CreateShape()
        {
            return new T();
        }
    }
}