using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LiveCharts;
using LiveCharts.Uwp;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherDashboard.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private SeriesCollection seriesCollection;
        public MainPage()
        {
            this.InitializeComponent();

            seriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                new LineSeries 
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };
            CartesianChart.Series = seriesCollection;
        }
    }
}
