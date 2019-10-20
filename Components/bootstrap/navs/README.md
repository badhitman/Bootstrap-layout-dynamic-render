## [Base nav](https://getbootstrap.com/docs/4.3/components/navs/#base-nav)
> Базовая навигация построена с применением **flexbox** и обеспечивает прочную основу для формирования всех типов навигационных компонентов.
Он включает в себя некоторые переопределения стилей (например: для работы со списками и т.п.)

> Базовый компонент `nav` не включает в себя никакого рендеринга `.active` состояния пунктов меню.
Следующие примеры включают класс `active`, главным образом, чтобы продемонстрировать, что этот конкретный класс не вызывает никакого специального стиля.

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
***result:***
![Bootstrap - Navs (base demo ul->li->a)](../../../demo/nav-base-ul-li-a.jpg)

> Классы в **Bootstrap** используются повсюду, поэтому ваша разметка может быть очень гибкой.
Используйте `<ul>`s, как продемонстрировано выше, либо воспользуйтесь элементом `<nav>`.
Так-как **.nav** использует `display: flex`, теги ссылок `<a>` внутри `<nav>` ведут себя так же, как и стандартные элементы навигации.

Для того что бы компонент навигации ипользовал теги ссылок `<a>` внутри `<nav>` - достаточно указать другой тип обёртки:

```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyLeftAligned);
// ...
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
```
***result:***
![Bootstrap - Navs (base demo nav->a)](../../../demo/nav-base-nav-a.jpg)

## [Horizontal alignment](https://getbootstrap.com/docs/4.3/components/navs/#horizontal-alignment)
> Измените горизонтальное выравнивание навигатора с помощью утилит flexbox. По умолчанию навигаторы выровнены по левому краю, но вы можете легко изменить их на выравнивание по центру или по правому краю.

Выравнивание назначается через позиционирование (параметр контсруктора менеджера навигации).
В следующем примере навигация центруется по горизонтали (применяется: `.justify-content-center`):

```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyCenterAligned);
```
***result:***
![Bootstrap - Horizontal alignment (demo center-alignment)](../../../demo/nav-horizontal-center-alignment.jpg)

В следующем примере навигация распологается справа по горизонтали (применяется: `.justify-content-end`):
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyRightAligned);
```
***result:***
![Bootstrap - Horizontal alignment (demo right-alignment)](../../../demo/nav-horizontal-right-alignment.jpg)

## [Vertical](https://getbootstrap.com/docs/4.3/components/navs/#vertical)
> Сделать навигацию в виде стэка можно изменив направление элемента flex с помощью утилиты .flex-column.

Горизонтальное расположение в виде стэка определяется через ориентацию. Так же как и при обычном базовом подходе:
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.Vertically);
```
***result:***
![Bootstrap - Vertical alignment (demo vertical-alignment ul->li->a)](../../../demo/nav-vertical-alignment-ul-li-a.jpg)

> Нужно складывать их на некоторых видовых экранах, но не на других? Используйте адаптивные версии (например, `.flex-sm-column`).
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.Vertically);
// удаляем стандартный для вертикального позиционирования CSS стилей
nav.RemoveCSS("flex-column");
// добавляем другой CSS стилей
nav.AddCSS("flex-md-column");

