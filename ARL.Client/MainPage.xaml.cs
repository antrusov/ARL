using ARL.Logic.Settings;
using Microsoft.Extensions.Options;

namespace ARL.Client;

public partial class MainPage : ContentPage
{
    private readonly GameSettings _gameSettings;
    int count = 0;

	public MainPage(IOptions<GameSettings> gameSettings)
	{
		InitializeComponent();

		_gameSettings = gameSettings.Value;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time ({_gameSettings.GameDefinitionJsonFile})";
		else
			CounterBtn.Text = $"Clicked {count} times ({_gameSettings.GameDefinitionJsonFile})";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

