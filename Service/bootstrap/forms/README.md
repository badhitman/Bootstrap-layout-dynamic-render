# Forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#overview)

> Классы **Bootstrap** форм расширяют [перегруженые стили "по умолчанию"](https://getbootstrap.com/docs/4.3/content/reboot/#forms).
Используйте эти классы, для более согласованного отображения в браузерах и устройствах.

> Обязательно используйте соответствующий атрибут **type** во всех `<input>`**s** (например, **email** для адреса электронной почты или **number** для числовой информации), чтобы воспользоваться преимуществами новых элементов управления вводом, таких как проверка электронной почты, выбор номера и многое другое.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager(){ ID = "domo-form-dom-id"};

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Email address";
  SingleGroup.CustomInput.Input = new InputEmailManager()
  {
    Placeholder = "Enter email",
    ID = "input-email-dom-id"
  };
  SingleGroup.CustomInput.HelpCaption = "We'll never share your email with anyone else.";
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Password";
  SingleGroup.CustomInput.Input = new InputPasswordManager()
  {
    Placeholder = "Password",
    ID = "input-password-dom-id"
  };
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Input = new InputCheckboxManager() { ID = "input-checkbox-dom-id" };
  SingleGroup.CustomInput.Label = "Check me out";
  form.AddChild(SingleGroup);

  form.AddChild(new BootstrapButtonManager("Submit")
  {
    ButtonType = ButtonTypesEnum.submit,
    BackgroundColorTheme = BackgroundColorThemesEnum.primary
  });

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms overview](../../../demo/forms-overview.jpg)
```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="form-group">
    <label for="input-email-dom-id">Email address</label>
    <input aria-describedby="input-email-dom-id-HelpCaption" id="input-email-dom-id" name="input-email-dom-id" placeholder="Enter email" type="email" class="form-control">
    <small id="input-email-dom-id-HelpCaption" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="input-password-dom-id">Password</label>
    <input id="input-password-dom-id" name="input-password-dom-id" placeholder="Password" type="password" class="form-control">
  </div>
  <div class="form-check form-group">
    <input id="input-checkbox-dom-id" name="input-checkbox-dom-id" type="checkbox" class="form-check-input">
    <label for="input-checkbox-dom-id" class="form-check-label">Check me out</label>
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
```
## Form controls[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-controls)

> Текстовые контролы `<input>`**s**, `<select>`**s** и `<textarea>`**s** — оформлены классом стилей **.form-control**.
В базовое оформление включены стили для общего внешнего вида, состояния фокуса, размеров и многого другого.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Email address";
  SingleGroup.CustomInput.Input = new InputEmailManager()
  {
    Placeholder = "name@example.com",
    ID = "input-email-dom-id"
  };
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Example select";
  InputSelectManager inputSelect = new InputSelectManager()
  {
    ID = "input-select-dom-id"
  };
  for (int i = 1; i < 6; i++)
  {
    inputSelect.AddItem(i.ToString(), null);
  }
  //
  SingleGroup.CustomInput.Input = inputSelect;
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Example multiple select";
  inputSelect = new InputSelectManager()
  {
    ID = "input-multiple-select-dom-id",
    IsMultiple = true
  };
  for (int i = 1; i < 6; i++)
  {
    inputSelect.AddItem(i.ToString(), null);
  }
  //
  SingleGroup.CustomInput.Input = inputSelect;
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Example textarea";
  SingleGroup.CustomInput.Input = new TextareaManager() { ID = "input-textarea-dom-id", Placeholder = "Full-text input", SizeArea = 3 };
  form.AddChild(SingleGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms controls](../../../demo/forms-controls.jpg)
