////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public abstract class AbstractNestedToolsManager : AbstractSafeNestedToolsManager
    {
        /// <summary>
        /// Прямое добавление дочернего/вложеного элемента.
        /// </summary>
        public virtual void AddDomNode(AbstractDomManager child) => Childs.Add(child);

        /// <summary>
        /// Пакетное добавление дочерних/вложеных элементов.
        /// </summary>
        public virtual void AddRangeDomNode(List<AbstractDomManager> childs) => Childs.AddRange(childs);

        /// <summary>
        /// Удалить все ложеные DOM элементы
        /// </summary>
        public virtual void ClearNestedDom() => Childs.Clear();
    }
}
