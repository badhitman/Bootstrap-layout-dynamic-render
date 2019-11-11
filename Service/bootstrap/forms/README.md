# Forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#overview)

> Классы **Bootstrap** форм расширяют [перегруженые стили](https://getbootstrap.com/docs/4.3/content/reboot/#forms).
Используйте эти классы, для более согласованного отображения в браузерах и устройствах.

> Обязательно используйте соответствующий атрибут **type** во всех `<input>`**s** (например, **email** для адреса электронной почты или **number** для числовой информации), чтобы воспользоваться преимуществами новых элементов управления вводом, таких как проверка электронной почты, выбор номера и многое другое.

```cshtml
@{

}
```

***result:***

![Forms overview](../../../../demo/forms-overview.jpg)

## Form controls[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-controls)

> Текстовые контролы `<input>`**s**, `<select>`**s** и `<textarea>`s — оформлены классом стилей **.form-control**.
В базовое оформление включены стили для общего внешнего вида, состояния фокуса, размеров и многого другого.

```cshtml
@{

}
```

***result:***

![Forms controls](../../../../demo/forms-controls.jpg)

> Для `<inputs />`**s** файлов, вместо **.form-control** применяется **.form-control-file**.

```cshtml
@{

}
```

***result:***

![Forms file controls](../../../../demo/forms-form-file-control.jpg)

## Sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#sizing)

> Установите высоту, используя такие классы, как **.form-control-lg** и **.form-control-sm**.

```cshtml
@{

}
```

***result:***

![Forms controls sizing](../../../../demo/forms-controls-sizing.jpg)

```cshtml
@{

}
```

***result:***

![Forms select controls sizing](../../../../demo/forms-select-controls-sizing.jpg)

## Readonly[¶](https://getbootstrap.com/docs/4.3/components/forms/#readonly)

> Добавьте логический атрибут `readonly` для `<input>`, чтобы предотвратить изменение значения поля формы.
Поля формы **"только для чтения"** выглядят светлее остальных и похоже на **"отключенные"**, но сохраняют стандартный курсор.

```cshtml
@{

}
```

***result:***

![Forms controls readonly](../../../../demo/forms-controls-readonly.jpg)

## Readonly plain text[¶](https://getbootstrap.com/docs/4.3/components/forms/#readonly-plain-text)

> Если вы хотите, чтобы элементы `<input readonly>` в вашей форме были оформлены как обычный текст, используйте класс **.form-control-plaintext** для удаления оформления полей формы по умолчанию и сохранения правильного **margin** и **padding**.

```cshtml
@{

}
```

***result:***

![Forms controls readonly plain text](../../../../demo/forms-controls-readonly-plain-text.jpg)

```cshtml
@{

}
```

***result:***

![Forms inline controls readonly plain text](../../../../demo/forms-inline-controls-readonly-plain-text.jpg)

## Range Inputs[¶](https://getbootstrap.com/docs/4.3/components/forms/#range-inputs)

> Установите горизонтально прокручиваемый "range `<input>`**s**" с помощью **.form-control-range**.

```cshtml
@{

}
```

***result:***

![Forms range inputs](../../../../demo/forms-range-inputs.jpg)

## Checkboxes and radios[¶](https://getbootstrap.com/docs/4.3/components/forms/#checkboxes-and-radios)

> По умолчанию `checkbox`**es** и `radio`**s** усовершенствованны с помощью единого класса стилей **.form-check**, который улучшает макет и поведение их HTML-элементов. `Сheckbox`**es** предназначены для выбора одного или нескольких вариантов в списке, в то время как `radio`**s** предназначены для выбора одного варианта из многих.

> Поддерживаются отключенные `checkbox`**es** и `radio`**s**.
Отключенный **disabled** применяет более светлый цвет елементу, чтобы помочь указать состояние `<input>`’***s**.

> `Checkbox`**es** и `radio`**s** используются для поддержки валидации формы на основе HTML и предоставления кратких, доступных меток.
Таким образом, ваши `<input>`s `<label>`s являются одноуровневыми элементами, а не `<input>` внутри `<label>`.
Это немного более подробно, так как вы должны указать **id** и атрибуты, чтобы связать `<input>` и `<label>`.

## Default (stacked)[¶](https://getbootstrap.com/docs/4.3/components/forms/#default-stacked)

> По умолчанию любое количество `checkbox`**es** и `radio`**s**, которые являются непосредственными дочерними элементами, будут вертикально сложены c соответствующими отступами **.form-check**.

```cshtml
@{

}
```

***result:***

![Forms checkboxes](../../../../demo/forms-checkboxes.jpg)

```cshtml
@{

}
```

***result:***

![Forms radios](../../../../demo/forms-radios.jpg)

## Inline[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline)

> Группируйте `checkbox`**es** и `radio`**s** в одной горизонтальной строке путем добавления **.form-check-inline** в любой **.form-check**.

```cshtml
@{

}
```

***result:***

![Forms inline checkboxes](../../../../demo/forms-inline-checkboxes.jpg)

```cshtml
@{

}
```

***result:***

![Forms inline radios](../../../../demo/forms-inline-radios.jpg)

## Without labels[¶](https://getbootstrap.com/docs/4.3/components/forms/#without-labels)

> 

```cshtml
@{

}
```

***result:***

![Forms without labels](../../../../demo/forms-without-labels.jpg)

## Layout[¶](https://getbootstrap.com/docs/4.3/components/forms/#layout)

> 

## Form groups[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-groups)

> 

```cshtml
@{

}
```

***result:***

![Forms groups](../../../../demo/forms-groups.jpg)

## Form grid[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-grid)

> 

```cshtml
@{

}
```

***result:***

![Forms grid](../../../../demo/forms-grid.jpg)

## Form row[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-row)

> 

```cshtml
@{

}
```

***result:***

![Forms row](../../../../demo/forms-row.jpg)

> Более сложные макеты также могут быть созданы с помощью грид-системы.

```cshtml
@{

}
```

***result:***

![Forms many rows](../../../../demo/forms-many-rows.jpg)

## Horizontal form[¶](https://getbootstrap.com/docs/4.3/components/forms/#horizontal-form)

> 

```cshtml
@{

}
```

***result:***

![Forms many rows](../../../../demo/forms-horizontal.jpg)

###### Horizontal form label sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#horizontal-form-label-sizing)

> 

```cshtml
@{

}
```

***result:***

![Forms horizontal form label sizing](../../../../demo/forms-horizontal-form-label-sizing.jpg)

## Column sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#column-sizing)

> 

```cshtml
@{

}
```

***result:***

![Forms column sizing](../../../../demo/forms-horizontal-form-column-sizing.jpg)

## Auto-sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#auto-sizing)

> 

```cshtml
@{

}
```

***result:***

![Forms auto sizing](../../../../demo/forms-horizontal-form-auto-sizing.jpg)

> Затем вы можете повторить это еще раз с помощью классов столбцов, зависящих от размера.

```cshtml
@{

}
```

***result:***

![Forms auto sizing remix](../../../../demo/forms-horizontal-form-auto-sizing-remix.jpg)

> [Пользовательские элементы управления формы](https://getbootstrap.com/docs/4.3/components/forms/#custom-forms) тоже поддерживаются

```cshtml
@{

}
```

***result:***

![Forms custom inputs](../../../../demo/forms-custom-inputs.jpg)

## Inline forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline-forms)

> 

```cshtml
@{

}
```

***result:***

![Forms inline](../../../../demo/forms-inline.jpg)

> Пользовательские элементы управления формы и `select`**s** тоже поддерживаются.

```cshtml
@{

}
```

***result:***

![Forms inline сustom controls and selects](../../../../demo/forms-inline-сustom-controls-and-selects.jpg)

> Альтернативы скрытым меткам
У вспомогательных технологий, такие как программы чтения с экрана, могут иметь проблемы с вашими формами, если вы не включаете метку для каждого ввода.
Для таких inline форм, вы можете спрятать ярлыки с помощью ".sr-only" класса.
Существуют и другие альтернативные способы предоставления метки для вспомогательных технологий. Например атрибуты **aria-label**, **aria-labelledby** или **title**.
Если ни один из них не присутствует, вспомогательные технологии могут прибегнуть к использованию атрибута **placeholder**, если он присутствует, но обратите внимание, что использование **placeholder** в качестве замены для других методов маркировки не рекомендуется.

## Help text[¶](https://getbootstrap.com/docs/4.3/components/forms/#help-text)

> 

```cshtml
@{

}
```

***result:***

![Forms input help text](../../../../demo/forms-input-help-text.jpg)

> Inline текст может использовать любой типичный Inline HTML-элемент (будь то `<small>`, `<span>` или что-то еще) без какого либо служебного класса.

```cshtml
@{

}
```

***result:***

![Forms inline input help text](../../../../demo/forms-inline-input-help-text.jpg)

## Disabled forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#disabled-forms)

> 

```cshtml
@{

}
```

***result:***

![Disabled forms](../../../../demo/disabled-forms.jpg)

## Validation forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#validation)

> 

## How it works[¶](https://getbootstrap.com/docs/4.3/components/forms/#how-it-works)

> 

## Custom styles[¶](https://getbootstrap.com/docs/4.3/components/forms/#custom-styles)

> 

```cshtml
@{

}
```

***result:***

![Validation forms](../../../../demo/validation-forms-custom-styles.jpg)

## Browser defaults[¶](https://getbootstrap.com/docs/4.3/components/forms/#browser-defaults)

> 

```cshtml
@{

}
```

***result:***

![Validation forms browser defaults](../../../../demo/validation-forms-browser-defaults.jpg)

## Server side[¶](https://getbootstrap.com/docs/4.3/components/forms/#server-side)

> 

```cshtml
@{

}
```

***result:***

![Validation forms server side](../../../../demo/validation-forms-server-side.jpg)

## Supported elements[¶](https://getbootstrap.com/docs/4.3/components/forms/#supported-elements)

> 

```cshtml
@{

}
```

***result:***

![Validation forms supported elements](../../../../demo/validation-forms-supported-elements.jpg)

## Tooltips[¶](https://getbootstrap.com/docs/4.3/components/forms/#tooltips)

> 

```cshtml
@{

}
```

***result:***

![Validation forms tooltips](../../../../demo/validation-forms-tooltips.jpg)

## Customizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#customizing)

> 

```cshtml
@{

}
```

***result:***

![Validation forms customizing](../../../../demo/validation-forms-customizing.jpg)

## Custom forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#custom-forms)

> 

## Checkboxes and radios[¶](https://getbootstrap.com/docs/4.3/components/forms/#checkboxes-and-radios-1)

> 

## Checkboxes[¶](https://getbootstrap.com/docs/4.3/components/forms/#checkboxes)

```cshtml
@{

}
```

***result:***

![Custom forms checkboxes](../../../../demo/custom-forms-checkboxes.jpg)

> Пользовательские `checkbox`**es** также могут использовать псевдокласс: **indeterminate** при ручной установке с помощью JavaScript (для этого в HTML нет доступного атрибута).

```cshtml
@{

}
```

***result:***

![Custom forms checkboxes indeterminate](../../../../demo/custom-forms-checkboxes-indeterminate.jpg)

> Если вы используете jQuery,то должно быть достаточно что-то вроде этого:

```js
@{
  $('.your-checkbox').prop('indeterminate', true);
}
```

## Radios[¶](https://getbootstrap.com/docs/4.3/components/forms/#radios)

```cshtml
@{

}
```

***result:***

![Custom forms radios](../../../../demo/custom-forms-radios.jpg)

## Inline[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline-1)

```cshtml
@{

}
```

***result:***

![Custom forms radios inline](../../../../demo/custom-forms-radios-inline.jpg)

## Disabled[¶](https://getbootstrap.com/docs/4.3/components/forms/#disabled)

> 

```cshtml
@{

}
```

***result:***

![Custom forms disabled](../../../../demo/custom-forms-disabled.jpg)

## Switches[¶](https://getbootstrap.com/docs/4.3/components/forms/#switches)

> 

```cshtml
@{

}
```

***result:***

![Custom forms switches](../../../../demo/custom-forms-switches.jpg)

## Select menu[¶](https://getbootstrap.com/docs/4.3/components/forms/#select-menu)

> 

```cshtml
@{

}
```

***result:***

![Custom forms select menu](../../../../demo/custom-forms-select-menu.jpg)

> Вы также можете установить размер пользовательских `<selects>`**s**, чтобы соответствовать текстовым `<inputs>` аналогичного размера.

```cshtml
@{

}
```

***result:***

![Custom forms select menu size](../../../../demo/custom-forms-select-menu-size.jpg)

> Множественный выбор также поддерживается:

```cshtml
@{

}
```

***result:***

![Custom forms select menu multiple attribute](../../../../demo/custom-forms-select-menu-multiple-attribute.jpg)

> Как и атрибут размера:

```cshtml
@{

}
```

***result:***

![Custom forms select menu size attribute](../../../../demo/custom-forms-select-menu-size-attribute.jpg)

## Range[¶](https://getbootstrap.com/docs/4.3/components/forms/#range)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range](../../../../demo/custom-forms-range.jpg)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range max](../../../../demo/custom-forms-range-max.jpg)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range step](../../../../demo/custom-forms-range-step.jpg)

## File browser[¶](https://getbootstrap.com/docs/4.3/components/forms/#file-browser)

> 

```cshtml
@{

}
```

***result:***

![Custom forms file browser](../../../../demo/custom-forms-file-browser.jpg)