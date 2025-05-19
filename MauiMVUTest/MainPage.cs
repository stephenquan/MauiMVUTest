using AppFramework.Mvvm;
using CommunityToolkit.Maui.Markup;
namespace MauiMVUTest;

public partial class MainPage : ContentPage
{
	[BindableProperty] public partial int ClickCount { get; set; } = 0;
	[BindableProperty] public partial string MyText { get; set; } = "Hello, World!";

	public MainPage()
	{
		BindingContext = this;
		this.Content =
			new VerticalStackLayout()
			{
				Spacing = 25,
				Padding = new Thickness(25, 25, 25, 25),
				Children =
				{
					new Label() { }
						.Bind(Label.TextProperty, (MainPage ctx) => ctx.MyText),
					new Button() { }
						.BorderColor(Colors.Green)
						.BorderWidth(1.0)
						.BackgroundColor(Colors.White)
						.CornerRadius(5)
						.Text("Update Text")
						.TextColor(Colors.Green)
						.Command(() => { MyText = $"Clicked {++ClickCount} times"; })
				}
			};
	}
}
