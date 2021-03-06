﻿using BlueSwitch.Base.Components.Base;
using BlueSwitch.Base.Components.Switches.Base;
using BlueSwitch.Base.Processing;

namespace BlueSwitch.Base.Components.Switches.Logic.Double
{
    class GreaterThanSwitch : SwitchBase
    {
        protected override void OnInitialize(Engine renderingEngine)
        {
            AddInput(typeof(double));
            AddInput(typeof(double));
            AddOutput(typeof(bool));

            DisplayName = "Double.GreaterThan";
            UniqueName = "BlueSwitch.Base.Components.Switches.Logic.Double.Double.GreaterThan";
            Description = "Checks if Double(x) is greater than Double(y)";
        }

        public override GroupBase OnSetGroup()
        {
            return Groups.LogicDouble;
        }

        protected override void OnProcessData<T>(Processor p, ProcessingNode<T> node)
        {
            var a = GetData(0);
            var b = GetData(1);

            if(a != null && b != null)
            {
                SetData(0, new DataContainer((double)a.Value > (double)b.Value));
            }

            base.OnProcessData(p, node);
        }
    }
}