nav.AddNav("Active", "nav-home", "#").IsActive = true;
nav.AddNav("Link", "nav-link", "#");
nav.AddNav("Link", "nav-link-second", "#");
nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;                    
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
```
***result:*** сравнение отображения на разных устройствах (Монитор ПК и дисплей iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column ul->li->a)](../../../demo/nav-vertical-alignment-flex-sm-column-nav-a.jpg)

> Как всегда, вертикальная навигация возможна и без `<ul>`s.
```c#
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
```
***result:***
![Bootstrap - Vertical alignment (base demo vertical nav->a)](../../../demo/nav-vertical-alignment-nav-a.jpg)


## [Tabs](https://getbootstrap.com/docs/4.3/components/navs/#tabs)
> За основу берется базовая навигация и добавляется `.nav-tabs` класс для создания интерфейса с вкладками.
Используйте их для создания вкладочных областей с помощью `JavaScript tab` плагина.

**Tabs** стиль определяется через конструктор менеджера навигации (третий парамтр:`bool SetTabsStyle`)
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyLeftAligned, true);
```
***result:***
![Bootstrap - Tabs style (base demo tabs ul->li->a)](../../../demo/nav-tabs-ul-li-a.jpg)
Не следует совмещать стили **[Tabs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#tabs)** и **[Pills](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#pills)** одновременно

> Как всегда, навигация возможна и без `<ul>`s.

```c#
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
```
***result:***
![Bootstrap - Tabs style (base demo tabs nav->a)](../../../demo/nav-tabs-nav-a.jpg)

## [Pills](https://getbootstrap.com/docs/4.3/components/navs/#pills)
> Возьмите базовую навигацию, но примените к нему `.nav-pills`

Включение **nav-pills** производиться через соостветвующее поле параметра вызова базового компонента навигации `SetPillsTheme = true`.

```cshtml
@await Component.InvokeAsync(typeof(NavBase).Name, new { navManager = nav, SetPillsTheme = true })
```
***result:***
![Bootstrap - Pills style (base demo Pills ul->li->a)](../../../demo/nav-pills-ul-li-a.jpg)
Не следует совмещать стили **[Tabs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#tabs)** и **[Pills](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#pills)** одновременно

## [Fill and justify](https://getbootstrap.com/docs/4.3/components/navs/#fill-and-justify)
> Для принудительного расширения `.nav`s по всей доступной ширине применяется один из двух классов-модификаторов.
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyFill);
```
***result:***
![Bootstrap - Fill (base demo pills fill ul->li->a)](../../../demo/nav-pills-fill-ul-li-a.jpg)
> Чтобы пропорционально заполнить все доступное пространство телом `.nav-items`, используется `.nav-fill`.
Обратите внимание, что все горизонтальное пространство занято, но не каждый элемент навигации имеет одинаковую ширину.

> При использовании навигации на основе `<nav>` в режиме `fill`, пункты меню будут промаркированы классом `.nav-item`.
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyFill);
...
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
```
***result:***
![Bootstrap - Fill (base demo pills fill nav->a)](../../../demo/nav-pills-fill-nav-a.jpg)

Для задания элементов равной ширины используйте соответсвующее позиционирование `NavOrientationsEnum.HorizontallyJustified` (которое задействует: `.nav-justified`):
```c#
NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.HorizontallyJustified);
// ...
nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
```
***result:***
![Bootstrap - Fill (base demo pills justified ul->li->a)](../../../demo/nav-pills-justified-ul-li-a.jpg)
> Все горизонтальное пространство будет занято навигационными ссылками, но в отличие от предыдущего примера (`.nav-fill`), каждый элемент навигации будет одинаковой ширины.

## [Working with flex utilities](https://getbootstrap.com/docs/4.3/components/navs/#working-with-flex-utilities)
> Если вам нужны адаптивные варианты навигации, рассмотрите возможность использования ряда flexbox-утилит

Через механизм установки CSS стилей можно более детально и гибко манипулировать адаптированой вёрсткой:
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu", BootstrapViewComponentsRazorLibrary.Models.bootstrap.NavOrientationsEnum.Vertically);
    // добавления пользователського класса стилей блоку навигации
    // по умолчанию там уже будут классы nav, flex-column (в случае вертикальной ориентации) и nav-pills в случае применения стиля Pills
    nav.AddCSS("flex-sm-row");

    nav.AddNav("Active", "nav-home", "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true; 

    // метод добавления пользовательских классов в дочерние елементы (пункты меню на уровне тега <a></a>)
    // по умолчанию <a></a> якоря уже будут иметь обязательные классы стилей. мы к ним добавляем дополнительные
    nav.ChildsAddCSS("flex-sm-fill text-sm-center");
                   
    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { navManager = nav, SetPillsTheme = true })
</header>
```
> В приведенном ниже примере наш навигатор будет уложен на самую низкую **breakpoint**, а затем адаптируется к горизонтальной компоновке, которая заполняет доступную ширину, начиная с наименьшей **breakpoint**.

***result:*** сравнение отображения на разных устройствах (Монитор ПК и дисплей iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column ul->li->a)](../../../demo/nav-flex-utilities-nav-a.jpg)

## [Regarding accessibility](https://getbootstrap.com/docs/4.3/components/navs/#regarding-accessibility)
> дополняется ...

## [Tabs with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#tabs-with-dropdowns)
> дополняется ...

## [Pills with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#pills-with-dropdowns)
> дополняется ...

## [JavaScript behavior](https://getbootstrap.com/docs/4.3/components/navs/#javascript-behavior)
> дополняется ...
