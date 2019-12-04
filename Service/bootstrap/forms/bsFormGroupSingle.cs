////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;
using System.Globalization;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Группирующая обёртка для вывода одного поля формы
    /// </summary>
    public class bsFormGroupSingle : absFormGroup
    {
        /// <summary>
        /// Настраиваемый Input
        /// </summary>
        public bmInput CustomInput { get; set; } = UseCustomisation ? new bmCustomInput() : new bmInput();
        ahsInputs wInput;

        /// <summary>
        /// Признак того, что Label с Input размещены в одной горизонтли
        /// </summary>
        public bool IsHorisontal { get; set; } = false;

        hsLabelInput Label;
        string HelpCaptionId;

        public override ahsDom[] GetChilds()
        {
            ChildsNodes.Clear();
            //
            Label = new hsLabelInput() { Header = CustomInput.Label, For = CustomInput.Input.ID };
            if (CustomInput.LabelSrOnly)
                Label.AddCSS("sr-only");

            HelpCaptionId = CustomInput.Input.ID + "-" + nameof(CustomInput.HelpCaption);
            wInput = CustomInput.Input.Clone() as ahsInputs;
            /*
             if (UseCustomisation)
                    groupSingle.CustomInput = new bmCustomInput(input);
                else
                    groupSingle.CustomInput = input.Clone() as bmInput;
             */
            //
            if (CustomInput.SizeInput != bmTwinSizingsEnum.NULL)
            {
                string SizeInputAsString = CustomInput.SizeInput.ToString().ToLower(CultureInfo.CurrentCulture);
                if (CustomInput is bmCustomInput && CustomInput.Input is hsInputSelect)
                {
                    wInput.AddCSS("custom-select-" + SizeInputAsString);
                }
                else
                {
                    wInput.AddCSS("form-control-" + SizeInputAsString);
                }

                if (IsHorisontal && !(CustomInput.Input is hsInputFile))
                {
                    Label.AddCSS("col-form-label-" + SizeInputAsString);
                }
            }

            if (!string.IsNullOrWhiteSpace(CustomInput.HelpCaption))
            {
                wInput.SetAttribute("aria-describedby", HelpCaptionId);
            }

            if (CustomInput is bmCustomInput)
            {
                WriteCustomDomSingle();
            }
            else
            {
                if (CustomInput.Input is hsInputFile)
                {
                    wInput.AddCSS("form-control-file");
                }
                else if (CustomInput.Input is hsInputRange)
                {
                    wInput.AddCSS("form-control-range");
                }
                else if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
                {
                    wInput.AddCSS("form-check-input");
                    if (string.IsNullOrEmpty(CustomInput.Label))
                    {
                        wInput.AddCSS("position-static");
                    }
                    else
                    {
                        Label.AddCSS("form-check-label");
                    }
                }
                else
                {
                    if (CustomInput.Input is bsPlainTextInput)
                        wInput.AddCSS("form-control-plaintext");
                    else
                        wInput.AddCSS("form-control");
                }

                if (!IsHorisontal)
                {
                    if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
                    {
                        WriteDomNormalSingleCheckable();
                    }
                    else
                    {
                        WriteDomNormalSingle();
                    }
                }
                else
                {
                    if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
                    {
                        WriteDomHorisontalSingleCheckable();
                    }
                    else
                    {
                        WriteDomHorisontalSingle();
                    }
                }
            }

            return base.GetChilds();
        }

        /// <summary>
        /// Кастомный Bootstrap Input
        /// </summary>
        private void WriteCustomDomSingle()
        {
            if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
            {
                wInput.AddCSS("custom-control-input");
                Label.AddCSS("custom-control-label");
            }
            else
            {
                if (CustomInput.Input is hsInputSelect)
                {
                    wInput.AddCSS("custom-select");
                }
                else if (CustomInput.Input is hsInputRange)
                {
                    wInput.AddCSS("custom-range");
                }
                else if (CustomInput.Input is hsInputFile)
                {
                    wInput.AddCSS("custom-file-input");
                    Label.AddCSS("custom-file-label");
                }
                else
                {
                    //wInput.AddCSS("custom-control-input");
                }
            }

            if (IsHorisontal)
            {
                hsDiv LabelDiv = new hsDiv().AddCSS("col-sm-2") as hsDiv;
                hsDiv InputDiv = new hsDiv().AddCSS("col-sm-10") as hsDiv;

                if (!(CustomInput.Input is hsInputFile))
                {
                    Label.AddCSS("col-form-label");
                }

                if (!string.IsNullOrEmpty(CustomInput.Label) && !(CustomInput.Input is hsInputFile))
                {
                    LabelDiv.ChildsNodes.Add(Label);
                }
                else
                {
                    LabelDiv.ChildsNodes.Add(new hsP(" "));
                }

                InputDiv.ChildsNodes.Add(wInput);

                if (CustomInput.Input is hsInputFile)
                {
                    InputDiv.ChildsNodes.Add(Label);
                }
                if (!string.IsNullOrEmpty(CustomInput.HelpCaption))
                {
                    InputDiv.ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption).AddCSS("form-text text-muted"));
                }
                ChildsNodes.Add(LabelDiv);
                ChildsNodes.Add(InputDiv);
            }
            else
            {
                if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
                {
                    hsDiv div = new hsDiv().AddCSS("custom-control") as hsDiv;
                    if (CustomInput.IsHorisontalStyle)
                    {
                        div.AddCSS("custom-control-inline");
                    }

                    if (CustomInput.Input is bsSwitchInput)
                    {
                        div.AddCSS("custom-switch");
                    }
                    else if (CustomInput.Input is hsInputCheckbox)
                    {
                        div.AddCSS("custom-checkbox");
                    }
                    else if (CustomInput.Input is hsInputRadio)
                    {
                        div.AddCSS("custom-radio");
                    }

                    div.AddChild(wInput);
                    if (string.IsNullOrEmpty(CustomInput.Label))
                    {
                        wInput.AddCSS("position-static");
                    }
                    else
                    {
                        div.AddChild(Label);
                    }

                    if (!string.IsNullOrWhiteSpace(CustomInput.HelpCaption))
                    {
                        div.AddChild(new hsSmall(CustomInput.HelpCaption) { ID = HelpCaptionId }.AddCSS("form-text text-muted"));
                    }
                    ChildsNodes.Add(div);
                }
                else
                {
                    if (CustomInput.Input is hsInputSelect)
                    {
                        wInput.AddCSS("custom-select");
                    }
                    else if (CustomInput.Input is hsInputRange)
                    {
                        wInput.AddCSS("custom-range");
                    }
                    else if (CustomInput.Input is hsInputFile)
                    {
                        Label.AddCSS("custom-file-label");
                        wInput.AddCSS("custom-file-input");
                    }
                    else
                    {
                        wInput.AddCSS("form-control");
                    }
                    if (!string.IsNullOrEmpty(CustomInput.Label))
                    {
                        ChildsNodes.Add(Label);
                    }
                    ChildsNodes.Add(wInput);
                    if (!string.IsNullOrWhiteSpace(CustomInput.HelpCaption))
                    {
                        ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption) { ID = HelpCaptionId }.AddCSS("form-text text-muted"));
                    }
                }
            }
        }

        /// <summary>
        /// Вертикально обычный Input (не Checkable)
        /// </summary>
        private void WriteDomNormalSingle()
        {
            if (!string.IsNullOrEmpty(Label.Header))
                ChildsNodes.Add(Label);

            ChildsNodes.Add(wInput);

            if (!string.IsNullOrEmpty(CustomInput.HelpCaption))
            {
                ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption).AddCSS("form-text text-muted"));
            }
        }

        /// <summary>
        /// Горизонтально обычный Input (не Checkable)
        /// </summary>
        private void WriteDomHorisontalSingle()
        {
            hsDiv LabelDiv = new hsDiv().AddCSS("col-sm-2") as hsDiv;
            hsDiv InputDiv = new hsDiv().AddCSS("col-sm-10") as hsDiv;
            //Label.AddCSS("col-form-label");

            LabelDiv.ChildsNodes.Add(Label);
            ChildsNodes.Add(LabelDiv);
            InputDiv.ChildsNodes.Add(wInput);
            if (!string.IsNullOrEmpty(CustomInput.HelpCaption))
            {
                InputDiv.ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption).AddCSS("form-text text-muted"));
            }
            ChildsNodes.Add(InputDiv);
        }

        /// <summary>
        /// Checkable - Label следом справа от Input
        /// </summary>
        private void WriteDomNormalSingleCheckable()
        {
            hsDiv div = new hsDiv().AddCSS("form-check") as hsDiv;
            if (CustomInput.IsHorisontalStyle)
            {
                div.AddCSS("form-check-inline");
            }
            div.ChildsNodes.Add(wInput);
            if (!string.IsNullOrEmpty(Label.Header))
                div.ChildsNodes.Add(Label);
            if (!string.IsNullOrEmpty(CustomInput.HelpCaption))
            {
                div.ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption).AddCSS("form-text text-muted"));
            }
            ChildsNodes.Add(div);
        }

        /// <summary>
        /// Checkable - Label слева отдельно (в "col-sm-2") от Input. Input справа в "col-sm-10"
        /// </summary>
        private void WriteDomHorisontalSingleCheckable()
        {
            hsDiv LabelDiv = new hsDiv().AddCSS("col-sm-2") as hsDiv;
            hsDiv InputDiv = new hsDiv().AddCSS("col-sm-10") as hsDiv;
            hsDiv div = new hsDiv().AddCSS("form-check") as hsDiv;
            if(CustomInput.IsHorisontalStyle)
            {
                div.AddCSS("form-check-inline");
            }
            div.ChildsNodes.Add(LabelDiv);
            div.ChildsNodes.Add(InputDiv);
            if (!string.IsNullOrEmpty(CustomInput.HelpCaption))
            {
                div.ChildsNodes.Add(new hsSmall(CustomInput.HelpCaption).AddCSS("form-text text-muted"));
            }
            ChildsNodes.Add(div);
        }

        public override string GetStringCSS()
        {
            if (IsHorisontal)
                AddCSS("row");
            else
                RemoveCSS("row");

            return (base.GetStringCSS()).Trim();
        }

        public override object Clone()
        {
            bsFormGroupSingle groupSingle = base.Clone() as bsFormGroupSingle;
            groupSingle.CustomInput = CustomInput.Clone() as bmInput;
            return groupSingle;
        }
    }
}
