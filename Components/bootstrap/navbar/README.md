## [Navbar](https://getbootstrap.com/docs/4.3/components/navbar/)
> Вот что нужно знать, прежде чем начать работу с навигационной панелью:

- Навигационные панели требуют обертывания `.navbar` при помощи `.navbar-expand{-sm|-md|-lg|-xl}` для гибкой адаптивной разметки.
- Навигационные панели и их содержимое по умолчанию являются растягивающимся/жидкими. Используйте дополнительные контейнеры, чтобы ограничить их горизонтальную ширину.
- Используйте классы утилит `spacing` и `flex` для управления расстоянием и выравниванием в навигационных панелях.
- Навигационные панели реагируют по умолчанию, но вы можете легко изменить их, чтобы изменить это. Отзывчивое поведение зависит от нашего плагина **JavaScript Collapse**.
- Навигационные панели по умолчанию скрыты при печати. Заставьте их быть напечатаны путем добавления `.d-print` на `.navbar`. Обратите внимание на классы утилиты **display**.
- Обеспечьте доступность с помощью элемента `<nav>` или, если используется более общий элемент, такой как `<div>`, добавьте `role="navigation"` к каждой навигационной панели, чтобы явно определить ее как ориентир для пользователей вспомогательных технологий.

> Navbars поставляются со встроенной поддержкой [нескольких субкомпонентов](https://getbootstrap.com/docs/4.3/components/navbar/#supported-content):

- **.navbar-brand** для названия вашей компании, продукта или проекта. В том числе с аватаркой/картинкой.
- **.navbar-nav** для `full-height` и `lightweight` навигации (включая поддержку выпадающих меню).
- **.navbar-toggler** для использования с нашим плагином _collapse_ и другими способами переключения навигации.
- **.form-inline** для любых элементов управления и действий формы.
- **.navbar-text** для добавления вертикально центрированных строк текста.
- **.collapse.navbar-collapse** для группировки и скрытия содержимого навигационной панели.

## [Brand](https://getbootstrap.com/docs/4.3/components/navbar/#brand)
>  дополняется

## [Nav](https://getbootstrap.com/docs/4.3/components/navbar/#nav)
>  дополняется

## [Forms](https://getbootstrap.com/docs/4.3/components/navbar/#forms)
>  дополняется

## [Text](https://getbootstrap.com/docs/4.3/components/navbar/#text)
>  дополняется

## [Color schemes](https://getbootstrap.com/docs/4.3/components/navbar/#color-schemes)
>  дополняется

## [Containers](https://getbootstrap.com/docs/4.3/components/navbar/#containers)
>  дополняется

## [Placement](https://getbootstrap.com/docs/4.3/components/navbar/#placement)
>  Используйте утилиты позиционирования для размещения навигационных панелей в нестатических положениях.
Выберите одно из фиксированных положений `top`, `fixed to the bottom` или `stickied to the top` (прокручивает страницу до тех пор, пока она не достигнет вершины, а затем остается там).
Фиксированные навигационные панели используют `position: fixed`, что означает, что они вытягиваются из нормального потока **DOM** и могут требовать пользовательского **CSS** (например, `padding-top` на `<body>`), чтобы предотвратить перекрытие с другими элементами.

> Также обратите внимание, что `.sticky-top` использует позицию: `sticky`, которая в некоторых браузерах не имеет полной поддержки.

## [Responsive behaviors](https://getbootstrap.com/docs/4.3/components/navbar/#responsive-behaviors)
>  дополняется

## [Toggler](https://getbootstrap.com/docs/4.3/components/navbar/#toggler)
>  дополняется

## [External content](https://getbootstrap.com/docs/4.3/components/navbar/#external-content)
>  дополняется