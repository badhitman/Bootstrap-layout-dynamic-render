## [Base nav](https://getbootstrap.com/docs/4.3/components/navs/#base-nav)
```cshtml
@using BootstrapViewComponentsRazorLibrary.Service.bootstrap
@using BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav
@{
  NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyLeftAligned);
  nav.AddNav("Active", "nav-home", "#").IsActive = true;
  nav.AddNav("Link", "nav-link", "#");
  nav.AddNav("Link", "nav-linc-second", "#");
  nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
  nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
}
@await Component.InvokeAsync(typeof(NavBase).Name, new { navManager = nav, SetPillsTheme = false })
```
result:
```html
<ul id="top-menu" class="nav">
  <li class="nav-item" >
    <a id="nav-home" class="nav-link active" href="#">Active</a>
  </li>
  <li class="nav-item" >
    <a id="nav-link" class="nav-link" href="#">Link</a>
  </li>
  <li class="nav-item" >
    <a id="nav-linc-second" class="nav-link" href="#">Link</a>
  </li>
  <li class="nav-item" >
    <a id="nav-disabled" tabindex="-1" aria-disabled="true" class="nav-link disabled" href="#">Disabled</a>
  </li>
</ul>
```

## [Horizontal alignment](https://getbootstrap.com/docs/4.3/components/navs/#horizontal-alignment)
> дополняется ...

## [Vertical](https://getbootstrap.com/docs/4.3/components/navs/#vertical)
> дополняется ...

## [Tabs](https://getbootstrap.com/docs/4.3/components/navs/#tabs)
> дополняется ...

## [Pills](https://getbootstrap.com/docs/4.3/components/navs/#pills)
> дополняется ...

## [Fill and justify](https://getbootstrap.com/docs/4.3/components/navs/#fill-and-justify)
> дополняется ...

## [Working with flex utilities](https://getbootstrap.com/docs/4.3/components/navs/#working-with-flex-utilities)
> дополняется ...

## [Regarding accessibility](https://getbootstrap.com/docs/4.3/components/navs/#regarding-accessibility)
> дополняется ...

## [Tabs with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#tabs-with-dropdowns)
> дополняется ...

## [Pills with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#pills-with-dropdowns)
> дополняется ...

## [JavaScript behavior](https://getbootstrap.com/docs/4.3/components/navs/#javascript-behavior)
> дополняется ...
