using CommunityToolkit.Maui.Markup;

namespace MauiMVUTest;
public static class LabelExtensions
{
	public static Label BindText(this Label label, string propertyName)
	{
		label.Bind(Label.TextProperty, propertyName);
		return label;
	}
}
