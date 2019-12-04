////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;

namespace BootstrapAspDynamicRender.models
{
    public class bmInput : asCloneableObject
    {
        public string Label { get; set; }
        /// <summary>
        /// Признак того, что заголовок выводиться только для систем автоматизированного чтения страниц
        /// </summary>
        public bool LabelSrOnly { get; set; } = false;

        public virtual ahsInputs Input { get; set; }

        /// <summary>
        /// Пояснение для поля. Подсказка
        /// </summary>
        public string HelpCaption { get; set; }

        public string AddedWrapCSS { get; set; }

        public bmTwinSizingsEnum SizeInput { get; set; } = bmTwinSizingsEnum.NULL;

        /// <summary>
        /// Сообщение об успешной проверке для подсистемы валидации форм/моделей
        /// </summary>
        public string ValidFeedback { get; set; }

        /// <summary>
        /// Сообщение об ошибке для подсистемы валидации форм/моделей
        /// </summary>
        public string InvalidFeedback { get; set; }

        public bool IsHorisontalStyle { get; set; } = false;

        public override object Clone()
        {
            bmInput cloneableObject = base.Clone() as bmInput;
            cloneableObject.Input = Input.Clone() as ahsInputs;
            return cloneableObject;
        }
    }
}
