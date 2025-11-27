using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DimensionalUI.Core.Themes;
using DimensionalUI.Core.Geometry;

namespace DimensionalUI.App.Views.Overlays;

public sealed partial class HexMenuControl : UserControl
{
    public HexMenuControl()
    {
        this.InitializeComponent();
    }

    public void CenterAt(Point center)
    {
        CanvasRoot.Children.Clear();

        double radius = 70;
        int itemCount = 6;

        AddButton(center, "Close", isCore: true);

        for (int i = 0; i < itemCount; i++)
        {
            double angle = (Math.PI * 2 / itemCount) * i;
            double x = center.X + radius * Math.Cos(angle);
            double y = center.Y + radius * Math.Sin(angle);

            var label = i switch
            {
                0 => "Desert",
                1 => "Water",
                2 => "Neon",
                3 => "Cube",
                4 => "Sphere",
                5 => "WaterMode",
                _ => $"N{i+1}"
            };

            AddButton(new Point(x, y), label);
        }
    }

    private void AddButton(Point position, string label, bool isCore = false)
    {
        var btn = new Button
        {
            Width = 48,
            Height = 48,
            Content = label,
            Tag = label,
            HorizontalAlignment = HorizontalAlignment.Left,
            VerticalAlignment = VerticalAlignment.Top
        };

        Canvas.SetLeft(btn, position.X - 24);
        Canvas.SetTop(btn, position.Y - 24);

        btn.Click += (s, e) =>
        {
            if (label == "Close")
            {
                this.Visibility = Visibility.Collapsed;
            }
            // Theme / geometry switches are actually handled in services
            // in this starter shell we only handle close here.
        };

        CanvasRoot.Children.Add(btn);
    }
}
