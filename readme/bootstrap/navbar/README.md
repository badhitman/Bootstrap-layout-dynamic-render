# Navbar[�](https://getbootstrap.com/docs/4.3/components/navbar/)
> ��� ��� ����� �����, ������ ��� ������ ������ � ������������� �������:

- ������������� ������ ������� ����������� `.navbar` ��� ������ `.navbar-expand{-sm|-md|-lg|-xl}` ��� ������ ���������� ��������.
- ������������� ������ � �� ���������� �� ��������� �������� ���������������/�������. ����������� �������������� ����������, ����� ���������� �� �������������� ������.
- ����������� ������ ������ `spacing` � `flex` ��� ���������� ����������� � ������������� � ������������� �������.
- ������������� ������ ��������� �� ���������, �� �� ������ ����� �������� ��, ����� �������� ���. ���������� ��������� ������� �� ������ ������� **JavaScript Collapse**.
- ������������� ������ �� ��������� ������ ��� ������. ��������� �� ���� ���������� ����� ���������� `.d-print` �� `.navbar`. �������� �������� �� ������ ������� **display**.
- ���������� ����������� � ������� �������� `<nav>` ���, ���� ������������ ����� ����� �������, ����� ��� `<div>`, �������� `role="navigation"` � ������ ������������� ������, ����� ���� ���������� �� ��� �������� ��� ������������� ��������������� ����������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "TopMenu" };
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("brand-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������",
      ImageNavbarBrandSrc = "/img/bootstrap-solid.svg"
    }
  };
  bsNavbarNav navbar_nav_manager = new bsNavbarNav();
  navbar_nav_manager.AddCSS("mr-auto"); // ��������� ���������� �����: margin-right: auto !important;
  navbar_nav_manager.AddNavItem(id_dom: "home-nav-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("link-nav-id", "Link", "#");
  bsNavItem navbar_nav_dropdown_item = navbar_nav_manager.AddNavItem("dropdown-nav-id", "Dropdown", "#");
  navbar_nav_dropdown_item.AddSubNav(header_nav: "Action", href_nav: "#", id_nav: "action-nav-id");
  navbar_nav_dropdown_item.AddSubNav("Another action", "#", "another-action-nav-id"); navbar_nav_dropdown_item.AddSubNav(null);
  navbar_nav_dropdown_item.AddSubNav("Something else here", "#", "something-else-here-nav-id");
  navbar_nav_manager.AddNavItem("disabled-nav-id", "Disabled", "#").IsDisabled = true;
  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);
  FormManager formManager = new FormManager();
  InputSearchManager input_manager = new InputSearchManager()
  {
    Placeholder = "Search"
  };
  input_manager.AddCSS("form-control mr-sm-2");
  formManager.AddChild(input_manager);
  hsButton button_manager = new hsButton("Search");
  button_manager.AddCSS("btn btn-outline-success my-2 my-sm-0");
  formManager.AddChild(button_manager);
  formManager.AddCSS("my-2 my-lg-0");
  navbar_manager.NavbarActions.AddSubNode(formManager);
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:*** ������: ������� �� (����� �����) � �� ������� **iPhone 6/6/7** (������ �������). ������� **iPhone** � ���� ������� ��������������� � ���� ����������: �������� (����� ����������) � ����������� (������ ������)
![Bootstrap - Navbar base (demo ul->li->a)](../demo/navbar-base-ul-li-a.jpg)
� ������� ���� �������������� ������� [color](https://getbootstrap.com/docs/4.3/utilities/colors/) (__bg-light__) � [spacing](https://getbootstrap.com/docs/4.3/utilities/spacing/) (__my-2, my-lg-0, mr-sm-0, my-sm-0, mr-auto__).


> Navbars ������������ �� ���������� ���������� [���������� ��������������](https://getbootstrap.com/docs/4.3/components/navbar/#supported-content):

- [**.navbar-brand**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#brand) ��� �������� ����� ��������, �������� ��� �������. � ��� ����� � ���������/���������.
- [**.navbar-nav**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#nav) ��� `full-height` � `lightweight` ��������� (������� ��������� ���������� ����).
- [**.navbar-toggler**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#toggler) ��� ������������� � ����� �������� _collapse_ � ������� ��������� ������������ ���������.
- [**.form-inline**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#forms) ��� ����� ��������� ���������� � �������� �����.
- [**.navbar-text**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#text) ��� ���������� ����������� �������������� ����� ������.
- [**.collapse.navbar-collapse**](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/html/bootstrap/navbar#external-content) ��� ����������� � ������� ����������� ������������� ������.

## Brand[�](https://getbootstrap.com/docs/4.3/components/navbar/#brand)
> **.navbar-brand** ����� ���� �������� � ����������� ����� **�����**, �� `<a></a>` �������� ����� �����, ��������� ������ ���� ����� ����� ����������� �������������� **utility classes** ��� ���������������� ������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "top-menu-dom-id" };

  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id") { Href = "#", Header = " Brand", Title = "�������� ������" }
  };
  @await Component.InvokeAsync(typeof(NavbarBase).Name, new { SetObjectManager = navbar_manager });
  
  <br />
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id") { Header = " Brand", Title = "�������� ������" }
  };
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-brand-a.jpg)

> ���������� ����������� � **.navbar-brand**, ������ �����, ��������� ���������������� ������ ��� ������ ��� ����������� �������. ��� ��������� �������� ��� ������������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "top-menu-dom-id" };
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-dom-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id")
    {
      Href = "#",
      Title = "�������� ������",
      ImageNavbarBrandSrc = "/img/bootstrap-solid.svg"
    }
  };
  @await Component.InvokeAsync(typeof(NavbarBase).Name, new { SetObjectManager = navbar_manager });
  <br />
  navbar_manager.ID = "top-menu-2-dom-id";
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-2-dom-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-2-dom-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������",
      ImageNavbarBrandSrc = "/img/bootstrap-solid.svg"
    }
  };
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-brand-a-img.jpg)