```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="form-group">
    <label for="input-email-dom-id">Email address</label>
    <input id="input-email-dom-id" name="input-email-dom-id" placeholder="name@example.com" type="email" class="form-control">
  </div>
  <div class="form-group">
    <label for="input-select-dom-id">Example select</label>
    <select id="input-select-dom-id" name="input-select-dom-id" class="form-control">
      <option>1</option>
      <option>2</option>
      <option>3</option>
      <option>4</option>
      <option>5</option>
    </select>
  </div>
  <div class="form-group">
    <label for="input-multiple-select-dom-id">Example multiple select</label>
    <select id="input-multiple-select-dom-id" multiple="" name="input-multiple-select-dom-id" class="form-control">
      <option>1</option>
      <option>2</option>
      <option>3</option>
      <option>4</option>
      <option>5</option>
    </select>
  </div>
  <div class="form-group">
    <label for="input-textarea-dom-id">Example textarea</label>
    <textarea id="input-textarea-dom-id" name="input-textarea-dom-id" placeholder="Full-text input" rows="3" class="form-control"></textarea>
  </div>
</form>
```
> Для файлов `<inputs />`**s**, вместо **.form-control** применяется **.form-control-file**.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Example file input";
  SingleGroup.CustomInput.Input = new InputFileManager()
  {
    ID = "input-file-dom-id"
  };
  form.AddChild(SingleGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms file controls](../../../demo/forms-form-file-control.jpg)
```html
<div class="form-group">
  <label for="input-file-dom-id">Example file input</label>
  <input id="input-file-dom-id" name="input-file-dom-id" type="file" class="form-control-file">
</div>
```
## Sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#sizing)

> Установите высоту, используя такие классы, как **.form-control-lg** и **.form-control-sm**.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager();
  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputTextManager()
    {
      Placeholder = ".form-control-lg"
    },
    SizeInput = TwinSizingEnum.Lg
  });
    GroupStacked.CustomInputs.Add(new CustomInputModel()
    {
      Input = new InputTextManager()
      {
        Placeholder = "Default input"
      }
  });
  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputTextManager()
    {
      Placeholder = ".form-control-sm"
    },
    SizeInput = TwinSizingEnum.Sm
  });
  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms controls sizing](../../../demo/forms-controls-sizing.jpg)

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager();
  InputSelectManager SelectInput = new InputSelectManager();
  SelectInput.AddItem("Large select", null);
  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = SelectInput,
    SizeInput = TwinSizingEnum.Lg
  });

  SelectInput = new InputSelectManager();
  SelectInput.AddItem("Default select", null);
  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = SelectInput
  });

  SelectInput = new InputSelectManager();
  SelectInput.AddItem("Small select", null);
  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = SelectInput,
    SizeInput = TwinSizingEnum.Sm
  });

  form.AddChild(GroupStacked);    
  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms select controls sizing](../../../demo/forms-select-controls-sizing.jpg)

## Readonly[¶](https://getbootstrap.com/docs/4.3/components/forms/#readonly)

> Добавьте логический атрибут `readonly` для `<input>`, чтобы предотвратить изменение значения поля формы.
Поля формы **"только для чтения"** выглядят светлее остальных и похоже на **"отключенные"**, но сохраняют стандартный курсор.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Input = new InputTextManager()
  {
    Readonly = true,
    Placeholder = "Readonly input here...",
    ID = "input-text-dom-id"
  };
  form.AddChild(SingleGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms controls readonly](../../../demo/forms-controls-readonly.jpg)

## Readonly plain text[¶](https://getbootstrap.com/docs/4.3/components/forms/#readonly-plain-text)

