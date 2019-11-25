////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Заблокированный элемент. Такие элементы не могут получить фокус, быть нажатыми или активированы. 
    /// </summary>
    public abstract class ahsDisengageableDom : ahsDom
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
