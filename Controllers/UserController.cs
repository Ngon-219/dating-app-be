using AutoMapper;
using DatingApp.Data;
using DatingApp.Dtos;
using DatingApp.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class 
        UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly dataContext _dbContext;

        public UserController(dataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = context;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<List<UserDto>>> createUser([FromBody] AppUser user)
        {
            try
            {
                var users = _dbContext.user.ToList();
                _dbContext.user.Add(user);
                await _dbContext.SaveChangesAsync();
                return Ok(users.Select(user => _mapper.Map<UserDto>(user)));
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<UserDto>>> getUserByEmail(Guid id)
        {
            try
            {
                var user = await _dbContext.user.FindAsync(id);
                return Ok(_mapper.Map<UserDto>(user));
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getAllUser")] 
        public async Task<ActionResult<List<UserDto>>> getAllUser()
        {
            try
            {
                var user =await _dbContext.user.FindAsync();
                return Ok(_mapper.Map<UserDto>(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
