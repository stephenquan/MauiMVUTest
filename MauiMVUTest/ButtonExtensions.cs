namespace MauiMVUTest;
public static class ButtonExtensions
{
	public static Button Text(this Button button, string text)
	{
		button.Text = text;
		return button;
	}

	public static Button Command(this Button button, Action action)
	{
		button.Command = new Command(action);
		return button;
	}
}
