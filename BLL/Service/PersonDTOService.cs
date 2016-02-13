using System.Collections.Generic;
using BLL.DTO;
using AutoMapper;
using DAL.Entities;
using DAL.Repository;
using System.Data.Entity;
using DAL.EF;
using System;

namespace BLL.Service
{
    public class PersonDTOService : IService<PersonDTO>
    {

        private PersonRepository _Repository;
        UserContext context = new UserContext();
        public PersonDTOService()
        {
            _Repository = new PersonRepository();
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

        public void Create(PersonDTO item)
        {
            _Repository.Create(Mapper.Map<PersonDTO, Person>(item));
        }

        public void Delete(int id)
        {
            PersonDTO person = Mapper.Map<Person, PersonDTO>(_Repository.Get(id));
            if (person != null)
            {
                _Repository.Delete(id);
                //_personRepository.Save();
            }
        }


        public PersonDTO Get(int id)
        {
            return Mapper.Map<Person, PersonDTO>(_Repository.Get(id));
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            IEnumerable<PersonDTO> var = Mapper.Map<IEnumerable<Person>, List<PersonDTO>>(_Repository.GetAll());
            return Mapper.Map<IEnumerable<Person>, List<PersonDTO>>(_Repository.GetAll());
        }


        public void Update(PersonDTO item)
        {
            _Repository.Update(Mapper.Map<PersonDTO, Person>(item));

           
            }

        public PersonDTO GetbyRegId(string Id)
        {
            throw new NotImplementedException();
        }
    }
    }





