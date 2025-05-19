namespace MauiMVUTest;

/// <summary>
/// Extension methods for the Button class.
/// </summary>
public static class ButtonExtensions
{
    /// <summary>
    /// Sets the background color of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static Button BackgroundColor(this Button button, Color color)
    {
        button.BackgroundColor = color;
        return button;
    }

    /// <summary>
    /// Sets the border color of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static Button BorderColor(this Button button, Color color)
    {
        button.BorderColor = color;
        return button;
    }

    /// <summary>
    /// Sets the border width of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="width"></param>
    /// <returns></returns>
    public static Button BorderWidth(this Button button, double width)
    {
        button.BorderWidth = width;
        return button;
    }

    /// <summary>
    /// Sets the corner radius of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="radius"></param>
    /// <returns></returns>
    public static Button CornerRadius(this Button button, int radius)
    {
        button.CornerRadius = radius;
        return button;
    }

    /// <summary>
    /// Sets the text of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Button Text(this Button button, string text)
    {
        button.Text = text;
        return button;
    }

    /// <summary>
    /// Sets the text color of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static Button TextColor(this Button button, Color color)
    {
        button.TextColor = color;
        return button;
    }

    /// <summary>
    /// Sets the command of the button.
    /// </summary>
    /// <param name="button"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static Button Command(this Button button, Action action)
    {
        button.Command = new Command(action);
        return button;
    }
}
