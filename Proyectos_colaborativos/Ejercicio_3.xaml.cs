namespace Proyectos_colaborativos;

public partial class Ejercicio_3 : ContentPage
{
	public Ejercicio_3()
	{
		InitializeComponent();
	}

	private void OnGenerateClicked(object? sender, EventArgs e)
	{
		TablesLabel.Text = BuildTables();
	}

	private static string BuildTables()
	{
		var sb = new System.Text.StringBuilder();

		for (int table = 1; table <= 10; table++)
		{
			sb.AppendLine($"Tabla del {table}");
			sb.AppendLine("──────────────");

			for (int multiplier = 1; multiplier <= 10; multiplier++)
			{
				sb.AppendLine($"{table} × {multiplier,2} = {table * multiplier,2}");
			}

			sb.AppendLine();
		}

		return sb.ToString();
	}
}