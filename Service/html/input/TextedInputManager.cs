////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using BootstrapViewComponents;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class TextedInputManager : InputManager
    {
        /// <summary>
        /// Выводит текст внутри поля формы, который исчезает при получении фокуса.
        /// Если внутри строки предполагается пробел, ее необходимо брать в двойные или одинарные кавычки.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// Указывает регулярное выражение, согласно которому требуется вводить и проверять данные в поле формы.
        /// Если присутствует атрибут [pattern], то форма не будет отправляться, пока поле не будет заполнено правильно.
        /// </summary>
        public string PatternInput { get; set; }

        /// <summary>
        /// Ширина текстового поля, которое определяется числом символов моноширинного шрифта.
        /// Иными словами, ширина задается количеством близстоящих букв одинаковой ширины по горизонтали.
        /// Если размер шрифта изменяется с помощью стилей, ширина также соответственно меняется. 
        /// </summary>
        public int SizeInput { get; set; } = 0;

        /// <summary>
        /// Этот атрибут помогает заполнять поля форм текстом, который был введён в них ранее.
        /// Значения сохраняет и подставляет браузер, при этом автозаполнение по соображениям безопасности может отключаться пользователем в настройках и не может в таком случае управляться атрибутом [autocomplete].
        /// </summary>
        public bool? Autocomplete { get; set; } = null;

        public TextedInputManager(InputTypesEnum SetInputType) : base(SetInputType)
        {

        }

        public override string StringAttributes
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Placeholder))
                    SetAttribute("placeholder", Placeholder);
                
                if (!string.IsNullOrWhiteSpace(PatternInput))
                    SetAttribute("pattern", PatternInput);

                if (SizeInput>0)
                    SetAttribute("size", SizeInput);
                
                if (Autocomplete != null)
                    SetAttribute("autocomplete", Autocomplete == true ? "on" : "off");

                return base.StringAttributes;
            }
        }
    }
}
