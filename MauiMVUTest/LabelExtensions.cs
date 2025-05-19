namespace MauiMVUTest;

public static class LabelExtensions
{
    public static Label Text(this Label label, string text)
    {
        label.Text = text;
        return label;
    }

    public static Label TextColor(this Label label, Color color)
    {
        label.TextColor = color;
        return label;
    }
}
