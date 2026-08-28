namespace Proyectos_colaborativos;

public partial class Ejercicio_4 : ContentPage
{
	public Ejercicio_4()
	{
		InitializeComponent();
	}

	private void OnCalcularClicked(object? sender, EventArgs e)
	{
		if (double.TryParse(HorasEntry.Text, out double horas) &&
			double.TryParse(PagoEntry.Text, out double pagoPorHora))
		{
			double sueldo = horas * pagoPorHora;
			ResultadoLabel.Text = $"Sueldo semanal: L. {sueldo:F2}";
		}
		else
		{
			ResultadoLabel.Text = "Ingrese valores válidos.";
			ResultadoLabel.TextColor = Colors.Red;
		}
	}
}
