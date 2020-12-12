using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class HospitaisDao
    {
        private readonly TeleMonitorContext _context;
        public HospitaisDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Hospitais> GetData()
        {
            return this._context.Hospitais.ToList();
        }
        public Hospitais GetById(int id)
        {
            return this._context.Hospitais
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Hospitais data)
        {
            this._context.Hospitais.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Hospitais infos)
        {
            Doencas dados = GetById(id);
            this._context.Hospitais.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Hospitais.Remove(this._context.Hospitais.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
