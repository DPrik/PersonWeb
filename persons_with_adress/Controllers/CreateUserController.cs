using AutoMapper;
using BLL.DTO;
using BLL.Service;
using Microsoft.AspNet.Identity;
using persons_with_adress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PersUI.Controllers
{
    public class CreateUserController : Controller
    {
        IService<UserDTO> db = new UserDTOService();


        public CreateUserController()
        {

        }

        public CreateUserController(IService<UserDTO> serv)
        {
            db = serv;
        }

        // GET: CreateUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            //  UserDTO user1 = new UserDTO() { RegId = user.Id, Id = 1 };
            // UserDTOService dt = new UserDTOService();

            // dt.Create(user1);

            return View();
        }
        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {

            user.RegId = User.Identity.GetUserId();
            Mapper.CreateMap<PersoneViewModel, PersonDTO>();
            Mapper.CreateMap<UserViewModel, UserDTO>();
            Mapper.CreateMap<AddressViewModel, AddressDTO>();
            Mapper.CreateMap<PhoneViewModel, PhoneDTO>();



            var value = Mapper.Map<UserViewModel, UserDTO>(user);


            db.Create(value);
            return RedirectToAction("Index", "User");
        }
    }
}