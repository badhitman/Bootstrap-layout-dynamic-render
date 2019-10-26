////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public abstract class AbstractDomManager
    {
        #region Поля
        ///////////////////////////////////////////////
        //

        public abstract string ViewComponentName { get; }

        /// <summary>
        /// HTML Комментирование блока/элемента. Оборачивает текущий блок в два коментария (непосредственно до и после DOM блока).
        /// Если указать только начальный/верхний коментарий, то он же будет использоваться и в нижнем.
        /// </summary>
        public string Before_coment_block { get; set; } = null;
        public string After_coment_block { get; set; } = null;

        /// <summary>
        /// Идентификатор/ID элемента в DOM
        /// </summary>
        public string Id_DOM { get; set; } = null;

        /// <summary>
        /// Имя/Name элемента в DOM
        /// </summary>
        public string Name_DOM { get; set; } = null;

        /// <summary>
        /// Позволяет получить доступ к элементу с помощью заданного сочетания клавиш. Браузеры при этом используют различные комбинации клавиш.
        /// </summary>
        public string Accesskey { get; set; } = null;

        /// <summary>
        /// Сообщает, что элемент доступен для редактирования пользователем — можно удалять текст и вводить новый.
        /// Также работают стандартные команды вроде отмены, вставки текста из буфера и др.
        /// </summary>
        public bool Contenteditable { get; set; } = false;

        /// <summary>
        /// Скрывает содержимое элемента от просмотра. Такой элемент не отображается на странице, но доступен через скрипты
        /// </summary>
        public bool Hidden { get; set; } = false;

        /// <summary>
        /// Устанавливает порядок получения фокуса при переходе между элементами с помощью клавиши Tab.
        /// В случае значения по умолчанию 0 - атрибут не выводится вовсе
        /// </summary>
        public int Tabindex { get; set; } = 0;

        /// <summary>
        /// Текст HTML подсказки/title
        /// </summary>
        public string Title { get; set; } = default;

        //
        ///////////////////////////////////////////////
        #endregion

        #region Управление атрибутами (и событиями) объекта
        ///////////////////////////////////////////////
        //
        /// <summary>
        /// Пользовательские атрибуты текущего HTML элемента
        /// </summary>
        protected Dictionary<string, string> CustomAttributes { get; private set; } = new Dictionary<string, string>();

        /// <summary>
        /// Установить или добавить атрибут.
        /// </summary>
        /// <param name="attr_name">Имя атрибута dom объекта</param>
        /// <param name="attr_value">Если знаение атрибута IS NULL, то генератор объявит имя атрибута у объекта, но не будет указывать значение этого атрибута (т.е. будет пропущен знак = и его значение)</param>
        public AbstractDomManager SetAttribute(string attr_name, string attr_value)
        {
            if (!CustomAttributes.ContainsKey(attr_name))
                CustomAttributes.Add(attr_name, attr_value);
            else
                CustomAttributes[attr_name] = attr_value;

            return this;
        }
        public AbstractDomManager SetAttribute(string attr_name, int attr_value) => SetAttribute(attr_name, attr_value.ToString());
        public AbstractDomManager SetAttribute(string attr_name, double attr_value) => SetAttribute(attr_name, attr_value.ToString());

        /// <summary>
        /// Установить DOM объекту составное значение атрибута
        /// </summary>
        /// <param name="attr_name">Имя атрибута</param>
        /// <param name="attributes">Список значений атрибутов, которые нужно объеденить в одно составное значение</param>
        /// <param name="separator">Символ-разделитель значений в составном значении атрибута</param>
        /// <param name="check_duplicates_attributes">если true - то дубли значений будут исключены из конечного составного значения</param>
        public AbstractDomManager SetAttribute<T>(string attr_name, List<T> attributes, string separator, bool check_duplicates_attributes = true)
        {
            string attr_as_string = "";
            if (check_duplicates_attributes)
                (from attr in attributes group attr by attr.ToString()).ToList().ForEach(e => attr_as_string += " " + e.Key);
            else
                attributes.ForEach(e => attr_as_string += " " + e.ToString());

            attr_as_string = attr_as_string.Trim().Replace(" ", separator);
            if (!string.IsNullOrEmpty(attr_as_string))
                SetAttribute(attr_name, attr_as_string);

            return this;
        }

        /// <summary>
        /// Пакетная установка атрибутов
        /// </summary>
        public AbstractDomManager SetAttribute(Dictionary<string, string> in_custom_atributes)
        {
            foreach (KeyValuePair<string, string> kvp in in_custom_atributes)
                SetAttribute(kvp.Key, kvp.Value);

            return this;
        }

        /// <summary>
        /// Получить значение атрибута
        /// </summary>
        public string GetAttribute(string attr_name)
        {
            if (CustomAttributes.ContainsKey(attr_name))
                return CustomAttributes[attr_name];

            return null;
        }

        /// <summary>
        /// Удалить атрибу (если существует)
        /// </summary>
        public AbstractDomManager RemoveAttribute(string attr_name)
        {
            if (CustomAttributes.ContainsKey(attr_name))
                CustomAttributes.Remove(attr_name);

            return this;
        }

        /// <summary>
        /// Установить DOM элементу обработчик события.
        /// Если "event_src" IsNullOrEmpty, то событие удаляется
        /// </summary>
        public AbstractDomManager SetEvent(UniversalEventsEnum my_event, string event_src)
        {
            if (string.IsNullOrEmpty(event_src))
            {
                if (CustomAttributes.ContainsKey(my_event.ToString("g")))
                    CustomAttributes.Remove(my_event.ToString("g"));
            }
            else
                SetAttribute(my_event.ToString("g"), event_src);

            return this;
        }

        /// <summary>
        /// Получить атрибуты (в том числе события) одной строкой
        /// </summary>
        public virtual string StringAttributes
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Id_DOM))
                    SetAttribute("id", Id_DOM.Trim());

                if (!string.IsNullOrWhiteSpace(Name_DOM))
                    SetAttribute("name", Name_DOM.Trim());

                if (!string.IsNullOrWhiteSpace(Accesskey))
                    SetAttribute("accesskey", Accesskey.Trim());

                if (Contenteditable)
                    SetAttribute("contenteditable", "true");

                if (Hidden)
                    SetAttribute("hidden", null);

                if (Tabindex != default)
                    SetAttribute("tabindex", Tabindex.ToString());

                if (!string.IsNullOrWhiteSpace(Title))
                    SetAttribute("title", Title.Trim());

                string attributes_as_string = " ";

                foreach (KeyValuePair<string, string> kvp in CustomAttributes)
                {
                    if (kvp.Value is null)
                        attributes_as_string += kvp.Key + " ";
                    else
                        attributes_as_string += kvp.Key + "=\"" + kvp.Value + "\" ";
                }
                return attributes_as_string.Trim();
            }
        }
        //
        ///////////////////////////////////////////////
        #endregion

        #region CSS классы стилей
        ///////////////////////////////////////////////
        //
        /// <summary>
        /// Для поиска пробелов в передаваемых CSS классах
        /// </summary>
        private readonly Regex regex_spice = new Regex(@"\s+", RegexOptions.Compiled);

        /// <summary>
        /// CSS стили для элемента
        /// </summary>
        private readonly List<string> css = new List<string>();

        public string[] ReadCSS() => css.ToArray();

        /// <summary>
        /// Добавить CSS класс текущему объекту (если такой класс ещё не назначен объекту)
        /// </summary>
        public AbstractDomManager AddCSS(string css_class, bool check_spices = false, bool low_and_trim_name_class = true)
        {
            if (low_and_trim_name_class)
                css_class = css_class?.Trim().ToLower();

            if (check_spices && regex_spice.IsMatch(css_class))
                foreach (string s in regex_spice.Split(css_class))
                    AddCSS(s, false, false);
            else if (!string.IsNullOrEmpty(css_class) && !css.Contains(css_class))
                css.Add(css_class);
            return this;
        }

        /// <summary>
        /// Удалить класс CSS
        /// </summary>
        public AbstractDomManager RemoveCSS(string css_class, bool check_spices = false)
        {
            if (check_spices && regex_spice.IsMatch(css_class))
            {
                foreach (string s in regex_spice.Split(css_class))
                    RemoveCSS(s, false);
            }
            else if (!string.IsNullOrEmpty(css_class))
                css.Remove(css_class);

            return this;
        }

        /// <summary>
        /// Если класса нет, то будет добавлен. Если класс есть, то будет удалён
        /// </summary>
        public AbstractDomManager TogleCSS(string css_class)
        {
            if (!string.IsNullOrEmpty(css_class))
            {
                if (!css.Contains(css_class))
                    css.Add(css_class);
                else
                    css.Remove(css_class);
            }

            return this;
        }

        public AbstractDomManager ClearCSS()
        {
            css.Clear();
            return this;
        }

        /// <summary>
        /// Получить CSS классы одной строкой (разделитель пробел)
        /// </summary>
        public string StringCSS
        {
            get
            {
                string css_as_string = "";
                css.ForEach(x => css_as_string += " " + x);
                return css_as_string.Trim();
            }
        }
        //
        ///////////////////////////////////////////////
        #endregion    
    }
}