> Если вы хотите, чтобы элементы `<input readonly>` в вашей форме были оформлены как обычный текст, используйте класс **.form-control-plaintext** для удаления оформления полей формы по умолчанию и сохранения правильного **margin** и **padding**.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager() { IsHorisontal = true };
  SingleGroup.CustomInput.Label = "Email";
  SingleGroup.CustomInput.Input = new InputTextManager()
  {
    ID = "input-email-dom-id",
    Value = "email@example.com",
    Readonly = true
  };
  SingleGroup.CustomInput.Input.AddCSS("form-control-plaintext");
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager() { IsHorisontal = true };
  SingleGroup.CustomInput.Label = "Password";
  SingleGroup.CustomInput.Input = new InputPasswordManager()
  {
    Placeholder = "Password",
    ID = "input-password-dom-id"
  };
  form.AddChild(SingleGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms controls readonly plain text](../../../demo/forms-controls-readonly-plain-text.jpg)

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id", IsInlineForm = true };

  FormGroupSingleManager FormGroup = new FormGroupSingleManager().AddCSS("mb-2") as FormGroupSingleManager;
  FormGroup.CustomInput.Label = "Email";
  FormGroup.CustomInput.LabelSrOnly = true;
  FormGroup.CustomInput.Input = new InputTextManager()
  {
    ID = "staticEmail2",
    Value = "email@example.com",
    Readonly = true
  };
  FormGroup.CustomInput.Input.AddCSS("form-control-plaintext");
  form.AddChild(FormGroup);

  FormGroup = new FormGroupSingleManager().AddCSS("mx-sm-3 mb-2") as FormGroupSingleManager;
  FormGroup.CustomInput.Label = "Password";
  FormGroup.CustomInput.LabelSrOnly = true;
  FormGroup.CustomInput.Input = new InputPasswordManager()
  {
    ID = "inputPassword2",
    Placeholder = "Password"
  };
  form.AddChild(FormGroup);

  form.AddChild(new BootstrapButtonManager("Confirm identity") { BackgroundColorTheme = BackgroundColorThemesEnum.primary, ButtonType = ButtonTypesEnum.submit }.AddCSS("mb-2"));

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms inline controls readonly plain text](../../../demo/forms-inline-controls-readonly-plain-text.jpg)

## Range Inputs[¶](https://getbootstrap.com/docs/4.3/components/forms/#range-inputs)

> Установите горизонтально прокручиваемый "range `<input>`**s**" с помощью **.form-control-range**.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager FormGroup = new FormGroupSingleManager();
  FormGroup.CustomInput.Label = "Example Range input";
  FormGroup.CustomInput.Input = new InputRangeManager() { ID = "formControlRange" };
  form.AddChild(FormGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms range inputs](../../../demo/forms-range-inputs.jpg)

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
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager();

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "defaultCheck1"
    },
    Label = "Default checkbox"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "defaultCheck2",
      IsDisabled = true
    },
    Label = "Disabled checkbox"
  });

  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms checkboxes](../../../demo/forms-checkboxes.jpg)

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager();

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      Value = "option1",
      NameDom = "exampleRadios",
      ID = "exampleRadios1",
      IsChecked = true
    },
    Label = "Default checkbox"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      Value = "option2",
      NameDom = "exampleRadios",
      ID = "exampleRadios2"
    },
    Label = "Second default radio"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      Value = "option3",
      NameDom = "exampleRadios",
      ID = "exampleRadios3",
      IsDisabled = true
    },
    Label = "Disabled checkbox"
  });

  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms radios](../../../demo/forms-radios.jpg)

## Inline[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline)

> Группируйте `checkbox`**es** и `radio`**s** в одной горизонтальной строке путем добавления **.form-check-inline** в любой **.form-check**.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager() { IsInline = true };

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "inlineCheckbox1"
    },
    Label = "1"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "inlineCheckbox2"
    },
    Label = "2"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "inlineCheckbox3",
      IsDisabled = true
    },
    Label = "3"
  });

  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms inline checkboxes](../../../demo/forms-inline-checkboxes.jpg)

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager() { IsInline = true };

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
        Input = new InputRadioManager()
        {
            ID = "inlineRadio1",
            NameDom = "inlineRadioOptions",
            Value = "option1"
        },
        Label = "1"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      ID = "inlineRadio2",
      NameDom = "inlineRadioOptions",
      Value = "option2"
    },
    Label = "2"
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      ID = "inlineRadio3",
      NameDom = "inlineRadioOptions",
      Value = "option3",
      IsDisabled = true
    },
    Label = "3"
  });

  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms inline radios](../../../demo/forms-inline-radios.jpg)

