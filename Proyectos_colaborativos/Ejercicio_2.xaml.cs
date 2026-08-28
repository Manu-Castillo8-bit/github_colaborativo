namespace Proyectos_colaborativos;

public partial class Ejercicio_2 : ContentPage
{
	private const int StartValue = 10;
	private int _currentValue;
	private bool _isRunning;

	public Ejercicio_2()
	{
		InitializeComponent();
		_currentValue = StartValue;
		CountdownLabel.Text = _currentValue.ToString();
	}

	private async void OnStartClicked(object? sender, EventArgs e)
	{
		if (_isRunning)
			return;

		_isRunning = true;
		StartButton.IsVisible = false;
		ResetButton.IsVisible = true;

		for (int i = StartValue; i >= 1; i--)
		{
			_currentValue = i;
			CountdownLabel.Text = i.ToString();
			await Task.Delay(1000);
		}

		CountdownLabel.Text = "¡Listo!";
	}

	private void OnResetClicked(object? sender, EventArgs e)
	{
		_currentValue = StartValue;
		CountdownLabel.Text = _currentValue.ToString();
		StartButton.IsVisible = true;
		ResetButton.IsVisible = false;
		_isRunning = false;
	}
}
