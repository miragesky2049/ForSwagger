using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Swagger.WebApi.Controllers
{
    /// <summary>
    /// 测评活动接口
    /// </summary>
    public class ActivityController : ApiController
    {
        /// <summary>
        /// 获取测评活动数组
        /// </summary>
        /// <returns></returns>
        // GET: api/Activity
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// 获取测评活动信息
        /// </summary>
        /// <param name="id">活动Id</param>
        /// <returns>活动接口返回值</returns>
        // GET: api/Activity/5
        public string Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// 更新测评活动1
        /// </summary>
        /// <param name="value">活动名称</param>
        // POST: api/Activity
        public void Post([FromBody]string value)
        {
        }
        /// <summary>
        /// 更新测评活动2
        /// </summary>
        /// <param name="id">活动Id</param>
        /// <param name="value">活动名称</param>
        // PUT: api/Activity/5
        public void Put(int id, [FromBody]string value=null)
        {
        }
        /// <summary>
        /// 删除测评活动
        /// </summary>
        /// <param name="id">活动Id</param>
        // DELETE: api/Activity/5
        public void Delete(int id)
        {
        }
    }
}
