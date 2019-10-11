////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public class AbstractNestedToolsManager: AbstractToolsManager
    {
        #region Вложеные/Дочерние элементы
        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        protected internal List<AbstractToolsManager> Childs = new List<AbstractToolsManager>();

        /// <summary>
        /// Прямое добавление дочернего/вложеного элемента.
        /// </summary>
        public virtual void AddDomNode(AbstractToolsManager child) => Childs.Add(child);

        /// <summary>
        /// Пакетное добавление дочерних/вложеных элементов.
        /// </summary>
        public virtual void AddRangeDomNode(List<AbstractToolsManager> childs) => Childs.AddRange(childs);

        /// <summary>
        /// Удалить все ложеные DOM элементы
        /// </summary>
        public virtual void ClearNestedDom() => Childs.Clear();
        #endregion
    }
}
