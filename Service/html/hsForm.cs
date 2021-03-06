﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;
using System.Net.Http;

namespace BootstrapAspDynamicRender.service
{
    public class hsForm : ahsManagedListNodes
    {
        public override string ViewComponentName => nameof(brForm);

        public HttpMethod FormMethod { get; set; }

        public hmEncTypesEnum? EncTypeData { get; set; } = null;

        /// <summary>
        /// Адрес программы или документа, который обрабатывает данные формы. 
        /// </summary>
        public string FormAction { get; set; } = null;

        /// <summary>
        /// Устанавливает кодировку, в которой сервер может принимать и обрабатывать данные (по умолчанию: utf-8)
        /// </summary>
        public string AcceptCharset { get; set; } = "utf-8";

        /// <summary>
        /// Имя окна или фрейма, куда обработчик будет загружать возвращаемый результат.
        /// В качестве значения используется имя окна или фрейма, заданное атрибутом name. Если установлено несуществующее имя, то будет открыто новое окно.
        /// В качестве зарезервированных имен можно указывать следующие:
        /// _blank - Загружает страницу в новое окно браузера. 
        /// _self - Загружает страницу в текущее окно.
        /// _parent - Загружает страницу во фрейм-родитель, если фреймов нет, то это значение работает как _self.
        /// _top - Отменяет все фреймы и загружает страницу в полном окне браузера, если фреймов нет, то это значение работает как _self.
        /// </summary>
        public hmFormTargetsEnum FormTarget { get; set; } = hmFormTargetsEnum.NULL;

        /// <summary>
        /// Отменяет встроенную проверку данных введенных пользователем в форме на корректность.
        /// Такая проверка осуществляется браузером автоматически при отправке формы на сервер и происходит для полей [input type="email"], [input type="url"], а также при наличии атрибута pattern или required.
        /// </summary>
        public bool NoValidate { get; set; } = false;

        /// <summary>
        /// Управляет автозаполнением полей форм. Значение может быть перекрыто атрибутом autocomplete у конкретных элементов формы.
        /// </summary>
        public bool? AutoComplete { get; set; } = null;

        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                if (FormMethod != null)
                    SetAttribute("method", FormMethod.ToString());
                else
                    RemoveAttribute("method");

                if (EncTypeData != null)
                    SetAttribute("enctype", GetEnctypeHtmlForm(EncTypeData));
                else
                    RemoveAttribute("enctype");

                if (!string.IsNullOrWhiteSpace(FormAction))
                    SetAttribute("action", FormAction);
                else
                    RemoveAttribute("action");

                if (!string.IsNullOrWhiteSpace(AcceptCharset))
                    SetAttribute("accept-charset", AcceptCharset);
                else
                    RemoveAttribute("accept-charset");

                if (FormTarget != hmFormTargetsEnum.NULL)
                    SetAttribute("target", FormTarget.ToString("g"));
                else
                    RemoveAttribute("target");

                if (NoValidate)
                    SetAttribute("novalidate", null);
                else
                    RemoveAttribute("novalidate");

                if (!(AutoComplete is null))
                    SetAttribute("autocomplete", AutoComplete == true ? "on" : "off");
                else
                    RemoveAttribute("autocomplete");
            }

            return base.GetStringAttributes();
        }

        /// <summary>
        /// Получить в виде строки тип кодирования отпарвляемых данных HTML формы
        /// </summary>
        private string GetEnctypeHtmlForm(hmEncTypesEnum? EncType)
        {
            switch (EncType)
            {
                // Данные не кодируются. Это значение применяется при отправке файлов.
                case hmEncTypesEnum.MultipartFormData:
                    return "multipart/form-data";
                // Пробелы заменяются знаком +, буквы и другие символы не кодируются.
                case hmEncTypesEnum.Plain:
                    return "text/plain";
                // EncTypes.WwwFormUrlEncoded: Вместо пробелов ставится +, символы вроде русских букв кодируются их шестнадцатеричными значениями (например, %D0%9F%D0%B5%D1%82%D1%8F вместо Петя).
                default:
                    return "application/x-www-form-urlencoded";
            }
        }
    }
}
