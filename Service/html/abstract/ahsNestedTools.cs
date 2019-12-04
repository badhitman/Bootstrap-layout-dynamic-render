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
        public int ChildsCount => ChildsNodes.Count;

        /// <summary>
        /// Дочерние/вложеные элементы
        /// </summary>
        protected internal List<ahsDom> ChildsNodes { get; } = new List<ahsDom>();

        public virtual ahsDom[] GetChilds() => ChildsNodes.ToArray();

        /// <summary>
        /// Добавление класса во все дочерние элементы
        /// </summary>
        /// <param name="AddedClassesCSS">Добавляемый класс стилей</param>
        public void ChildsAddCSS(string AddedClassesCSS)
        {
            if (string.IsNullOrWhiteSpace(AddedClassesCSS))
                return;

            foreach (ahsDom child in ChildsNodes)
            {
                child.AddCSS(AddedClassesCSS);
                if (child is ahsNestedTools || child.GetType().IsSubclassOf(typeof(ahsNestedTools)))
                    ((ahsNestedTools)child).ChildsAddCSS(AddedClassesCSS);
            }
        }

        /// <summary>
        /// Добавить CSS класс элементу по его HTML>DOM>ID. Поиск во всех вложеных элементах
        /// </summary>
        /// <param name="SoughtDomId">Искомый DOM.ID</param>
        /// <param name="AddedClassesCSS">Добавляемый класс стилей</param>
        public ahsNestedTools AddCssById(string SoughtDomId, string AddedClassesCSS)
        {
            if (ID.ToLower().Equals(SoughtDomId.ToLower()))
            {
                AddCSS(AddedClassesCSS);
                return this;
            }
            foreach (ahsDom adm in ChildsNodes.Where(x => !(x is null)))
            {
                if (adm is ahsNestedTools)
                    ((ahsNestedTools)adm).AddCssById(SoughtDomId, AddedClassesCSS);
                else if (adm.ID.ToLower().Equals(SoughtDomId.ToLower()))
                {
                    adm.AddCSS(AddedClassesCSS);
                    return this;
                }
            }
            return this;
        }

        /// <summary>
        /// Установить атрибут элементу по его HTML>DOM>ID. Поиск во всех вложеных элементах
        /// </summary>
        /// <param name="SoughtDomId">Искомый DOM.ID</param>
        /// <param name="SetAttrName">Имя атрибута</param>
        /// <param name="SetAttrValue">Значение атрибута</param>
        public ahsNestedTools SetAttributeById(string SoughtDomId, string SetAttrName, string SetAttrValue)
        {
            if (ID.ToLower().Equals(SoughtDomId.ToLower()))
            {
                SetAttribute(SetAttrName, SetAttrValue);
                return this;
            }

            foreach (ahsDom adm in ChildsNodes.Where(x => !(x is null) && x is ahsNestedTools))
            {
                if (adm is ahsNestedTools)
                    ((ahsNestedTools)adm).SetAttributeById(SoughtDomId, SetAttrName, SetAttrValue);
                else if (adm.ID.ToLower().Equals(SoughtDomId.ToLower()))
                {
                    adm.SetAttribute(SetAttrName, SetAttrValue);
                    return this;
                }
            }
            return this;
        }
    }
}
