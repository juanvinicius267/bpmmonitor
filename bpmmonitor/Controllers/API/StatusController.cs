using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly StatusDao _context;
        public StatusController(StatusDao context)
        {
            this._context = context;
        }
        //GET: api/Status
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Status
        [HttpPost]
        public ActionResult Post(Status dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Status
        [HttpPut]
        public ActionResult Update(int id, Status dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Status
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
