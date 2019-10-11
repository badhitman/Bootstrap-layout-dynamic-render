////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootstrapViewComponents
{
    public class PaginationManager : AbstractToolsManager
    {
        public class PageSizeItem
        {
            /// <summary>
            /// Размерность/Количество элементов на странице
            /// </summary>
            public int Value { get; set; }

            /// <summary>
            /// Заголовок/Название размерности
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Подсказка/Описание размерности
            /// </summary>
            public string Tooltip { get; set; }
        }

        public List<PageSizeItem> ListSizes
        {
            get
            {
                return new List<PageSizeItem>()
                {
                    new PageSizeItem(){ Value = 5, Title = "5", Tooltip = "По 5 элементов на странице" },
                    new PageSizeItem(){ Value = 10, Title = "10", Tooltip = "По 10 элементов на странице" },
                    new PageSizeItem(){ Value = 30, Title = "30", Tooltip = "По 30 элементов на странице" },
                    new PageSizeItem(){ Value = 50, Title = "50", Tooltip = "По 50 элементов на странице" },
                    new PageSizeItem(){ Value = 100, Title = "100", Tooltip = "По 100 элементов на странице" }
                };
            }
        }

        public AlignmentEnumModel AlignmentPagination = AlignmentEnumModel.right;

        public BootstrapSizingEnum? SiziePagination = null;

        /// <summary>
        /// Шаблон href
        /// </summary>
        public string UrlTmpl = "#";

        /// <summary>
        /// Номер страницы "постраничного/разбитого" документа
        /// </summary>
        public int PageNum { get; private set; } = 1;

        /// <summary>
        /// Размер строк "постраничного/разбитого" документа
        /// </summary>
        public int PageSize { get; private set; } = 10;

        /// <summary>
        /// Сколько всего элементов для разбивки на страницы
        /// </summary>
        public int CountAllElements { get; private set; } = 0;

        /// <summary>
        /// Вычислить количество строк данных, которые нужно пропустить исходя из номера текущей страницы
        /// </summary>
        public int Skip { get { return (PageNum - 1) * PageSize; } }

        /// <summary>
        /// Количество страниц в постраничном документе
        /// </summary>
        public int CountPages
        {
            get
            {
                if (CountAllElements <= 0 || PageSize <= 0)
                    return 0;

                return Convert.ToInt16(Math.Ceiling((double)CountAllElements / (double)PageSize));
            }
        }

        /// <summary>
        /// Проверка корректности номера страницы
        /// </summary>
        /// <param name="page_num">номер страницы для проверки</param>
        /// <returns>Корректное значение номера страницы</returns>
        public int CheckPageNum(int page_num)
        {
            if (page_num <= 0)
                return 1;

            if (CountPages < page_num)
                page_num = CountPages;

            return page_num;
        }

        /// <summary>
        /// Проверка корректности размерности страницы (количество элементов на страницу)
        /// </summary>
        /// <param name="page_size">Размерность для проверки</param>
        /// <returns>Корректное значение размера страницы</returns>
        public int CheckPageSize(int page_size)
        {
            int min_pagesize = ListSizes.Min(x => x.Value);
            int max_pagesize = ListSizes.Max(x => x.Value);

            if (min_pagesize > page_size)
                return min_pagesize;

            if (max_pagesize < page_size)
                return max_pagesize;

            if (CountAllElements < page_size)
                page_size = CountAllElements;

            return page_size;
        }

        /// <summary>
        /// Перезагрузить состояние "пагинатора" для формирования постраничного вывода данных.
        /// ВНИМАНИЕ! Переданый 'List' будет усечён до "актуального состояния" в зависимости от запрошеного номера страницы и настроек размера страницы
        /// </summary>
        /// <param name="data_list">Многострочные данные для формирования постраничного документа. Переданый список будет "усечён до актуального состояния" в зависимости от запрошеного номера страницы и настроек размера страницы</param>
        public PaginationManager Init<T>(ref List<T> data_list, string url_tmpl, int _PageNum, int _PageSize)
        {
            CountAllElements = data_list.Count;
            PageSize = CheckPageSize(_PageSize);
            PageNum = CheckPageNum(_PageNum);

            UrlTmpl = url_tmpl + "PageSize=" + PageSize + "&PageNum=";

            if (PageNum == 1)
                data_list = new List<T>(data_list.Take(PageSize));
            else
                data_list = new List<T>(data_list.Skip(Skip).Take(PageSize));

            return this;
        }

        /// <summary>
        /// Перезагрузить состояние пагинатора
        /// </summary>
        /// <param name="data_list_count">количество всего элементов в выводимой коллекции/таблицы</param>
        public PaginationManager Init(int data_list_count, string url_tmpl, int _PageNum, int _PageSize)
        {
            CountAllElements = data_list_count;
            PageSize = CheckPageSize(_PageSize);
            PageNum = CheckPageNum(_PageNum);
            UrlTmpl = url_tmpl + "PageSize=" + PageSize + "&PageNum=";

            return this;
        }
    }
}
