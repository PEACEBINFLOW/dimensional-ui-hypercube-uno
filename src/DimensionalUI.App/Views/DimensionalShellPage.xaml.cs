using System;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using DimensionalUI.App.Services;
using DimensionalUI.App.ViewModels;
using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Interactions;
using DimensionalUI.Core.Themes;
using DimensionalUI.Core.Util;

namespace DimensionalUI.App.Views;

public sealed partial class DimensionalShellPage : Page
{
    private readonly ShellViewModel _vm;
    private readonly InteractionBridge _interactionBridge;
    private readonly GeometryService _geometryService;

    private Point _lastPointer;
    private bool _pointerDown;
    private DateTime _pointerDownTime;

    public DimensionalShellPage()
    {
        this.InitializeComponent();

        var eventBus = new EventBus();
        var themeService = new ThemeService(eventBus);
        _geometryService = new GeometryService(eventBus);
        var patternCapture = new PatternCaptureService(eventBus);
        _interactionBridge = new InteractionBridge(eventBus);

        _vm = new ShellViewModel(themeService, _geometryService);

        DataContext = _vm;

        eventBus.Subscribe("ShowHexMenu", payload =>
        {
            if (payload is InteractionEvent ev)
            {
                HexMenu.CenterAt(new Windows.Foundation.Point(ev.X, ev.Y));
                HexMenu.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        });

        eventBus.Subscribe("PrimaryClick", payload =>
        {
            // For now: hide menu on primary click
            HexMenu.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        });

        // Load basic faces
        FrontFrame.Navigate(typeof(Faces.HomeFaceView));
        RightFrame.Navigate(typeof(Faces.TasksFaceView));
        TopFrame.Navigate(typeof(Faces.NotesFaceView));

        // Hook pointer events at root
        RootGrid.PointerPressed += OnPointerPressed;
        RootGrid.PointerReleased += OnPointerReleased;
        RootGrid.PointerMoved += OnPointerMoved;
        RootGrid.RightTapped += OnRightTapped;
    }

    private void OnPointerPressed(object sender, PointerRoutedEventArgs e)
    {
        _pointerDown = true;
        _pointerDownTime = DateTime.UtcNow;
        _lastPointer = e.GetCurrentPoint(RootGrid).Position;
        RootGrid.CapturePointer(e.Pointer);
    }

    private void OnPointerReleased(object sender, PointerRoutedEventArgs e)
    {
        _pointerDown = false;
        RootGrid.ReleasePointerCapture(e.Pointer);
        var pos = e.GetCurrentPoint(RootGrid).Position;
        var elapsed = (DateTime.UtcNow - _pointerDownTime).TotalMilliseconds;

        if (elapsed < 250)
        {
            _interactionBridge.HandleClick(pos);
        }
        else
        {
            _interactionBridge.HandleHold(pos);
        }
    }

    private void OnPointerMoved(object sender, PointerRoutedEventArgs e)
    {
        if (!_pointerDown) return;

        var pos = e.GetCurrentPoint(RootGrid).Position;
        var dx = pos.X - _lastPointer.X;
        var dy = pos.Y - _lastPointer.Y;
        _lastPointer = pos;

        _interactionBridge.HandleDrag(pos, dx, dy);

        // apply cube rotation to visual
        var rotation = _geometryService.GetRotation();
        FrontFaceProjection.RotationX = rotation.rotationX;
        FrontFaceProjection.RotationY = rotation.rotationY;
        RightFaceProjection.RotationY = rotation.rotationY - 90;
        TopFaceProjection.RotationX = rotation.rotationX + 90;
    }

    private void OnRightTapped(object sender, RightTappedRoutedEventArgs e)
    {
        var pos = e.GetPosition(RootGrid);
        _interactionBridge.HandleRightClick(pos);
    }
}
