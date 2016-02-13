using AutoMapper;
using BLL.DTO;
using BLL.Service;
using Microsoft.AspNet.Identity;
using persons_with_adress.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PersUI.Controllers
{
    public class UserProfileController : Controller
    {
        IService<UserDTO> db = new UserDTOService();


        public UserProfileController()
        {

        }

        public UserProfileController(IService<UserDTO> serv)
        {
            db = serv;
        }

        public ActionResult Index()
        {
            UserDTOService db1 = new UserDTOService();
          
            Mapper.CreateMap<UserDTO, UserViewModel>();
            Mapper.CreateMap<UserViewModel, UserDTO>();
            

            var result = Mapper.Map<IEnumerable<UserDTO>, List<UserViewModel>>(db1.GetAll());

           return PartialView();
           // return View();
        
        }
    }
}