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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void truckButton_Click(object sender, RoutedEventArgs e)
        { //haetaan käyttöliittymästä truck blockin sisältämä teksti
            string truckString = trucksBlock.Text; //"0"
            int trucks = int.Parse(truckString);//0
            trucks++; // trucks = trucks + 1;
            //näytetään uusi lukumäärä näytöllä
            trucksBlock.Text = trucks.ToString(); // tässä muutetaan int stringiksi
           

        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            string carString = carsBlock.Text;
            int cars = int.Parse(carString);
            cars++;
            carsBlock.Text = cars.ToString();

        }
    }
}
