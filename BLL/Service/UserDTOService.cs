using AutoMapper;
using BLL.DTO;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace BLL.Service
{
    public class UserDTOService : IService<UserDTO>
    {

        IRepository<User> db = new UserRepository();
        UserContext context = new UserContext();

        private UserRepository _Repository;
        public UserDTOService()
        {
            _Repository = new UserRepository();
            Mapper.CreateMap<UserDTO, User>();
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<PersonDTO, Person>()/*.ForMember(g => g._Id, opt => opt.Ignore())*/;
            Mapper.CreateMap<Person, PersonDTO>();
            Mapper.CreateMap<PhoneDTO, Phone>();
            Mapper.CreateMap<Phone, PhoneDTO>();
            Mapper.CreateMap<AddressDTO, Address>();
            Mapper.CreateMap<Address, AddressDTO>();
            Mapper.CreateMap<StreetDTO, Street>();
            Mapper.CreateMap<Street, StreetDTO>();
            Mapper.CreateMap<CityDTO, City>();
            Mapper.CreateMap<City, CityDTO>();
            Mapper.CreateMap<CountryDTO, Country>();
            Mapper.CreateMap<Country, CountryDTO>();
        }




        public void Create(UserDTO item)
        {

            _Repository.Create(Mapper.Map<UserDTO, User>(item));

        }

        public void Delete(int id)
        {


            UserDTO user = Mapper.Map<User, UserDTO>(_Repository.Get(id));
            if (user != null)
            {
                _Repository.Delete(id);
                //_personRepository.Save();
            }
        }

        public UserDTO Get(int id)
        {
            return Mapper.Map<User, UserDTO>(_Repository.Get(id));

        }

        public IEnumerable<UserDTO> GetAll()
        {
            IEnumerable<UserDTO> var = Mapper.Map<IEnumerable<User>, List<UserDTO>>(_Repository.GetAll());
            return Mapper.Map<IEnumerable<User>, List<UserDTO>>(_Repository.GetAll());
        }

        public void Update(UserDTO item)
        {
            _Repository.Update(Mapper.Map<UserDTO, User>(item));
            
        }
        public UserDTO GetByRegId(string id)
        {
            return Mapper.Map<User, UserDTO>(_Repository.GetByRegId(id));
        }

        public UserDTO GetbyRegId(string Id)
        {
            return Mapper.Map<User, UserDTO>(_Repository.GetByRegId(Id));
        }
    }

}
