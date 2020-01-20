using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace MyMVC.ApiControllers
{
    [Route("api/values")]
    public class ValuesController : ApiController
    {
        private readonly List<Value> _values;

        public ValuesController()
        {
            _values = new List<Value>
            {
                new Value
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Значение 1"
                },
                new Value
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Значение 2"
                }
            };
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(_values);
        }
    }

    public class Value
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
