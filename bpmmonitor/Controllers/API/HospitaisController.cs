using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class HospitaisController : Controller
    {
        private readonly HospitaisDao _context;
        public HospitaisController(HospitaisDao context)
        {
            this._context = context;
        }
        //GET: api/Hospitais
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Hospitais
        [HttpPost]
        public ActionResult Post(Hospitais dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Hospitais
        [HttpPut]
        public ActionResult Update(int id, Hospitais dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Hospitais
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
