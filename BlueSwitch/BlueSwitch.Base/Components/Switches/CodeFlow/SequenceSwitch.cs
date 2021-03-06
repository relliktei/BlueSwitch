﻿using BlueSwitch.Base.Components.Base;
using BlueSwitch.Base.Components.Switches.Base;
using BlueSwitch.Base.Components.Types;
using BlueSwitch.Base.Components.UI;
using BlueSwitch.Base.Processing;

namespace BlueSwitch.Base.Components.Switches.CodeFlow
{
    public class SequenceSwitch : SwitchBase
    {
        protected override void OnInitialize(Engine renderingEngine)
        {
            UniqueName = "BlueSwitch.Base.Components.Switches.CodeFlow.Sequence";
            DisplayName = "Sequence";
            Description = "Sequence";

            AddInput(new ActionSignature());

            ActivateOutputAdd(new PinDescription(new ActionSignature(), UIType.None), 2);
            IsCompact = true;
        }

        public override GroupBase OnSetGroup()
        {
            return Groups.CodeFlow;
        }

        protected override void OnProcess<T>(Processor p, ProcessingNode<T> node)
        {
            base.OnProcess(p, node);
        }
    }
}
