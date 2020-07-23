using ODataSample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.API.Context
{
    public class RegionDbContext
    {
        public static List<Region> regions;
        public RegionDbContext()
        {
            regions = new List<Region>()
            {
            new Region
                {
                    Id = 1,
                    Name = "Asia",
                    Population = 300000000,
                    Countries = new List<Country>()
                    {
                        new Country{Id = 1, Name = "Japan"},
                        new Country{Id = 2, Name = "Taiwan"},
                        new Country{Id = 3, Name = "Thailand"}
                    }
                },
            new Region
                {
                    Id = 2,
                    Name = "Europe",
                    Population = 500000000,
                    Countries = new List<Country>()
                    {
                        new Country{Id = 4, Name = "Italy"},
                        new Country{Id = 5, Name = "Hungary"},
                        new Country{Id = 6, Name = "Spain"}
                    }
                },
            new Region
                {
                    Id = 3,
                    Name = "America",
                    Population = 900000000,
                    Countries = new List<Country>()
                    {
                        new Country{Id = 4, Name = "Colombia"},
                        new Country{Id = 5, Name = "Argentina"},
                        new Country{Id = 6, Name = "Cuba"}
                    }
                }
            };
        }

        public List<Region> GetAll()
        {
            return regions;
        }

        public Region GetById(int key)
        {
            return regions.First(x => x.Id.Equals(key));
        }
    }
}
