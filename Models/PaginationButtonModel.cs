////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
namespace BootstrapViewComponents
{
    /// <summary>
    /// Модель для передачи параметров для формирования кнопки
    /// </summary>
    public class PaginationButtonModel
    {
        /// <summary>
        /// Типы кнопок Пагинатора
        /// </summary>
        public enum TypesButton
        {
            /// <summary>
            /// Назад. Предыдущая страница
            /// </summary>
            Back,

            /// <summary>
            /// Номер страницы
            /// </summary>
            Numb,

            /// <summary>
            /// Разделитель
            /// </summary>
            Separator,

            /// <summary>
            /// Далее. Следующая страница
            /// </summary>
            Next
        }

        /// <summary>
        /// Тип кнопки: Назад, Номер страницы, Разделитель, Далее
        /// </summary>
        public TypesButton TypeButton { get; set; }

        /// <summary>
        /// Ссылка кнопки
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Текст кнопки
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Признак того что кнопка активная
        /// </summary>
        public bool IsActive { get; set; }
    }
}
