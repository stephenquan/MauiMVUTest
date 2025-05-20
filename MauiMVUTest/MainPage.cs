using AppFramework.Mvvm;
using CommunityToolkit.Maui.Markup;
namespace MauiMVUTest;

/// <summary>This is the main page of the application.</summary>
public partial class MainPage : ContentPage
{
    /// <summary>The number of times the button has been clicked.</summary>
    [BindableProperty] public partial int ClickCount { get; private set; } = 0;

    /// <summary>The text displayed on the label.</summary>
    [BindableProperty] public partial string MyText { get; private set; } = "Hello, World!";

    /// <summary>Initializes a new instance of the <see cref="MainPage"/> class.</summary>
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
                    new Label()
                    {
                    }
                        .Bind(Label.TextProperty, (MainPage ctx) => ctx.MyText),
                    new Button()
                    {
                        BorderColor = Colors.Green,
                        BorderWidth = 1.0,
                        BackgroundColor = Colors.White,
                        CornerRadius = 5,
                        Text = "Update Text",
                        TextColor = Colors.Green,
                        Command = new Command(() => { MyText = $"Clicked {++ClickCount} times"; })
                    }
                }
            };
    }
}
