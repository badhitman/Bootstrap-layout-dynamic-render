////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    /// <summary>
    /// Извне недоступны методы управления вложеными объектами
    /// </summary>
    public abstract class AbstractNestedToolsManager : AbstractDomManager
    {
        public int ChildsCount => Childs.Count;

        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        protected internal List<AbstractDomManager> Childs = new List<AbstractDomManager>();

        public virtual AbstractDomManager[] GetChilds() => Childs.ToArray();

        public void ChildsAddCSS(string css_class)
        {
            foreach (AbstractDomManager child in Childs)
            {
                child.AddCSS(css_class, true);
                if (child is AbstractNestedToolsManager || child.GetType().IsSubclassOf(typeof(AbstractNestedToolsManager)))
                    ((AbstractNestedToolsManager)child).ChildsAddCSS(css_class);
            }
        }

        /// <summary>
        /// Установить класс объекту по его Id_DOM
        /// </summary>
        public AbstractNestedToolsManager AddByIdCSS(string id_dom, string css_class)
        {
            if (Id_DOM.ToLower().Equals(id_dom.ToLower()))
                AddCSS(css_class);

            foreach (AbstractDomManager adm in Childs.Where(x => !(x is null) && x is AbstractNestedToolsManager))
                ((AbstractNestedToolsManager)adm).AddByIdCSS(id_dom, css_class);

            return this;
        }

        public AbstractNestedToolsManager SetAttributeById(string id_dom, string attr_name, string attr_value)
        {
            if (Id_DOM.ToLower().Equals(id_dom.ToLower()))
                SetAttribute(attr_name, attr_value);

            foreach (AbstractDomManager adm in Childs.Where(x => !(x is null) && x is AbstractNestedToolsManager))
                ((AbstractNestedToolsManager)adm).SetAttributeById(id_dom, attr_name, attr_value);

            return this;
        }
    }
}
