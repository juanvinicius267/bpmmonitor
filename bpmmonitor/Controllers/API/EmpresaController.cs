﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bpmmonitor.Controllers.API
{
    [Route("api/[controller]")]
    public class EmpresaController : Controller
    {
        private readonly EmpresaDao _context;
        public TelemonitorController(EmpresaDao context)
        {
            this._context = context;
        }
        //GET: api/Empresa
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._context.GetData());
        }
        //POST: api/Empresa
        [HttpPost]
        public ActionResult Post(Empresa dados)
        {
            this._context.SetData(dados);
            return Ok();
        }
        //PUT: api/Empresa
        [HttpPut]
        public ActionResult Update(int id, Empresa dados)
        {
            this._context.UpdateData(id, dados);
            return Ok();
        }
        //DELETE: api/Empresa
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            this._context.DeleteData(id);
            return Ok();
        }
    }
}
