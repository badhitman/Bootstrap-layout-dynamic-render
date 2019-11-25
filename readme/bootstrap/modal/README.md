# Modal[�](https://getbootstrap.com/docs/4.3/components/modal/)

> ����������� Bootstrap JavaScript **modal** ������ ��� ���������� ���������� ���� �� ��� ���� ��� ����������, ����������� ������������� ��� ��������� ����������������� ��������.

> ������ ��� ������ ������ � ����������� **modal** Bootstrap, ����������� ���������� ���������:

- ��������� ������� �������� � �������������� **HTML**, **CSS** � **JavaScript**. ��� ����������� ������ ����� ���������� � ��������� � ��������� ��������� `<body>`, ����� ������ ����� �������������� ��������� ����������.
- �������� ������ �� ��������� ���������� ������� � ��������� ������ ������������� ���������.
- Bootstrap ������������ ������ ���� ��������� ���� �� ���. ��������� ��������� ������� �� ��������������.
- ��������� ������� ���������� `position: fixed;`, � ����� � ��� ��������� ������ ����� ����� ��������� �����������. �� ����������� ���������� ���� ��������� HTML-��� �� ������� ������, ����� �������� ��������� ����� �� ������� ������ ���������. ��, ��������, ����������� � ���������� ��� �������� **.modal** ������ ������� `position: fixed;` ��������.
- ��-�� `position: fixed;`, ���� ��������� ������ � �������������� ��������� �������� �� ��������� �����������. �������������� ���������� ��. [� ������������ �� ��������� ��������](https://getbootstrap.com/docs/4.3/getting-started/browsers-devices/#modals-and-dropdowns-on-mobile).
- ��-�� ����������� ��������� HTML5, [HTML ������� **autofocus**](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-autofocus) �� ����� �������� ������� � ��������� �������� Bootstrap. ����� ������� ���� �� �������, ����������� ��������� ���������������� JavaScript:

```javascript
$('#myModal').on('shown.bs.modal', function () {
  $('#myInput').trigger('focus')
})
```

> ������������ ������ ����� ���������� ������� �� **prefers-reduced-motion media query**.
��. [������ � ������������](https://getbootstrap.com/docs/4.3/getting-started/accessibility/#reduced-motion).

## Modal components[�](https://getbootstrap.com/docs/4.3/components/modal/#modal-components)

> ���� �������� ����������� ������ ���������� ������� (��� ��������, ��� ��� ������� � ����������� ���� ��������������).
�������� ���������, ���� (��������� ��� ���������� ���������) � ������ ���������� (�������������).
� ��������� ���������� ���� ���� ������ �����������.

```cshtml
@{

}
```

***result:***

![Modal demo](../demo/modal-demo.jpg)

## Scrolling long content[�](https://getbootstrap.com/docs/4.3/components/modal/#scrolling-long-content)

> ����� ��������� ���� ���������� ������� �������� ��� ������ ���������� ������������, ��� �������������� ������� � ���������� �� ����� ��������.

> �� ������ ������� �������������� ��������� ����, ������� ��������� ������������ ��������������� ��������� ����, ������� **.modal-dialog-scrollable** � **.modal-dialog**.

```cshtml
@{

}
```

***result:***

![Modal scrolling long content body demo](../demo/modal-scrollable-modal-body-demo.jpg)

## Vertically centered[�](https://getbootstrap.com/docs/4.3/components/modal/#vertically-centered)

> �������� **.modal-dialog-centtered** � **.modal-dialog**, ����� ����������� ������������ ��������� ����.

```cshtml
@{

}
```

***result:***

![Modal vertically centered demo](../demo/modal-vertically-centered-demo.jpg)

## Tooltips and popovers[�](https://getbootstrap.com/docs/4.3/components/modal/#tooltips-and-popovers)

> ��� ������������� � ��������� ����� ����� ���� ��������� ����������� ��������� � ����������� ����.
����� ��������� ���� �������, ����� ����������� ��������� � ����������� ���� ����� ������������� ���������.

## Using the grid[�](https://getbootstrap.com/docs/4.3/components/modal/#using-the-grid)

> ����������� �������� ������� Bootstrap � ���� ���������� ����, ������ **.container-liquid** � **.modal-body**.
����� ����������� ������� ������ ������� �����, ��� ������.

```cshtml
@{

}
```

## Varying modal content[�](https://getbootstrap.com/docs/4.3/components/modal/#varying-modal-content)

> � ��� ���� ��������� ������, ������� ������ ��������� ���� � ��� �� ��������� ���� �� ������ ������������ ����������?
����������� �������� **event.relatedTarget** � HTML `data- *` (��������, ����� jQuery), ����� ����������� ���������� ���������� ���� � ����������� �� ����, ����� ������ ���� ������.

```cshtml
@{

}
```

## Optional sizes[�](https://getbootstrap.com/docs/4.3/components/modal/#optional-sizes)

> ��������� ���� ����������� ����� ��� �������, ��������� ����� ������ ������������� ��� ���������� � ������� **.modal**.
��� ������� ������ � ������������ ����� ��������, ����� �������� �������������� ����� ��������� �� ����� ����� ����� ���������.

- _Small_ **.modal-sm** - 300px
- _Default_ None - 500px
- _Large_ **.modal-lg** - 800px
- _Extra large_ **.modal-xl** - 1140px

> ��������� ���� �� ��������� (��� ������ �������������) ���������� �������� ������.

```cshtml
@{

}
```