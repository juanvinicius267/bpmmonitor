using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class AtendimentoController : Controller
    {
        private readonly AtendimentoDao _context;
        public AtendimentoController(AtendimentoDao context)
        {
            this._context = context;
        }
        //GET: api/Atendimento
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Atendimento
        [HttpPost]
        public ActionResult Post(Atendimento dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Atendimento
        [HttpPut]
        public ActionResult Update(int id, Atendimento dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Atendimento
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