## Without labels[¶](https://getbootstrap.com/docs/4.3/components/forms/#without-labels)

> Добавление **position-static** к `<input>`**s** внутри **.form-check**, когда нет текста метки.
Не забудьте по-прежнему предоставлять какую-нибудь метку для вспомогательных технологий (например, используя **aria-label**).

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupStackedManager GroupStacked = new FormGroupStackedManager();

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputCheckboxManager()
    {
      ID = "blankCheckbox"
    }.SetAttribute("aria-label","Checkbox without labels demo") as InputCheckboxManager
  });

  GroupStacked.CustomInputs.Add(new CustomInputModel()
  {
    Input = new InputRadioManager()
    {
      ID = "blankRadio1",
      NameDom = "blankRadio",
      Value = "option1"
    }.SetAttribute("aria-label","Radio without labels demo") as InputRadioManager
  });

  form.AddChild(GroupStacked);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms without labels](../../../demo/forms-without-labels.jpg)

```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="form-group">
    <div class="form-check">
      <input id="blankCheckbox" name="blankCheckbox" type="checkbox" class="form-check-input position-static" aria-label="Checkbox without labels demo">
    </div>
    <div class="form-check">
      <input id="blankRadio1" name="blankRadio" type="radio" value="option1" class="form-check-input position-static" aria-label="Radio without labels demo">
    </div>
  </div>
</form>
```

## Layout[¶](https://getbootstrap.com/docs/4.3/components/forms/#layout)

> Поскольку **Bootstrap** применяет `display: block;` и `width: 100%;` почти ко всем элементам управления формами, формы по умолчанию будут складываться вертикально.
Дополнительные классы могут использоваться для изменения этого макета для конкретной отдельно взятой формы.

## Form groups[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-groups)

> Класс стилей **.form-group** - это самый простой способ добавить некоторую структуру в формы.
Он предоставляет гибкость, которая поощряет правильную группировку `<label>`**s**, элементов управления, необязательного текста справки и сообщений проверки формы.
По умолчанию он применяет только `margin-bottom` ,но подбирает дополнительные стили в **.form-inline** по мере необходимости.
Используйте его с `<fieldset>`**s**, `<div>`**s** или почти любым другим элементом.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  FormGroupSingleManager SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Example label";
  SingleGroup.CustomInput.Input = new InputTextManager()
  {
    Placeholder = "Example input",
    ID = "input-example-dom-id"
  };
  form.AddChild(SingleGroup);

  SingleGroup = new FormGroupSingleManager();
  SingleGroup.CustomInput.Label = "Another label";
  SingleGroup.CustomInput.Input = new InputTextManager()
  {
    Placeholder = "Another label",
    ID = "input-another-example-dom-id"
  };
  form.AddChild(SingleGroup);

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms groups](../../../demo/forms-groups.jpg)

```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="form-group">
    <label for="input-example-dom-id">Example label</label>
    <input id="input-example-dom-id" name="input-example-dom-id" placeholder="Example input" type="text" class="form-control">
  </div>
  <div class="form-group">
    <label for="input-another-example-dom-id">Another label</label>
    <input id="input-another-example-dom-id" name="input-another-example-dom-id" placeholder="Another label" type="text" class="form-control">
  </div>
</form>
```

## Form grid[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-grid)

> Более сложные формы могут быть построены с использованием **grid** классов сетки.
Используйте их для макетов форм, требующих нескольких столбцов, различной ширины и дополнительных параметров выравнивания.

