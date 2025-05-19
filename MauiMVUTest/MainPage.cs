using AppFramework.Mvvm;
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
						.BindText(nameof(MyText)),
					new Button() { }
						.Text("Update Text")
						.Command(() => { MyText = $"Clicked {++ClickCount} times"; })
				}
			};
	}
}
