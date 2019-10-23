﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap.navbar;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;

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
        #region Navbar настройки/стили
        //////////////////////////////////////////////////////////////////////////////////////////
        //

        /// <summary>
        /// Navbars require a wrapping .navbar with .navbar-expand{-sm|-md|-lg|-xl} for responsive collapsing and color scheme classes.
        /// </summary>
        public BootstrapSizingEnum NavbarExpandSize { get; set; } = BootstrapSizingEnum.Lg;

        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.
        /// Then, customize with .bg-* utilities.
        /// </summary>
        public BackgroundColorThemesEnum BackgroundColorTheme { get; private set; } = BackgroundColorThemesEnum.light;

        /// <summary>
        /// Color schemes
        /// 
        /// Theming the navbar has never been easier thanks to the combination of theming classes and background-color utilities.
        /// Choose from.navbar-light for use with light background colors, or.navbar-dark for dark background colors.Then, customize with .bg-* utilities.
        /// </summary>
        public NavbarColorSchemesEnum NavbarColorScheme { get; private set; } = NavbarColorSchemesEnum.light;

        /// <summary>
        /// Позиционирование для размещения навигационных панелей в нестатических положениях
        /// </summary>
        public NavbarPlacementsEnum NavbarPlacement { get; set; } = NavbarPlacementsEnum.Default;

        //
        //////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        public NavbarBrandManager NavbarBrand { get; set; }

        public string CollapseTarget  => Id_DOM + "NavbarCollapsedContent";
        public NavbarBodyManager NavbarBody { get; set; } = new NavbarBodyManager();

        public NavbarManager()
        {
            
        }
    }
}
