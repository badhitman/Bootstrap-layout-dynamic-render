# Carousel[¶](https://getbootstrap.com/docs/4.3/components/carousel/)

> Компонент слайд-шоу для циклического перемещения по элементам-изображениям или слайдам текста-как карусель.

> Карусель представляет собой слайд-шоу серии контента по кругу, построенного с помощью CSS 3D-преобразований и немного JavaScript. Он работает с серией изображений, текстом или пользовательской разметкой. Он также включает поддержку предыдущих/следующих элементов управления и индикаторов.

> В браузерах, где поддерживается [API видимости страницы](https://www.w3.org/TR/page-visibility/), карусель будет избегать скольжения, когда веб-страница не видна пользователю (например, когда вкладка браузера неактивна, окно браузера свернуто и т. д.).

> Анимационный эффект в этом компоненте зависит от **prefers-reduced-motion** мультимедиа запроса. 
См. раздел документации по доступности [reduced motion](https://getbootstrap.com/docs/4.3/getting-started/accessibility/#reduced-motion).

> Обратите внимание, что вложенные карусели не поддерживаются и, как правило, не соответствуют стандартам доступности.
Наконец, если вы создаете свой JavaScript из исходного кода, [потребуется util.JS](https://getbootstrap.com/docs/4.3/getting-started/javascript/#util).

## Example[¶](https://getbootstrap.com/docs/4.3/components/carousel/#example)

> Карусели не нормализуют размеры слайдов.
Таким образом, вам может потребоваться использовать дополнительные утилиты или пользовательские стили для соответствующего размера содержимого.
Не смотря на то, что карусели поддерживают **предыдущие**/**следующие** элементы управления и **индикаторы**, они явно не требуются. Добавте и настрйте их, как вы считаете нужным.

> Класс **.active** должен быть добавлен к одному из слайдов, иначе карусель не будет видна.
Также не забудьте установить уникальный идентификатор **.carousel** для улучшеной управляемости элементом, особенно если вы используете несколько каруселей на одной странице.
Элементы управления и индикаторы должны иметь атрибут **data-target** (или href для ссылок), соответствующий идентификатору элемента **.carousel**.

## Slides only[¶](https://getbootstrap.com/docs/4.3/components/carousel/#slides-only)

> Вот карусель только со слайдами без дополнительных элементов управления/индикации.
Обратите внимание на наличие **.d-block** и **.w-100** на изображениях карусели, чтобы предотвратить выравнивание браузером изображения по умолчанию.

```cshtml
@{

}
```

***result:***

![Carousel example demo](../../../../demo/carousel-example-demo.jpg)

## With controls[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-controls)

> 

```cshtml
@{

}
```

***result:***

![Carousel with controls demo](../../../../demo/carousel-with-controls-demo.jpg)

## With indicators[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-indicators)

> 

```cshtml
@{

}
```

***result:***

![Carousel with indicators demo](../../../../demo/carousel-with-indicators-demo.jpg)

## With captions[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-captions)

> 

```cshtml
@{

}
```

***result:***

![Carousel with captions demo](../../../../demo/carousel-with-captions-demo.jpg)

## Crossfade[¶](https://getbootstrap.com/docs/4.3/components/carousel/#crossfade)

> 

```cshtml
@{

}
```

***result:***

![Carousel crossfade demo](../../../../demo/carousel-crossfade-demo.jpg)

## Individual .carousel-item interval[¶](https://getbootstrap.com/docs/4.3/components/carousel/#individual-carousel-item-interval)

> 

```cshtml
@{

}
```

***result:***

![Carousel individual carousel item interval demo](../../../../demo/carousel-ndividual-carousel-item-interval-demo.jpg)