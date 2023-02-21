using BusinessLogic;
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
        [HttpGet("Get EducationalDetails")]
        public ActionResult e()
        {
            try
            {
                var Ttry = logic.GetEducationalDetails();
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
        [HttpGet("GetCompanydetails")]
        public IActionResult c()
        {
            try
            {
                var Ttry = logic.GetCompanyDetails();
                if(Ttry.Count() > 0)
                {
                    return Ok(Ttry);    
                }
                else
                {
                    return BadRequest("Data base is empty");
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
        public IActionResult Del(string email) 
        {
            try
            {
                if (email!=null)
                {
                    var r=logic.DeleteAllDetails(email);
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
        [HttpPut("updateEducation")]
        public IActionResult Eupdate(int id, EducationalD details)
        {
            try
            {
                if (id != null)
                {
                    var Ed = logic.Edupdatebyid(id, details);
                    return Ok(Ed);
                }
                else
                {
                    return BadRequest("error");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("cant find data");
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut("updateskilldetails")]
        public IActionResult Supdate(int id,SkillD details)
        {
            try
            {
                if (id != null)
                {
                    var S = logic.Supdatebyid(id, details);
                    return Ok(S);
                }
                else
                {
                    return BadRequest("error");
                }

            }
            catch (SqlException e)
            {
                return BadRequest("cant find data");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet("Login")]
        public IActionResult login(string email,string pass) 
        {
            try
            {
                if(email!= null)
                {
                    var l = logic.login(email, pass);
                    if (l == true)
                    {
                        return Ok("Login Successful");
                    }
                    else
                    {
                        return BadRequest("Login Failed");
                    }
                }
                return BadRequest("Please Enter Your Credentials");
            }
            catch (SqlException e)
            {
                return BadRequest(e);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("Search bySkill")]
        public ActionResult FindTrainerBySkill(string skill)
        {
            try
            {
                var s=logic.FindTrainerBySkill(skill);
                if (s != null)
                {
                    return Ok(s);
                }
                else
                {
                    return NotFound("Trainers with the skill not found");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("Data not found");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut("companydetails")]
        public IActionResult Cupdatebyid(int id,CompanyD details) 
        {
            try
            {
                if (id != null)
                {
                    var C = logic.Cupdatebyid(id, details);
                    return Ok(C);
                }
                else
                {
                    return BadRequest("error");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("Data not found");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        }
    }
    

