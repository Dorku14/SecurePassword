using Microsoft.AspNetCore.Mvc;
using SecurePassword.Context;
using SecurePassword.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecurePassword.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly AccountContext _context;

        public PasswordController(AccountContext context)
        {
            _context = context;
        }
        // GET: api/<PasswordController>
        [HttpGet]
        public IEnumerable<Password> Get()
        {
            List<Password> usuarios = _context.Name.ToList();
            usuarios[1].Name = "prueba";
            return usuarios.AsReadOnly();
        }

        // GET api/<PasswordController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PasswordController>
        [HttpPost]
        public void Post([FromBody] Password value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<PasswordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PasswordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
