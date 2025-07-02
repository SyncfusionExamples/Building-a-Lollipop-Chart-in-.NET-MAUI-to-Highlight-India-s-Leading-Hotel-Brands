using Syncfusion.Maui.Toolkit.Charts;

namespace LollipopChart;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

public class LollipopSeries : ColumnSeries
{
	protected override ChartSegment CreateSegment()
	{
		return new LollipopSegment();
	}
}

public class LollipopSegment : ColumnSegment
{
    protected override void Draw(ICanvas canvas)
    {
        float radius = 8;
        float centerX = (Right + Left) / 2;
        float centerY = Top + radius;

        // Create path for vertical stem
        var path = new PathF();
        path.MoveTo(centerX, Bottom);
        path.LineTo(centerX, Top);

        // Extract color from Fill brush
        var color = (Fill is SolidColorBrush brush) ? brush.Color : Colors.Transparent;

        // Draw stem
        canvas.StrokeColor = color;
        canvas.StrokeSize = 3;
        canvas.DrawPath(path);

        // Draw candy circle
        canvas.FillColor = color;
        canvas.FillCircle(centerX, centerY, radius);
    }
}

