using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Temples.DataEntities.Models;
using Temples.Services.Interfaces;
using Temples.ViewMapper.ModelEntities;

namespace Temples.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TempleController : ControllerBase
    {
        private readonly ITempleService _templeService;
        private readonly IMapper _mapper;

        public TempleController(ITempleService templeService, IMapper mapper)
        {
            _templeService = templeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {

            try
            {
                List<Temple> templeList = new List<Temple>();
                List<TempleViewModel> templeViewList = new List<TempleViewModel>();

                templeList = _templeService.GetMajorTemples().ToList();

                if (templeList == null) return NotFound("Could not find any result");

                return Ok(templeList);
               // return Ok(_mapper.Map<TempleViewModel>(templeList));
            }
            catch (Exception ex)
            {
                return BadRequest("Could not retrieve result");
            }           

        }

    }
}