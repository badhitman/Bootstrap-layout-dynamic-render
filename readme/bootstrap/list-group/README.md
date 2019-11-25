# List group[¶](https://getbootstrap.com/docs/4.3/components/list-group/)

> **List groups** - это гибкий и мощный компонент для отображения серии контента. Измените и расширьте их, чтобы поддерживать практически любой контент внутри.

## Basic example[¶](https://getbootstrap.com/docs/4.3/components/list-group/#basic-example)

> Самый обычный **list group** - это неупорядоченный список с соответствующими классами.
Соберите его с помощью следующих опций или с помощью вашего собственного CSS по мере необходимости.

```cshtml
@{

}
```

***result:***

![List group basic example](../../demo/list-group-basic-example-demo.jpg)

## Active items[¶](https://getbootstrap.com/docs/4.3/components/list-group/#active-items)

> Для указания текущего активного выбора к **.list-group-item** добавляется класс **.active**.

```cshtml
@{

}
```

***result:***

![List group active items](../../demo/list-group-active-items-demo.jpg)

## Disabled items[¶](https://getbootstrap.com/docs/4.3/components/list-group/#disabled-items)

> Чтобы **.list-group-item** выглядел отключенным, к нему добавляется класс **.disabled**.
Отметим, что для некоторых элементов классом **.disabled** также потребуется пользовательский **JavaScript**, чтобы полностью отключить их события кликов (например, ссылки).

```cshtml
@{

}
```

***result:***

![List group disabled items](../../demo/list-group-disabled-items-demo.jpg)

## Links and buttons[¶](https://getbootstrap.com/docs/4.3/components/list-group/#links-and-buttons)

> Используйте `<a>`**s** или `<button>`**s** для создания элементов **list group** с поддержкой состояний **hover**, **disabled** и **active** путем добавления **.list-group-item-action**.
Мы разделяем эти псевдоклассы, чтобы гарантировать, что **list group**, состоящий из неинтерактивных элементов (таких как `<li>`**s** или `<div>`**s**), не обеспечивают доступность щелчка или нажатия.
Ни когда не используйте тут стандартный класс **.btn**

```cshtml
@{

}
```

***result:***

![List group links](../../demo/list-group-links-demo.jpg)

> При использовании `<button>`**s** вы также можете использовать атрибут **disabled** вместо класса **.disabled**. К сожалению, `<a>`**s** не поддерживает атрибут **disabled**.

```cshtml
@{

}
```

***result:***

![List group with disables buttons](../../demo/list-group-disables-buttons-demo.jpg)

## Flush[¶](https://getbootstrap.com/docs/4.3/components/list-group/#flush)

> Использование **.list-group-flush** для удаления некоторых границ и закругленных углов для отображения элементов группы списков от края до края в Родительском контейнере (например, карты).

```cshtml
@{

}
```

***result:***

![List group flush](../../demo/list-group-flush-demo.jpg)

## Horizontal[¶](https://getbootstrap.com/docs/4.3/components/list-group/#horizontal)

> Добавление класса **.list-group-horizontal** измененит расположения элементов группового списка с вертикального на горизонтальное.
Кроме того, доступен адаптивный вариант **.list-group-horizontal-{sm|md|lg|xl}** чтобы сделать этот список горизонтальной только для некоторых экранов.
В настоящее время горизонтальные групповые списки не могут быть объединены с **flush**.
**Подсказка:** хотите, чтобы при горизонтальной ориентации элементы группы списка были равной ширины? Добавь **.flex-fill** для каждого элемента группового списка.

```cshtml
@{

}
```

***result:***

![List group horizontal](../../demo/list-group-horizontal-demo.jpg)

```cshtml
@{

}
```

***result:***

![List group horizontal-sm](../../demo/list-group-horizontal-sm-demo.jpg)


```cshtml
@{

}
```

***result:***

![List group horizontal-md](../../demo/list-group-horizontal-md-demo.jpg)

```cshtml
@{

}
```

***result:***

![List group horizontal-lg](../../demo/list-group-horizontal-lg-demo.jpg)

```cshtml
@{

}
```

***result:***

![List group horizontal-xl](../../demo/list-group-horizontal-xl-demo.jpg)

## Contextual classes[¶](https://getbootstrap.com/docs/4.3/components/list-group/#contextual-classes)

> Используйте контекстные классы для стилизации элементов списка с фоном и цветом с отслеживанием состояния.

```cshtml
@{

}
```

***result:***

![List group contextual classes](../../demo/list-group-contextual-classes-demo.jpg)

> Контекстные классы также работают с **.list-group-item-action**.
Также поддерживается **.active** состояние; примените его, чтобы указать активный/выбранный элемент.

```cshtml
@{

}
```

***result:***

![List group contextual classes item action](../../demo/list-group-contextual-classes-item-action-demo.jpg)

> Передача "данных состояния" в вспомогательные технологии:
Использование цвета для добавления "данных состояния" обеспечивает только визуальную индикацию, которая не будет передаваться пользователям вспомогательных технологий, таких как программы чтения с экрана.
Убедитесь, что информация, обозначенная цветом, либо очевидна из самого содержимого (например, видимый текст), либо включена с помощью альтернативных средств, таких как дополнительный текст, скрытый с помощью класса **.sr-only**.

## With badges[¶](https://getbootstrap.com/docs/4.3/components/list-group/#with-badges)

> Добавьте значки в любой элемент группы списков, чтобы показать непрочитанные счетчики, активность и многое другое с помощью некоторых [утилит](https://getbootstrap.com/docs/4.3/utilities/flex/).

```cshtml
@{

}
```

***result:***

![List group badges](../../demo/list-group-badges-demo.jpg)

## Custom content[¶](https://getbootstrap.com/docs/4.3/components/list-group/#custom-content)

> Добавьте почти любой HTML внутри элемента списка, даже для групп связанных списков, как показано ниже, с помощью [утилит flexbox](https://getbootstrap.com/docs/4.3/utilities/flex/).

```cshtml
@{

}
```

***result:***

![List group custom content](../../demo/list-group-custom-content-demo.jpg)
