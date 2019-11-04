using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapButtonManager : ButtonBaseManager
    {
        /// <summary>
        /// Нужны кнопки, но хотите избежать черезмерно насыщеный цвет фона, которые они приносят?
        /// Замените классы модификаторов по умолчанию на.btn-outline-*, чтобы удалить все фоновые изображения и цвета на любой кнопке.
        /// </summary>
        public bool IsOutlineStyle { get; set; } = false;

        public BackgroundColorThemesEnum BackgroundColorTheme { get; set; } = BackgroundColorThemesEnum.primary;

        public BootstrapButtonManager(string SetHeader) : base(SetHeader) { }

        public override string StringCSS
        {
            get
            {
                if (BackgroundColorTheme != BackgroundColorThemesEnum.NULL)
                    AddCSS("btn-" + (IsOutlineStyle ? "outline-" : "") + BackgroundColorTheme.ToString());

                return base.StringCSS;
            }
        }
    }
}
