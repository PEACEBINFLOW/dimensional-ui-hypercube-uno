namespace DimensionalUI.Core.Geometry;

public class CubeGeometryMode : IGeometryMode
{
    private double _rotationX;
    private double _rotationY;

    public ShapeMode Mode => ShapeMode.Cube;

    public void ApplyDrag(double deltaX, double deltaY)
    {
        var speed = 0.2;
        _rotationY += -deltaX * speed;
        _rotationX += deltaY * speed;
    }

    public void Reset()
    {
        _rotationX = 0;
        _rotationY = 0;
    }

    public (double RotationX, double RotationY) GetRotation()
        => (_rotationX, _rotationY);
}
