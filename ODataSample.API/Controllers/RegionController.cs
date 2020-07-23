using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ODataSample.API.Context;
using ODataSample.API.Models;

namespace ODataSample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        public RegionDbContext context;
        public RegionController()
        {
            context = new RegionDbContext();
        }

        [HttpGet]
        [EnableQuery()]
        public List<Region> Get()
        {
            return context.GetAll();
        }
    }


}
