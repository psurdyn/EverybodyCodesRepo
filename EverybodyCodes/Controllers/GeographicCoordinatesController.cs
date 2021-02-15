using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverybodyCodes.Models;
using EverybodyCodes.Readers;
using EverybodyCodesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TinyCsvParser.Mapping;

namespace EverybodyCodes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographicCoordinatesController : ControllerBase
    {
        public IEnumerable<GeographicCoordinatesModel> GeographicCoordinates { get; set; }

        public GeographicCoordinatesController()
        {
            GeographicCoordinates = CsvReader.ReadGeographicCoordinates()
                .Select(gc => gc.Result);
        }

        [HttpGet("all")]
        public IEnumerable<GeographicCoordinatesExtendedModel> GetAllUnformatted()
        {
            return GeographicCoordinates.Select(gc => new GeographicCoordinatesExtendedModel
            {
                CameraNumber = Int32.Parse(gc.Camera.Split('-').LastOrDefault()),
                Camera = gc.Camera,
                Latitude = gc.Latitude,
                Longitude = gc.Longitude
            });
        }

        [HttpGet("all/formatted")]
        public IList<string> GetAllFormatted()
        {
            List<string> resultList = new List<string>();

            foreach (var row in GeographicCoordinates.Where(gc => gc != null))
            {
                var cameraNum = row.Camera.Split('-').LastOrDefault();
                resultList.Add($"{cameraNum} | {row.Camera} | {row.Latitude} | {row.Longitude}");
            }

            return resultList;
        }




    }
}