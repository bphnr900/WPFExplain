using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace wpfSample04.Models
{
    class GcodeStore
    {
        public ObservableCollection<Gcode> Gcodes { get; set; }

        public GcodeStore()
        {
            this.Gcodes = new ObservableCollection<Gcode>();
            this.Gcodes = new ObservableCollection<Gcode>(Enumerable.Range(0, 99).Select(i => new Gcode
            {
                ID = i,
                Model = i % 2 == 0 ? "501F" : "701F",
                Code = i % 2 == 0 ? "G5FQTRA" + i.ToString() : "G7FQTRA" + i.ToString(),
            }).ToList());
        }
    }
}
