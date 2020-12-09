using AutoMapper;
using DemoProject.Contracts;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        private readonly IMemberRepository _repo;
        private readonly IMapper _mapper;

        public MemberController(IMemberRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: MemberController
        public ActionResult Index()
        {
            var members = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Member>, List<MemberListViewModel>>(members);
            return View(model);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var member = _mapper.Map<Member>(model);
                var isSuccess = _repo.Create(member);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }
                ViewBag.successMessage = "Successfull";
                return View();
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View(model);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
