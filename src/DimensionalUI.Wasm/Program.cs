using System;
using Windows.UI.Xaml;
using DimensionalUI.App;

namespace DimensionalUI.Wasm;

public static class Program
{
    public static void Main(string[] args)
    {
        // In a real Uno WASM head this bootstraps the WebAssembly app.
        // Here we just call Application.Start with App.
        Application.Start(_ => new App());
    }
}
