
namespace color_maker;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void sldRed_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SetColorElements();
    }

    private void SetColorElements()
    {
        Color color = GetColorHex();

        var colorHex = color.ToHex();

        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        lblHex.Text = colorHex;
    }

    private Color GetColorHex
        ()
    {
        var red = sldRed.Value;
        var green = sldGreen.Value;
        var blue = sldBlue.Value;

        Color color = Color.FromRgb(red, green, blue);
        return color;
    }

    private void sldGreen_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SetColorElements();
    }

    private void sldBlue_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SetColorElements();
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {
        var random = new Random();

        var red   = random.Next(0, 265); 
        var green = random.Next(0, 265);
        var blue  = random.Next(0, 265);

        var color = Color.FromRgb(red, green, blue);

        sldRed.Value   = color.Red;
        sldGreen.Value = color.Green;
        sldBlue.Value  = color.Blue;
      SetColorElements();
    }

    private async  void  ImageButton_Clicked(object sender, EventArgs e)
    {
        Color color = GetColorHex();

        var colorHex = color.ToHex();
        await Clipboard.SetTextAsync(colorHex);
        await DisplayAlert("Atenção", $" Color Copied {colorHex}", "Ok");
    }
}

