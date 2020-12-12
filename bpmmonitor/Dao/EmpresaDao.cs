using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class EmpresaDao
    {
        private readonly TeleMonitorContext _context;
        public EmpresaDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Empresa> GetData()
        {
            return this._context.Empresas.ToList();
        }
        public Empresa GetById(int id)
        {
            return this._context.Empresas
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Empresa data)
        {
            this._context.Empresas.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Empresa infos)
        {
            Telemonitor dados = GetById(id);
            this._context.Empresas.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Empresas.Remove(this._context.Empresas.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