```cshtml
@{
  BootstrapFormManager form = new BootstrapFormManager() { ID = "domo-form-dom-id" };

  /////////////////////////////////////////////////
  //

  DivBaseManager div_row = new DivBaseManager().AddCSS("row") as DivBaseManager;

  DivBaseManager div_col = new DivBaseManager().AddCSS("col") as DivBaseManager;
  div_col.AddChild(new InputTextManager() { Placeholder = "First name" }.AddCSS("form-control"));
  div_row.AddChild(div_col);

  div_col = new DivBaseManager().AddCSS("col") as DivBaseManager;
  div_col.AddChild(new InputTextManager() { Placeholder = "Last name" }.AddCSS("form-control"));
  div_row.AddChild(div_col);
  form.AddChild(div_row);

  //
  /////////////////////////////////////////////////

  @await Component.InvokeAsync(form.ViewComponentName, new { SetObjectManager = form })
}
```

***result:***

![Forms grid](../../../demo/forms-grid.jpg)

```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="row">
    <div class="col">
      <input placeholder="First name" type="text" class="form-control">
    </div>
    <div class="col">
      <input placeholder="Last name" type="text" class="form-control">
    </div>
  </div>
</form>
```

```cshtml

```

***result:***

![Forms grid](../../../demo/forms-grid-2.jpg)

```html
<form accept-charset="utf-8" id="domo-form-dom-id">
  <div class="row">
    <div class="col">
      <label>First label</label>
      <input placeholder="First name" type="text" class="form-control">
    </div>
    <div class="col">   
      <label>Last label</label>
      <input placeholder="Last name" type="text" class="form-control">
    </div>
    <div class="col">   
      <label>Description label</label>
      <input placeholder="Description" type="text" class="form-control">
    </div>
  </div>
</form>
```

## Form row[¶](https://getbootstrap.com/docs/4.3/components/forms/#form-row)

> Можно также использовать **.form-row** вместо стандартной строки сетки **.row**, чтобы переопределить зазор по умолчанию для более плотных и компактных макетов.

```cshtml
@{

}
```

***result:***

![Forms row](../../../demo/forms-row.jpg)

> Более сложные и комплексные макеты также могут быть созданы с помощью **grid**-системы.

```cshtml
@{

}
```

***result:***

![Forms complex layouts](../../../demo/forms-complex-layouts.jpg)

## Horizontal form[¶](https://getbootstrap.com/docs/4.3/components/forms/#horizontal-form)

> Создавайте горизонтальные формы с помощью сетки, добавив класс **.row** для формирования групп форм и используйте классы `.col-*-*` для указания ширины ваших меток и элементов управления.
Обязательно добавьте **.col-form-label** к вашим `<label>`, чтобы они были вертикально отцентрированы с соответствующими элементами управления формы.

```cshtml
@{

}
```

***result:***

![Forms horizontal rows](../../../demo/forms-horizontal-rows.jpg)

###### Horizontal form label sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#horizontal-form-label-sizing)

> Обязательно используйте **.col-form-label-sm** или **.col-form-label-lg** для ваших `<label>` или `<legend>`**s**, чтобы правильно следовать размеру **.form-control-lg** и **.form-control-sm**.

```cshtml
@{

}
```

***result:***

![Forms horizontal form label sizing](../../../demo/forms-horizontal-form-label-sizing.jpg)

## Column sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#column-sizing)

> Как показано в предыдущих примерах, **grid** система позволяет вам размещать любое количество **.cols** в **.row** или **.form-row**.
Они разделят доступную ширину поровну между ними.
Вы также можете выбрать подмножество ваших столбцов, чтобы они занимали больше или меньше места, в то время как остальные **.cols** в равной степени разделяют остальные, с конкретными классами столбцов, такими как **.col-7**.

```cshtml
@{

}
```

***result:***

![Forms column sizing](../../../demo/forms-horizontal-form-column-sizing.jpg)

## Auto-sizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#auto-sizing)

> В приведенном ниже примере используется утилита **flexbox** для вертикального центрирования содержимого и изменения **.col** на **.col-auto**, чтобы ваши столбцы занимали столько места, сколько необходимо.
Другими словами, размер столбца зависит от его содержимого.

```cshtml
@{

}
```

***result:***

![Forms auto sizing](../../../demo/forms-horizontal-form-auto-sizing.jpg)

> Затем вы можете повторить это еще раз с помощью классов столбцов, зависящих от размера.

