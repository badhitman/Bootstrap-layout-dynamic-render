# Breadcrumbs[�](https://getbootstrap.com/docs/4.3/components/breadcrumb/)

������ ������������� � **.cshtml**
```cshtml
@using BootstrapAspDynamicRender.models
@using BootstrapAspDynamicRender.components
<p>
  @{
    List<bmBreadcrumbItem> BreadcrumbItems = new List<bmBreadcrumbItem>()
	{
      new bmBreadcrumbItem(){ text = "������������", href = "/Users"},
      new bmBreadcrumbItem(){ text = "���� ������", href = "/Users/Details/1"},
      new bmBreadcrumbItem(){ text = "������ ��������"}
    };
  }
  @await Component.InvokeAsync(typeof(brBreadcrumbs), new { BreadcrumbItems = BreadcrumbItems })
</p>
```

###### ���������:

![Bootstrap - breadcrumb demo](./demo/breadcrumb.png)