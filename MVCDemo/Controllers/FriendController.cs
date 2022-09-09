using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public List<Friend>? Friends { get; set; }
        public IActionResult Index()
        {
            List<Friend> Friends = FriendService.GetAll();
            return View(Friends);
        }
        public IActionResult Details(int id)
        {
            Friend f = FriendService.Get(id);
            return View(f);
        }

        public IActionResult List()
        {
            List<Friend> Friends = FriendService.GetAll();
            return View(Friends);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string name, string place)
        {
            Friend f = new Friend { FriendId = id, FriendName = name, Place = place };
            FriendService.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend f = FriendService.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(Friend f)
        {
            FriendService.Delete(f.FriendId);
            return RedirectToAction("Delete");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, string place)
        {
            Friend f = new Friend { FriendId = id, FriendName = name, Place = place };
            FriendService.Update(f);
            return RedirectToAction("List");
        }
    }
}

