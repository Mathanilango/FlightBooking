using Adminservice.Dto;
using Adminservice.Interface;
using Adminservice.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adminservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IMapper _Imapper;
        private readonly IAdmin _Iadmin;
        
        public AdminController(IMapper mapper, IAdmin iadmin)
        {
            _Imapper = mapper;
            _Iadmin = iadmin;
        }
        [HttpPost("AddAirline")]
        public async Task<ActionResult<string>> AddAirline(AirlineDto airlineDto)
        {
            var result = _Imapper.Map<AirlineDto, Airline>(airlineDto);
            return _Iadmin.addairline(result);
        }
        [HttpPost("AddFlight")]
        public async Task<ActionResult<string>> AddFlight(FlightDto flightDto)
        {
            var result = _Imapper.Map<FlightDto, Flight>(flightDto);
            return _Iadmin.addflight(result);
        }
        [HttpGet("Searchairline")]
        public async Task<Airline[]> searchairline(int airlineno)
        {
            
            return _Iadmin.searchflight(airlineno);
        }
        [HttpGet("getallairline")]
        public async Task<Airline[]> getallairline()
        {

            return _Iadmin.getallairline();
        }
        [HttpGet("getflight")]
        public async Task<Flight[]> getflight(int airlineno)
        {

            return _Iadmin.getflight(airlineno);
        }
        [HttpPost("BlockAirline")]
        public async Task<ActionResult<string>> BlockAirline(int Flightnumber)
        {
            return _Iadmin.blockairline(Flightnumber);
        }
        [HttpPost("UnBlockAirline")]
        public async Task<ActionResult<string>> UnBlockAirline(int Flightnumber)
        {
            return _Iadmin.Unblockairline(Flightnumber);
        }
        [HttpPost("ScheduleFlight")]
        public async Task<ActionResult<string>> ScheduleFlight(Flight ft)
        {
            return _Iadmin.scheduleflight(ft);
        }
       
       
    }
}
