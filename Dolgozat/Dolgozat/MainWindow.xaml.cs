using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        int page_count = 0;
        ImageBrush myBrush = new ImageBrush();

        string[] konnyu_kerdesek =
        {
              "Mikor érkezett Kolumbusz Kristóf az Amerikai kontinensre?",
              "Ki volt az első amerikai elnök?",
              "Melyik évben kezdődött az első világháború?",
              "Mi volt XIV. Lajos beceneve?",
              "Melyik évben tört ki a francia forradalom?",
              "Ki volt a legelső római császár?",
              "Melyik évben égett le a római Colosseum?",
              "Melyik évben érkeztek a Pilgrim apák az Amerikai kontinensre?",
              "Melyik ország volt az első, ahol nők szavazati jogot kaptak?",
              "Ki volt az első nő, aki megkapta a Nobel-békedíjat?"
        };

        string[] konnyu_valaszok =
        {
           "1492",
           "George Washington",
           "1914",
           "Napkirály",
           "1789",
           "Augustus Caesar",
           "79",
           "1620",
           "Új-Zéland",
           "Jane Addams"
        };

        string[] kozepes_kerdesek =
        {
            "Melyik évben kezdődött az amerikai polgárháború?",
            "Ki volt a francia forradalom egyik legfontosabb alakja, akit a tisztogatás angyalának is neveztek?",
            "Melyik ország volt az első, ahol bevezették a parlamentáris demokráciát?",
            "Ki volt a második világháborúban a tengelyhatalmak vezetője?",
            "Melyik évben tört ki a kínai kommunista forradalom?",
            "Ki volt az első nő, aki repülőgéppel átrepülte az Atlanti-óceánt?",
            "Melyik ország gyártotta az első ipari forradalom idején az első gőzmozdonyt?",
            "Ki volt az Oszmán Birodalom alapítója?",
            "Melyik évben követte el a japán haditengerészet a Pearl Harbor elleni támadást?",
            "Ki volt a XVII. századi Anglia polgárháborújának győztese?"
        };

        string[] kozepes_valaszok =
        {
           "1861",
           "Robespierre",
           "Egyesült Királyság",
           "Adolf Hitler",
           "1949",
           "Amelia Earhart",
           "Egyesült Királyság",
           "Osman I",
           "1941",
           "Oliver Cromwell"
        };


        string[] nehez_kerdesek =
        {
            "Melyik évben volt az első keresztes hadjárat?",
            "Ki volt az első római császár, aki keresztény hitet fogadott el?",
            "Melyik évben égett le a nagy londoni tűz?",
            "Ki volt az első nő, aki repülőgéppel átrepülte az Atlanti-óceánt egymaga?",
            "Melyik évben halt meg II. Vilmos angol király, a normannok meghódítója?",
            "Ki volt az első római császárnő?",
            "Ki volt a Habsburg Birodalom utolsó császára?",
            "Melyik évben írták alá a Magna Charta-t, az angol alkotmány alapját?",
            "Ki volt a mongol Birodalom első nagy kánja?",
            "Melyik évben kezdődött az első világháború?"
        };


        string[] nehez_valaszok =
        {
            "1096",
            "Constantinus Nagy",
            "1666",
            "Amelia Earhart",
            "1087",
            "Livia",
            "I. Ferenc József",
            "1215",
            "Dzsingisz kán",
            "1914",

        };

        public MainWindow()
        {
            InitializeComponent();
            //myBrush.ImageSource = new BitmapImage(new Uri("", UriKind.Relative)); //majd valami háttér
            //this.Background = myBrush;
            nehez.Visibility = Visibility.Hidden;
            kozepes.Visibility = Visibility.Hidden;
            konnyu.Visibility = Visibility.Hidden;
        }




        private void Start_Click(object sender, RoutedEventArgs e)
        {
            title.Content = "Válassz egy nehézséget:";
            next_button.Visibility = Visibility.Hidden;
            nehez.Visibility = Visibility.Visible;
            kozepes.Visibility = Visibility.Visible;
            konnyu.Visibility = Visibility.Visible;


        }

        private void konnyu_Click(object sender, RoutedEventArgs e)
        {
            page_count++;
            hide_diff_buttons();
            show_opts();

            if(page_count == 1)
            {
                title.Content = page_count + ": " + konnyu_kerdesek[page_count];
                option1.Content = "1492";
                option2.Content = "1507";
                option3.Content = "1515";
                option4.Content = "1523";
            }
            


        }

        private void kozepes_Click(object sender, RoutedEventArgs e)
        {
            page_count++;
            hide_diff_buttons();
            show_opts();
        }


        private void nehez_Click(object sender, RoutedEventArgs e)
        {
            page_count++;
            hide_diff_buttons();
            show_opts();


        }


        private void hide_diff_buttons()
        {
            nehez.Visibility = Visibility.Hidden;
            kozepes.Visibility = Visibility.Hidden;
            konnyu.Visibility = Visibility.Hidden;
        }

        private void show_opts()
        {
            option1.Visibility = Visibility.Visible;
            option2.Visibility = Visibility.Visible;
            option3.Visibility = Visibility.Visible;
            option4.Visibility = Visibility.Visible;
        }

        private void option1_Click(object sender, RoutedEventArgs e)
        {
            if(option1.Content.ToString() == konnyu_valaszok[page_count-1])
            {
                reply_label.Content = "Jó Válasz!";
                reply_label.Foreground = Brushes.Green;
                reply_label.Visibility = Visibility.Visible;
                option1.Background = Brushes.Green;
            }


        }

        private void option2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void option3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void option4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
