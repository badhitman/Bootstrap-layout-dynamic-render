////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public class AbstractNestedToolsManager : AbstractDomManager
    {
        #region Вложеные/Дочерние элементы
        ///////////////////////////////////////////////////////////
        //
        public int ChildsCount => Childs.Count;

        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        protected internal List<AbstractDomManager> Childs = new List<AbstractDomManager>();

        public AbstractDomManager[] GetChilds() => Childs.ToArray();

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
        //
        ///////////////////////////////////////////////////////////
        #endregion
        
        public void ChildsAddCSS(string css_class)
        {
            foreach(AbstractDomManager child in Childs)
            {
                child.AddCSS(css_class, true);
                if (child is AbstractNestedToolsManager || child.GetType().IsSubclassOf(typeof(AbstractNestedToolsManager)))
                    ((AbstractNestedToolsManager)child).ChildsAddCSS(css_class);
            }
        }

        /// <summary>
        /// Установить класс объекту по его Id_DOM
        /// </summary>
        public AbstractNestedToolsManager AddCSS(string id_dom, string css_class)
        {
            if (Id_DOM.ToLower().Equals(id_dom.ToLower()))
                AddCSS(css_class);

            foreach (AbstractDomManager adm in Childs.Where(x => !(x is null) && x is AbstractNestedToolsManager))
                ((AbstractNestedToolsManager)adm).AddCSS(id_dom, css_class);

            return this;
        }

        public AbstractNestedToolsManager SetAttribute(string id_dom, string attr_name, string attr_value)
        {
            if (Id_DOM.ToLower().Equals(id_dom.ToLower()))
                SetAttribute(attr_name, attr_value);

            foreach (AbstractDomManager adm in Childs.Where(x => !(x is null) && x is AbstractNestedToolsManager))
                ((AbstractNestedToolsManager)adm).SetAttribute(id_dom, attr_name, attr_value);

            return this;
        }
    }
}
