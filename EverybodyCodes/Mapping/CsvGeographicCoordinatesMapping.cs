using EverybodyCodes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace EverybodyCodes.Mapping
{
    public class CsvGeographicCoordinatesMapping : CsvMapping<GeographicCoordinatesModel>
    {
        public CsvGeographicCoordinatesMapping() : base()
        {
            MapProperty(0, p => p.Camera);
            MapProperty(1, p => p.Latitude);
            MapProperty(2, p => p.Longitude);
        }
    }
}
