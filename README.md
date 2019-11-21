# Bootstrap layout dynamic render (by C# ASP.NET Standard)
Динамическая вёрстка Bootstrap 4.3

## Navs[¶](https://getbootstrap.com/docs/4.3/components/navs/)
> [readme...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs)

## Navbar[¶](https://getbootstrap.com/docs/4.3/components/navbar/)
> [readme...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navbar)

## Pagination[¶](https://getbootstrap.com/docs/4.3/components/pagination/)

> шаг 1 - обращаем внимание на ![PaginationManager.cs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/blob/master/Service/PaginationManager.cs) спсиок предустановленных допустимых размерностей страниц пагинатора.
В данном контексте этот список необходим для определения максимального и минимального размера страницы

```c#
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
```

> шаг 2 - в методе контроллера потребуются зарезервировать два параметра для определения состояния пагинатора: `int PageSize = 10, int PageNum = 1`


Пример установки состояние пагинатора в методе контроллера:
```c#
public IActionResult Index(int PageSize = 10, int PageNum = 1)
{
  int count_rows = db.Products.Count();
  PaginationManager pagination = new PaginationManager().Init(count_rows, this.HttpContext.Request.Path.Value + "?", PageNum, PageSize);
  IQueryable<ProductModel> products = db.Products;
  if (PageNum > 1)
    products = products.Skip(pagination.Skip);
	
  ViewBag.Pagination = pagination;
  return View(products.Take(PageSize).ToList());
}
```

Существует так же и другой (перегруженый) метод:
```c#
public PaginationManager Init<T>(ref List<T> data_list, string url_tmpl, int _PageNum, int _PageSize)
```
Этот метод следует использовать в том случае если заранее у вас есть полный список элементов/строк. Т.е. небыло возможности предварительно применить к выборке оптимизаторы типа: Take или Skip.

***Данная перегрузка самостоятельно модифицирует передаваемый `List<T>`. Он будет усечён до "актуального состояния" в зависимости от сосотояния пагинатора!*** 

Пример использования:
```c#
public IActionResult Index(int PageSize = 10, int PageNum = 1)
{
  DirectoryInfo d = new DirectoryInfo("Uploads");
  List<FileInfo> Files = d.GetFiles().OrderBy(c => c.Name).ToList();
	
  PaginationManager pagination = new PaginationManager().Init(ref Files, this.HttpContext.Request.Path.Value + "?", PageNum, PageSize);
  ViewBag.Pagination = pagination;
  return View(Files);
}
```

> шаг 3 - Теперь в .cshtml 

```cshtml
@{
  ViewData["Title"] = "Заказы клиента";
  PaginationManager pagination = ViewBag.Pagination;
}

@if (!(pagination is null) && pagination is PaginationManager)
{
  <p>
    @await Component.InvokeAsync(typeof(Pagination).Name, new { pagination = pagination })
  </p>
}
```

###### Результаты:

![Bootstrap - pagination demo 1](./demo/pagination.png)

![Bootstrap - pagination demo 2](./demo/pagination2.png)

![Bootstrap - pagination demo 3](./demo/pagination3.png)


## Breadcrumbs[¶](https://getbootstrap.com/docs/4.3/components/breadcrumb/)
Пример использования в .cshtml
```cshtml
@using BootstrapViewComponents

<p>
  @{
    List<Breadcrumbs.BreadcrumbItem> BreadcrumbItems = new List<Breadcrumbs.BreadcrumbItem>(){
      new Breadcrumbs.BreadcrumbItem(){ text = "Пользователи", href = "/Users"},
      new Breadcrumbs.BreadcrumbItem(){ text = "Иван Петров", href = "/Users/Details/1"},
      new Breadcrumbs.BreadcrumbItem(){ text = "Журнал операций"}
    };
  }
  @await Component.InvokeAsync(typeof(BootstrapViewComponents.Breadcrumbs), new { BreadcrumbItems = BreadcrumbItems })
</p>
```

