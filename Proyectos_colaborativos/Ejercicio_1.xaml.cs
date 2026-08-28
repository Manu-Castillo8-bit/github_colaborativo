namespace Proyectos_colaborativos;

public partial class Ejercicio_1 : ContentPage
{
	public Ejercicio_1()
	{
		InitializeComponent();
		NumerosPares.ItemsSource = Enumerable.Range(0, 101).Where(n => n % 2 == 0).ToList();
	}
}