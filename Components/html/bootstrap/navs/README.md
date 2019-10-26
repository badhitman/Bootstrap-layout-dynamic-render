## [Base nav](https://getbootstrap.com/docs/4.3/components/navs/#base-nav)
> Базовая навигация построена с применением **flexbox** и обеспечивает прочную основу для формирования всех типов навигационных компонентов.
Он включает в себя некоторые переопределения стилей (например: для работы со списками и т.п.)

> Базовый компонент `nav` не включает в себя никакого рендеринга `.active` состояния пунктов меню.
Следующие примеры включают класс `active`, главным образом, чтобы продемонстрировать, что этот конкретный класс не вызывает никакого специального стиля.

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyLeftAligned;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Navs (base demo ul->li->a)](../../../../demo/nav-base-ul-li-a.jpg)

> Классы в **Bootstrap** используются повсюду, поэтому ваша разметка может быть очень гибкой.
Используйте `<ul>`s, как продемонстрировано выше, либо воспользуйтесь элементом `<nav>`.
Так-как **.nav** использует `display: flex`, теги ссылок `<a>` внутри `<nav>` ведут себя так же, как и стандартные элементы навигации.

Для того что бы компонент навигации ипользовал теги ссылок `<a>` внутри `<nav>` - достаточно было указать другой тип обёртки `nav.NavWrapperType`:

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyLeftAligned;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Navs (base demo nav->a)](../../../../demo/nav-base-nav-a.jpg)

## [Horizontal alignment](https://getbootstrap.com/docs/4.3/components/navs/#horizontal-alignment)
> Измените горизонтальное выравнивание навигатора с помощью утилит flexbox. По умолчанию навигаторы выровнены по левому краю, но вы можете легко изменить их на выравнивание по центру или по правому краю.

Выравнивание назначается через позиционирование `nav.NavigationOrientation`.
В следующем примере навигация центруется по горизонтали (применяется класс Bootstrap стилей: **.justify-content-center**):

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyCenterAligned;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Horizontal alignment (demo center-alignment)](../../../../demo/nav-horizontal-center-alignment.jpg)

В следующем примере навигация распологается справа по горизонтали (применяется класс Bootstrap стилей: **.justify-content-end**):
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyRightAligned;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Horizontal alignment (demo right-alignment)](../../../../demo/nav-horizontal-right-alignment.jpg)

## [Vertical](https://getbootstrap.com/docs/4.3/components/navs/#vertical)
> Сделать навигацию в виде стэка можно изменив направление элемента flex с помощью утилиты **.flex-column**.

Горизонтальное расположение в виде стэка определяется через ориентацию (свойство: `nav.NavigationOrientation`):
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.Vertically;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Vertical alignment (demo vertical-alignment ul->li->a)](../../../../demo/nav-vertical-alignment-ul-li-a.jpg)

> Нужно складывать их на некоторых видовых экранах, но не на других? Используйте адаптивные версии (например, `.flex-sm-column`).

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.Vertically;

    // добавляем адаптивный пользовательский класс стилей
    nav.AddCSS("flex-md-column");
    // дело в том что стандартный класс стилей для вертиклаьного позиционирования flex-column добавляется только в случае если спсиок назначеных стилей отвечает условию: !<CSS Styles as List>.Any(x => x.StartsWith("flex-") && x.EndsWith("-column"))

    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;                    
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:*** сравнение отображения на разных устройствах (Монитор ПК и дисплей iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column ul->li->a)](../../../../demo/nav-vertical-alignment-flex-sm-column-nav-a.jpg)

> Традиционно, вертикальная навигация возможна и без `<ul>`s.
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.Vertically;

    // добавляем адаптивный пользовательский класс стилей
    nav.AddCSS("flex-md-column");
    // дело в том что стандартный класс стилей для вертиклаьного позиционирования flex-column добавляется только в случае если спсиок назначеных стилей отвечает условию: !<CSS Styles as List>.Any(x => x.StartsWith("flex-") && x.EndsWith("-column"))

    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;                    
    nav.NavWrapperType = NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Vertical alignment (base demo vertical nav->a)](../../../../demo/nav-vertical-alignment-nav-a.jpg)


## [Tabs](https://getbootstrap.com/docs/4.3/components/navs/#tabs)
> За основу берется базовая навигация и добавляется `.nav-tabs` класс для создания интерфейса с вкладками.
Используйте их для создания вкладочных областей с помощью `JavaScript tab` плагина.

