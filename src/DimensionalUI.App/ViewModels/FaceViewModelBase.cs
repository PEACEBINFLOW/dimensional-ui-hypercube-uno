namespace DimensionalUI.App.ViewModels;

public abstract class FaceViewModelBase
{
    public string Title { get; }

    protected FaceViewModelBase(string title)
    {
        Title = title;
    }
}
