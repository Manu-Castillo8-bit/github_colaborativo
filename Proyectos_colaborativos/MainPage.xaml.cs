using System.Globalization;

namespace Proyectos_colaborativos
{
    public partial class MainPage : ContentPage
    {
        private const double DefaultRate = 18.50;

        public MainPage()
        {
            InitializeComponent();
            RateEntry.Text = DefaultRate.ToString("0.00", CultureInfo.InvariantCulture);
            ResultLabel.Text = "—";
        }

        private void OnConvertClicked(object? sender, EventArgs e)
        {
            if (!double.TryParse(PesosEntry.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double pesos) || pesos < 0)
            {
                ResultLabel.Text = "Ingresa una cantidad válida.";
                return;
            }

            if (!double.TryParse(RateEntry.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double tasa) || tasa <= 0)
            {
                ResultLabel.Text = "Ingresa un tipo de cambio válido.";
                return;
            }

            double dolares = pesos / tasa;
            ResultLabel.Text = $"US$ {dolares:N2}";
        }

        private void OnClearClicked(object? sender, EventArgs e)
        {
            PesosEntry.Text = string.Empty;
            RateEntry.Text = DefaultRate.ToString("0.00", CultureInfo.InvariantCulture);
            ResultLabel.Text = "—";
            PesosEntry.Focus();
        }
    }
}