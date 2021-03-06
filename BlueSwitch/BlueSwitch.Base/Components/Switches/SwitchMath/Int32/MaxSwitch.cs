﻿using System;
using BlueSwitch.Base.Components.Base;
using BlueSwitch.Base.Components.Switches.Base;
using BlueSwitch.Base.Components.UI;
using BlueSwitch.Base.Processing;

namespace BlueSwitch.Base.Components.Switches.SwitchMath.Int32
{
    public class MaxSwitch : SwitchBase
    {
        public override GroupBase OnSetGroup()
        {
            return Groups.Math;
        }

        protected override void OnInitialize(Engine renderingEngine)
        {
            base.OnInitialize(renderingEngine);

            UniqueName = "BlueSwitch.Base.Components.Switches.SwitchMath.Int32.Max";
            DisplayName = "Int32.Max";
            Description = "Calculates the maximum of the given integers.";

            ActivateInputAdd(new PinDescription(typeof(int), UIType.TextEdit) { IsDecimalNumber = false, IsNumeric = true}, 2);
            
            AddOutput(typeof(int));
        }

        protected override void OnInitializeMetaInformation(Engine engine)
        {
            engine.SearchService.AddTags(this, new string[] { "Math", "Calculation", "Max", "Maximum", "Int32" });
        }

        protected override void OnProcessData<T>(Processor p, ProcessingNode<T> node)
        {
            base.OnProcessData(p, node);

            int result = int.MinValue;
            for (int i = 0; i < TotalInputs; i++)
            {
                int value = GetDataValueOrDefault<int>(i);
                result = Math.Max(value, result);
            }

            SetData(0, new DataContainer(result));
        }
    }
}
