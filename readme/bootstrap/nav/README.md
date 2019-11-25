## Base nav[�](https://getbootstrap.com/docs/4.3/components/navs/#base-nav)

> ������� ��������� ��������� � ����������� **flexbox** � ������������ ������� ������ ��� ������������ ���� ����� ������������� �����������.
�� �������� � ���� ��������� ��������������� ������ (��������: ��� ������ �� �������� � �.�.)

> ������� ��������� `nav` �� �������� � ���� �������� ���������� `.active` ��������� ������� ����.
��������� ������� �������� ����� `active`, ������� �������, ����� ������������������, ��� ���� ���������� ����� �� �������� �������� ������������ �����.

```cshtml
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.AddCSS("shadow p-3 mb-5");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyLeftAligned;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
```
***result:***
![Bootstrap - Navs (base demo ul->li->a)](../demo/nav-base-ul-li-a.jpg)

```html
<ul id="top-nav-menu-dom-id" class="nav">
  <li class="nav-item">
    <a href="#" id="nav-home-dom-id" class="nav-link active">Active <span class="sr-only">(current)</span></a>
  </li>
  <li class="nav-item">
    <a href="#" id="nav-item-link-first-dom-id" class="nav-link">Link</a>
  </li>
  <li class="nav-item">
    <a href="#" id="nav-item-link-second-dom-id" class="nav-link">Link</a>
  </li>
  <li class="nav-item">
    <a aria-disabled="true" href="#" id="nav-item-disabled-dom-id" tabindex="-1" class="nav-link disabled">Disabled</a>
  </li>
</ul>
```

> ������ � **Bootstrap** ������������ �������, ������� ���� �������� ����� ���� ����� ������.
����������� `<ul>`s, ��� ������������������ ����, ���� �������������� ��������� `<nav>`.
���-��� **.nav** ���������� `display: flex`, ���� ������ `<a>` ������ `<nav>` ����� ���� ��� ��, ��� � ����������� �������� ���������.

��� ���� ��� �� ��������� ��������� ���������� ���� ������ `<a>` ������ `<nav>` - ���������� ���� ������� ������ ��� ������ `nav.NavWrapperType`:

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyLeftAligned;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Navs (base demo nav->a)](../demo/nav-base-nav-a.jpg)

## Horizontal alignment[�](https://getbootstrap.com/docs/4.3/components/navs/#horizontal-alignment)
> �������� �������������� ������������ ���������� � ������� ������ flexbox. �� ��������� ���������� ��������� �� ������ ����, �� �� ������ ����� �������� �� �� ������������ �� ������ ��� �� ������� ����.

������������ ����������� ����� ���������������� `nav.NavigationOrientation`.
� ��������� ������� ��������� ���������� �� ����������� (����������� ����� Bootstrap ������: **.justify-content-center**):

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyCenterAligned;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Horizontal alignment (demo center-alignment)](../demo/nav-horizontal-center-alignment.jpg)

� ��������� ������� ��������� ������������� ������ �� ����������� (����������� ����� Bootstrap ������: **.justify-content-end**):
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyRightAligned;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Horizontal alignment (demo right-alignment)](../demo/nav-horizontal-right-alignment.jpg)

## Vertical[�](https://getbootstrap.com/docs/4.3/components/navs/#vertical)
> ������� ��������� � ���� ����� ����� ������� ����������� �������� flex � ������� ������� **.flex-column**.

�������������� ������������ � ���� ����� ������������ ����� ���������� (��������: `nav.NavigationOrientation`):
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.Vertically;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Vertical alignment (demo vertical-alignment ul->li->a)](../demo/nav-vertical-alignment-ul-li-a.jpg)

> ����� ���������� �� �� ��������� ������� �������, �� �� �� ������? ����������� ���������� ������ (��������, `.flex-sm-column`).

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.Vertically;

  // ��������� ���������� ���������������� ����� ������
  nav.AddCSS("flex-md-column");
  // ���� � ��� ��� ����������� ����� ������ ��� ������������� ���������������� flex-column ����������� ������ � ������ ���� ������ ���������� ������ �������� �������: !<CSS Styles List>.Any(x => x.StartsWith("flex-") && x.EndsWith("-column"))
  // ����� ������� ������� ����� "flex-md-column" �� ��������, ��� ����� "flex-column" (������������ �� ��������� ��� ������������� ���������������� ����� ���������), �� ����� ��������

  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:*** ��������� ����������� �� ������ ����������� (������� �� � ������� iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column ul->li->a)](../demo/nav-vertical-alignment-flex-sm-column-nav-a.jpg)

