using AutoMapper;
using BLL.DTO;
using BLL.Service;
using Microsoft.AspNet.Identity;
using persons_with_adress.Models;
using PersUI.Models;
using System;
using System.Collections.Generic;

using System.Web.Mvc;


namespace persons_with_adress.Controllers
{
    public class UserController : Controller
    {
        IService<UserDTO> db = new UserDTOService();


        public UserController()
        {

        }

        public UserController(IService<UserDTO> serv)
        {
            db = serv;
        }

        public ActionResult Index()
        {
            PersonDTOService db1 = new PersonDTOService();
            Mapper.CreateMap<PersonDTO, PersoneViewModel>();
            Mapper.CreateMap<UserDTO, UserViewModel>();
            Mapper.CreateMap<AddressDTO, AddressViewModel>();
            Mapper.CreateMap<PhoneDTO, PhoneViewModel>();
            Mapper.CreateMap<StreetDTO, StreetViewModel>();
            Mapper.CreateMap<CityDTO, CityViewModel>();
            Mapper.CreateMap<CountryDTO, CountryViewModel>();
            Mapper.CreateMap<CountryViewModel, CountryDTO>();

            var result = Mapper.Map<IEnumerable<PersonDTO>, List<PersoneViewModel>>(db1.GetAll());


            return View(result);

        }

        public ActionResult ShowProfile( UserViewModel id)
        {
            UserDTOService dto = new UserDTOService();
            UserViewModel model = Mapper.Map<UserDTO, UserViewModel>(dto.GetByRegId(User.Identity.GetUserId()));
            return PartialView(model);

        }
        
        public ActionResult Edit(int id)
        {
            PersonDTOService db1 = new PersonDTOService();
            var pers = db1.Get(id);
            Mapper.CreateMap<PersonDTO, PersoneViewModel>();
            Mapper.CreateMap<UserDTO, UserViewModel>();
            Mapper.CreateMap<AddressDTO, AddressViewModel>();
            Mapper.CreateMap<PhoneDTO, PhoneViewModel>();
            Mapper.CreateMap<StreetDTO, StreetViewModel>();
            Mapper.CreateMap<CityDTO, CityViewModel>();
            Mapper.CreateMap<CountryDTO, CountryViewModel>();

            var persone = Mapper.Map<PersonDTO, PersoneViewModel>(pers);



            return View("EditPerson", persone);
            
        }

        [HttpPost]
        public ActionResult Edit(PersoneViewModel person)
        {
            PersonDTOService db1 = new PersonDTOService();
            Mapper.CreateMap<PersoneViewModel, PersonDTO>();
            Mapper.CreateMap<UserViewModel, UserDTO>();
            Mapper.CreateMap<AddressViewModel, AddressDTO>();
            Mapper.CreateMap<PhoneViewModel, PhoneDTO>();
            Mapper.CreateMap<StreetViewModel, StreetDTO>();
            Mapper.CreateMap<CityViewModel, CityDTO>();
            Mapper.CreateMap<CountryViewModel, CountryDTO>();
            var value = Mapper.Map<PersoneViewModel, PersonDTO>(person);


            db1.Update(value);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
          
            
            return View();
        }

        [HttpPost]
        public ActionResult ModalCreate(PersoneViewModel person)
        {

            PersonDTOService db1 = new PersonDTOService();
            person.Id = 1;
            Mapper.CreateMap<PersoneViewModel, PersonDTO>();
            Mapper.CreateMap<UserViewModel, UserDTO>();
            Mapper.CreateMap<AddressViewModel, AddressDTO>();
            Mapper.CreateMap<PhoneViewModel, PhoneDTO>();
            Mapper.CreateMap<StreetViewModel, StreetDTO>();
            Mapper.CreateMap<CityViewModel, CityDTO>();
            Mapper.CreateMap<CountryViewModel, CountryDTO>();


            var value = Mapper.Map<PersoneViewModel, PersonDTO>(person);
           
            db1.Create(value);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult ModalCreate()
        {

            return PartialView();
        }

        public ActionResult ModalEdit(int id)

        {
            PersonDTOService db1 = new PersonDTOService();
            var pers = db1.Get(id);
            Mapper.CreateMap<PersonDTO, PersoneViewModel>();
            Mapper.CreateMap<UserDTO, UserViewModel>();
            Mapper.CreateMap<AddressDTO, AddressViewModel>();
            Mapper.CreateMap<PhoneDTO, PhoneViewModel>();
            Mapper.CreateMap<StreetDTO, StreetViewModel>();
            Mapper.CreateMap<CityDTO, CityViewModel>();
            Mapper.CreateMap<CountryDTO, CountryViewModel>();

            var persone = Mapper.Map<PersonDTO, PersoneViewModel>(pers);

            return PartialView(persone);
        }


    }
}