###### Результат:

![Bootstrap - breadcrumb demo](./demo/breadcrumb.png)

## Modal[¶](https://getbootstrap.com/docs/4.3/components/modal/)

> Используйте Bootstrap JavaScript **modal** плагин для добавления диалоговых окон на ваш сайт для лайтбоксов, уведомлений пользователей или полностью пользовательского контента.

#### How it works[¶](https://getbootstrap.com/docs/4.3/components/modal/#how-it-works)

> Прежде чем начать работу с компонентом **modal** Bootstrap, обязательно прочитайте следующее:

- Модальные объекты строятся с использованием **HTML**, **CSS** и **JavaScript**. Они расположены поверх всего остального в документе и отключают прокрутку `<body>`, чтобы вместо этого прокручивалось модальное содержимое.
- Кликните мышкой за границами модального объекта и модальный объект автоматически закроется.
- Bootstrap поддерживает только одно модальное окно за раз. Вложенные модальные объекты не поддерживаются.
- Модальные объекты используют `position: fixed;`, в связи с чем рендеринг иногда может иметь некоторые особенности. По возможности разместите свой модальный HTML-код на верхнем уровне, чтобы избежать возможных помех со стороны других элементов. Вы, вероятно, столкнетесь с проблемами при вложении **.modal** внутри другого `position: fixed;` элемента.
- Из-за `position: fixed;`, есть некоторые нюансы с использованием модальных объектов на мобильных устройствах. Дополнительную информацию см. [В документации по поддержке браузера](https://getbootstrap.com/docs/4.3/getting-started/browsers-devices/#modals-and-dropdowns-on-mobile).
- Из-за определённой семантики HTML5, [HTML атрибут **autofocus**](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-autofocus) не имеет никакого эффекта в модальных объектах Bootstrap. Чтобы достичь того же эффекта, используйте некоторые пользовательские JavaScript:

```javascript
$('#myModal').on('shown.bs.modal', function () {
  $('#myInput').trigger('focus')
})
```

> Анимационный эффект этого компонента зависит от **prefers-reduced-motion media query**.
См. [раздел в документации](https://getbootstrap.com/docs/4.3/getting-started/accessibility/#reduced-motion).

## Modal components[¶](https://getbootstrap.com/docs/4.3/components/modal/#modal-components)

> Ниже приведен статический пример модального объекта (это означает, что его позиция и отображение были переопределены).
Включены заголовок, тело (требуется для заполнения контентом) и нижний колонтитул (необязательно).
В заголовке модального окна есть кнопка деактивации.

```cshtml
@{

}
```

***result:***

![Modal demo](../../../../demo/modal-demo.jpg)

## Forms[¶](https://getbootstrap.com/docs/4.3/components/forms/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/forms)

## Input group[¶](https://getbootstrap.com/docs/4.3/components/input-group/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/input/group)

## Buttons[¶](https://getbootstrap.com/docs/4.3/components/buttons/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/button)

## Button group[¶](https://getbootstrap.com/docs/4.3/components/button-group/#basic-example)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/button/group)

## List group[¶](https://getbootstrap.com/docs/4.3/components/list-group/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/list)

## Carousel[¶](https://getbootstrap.com/docs/4.3/components/carousel/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/carousel)

## Collapse[¶](https://getbootstrap.com/docs/4.3/components/collapse/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/collapse)

## Dropdowns[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/dropdowns)

## Cards[¶](https://getbootstrap.com/docs/4.3/components/card/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/cards)

## Media object[¶](https://getbootstrap.com/docs/4.3/components/media-object/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/media)

## Progress[¶](https://getbootstrap.com/docs/4.3/components/progress/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/progress)

## Scrollspy[¶](https://getbootstrap.com/docs/4.3/components/scrollspy/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/scrollspy)

## Tables[¶](https://getbootstrap.com/docs/4.3/content/tables/)
> [progress...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Service/bootstrap/table)