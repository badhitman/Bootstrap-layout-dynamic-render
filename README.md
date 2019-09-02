# Bootstrap ViewComponent`s Razor Library
Bootstrap reusable ViewComponent`s ASP.NET Core 2.2

Вьюеры семейства Bootstrap 4.3

## ![Breadcrumbs](https://getbootstrap.com/docs/4.3/components/breadcrumb/)
Пример использования в *.cshtml
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

![Bootstrap - breadcrumb demo](./demo/Breadcrumb.png)

## ![Pagination](https://getbootstrap.com/docs/4.3/components/pagination/)

> в ![PaginationManager.cs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/blob/master/Service/PaginationManager.cs) спсиок предустановленных допустимых размерностей страниц пагинатора.

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



![Bootstrap - pagination demo](./demo/Pagination.png)

