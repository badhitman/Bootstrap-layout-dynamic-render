////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Извне недоступны методы управления вложеными объектами
    /// </summary>
    public abstract class ahsNestedTools : ahsDom
    {
        public int ChildsCount => Childs.Count;

        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        protected internal List<ahsDom> Childs = new List<ahsDom>();

        public virtual ahsDom[] GetChilds() => Childs.ToArray();

        public void ChildsAddCSS(string css_class)
        {
            foreach (ahsDom child in Childs)
            {
                child.AddCSS(css_class);
                if (child is ahsNestedTools || child.GetType().IsSubclassOf(typeof(ahsNestedTools)))
                    ((ahsNestedTools)child).ChildsAddCSS(css_class);
            }
        }

        /// <summary>
        /// Установить класс объекту по его ID
        /// </summary>
        public ahsNestedTools AddByIdCSS(string id_dom, string css_class)
        {
            if (ID.ToLower().Equals(id_dom.ToLower()))
                AddCSS(css_class);

            foreach (ahsDom adm in Childs.Where(x => !(x is null) && x is ahsNestedTools))
                ((ahsNestedTools)adm).AddByIdCSS(id_dom, css_class);

            return this;
        }

        public ahsNestedTools SetAttributeById(string id_dom, string attr_name, string attr_value)
        {
            if (ID.ToLower().Equals(id_dom.ToLower()))
                SetAttribute(attr_name, attr_value);

            foreach (ahsDom adm in Childs.Where(x => !(x is null) && x is ahsNestedTools))
                ((ahsNestedTools)adm).SetAttributeById(id_dom, attr_name, attr_value);

            return this;
        }
    }
}
