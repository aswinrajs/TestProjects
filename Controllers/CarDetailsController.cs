using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CarDetailsController : ApiController
    {
        // GET api/cardetails
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]  
        public IEnumerable<CarsStock> GetAllCarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();

            List<CarsStock> li = new List<CarsStock>();
            ST.CarName = "Maruti Waganor";
            ST.CarPrice = "4 Lakh";
            ST.CarModel = "VXI";
            ST.CarColor = "Brown";

            ST1.CarName = "Maruti Swift";
            ST1.CarPrice = "5 Lakh";
            ST1.CarModel = "VXI";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
  
            return li;
        }


        // GET api/cardetails/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();

            if (id == 1)
            {

                ST.CarName = "Maruti Waganor";
                ST.CarPrice = "4 Lakh";
                ST.CarModel = "VXI";
                ST.CarColor = "Brown";
                li.Add(ST);  
            }
            else
            {
                ST1.CarName = "Maruti Swift";
                ST1.CarPrice = "5 Lakh";
                ST1.CarModel = "VXI";
                ST1.CarColor = "RED";
                li.Add(ST1);  
            }
            return li;
        }

        // POST api/cardetails
        [HttpPost] 
        public void Post([FromBody]CarsStock cs)
        {
        }

        // PUT api/cardetails/5
        [HttpPut]  
        public void Put(int id, [FromBody]CarsStock cs)
        {
        }

        // DELETE api/cardetails/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
