namespace panScrollSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        for (var i = 0; i < 100; i++)
        {
            RowsLayout.Children.Add(new Grid
            {
                BackgroundColor = Colors.Red,
                Margin = new Thickness(1),
                HeightRequest = 50
            });
        }
    }

    private void Pan_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        PanStatusLabel.Text = e.StatusType == GestureStatus.Running
            ? $"Pan: {e.StatusType} | X: {e.TotalX:F0} | Y: {e.TotalY:F0}"
            : $"Pan: {e.StatusType}";
    }
}
