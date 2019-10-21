////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    /// <summary>
    /// Navbars поставляются со встроенной поддержкой нескольких субкомпонентов:
    /// 
    ///     .navbar-brand для названия вашей компании, продукта или проекта. В том числе с аватаркой/картинкой.
    ///     .navbar-nav для full-height и lightweight навигации (включая поддержку выпадающих меню).
    ///     .navbar-toggler для использования с нашим плагином collapse и другими способами переключения навигации.
    ///     .form-inline для любых элементов управления и действий формы.
    ///     .navbar-text для добавления вертикально центрированных строк текста.
    ///     .collapse.navbar-collapse для группировки и скрытия содержимого навигационной панели.
    /// </summary>
    public class NavbarManager : AbstractDomManager
    {
        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.
        /// Then, customize with .bg-* utilities.
        /// </summary>
        public BackgroundColorThemesEnum BackgroundColorTheme { get; private set; } = BackgroundColorThemesEnum.NULL;

        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.Then, customize with .bg-* utilities.
        /// </summary>
        public NavbarColorSchemesEnum NavbarColorScheme { get; private set; } = NavbarColorSchemesEnum.NULL;

        /// <summary>
        /// Navbars require a wrapping .navbar with .navbar-expand{-sm|-md|-lg|-xl} for responsive collapsing and color scheme classes.
        /// </summary>
        public BootstrapSizingEnum NavbarExpandSize { get; private set; } = BootstrapSizingEnum.NULL;

        /// <summary>
        /// Adding images to the .navbar-brand will likely always require custom styles or utilities to properly size.
        /// Here are some examples to demonstrate.
        /// </summary>
        public string ImageNavbarBrand { get; set; } = null;

        /// <summary>
        /// The .navbar-brand can be applied to most elements, but an anchor works best as some elements might require utility classes or custom styles.
        /// </summary>
        public NavItemModel NavbarBrand { get; set; } = null;

        public AbstractNavManager NavLeft { get; set; }

        /// <summary>
        /// Navbars may contain bits of text with the help of .navbar-text.
        /// This class adjusts vertical alignment and horizontal spacing for strings of text.
        /// </summary>
        public string NavbarInlineText { get; set; }

        /// <summary>
        /// Place various form controls and components within a navbar with .form-inline.
        /// </summary>
        public FormManager FormInline { get; set; } = null;

        public AbstractNavManager NavRight { get; set; }

        public NavbarManager(BackgroundColorThemesEnum SetBackgroundColorTheme = BackgroundColorThemesEnum.light, NavbarColorSchemesEnum SetNavbarColorScheme = NavbarColorSchemesEnum.light, BootstrapSizingEnum SetNavbarExpandSize = BootstrapSizingEnum.Lg)
        {
            AddCSS("navbar");

            NavbarExpandSize = SetNavbarExpandSize;
            if (NavbarExpandSize != BootstrapSizingEnum.NULL)
                AddCSS("navbar-expand-" + NavbarExpandSize.ToString().ToLower());

            BackgroundColorTheme = SetBackgroundColorTheme;
            if (BackgroundColorTheme != BackgroundColorThemesEnum.NULL)
                AddCSS("bg-" + BackgroundColorTheme.ToString());

            if (SetNavbarColorScheme != NavbarColorSchemesEnum.NULL)
                AddCSS("navbar-" + SetNavbarColorScheme.ToString());



        }
    }
}
