﻿using BusinessLogic;
using Core_EF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Model;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TController : ControllerBase
    {
        ILogic logic;
        public TController(ILogic log)
        {
            logic = log;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var Ttry = logic.GetTraineeDetails();
                if (Ttry.Count() > 0)
                {
                    return Ok(Ttry);
                }
                else
                {
                    return BadRequest("Database is empty");
                }

            }
            catch (SqlException e)
            {
                return BadRequest($"cant find data");
            }
            catch (Exception eg)
            {
                return BadRequest(eg);
            }
        }
        [HttpGet("Get SkillDetails")]
        public ActionResult S()
        {
            try
            {
                var Ttry = logic.GetSkillDetails();
                if (Ttry.Count() > 0)
                {
                    return Ok(Ttry);
                }
                else
                {
                    return BadRequest("Database is empty");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("cant find data");
            }
            catch (Exception eg)
            {
                return BadRequest(eg);
            }
        }
        [HttpGet("GetAllDetails")]
        public ActionResult P()
        {
            try
            {
                var Ttry = logic.GetAllDetails();
                if (Ttry.Count() > 0)
                {
                    return Ok(Ttry);
                }
                else
                {
                    return BadRequest("Data is empty");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost("ADDTraineeDetails")]
        public IActionResult Add(TrainerD d)
        {
            try
            {
                var t = logic.AddTraineeDetails(d);
                return Created("Added", t);
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }
        }
        [HttpPost("AddSkillDetails")]
        public IActionResult Add(SkillD d)
        {
            try
            {
                var s = logic.AddSkillDetails(d);
                return Created("Added", s);
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }
        }
        [HttpPost("AddEducationaldetails")]
        public IActionResult Add(EducationalD d)
        {
            try
            {
                var s = logic.AddEducationalDetails(d);
                return Created("Added", s);
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }

        }
        [HttpPost("AddCompanydetails")]
        public IActionResult Add(CompanyD C)
        {
            try
            {
                var c = logic.AddCompanyDetails(C);
                return Created("Added", c);
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }
        }
        [HttpDelete("Deletingdetails")]
        public IActionResult Del(int id) 
        {
            try
            {
                if (id!=null)
                {
                    var r=logic.DeleteAllDetails(id);
                    return Ok(r);
                }
                else
                {
                    return BadRequest($"error");
                }

            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }
        }
        [HttpPut("updatetraineedetails")]
        public IActionResult update(int id, TrainerD details)
        {
            try
            {
                if (id != null)
                {
                    var up = logic.updatebyid(id, details);
                    return Ok(up);
                }
                else
                {
                    return BadRequest("error");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("Cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }
        }
        }
    }

