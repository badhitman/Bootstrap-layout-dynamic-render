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
 

![Bootstrap - pagination demo](./demo/Pagination.png)

