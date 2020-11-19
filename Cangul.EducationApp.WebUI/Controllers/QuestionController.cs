using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DTO.Question;
using Cangul.EducationApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cangul.EducationApp.WebUI.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly ITopicService _topicService;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionService questionService, IMapper mapper,ITopicService topicService)
        {
            _topicService = topicService;
            _questionService = questionService;
            _mapper = mapper;
        }
        public async Task<IActionResult> LoadData()
        {
            return Json(await _questionService.GetAllAsync());
        }

        public async Task<IActionResult> Index()
        {
            return  View();
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.Topicies = new SelectList(await _topicService.GetAllAsync(), nameof(Topic.Id), nameof(Topic.Name));
            return View(new QuestionAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuestionAddDto model)
        {
            if (ModelState.IsValid)
            {
                await _questionService.AddAsync(new Question()
                {
                    
                    Content=model.Content,
                    TopicId=model.TopicId,
                    Description = model.Description,
                   
                });
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            TempData["id"] = id;
            return View(_mapper.Map<QuestionUpdateDto>(await _questionService.FindByIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Update(QuestionUpdateDto model)
        {
            if (model.Id != (int)TempData["id"])
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _questionService.UpdateAsync(_mapper.Map<Question>(model));

            return View(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            await _questionService.RemoveAsync(new Question { Id = id });
            return Json(null);
        }

    }
}
