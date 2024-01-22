using Microsoft.AspNetCore.Mvc;

namespace cobaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pegawai2 : ControllerBase
    {
        public static List<Pegawai> a = new List<Pegawai>   
        {
            new Pegawai ("siska", "UI/UX"),
            new Pegawai ("Indah", "UI/UX"),
            new Pegawai ("Yoga", "UI/UX"),
            new Pegawai ("Arya", "UI/UX")

        };
        // GET: api/<Pegawai2>
        [HttpGet]
        public IEnumerable<Pegawai> Get()
        {
            return a;
        }

        // GET api/<Pegawai2>/5
        [HttpGet("{id}")]
        public Pegawai Get(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        // POST api/<Pegawai2>
        [HttpPost]
        public void Post([FromBody] Pegawai value)
        {
            a.Add(value);
        }

        // DELETE api/<Pegawai>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            a.RemoveAt(id);
        }
    }
}

