﻿////////////////////////////////////////////////
// https://github.com/badhitman
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public abstract class ahsTextedInputs : ahsTextedBasicInputs
    {
        /// <summary>
        /// Этот атрибут помогает заполнять поля форм текстом, который был введён в них ранее.
        /// Значения сохраняет и подставляет браузер, при этом автозаполнение по соображениям безопасности может отключаться пользователем в настройках и не может в таком случае управляться атрибутом [autocomplete].
        /// </summary>
        public bool? Autocomplete { get; set; } = null;

        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                if (SizeArea > 0)
                    SetAttribute("size", SizeArea.ToString());
                else
                    RemoveAttribute("size");

                if (Autocomplete != null)
                    SetAttribute("autocomplete", Autocomplete == true ? "on" : "off");
                else
                    RemoveAttribute("autocomplete");
            }

            return base.GetStringAttributes();
        }
    }
}
