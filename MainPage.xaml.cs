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
		base.OnLayout();

		float radius = 8;
		float centerX = (Right + Left) / 2;
		float centerY = Top + radius;

		var path = new PathF();
		path.MoveTo(centerX, Bottom);
		path.LineTo(centerX, Top);

		var color = (Fill is SolidColorBrush brush) ? brush.Color : Colors.Transparent;

		canvas.StrokeColor = color;
		canvas.StrokeSize = 3;
		canvas.DrawPath(path);

		canvas.FillColor = color;
		canvas.FillCircle(centerX, centerY, radius);
	}

}

