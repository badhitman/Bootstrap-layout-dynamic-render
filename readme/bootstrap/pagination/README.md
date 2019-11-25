# Pagination[�](https://getbootstrap.com/docs/4.3/components/pagination/)

> ��� 1 - �������� �������� �� ![bsPagination.cs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/blob/master/Service/bootstrap/bsPagination.cs#L35) ������ ����������������� ���������� ������������ ������� ����������.
� ������ ��������� ���� ������ ��������� ��� ����������� ������������� � ������������ ������� ��������

```c#
public List<PageSizeItem> ListSizes
{
  get
  {
    return new List<PageSizeItem>()
    {
      new PageSizeItem(){ Value = 5, Title = "5", Tooltip = "�� 5 ��������� �� ��������" },
      new PageSizeItem(){ Value = 10, Title = "10", Tooltip = "�� 10 ��������� �� ��������" },
      new PageSizeItem(){ Value = 30, Title = "30", Tooltip = "�� 30 ��������� �� ��������" },
      new PageSizeItem(){ Value = 50, Title = "50", Tooltip = "�� 50 ��������� �� ��������" },
      new PageSizeItem(){ Value = 100, Title = "100", Tooltip = "�� 100 ��������� �� ��������" }
    };
  }
}
```

> ��� 2 - � ������ ����������� ����������� ��������������� ��� ��������� ��� ����������� ��������� ����������: `int PageSize = 10, int PageNum = 1`

������ ��������� ��������� ���������� � ������ �����������:
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

���������� ��� �� � ������ (������������) �����:
```c#
public bsPagination Init<T>(ref List<T> data_list, string url_tmpl, int _PageNum, int _PageSize)
```
���� ����� ������� ������������ � ��� ������ ���� ������� � ��� ������ ������ ���������/�����, ���� ������ ����������� �������������� ��������� � ������� ������������ ����: **Skip** ��� **Take**.

***������ ���������� �������������� ������������ ������������ `List<T>`. �� ����� ������ �� "����������� ���������" � ����������� �� ���������� ����������!*** 

������ �������������:
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

> ��� 3 - ������ ������ ������������� � .cshtml 

```cshtml
@{
  ViewData["Title"] = "������ �������";
  bsPagination pagination = ViewBag.Pagination;
}

@if (!(pagination is null) && pagination is bsPagination)
{
  <p>
    @await Component.InvokeAsync(pagination.ViewComponentName, new { pagination = pagination })
  </p>
}
```

###### ����������:

![Bootstrap - pagination demo 1](../demo/pagination.png)

![Bootstrap - pagination demo 2](../demo/pagination2.png)

![Bootstrap - pagination demo 3](../demo/pagination3.png)