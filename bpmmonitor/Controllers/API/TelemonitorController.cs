using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bpmmonitor.Dao;
using bpmmonitor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelemonitorController : ControllerBase
    {
        private readonly TelemonitorDao _context;
        public TelemonitorController(TelemonitorDao context)
        {
            this._context = context;
        }
        //GET: api/Telemonitor
        [HttpGet]
        public ActionResult Get()
        {            
            return Ok(this._context.GetData());
        }
        //POST: api/Telemonitor
        [HttpPost]
        public ActionResult Post(Telemonitor dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Telemonitor
        [HttpPut]
        public ActionResult Update(int id, Telemonitor dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Telemonitor
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}