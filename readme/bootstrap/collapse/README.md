# Collapse[¶](https://getbootstrap.com/docs/4.3/components/collapse/)

> Сокрытие или отображение контента в вашем проекте с помощью нескольких классов и наших плагинов JavaScript.

## How it works[¶](https://getbootstrap.com/docs/4.3/components/collapse/#how-it-works)

> Плагин collapse JavaScript используется для отображения и скрытия содержимого.
Кнопки или якоря используются в качестве триггеров, которые сопоставляются с определенными элементами, которые вы переключаете.
Сворачивание элемента приведет к анимации высоты от ее текущего значения до 0.
Учитывая, как CSS обрабатывает анимации, вы не можете использовать заполнение **.collapse** элемента.
Вместо этого используйте класс как независимый элемент обертывания.

## Example[¶](https://getbootstrap.com/docs/4.3/components/collapse/#example)

> Нажатие на кнопки ниже, отображают и/или скрывают другой элемент с помощью изменений класса:

- `.collapse` - скрытие контента
- `.collapsing` - применяется во время переходов
- `.collapse.show` - отображение контента


> Можно использовать ссылку с атрибутом `href` или кнопку с атрибутом `data-target`. В обоих случаях требуется `data-toggle="collapse"`.

```cshtml
@{

}
```

***result:***

![Collapse example demo](../../demo/collapse-example-demo.jpg)

## Multiple targets[¶](https://getbootstrap.com/docs/4.3/components/collapse/#multiple-targets)

> `<button>` или `<a>` могут отображать и скрывать несколько элементов, ссылаясь на них с помощью селектора **JQuery** в атрибуте `href` или `data-target`.
Несколько `<button>` или `<a>` могут показывать и скрывать элемент, если каждый из них ссылается на него со своим атрибутом `href` или `data-target`

```cshtml
@{

}
```

***result:***

![Collapse multiple targets demo](../../demo/collapse-multiple-targets-demo.jpg)

## Accordion example[¶](https://getbootstrap.com/docs/4.3/components/collapse/#accordion-example)

> С помощью компонента **card** можно расширить поведение сворачивания по умолчанию для создания аккордеона.
Чтобы правильно достичь стиля аккордеона, обязательно используйте **.accordion** как обертку.

```cshtml
@{

}
```

***result:***

![Collapse accordion example demo](../../demo/collapse-accordion-example-demo.jpg)
