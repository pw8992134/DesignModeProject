namespace DesignModeProject.AbstractFactoryMode.Example1
{
    /// <summary>
    /// 抽象工厂模式
    /// 相关对象(同一类1铲平)
    /// 优点：封装性，对高层模块只是抽象产品，约束：高层模块不关心约束。只在底层关心（比如黄色人种和白色人种的生成有比例）
    /// 缺点：产品族扩展困难，不符合开闭原则。产品等级扩展容易
    /// </summary>
    public class YellowHumanFactory : AbstractHumanFactory
    {
        public override IHuman CreateHuman()
        {
            throw new System.NotImplementedException();
        }
    }
}