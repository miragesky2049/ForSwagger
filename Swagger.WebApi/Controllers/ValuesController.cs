using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Swagger.WebApi.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// get对象数组
        /// </summary>
        /// <returns></returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// get对象-我是接口描述信息
        /// </summary>
        /// <param name="id">数据Id-我是参数说明</param>
        /// <returns>我是返回值说明</returns>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// post对象-我是接口描述信息
        /// </summary>
        /// <param name="value">参数value-我是参数说明</param>
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// put对象-我是接口描述信息
        /// </summary>
        /// <param name="id">数据Id-我是参数</param>
        /// <param name="value">参数value-我是参数说明</param>
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// dele对象-我是接口描述信息
        /// </summary>
        /// <param name="id">数据Id-我是参数说明</param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