> �����������, ������������ ��������� �������� � ��� `<ul>`s.
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.Vertically;

  // ��������� ���������� ���������������� ����� ������
  nav.AddCSS("flex-md-column");
  // ���� � ��� ��� ����������� ����� ������ ��� ������������� ���������������� flex-column ����������� ������ � ������ ���� ������ ���������� ������ �������� �������: !<CSS Styles List>.Any(x => x.StartsWith("flex-") && x.EndsWith("-column"))
  // ����� ������� ������� ����� "flex-md-column" �� ��������, ��� ����� "flex-column" (������������ �� ��������� ��� ������������� ���������������� ����� ���������), �� ����� ��������

  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Vertical alignment (base demo vertical nav->a)](../demo/nav-vertical-alignment-nav-a.jpg)


## Tabs[�](https://getbootstrap.com/docs/4.3/components/navs/#tabs)
> �� ������ ������� ������� ��������� � ����������� `.nav-tabs` ����� ��� �������� ���������� � ���������.
����������� �� ��� �������� ���������� �������� � ������� `JavaScript tab` �������.

1. ������ ��������� ����� **Tabs** � **[Pills](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/bootstrap/navs#pills)** ������������
2. ��� ����� **Tabs** �� ������������� ������������ ����������������

**Tabs** ����� ������������ ����� �������������� ��������� `nav.IsTabsStyle = true;`
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.IsTabsStyle = true;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Tabs style (base demo tabs ul->li->a)](../demo/nav-tabs-ul-li-a.jpg)

> �����������, ��������� �������� � ��� `<ul>`s.

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.IsTabsStyle = true;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Tabs style (base demo tabs nav->a)](../demo/nav-tabs-nav-a.jpg)

## Pills[�](https://getbootstrap.com/docs/4.3/components/navs/#pills)
> �������� ������� ���������, �� ��������� � ���� `.nav-pills`

