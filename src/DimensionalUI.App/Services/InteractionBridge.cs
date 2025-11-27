using System;
using Windows.Foundation;
using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Interactions;
using DimensionalUI.Core.Themes;
using DimensionalUI.Core.Util;

namespace DimensionalUI.App.Services;

public class InteractionBridge
{
    private readonly EventBus _bus;
    private readonly InteractionEngine _engine;
    private readonly Func<long> _now;

    public InteractionBridge(EventBus bus, Func<long>? nowProvider = null)
    {
        _bus = bus;
        _engine = new InteractionEngine(bus);
        _now = nowProvider ?? (() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }

    private InteractionEvent CreateEvent(GestureType type, Point p)
        => new()
        {
            GestureType = type,
            X = p.X,
            Y = p.Y,
            TimestampMs = _now(),
            ShapeMode = ShapeMode.Cube, // You can wire this to GeometryService
            Theme = DimensionalTheme.Desert // You can wire this to ThemeService
        };

    public void HandleClick(Point p)
        => _engine.ProcessEvent(CreateEvent(GestureType.Click, p));

    public void HandleRightClick(Point p)
        => _engine.ProcessEvent(CreateEvent(GestureType.RightClick, p));

    public void HandleHold(Point p)
        => _engine.ProcessEvent(CreateEvent(GestureType.Hold, p));

    public void HandleDrag(Point p, double dx, double dy)
        => _engine.ProcessEvent(CreateEvent(GestureType.Drag, p));
}
