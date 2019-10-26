# Bootstrap ViewComponent`s ASP Razor Library
Вьюеры семейства Bootstrap 4.3 - C# .Net Standart 2.0

## [Navs](https://getbootstrap.com/docs/4.3/components/navs/)
> [документация](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/html/bootstrap/navs)

## [Navbar](https://getbootstrap.com/docs/4.3/components/navbar/)
> [в процессе ...](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/html/bootstrap/navbar)

## [Pagination](https://getbootstrap.com/docs/4.3/components/pagination/)

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


## [Breadcrumbs](https://getbootstrap.com/docs/4.3/components/breadcrumb/)
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

