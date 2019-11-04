﻿////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.html
{
    /// <summary>
    /// По умолчанию, при переходе по ссылке документ открывается в текущем окне или фрейме. При необходимости, это условие может быть изменено атрибутом target тега [a].
    /// В XHTML применение этого атрибута запрещено. 
    /// </summary>
    public enum FormTargetsEnum
    {
        /// <summary>
        /// Отменяет все фреймы и загружает страницу в полном окне браузера, если фреймов нет, то это значение работает как _self.
        /// </summary>
        _top,

        /// <summary>
        /// Загружает страницу во фрейм-родитель, если фреймов нет, то это значение работает как _self.
        /// </summary>
        _parent,

        /// <summary>
        /// Загружает страницу в новое окно браузера.
        /// </summary>
        _blank,

        /// <summary>
        /// Загружает страницу в текущее окно.
        /// </summary>
        _self
    }
}
