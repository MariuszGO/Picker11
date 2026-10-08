namespace Picker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnObliczClicked(object sender, EventArgs e)
        {
            if (pickerBilet.SelectedIndex == -1)
            {
                wynik.Text = "Wybierz rodzaj biletu";
                return;
            }

            string bilet = pickerBilet.SelectedItem.ToString();

            int ilosc = int.Parse(liczba.SelectedItem.ToString());

            double cena = 0;

            if (bilet == "Normalny")
                cena = 20;
            else if (bilet == "Ulgowy")
                cena = 12;
            else if (bilet == "Dziecięcy")
                cena = 8;

            DateTime wybrana_data = nasza_data.Date ?? DateTime.Today;

            wynik.Text = $"Wybrano: {bilet}\n za  {cena} zł na dzień {wybrana_data:dd.MM.yyyy} . " +
                $"Ilość: {ilosc} sztuk czyli łacznie do zapłaty {ilosc * cena} zł";
        }
    }
}
