using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using eureka.client.config;

namespace eureka.client.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IConfigurationRoot _config;
        private readonly IOptionsSnapshot<dev> _configDemo;

        public ValuesController(IConfigurationRoot config, IOptionsSnapshot<dev> configDemo)
        {
            _config = config;
            _configDemo = configDemo;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", _configDemo.Value.Name };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
