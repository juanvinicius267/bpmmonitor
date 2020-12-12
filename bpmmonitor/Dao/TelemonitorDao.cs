using bpmmonitor.Data;
using bpmmonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class TelemonitorDao
    {
        private readonly TeleMonitorContext _context;
        public TelemonitorDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Telemonitor> GetData()
        {
            return this._context.Telemonitores.ToList();
        }
        public Telemonitor GetById(int id)
        {
            return this._context.Telemonitores
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Telemonitor data)
        {
            this._context.Telemonitores.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Telemonitor infos)
        {
            Telemonitor dados = GetById(id);
            this._context.Telemonitores.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Telemonitores.Remove(this._context.Telemonitores.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
