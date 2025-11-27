using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Util;

namespace DimensionalUI.App.Services;

public class GeometryService
{
    private readonly IGeometryMode _cubeMode = new CubeGeometryMode();
    private readonly IGeometryMode _sphereMode = new SphereGeometryMode();
    private readonly IGeometryMode _waterMode = new WaterGeometryMode();

    private IGeometryMode _currentMode;
    private readonly EventBus _bus;

    public GeometryService(EventBus bus)
    {
        _bus = bus;
        _currentMode = _cubeMode;
    }

    public ShapeMode CurrentMode => _currentMode.Mode;

    public void SetMode(ShapeMode mode)
    {
        _currentMode = mode switch
        {
            ShapeMode.Cube => _cubeMode,
            ShapeMode.Sphere => _sphereMode,
            ShapeMode.Water => _waterMode,
            _ => _cubeMode
        };
        _bus.Publish("ShapeModeChanged", _currentMode.Mode);
    }

    public void ApplyDrag(double dx, double dy)
    {
        _currentMode.ApplyDrag(dx, dy);
    }

    public (double rotationX, double rotationY) GetRotation()
    {
        var (rx, ry) = _currentMode.GetRotation();
        return (rx, ry);
    }
}
