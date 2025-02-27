﻿using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]//-->göndermek
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);
            return Ok(createdBrandResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());
        }
    }
}
