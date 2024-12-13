using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_SPM.DataModels
{
    public  class Models
    {
        public class LaxvenSpeedometerModel
        {

            public LaxvenSpeedometerModel(Boolean IsPressureinPSI = true)
            {
                this._IsPressureinPSI = IsPressureinPSI; 
            }

            bool _IsPressureinPSI = false;

            public DateTime RunDateAndTime { get; set; }
            public Single TrainSpeed { get; set; }
            public Single DistanceCounter { get; set; }
            public Single TractiveEffort { get; set; }
            public Single GeneratedPower { get; set; }
            public Single BPpressure { get; set; }
            public Single BCpressure { get; set; }
            public Single TL24voltage { get; set; }
            public string ReverserPosition { get; set; }
            public string Throttle { get; set; }
            public Boolean Horn { get; set; }
            public Boolean Headlight1 { get; set; }
            public Boolean Headlight2 { get; set; }
            public Boolean PCSpickedup { get; set; }
            public Boolean PenalyBrakeApplied { get; set; }

            public double BPpressureMetric { get { return PressureModifierToMetric(BPpressure, _IsPressureinPSI); } }
            public double BCpressureMetric { get { return PressureModifierToMetric(BCpressure, _IsPressureinPSI); } }
        }

        public class MedhaSpeedometerModel
        {
            public LaxvenSpeedometerModel(Boolean IsPressureinPSI = true)
            {
                this._IsPressureinPSI = IsPressureinPSI;
            }

            bool _IsPressureinPSI = false;

            public DateTime Rundate { get; set; }
            public TimeSpan Runtime { get;set }
            public Single TrainSpeed { get; set; }
            public Single DistanceCounter { get; set; }
            public Single TractiveEffort { get; set; }
            public Single GeneratedPower { get; set; }
            public Single BPpressure { get; set; }
            public Single BCpressure { get; set; }
            public Single TL24voltage { get; set; }
            public string ReverserPosition { get; set; }
            public string Throttle { get; set; }
            public Boolean Horn { get; set; }
            public Boolean Headlight1 { get; set; }
            public Boolean Headlight2 { get; set; }
            public Boolean PCSpickedup { get; set; }
            public Boolean PenalyBrakeApplied { get; set; }

            public DateTime RunDateAndTime { get { return Rundate.Add(Runtime); } }

            public double BPpressureMetric { get { return PressureModifierToMetric(BPpressure, _IsPressureinPSI); } }
            public double BCpressureMetric { get { return PressureModifierToMetric(BCpressure, _IsPressureinPSI); } }

        }

        private static double PressureModifierToMetric(Single PressureInPSI, Boolean IsBritishSystem )
        {
            if (IsBritishSystem)
            {
                return Math.Round((PressureInPSI * 0.070307), 2);
            } else return PressureInPSI;
        }

    }
}
