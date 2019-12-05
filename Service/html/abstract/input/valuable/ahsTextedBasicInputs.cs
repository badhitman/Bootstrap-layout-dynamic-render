////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class ahsTextedBasicInputs : ahsValuableDataInputs
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

        public int SizeArea { get; set; } = 0;

        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                if (!string.IsNullOrWhiteSpace(Placeholder))
                    SetAttribute("placeholder", Placeholder);

                if (!string.IsNullOrWhiteSpace(PatternInput))
                    SetAttribute("pattern", PatternInput);

                if(SizeArea != 0)
                    SetAttribute("size", SizeArea.ToString());
            }

            return base.GetStringAttributes();
        }
    }
}
