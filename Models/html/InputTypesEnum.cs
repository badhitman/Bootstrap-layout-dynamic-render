﻿////////////////////////////////////////////////
// https://github.com/badhitman
// Описание HTML объектов позаимствовано с сайта http://htmlbook.ru
////////////////////////////////////////////////

namespace BootstrapViewComponents
{
    /// <summary>
    /// Доступные типы [input]
    /// </summary>
    public enum InputTypesEnum
    {
        /// <summary>
        /// Кнопка
        /// </summary>
        button,

        /// <summary>
        /// Флажки. Позволяют выбрать более одного варианта из предложенных.
        /// </summary>
        checkbox,

        /// <summary>
        /// Поле для ввода имени файла, который пересылается на сервер.
        /// </summary>
        file,

        /// <summary>
        /// Скрытое поле. Оно никак не отображается на веб-странице.
        /// </summary>
        hidden,

        /// <summary>
        /// Поле с изображением. При нажатии на рисунок данные формы отправляются на сервер.
        /// </summary>
        image,

        /// <summary>
        /// Обычное текстовое поле, но отличается от него тем, что все символы показываются звездочками. Предназначено для того, чтобы никто не подглядел вводимый пароль.
        /// </summary>
        password,

        /// <summary>
        /// Переключатели. Используются, когда следует выбрать один вариант из нескольких предложенных.
        /// </summary>
        radio,

        /// <summary>
        /// Кнопка для возвращения данных формы в первоначальное значение.
        /// </summary>
        reset,

        /// <summary>
        /// Кнопка для отправки данных формы на сервер.
        /// </summary>
        submit,

        /// <summary>
        /// Текстовое поле. Предназначено для ввода символов с помощью клавиатуры.
        /// </summary>
        text,

        #region В HTML5 добавлены новые значения
        /// <summary>
        /// Виджет для выбора цвета.
        /// </summary>
        color,

        /// <summary>
        /// Поле для выбора календарной даты.
        /// </summary>
        date,

        /// <summary>
        /// Указание даты и времени.
        /// </summary>
        datetime,

        /// <summary>
        /// Указание местной даты и времени.
        /// </summary>
        datetime_local,

        /// <summary>
        /// Для адресов электронной почты.
        /// </summary>
        email,

        /// <summary>
        /// Ввод чисел.
        /// </summary>
        number,

        /// <summary>
        /// Ползунок для выбора чисел в указанном диапазоне.
        /// </summary>
        range,

        /// <summary>
        /// Поле для поиска.
        /// </summary>
        search,

        /// <summary>
        /// Для телефонных номеров.
        /// </summary>
        tel,

        /// <summary>
        /// Для времени.
        /// </summary>
        time,

        /// <summary>
        /// Для веб-адресов.
        /// </summary>
        url,

        /// <summary>
        /// Выбор месяца.
        /// </summary>
        month,

        /// <summary>
        /// Выбор недели.
        /// </summary>
        week
        #endregion
    }
}
