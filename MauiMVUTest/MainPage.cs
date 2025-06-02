using System.Globalization;
using CommunityToolkit.Maui.Markup;
using MauiMVUTest.Resources.Strings;
using SQuan.Helpers.Maui.Mvvm;

namespace MauiMVUTest;

/// <summary>This is the main page of the application.</summary>
public partial class MainPage : ContentPage
{
    /// <summary>The number of times the button has been clicked.</summary>
    [BindableProperty] public partial int ClickCount { get; private set; } = 0;

    /// <summary>The text displayed on the label.</summary>
    [BindableProperty] public partial string MyText { get; private set; } = AppStrings.LBL_HELLO;

    /// <summary>Gets the list of supported cultures for localization.</summary>
    public List<CultureInfo> SupportedCultures { get; } = [new CultureInfo("en-US"), new CultureInfo("fr-FR"), new CultureInfo("de-DE")];

    /// <summary>Gets or sets the currently selected culture for the application.</summary>
    [ObservableProperty] public partial CultureInfo SelectedCulture { get; internal set; }

    /// <summary>Initializes a new instance of the <see cref="MainPage"/> class.</summary>
    public MainPage()
    {
        BindingContext = this;
        SelectedCulture = SupportedCultures[0];

        this
            .Bind(
                MainPage.TitleProperty,
                (MainPage ctx) => ctx.SelectedCulture,
                convert: (CultureInfo? culture) => AppStrings.ResourceManager.GetString(nameof(AppStrings.TITLE_HOME), culture))
            .Bind(
                MainPage.MyTextProperty,
                (MainPage ctx) => ctx.SelectedCulture,
                convert: (CultureInfo? culture) => AppStrings.ResourceManager.GetString(nameof(AppStrings.LBL_HELLO), culture))
            ;

        this.Content =
            new VerticalStackLayout()
            {
                Spacing = 25,
                Padding = new Thickness(25, 25, 25, 25),
                Children =
                {
                    new Label()
                    {
                        HorizontalOptions = LayoutOptions.Center,
                    }
                        .Bind(Label.TextProperty, (MainPage ctx) => ctx.MyText),
                    new AppButton()
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        WidthRequest = 300,
                        Command = new Command(() =>
                        {
                            ClickCount++;
                            this
                                .Bind(
                                    MainPage.MyTextProperty,
                                    (MainPage ctx) => ctx.SelectedCulture,
                                    convert: (CultureInfo? culture)
                                        => (AppStrings.ResourceManager.GetString(nameof(AppStrings.LBL_CLICK_COUNT_TIMES), culture) is string format) ? string.Format(format, ClickCount) : string.Empty)
                                ;
                        })
                    }
                        .Bind(
                            Button.TextProperty,
                            (MainPage ctx) => ctx.SelectedCulture,
                            convert: (CultureInfo? culture) => AppStrings.ResourceManager.GetString(nameof(AppStrings.BTN_UPDATE_TEXT), culture))
                        ,
                    new HorizontalStackLayout()
                    {
                        Spacing = 25,
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new AppButton()
                            {
                                Text = SupportedCultures[0].NativeName,
                                Command = new Command(() => { SelectedCulture = SupportedCultures[0]; }),
                            }
                                .Bind(AppButton.IsSelectedProperty, (MainPage ctx) => ctx.SelectedCulture, convert: (CultureInfo? culture) => culture == SupportedCultures[0])
                            ,
                            new AppButton()
                            {
                                Text = SupportedCultures[1].NativeName,
                                Command = new Command(() => { SelectedCulture = SupportedCultures[1]; }),
                            }
                                .Bind(AppButton.IsSelectedProperty, (MainPage ctx) => ctx.SelectedCulture, convert: (CultureInfo? culture) => culture == SupportedCultures[1])
                            ,
                            new AppButton()
                            {
                                Text = SupportedCultures[2].NativeName,
                                Command = new Command(() => { SelectedCulture = SupportedCultures[2]; }),
                            }
                                .Bind(AppButton.IsSelectedProperty, (MainPage ctx) => ctx.SelectedCulture, convert: (CultureInfo? culture) => culture == SupportedCultures[2])
                            ,
                        },
                    },
                }
            };
    }
}
