using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using Newtonsoft.Json;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.FixedData
{
    public class CpuSpecs : IFixedData
    {
        #region Fields

        private static SpecDetails _specDetails; 
        //  private SpecSimple _specSimple;
        private string _name;

        #endregion

        #region Methods

        #region Return type ones

        public SpecDetails GetDetails()
        {
            return _specDetails;
        }

        #endregion

        #region Setups

        public void SetSpecs()
        {
            _name = GetName();
            var txt = File.ReadAllText(@"src/db/cpu.json");
            var list = JsonConvert.DeserializeObject<List<SpecDetails>>(txt);
            _specDetails = list.FirstOrDefault(n => n.BiosNames.Contains(_name));
        }

        private string GetName()
        {
            var mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            var name = "";
            foreach (var mo in mos.Get())
            {
                name = mo["Name"].ToString();
            }

            return name.Split(' ').Where(n => n != "" && n != " " && n != "\n").Aggregate("", (current, n) => current + $@" {n}")
                .Trim();
        }

        #endregion

        #endregion

        #region Custom Classes

        public class SpecSimple
        {

        }

        public class SpecDetails
        {
            // Names
            public string FullName { get; set; }
            public string BiosNames { get; set; }
            public string Manufacturer { get; set; }
            public string Family { get; set; }
            public string Series { get; set; }
            public string Model { get; set; }

            //Physical
            public string Socket { get; set; }
            public string Foundry { get; set; }
            public string Lithography { get; set; }
            public string Transistors { get; set; }
            public string DieSize { get; set; }
            public string Package { get; set; }
            public string MaxTemp { get; set; }

            //Performance
            public string Clock { get; set; }
            public string Boost { get; set; }
            public string BaseClock { get; set; }
            public string Multiplier { get; set; }
            public string Unlocked { get; set; }
            public string Voltage { get; set; }
            public string Tdp { get; set; }

            //Architecture
            public string Market { get; set; }
            public string Status { get; set; }
            public string Released { get; set; }
            public string CodeName { get; set; }
            public string Generation { get; set; }
            public string Part { get; set; }
            public string Memory { get; set; }

            //Cores
            public string Cores { get; set; }
            public string Threads { get; set; }
            public string SmpCpu { get; set; }
            public string Gpu { get; set; }

            //Cache
            public string L1 { get; set; }
            public string L2 { get; set; }
            public string L3 { get; set; }

            //Features
            public string Features { get; set; }
        }

        #endregion
    }
}