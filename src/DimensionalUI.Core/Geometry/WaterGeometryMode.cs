namespace DimensionalUI.Core.Geometry;

public class WaterGeometryMode : IGeometryMode
{
    private double _offsetX;
    private double _offsetY;

    public ShapeMode Mode => ShapeMode.Water;

    public void ApplyDrag(double deltaX, double deltaY)
    {
        var speed = 0.1;
        _offsetX += -deltaX * speed;
        _offsetY += -deltaY * speed;
    }

    public void Reset()
    {
        _offsetX = 0;
        _offsetY = 0;
    }

    public (double RotationX, double RotationY) GetRotation()
        => (_offsetX, _offsetY);
}
