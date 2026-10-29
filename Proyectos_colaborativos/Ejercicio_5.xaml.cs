using System.Globalization;

namespace Proyectos_colaborativos;

public partial class Ejercicio_5 : ContentPage
{
    public Ejercicio_5()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(txtPersonas.Text, out int personas) && personas > 0)
        {
            decimal costoPorPlatillo;

            if (personas <= 200)
            {
                costoPorPlatillo = 95.00m;
            }
            else if (personas <= 300)
            {
                costoPorPlatillo = 85.00m;
            }
            else
            {
                costoPorPlatillo = 75.00m;
            }

            decimal presupuestoTotal = personas * costoPorPlatillo;

            // Usamos InvariantCulture para mantener el formato estándar con punto y separador de miles
            var culture = CultureInfo.InvariantCulture;

            lblCostoPlatillo.Text = $"Costo por platillo: ${costoPorPlatillo.ToString("N2", culture)}";
            lblPresupuestoTotal.Text = $"Presupuesto total: ${presupuestoTotal.ToString("N2", culture)}";
        }
        else
        {
            DisplayAlert("Dato inválido", "Por favor, ingrese un número entero mayor a cero.", "Aceptar");
        }
    }
}