## Nav[�](https://getbootstrap.com/docs/4.3/components/navbar/#nav)
>  ������������� ������ **Navbar** ��������� �� ������ **.nav** . ����� ���� ����������� ����� ����������� � ������� ������������� ������� `toggler` ��� ����������� ����������� �����.
��������� � **navbars** ����� ����� �������������, ����� ������ ��� ����� ������ ��������������� ������������, ����� ��������� ���������� **navbar** ������� ���������.
```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "top-menu-navbar-dom-id" };
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-nav-dom-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������"
    }
  };

  bsNavbarNav navbar_nav_manager = new bsNavbarNav();
  navbar_nav_manager.AddNavItem(id_dom: "home-nav-dom-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("features-nav-dom-id", "Features", "#");
  navbar_nav_manager.AddNavItem("pricing-nav-dom-id", "Pricing", "#");
  navbar_nav_manager.AddNavItem("disabled-nav-dom-id", "Disabled", "#").IsDisabled = true;
  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-nav-ul-li-a.jpg)

> � ��������� �� ���������� ������ ��� ����� �����������, �� ������ ��������� �������� ������� �� ������ ������, ���� ������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id"
  };

  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-nav-dom-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������"
    }
  };

  bsNavbarNav navbar_nav_manager = new bsNavbarNav()
  {
    NavWrapper = NavbarNavWrappersEnum.div
  };

  navbar_nav_manager.AddNavItem(id_dom: "home-nav-dom-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("features-nav-dom-id", "Features", "#");
  navbar_nav_manager.AddNavItem("pricing-nav-dom-id", "Pricing", "#");
  navbar_nav_manager.AddNavItem("disabled-nav-dom-id", "Disabled", "#").IsDisabled = true;
  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-nav-div-a.jpg)

> �� ����� ������ ������������ ���������� ���� � ������ ���������.
���������� ���� ������� ����������� �������� ��� ����������������, ������� ����������� ����������� ��������� � ��������� ��������: **.nav-item** � **.nav-link**, ��� �������� ����:

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id"
  };

  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-nav-dom-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������"
    }
  };

  bsNavbarNav navbar_nav_manager = new bsNavbarNav();

  navbar_nav_manager.AddNavItem(id_dom: "home-nav-dom-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("features-nav-dom-id", "Features", "#");
  navbar_nav_manager.AddNavItem("pricing-nav-dom-id", "Pricing", "#");

  bsNavItem navItem = navbar_nav_manager.AddNavItem("disabled-nav-dom-id", "Dropdown link", "#");
                    
  navItem.AddSubNav(header_nav: "Action", href_nav: "#", id_nav: "dropdown-action-dom-id");
  navItem.AddSubNav(header_nav: "Another action", href_nav: "#", id_nav: "dropdown-another-action-dom-id");
  navItem.AddSubNav(null);
  navItem.AddSubNav(header_nav: "Something else here", href_nav: "#", id_nav: "dropdown-something-action-dom-id");

  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-dropdowns-ul-li-a.jpg)

## Forms[�](https://getbootstrap.com/docs/4.3/components/navbar/#forms)
>  ��������� ��������� �������� ���������� � ���������� ����� � ������������� ������ **.form-inline**.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id"
  };
  navbar_manager.NavbarActions.IsHidesCollapse = false;
  FormManager formManager = new FormManager() { ID = "navbar-form-dom-id" };

  InputSearchManager input_manager = new InputSearchManager()
  {
    Placeholder = "Search",
    ID = "navbar-form-search-input-dom-id"
  };
  input_manager.AddCSS("form-control mr-sm-2");
  formManager.AddChild(input_manager);

  hsButton button_manager = new hsButton("Search");
  button_manager.AddCSS("btn btn-outline-success my-2 my-sm-0");

  formManager.AddChild(button_manager);
  navbar_manager.NavbarActions.AddSubNode(formManager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-form.jpg)

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id",
    NavbarExpandSize = BootstrapViewComponents.bmSizingsEnum.NULL
  };
  navbar_manager.NavbarActions.IsHidesCollapse = false;
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-nav-dom-id")
    {
      Href = "#",
      Header = " Brand",
      Title = "�������� ������"
    }
  };

  FormManager formManager = new FormManager();

  InputSearchManager input_manager = new InputSearchManager()
  {
    Placeholder = "Search"
  };
  input_manager.AddCSS("form-control mr-sm-2");
  formManager.AddChild(input_manager);

  hsButton button_manager = new hsButton("Search")
  {
    ButtonType = hmButtonTypesEnum.submit
  };
  button_manager.AddCSS("btn btn-outline-success my-2 my-sm-0");

  formManager.AddChild(button_manager);

  navbar_manager.NavbarActions.AddSubNode(formManager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-brand-form.jpg)

## Text[�](https://getbootstrap.com/docs/4.3/components/navbar/#text)

>  ������������� ������ ����� ��������� ��������� ������ � ������� **.navbar-text**.
���� ����� ���������� ������������ ������������ � �������������� �������� ��� ����� ������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id",
    NavbarExpandSize = BootstrapViewComponents.bmSizingsEnum.NULL
  };
    navbar_manager.NavbarActions.IsHidesCollapse = false;
    NavbarTextManager navbarText = new NavbarTextManager("Navbar text with an inline element");
    navbar_manager.NavbarActions.AddSubNode(navbarText);
    @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-text.jpg)

> ���������� � ������� ������������ � ��������� �� ���� �������������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar()
  {
    ID = "top-menu-navbar-dom-id",
    NavbarExpandSize = BootstrapViewComponents.bmSizingsEnum.Lg
  };
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandDom = new BrandNavItemModel("brand-dom-id")
    {
      Header = "Navbar w/ text",
      Href = "#"
    }
  };

  navbar_manager.NavbarActions.IsHidesCollapse = true;

  bsNavbarNav navbar_nav_manager = new bsNavbarNav();
  navbar_nav_manager.AddCSS("mr-auto");
  navbar_nav_manager.AddNavItem(id_dom: "home-nav-dom-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("features-nav-dom-id", "Features", "#");
  navbar_nav_manager.AddNavItem("pricing-nav-dom-id", "Pricing", "#");
  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  NavbarTextManager navbarText = new NavbarTextManager("Navbar text with an inline element");
  navbarText.AddCSS("navbar-text");
  navbar_manager.NavbarActions.AddSubNode(navbarText);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```
