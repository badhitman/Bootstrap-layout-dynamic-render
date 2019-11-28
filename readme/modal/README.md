# Modal[¶](https://getbootstrap.com/docs/4.3/components/modal/)

> Используйте Bootstrap JavaScript **modal** плагин для добавления диалоговых окон на ваш сайт для лайтбоксов, уведомлений пользователей или полностью пользовательского контента.

> Прежде чем начать работу с компонентом **modal** Bootstrap, обязательно прочитайте следующее:

- Модальные объекты строятся с использованием **HTML**, **CSS** и **JavaScript**. Они расположены поверх всего остального в документе и отключают прокрутку `<body>`, чтобы вместо этого прокручивалось модальное содержимое.
- Кликните мышкой за границами модального объекта и модальный объект автоматически закроется.
- Bootstrap поддерживает только одно модальное окно за раз. Вложенные модальные объекты не поддерживаются.
- Модальные объекты используют `position: fixed;`, в связи с чем рендеринг иногда может иметь некоторые особенности. По возможности разместите свой модальный HTML-код на верхнем уровне, чтобы избежать возможных помех со стороны других элементов. Вы, вероятно, столкнетесь с проблемами при вложении **.modal** внутри другого `position: fixed;` элемента.
- Из-за `position: fixed;`, есть некоторые нюансы с использованием модальных объектов на мобильных устройствах. Дополнительную информацию см. [В документации по поддержке браузера](https://getbootstrap.com/docs/4.3/getting-started/browsers-devices/#modals-and-dropdowns-on-mobile).
- Из-за определённой семантики HTML5, [HTML атрибут **autofocus**](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-autofocus) не имеет никакого эффекта в модальных объектах Bootstrap. Чтобы достичь того же эффекта, используйте некоторые пользовательские JavaScript:

```javascript
$('#myModal').on('shown.bs.modal', function () {
  $('#myInput').trigger('focus')
})
```

> Анимационный эффект этого компонента зависит от **prefers-reduced-motion media query**.
См. [раздел в документации](https://getbootstrap.com/docs/4.3/getting-started/accessibility/#reduced-motion).

## Modal components[¶](https://getbootstrap.com/docs/4.3/components/modal/#modal-components)

> Ниже приведен статический пример модального объекта (это означает, что его позиция и отображение были переопределены).
Включены заголовок, тело (требуется для заполнения контентом) и нижний колонтитул (необязательно).
В заголовке модального окна есть кнопка деактивации.

```cshtml
@{
  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "Modal title" };

  // <!-- Button trigger modal -->
  bsButton button = bsModal.GetDefaultButtonTriggerModal(modal.ID);
  @await Component.InvokeAsync(button.ViewComponentName, new { SetObjectManager = button })

  modal.FooterExtButtons.Add(bsModal.GetDefaultButtonDismissFooter());
  modal.FooterExtButtons.Add(new bsButton("Save changes") { BackgroundColorTheme = bmBackgroundColorThemesEnum.primary });
  hsP paragraf = new hsP("Modal body text goes here.");
  modal.AddChild(paragraf);
  @await Component.InvokeAsync(modal.ViewComponentName, new { SetObjectManager = modal })
}
```

***result:***

![Modal demo](../demo/modal-demo.jpg)

```html
<div id="modal-dom-id" role="dialog" class="modal fade show" aria-labelledby="modal-dom-id-ModalLabel" style="display: block;" aria-modal="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="modal-dom-id-ModalLabel">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">×</span>
        </button>
      </div>
      <div class="modal-body">
        <p>Modal body text goes here.</p>
      </div>
      <div class="modal-footer">
        <button data-dismiss="modal" type="button" class="btn btn-secondary">Cancel</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
```

## Scrolling long content[¶](https://getbootstrap.com/docs/4.3/components/modal/#scrolling-long-content)

> Когда модальное окно становятся слишком длинными для экрана устройства пользователя, оно прокручиваются целиком и независимо от самой страницы.

```cshtml
@{
  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "Modal title", IsModalDialogScrollable = false };
}
```

***result:*** верхнее положение прокрутки

![Modal scrolling long content body demo](../demo/modal-scrollable-win-demo.jpg)

***result:*** нижнее положение прокрутки

![Modal scrolling long content body demo](../demo/modal-scrollable-win-demo-2.jpg)

> Вы можете создать прокручиваемое модальное окно, которое позволяет прокручивать непосредственно модальное тело, добавив **.modal-dialog-scrollable** в **.modal-dialog**.

```cshtml
@{
  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "Modal title", IsModalDialogScrollable = true };
}
```

***result:***

![Modal scrolling long content body demo](../demo/modal-scrollable-modal-body-demo.jpg)

## Vertically centered[¶](https://getbootstrap.com/docs/4.3/components/modal/#vertically-centered)

> Добавьте **.modal-dialog-centtered** в **.modal-dialog**, чтобы вертикально центрировать модальное окно.

```cshtml
@{
  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "Modal title", IsVerticallyСentered = true };
}
```

***result:***

![Modal vertically centered demo](../demo/modal-vertically-centered-demo.jpg)

## Tooltips and popovers[¶](https://getbootstrap.com/docs/4.3/components/modal/#tooltips-and-popovers)

> При необходимости в модальных окнах могут быть размещены всплывающие подсказки и всплывающие окна.
Когда модальные окна закрыты, любые всплывающие подсказки и всплывающие окна также автоматически удаляются.

## Using the grid[¶](https://getbootstrap.com/docs/4.3/components/modal/#using-the-grid)

> Используйте сеточную систему Bootstrap в теле модального окна, вложив **.container-liquid** в **.modal-body**.
Затем используйте обычные классы системы сетки, как обычно.

```cshtml
@{
  hsDiv simple_fluid_div = new hsDiv().AddCSS("container-fluid") as hsDiv;
  ////////////////////////////////////////
  //
  hsDiv simple_row_div = new hsDiv().AddCSS("row") as hsDiv;
  hsDiv simple_col_div = new hsDiv().AddCSS("col-md-4") as hsDiv;
  simple_col_div.AddChild(new hsRaw(".col-md-4"));
  simple_row_div.AddChild(simple_col_div);
  //
  simple_col_div = new hsDiv().AddCSS("col-md-4 ml-auto") as hsDiv;
  simple_col_div.AddChild(new hsRaw(".col-md-4 .ml-auto"));
  simple_row_div.AddChild(simple_col_div);
  //
  simple_fluid_div.AddChild(simple_row_div);
  //
  ////////////////////////////////////////

  ////////////////////////////////////////
  //
  simple_row_div = new hsDiv().AddCSS("row") as hsDiv;
  simple_col_div = new hsDiv().AddCSS("col-md-3 ml-auto") as hsDiv;
  simple_col_div.AddChild(new hsRaw(".col-md-3 .ml-auto"));
  simple_row_div.AddChild(simple_col_div);
  //
  simple_col_div = new hsDiv().AddCSS("col-md-2 ml-auto") as hsDiv;
  simple_col_div.AddChild(new hsRaw(".col-md-2 .ml-auto"));
  simple_row_div.AddChild(simple_col_div);
  //
  simple_fluid_div.AddChild(simple_row_div);
  //
  ////////////////////////////////////////

  ////////////////////////////////////////
  //
  simple_row_div = new hsDiv().AddCSS("row") as hsDiv;
  simple_col_div = new hsDiv().AddCSS("col-md-6 ml-auto") as hsDiv;
  simple_col_div.AddChild(new hsRaw(".col-md-6 .ml-auto"));
  simple_row_div.AddChild(simple_col_div);
  //
  simple_fluid_div.AddChild(simple_row_div);
  //
  ////////////////////////////////////////

  ////////////////////////////////////////
  //
  simple_row_div = new hsDiv().AddCSS("row") as hsDiv;
  simple_col_div = new hsDiv().AddCSS("col-sm-9") as hsDiv;
  simple_col_div.AddChild(new hsRaw("Level 1: .col-sm-9"));

  hsDiv simple_sub_row_div = new hsDiv().AddCSS("row") as hsDiv;
  hsDiv simple_sub_col_div = new hsDiv().AddCSS("col-8 col-sm-6") as hsDiv;
  simple_sub_col_div.AddChild(new hsRaw("Level 2: .col-8 .col-sm-6"));
  simple_sub_row_div.AddChild(simple_sub_col_div);
  //
  simple_sub_col_div = new hsDiv().AddCSS("col-8 col-sm-6") as hsDiv;
  simple_sub_col_div.AddChild(new hsRaw("Level 2: .col-4 .col-sm-6"));
  simple_sub_row_div.AddChild(simple_sub_col_div);
  simple_col_div.AddChild(simple_sub_row_div);

  simple_row_div.AddChild(simple_col_div);
  //
  simple_fluid_div.AddChild(simple_row_div);
  //
  ////////////////////////////////////////

  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "Modal title", IsVerticallyСentered = true };
  modal.FooterExtButtons.Add(bsModal.GetDefaultButtonDismissFooter());
  modal.FooterExtButtons.Add(new bsButton("Save changes") { BackgroundColorTheme = bmBackgroundColorThemesEnum.primary });
  // <!-- Button trigger modal -->
  bsButton button = bsModal.GetDefaultButtonTriggerModal(modal.ID);
  @await Component.InvokeAsync(button.ViewComponentName, new { SetObjectManager = button })

  modal.AddChild(simple_fluid_div);
  @await Component.InvokeAsync(modal.ViewComponentName, new { SetObjectManager = modal })
}
```

***result:***

![Modal vertically centered demo](../demo/modal-grid-demo.jpg)

## Varying modal content[¶](https://getbootstrap.com/docs/4.3/components/modal/#varying-modal-content)

> У вас есть несколько кнопок, которые должны запускать одно и тот же модальное окно со слегка отличающимся содержимым?
Используйте атрибуты **event.relatedTarget** и HTML `data-*` (возможно, через jQuery), чтобы варьировать содержимое модального окна в зависимости от того, какая кнопка была нажата.

```cshtml
@{
  bsModal modal = new bsModal() { ID = "modal-dom-id", Header = "New message", IsVerticallyСentered = true };
  modal.FooterExtButtons.Add(bsModal.GetDefaultButtonDismissFooter());
  modal.FooterExtButtons.Add(new bsButton("Save changes") { BackgroundColorTheme = bmBackgroundColorThemesEnum.primary });

  bsButton button = bsModal.GetDefaultButtonTriggerModal(modal.ID, "Open modal for @mdo", bmBackgroundColorThemesEnum.primary).SetAttribute("data-whatever", "@mdo") as bsButton;
  @await Component.InvokeAsync(button.ViewComponentName, new { SetObjectManager = button })
  //
  button = bsModal.GetDefaultButtonTriggerModal(modal.ID, "Open modal for @fat", bmBackgroundColorThemesEnum.primary).SetAttribute("data-whatever", "@fat") as bsButton;
  @await Component.InvokeAsync(button.ViewComponentName, new { SetObjectManager = button })
  //
  button = bsModal.GetDefaultButtonTriggerModal(modal.ID, "Open modal for @getbootstrap", bmBackgroundColorThemesEnum.primary).SetAttribute("data-whatever", "@getbootstrap") as bsButton;
  @await Component.InvokeAsync(button.ViewComponentName, new { SetObjectManager = button })

  bsForm form = new bsForm() { ID = "demo-form-dom-id" };

  bsFormGroupSingle SingleGroup = new bsFormGroupSingle();
  SingleGroup.CustomInput.Label = "Recipient:";
  SingleGroup.CustomInput.Input = new hsInputText() { ID = "recipient-name" };
  form.AddChild(SingleGroup);

  SingleGroup = new bsFormGroupSingle();
  SingleGroup.CustomInput.Label = "Message:";
  SingleGroup.CustomInput.Input = new hsTextarea() { ID = "message-text", Placeholder = "Enter text message:", SizeArea = 3 };
  form.AddChild(SingleGroup);

  modal.AddChild(form);
  @await Component.InvokeAsync(modal.ViewComponentName, new { SetObjectManager = modal })
}
```

```js
$('#modal-dom-id').on('show.bs.modal', function (event) {
  var button = $(event.relatedTarget) // Button that triggered the modal
  var recipient = button.data('whatever') // Extract info from data-* attributes
  // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
  // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
  var modal = $(this)
  modal.find('.modal-title').text('New message to ' + recipient)
  modal.find('.modal-body input').val(recipient)
})
```

***result:***

![Modal varying content demo](../demo/modal-varying-content-demo.jpg)

## Optional sizes[¶](https://getbootstrap.com/docs/4.3/components/modal/#optional-sizes)

> Модальные окна опционально имеют три размера, доступные через классы модификаторов для размещения в диалоге **.modal**.
Эти размеры входят в определенные точки останова, чтобы избежать горизонтальных полос прокрутки на более узких окнах просмотра.

- _Small_ **.modal-sm** - 300px
- _Default_ None - 500px
- _Large_ **.modal-lg** - 800px
- _Extra large_ **.modal-xl** - 1140px

> Модальное окно по умолчанию (без класса модификаторов) составляет «средний» размер.

```cshtml
@{

}
```