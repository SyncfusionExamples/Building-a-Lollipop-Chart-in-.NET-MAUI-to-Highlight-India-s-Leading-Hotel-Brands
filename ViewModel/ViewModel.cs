using System.Collections.ObjectModel;

namespace LollipopChart;

public class ViewModel
{
    public ObservableCollection<Model> HotelPercentageShareDetails { get; set; }

    public ViewModel()
    {
        HotelPercentageShareDetails = new ObservableCollection<Model>()
            {
                new Model("Marriott International",13.61),
                new Model("Radisson Hotel Group",7.43),
                new Model("Accor",6.40),
                new Model("Hyatt Hotels Corporation",5.37),
                new Model("Concept Hospitality",3.25),
                new Model("Royal Orchid Group",3.25),
                new Model("IHG",4.41),
                new Model("Lemon Tree Hotels",5.39),
                new Model("ITC Hotels",6.86),
                 new Model("IHCL",12.06),
            };
    }
}