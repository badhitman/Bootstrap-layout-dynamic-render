# Button group[¶](https://getbootstrap.com/docs/4.3/components/button-group/)

> Группировка серии кнопок в единый элемент управления

## Basic example[¶](https://getbootstrap.com/docs/4.3/components/button-group/#basic-example)

> Оберните серию кнопок (с классом: **.btn**) в **.btn-group**.
Объеденив **radio** и **checkbox**, а JavaScript поведение будет обеспечено при помощи [плагина кнопок](https://getbootstrap.com/docs/4.3/components/buttons/#button-plugin).

```cshtml

```

***result:***

![Button group](../../../../demo/btn-group-basic-example-demo.jpg)

> Обеспечьте правильную роль и установите метку.
Для того, чтобы вспомогательные технологии (такие как программы чтения с экрана) корректно определяли информацию о том, что ряд кнопок сгруппирован, необходимо предоставить соответствующий атрибут роли. Для групп кнопок это будет `role="group"`, в то время как панели инструментов должны иметь `role="toolbar"`.
Кроме того, группам и панелям инструментов должна быть присвоена явная метка, так как большинство вспомогательных технологий в противном случае не объявляют их, несмотря на наличие правильного атрибута роли. В приведенных здесь примерах используется **aria-label**, но также можно использовать альтернативы, такие как `aria-labelledby`.

## Button toolbar[¶](https://getbootstrap.com/docs/4.3/components/button-group/#button-toolbar)

> Объедините наборы групп кнопок в панели инструментов кнопок для более сложных компонентов.
Используйте классы утилит по мере необходимости, чтобы выделить группы, кнопки и многое другое.

```cshtml

```

***result:***

![Button toolbar](../../../../demo/btn-toolbar-demo.jpg)

> Не стесняйтесь смешивать группы ввода с группами кнопок на панелях инструментов.
Подобно приведенному выше примеру, вам, вероятно,понадобятся некоторые утилиты, чтобы правильно разместить элементы управления.

```cshtml

```

***result:***

![Button toolbar](../../../../demo/btn-toolbar-mixed-demo.jpg)

## Sizing[¶](https://getbootstrap.com/docs/4.3/components/button-group/#sizing)

> Вместо применения классов размеров кнопок к каждой кнопке в группе, просто добавьте **.btn-group-** * каждому **.btn-group**, включая вложеные группы.

```cshtml

```

***result:***

![Button sizing](../../../../demo/btn-group-sizing-demo.jpg)

## Nesting[¶](https://getbootstrap.com/docs/4.3/components/button-group/#nesting)

> Размещение одиного **.btn-group** внутри другого **.btn-group**, для формирования выпадающего меню из другой серии кнопок.

```cshtml

```

***result:***

![Button group nesting](../../../../demo/btn-group-nesting-demo.jpg)

## Vertical variation[¶](https://getbootstrap.com/docs/4.3/components/button-group/#vertical-variation)

> Набор кнопок в вертикальном, а не горизонтальном расположении. Разделители в данном раскрывающемся списке кнопок не поддерживается.

```cshtml

```

***result:***

![Button group vertical variation](../../../../demo/btn-group-vertical-variation-demo.jpg)