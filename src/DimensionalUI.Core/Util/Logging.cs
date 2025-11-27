using System;

namespace DimensionalUI.Core.Util;

public static class Logging
{
    // Minimal placeholder logger
    public static void Info(string message) => Console.WriteLine($"[INFO] {message}");
    public static void Warn(string message) => Console.WriteLine($"[WARN] {message}");
    public static void Error(string message) => Console.WriteLine($"[ERROR] {message}");
}
