////////////////////////////////////////////////
// https://github.com/badhitman
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

        /// <summary>
        /// Имя компонента для рендеринга
        /// </summary>
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
        public string ID { get; set; } = null;

        /// <summary>
        /// Имя/Name элемента в DOM
        /// </summary>
        public string Name { get; set; } = null;

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

        private static readonly string[] IndependentAttributes = new string[] { "style", "class" };

        /// <summary>
        /// Пользовательские атрибуты текущего HTML элемента
        /// </summary>
        protected SortedDictionary<string, string> CustomAttributes { get; private set; } = new SortedDictionary<string, string>();

        public List<KeyValuePair<string, string>> ReadAttributes() => CustomAttributes.ToList();

        /// <summary>
        /// Установить значение атрибута (добавить если атрибут отсутсвует).
        /// </summary>
        /// <param name="attr_name">Имя атрибута dom объекта</param>
        /// <param name="attr_value">Если знаение атрибута IS NULL, то генератор объявит имя атрибута без упоминания значения этого атрибута (т.е. будет пропущен знак = и его значение)</param>
        public AbstractDomManager SetAttribute(string attr_name, string attr_value)
        {
            attr_name = attr_name.Trim().ToLower();

            if (IndependentAttributes.Contains(attr_name))
                return this;

            if (attr_name == "id")
                ID = attr_value;

            if (attr_name == "name")
                Name = attr_value;

            if (attr_name == "accesskey")
                Accesskey = attr_value;

            if (attr_name == "contenteditable")
                Contenteditable = attr_value.ToLower() == "true";

            if (attr_name == "hidden")
                Hidden = true;

            if (attr_name == "tabindex")
            {
                if (!Regex.IsMatch(attr_value, @"^-?\d+$"))
                    return this;
                Tabindex = int.Parse(attr_value);
            }
            if (attr_name == "title")
                Title = attr_value;

            if (!CustomAttributes.ContainsKey(attr_name))
                CustomAttributes.Add(attr_name, attr_value);
            else
                CustomAttributes[attr_name] = attr_value;

            return this;
        }

        public AbstractDomManager SetAttribute(List<KeyValuePair<string, string>> attributes)
        {
            attributes.ForEach(x=> SetAttribute(x.Key, x.Value));
            return this;
        }

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
        public virtual string GetStringAttributes()
        {
            //get
            //{
                if (!string.IsNullOrWhiteSpace(ID))
                    SetAttribute("id", ID.Trim());

                if (!string.IsNullOrWhiteSpace(Name))
                    SetAttribute("name", Name.Trim());

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

                if (css.Count > 0)
                    attributes_as_string += "class=\"" + GetStringCSS() + "\" ";

                if (CustomStyles.Count > 0)
                    attributes_as_string += "style=\"" + GetStringStyles() + "\" ";

                return attributes_as_string.Trim();
            //}
        }

        //
        ///////////////////////////////////////////////
        #endregion

        #region Управление стилями/style объекта
        ///////////////////////////////////////////////
        //

        /// <summary>
        /// Пользовательские стили текущего HTML элемента
        /// </summary>
        protected SortedDictionary<string, string> CustomStyles { get; private set; } = new SortedDictionary<string, string>();

        /// <summary>
        /// Установить значение стиля (добавить если стиль отсутсвует).
        /// </summary>
        /// <param name="style_name">Имя стиля dom объекта</param>
        /// <param name="style_value">Знаение стиля</param>
        public AbstractDomManager SetStyle(string style_name, string style_value)
        {
            style_name = style_name.Trim().ToLower().Trim();
            style_value = style_value.Trim().ToLower().Trim();

            if (string.IsNullOrWhiteSpace(style_name) || string.IsNullOrWhiteSpace(style_value))
                return this;

            if (!CustomStyles.ContainsKey(style_name))
                CustomStyles.Add(style_name, style_value);
            else
                CustomStyles[style_name] = style_value;

            return this;
        }

        /// <summary>
        /// Получить значение стиля
        /// </summary>
        public string GetStyle(string style_name)
        {
            if (CustomStyles.ContainsKey(style_name))
                return CustomStyles[style_name];

            return null;
        }

        /// <summary>
        /// Удалить стиль (если существует)
        /// </summary>
        public AbstractDomManager RemoveStyle(string style_name)
        {
            if (CustomStyles.ContainsKey(style_name))
                CustomStyles.Remove(style_name);

            return this;
        }

        /// <summary>
        /// Получить стили одной строкой
        /// </summary>
        public virtual string GetStringStyles()
        {
            //get
            //{
                string styles_as_string = " ";

                foreach (KeyValuePair<string, string> kvp in CustomStyles)
                    styles_as_string += kvp.Key + ":" + kvp.Value + "; ";

                return styles_as_string.Trim();
            //}
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
        public AbstractDomManager AddCSS(string css_class)
        {
            if (string.IsNullOrWhiteSpace(css_class))
                return this;

            css_class = css_class.Trim().ToLower();

            if (regex_spice.IsMatch(css_class))
                foreach (string s in regex_spice.Split(css_class))
                    AddCSS(s);
            else if (!string.IsNullOrEmpty(css_class) && !css.Contains(css_class))
                css.Add(css_class);
            return this;
        }

        public AbstractDomManager AddCSS(string[] css_classes)
        {
            foreach (string s in css_classes)
                AddCSS(s);
            return this;
        }

        /// <summary>
        /// Удалить класс CSS
        /// </summary>
        public AbstractDomManager RemoveCSS(string css_class)
        {
            css_class = css_class?.Trim().ToLower();
            if (regex_spice.IsMatch(css_class))
            {
                foreach (string s in regex_spice.Split(css_class))
                    RemoveCSS(s);
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
        public virtual string GetStringCSS()
        {
            //get
            //{
                string css_as_string = "";
                css.ForEach(x => css_as_string += " " + x);
                return css_as_string.Trim();
            //}
        }
        //
        ///////////////////////////////////////////////
        #endregion    
    }
}
