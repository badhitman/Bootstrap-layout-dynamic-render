using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class ModalManager : ManagedListNodesManager
    {
        public override string ViewComponentName => nameof(BootstrapRenderModal);

        public new int Tabindex = -1;

        public string Header { get; set; }

        public List<BootstrapButtonManager> FooterExtButtons { get; private set; } = new List<BootstrapButtonManager>();

        public BootstrapModalSizesEnum MaxModalSize { get; set; } = BootstrapModalSizesEnum.Default;

        public bool IsFadeAnimation { get; set; } = false;

        /// <summary>
        /// Кнопка закрытия модлального окна
        /// </summary>
        /// <param name="ButtonHeader">Заголовок кнопки</param>
        /// <param name="BackgroundColorTheme">Цветовая тема кнопки</param>
        /// <param name="SetOutlineStyle">Режим outline стиля для кнопки</param>
        /// <returns></returns>
        public static BootstrapButtonManager GetDefaultButtonDismissFooter(string ButtonHeader = "Cancel", BackgroundColorThemesEnum BackgroundColorTheme = BackgroundColorThemesEnum.secondary, bool SetOutlineStyle = false)
        {
            BootstrapButtonManager BootstrapButton = new BootstrapButtonManager(ButtonHeader)
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
        public static BootstrapButtonManager GetDefaultButtonTriggerModal(string ModalId, string ButtonHeader = "Open", BackgroundColorThemesEnum BackgroundColorTheme = BackgroundColorThemesEnum.secondary, bool SetOutlineStyle = false)
        {
            BootstrapButtonManager BootstrapButton = new BootstrapButtonManager(ButtonHeader)
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
