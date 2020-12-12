using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class PessoasController : Controller
    {
        private readonly PessoasDao _context;
        public TelemonitorController(PessoasDao context)
        {
            this._context = context;
        }
        //GET: api/Pessoas
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Pessoas
        [HttpPost]
        public ActionResult Post(Pessoas dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Pessoas
        [HttpPut]
        public ActionResult Update(int id, Pessoas dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Pessoas
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
