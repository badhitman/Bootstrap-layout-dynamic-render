////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BootstrapAspDynamicRender.service
{
    public abstract class ahsDom : asCloneableObject
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
        public virtual string ID { get; set; } = null;

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
        //
        public List<KeyValuePair<string, string>> ReadAttributes() => CustomAttributes.ToList();

        /// <summary>
        /// Установить значение атрибута (добавить если атрибут отсутсвует).
        /// </summary>
        /// <param name="attr_name">Имя атрибута dom объекта</param>
        /// <param name="attr_value">Если знаение атрибута IS NULL, то генератор объявит имя атрибута без упоминания значения этого атрибута (т.е. будет пропущен знак = и его значение)</param>
        public ahsDom SetAttribute(string attr_name, string attr_value)
        {
            attr_name = attr_name.Trim().ToLower();

            if (IndependentAttributes.Contains(attr_name))
                return this;

            if (attr_name == "id")
            {
                if (attr_value != ID)
                {
                    CacheAttributes = string.Empty;
                    ID = attr_value;
                }
            }

            if (attr_name == "accesskey")
            {
                if (attr_value != Accesskey)
                {
                    CacheAttributes = string.Empty;
                    Accesskey = attr_value;
                }
            }

            if (attr_name == "contenteditable")
            {
                bool new_value = attr_value.ToLower() == "true" || attr_value.ToLower().EndsWith("editable");
                if (Contenteditable != new_value)
                {
                    CacheAttributes = string.Empty;
                    Contenteditable = new_value;
                }
            }

            if (attr_name == "hidden")
            {
                bool new_value = attr_value.ToLower() == "true" || attr_value.ToLower() == "hidden";
                if (new_value != Hidden)
                {
                    CacheAttributes = string.Empty;
                    Hidden = new_value;
                }
            }

            if (attr_name == "tabindex")
            {
                if (attr_value != Tabindex.ToString())
                {
                    if (!Regex.IsMatch(attr_value, @"^-?\d+$"))
                        return this;
                    CacheAttributes = string.Empty;
                    Tabindex = int.Parse(attr_value);
                }
            }

            if (attr_name == "title")
            {
                if (attr_value != Title)
                {
                    CacheAttributes = string.Empty;
                    Title = attr_value;
                }
            }

            if (!CustomAttributes.ContainsKey(attr_name))
            {
                CacheAttributes = string.Empty;
                CustomAttributes.Add(attr_name, attr_value);
            }
            else if (CustomAttributes[attr_name] != attr_value)
            {
                CacheAttributes = string.Empty;
                CustomAttributes[attr_name] = attr_value;
            }
            return this;
        }

        public ahsDom SetAttributes(List<KeyValuePair<string, string>> attributes)
        {
            attributes.ForEach(x => SetAttribute(x.Key, x.Value));
            return this;
        }

        /// <summary>
        /// Установить DOM объекту составное значение атрибута
        /// </summary>
        /// <param name="attr_name">Имя атрибута</param>
        /// <param name="attributes">Список значений атрибутов, которые нужно объеденить в одно составное значение</param>
        /// <param name="separator">Символ-разделитель значений в составном значении атрибута</param>
        /// <param name="check_duplicates_attributes">если true - то дубли значений будут исключены из конечного составного значения</param>
        public ahsDom SetAttribute<T>(string attr_name, List<T> attributes, string separator, bool check_duplicates_attributes = true)
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
        public ahsDom SetAttribute(Dictionary<string, string> in_custom_atributes)
        {
            CacheAttributes = string.Empty;
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
        public ahsDom RemoveAttribute(string attr_name)
        {
            CacheAttributes = string.Empty;
            if (CustomAttributes.ContainsKey(attr_name))
                CustomAttributes.Remove(attr_name);

            return this;
        }

        /// <summary>
        /// Установить DOM элементу обработчик события.
        /// Если "event_src" IsNullOrEmpty, то событие удаляется
        /// </summary>
        public ahsDom SetEvent(hmUniversalEventsEnum my_event, string event_src)
        {
            CacheAttributes = string.Empty;
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
            if (!string.IsNullOrWhiteSpace(CacheAttributes))
                return CacheAttributes.Trim();

            if (!string.IsNullOrWhiteSpace(ID))
                SetAttribute("id", ID.Trim());

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

            CacheAttributes = " ";

            foreach (KeyValuePair<string, string> kvp in CustomAttributes)
            {
                if (kvp.Value is null)
                    CacheAttributes += kvp.Key + " ";
                else
                    CacheAttributes += kvp.Key + "=\"" + kvp.Value + "\" ";
            }

            string tmp_css_string = GetStringCSS();
            if (!string.IsNullOrWhiteSpace(tmp_css_string))
                CacheAttributes += "class=\"" + tmp_css_string + "\" ";

            if (CustomStyles.Count > 0)
                CacheAttributes += "style=\"" + GetStringStyles() + "\" ";

            return CacheAttributes.Trim();
        }

        protected string CacheAttributes { get; private set; }

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

        public List<KeyValuePair<string, string>> ReadStyles() => CustomStyles.ToList();

        /// <summary>
        /// Установить значение стиля (добавить если стиль отсутсвует).
        /// </summary>
        /// <param name="style_name">Имя стиля dom объекта</param>
        /// <param name="style_value">Знаение стиля</param>
        public ahsDom SetStyle(string style_name, string style_value)
        {
            if (string.IsNullOrWhiteSpace(style_name) || string.IsNullOrWhiteSpace(style_value))
                return this;

            CacheStyles = string.Empty;
            style_name = style_name.Trim().ToLower().Trim();
            style_value = style_value.Trim().ToLower().Trim();

            if (!CustomStyles.ContainsKey(style_name))
                CustomStyles.Add(style_name, style_value);
            else
                CustomStyles[style_name] = style_value;

            return this;
        }

        /// <summary>
        /// Пакетная установка стилей
        /// </summary>
        public ahsDom SetStyles(List<KeyValuePair<string, string>> in_custom_styles)
        {
            CacheStyles = string.Empty;
            foreach (KeyValuePair<string, string> kvp in in_custom_styles)
                SetStyle(kvp.Key, kvp.Value);

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
        public ahsDom RemoveStyle(string style_name)
        {
            CacheStyles = string.Empty;
            if (CustomStyles.ContainsKey(style_name))
                CustomStyles.Remove(style_name);

            return this;
        }

        /// <summary>
        /// Получить стили одной строкой
        /// </summary>
        public virtual string GetStringStyles()
        {
            if (string.IsNullOrWhiteSpace(CacheStyles) && CustomStyles.Count > 0)
            {
                CacheStyles = " ";

                foreach (KeyValuePair<string, string> kvp in CustomStyles)
                    CacheStyles += kvp.Key + ":" + kvp.Value + "; ";
            }

            return CacheStyles.Trim();
        }
        protected string CacheStyles { get; private set; }

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
        protected List<string> css = new List<string>();

        public bool ContainsClassCSS(Predicate<string> predicate) => css.Any(x => predicate(x));

        public string[] ReadCSS() => css.ToArray();

        /// <summary>
        /// Добавить CSS класс текущему объекту (если такой класс ещё не назначен объекту)
        /// </summary>
        public ahsDom AddCSS(string css_class, bool check_separator = true)
        {
            if (string.IsNullOrWhiteSpace(css_class))
                return this;

            css_class = css_class.Trim().ToLower();

            if (check_separator && regex_spice.IsMatch(css_class))
                foreach (string s in regex_spice.Split(css_class))
                    AddCSS(s, false);

            else if (!string.IsNullOrEmpty(css_class) && !css.Contains(css_class))
            {
                CacheCSS = string.Empty;
                css.Add(css_class);
            }
            return this;
        }

        public ahsDom AddCSS(string[] css_classes)
        {
            foreach (string s in css_classes)
                AddCSS(s);
            return this;
        }

        /// <summary>
        /// Удалить класс CSS
        /// </summary>
        public ahsDom RemoveCSS(string css_class, bool check_separator = true)
        {
            if (css.Count == 0)
                return this;

            css_class = css_class?.Trim().ToLower();
            if (check_separator && regex_spice.IsMatch(css_class))
            {
                foreach (string s in regex_spice.Split(css_class))
                    RemoveCSS(s, false);
            }
            else if (!string.IsNullOrEmpty(css_class) && css.Contains(css_class))
            {
                css.Remove(css_class);
                CacheCSS = string.Empty;
            }
            return this;
        }

        /// <summary>
        /// Удаление CSS класса про предикату
        /// </summary>
        /// <param name="predicate">Предикат определения класса для удаления</param>
        public ahsDom RemoveCSS(Predicate<string> predicate)
        {
            css.Where(x => predicate(x)).ToList().ForEach(x => RemoveCSS(x));
            return this;
        }

        /// <summary>
        /// Если класса нет, то будет добавлен. Если класс есть, то будет удалён
        /// </summary>
        public ahsDom TogleCSS(string css_class, bool check_separator = true)
        {
            if (string.IsNullOrEmpty(css_class))
                return this;

            css_class = css_class.Trim().ToLower();
            if (check_separator && regex_spice.IsMatch(css_class))
            {
                foreach (string s in regex_spice.Split(css_class))
                    TogleCSS(s, false);
            }

            if (!css.Contains(css_class))
                css.Add(css_class);
            else
                css.Remove(css_class);

            CacheCSS = string.Empty;

            return this;
        }

        public ahsDom ClearCSS()
        {
            CacheCSS = string.Empty;
            css.Clear();
            return this;
        }

        /// <summary>
        /// Получить CSS классы одной строкой (разделитель пробел)
        /// </summary>
        public virtual string GetStringCSS()
        {
            if (string.IsNullOrWhiteSpace(CacheCSS))
            {
                CacheCSS = "";
                css.ForEach(x => CacheCSS += " " + x);
            }
            return CacheCSS.Trim();
        }

        protected string CacheCSS { get; private set; }

        //
        ///////////////////////////////////////////////
        #endregion

        public override object Clone()
        {
            ahsDom dom = base.Clone() as ahsDom;
            //
            dom.CustomAttributes = new SortedDictionary<string, string>();
            dom.SetAttributes(ReadAttributes());
            //
            dom.CustomStyles = new SortedDictionary<string, string>();
            dom.SetStyles(ReadStyles());
            //
            dom.css = new List<string>();
            dom.AddCSS(ReadCSS());
            //
            return dom;
        }
    }
}
