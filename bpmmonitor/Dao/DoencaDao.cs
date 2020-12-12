using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class DoencaDao
    {
        private readonly TeleMonitorContext _context;
        public DoencaDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Doencas> GetData()
        {
            return this._context.Doencas.ToList();
        }
        public Doencas GetById(int id)
        {
            return this._context.Doencas
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Doencas data)
        {
            this._context.Doencas.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Doencas infos)
        {
            Doencas dados = GetById(id);
            this._context.Doencas.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Doencas.Remove(this._context.Doencas.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
