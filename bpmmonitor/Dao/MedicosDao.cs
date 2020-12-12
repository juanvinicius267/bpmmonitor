using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class MedicosDao
    {
        private readonly TeleMonitorContext _context;
        public MedicosDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Medicos> GetData()
        {
            return this._context.Medicos.ToList();
        }
        public Medicos GetById(int id)
        {
            return this._context.Medicos
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Medicos data)
        {
            this._context.Medicos.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Medicos infos)
        {
            Telemonitor dados = GetById(id);
            this._context.Medicos.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Medicos.Remove(this._context.Medicos.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
