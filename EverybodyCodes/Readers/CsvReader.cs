using EverybodyCodes.Mapping;
using EverybodyCodes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace EverybodyCodes.Readers
{
    public static class CsvReader
    {
        public static IEnumerable<CsvMappingResult<GeographicCoordinatesModel>> ReadGeographicCoordinates()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            var csvParser = new CsvParser<GeographicCoordinatesModel>(csvParserOptions, new CsvGeographicCoordinatesMapping());
            var records = csvParser.ReadFromFile(@"CsvData\cameras-defb.csv", Encoding.UTF8);

            return records;
        }
    }
}
