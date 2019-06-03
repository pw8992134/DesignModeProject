namespace DesignModeProject.AbstractFactoryMode.Example2
{
    public interface IFillColorShapeFactory
    {
        IShape CreateShape();

        IColor CreateColor();
    }
}