```cshtml
@{

}
```

***result:***

![Forms auto sizing remix](../../../demo/forms-horizontal-form-auto-sizing-remix.jpg)

> [Пользовательские элементы управления формы](https://getbootstrap.com/docs/4.3/components/forms/#custom-forms) тоже поддерживаются

```cshtml
@{

}
```

***result:***

![Forms custom inputs](../../../demo/forms-custom-inputs.jpg)

## Inline forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline-forms)

> Используйте класс **.form-inline** для отображения серии меток, элементов управления формы и кнопок в одной горизонтальной строке.
Элементы управления формы внутри встроенных форм немного отличаются от их состояний по умолчанию.

- Элементам управления формы устанавлиывается атрибут `display: flex`, сворачивая любое пустое пространство HTML и позволяя вам обеспечить контроль выравнивания с помощью утилит [spacing](https://getbootstrap.com/docs/4.3/utilities/spacing/) и [flexbox](https://getbootstrap.com/docs/4.3/utilities/flex/).
- Элементы управления и группы ввода получают `width: auto;`, чтобы переопределить ширину **Bootstrap** по умолчанию: `width: 100%;`.
- Элементы управления **отображаются встроенными только в окнах просмотра шириной не менее 576px** для учета узких окон просмотра на мобильных устройствах.

> Возможно, вам придется вручную задавать ширину и выравнивание отдельных элементов управления формы с помощью [служебных spacing утилит](https://getbootstrap.com/docs/4.3/utilities/spacing/) (как показано ниже).
Наконец, обязательно добавляйте `<label>` к каждому полю формы. Если вам нужно скрыть его от посетителей, примените **.sr-only**.

```cshtml
@{

}
```

***result:***

![Forms inline](../../../demo/forms-inline.jpg)

> Пользовательские элементы управления формы и `select`**s** тоже поддерживаются.

```cshtml
@{

}
```

***result:***

![Forms inline сustom controls and selects](../../../demo/forms-inline-сustom-controls-and-selects.jpg)

> Альтернативы скрытым меткам
У вспомогательных технологий, такие как программы чтения с экрана, могут иметь проблемы с вашими формами, если вы не включаете метку для каждого ввода.
Для таких inline форм, вы можете спрятать ярлыки с помощью ".sr-only" класса.
Существуют и другие альтернативные способы предоставления метки для вспомогательных технологий. Например атрибуты **aria-label**, **aria-labelledby** или **title**.
Если ни один из них не присутствует, вспомогательные технологии могут прибегнуть к использованию атрибута **placeholder**, если он присутствует, но обратите внимание, что использование **placeholder** в качестве замены для других методов маркировки не рекомендуется.

## Help text[¶](https://getbootstrap.com/docs/4.3/components/forms/#help-text)

> Текст справки на уровне блоков в формах может быть создан с использованием **.form-text** (ранее в `v3` известный как **.help-block**).
Встроенный текст справки может быть гибко реализован с использованием любого встроенного HTML-элемента и служебных классов, таких как **.text-muted**.

> Связывание текста справки с элементами управления формы: 
Текст справки должен быть явно связан с элементом управления формы, к которому он относится с использованием атрибута **aria-describedby**.
Это гарантирует, что вспомогательные технологии, такие как программы чтения с экрана, будут объявлять этот текст справки, когда пользователь фокусируется или активизирует элемент управления.

> Текст справки под `<input>` может быть оформлен с помощью **.form-text**.
Этот класс включает `display: block;` и добавляет отступ от `<input>` сверху.

```cshtml
@{

}
```

***result:***

![Forms input help text](../../../demo/forms-input-help-text.jpg)

> Inline текст может использовать любой типичный Inline HTML-элемент (будь то `<small>`, `<span>` или что-то еще) без какого либо служебного класса.

```cshtml
@{

}
```

***result:***

![Forms inline input help text](../../../demo/forms-inline-input-help-text.jpg)

## Disabled forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#disabled-forms)

> Добавьте в `<input>` логический атрибут **disabled**, чтобы предотвратить взаимодействие с пользователем и сделать его более светлым.

```cshtml
@{

}
```

***result:***

![Disabled forms](../../../demo/disabled-forms.jpg)

> Будьте осторожны с якорями! 
По умолчанию браузеры будут обрабатывать все собственные элементы управления формой (элементы `<input>`, `<select>` и `<button>`) внутри `<fieldset disabled>` как отключенные, предотвращая на них взаимодействие с клавиатурой и мышью.
Однако, если ваша форма также содержит элементы `<a ... class="btn btn-*">`, им будет присвоен только стиль `pointer-events: none;`.
Как отмечено в разделе об отключенном состоянии для кнопок (и, в частности, в подразделе для якорных элементов), это свойство CSS еще не стандартизировано и не полностью поддерживается в **Internet Explorer 10** и не будет препятствовать пользователям клавиатуры возможность сфокусировать или активировать эти ссылки. 
Поэтому, чтобы быть в безопасности, используйте пользовательский **JavaScript**, чтобы отключить такие ссылки.

> Кросс-браузерная совместимость:
Хотя **Bootstrap** будет применять эти стили во всех браузерах, **Internet Explorer 11** и ниже не полностью поддерживает атрибут **disabled** в `<fieldset>`.
Используйте пользовательский **JavaScript**, чтобы отключить набор полей в этих браузерах.

## Validation forms[¶](https://getbootstrap.com/docs/4.3/components/forms/#validation)

> Предоставьте ценную и действенную обратную связь своим пользователям с проверкой формы HTML5, доступной во всех [поддерживаемых браузерах](https://caniuse.com/#feat=form-validation).
Выберите в браузере отзывы о проверке по умолчанию или создайте пользовательские сообщения с помощью наших встроенных классов и начального JavaScript.

## How it works[¶](https://getbootstrap.com/docs/4.3/components/forms/#how-it-works)

> Вот как проверка формы работает с Bootstrap:
- Проверка формы HTML применяется с помощью двух псевдоклассов CSS `:invalid` и `:valid`. Он применяется к элементам `<input>`, `<select>` и `<textarea>`.
- **Bootstrap** применяет стили `:invalid` и `:valid` к родительскому классу **.was-validated**, обычно применяемому к `<form>`. В противном случае любое обязательное поле без значения отображается как недопустимое при загрузке страницы. Таким образом, вы можете выбрать, когда их активировать (обычно после попытки отправки формы).
- Чтобы сбросить внешний вид формы (например, в случае динамической отправки формы с использованием AJAX), снова удалите класс **.was-validated** из `<form>` после отправки.
- В качестве запасного варианта вместо псевдоклассов [для проверки на стороне сервера](https://getbootstrap.com/docs/4.3/components/forms/#server-side) могут использоваться классы **.is-invalid** и **.is-valid**. Им не требуется родительский класс **.was-validated**.
- Из-за ограничений в том, как работает CSS, мы не можем (в настоящее время) применять стили к `<label>`, который находится перед элементом управления формой в DOM, без помощи специального **JavaScript**.
- Все [современные браузеры поддерживают API](https://www.w3.org/TR/html5/sec-forms.html#the-constraint-validation-api) проверки ограничений - серию методов JavaScript для проверки элементов управления формы.
- Cообщения обратной связи могут отображаться [браузером самостоятельно по умолчанию](https://getbootstrap.com/docs/4.3/components/forms/#browser-defaults) (разные для каждого браузера и нестабильные через CSS) или пользовательские **Bootstrap** стили обратной связи с дополнительными HTML и CSS.
- Вы можете предоставить пользовательские сообщения о валидности с помощью `setCustomValidity` в **JavaScript**.

## Custom styles[¶](https://getbootstrap.com/docs/4.3/components/forms/#custom-styles)

> 

```cshtml
@{

}
```

***result:***

![Validation forms](../../../demo/validation-forms-custom-styles.jpg)

## Browser defaults[¶](https://getbootstrap.com/docs/4.3/components/forms/#browser-defaults)

> 

```cshtml
@{

}
```

***result:***

![Validation forms browser defaults](../../../demo/validation-forms-browser-defaults.jpg)

## Server side[¶](https://getbootstrap.com/docs/4.3/components/forms/#server-side)

> 

```cshtml
@{

}
```

***result:***

![Validation forms server side](../../../demo/validation-forms-server-side.jpg)

## Supported elements[¶](https://getbootstrap.com/docs/4.3/components/forms/#supported-elements)

> 

```cshtml
@{

}
```

***result:***

![Validation forms supported elements](../../../demo/validation-forms-supported-elements.jpg)

## Tooltips[¶](https://getbootstrap.com/docs/4.3/components/forms/#tooltips)

> 

```cshtml
@{

}
```

***result:***

![Validation forms tooltips](../../../demo/validation-forms-tooltips.jpg)

## Customizing[¶](https://getbootstrap.com/docs/4.3/components/forms/#customizing)

> 

```cshtml
@{

}
```

***result:***

![Validation forms customizing](../../../demo/validation-forms-customizing.jpg)

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

![Custom forms checkboxes](../../../demo/custom-forms-checkboxes.jpg)

> Пользовательские `checkbox`**es** также могут использовать псевдокласс: **indeterminate** при ручной установке с помощью JavaScript (для этого в HTML нет доступного атрибута).

```cshtml
@{

}
```

***result:***

![Custom forms checkboxes indeterminate](../../../demo/custom-forms-checkboxes-indeterminate.jpg)

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

![Custom forms radios](../../../demo/custom-forms-radios.jpg)

## Inline[¶](https://getbootstrap.com/docs/4.3/components/forms/#inline-1)

```cshtml
@{

}
```

***result:***

![Custom forms radios inline](../../../demo/custom-forms-radios-inline.jpg)

## Disabled[¶](https://getbootstrap.com/docs/4.3/components/forms/#disabled)

> 

```cshtml
@{

}
```

***result:***

![Custom forms disabled](../../../demo/custom-forms-disabled.jpg)

## Switches[¶](https://getbootstrap.com/docs/4.3/components/forms/#switches)

> 

```cshtml
@{

}
```

***result:***

![Custom forms switches](../../../demo/custom-forms-switches.jpg)

## Select menu[¶](https://getbootstrap.com/docs/4.3/components/forms/#select-menu)

> **Switch** имеет разметку пользовательского флажка, но использует класс **.custom-switch** для рендеринга тумблера.
**Switches** также поддерживают отключенный атрибут.

```cshtml
@{

}
```

***result:***

![Custom forms select menu](../../../demo/custom-forms-select-menu.jpg)

> Вы также можете установить размер пользовательских `<selects>`**s**, чтобы соответствовать текстовым `<inputs>` аналогичного размера.

```cshtml
@{

}
```

***result:***

![Custom forms select menu size](../../../demo/custom-forms-select-menu-size.jpg)

> Множественный выбор также поддерживается:

```cshtml
@{

}
```

***result:***

![Custom forms select menu multiple attribute](../../../demo/custom-forms-select-menu-multiple-attribute.jpg)

> Как и атрибут размера:

```cshtml
@{

}
```

***result:***

![Custom forms select menu size attribute](../../../demo/custom-forms-select-menu-size-attribute.jpg)

## Range[¶](https://getbootstrap.com/docs/4.3/components/forms/#range)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range](../../../demo/custom-forms-range.jpg)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range max](../../../demo/custom-forms-range-max.jpg)

> 

```cshtml
@{

}
```

***result:***

![Custom forms range step](../../../demo/custom-forms-range-step.jpg)

## File browser[¶](https://getbootstrap.com/docs/4.3/components/forms/#file-browser)

> 

```cshtml
@{

}
```

***result:***

![Custom forms file browser](../../../demo/custom-forms-file-browser.jpg)