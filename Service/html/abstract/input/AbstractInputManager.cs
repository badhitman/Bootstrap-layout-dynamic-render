////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractInputManager : AbstractDisengageableManager
    {
        public override string ViewComponentName => nameof(InputBase);

        /// <summary>
        /// Имя поля формы
        /// </summary>
        public string NameDom
        {
            get => nameDom;
            set
            {
                nameDom = value;
                if (string.IsNullOrWhiteSpace(base.ID))
                    base.ID = nameDom;
            }
        }
        private string nameDom;
        public override string ID
        {
            get => base.ID;
            set
            {
                base.ID = value;
                if (string.IsNullOrWhiteSpace(nameDom))
                    nameDom = value;
            }
        }

        /// <summary>
        /// флаг/признак - только для чтения
        /// </summary>
        public bool Readonly { get; set; } = false;

        /// <summary>
        /// флаг/признак - обязательно для заполнения
        /// </summary>
        public bool Required { get; set; } = false;

        /// <summary>
        /// Автоматически устанавливает фокус в поле формы. В таком поле можно сразу набирать текст без явного щелчка по нему курсором мыши.
        /// </summary>
        public bool Autofocus { get; set; } = false;

        /// <summary>
        /// Связывает поле с формой по её идентификатору.
        /// Такая связь необходима в случае, когда поле располагается за пределами [form], например, при создании её программно или по соображениям дизайна.
        /// </summary>
        public string FormDomId { get; set; }

        public override string GetStringAttributes()
        {
            if (string.IsNullOrEmpty(CacheAttributes))
            {
                if (!string.IsNullOrWhiteSpace(NameDom))
                    SetAttribute("name", NameDom);

                if (!string.IsNullOrWhiteSpace(FormDomId))
                    SetAttribute("form", FormDomId);

                if (Autofocus)
                    SetAttribute("autofocus", null);

                if (Required)
                    SetAttribute("required", null);

                if (Readonly)
                    SetAttribute("readonly", null);
            }

            return base.GetStringAttributes();
        }
    }
}
