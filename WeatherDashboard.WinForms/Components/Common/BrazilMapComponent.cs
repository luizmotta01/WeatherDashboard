using System.Windows.Forms;
using LiveCharts.WinForms;

namespace WeatherDashboardWinForms.Components.Common
{
    public partial class BrazilMapComponent : UserControl
    {
        public GeoMap BrazilGeoMap => _brazilMap;

        public BrazilMapComponent()
        {
            InitializeComponent();
        }
    }
}
