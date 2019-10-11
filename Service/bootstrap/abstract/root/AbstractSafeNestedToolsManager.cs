////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    /// <summary>
    /// Заблокированы методы управления вложеными объектами
    /// </summary>
    public class AbstractSafeNestedToolsManager : AbstractNestedToolsManager
    {
        /// <summary>
        /// ЗАПРЕЩЕНО!
        /// В данном объекте нельзя {напрямую/вручную} манипулировать вложеными [dom] элементами.
        /// </summary>
        public override void AddDomNode(AbstractToolsManager child)
        {
            throw new NotImplementedException();
            //base.Add(child);
        }

        /// <summary>
        /// ЗАПРЕЩЕНО!
        /// В данном объекте нельзя {напрямую/вручную} манипулировать вложеными [dom] элементами.
        /// </summary>
        public override void AddRangeDomNode(List<AbstractToolsManager> childs)
        {
            throw new NotImplementedException();
            //base.AddRange(childs);
        }

        /// <summary>
        /// ЗАПРЕЩЕНО!
        /// В данном объекте нельзя {напрямую/вручную} манипулировать вложеными [dom] элементами.
        /// </summary>
        public override void ClearNestedDom()
        {
            throw new NotImplementedException();
            //base.ClearNestedDom();
        }
    }
}
