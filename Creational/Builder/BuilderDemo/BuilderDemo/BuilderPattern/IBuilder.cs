using System;
using BuilderDemo.Models;

namespace BuilderDemo.BuilderPattern
{
    public interface IBuilder
    {
        ComplexModule Result { get; }
        ModuleX ModuleX { get; }
        double Factor { get; set; }
        decimal InitialPrice { get; set; }
        bool IsInLimitedMode { get; set; }
        int ModuleX_x { get; set; }
        int ModuleX_y { get; set; }
        string ModuleY_name { get; set; }
        DateTime ModuleY_issueDate { get; set; }
    }
}
