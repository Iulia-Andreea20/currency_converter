
using System.Diagnostics;

namespace currency_converter;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBtnClicked(object sender, EventArgs e)
	{
		leiOutput.Text = $"{Math.Round(Convert.ToInt32(userInput.Text) * 4.91, 2, MidpointRounding.AwayFromZero)} Lei";
		
		SemanticScreenReader.Announce(leiOutput.Text);
	}

}


