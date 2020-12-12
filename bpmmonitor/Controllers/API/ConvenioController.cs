using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class ConvenioController : Controller
    {
        private readonly TelemonitorDao _context;
        public TelemonitorController(ConvenioDao context)
        {
            this._context = context;
        }
        //GET: api/Convenio
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Convenio
        [HttpPost]
        public ActionResult Post(Convenio dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Convenio
        [HttpPut]
        public ActionResult Update(int id, Convenio dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Convenio
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
