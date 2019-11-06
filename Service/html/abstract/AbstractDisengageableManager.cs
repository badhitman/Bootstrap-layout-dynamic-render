using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    /// <summary>
    /// Заблокированный элемент. Такие элементы не могут получить фокус, быть нажатыми или активированы. 
    /// </summary>
    public abstract class AbstractDisengageableManager : AbstractDomManager
    {
        /// <summary>
        /// Заблокированный элемент. Такие элементы не могут получить фокус, быть нажатыми или активированы. 
        /// </summary>
        public bool IsDisabled { get; set; } = false;

        public override string GetStringAttributes()
        {
            if (IsDisabled)
                SetAttribute("disabled", "disabled");

            return base.GetStringAttributes();
        }
    }
}
