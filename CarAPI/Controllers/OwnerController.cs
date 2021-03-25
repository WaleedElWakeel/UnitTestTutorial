using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarAPI.Controllers
{
    [Route("api/Owner")]
    public class OwnerController : ApiController
    {
        public IOwnerService OwnerService { get; set; }
        public OwnerController(IOwnerService ownerService)
        {
            OwnerService = ownerService;
        }
        [HttpGet]
        public List<Owner> Get()
        {
            return OwnerService.GetOwners();
        }

        [HttpGet]
        [Route("{id:int}")]
        public Owner Get(int id)
        {
            return OwnerService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]Owner owner)
        {
            OwnerService.AddOwner(owner);
        }
    }
}
