﻿using System.Collections.Generic;
using ServiceStack;
using dsnybff.ServiceModel.Types;

namespace dsnybff.ServiceModel
{
    [Route("/locations")]
    [Route("/{Topic}/locations")]
    public class GetLocations : IReturn<IEnumerable<Location>>
    {
        public string Topic { get; set; }
    }

    [Route("/locations/reload")]
    public class ReloadLocations : IReturn<IEnumerable<Location>>
    { }

    public class LocationResponse
    {
        public IEnumerable<Location> Items { get; set; }
    }
}
