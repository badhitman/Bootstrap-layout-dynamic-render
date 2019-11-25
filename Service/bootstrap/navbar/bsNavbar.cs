////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
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
    public class bsNavbar : ahsDom
    {
        #region Navbar настройки/стили
        //////////////////////////////////////////////////////////////////////////////////////////
        //

        /// <summary>
        /// Navbars require a wrapping .navbar with .navbar-expand{-sm|-md|-lg|-xl} for responsive collapsing and color scheme classes.
        /// </summary>
        public bmSizingsEnum NavbarExpandSize { get; set; } = bmSizingsEnum.Lg;

        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.
        /// Then, customize with .bg-* utilities.
        /// </summary>
        public bmBackgroundColorThemesEnum BackgroundColorTheme { get; set; } = bmBackgroundColorThemesEnum.light;

        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.Then, customize with .bg-* utilities.
        /// </summary>
        public bmMonochromeColorSchemesEnum NavbarColorScheme { get; set; } = bmMonochromeColorSchemesEnum.light;

        /// <summary>
        /// Позиционирование для размещения навигационных панелей в нестатических положениях
        /// </summary>
        public bmNavbarPlacementsEnum NavbarPlacement { get; set; } = bmNavbarPlacementsEnum.Default;

        //
        //////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        public bsNavbarBrand NavbarBrand { get; set; }

        public string CollapseTarget => ID + "NavbarCollapsedContent";

        public bsNavbarActions NavbarActions { get; set; } = new bsNavbarActions();

        public override string ViewComponentName => nameof(brNavbar);
    }
}
