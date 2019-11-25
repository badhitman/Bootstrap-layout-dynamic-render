# Dropdowns[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/)

> Переключение контекстных наложений для отображения списков ссылок и многого другого с помощью плагина **Bootstrap dropdown**.

## Overview[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#overview)

> Выпадающие списки-это переключаемые, контекстные оверлеи для отображения списков ссылок и многого другого.
Интерактивными они становятся благодаря включению **JavaScript** плагина **Bootstrap dropdown**.
Они переключаются щелчком, а не наведением курсора; [это преднамеренное дизайнерское решение](http://markdotto.com/2012/02/27/bootstrap-explained-dropdowns/).

> Выпадающие списки построены на базе сторонней библиотеки, [Popper.js](https://popper.js.org/), который обеспечивает динамическое позиционирование и обнаружение видового экрана.
Обязательно включите [popper.min.js](https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js) перед загрузкой **JavaScript** или используйте bootstrap.bundle.min.js/bootstrap.bundle.js, который содержит Popper.js.
Popper.js не используется для размещения выпадающих списков в **навигационных панелях**, хотя динамическое позиционирование не требуется.

> Если вы создаете свой **JavaScript** из исходного кода, тогда вам потребуется [util.js](https://getbootstrap.com/docs/4.3/getting-started/javascript/#util).

## Accessibility[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#accessibility)

> Стандарт [WAI ARIA](https://www.w3.org/TR/wai-aria/) определяет фактический виджет [role="menu"](https://www.w3.org/WAI/PF/aria/roles#menu), но это специфично для меню, подобных приложениям, которые запускают действия или функции.
Меню ARIA могут содержать только **пункты меню**, **checkbox**, **radio**, группы переключателей **radio** и **подменю**.

> С другой стороны, раскрывающиеся списки Bootstrap предназначены для общего использования и применимы к различным ситуациям и структурам разметки.
Например, можно создать раскрывающиеся списки, содержащие дополнительные входные данные и элементы управления формами, такие как поля поиска или формы входа.
По этой причине Bootstrap не ожидает (и не добавляет автоматически) каких - либо **ролей** и атрибутов **aria-**, необходимых для валидного меню **ARIA**.
Разработчикам должно будет включать эти более конкретные атрибуты самостоятельно на своё усмотрение.

> Тем не менее, **Bootstrap** добавляет встроенную поддержку для большинства стандартных взаимодействий меню клавиатуры, таких как возможность перемещения по отдельным элементам **.dropdown-item** и закрытие меню с помощью клавиши `ESC`.

## Examples[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#examples)

> Оберните переключатель выпадающего списка (вашу кнопку или ссылку) и выпадающее меню внутри **.dropdown** или другой элемент, объявляющий `position: relative;`.
Выпадающие списки могут быть вызваны из элементов `<a>` или `<button>`, чтобы лучше соответствовать вашим потенциальным потребностям.

## Single button[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#single-button)

> Любой обычный **.btn** можно превратить в переключатель выпадающего списка, добавив некоторые изменения разметки.
Вот как вы можете заставить их работать с любыми элементами `<button>`:

```cshtml
@{

}
```

***result:***

![Dropdowns single button](../demo/dropdowns-single-button.jpg)

> и при помощи `<a>` элементов:

```cshtml
@{

}
```

***result:***

![Dropdowns single button <a> elements](../demo/dropdowns-single-button-with-a.jpg)

> Самое приятное, что вы можете сделать тоже самое с любым вариантом кнопки

```cshtml
@{

}
```

![Dropdowns single button variant](../demo/dropdowns-single-button-variant.jpg)

## Split button[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#split-button)

> Аналогично, создайте раскрывающиеся списки с разделенными кнопками с практически той же разметкой, что и раскрывающиеся списки с одной кнопкой, добавив только **.dropdown-toggle-split** для правильного интервала вокруг курсора.

> Этот дополнительный класс используется, чтобы уменьшить горизонтальный `padding` по обе стороны от курсора на 25% и удалить `margin-left`, добавленный для обычных выпадающих кнопок.
Эти дополнительные изменения сохраняют курсор в центре отдельной кнопки и обеспечивают более подходящий размер кликабельной области рядом с основной кнопкой.

```cshtml
@{

}
```

![Dropdowns split button](../demo/dropdowns-split-button.jpg)

## Sizing[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#sizing)

> Выпадающие списки кнопок работают с кнопками всех размеров, включая кнопки по умолчанию и **split dropdown**.

```cshtml
@{

}
```

![Dropdowns sizing](../demo/dropdowns-sizing.jpg)

## Directions[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#directions)

## Dropup[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#dropup)

> Вызов выпадающего меню над родительским элементом путем добавления **.dropup** для такого родительского элемента.

```cshtml
@{

}
```

![Dropdowns dropup](../demo/dropdowns-dropup.jpg)

## Dropright[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#dropright)

> Вызов выпадающего меню справа от родительского элемента путем добавления **.dropright** для такого родительского элемента.

```cshtml
@{

}
```

![Dropdowns dropright](../demo/dropdowns-dropright.jpg)

## Dropleft[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#dropleft)

> Вызов выпадающего меню слева от родительского элемента путем добавления **.dropleft** для такого родительского элемента.

```cshtml
@{

}
```

![Dropdowns dropleft](../demo/dropdowns-dropleft.jpg)

## Menu items[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#menu-items)

> Исторически сложилось так, что содержимое выпадающего меню должно было быть ссылками, но это больше не относится к v4.
Теперь вы можете дополнительно использовать элементы `<button>` в раскрывающихся списках вместо `<a>`**s**.

```cshtml
@{

}
```

![Dropdowns menu items](../demo/dropdowns-menu-items.jpg)

> Вы также можете создавать неинтерактивные элементы **.dropdown-item-text** в выпадающиющем списке.
Не стесняйтесь стилизовать дальше с помощью пользовательских CSS или текстовых утилит.

```cshtml
@{

}
```

![Dropdowns non-interactive items](../demo/dropdowns-non-interactive-items.jpg)

## Active[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#active)

> Добавление **.active** к элементам выпадающего списка, что бы **стилизовать их внешний как активный**.

```cshtml
@{

}
```

![Dropdowns active items](../demo/dropdowns-active-items.jpg)

## Disabled[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#disabled)

> Добавление **.disabled** к элементам выпадающего списка, что бы **стилизовать их внешний как отключённый**.

```cshtml
@{

}
```

![Dropdowns active items](../demo/dropdowns-disabled-items.jpg)

## Menu alignment[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#menu-alignment)

> По умолчанию выпадаюшее меню выравнивается по левому краю родительской кнопки.
Другими словами: для привязки позиционирования выпадающего меню берётся левый нижний угол родительской кнопки, а выпадающий список привязывается к опорной родительской точке своим левым верхним углом и отрисовывается вправо вдоль кнопки на необходимую ширину.

> Добавив **dropdown-menu-right** в **.dropdown-menu** выравнивание выпадающего меню будет производиться по правому краю.
Другими словами: для привязки позиционирования выпадающего меню берётся правый нижний угол родительской кнопки, а выпадающий список привязывается к опорной родительской точке своим правым верхним углом и отрисовывается влево вдоль кнопки на необходимую ширину.

> Выпадающий список позиционируется благодаря Popper.js (за исключением случаев, когда они содержатся в навигационной панели).

```cshtml
@{

}
```

![Dropdowns menu alignment](../demo/dropdowns-menu-alignment.jpg)

## Responsive alignment[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#responsive-alignment)

> Если вы хотите использовать адаптивное выравнивание, отключите динамическое позиционирование, добавив атрибут `data-display="static"` и используйте классы адаптивных вариантов.

```cshtml
@{

}
```

![Dropdowns menu responsive alignment](../demo/dropdowns-menu-responsive-alignment.jpg)

> Чтобы выровнять выпадающее меню слева, используются **.dropdown-menu-right** и **.dropdown-menu{-sm|-md|-lg|-xl}-left**.

```cshtml
@{

}
```

> Обратите внимание, что вам не нужно добавлять атрибут `data-display="static"` к кнопкам выпадающего меню в `navbar`, так как **Popper.js** не используется в **navbars**.

![Dropdowns menu right alignment](../demo/dropdowns-menu-right-alignment.jpg)

## Menu content[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#menu-content)

## Headers[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#headers)

> Добавьте заголовок для обозначения разделов действий в любом раскрывающемся меню.

```cshtml
@{

}
```

![Dropdowns menu headers](../demo/dropdowns-menu-headers.jpg)

## Dividers[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#dividers)

> Разделите группы связанных пунктов меню.

```cshtml
@{

}
```

![Dropdowns menu dividers](../demo/dropdowns-menu-dividers.jpg)

## Text[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#text)

> Поместите любой произвольный текст в выпадающее меню, используя утилиты интервалов.
Обратите внимание, что вам, вероятно, понадобятся дополнительные стили размеров, чтобы ограничить ширину меню.

```cshtml
@{

}
```

![Dropdowns menu text](../demo/dropdowns-menu-text.jpg)

## Forms[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#forms)

> Поместите форму в раскрывающееся меню или превратите ее в раскрывающееся меню и используйте [утилиты margin или padding](https://getbootstrap.com/docs/4.3/utilities/spacing/), чтобы предоставить ей необходимое отрицательное пространство.

```cshtml
@{

}
```

![Dropdowns menu forms](../demo/dropdowns-menu-forms.jpg)

> 

```cshtml
@{

}
```

![Dropdowns menu min forms](../demo/dropdowns-menu-min-forms.jpg)

## Dropdown options[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/#dropdown-options)

> Используйте **data-offset** или **data-reference** что бы изменить расположение выпадающего списка.

```cshtml
@{

}
```

![Dropdowns options](../demo/dropdowns-options.jpg)
