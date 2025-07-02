namespace LollipopChart;

public class Model
{
    public string Hotel { get; set; }
    public double PercentageShare { get; set; }
    public Model(string hotel, double percentageShare)
    {
        Hotel = hotel;
        PercentageShare = percentageShare;
    }
}