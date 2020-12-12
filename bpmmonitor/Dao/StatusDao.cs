using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class StatusDao
    {
        private readonly TeleMonitorContext _context;
        public StatusDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Status> GetData()
        {
            return this._context.Status.ToList();
        }
        public Status GetById(int id)
        {
            return this._context.Status
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Status data)
        {
            this._context.Status.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Status infos)
        {
            Doencas dados = GetById(id);
            this._context.Status.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Status.Remove(this._context.Status.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
