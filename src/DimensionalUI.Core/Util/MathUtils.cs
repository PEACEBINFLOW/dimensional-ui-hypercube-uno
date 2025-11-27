namespace DimensionalUI.Core.Util;

public static class MathUtils
{
    public static double Clamp(double v, double min, double max)
        => v < min ? min : v > max ? max : v;
}
