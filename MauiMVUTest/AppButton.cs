using AppFramework.Mvvm;
using CommunityToolkit.Maui.Markup;

namespace MauiMVUTest;

/// <summary>Represents a button control for the application.</summary>
public partial class AppButton : Button
{
    /// <summary>Gets or sets whether the button is selected.</summary>
    [BindableProperty]
    public partial bool IsSelected { get; set; } = false;

    /// <summary>Initializes a new instance of the <see cref="AppButton"/> class.</summary>
    public AppButton()
    {
        CornerRadius = 5;
        MinimumWidthRequest = 150;
        MinimumHeightRequest = 44;
        TextColor = Colors.White;

        this
            .Bind(Button.OpacityProperty, (AppButton ctx) => ctx.IsPressed, source: this, convert: (bool isPressed) => isPressed ? 0.5 : 1.0)
            .Bind(Button.ScaleProperty, (AppButton ctx) => ctx.IsPressed, source: this, convert: (bool isPressed) => isPressed ? 0.95 : 1.0)
            .Bind(Button.BackgroundColorProperty, (AppButton ctx) => ctx.IsSelected, source: this, convert: (bool isSelected) => isSelected ? Colors.OrangeRed : Colors.Green)
            ;
    }
}
