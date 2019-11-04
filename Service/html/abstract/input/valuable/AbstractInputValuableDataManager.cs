﻿////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractInputDataValuableManager : AbstractInputManager
    {
        /// <summary>
        /// Определяет значение элемента формы, которое будет отправлено на сервер или получено с помощью клиентских скриптов.
        /// На сервер отправляется пара «имя=значение», где имя задается атрибутом name тега [input], а значение — атрибутом [value].
        /// 
        /// В зависимости от типа элемента атрибут [value] выступает в следующей роли:
        /// 
        /// для кнопок(input type = "button | reset | submit") устанавливает текстовую надпись на них;
        /// для текстовых полей(input type = "password | text") указывает предварительно введенную строку. Пользователь может стирать текст и вводить свои символы, но при использовании в форме кнопки Reset пользовательский текст очищается и восстанавливается введенный в атрибуте [value];
        /// для флажков и переключателей(input type = "checkbox | radio") уникально определяет каждый элемент, с тем, чтобы клиентская или серверная программа могла однозначно установить, какой пункт выбрал пользователь.
        /// для файлового поля(input type = "file") не оказывает влияние.
        /// </summary>
        public string Value { get; set; } = null;
    }
}
