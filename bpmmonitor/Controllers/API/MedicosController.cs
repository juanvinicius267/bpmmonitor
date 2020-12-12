using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class MedicosController : Controller
    {
        private readonly MedicosDao _context;
        public MedicosController(MedicosDao context)
        {
            this._context = context;
        }
        //GET: api/Medicos
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Medicos
        [HttpPost]
        public ActionResult Post(Medicos dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Medicos
        [HttpPut]
        public ActionResult Update(int id, Medicos dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Medicos
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
