using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swagger.WebMvc.Controllers
{
    /// <summary>
    /// 测评活动相关接口
    /// </summary>
    public class ActivityController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Activity
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取活动详情页面
        /// </summary>
        /// <param name="id">活动id</param>
        /// <returns></returns>
        // GET: Activity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// 创建活动页面
        /// </summary>
        /// <returns></returns>
        // GET: Activity/Create
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 创建活动
        /// </summary>
        /// <param name="collection">活动信息</param>
        /// <returns></returns>
        // POST: Activity/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 编辑活动页面
        /// </summary>
        /// <param name="id">活动id</param>
        /// <returns></returns>
        // GET: Activity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// 编辑活动
        /// </summary>
        /// <param name="id">活动id</param>
        /// <param name="collection">活动信息</param>
        /// <returns></returns>
        // POST: Activity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 删除活动页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Activity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="id">活动id</param>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Activity/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection=null)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
