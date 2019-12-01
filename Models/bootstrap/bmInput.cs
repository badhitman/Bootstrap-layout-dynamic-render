////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;

namespace BootstrapAspDynamicRender.models
{
    public class bmInput
    {
        /// <summary>
        /// Дополнительные обязательные/статичные классы стилей к form-group
        /// </summary>
        public string AddedClassesCSS { get; set; }

        public string Label { get; set; }
        /// <summary>
        /// Признак того, что заголовок выводиться только для систем автоматизированного чтения страниц
        /// </summary>
        public bool LabelSrOnly { get; set; } = false;
        
        public virtual ahsInputs Input { get; set; }
        /// <summary>
        /// Дополнительные классы стилей для input
        /// </summary>
        public string CustomStyleInput { get; set; }

        /// <summary>
        /// Пояснение для поля. Подсказка
        /// </summary>
        public string HelpCaption { get; set; }

        public bmTwinSizingsEnum SizeInput { get; set; } = bmTwinSizingsEnum.NULL;

        /// <summary>
        /// Сообщение об успешной проверке для подсистемы валидации форм/моделей
        /// </summary>
        public string ValidFeedback { get; set; }

        /// <summary>
        /// Сообщение об ошибке для подсистемы валидации форм/моделей
        /// </summary>
        public string InvalidFeedback { get; set; }
    }
}
