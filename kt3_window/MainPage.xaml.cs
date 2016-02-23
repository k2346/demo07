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

namespace kt3_window
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

        private void Laskebutton_Click(object sender, RoutedEventArgs e)
        {   //etsi käyttäjän syöttämät luvut
            // leveys
            string leveysString = leveysTextBox.Text;
            int leveys = int.Parse(leveysString); // muutetaan string intiksi
            //korkeus
            string korkeusString = korkeusTextBox.Text;
            int korkeus = int.Parse(korkeusString); // muutetaan string intiksi, jotta laskut on mahdollisia
            //karmi
            string karmiString = karmitextBox.Text;
            int karmi = int.Parse(karmiString); // muutetaan string intiksi

            //lasketaan ikkunan pinta-ala
            int ikkunaPa = (leveys * korkeus) /10;

            //lasketaan piiri
            int luku1 = (karmi * 2 + leveys);
            int luku2 = (karmi * 2 + korkeus);
            int piiri = ((luku1 + luku2) * 2) /10;


        
            //lasketaan karmin pinta-ala
            int karmiPA = (karmi * leveys + karmi * leveys + karmi * korkeus + karmi * korkeus);

            //lasketaan lasin pinta-ala
            int lasiPa = (ikkunaPa - karmiPA) / 10;

            //tulostetaan tulokset vastausbokseihin
            VAikkunaPAtextBox.Text = ikkunaPa.ToString() + "cm^2";
            VAkarmipiiritextBox.Text = piiri.ToString();
            VAlasinPAtextBox.Text = lasiPa.ToString() + "cm^2";

        }
    }
}
