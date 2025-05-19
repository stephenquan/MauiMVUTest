namespace MauiMVUTest;
public static class ButtonExtensions
{
	public static Button BackgroundColor(this Button button, Color color)
	{
		button.BackgroundColor = color;
		return button;
	}

	public static Button BorderColor(this Button button, Color color)
	{
		button.BorderColor = color;
		return button;
	}

	public static Button BorderWidth(this Button button, double width)
	{
		button.BorderWidth = width;
		return button;
	}

	public static Button CornerRadius(this Button button, int radius)
	{
		button.CornerRadius = radius;
		return button;
	}

	public static Button Text(this Button button, string text)
	{
		button.Text = text;
		return button;
	}

	public static Button TextColor(this Button button, Color color)
	{
		button.TextColor = color;
		return button;
	}

	public static Button Command(this Button button, Action action)
	{
		button.Command = new Command(action);
		return button;
	}
}
