namespace MauiMVUTest;

/// <summary>
/// Extension methods for the Label class.
/// </summary>
public static class LabelExtensions
{
    /// <summary>
    /// Sets the background color of the label.
    /// </summary>
    /// <param name="label"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Label Text(this Label label, string text)
    {
        label.Text = text;
        return label;
    }

    /// <summary>
    /// Sets the background color of the label.
    /// </summary>
    /// <param name="label"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static Label TextColor(this Label label, Color color)
    {
        label.TextColor = color;
        return label;
    }
}