1. Нельзя совмещать стили **Tabs** и **[Pills](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#pills)** одновременно
2. Для стиля **Tabs** не предусмотрено вертикальное позиционирование

**Tabs** стиль определяется через соответсвующее свойствао `nav.IsTabsStyle = true;`
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.IsTabsStyle = true;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Tabs style (base demo tabs ul->li->a)](../../../../demo/nav-tabs-ul-li-a.jpg)

> Традиционно, навигация возможна и без `<ul>`s.

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.IsTabsStyle = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Tabs style (base demo tabs nav->a)](../../../../demo/nav-tabs-nav-a.jpg)

## [Pills](https://getbootstrap.com/docs/4.3/components/navs/#pills)
> Возьмите базовую навигацию, но примените к нему `.nav-pills`

Нельзя совмещать стили **Pills** и **[Tabs](https://github.com/badhitman/BootstrapViewComponentsRazorLibrary/tree/master/Components/bootstrap/navs#tabs)** одновременно

Включение **nav-pills** производиться через соостветвующее поле параметра вызова базового компонента навигации `SetPillsTheme = true`.

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
***result:***
![Bootstrap - Pills style (base demo Pills ul->li->a)](../../../../demo/nav-pills-ul-li-a.jpg)

## [Fill and justify](https://getbootstrap.com/docs/4.3/components/navs/#fill-and-justify)
> Для принудительного расширения `.nav`s по всей доступной ширине применяется один из двух классов-модификаторов.
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyFill;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Much longer nav link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
***result:***
![Bootstrap - Fill (base demo pills fill ul->li->a)](../../../../demo/nav-pills-fill-ul-li-a.jpg)
> Чтобы пропорционально заполнить все доступное пространство телом `.nav-items`, используется `.nav-fill`.
Обратите внимание, что все горизонтальное пространство занято, но не каждый элемент навигации имеет одинаковую ширину.

> При использовании навигации на основе `<nav>` в режиме **fill**, пункты меню будут промаркированы классом **.nav-item**.

```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyFill;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Much longer nav link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
***result:***
![Bootstrap - Fill (base demo pills fill nav->a)](../../../../demo/nav-pills-fill-nav-a.jpg)

Для задания элементов равной ширины используйте соответсвующее позиционирование `NavOrientationsEnum.HorizontallyJustified` (которое задействует клас стилей: **.nav-justified**):
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyJustified;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Much longer nav link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
***result:***
![Bootstrap - Fill (base demo pills justified ul->li->a)](../../../../demo/nav-pills-justified-ul-li-a.jpg)
> Все горизонтальное пространство будет занято навигационными ссылками, но в отличие от предыдущего примера (`.nav-fill`), каждый элемент навигации будет одинаковой ширины.

## [Working with flex utilities](https://getbootstrap.com/docs/4.3/components/navs/#working-with-flex-utilities)
> Если вам нужны адаптивные варианты навигации, рассмотрите возможность использования ряда flexbox-утилит

Через механизм установки CSS стилей можно гибче манипулировать адаптивной вёрсткой:
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.Vertically;
    
    // добавление пользователського класса стилей блоку навигации
    // по умолчанию там уже будут классы "nav", "flex-column" (в случае вертикальной ориентации) и "nav-pills" (в случае применения стиля Pills)
    nav.AddCSS("flex-sm-row");

    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;
    nav.AddNav("Link", "nav-link", "#");
    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true; 

    // метод добавления пользовательских классов в дочерние елементы (пункты меню на уровне тега <a></a>)
    // по умолчанию <a></a> якоря уже будут иметь обязательные классы стилей. мы к ним добавляем дополнительные
    // классы стилей будут добавлены толкьо в существующие(уже добавленые) пункты меню
    nav.ChildsAddCSS("flex-sm-fill text-sm-center");
                   
    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
> В приведенном ниже примере наш навигатор будет уложен на самую низкую **breakpoint**, а затем адаптируется к горизонтальной компоновке, которая заполняет доступную ширину, начиная с наименьшей **breakpoint**.

***result:*** сравнение отображения на разных устройствах (Монитор ПК и дисплей iPhone 6/7/8)
![Bootstrap - Vertical alignment (demo vertical-alignment flex-sm-column nav->a)](../../../../demo/nav-flex-utilities-nav-a.jpg)

## [Tabs with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#tabs-with-dropdowns)
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.IsTabsStyle = true;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;

    NavItemModel dropdown_nav = nav.AddNav("Dropdown", "dropdown-nav", "#");
    dropdown_nav.AddSubNav("Action", "dropdown-item-1", "#");
    dropdown_nav.AddSubNav("Another action", "dropdown-item-2", "#");
    dropdown_nav.AddSubNav("Something else here", "dropdown-item-3", "#");
    dropdown_nav.AddSubNav(null);//<div class="dropdown-divider"></div>
    dropdown_nav.AddSubNav("Separated link", "dropdown-item-4", "#");

    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;

    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:*** _под-меню свёрнуто (слева) и развёрнуто (справа)_
![Bootstrap - Tabs with dropdowns (base demo tabs dropdowns ul->li->a)](../../../../demo/nav-dropdowns-tabs-ul-li-a.jpg)

## [Pills with dropdowns](https://getbootstrap.com/docs/4.3/components/navs/#pills-with-dropdowns)
```cshtml
<header>
  @{
    NavReferenceBehaviorManager nav = new NavReferenceBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.HorizontallyJustified;
    nav.AddNav(SetNavHeader: "Active", SetNavId: "nav-home", SetNavHref: "#").IsActive = true;

    NavItemModel dropdown_nav = nav.AddNav("Dropdown", "dropdown-nav", "#");
    dropdown_nav.AddSubNav(header_nav: "Action", href_nav: "#", id_dom: "dropdown-item-1");
    dropdown_nav.AddSubNav("Another action", "#", "dropdown-item-2");
    dropdown_nav.AddSubNav("Something else here", "#", "dropdown-item-3");
    dropdown_nav.AddSubNav(null);//<div class="dropdown-divider"></div>
    dropdown_nav.AddSubNav("Separated link", "dropdown-item-4", "#");

    nav.AddNav("Link", "nav-link-second", "#");
    nav.AddNav("Disabled", "nav-disabled", "#").IsDisabled = true;
    nav.NavWrapperType = NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```
***result:*** _под-меню свёрнуто (слева) и развёрнуто (справа)_
![Bootstrap - Tabs-pills with dropdowns (base demo pills dropdowns ul->li->a)](../../../../demo/nav-dropdowns-pills-ul-li-a.jpg)

## [JavaScript behavior](https://getbootstrap.com/docs/4.3/components/navs/#javascript-behavior)
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
    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Tabs JavaScript behavior (base demo JavaScript behavior ul->li->a)](../../../../demo/nav-tabs-js-behavior-ul-li-a.jpg)

> Чтобы удовлетворить любые потребности, это работает с разметкой на основе `<ul>`, как показано выше, или с любой произвольной разметкой “roll your own”.
Обратите внимание, что если вы используете `<nav>`, вы не должны добавлять `role="tablist"` непосредственно к нему, так как это переопределит собственную роль элемента в качестве ориентира навигации.
Вместо этого происходит переключение на альтернативный элемент (в примере ниже, простой `<div>`), а он в свою очередь оберачивается тегом `<nav>`.

Для того что бы компонент навигации ипользовал теги ссылок `<a>` внутри `<nav>` - достаточно указать другой тип обёртки `nav.NavWrapperType`:

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
    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.nav;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = false })
</header>
```
***result:***
![Bootstrap - Tabs JavaScript behavior (base demo JavaScript behavior nav->div->a)](../../../../demo/nav-tabs-js-behavior-nav-div-a.jpg)

> Плагин **JavaScript behavior** также работает с **pills**.

***result:***
![Bootstrap - JavaScript behavior (as Pills) (base demo JavaScript behavior ul->li->a)](../../../../demo/nav-pills-js-behavior-ul-li-a.jpg)

> И с вертикальными Pills.

```cshtml
<header>
  @{
    string contetnt_home = "Home! Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.";
    string contetnt_profile = "Profile! Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.";
    string contetnt_contact = "Contact! Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.";

    NavJavaScriptBehaviorManager nav = new NavJavaScriptBehaviorManager("top-menu");
    nav.NavigationOrientation = NavOrientationsEnum.Vertically;
    nav.AddNav("Home", "nav-home", contetnt_home).IsActive = true;
    nav.AddNav("Profile", "nav-profile", contetnt_profile);
    nav.AddNav("Contact", "nav-contact", contetnt_contact);
    nav.IsFadeStyle = true;
    nav.NavWrapperType = BootstrapViewComponentsRazorLibrary.Models.NavWrapperTypesEnum.ul;
  }
  @await Component.InvokeAsync(typeof(NavBase).Name, new { SetObjectManager = nav, SetPillsTheme = true })
</header>
```

***result:***
![Bootstrap - JavaScript behavior (as Vertical Pills) (base demo JavaScript behavior ul->li->a)](../../../../demo/nav-vertical-pills-js-behavior-ul-li-a.jpg)