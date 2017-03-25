using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Models
{
    class HistoricalData
    {
        public int CurrentStepNumberValue { get; internal set; }
        public string HeaderName { get; set; }
        public double? Value { get; set; }
        public int ColumnNumber { get; set; }
        public int RowNumber { get; set; }
    }
}
