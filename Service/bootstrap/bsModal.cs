////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;
using System.Collections.Generic;

namespace BootstrapAspDynamicRender.service
{
    public class bsModal : ahsManagedListNodes
    {
        public override string ViewComponentName => nameof(brModal);

        public new int Tabindex = -1;

        public string Header { get; set; }

        public List<bsButton> FooterExtButtons { get; private set; } = new List<bsButton>();

        public bmModalSizesEnum MaxModalSize { get; set; } = bmModalSizesEnum.Default;

        public bool IsFadeAnimation { get; set; } = false;

        /// <summary>
        /// Кнопка закрытия модлального окна
        /// </summary>
        /// <param name="ButtonHeader">Заголовок кнопки</param>
        /// <param name="BackgroundColorTheme">Цветовая тема кнопки</param>
        /// <param name="SetOutlineStyle">Режим outline стиля для кнопки</param>
        /// <returns></returns>
        public static bsButton GetDefaultButtonDismissFooter(string ButtonHeader = "Cancel", bmBackgroundColorThemesEnum BackgroundColorTheme = bmBackgroundColorThemesEnum.secondary, bool SetOutlineStyle = false)
        {
            bsButton BootstrapButton = new bsButton(ButtonHeader)
            {
                BackgroundColorTheme = BackgroundColorTheme,
                IsOutlineStyle = SetOutlineStyle
            };
            BootstrapButton.SetAttribute("data-dismiss", "modal");

            return BootstrapButton;
        }

        /// <summary>
        /// Кнопка открытия модального окна
        /// </summary>
        /// <param name="ModalId">Dom id объекта модального окна</param>
        /// <param name="ButtonHeader">Заголовок кнопки</param>
        /// <param name="BackgroundColorTheme">Цветовая тема кнопки</param>
        /// <param name="SetOutlineStyle">Режим outline стиля для кнопки</param>
        /// <returns></returns>
        public static bsButton GetDefaultButtonTriggerModal(string ModalId, string ButtonHeader = "Open", bmBackgroundColorThemesEnum BackgroundColorTheme = bmBackgroundColorThemesEnum.secondary, bool SetOutlineStyle = false)
        {
            bsButton BootstrapButton = new bsButton(ButtonHeader)
            {
                BackgroundColorTheme = BackgroundColorTheme,
                IsOutlineStyle = SetOutlineStyle
            };
            BootstrapButton.SetAttribute("data-toggle", "modal");
            BootstrapButton.SetAttribute("data-target", "#" + ModalId);

            return BootstrapButton;
        }

        public override string GetStringAttributes()
        {
            SetAttribute("role", "dialog");
            return base.GetStringAttributes();
        }

        public override string GetStringCSS()
        {
            AddCSS("modal");
            if (IsFadeAnimation)
            {
                AddCSS("fade");
            }
            else
            {
                RemoveCSS("fade");
            }
            return base.GetStringCSS();
        }
    }
}
