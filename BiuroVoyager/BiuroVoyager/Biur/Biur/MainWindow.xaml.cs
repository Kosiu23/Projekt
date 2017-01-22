using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Biur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Gotowe oferty, dane są przypisane
        Wycieczki Grecja1 = new Wycieczki("Grecja", "Tak", 1,2000,"2017-03-24");
        Wycieczki Grecja2 = new Wycieczki("Grecja", "Nie", 2,1500,"2017-03-21");
        Wycieczki Turcja1 = new Wycieczki("Turcja", "Tak", 1,1800,"2017-01-24");
        Szczegoly Grecja = new Szczegoly("Grecja", "Apollo", "Niesamowite widoki,hotel z basenem w pobliżu morza");
        Szczegoly Turcja = new Szczegoly("Turcja", "Arsima", "Orientalny klimat i kultura");
        private Zamowienie zamowienie = new Zamowienie();

        public MainWindow()
        {
            InitializeComponent();
            UkryjWiekszosc();
        }
        public void UkryjWiekszosc() //Ukrywa większość przycisków,textboxów i labelów
        {
            CWycieczki.Visibility = Visibility.Hidden;
            OfertyText.Visibility = Visibility.Hidden;
            CKraj.Visibility = Visibility.Hidden;
            CWyzywienie.Visibility = Visibility.Hidden;
            Ciloscosob.Visibility = Visibility.Hidden;
            LKraj.Visibility = Visibility.Hidden;
            LWyzywienie.Visibility = Visibility.Hidden;
            LIloscosob.Visibility = Visibility.Hidden;
            BSzukaj.Visibility = Visibility.Hidden;
            LCena.Visibility = Visibility.Hidden;
            TCena.Visibility = Visibility.Hidden;
            BSzczegoly.Visibility = Visibility.Hidden;
            TSzczegoly.Visibility = Visibility.Hidden;
            L2PodajKraj.Visibility = Visibility.Hidden;
            L2Wyzywienie.Visibility = Visibility.Hidden;
            L2Iloscosob.Visibility = Visibility.Hidden;
            L2Cena.Visibility = Visibility.Hidden;
            L2Data.Visibility = Visibility.Hidden;
            T2PodajKraj.Visibility = Visibility.Hidden;
            T2Wyzywienie.Visibility = Visibility.Hidden;
            T2Podajiloscosob.Visibility = Visibility.Hidden;
            T2WpiszCene.Visibility = Visibility.Hidden;
            T2Data.Visibility = Visibility.Hidden;
            TPokaZamow.Visibility = Visibility.Hidden;
            BZamowienieWyc.Visibility = Visibility.Hidden;
            BCzyszczenie.Visibility = Visibility.Hidden;
            BZamowWycieczki2.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Hidden;
        }
        public void OdkryjZamowienie()//Odkrywa rzeczy związane z Zamówieniem
        {
            L2PodajKraj.Visibility = Visibility.Visible;
            L2Wyzywienie.Visibility = Visibility.Visible;
            L2Iloscosob.Visibility = Visibility.Visible;
            L2Cena.Visibility = Visibility.Visible;
            L2Data.Visibility = Visibility.Visible;
            T2PodajKraj.Visibility = Visibility.Visible;
            T2Wyzywienie.Visibility = Visibility.Visible;
            T2Podajiloscosob.Visibility = Visibility.Visible;
            T2WpiszCene.Visibility = Visibility.Visible;
            T2Data.Visibility = Visibility.Visible;
            BZamowienieWyc.Visibility = Visibility.Visible;
        }

        private void BWyc_Click(object sender, RoutedEventArgs e)
        {
            UkryjWiekszosc();
            CWycieczki.Visibility = Visibility.Visible;
            BZamowWycieczki2.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Hidden;
        }
        private void CWycieczki_SelectionChanged(object sender, SelectionChangedEventArgs e)//Gdy wybierzemy jakiś Combobox 
            //wtedy pojawia nam się okienko z informacją, w której później bedą informacje o wybranej wycieczce i pojawia się przycisk Szczegóły
        {
            OfertyText.Visibility = Visibility.Visible;
            BSzczegoly.Visibility = Visibility.Visible;

        }
        private void OfertyText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //OfertyText.Text = Grecja1.Informacja();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e) //gdy wbybierzemy Oferta 1 wtedy
        //dostaniemy informacje o tej wycieczce
        {
            OfertyText.Text = Grecja1.Informacja();
            TSzczegoly.Visibility = Visibility.Hidden;
            TPokaZamow.Visibility = Visibility.Hidden;
            BCzyszczenie.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Visible;
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)//gdy wbybierzemy Oferta 2 wtedy
        //dostaniemy informacje o tej wycieczce
        {
            OfertyText.Text = Grecja2.Informacja();
            TSzczegoly.Visibility = Visibility.Hidden;
            TPokaZamow.Visibility = Visibility.Hidden;
            BCzyszczenie.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Visible;
        }
        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)//gdy wbybierzemy Oferta 3 wtedy
        //dostaniemy informacje o tej wycieczce
        {
            OfertyText.Text = Turcja1.Informacja();
            TSzczegoly.Visibility = Visibility.Hidden;
            TPokaZamow.Visibility = Visibility.Hidden;
            BCzyszczenie.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Visible;
        }

        private void BZnajdz_Click(object sender, RoutedEventArgs e)//Ukrywa i odkrywa różne opcje po wciśnięciu przycisku Znajdź ofertę
        {
            UkryjWiekszosc();
            CKraj.Visibility = Visibility.Visible;
            LKraj.Visibility = Visibility.Visible;
            BZamowWycieczki2.Visibility = Visibility.Hidden;
            BZamowWycieczki3.Visibility = Visibility.Hidden;

        }

        private void CKraj_SelectionChanged(object sender, SelectionChangedEventArgs e)//Związane ze Znajdź ofertę
        //gdy wybierzemy kraj dopiero pojawia nam się Combobox do wyboru wyżywienia
        {
            CWyzywienie.Visibility = Visibility.Visible;
            LWyzywienie.Visibility = Visibility.Visible;
        }

        private void CWyzywienie_SelectionChanged(object sender, SelectionChangedEventArgs e)//Związane ze Znajdź ofertę
        //gdy wybierzemy wyzywienie dopiero pojawia nam się Combobox do wyboru ilości osób
        {
            Ciloscosob.Visibility = Visibility.Visible;
            LIloscosob.Visibility = Visibility.Visible;
        }

        private void Ciloscosob_SelectionChanged(object sender, SelectionChangedEventArgs e)//Związane ze Znajdź ofertę
        //gdy wybierzemy ilość osób dopiero pojawia nam się okienko do wpisania ceny
        {
            LCena.Visibility = Visibility.Visible;
            TCena.Visibility = Visibility.Visible;
            
        }
        private void TCena_TextChanged(object sender, TextChangedEventArgs e)//Związane ze Znajdź ofertę
        //gdy wpiszemy cenę dopiero pojawia nam się przycisk szukaj
        {
            BSzukaj.Visibility = Visibility.Visible;
        }

        private void BSzukaj_Click(object sender, RoutedEventArgs e)
        {
            BZamowWycieczki2.Visibility = Visibility.Hidden;
            TPokaZamow.Visibility = Visibility.Hidden;
            BCzyszczenie.Visibility = Visibility.Hidden;
            BZamowWycieczki2.Visibility = Visibility.Visible;
            int szukcena = Convert.ToInt32(TCena.Text);//konwersja wpisywanej ceny do int
            bool Gr1 = true;
            bool Gr2 = true;
            bool Tr1 = true;
            //Gr1,Gr2,Tr1 przydadzą się potem, potrzebne żeby nie wpisywać tej długiej części poniżej

                if (Gr1==(CKraj.Text == "Grecja" && CWyzywienie.Text == "Tak" && Ciloscosob.Text == "1" && szukcena >=2000))
                //Warunki co ma się pojawić po wybraniu danych opcji
                {
                    OfertyText.Visibility = Visibility.Visible;
                    OfertyText.Text = Grecja1.Informacja();
                    BSzczegoly.Visibility = Visibility.Visible;
            }
                else if (Gr2==(CKraj.Text == "Grecja" && CWyzywienie.Text == "Nie" && Ciloscosob.Text == "2" && szukcena >= 1500))
                {
                    OfertyText.Visibility = Visibility.Visible;
                    OfertyText.Text = Grecja2.Informacja();
                    BSzczegoly.Visibility = Visibility.Visible;
                    BZamowWycieczki2.Visibility = Visibility.Visible;
            }
                else if (Tr1==(CKraj.Text == "Turcja" && CWyzywienie.Text == "Tak" && Ciloscosob.Text == "1" && szukcena >= 1800))
                {
                    OfertyText.Visibility = Visibility.Visible;
                    OfertyText.Text = Turcja1.Informacja();
                    BSzczegoly.Visibility = Visibility.Visible;
                    BZamowWycieczki2.Visibility = Visibility.Visible;
            }
            
            else
            {
                //gdy wybierzemy opcje dla których nie ma oferty pojawi się wiadomość
                OfertyText.Visibility = Visibility.Hidden;
                TSzczegoly.Visibility = Visibility.Hidden;
                BSzczegoly.Visibility = Visibility.Hidden;
                BZamowWycieczki2.Visibility = Visibility.Hidden;
                MessageBox.Show("Nie mamy takiej oferty");
            }

        }

        private void BSzczegoly_Click(object sender, RoutedEventArgs e)
        {
            bool Gr1 = true;
            bool Gr2 = true;
            bool Tr1 = true;
            TSzczegoly.Visibility = Visibility.Visible;
            //Przycisk szczegóły dla Wycieczki
            //Gdy w OfertText pojawi się dana informacja o ofercie, wtedy zostaną wyświetlone odpowiednie dalsze szczegóły
            //po kliknięciu przcisku szczegóły
            if(OfertyText.Text == Grecja1.Informacja())
            {
                TSzczegoly.Text = Grecja.Informacja();
            }
            else if(OfertyText.Text==Grecja2.Informacja())
            {
                TSzczegoly.Text = Grecja.Informacja();
            }
            else if (OfertyText.Text == Turcja1.Informacja())
            {
                TSzczegoly.Text = Turcja.Informacja();
            }
            //Przycisk szczegóły dla Znajdź ofertę
            //jeśli wybierzemy odpowiednie opcje wtedy zostaną wyświetlone odpowiednie szczegóły po kliknięciu przycisku szczegóły
            else if(Gr1)
            {
                TSzczegoly.Text = Grecja.Informacja();
            }
            else if (Gr2)
            {
                TSzczegoly.Text = Grecja.Informacja();
            }
            else if (Tr1)
            {
                TSzczegoly.Text = Turcja.Informacja();
            }

        }
        private void BZamowienie_Click(object sender, RoutedEventArgs e)//Gdy klikniemy w przycisk Zamówienie, wtedy zostaną
        //ukryte i odkryte odpowiednie opcje
        {
            UkryjWiekszosc();
            OdkryjZamowienie();
        }

        private void BZamowienieWyc_Click(object sender, RoutedEventArgs e)
        {
            //Dotyczy opcji Zamówienie
            //Gdy wpiszemy odpowiednie wartości wtedy będzie możliwość zamówienia
            //w przeciwnym razie pojawią się informacje o popełnionych błędach
            try
            {
                if(T2PodajKraj.Text=="" & T2Wyzywienie.Text=="" & T2Podajiloscosob.Text=="" & T2WpiszCene.Text=="" & T2Data.Text=="")
                {
                    throw new Exception("Proszę wypełnić pola");
                }
                if (T2PodajKraj.Text != "Grecja" & T2PodajKraj.Text != "Turcja") throw new Exception("Do wyboru Grecja lub Turcja");
                if (T2Wyzywienie.Text != "Tak" & T2Wyzywienie.Text != "Nie") throw new Exception("Wpisz Tak lub Nie");
                if (T2Podajiloscosob.Text == "") throw new Exception("Podaj ilość osób");
                int ilosc = Convert.ToInt32(T2Podajiloscosob.Text);
                if (ilosc <= 0 || ilosc > 2) throw new Exception("Wyłącznie 1 lub 2 osoby");
                if (T2WpiszCene.Text == "") throw new Exception("Wpisz cenę");
                double cenaWyc = Convert.ToDouble(T2WpiszCene.Text);
                if (cenaWyc <= 0) throw new Exception("Cena nie może być mniejsza od zera");;
                if (T2Data.Text == "") throw new Exception("Wpisz datę w formacie Rok-Miesiąc-Dzień");
                DateTime dataWyc = Convert.ToDateTime(T2Data.Text);
                if (dataWyc < DateTime.Today) throw new Exception("Nie można wpisywać dat przeszłych");
                if (T2Data.Text != (dataWyc.ToString("yyyy-MM-dd"))) throw new Exception("Wpisz rok-miesiac-dzien");
                if (T2PodajKraj.Text == "Grecja" & T2Wyzywienie.Text == "Tak" & ilosc == 1 & cenaWyc == 2000)
                {
                    zamowienie.DodajWycieczke(T2PodajKraj.Text, T2Wyzywienie.Text, ilosc, cenaWyc,T2Data.Text);
                    TPokaZamow.Text = zamowienie.PodajZawartosc();
                    TPokaZamow.Visibility = Visibility.Visible;
                    BCzyszczenie.Visibility = Visibility.Visible;
                }
                else if(T2PodajKraj.Text == "Grecja" & T2Wyzywienie.Text == "Nie" & ilosc == 2 & cenaWyc == 1500)
                {
                    zamowienie.DodajWycieczke(T2PodajKraj.Text, T2Wyzywienie.Text, ilosc, cenaWyc,T2Data.Text);
                    TPokaZamow.Text = zamowienie.PodajZawartosc();
                    TPokaZamow.Visibility = Visibility.Visible;
                    BCzyszczenie.Visibility = Visibility.Visible;
                }
                else if(T2PodajKraj.Text == "Turcja" & T2Wyzywienie.Text == "Tak" & ilosc == 1 & cenaWyc == 1800)
                {
                    zamowienie.DodajWycieczke(T2PodajKraj.Text, T2Wyzywienie.Text, ilosc, cenaWyc,T2Data.Text);
                    TPokaZamow.Text = zamowienie.PodajZawartosc();
                    TPokaZamow.Visibility = Visibility.Visible;
                    BCzyszczenie.Visibility = Visibility.Visible;
                }
                else
                {
                    throw new Exception("Nie ma takiej oferty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BCzyszczenie_Click(object sender, RoutedEventArgs e)//Usuwa zamówienia
        {
            zamowienie.UsunWszystko();
            TPokaZamow.Text = "Brak zamówienia";
        }

        private void BZamowWycieczki2_Click(object sender, RoutedEventArgs e)//Ten przycisk dotyczy zamówienia
        //poprzez opcję Znajdź ofertę, gdy wybraliśmy odpowiednie opcje pojawi się przycisk i będzie możliwe zamówienie
        {

            int szukcena = Convert.ToInt32(TCena.Text);
            if (CKraj.Text == "Grecja" && CWyzywienie.Text == "Tak" && Ciloscosob.Text == "1" && szukcena >= 2000)
            {
                TPokaZamow.Text = Grecja1.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }
            else if(CKraj.Text == "Grecja" && CWyzywienie.Text == "Nie" && Ciloscosob.Text == "2" && szukcena >= 1500)
            {
                TPokaZamow.Text = Grecja2.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }
            else if(CKraj.Text == "Turcja" && CWyzywienie.Text == "Tak" && Ciloscosob.Text == "1" && szukcena >= 1800)
            {
                TPokaZamow.Text = Turcja1.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }    
        }

        private void BZamowWycieczki3_Click(object sender, RoutedEventArgs e)//Ten przycisk dotyczy zamówienia
        //poprzez opcję Wycieczki, gdy wybraliśmy odpowiednią ofertę pojawi się przycisk i będzie możliwe zamówienie
        {
            if (CWycieczki.Text == "Oferta 1")
            {
                TPokaZamow.Text = Grecja1.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }
            else if (CWycieczki.Text == "Oferta 2")
            {
                TPokaZamow.Text = Grecja2.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }
            else if (CWycieczki.Text == "Oferta 3")
            {
                TPokaZamow.Text = Turcja1.Informacja();
                TPokaZamow.Visibility = Visibility.Visible;
                BCzyszczenie.Visibility = Visibility.Visible;
            }
        }

        private void BWyjście_Click(object sender, RoutedEventArgs e)//Wyjście z aplikacji
        {
            Environment.Exit(0);
        }
    }
}
