using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural_DesignPattern.AdapterDesignPattern
{
   ///<summary>
   ///The 'ITarget' interface
   ///</summary>
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }

}
