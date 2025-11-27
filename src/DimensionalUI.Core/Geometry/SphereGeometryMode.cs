namespace DimensionalUI.Core.Geometry;

public class SphereGeometryMode : IGeometryMode
{
    private double _latitude;
    private double _longitude;

    public ShapeMode Mode => ShapeMode.Sphere;

    public void ApplyDrag(double deltaX, double deltaY)
    {
        var speed = 0.15;
        _longitude += -deltaX * speed;
        _latitude = Clamp(_latitude + deltaY * speed, -89, 89);
    }

    public void Reset()
    {
        _latitude = 0;
        _longitude = 0;
    }

    public (double RotationX, double RotationY) GetRotation()
        => (_latitude, _longitude);

    private static double Clamp(double v, double min, double max)
        => v < min ? min : v > max ? max : v;
}
