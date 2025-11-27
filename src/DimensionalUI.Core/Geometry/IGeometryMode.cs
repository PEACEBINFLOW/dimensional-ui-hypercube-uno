namespace DimensionalUI.Core.Geometry;

public interface IGeometryMode
{
    ShapeMode Mode { get; }

    /// <summary>
    /// Called when drag input occurs. Implementations update their internal rotation state.
    /// </summary>
    void ApplyDrag(double deltaX, double deltaY);

    /// <summary>
    /// Reset to a default orientation.
    /// </summary>
    void Reset();

    /// <summary>
    /// Optional: derived summary of current rotation for UI binding.
    /// </summary>
    (double RotationX, double RotationY) GetRotation();
}
