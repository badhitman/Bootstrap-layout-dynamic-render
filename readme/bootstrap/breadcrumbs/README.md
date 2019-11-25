# Breadcrumbs[¶](https://getbootstrap.com/docs/4.3/components/breadcrumb/)

Пример использования в **.cshtml**
```cshtml
@using BootstrapAspDynamicRender.models
@using BootstrapAspDynamicRender.components
<p>
  @{
    List<bmBreadcrumbItem> BreadcrumbItems = new List<bmBreadcrumbItem>()
	{
      new bmBreadcrumbItem(){ text = "Пользователи", href = "/Users"},
      new bmBreadcrumbItem(){ text = "Иван Петров", href = "/Users/Details/1"},
      new bmBreadcrumbItem(){ text = "Журнал операций"}
    };
  }
  @await Component.InvokeAsync(typeof(brBreadcrumbs), new { BreadcrumbItems = BreadcrumbItems })
</p>
```

###### Результат:

![Bootstrap - breadcrumb demo](./demo/breadcrumb.png)