using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cangul.EducationApp.Business.Concrete;
using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cangul.EducationApp.WebUI.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        private readonly  IMapper _mapper;

        public TestController(ITestService testService,IMapper mapper)
        {
            _testService = testService;
            _mapper = mapper;
        }
        public async Task<IActionResult> LoadData()
        {
            return Json(await _testService.GetAllAsync());
        }

        public async Task<IActionResult> Index()
        {
            var a = await _testService.GetAllAsync();
            return  View();
        }

       
        public async Task<IActionResult> Create()
        {
            return  View(new TestAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(TestAddDto model)
        {
            if (ModelState.IsValid)
            {
                await _testService.AddAsync(new Test()
                {
                    Name = model.Name,
                    Description=model.Description,
                    ExamDate=model.ExamDate,
                }) ;
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            TempData["id"] = id;
            return View(_mapper.Map<TestUpdateDto>(await _testService.FindByIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Update(TestUpdateDto model)
        {
            if (model.Id != (int)TempData["id"])
            {
              return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
               return View(model);
            }

            await _testService.UpdateAsync(_mapper.Map<Test>(model));

            return View(nameof(Index));
        }

       
        public async Task<IActionResult> Delete(int id)
        {
          await  _testService.RemoveAsync(new Test { Id = id });
            return Json(null);
        }

    }
}
