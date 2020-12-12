using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class ConvenioDao
    {
        private readonly TeleMonitorContext _context;
        public ConvenioDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Convenio> GetData()
        {
            return this._context.Convenios.ToList();
        }
        public Convenio GetById(int id)
        {
            return this._context.Convenios
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Convenio data)
        {
            this._context.Convenios.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Convenio infos)
        {
            Telemonitor dados = GetById(id);
            this._context.Convenios.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Convenios.Remove(this._context.Convenios.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
