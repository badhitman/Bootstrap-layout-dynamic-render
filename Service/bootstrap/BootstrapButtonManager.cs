using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using BootstrapViewComponentsRazorLibrary.Components.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapButtonManager : ButtonBaseManager
    {
        public override string ViewComponentName => nameof(HtmlRenderBootstrapButton);

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

        public BootstrapButtonManager(string SetHeader) : base(SetHeader)
        {
            AddCSS("btn");
        }

        public override string GetStringAttributes()
        {
            if (this is BootstrapButtonInputManager)
            {
                switch ((this as BootstrapButtonInputManager).InputType)
                {
                    case BootstrapButtonInputTypesEnum.reset:
                        ButtonType = Models.html.ButtonTypesEnum.reset;
                        break;
                    case BootstrapButtonInputTypesEnum.submit:
                        ButtonType = Models.html.ButtonTypesEnum.submit;
                        break;
                    default:
                        ButtonType = Models.html.ButtonTypesEnum.button;
                        break;
                }
                SetAttribute("type", ButtonType.ToString());
            }
            return base.GetStringAttributes();
        }

        public override string GetStringCSS()
        {
            //get
            //{
            if (BackgroundColorTheme != BackgroundColorThemesEnum.NULL)
                AddCSS("btn-" + (IsOutlineStyle ? "outline-" : "") + BackgroundColorTheme.ToString());

            if (SizeButton != TwinSizingEnum.NULL)
                AddCSS("btn-" + BackgroundColorTheme.ToString());

            if (IsBlockBtn)
                AddCSS("btn-block");

            if (IsActive)
            {
                AddCSS("active");
                SetAttribute("aria-pressed", "true");
            }

            if (ToggleActiveState)
            {
                SetAttribute("data-toggle", "button");
                SetAttribute("autocomplete", "off");
                SetAttribute("aria-pressed", "true");
            }

            return base.GetStringCSS();
            //}
        }
    }
}