������ ��������� ����� **Pills** � **[Tabs](https://github.com/badhitman/BootstrapAspDynamicRender/tree/master/Components/bootstrap/navs#tabs)** ������������

��������� **nav-pills** ������������� ����� �������������� ���� ��������� ������ �������� ���������� ��������� `SetPillsTheme = true`.

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.IsTabsStyle = false;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Link", "#", "nav-item-link-first-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
***result:***
![Bootstrap - Pills style (base demo Pills ul->li->a)](../demo/nav-pills-ul-li-a.jpg)

## Fill and justify[�](https://getbootstrap.com/docs/4.3/components/navs/#fill-and-justify)
> ��� ��������������� ���������� `.nav`s �� ���� ��������� ������ ����������� ���� �� ���� �������-�������������.
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyFill;
  nav.IsTabsStyle = false;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Much longer nav link", "#", "nav-item-link-much-longer-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
***result:***
![Bootstrap - Fill (base demo pills fill ul->li->a)](../demo/nav-pills-fill-ul-li-a.jpg)
> ����� ��������������� ��������� ��� ��������� ������������ ����� `.nav-items`, ������������ `.nav-fill`.
�������� ��������, ��� ��� �������������� ������������ ������, �� �� ������ ������� ��������� ����� ���������� ������.

> ��� ������������� ��������� �� ������ `<nav>` � ������ **fill**, ������ ���� ����� �������������� ������� **.nav-item**.

```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyFill;
  nav.IsTabsStyle = false;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Much longer nav link", "#", "nav-item-link-much-longer-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
***result:***
![Bootstrap - Fill (base demo pills fill nav->a)](../demo/nav-pills-fill-nav-a.jpg)

��� ������� ��������� ������ ������ ����������� �������������� ���������������� `NavOrientationsEnum.HorizontallyJustified` (������� ����������� ���� ������: **.nav-justified**):
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.HorizontallyJustified;
  nav.IsTabsStyle = false;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Much longer nav link", "#", "nav-item-link-much-longer-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
***result:***
![Bootstrap - Fill (base demo pills justified ul->li->a)](../demo/nav-pills-justified-ul-li-a.jpg)
> ��� �������������� ������������ ����� ������ �������������� ��������, �� � ������� �� ����������� ������� (`.nav-fill`), ������ ������� ��������� ����� ���������� ������.

## Working with flex utilities[�](https://getbootstrap.com/docs/4.3/components/navs/#working-with-flex-utilities)
> ���� ��� ����� ���������� �������� ���������, ����������� ����������� ������������� ���� flexbox-������

����� �������� ��������� CSS ������ ����� ����� �������������� ���������� �������:
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.NavigationOrientation = bmNavOrientationsEnum.Vertically;

  // ���������� ����������������� ������ ������ ����� ���������
  // �� ��������� ��� ��� ����� ������ "nav", "flex-column" (� ������ ������������ ����������) � "nav-pills" (� ������ ���������� ����� Pills)
  nav.AddCSS("flex-sm-row");

  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;
  nav.AddNav("Longer nav link", "#", "nav-item-longer-link-dom-id");
  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;

  // ����� ���������� ���������������� ������� � �������� �������� (������ ���� �� ������ ���� <a></a>)
  // �� ��������� <a></a> ����� ��� ����� ����� ������������ ������ ������. �� � ��� ��������� ��������������
  // ������ ������ ����� ��������� ������ � ������������(��� ����������) ������ ����
  nav.ChildsAddCSS("flex-sm-fill text-sm-center");

  nav.NavWrapperType = bmNavWrappersEnum.nav;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
> � ����������� ���� ������� ��� ��������� ����� ������ �� ����� ������ **breakpoint**, � ����� ������������ � �������������� ����������, ������� ��������� ��������� ������, ������� � ���������� **breakpoint**.

***result:*** ��������� ����������� �� ������ ����������� (������� �� � ������� iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column nav->a)](../demo/nav-flex-utilities-nav-a.jpg)

## Tabs with dropdowns[�](https://getbootstrap.com/docs/4.3/components/navs/#tabs-with-dropdowns)
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.IsTabsStyle = true;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;

  bsNavItem dropdown_nav = nav.AddNav("Dropdown", "#", "nav-dropdown-dom-id");
  dropdown_nav.AddSubNav("Action", "#", "nav-dropdown-action-sub-item-dom-id");
  dropdown_nav.AddSubNav("Another action", "#", "nav-dropdown-another-action-sub-item-dom-id");
  dropdown_nav.AddSubNav("Something else here", "#", "nav-dropdown-something-action-sub-item-dom-id");
  dropdown_nav.AddSubNav(null);//<div class="dropdown-divider"></div>
  dropdown_nav.AddSubNav("Separated link", "#", "nav-dropdown-separated-link-sub-item-dom-id");

  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;

  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Tabs with dropdowns (base demo tabs dropdowns ul->li->a)](../demo/nav-dropdowns-tabs-ul-li-a.jpg)

## Pills with dropdowns[�](https://getbootstrap.com/docs/4.3/components/navs/#pills-with-dropdowns)
```cshtml
<header>
@{
  bsNavReferenceBehavior nav = new bsNavReferenceBehavior("top-nav-menu-dom-id");
  nav.IsTabsStyle = false;
  nav.AddNav(SetNavHeader: "Active", SetNavHref: "#", SetNavId: "nav-home-dom-id").IsActive = true;

  bsNavItem dropdown_nav = nav.AddNav("Dropdown", "#", "nav-dropdown-dom-id");
  dropdown_nav.AddSubNav("Action", "#", "nav-dropdown-action-sub-item-dom-id");
  dropdown_nav.AddSubNav("Another action", "#", "nav-dropdown-another-action-sub-item-dom-id");
  dropdown_nav.AddSubNav("Something else here", "#", "nav-dropdown-something-action-sub-item-dom-id");
  dropdown_nav.AddSubNav(null);//<div class="dropdown-divider"></div>
  dropdown_nav.AddSubNav("Separated link", "#", "nav-dropdown-separated-link-sub-item-dom-id");

  nav.AddNav("Link", "#", "nav-item-link-second-dom-id");
  nav.AddNav("Disabled", "#", "nav-item-disabled-dom-id").IsDisabled = true;

  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```
***result:*** _���-���� ������� (�����) � ��������� (������)_
![Bootstrap - Tabs-pills with dropdowns (base demo pills dropdowns ul->li->a)](../demo/nav-dropdowns-pills-ul-li-a.jpg)

## JavaScript behavior[�](https://getbootstrap.com/docs/4.3/components/navs/#javascript-behavior)
```cshtml
<header>
@{
  // test content for tabs
  string contetnt_home = "Home! Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.";
  string contetnt_profile = "Profile! Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.";
  string contetnt_contact = "Contact! Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.";

  NavJavaScriptBehaviorManager nav = new NavJavaScriptBehaviorManager("top-menu");
  nav.IsTabsStyle = true;
  nav.AddNav("Home", "nav-home", contetnt_home).IsActive = true;
  nav.AddNav("Profile", "nav-profile", contetnt_profile);
  nav.AddNav("Contact", "nav-contact", contetnt_contact);

  nav.IsFadeStyle = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;

  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Tabs JavaScript behavior (base demo JavaScript behavior ul->li->a)](../demo/nav-tabs-js-behavior-ul-li-a.jpg)

> ����� ������������� ����� �����������, ��� �������� � ��������� �� ������ `<ul>`, ��� �������� ����, ��� � ����� ������������ ��������� �roll your own�.
�������� ��������, ��� ���� �� ����������� `<nav>`, �� �� ������ ��������� `role="tablist"` ��������������� � ����, ��� ��� ��� ������������� ����������� ���� �������� � �������� ��������� ���������.
������ ����� ���������� ������������ �� �������������� ������� (� ������� ����, ������� `<div>`), � �� � ���� ������� ������������� ����� `<nav>`.

��� ���� ��� �� ��������� ��������� ���������� ���� ������ `<a>` ������ `<nav>` - ���������� ������� ������ ��� ������ `nav.NavWrapperType`:

```cshtml
<header>
@{
  // test content for tabs
  string contetnt_home = "Home! Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.";
  string contetnt_profile = "Profile! Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.";
  string contetnt_contact = "Contact! Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.";

  NavJavaScriptBehaviorManager nav = new NavJavaScriptBehaviorManager("top-menu");
  nav.IsTabsStyle =  true;
  nav.AddNav("Home", "nav-home", contetnt_home).IsActive = true;
  nav.AddNav("Profile", "nav-profile", contetnt_profile);
  nav.AddNav("Contact", "nav-contact", contetnt_contact);

  nav.IsFadeStyle = true;
  nav.NavWrapperType = bmNavWrappersEnum.nav;
  
  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = false })
}
</header>
```
***result:***
![Bootstrap - Tabs JavaScript behavior (base demo JavaScript behavior nav->div->a)](../demo/nav-tabs-js-behavior-nav-div-a.jpg)

> ������ **JavaScript behavior** ����� �������� � **pills**.

***result:***
![Bootstrap - JavaScript behavior (as Pills) (base demo JavaScript behavior ul->li->a)](../demo/nav-pills-js-behavior-ul-li-a.jpg)

> � � ������������� Pills.

```cshtml
<header>
@{
  string contetnt_home = "Home! Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.";
  string contetnt_profile = "Profile! Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.";
  string contetnt_contact = "Contact! Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.";

  NavJavaScriptBehaviorManager nav = new NavJavaScriptBehaviorManager("top-menu");
  nav.NavigationOrientation = bmNavOrientationsEnum.Vertically;
  nav.AddNav("Home", "nav-home", contetnt_home).IsActive = true;
  nav.AddNav("Profile", "nav-profile", contetnt_profile);
  nav.AddNav("Contact", "nav-contact", contetnt_contact);
  nav.IsFadeStyle = true;
  nav.NavWrapperType = bmNavWrappersEnum.ul;
  
  @await Component.InvokeAsync(nav.ViewComponentName, new { SetObjectManager = nav, SetPillsTheme = true })
}
</header>
```

***result:***
![Bootstrap - JavaScript behavior (as Vertical Pills) (base demo JavaScript behavior ul->li->a)](../demo/nav-vertical-pills-js-behavior-ul-li-a.jpg)