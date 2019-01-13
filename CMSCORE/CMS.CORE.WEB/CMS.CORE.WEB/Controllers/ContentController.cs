using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.CORE.WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CMS.CORE.WEB.Controllers
{
    public class ContentController : Controller
    {
        private Content _content = null;
        public ContentController(IOptions<Content> option)
        {
            _content = option.Value;
        }

        // GET: Content
        public ActionResult Index()
        {
            return View(new ContentViewModel()
            {
                Contents = new List<Content>()
                {
                    _content,_content
                }
            });
            //var contents = new List<Content>();
            //for (int i = 0; i < 11; i++)
            //{
            //    contents.Add(new Content
            //    {
            //        Id = i,
            //        title = $"{i}的标题",
            //        content = $"{i}的内容",
            //        status = 1,
            //        add_time = DateTime.Now.AddDays(-i)
            //    });
            //}
            //return View(new ContentViewModel { Contents = contents });
        }

        // GET: Content/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Content/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Content/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Content/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Content/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Content/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Content/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}