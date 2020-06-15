using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSvgHelper.Classes.Attributes;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class animateTransform
    {
        public string id { get; set; } = null;
        public string attributeName { get; set; } = null;
        public string attributeType { get; set; } = null;
        public string type { get; set; } = null;
        public double by { get; set; } = double.NaN;
        public double dur { get; set; } = double.NaN;
        public string repeatCount { get; set; } = null;
        public string values { get; set; } = null;
        public string keyTimes { get; set; } = null;

        //[PropertyName("xlink:href")] public string href { get; set; }

        public string fill { get; set; } = null;
        public string begin { get; set; } = null;
        public string to { get; set; } = null;
        public string restart { get; set; } = null;
        public string additive { get; set; } = null;
        public string accumulate { get; set; } = null;
    }
}