***result:***
![Demo](../demo/navbar-base-nav-ul-li-a-and-text.jpg)

## Color schemes[�](https://getbootstrap.com/docs/4.3/components/navbar/#color-schemes)
>  ����������� ������������� ������ ������� �� ���� ����� ��������� ��������� ������� ����������� � ������ �������� �����.
��������� ����� **.navbar-light** ��� ������������� �� �������� ������� ����, ��� **.navbar-dark** �� ������ ���� �����.
����� ��������� ���� ������� ���� � ������� ������ **.bg-* **

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "navbar-top-menu-dom-id" };
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id")
    {
      Href = "#",
      Header = " Brand navbar",
      Title = "�������� ������"
    }
  };

  bsNavbarNav navbar_nav_manager = new bsNavbarNav();
  navbar_nav_manager.AddCSS("mr-auto");
  navbar_nav_manager.AddNavItem(id_dom: "home-nav-id", header: "Home", href: "#").IsActive = true;
  navbar_nav_manager.AddNavItem("features-nav-id", "Features", "#");
  navbar_nav_manager.AddNavItem("pricing-nav-id", "Pricing", "#");
  navbar_nav_manager.AddNavItem("disabled-nav-id", "About", "#");

  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  FormManager formManager = new FormManager();

  InputSearchManager input_manager = new InputSearchManager()
  {
    Placeholder = "Search"
  };
  input_manager.AddCSS("form-control mr-sm-2");
  formManager.AddChild(input_manager);

  hsButton button_manager = new hsButton("Search");
  button_manager.AddCSS("btn btn-outline-info my-2 my-sm-0");

  formManager.AddChild(button_manager);

  formManager.AddCSS("my-2 my-lg-0");
  navbar_manager.NavbarActions.AddSubNode(formManager);

  navbar_manager.NavbarColorScheme = MonochromeColorSchemesEnum.dark;
  navbar_manager.BackgroundColorTheme = bmBackgroundColorThemesEnum.dark;
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
  <br />

  navbar_manager.ID = "navbar-top-menu-dom-id-2";
  navbar_manager.ClearCSS();
  button_manager.ClearCSS();
  button_manager.AddCSS("btn btn-outline-light my-2 my-sm-0");
  navbar_manager.BackgroundColorTheme = bmBackgroundColorThemesEnum.primary;
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
  <br />

  navbar_manager.ID = "navbar-top-menu-dom-id-3";
  navbar_manager.ClearCSS();
  button_manager.ClearCSS();
  button_manager.AddCSS("btn btn-outline-primary my-2 my-sm-0");
  navbar_manager.NavbarColorScheme = MonochromeColorSchemesEnum.light;
  navbar_manager.BackgroundColorTheme = bmBackgroundColorThemesEnum.NULL;
  navbar_manager.SetStyle("background-color", "#e3f2fd");
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```

***result:***
![Demo](../demo/navbar-base-color-schemes.jpg)

## Placement[�](https://getbootstrap.com/docs/4.3/components/navbar/#placement)
>  ����������� ������� ���������������� ��� ���������� ������������� ������� � ������������� ����������.
�������� ���� �� ������������� ��������� `top`, `fixed to the bottom` ��� `stickied to the top` (������������ �������� �� ��� ���, ���� ��� �� ��������� �������, � ����� �������� ���).
������������� ������������� ������ ���������� `position: fixed`, ��� ��������, ��� ��� ������������ �� ����������� ������ **DOM** � ����� ��������� ����������������� **CSS** (��������, `padding-top` �� `<body>`), ����� ������������� ���������� � ������� ����������.

> ����� �������� ��������, ��� `.sticky-top` ���������� �������: `sticky`, ������� � ��������� ��������� �� ����� ������ ���������.

```cshtml
<header>
@{
  bsNavbar navbar_manager = new bsNavbar() { ID = "navbar-top-menu-dom-id" };
  navbar_manager.NavbarPlacement = NavbarPlacementsEnum.FixedTop;
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id")
    {
      Href = "#",
      Header = " Brand navbar",
      Title = "�������� ������"
    }
  };
  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```

###### Firefox 70 (x64) Win7 ***result:***
![Demo](../demo/navbar-placement-fixed-top-firefox-70-x64-win7.jpg)

###### Google Chrome 78.0.3904.70 (x64) Win7 ***result:***
![Demo](../demo/navbar-placement-fixed-top-google-chrome-78-x64-win7.jpg)

###### IE 11.0.9600.19507 (x64) Win7 ***result:***
![Demo](../demo/navbar-placement-fixed-top-ie-11-x64-win7.jpg)

## Nav x2

��� ������������� ����� ��������� ��� Nav � ����� Navbar

```cshtml
<header>
@{
  int CountUnreadedMessages = 0;
  if (ViewBag.CountUnreadedMessages is int)
  {
    CountUnreadedMessages = ViewBag.CountUnreadedMessages;
  }

  bsNavbar navbar_manager = new bsNavbar() { ID = "navbar-top-menu-dom-id" };
  navbar_manager.BackgroundColorTheme = bmBackgroundColorThemesEnum.dark;
  navbar_manager.NavbarColorScheme = MonochromeColorSchemesEnum.dark;
  navbar_manager.NavbarBrand = new NavbarBrandManager()
  {
    NavbarBrandPosition = NavbarBrandPositioningEnum.Left,
    ID = "navbar-brand-id",
    NavbarBrandDom = new BrandNavItemModel("navbar-brand-dom-id")
    {
      Href = "/",
      Header = " <span class=\"text-primary\">Shop</span><strong class=\"text-success\">ON</strong>",
      Title = "�������"
    }
  };

  bsNavbarNav navbar_nav_manager = new bsNavbarNav() { ID = "navbar-nav-left-dom-id" };
  navbar_nav_manager.AddCSS("mr-auto");
  navbar_nav_manager.AddNavItem(id_dom: "about-nav-dom-id", header: "About", href: "/about");
  navbar_nav_manager.AddNavItem("other-1-link-nav-dom-id", "Other 1", "#");
  navbar_nav_manager.AddNavItem("other-2-link-nav-dom-id", "Other 2", "#");
  navbar_nav_manager.AddNavItem("other-3-link-nav-dom-id", "Other 3", "#");
  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  navbar_nav_manager = new bsNavbarNav() { ID = "navbar-nav-right-dom-id" };
  navbar_nav_manager.AddCSS("ml-auto");
  @if (Model.User is null)
  {
    navbar_nav_manager.AddNavItem("navbar-login-link-nav-dom-id", "�����", "/account/login").AddCSS("text-primary");
  }
  else
  {
    NavItemModel navbar_nav_item;
    if (Model.User.AccessLevel >= AccessLevelUserModel.Manager)
    {
      navbar_nav_item = navbar_nav_manager.AddNavItem("navbar-admin-nav-dropdown-dom-id", "����������", "#");
      navbar_nav_item.AddCSS("bg-danger text-white");
      navbar_nav_item.AddSubNav(header_nav: "�������", href_nav: "/finance/", id_nav: "navbar-finance-nav-dom-id");
      navbar_nav_item.AddSubNav("��������", "/delivery/", "navbar-delivery-nav-dom-id");
      navbar_nav_item.AddSubNav("������������", "/users/", "navbar-users-nav-dom-id");
      navbar_nav_item.AddSubNav("�����������", "/assortment/", "navbar-assortment-nav-id");
      navbar_nav_item.AddSubNav("�����", "/files/", "navbar-files-nav-id");
    }
    navbar_nav_item = navbar_nav_manager.AddNavItem("navbar-unreaded-messages-nav-dom-id", "�����������", "/messages/");
    navbar_nav_item.Header += " <span class='badge" + (CountUnreadedMessages > 0 ? " text-danger badge-light" : "") + "'>" + CountUnreadedMessages + "</span>";
    navbar_nav_item = navbar_nav_manager.AddNavItem("navbar-profile-nav-dropdown-dom-id", "�������", "#");
    navbar_nav_item.AddSubNav(header_nav: "������", href_nav: "/account/", id_nav: "navbar-account-nav-dom-id");
    navbar_nav_item.AddSubNav(null);
    navbar_nav_item.AddSubNav(header_nav: "�����", href_nav: "/account/logout", id_nav: "navbar-logout-nav-dom-id");
  }

  navbar_manager.NavbarActions.AddSubNode(navbar_nav_manager);

  @await Component.InvokeAsync(navbar_manager.ViewComponentName, new { SetObjectManager = navbar_manager });
}
</header>
```

***result:*** ��������� ��� ���������������� ������������
![Demo](../demo/navbar-dual-nav-guest.jpg)

***result:*** ��������� ��� ��������������
![Demo](../demo/navbar-dual-nav-admin.jpg)

## Responsive behaviors[�](https://getbootstrap.com/docs/4.3/components/navbar/#responsive-behaviors)
>  � ��������...

## Toggler[�](https://getbootstrap.com/docs/4.3/components/navbar/#toggler)
>  ...

## External content[�](https://getbootstrap.com/docs/4.3/components/navbar/#external-content)
>  ...