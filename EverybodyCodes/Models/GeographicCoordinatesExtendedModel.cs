using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverybodyCodesApi.Models
{
    public class GeographicCoordinatesExtendedModel
    {
        public int CameraNumber { get; set; }
        public string Camera { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
