# Pagination[¶](https://getbootstrap.com/docs/4.3/components/pagination/)

> шаг 1 - обращаем внимание на ![bsPagination.cs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/blob/master/Service/bootstrap/bsPagination.cs#L35) спсиок предустановленных допустимых размерностей страниц пагинатора.
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

  bsPagination pagination = new bsPagination().Init(count_rows, HttpContext.Request.Path.Value + "?", PageNum, PageSize);
  ViewBag.Pagination = pagination;

  IQueryable<ProductModel> products = db.Products.Include(x => x.ThumbnailImage).OrderBy(x => x.DateCreate);

  if (PageNum > 1)
    products = products.Skip(pagination.Skip);

  return View(products.Take(PageSize).ToList());
}
```

Существует так же и другой (перегруженый) метод:
```c#
public bsPagination Init<T>(ref List<T> data_list, string url_tmpl, int _PageNum, int _PageSize)
```
Этот метод следует использовать в том случае если заранее у вас полный список элементов/строк, если небыло возможности предварительно применить к выборке оптимизаторы типа: **Skip** или **Take**.

***Данная перегрузка самостоятельно модифицирует передаваемый `List<T>`. Он будет усечён до "актуального состояния" в зависимости от сосотояния пагинатора!*** 

Пример использования:
```c#
public IActionResult Index(int PageSize = 10, int PageNum = 1)
{
  DirectoryInfo d = new DirectoryInfo("Uploads");
  List<FileInfo> Files = d.GetFiles().OrderBy(c => c.Name).ToList();
	
  bsPagination pagination = new bsPagination().Init(ref Files, this.HttpContext.Request.Path.Value + "?", PageNum, PageSize);
  ViewBag.Pagination = pagination;
  return View(Files);
}
```

> шаг 3 - Теперь пример использования в .cshtml 

```cshtml
@{
  ViewData["Title"] = "Заказы клиента";
  bsPagination pagination = ViewBag.Pagination;
}

@if (!(pagination is null) && pagination is bsPagination)
{
  <p>
    @await Component.InvokeAsync(pagination.ViewComponentName, new { pagination = pagination })
  </p>
}
```

###### Результаты:

![Bootstrap - pagination demo 1](../../demo/pagination.png)

![Bootstrap - pagination demo 2](../../demo/pagination2.png)

![Bootstrap - pagination demo 3](../../demo/pagination3.png)
