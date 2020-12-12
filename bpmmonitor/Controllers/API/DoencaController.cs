using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoencaController : ControllerBase
    {
        private readonly DoencaDao _context;
        public DoencaController(DoencaDao context)
        {
            this._context = context;
        }
        //GET: api/Doenca
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Doenca
        [HttpPost]
        public ActionResult Post(Doencas dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Doenca
        [HttpPut]
        public ActionResult Update(int id, Doencas dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Doenca
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
