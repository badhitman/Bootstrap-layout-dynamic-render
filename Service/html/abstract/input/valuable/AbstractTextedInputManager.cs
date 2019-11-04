////////////////////////////////////////////////
// https://github.com/badhitman
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Service.html.input.valuable;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractTextedInputManager : AbstractTextedBasicInputManager
    {
        /// <summary>
        /// Этот атрибут помогает заполнять поля форм текстом, который был введён в них ранее.
        /// Значения сохраняет и подставляет браузер, при этом автозаполнение по соображениям безопасности может отключаться пользователем в настройках и не может в таком случае управляться атрибутом [autocomplete].
        /// </summary>
        public bool? Autocomplete { get; set; } = null;

        public override string GetStringAttributes
        {
            get
            {
                if (SizeWidth > 0)
                    SetAttribute("size", SizeWidth.ToString());

                if (Autocomplete != null)
                    SetAttribute("autocomplete", Autocomplete == true ? "on" : "off");

                return base.GetStringAttributes;
            }
        }
    }
}
