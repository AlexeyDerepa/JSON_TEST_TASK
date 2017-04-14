using JSON_TEST_TASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSON_TEST_TASK.Controllers
{
    public class CarsController : ApiController
    {
        // GET api/cars
        public IEnumerable<Car> Get()
        {
            return new List<Car> {
                new Car { maker = "VW", model = "Golf" }, new Car { maker = "Honda", model = "CRX" },
                new Car {maker="Toyouta",model="Prius"}, new Car{maker="Toyouta",model="Camry"},
                new Car {maker="Honda",model="Civic"}, new Car{maker="VW",model="Passat"}
            };
        }

        // GET api/cars/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cars
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cars/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cars/5
        public void Delete(int id)
        {
        }
    }
}
