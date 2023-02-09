using BusinessLogic;
using Core_EF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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
                if (Ttry.Count() > 0 )
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
    }
}
