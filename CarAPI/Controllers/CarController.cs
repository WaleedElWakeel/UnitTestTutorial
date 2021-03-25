using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using CarAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace CarAPI.Controllers
{
    [Route("api/Car")]
    public class CarController : ApiController
    {
        public ICarService CarService { get; set; }
        public CarController(ICarService carService)
        {
            CarService = carService;
        }
        [HttpGet]
        public List<Car> Get()
        {
            return CarService.GetAll();
        }

        [HttpGet]
        [Route("{id:int}")]
        public Car Get(int id)
        {
            return CarService.GetCarById(id);
        }
       
        [HttpPost]
        public void Post([FromBody]Car car)
        {
            CarService.AddCar(car);
        }

    }
}
