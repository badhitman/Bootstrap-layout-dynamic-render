////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using System;

namespace BootstrapAspDynamicRender.models
{
    public class bmCustomInput : bmInput
    {

        private ahsInputs _Input;

        public override ahsInputs Input
        {
            get => _Input;
            set
            {
                if (value is hsInputCheckbox)
                {

                }
                else if (value is hsInputFile)
                {

                }
                else if (value is hsInputRadio)
                {

                }
                else if (value is hsInputRange)
                {

                }
                else if (value is hsInputSelect)
                {

                }
                else
                {
                    throw new ArgumentException("Недопустимый тип для пользовательского тега Input. Доступный перечень: hsInputCheckbox, hsInputRadio, hsInputRange, hsInputFile, hsInputSelect", nameof(Input));
                }

                _Input = value;
            }
        }

    }
}
