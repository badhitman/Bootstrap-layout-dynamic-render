# ”ровень типового HTML

## A


```cshtml
@{
  LinkBasicManager link = new LinkBasicManager() { Header = "My html web link", ID = "link-dom-id", Href = "#" };
  @await Component.InvokeAsync(link.ViewComponentName, new { SetObjectManager = link })
}
```
***result:***
```html
<a href="#" id="link-dom-id" target="_blank">
  My html web link
</a>
```
