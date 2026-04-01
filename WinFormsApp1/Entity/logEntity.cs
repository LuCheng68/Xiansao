using Dm;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Entity
{
    [SugarTable("xs_log")]
    internal class logEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int lid { get; set; }
        public string userName { get; set; }
        public DateTime logTime { get; set; }
        public int logLevel { get; set; }
        public string deviceSouce { get; set; }
        public string logCentene { get; set; }
    }
}
