////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System.Collections.Generic;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsFormGroupStacked : absFormGroup
    {
        public List<bmInput> CustomInputs { get; set; } = new List<bmInput>();

        public bool IsInline { get; set; } = false;

        public override ahsDom[] GetChilds()
        {
            ChildsNodes.Clear();
            bsFormGroupSingle groupSingle;
            foreach (bmInput input in CustomInputs)
            {
                groupSingle = new bsFormGroupSingle() { IsHorisontal = false };
                if (UseCustomisation)
                    groupSingle.CustomInput = new bmCustomInput(input);
                else
                    groupSingle.CustomInput = input.Clone() as bmInput;

                if (IsInline)
                {
                    groupSingle.CustomInput.IsHorisontalStyle = IsInline;
                    if (groupSingle.CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckableInputs)))
                    {
                        groupSingle.AddCSS("form-check-inline");
                        ChildsNodes.AddRange(groupSingle.GetChilds());
                    }
                    else
                    {
                        groupSingle.AddCSS(("col "+ input.AddedWrapCSS).Trim());
                        ChildsNodes.Add(groupSingle);
                    }
                }
                else
                {
                    ChildsNodes.AddRange(groupSingle.GetChilds());
                }

                
            }
            return base.GetChilds();
        }

        public override object Clone()
        {
            bsFormGroupStacked groupStacked = ((bsFormGroupStacked)base.Clone());
            groupStacked.CustomInputs = new List<bmInput>();
            foreach (bmInput input in CustomInputs.ToArray())
            {
                groupStacked.CustomInputs.Add(input.Clone() as bmInput);
            }
            return groupStacked;
        }

        public override string GetStringCSS()
        {
            if (IsInline)
                AddCSS("form-row");
            else
                RemoveCSS("form-row");

            return base.GetStringCSS();
        }
    }
}
