using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class EnderecoController : Controller
    {
        private readonly EnderecoDao _context;
        public EnderecoController(EnderecoDao context)
        {
            this._context = context;
        }
        //GET: api/Endereco
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Endereco
        [HttpPost]
        public ActionResult Post(Endereco dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Endereco
        [HttpPut]
        public ActionResult Update(int id, Endereco dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Endereco
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
