using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    public class ButtonSettingsModel
    {
        /// <summary>
        /// Нужны кнопки, но хотите избежать черезмерно насыщеный цвет фона, которые они приносят?
        /// Замените классы модификаторов по умолчанию на.btn-outline-*, чтобы удалить все фоновые изображения и цвета на любой кнопке.
        /// </summary>
        public bool IsOutlineStyle { get; set; } = false;

        /// <summary>
        /// Create block level buttons—those that span the full width of a parent—by adding .btn-block.
        /// </summary>
        public bool IsBlockBtn { get; set; } = false;

        /// <summary>
        /// Toggle states: 
        /// Add data-toggle="button" to toggle a button’s active state.If you’re pre-toggling a button, you must manually add the.active class and aria-pressed="true" to the<button>.
        /// </summary>
        public bool ToggleActiveState { get; set; } = false;

        public bool IsActive { get; set; } = false;

        public TwinSizingEnum SizeButton { get; set; } = TwinSizingEnum.NULL;

        public BackgroundColorThemesEnum BackgroundColorTheme { get; set; } = BackgroundColorThemesEnum.primary;
    }
}
