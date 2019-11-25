////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class bsButton : hsButton
    {
        public override string ViewComponentName => nameof(brButton);

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

        public bmTwinSizingsEnum SizeButton { get; set; } = bmTwinSizingsEnum.NULL;

        public bmBackgroundColorThemesEnum BackgroundColorTheme { get; set; } = bmBackgroundColorThemesEnum.primary;

        public bsButton(string SetHeader) : base(SetHeader)
        {

        }

        public override string GetStringAttributes()
        {
            if (this is bsButtonInput)
            {
                switch ((this as bsButtonInput).InputType)
                {
                    case bmButtonInputTypesEnum.reset:
                        ButtonType = hmhmButtonTypesEnum.reset;
                        break;
                    case bmButtonInputTypesEnum.submit:
                        ButtonType = hmhmButtonTypesEnum.submit;
                        break;
                    default:
                        ButtonType = hmhmButtonTypesEnum.button;
                        break;
                }
                SetAttribute("type", ButtonType.ToString());
            }

            if (IsActive)
                SetAttribute("aria-pressed", "true");

            if (ToggleActiveState)
            {
                SetAttribute("data-toggle", "button");
                SetAttribute("autocomplete", "off");
                SetAttribute("aria-pressed", "true");
            }

            return base.GetStringAttributes();
        }

        public override string GetStringCSS()
        {
            AddCSS("btn");

            if (BackgroundColorTheme != bmBackgroundColorThemesEnum.NULL)
                AddCSS("btn-" + (IsOutlineStyle ? "outline-" : "") + BackgroundColorTheme.ToString());

            if (SizeButton != bmTwinSizingsEnum.NULL)
                AddCSS("btn-" + SizeButton.ToString().ToLower());

            if (IsBlockBtn)
                AddCSS("btn-block");

            if (IsActive)
                AddCSS("active");

            return base.GetStringCSS();
        }
    }
}
