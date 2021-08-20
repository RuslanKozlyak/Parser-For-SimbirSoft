using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftProj.Core.DBConnection
{
    public interface IDBSettings
    {
        public string ConnectionString { get; set; }
    }
}
