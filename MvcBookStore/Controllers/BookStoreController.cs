﻿using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Controllers
{
    public class BookStoreController : Controller
    {
        // GET: BookStore
        private QLBanSachEntities db = new QLBanSachEntities();
        private List<SACH> Laysachmoi(int count)
        {
            return db.SACHes.OrderByDescending(s => s.Ngaycapnhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var sachmoi = Laysachmoi(5);
            return View(sachmoi);
        }

        public ActionResult ChuDe()
        {
            var chude = db.CHUDEs.ToList();
            return View(chude);
        }
        public ActionResult NXB()
        {
            var nxb = db.NHAXUATBANs.ToList();
            return View(nxb);
        }
        public ActionResult SPtheochude(int id)
        {
            var sach = db.SACHes.Where(s => s.MaCD == id).ToList();
            return View(sach);
        }
        public ActionResult SPtheoNXB(int id)
        {
            var sach = db.SACHes.Where(s => s.MaNXB == id).ToList();
            return View(sach);
        }
        public ActionResult Details(int id)
        {
            var sach = db.SACHes.Where(s => s.Masach == id).ToList();
            return View(sach.Single());
        }
    }
}