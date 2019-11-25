# Carousel[¶](https://getbootstrap.com/docs/4.3/components/carousel/)

> Компонент слайд-шоу для циклического перемещения по элементам-изображениям или слайдам текста-как карусель.

> Карусель представляет собой слайд-шоу серии контента по кругу, построенного с помощью CSS 3D-преобразований и немного JavaScript.
Он работает с серией изображений, текстом или пользовательской разметкой.
Он также включает поддержку элементов управления для переключения слайда **< "назад"** и **"вперёд" >**, а также индикации.

> В браузерах, где поддерживается [API видимости страницы](https://www.w3.org/TR/page-visibility/), карусель будет избегать скольжения, когда веб-страница не видна пользователю (например, когда вкладка браузера неактивна, окно браузера свернуто и т. д.).

> Анимационный эффект в этом компоненте зависит от мультимедиа запроса **prefers-reduced-motion**. 
См. раздел документации по доступности [reduced motion](https://getbootstrap.com/docs/4.3/getting-started/accessibility/#reduced-motion).

> Обратите внимание, что вложенные карусели не поддерживаются и, как правило, не соответствуют стандартам доступности.
Наконец, если вы создаете свой JavaScript из исходного кода, [потребуется util.JS](https://getbootstrap.com/docs/4.3/getting-started/javascript/#util).

> Карусели не нормализуют размеры слайдов.
Таким образом, вам может потребоваться использовать дополнительные утилиты или пользовательские стили для соответствующего размера содержимого.
Не смотря на то, что карусели поддерживают элементы управления для переключения слайда **< "назад"** и **"вперёд" >** и **индикации**, они явно не требуются.
Добавляйте и настраивайте их, по мере необходимости.

> Класс **.active** должен быть добавлен к одному из слайдов, иначе карусель не будет видна.
Также не забудьте установить уникальный идентификатор к **.carousel** для улучшеной управляемости элементом, особенно если вы используете несколько каруселей на одной странице.
Элементы управления и индикаторы должны иметь атрибут **data-target** (или **href** для ссылок), соответствующий идентификатору элемента **.carousel**.

## Slides only[¶](https://getbootstrap.com/docs/4.3/components/carousel/#slides-only)

> Ниже представлена карусель только со слайдами без дополнительных элементов управления или индикации.
Обратите внимание на наличие **.d-block** и **.w-100** на изображениях карусели, чтобы предотвратить выравнивание браузером изображения по умолчанию.

```cshtml
@{

}
```

***result:***

![Carousel example demo](../demo/carousel-example-demo.jpg)

## With controls[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-controls)

> Добавление элементов управления для переключения слайда **< "назад"** и **"вперёд" >**:

```cshtml
@{

}
```

***result:***

![Carousel with controls demo](../demo/carousel-with-controls-demo.jpg)

## With indicators[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-indicators)

> Наряду с элементами управления для карусели доступны также **индикация**.

```cshtml
@{

}
```

***result:***

![Carousel with indicators demo](../demo/carousel-with-indicators-demo.jpg)

## With captions[¶](https://getbootstrap.com/docs/4.3/components/carousel/#with-captions)

> Лёгкое добавление подписи к слайдам с помощью элемента **.carousel-caption** внутри любого **.carousel-item**.
Они могут быть легко скрыты на небольших видовых экранах, как показано ниже, с помощью дополнительных утилит отображения.
Мы скрываем их изначально с **.d-none** и возвращаем их на средних устройствах **.d-md-block**.

```cshtml
@{

}
```

***result:***

![Carousel with captions demo](../demo/carousel-with-captions-demo.jpg)

## Crossfade[¶](https://getbootstrap.com/docs/4.3/components/carousel/#crossfade)

> Добавление к карусели класса **.carousel-fade** обеспечит анимацию **"плавного перехода"** между слайдами вместо скольжения.

```cshtml
@{

}
```

***result:***

![Carousel crossfade demo](../demo/carousel-crossfade-demo.jpg)

## Individual .carousel-item interval[¶](https://getbootstrap.com/docs/4.3/components/carousel/#individual-carousel-item-interval)

> Добавьте `data-interval=""` к **.carousel-item** для изменения времени задержки между автоматическим циклическим переходом к следующему элементу.

```cshtml
@{

}
```

***result:***

![Carousel individual carousel item interval demo](../demo/carousel-ndividual-carousel-item-interval-demo.jpg)
