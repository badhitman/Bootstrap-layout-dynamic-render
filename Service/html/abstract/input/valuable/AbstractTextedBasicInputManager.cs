using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input.valuable
{
    public class AbstractTextedBasicInputManager : AbstractInputDataValuableManager
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
        public int SizeWidth { get; set; } = 0;

        public override string StringAttributes
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Placeholder))
                    SetAttribute("placeholder", Placeholder);

                if (!string.IsNullOrWhiteSpace(PatternInput))
                    SetAttribute("pattern", PatternInput);

                return base.StringAttributes;
            }
        }
    }
}
