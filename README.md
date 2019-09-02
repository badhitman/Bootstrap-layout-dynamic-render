# BootstrapViewComponentsRazorLibrary
Bootstrap reusable ViewComponent`s ASP.NET Core 2.2

¬ьюеры семейства Bootstrap 4.3

## [Breadcrumbs](https://getbootstrap.com/docs/4.3/components/breadcrumb/)
Пример использования в *.cshtml
```cshtml
@using BootstrapViewComponents

<p>
    @{
        List<Breadcrumbs.BreadcrumbItem> BreadcrumbItems = new List<Breadcrumbs.BreadcrumbItem>(){
            new Breadcrumbs.BreadcrumbItem(){ text = "Пользователи", href = "/Users"},
            new Breadcrumbs.BreadcrumbItem(){ text = UserOrder.ToString(), href = "/Users/Details/"+UserOrder.Id},
            new Breadcrumbs.BreadcrumbItem(){ text = "Журнал операций"}
        };
    }
    @await Component.InvokeAsync(typeof(BootstrapViewComponents.Breadcrumbs), new { BreadcrumbItems = BreadcrumbItems })
</p>
```
## Pagination
> скоро