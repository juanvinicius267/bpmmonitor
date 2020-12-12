using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class PessoasDao
    {
        private readonly TeleMonitorContext _context;
        public PessoasDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Pessoas> GetData()
        {
            return this._context.Pessoas.ToList();
        }
        public Doencas GetById(int id)
        {
            return this._context.Pessoas
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Pessoas data)
        {
            this._context.Pessoas.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Pessoas infos)
        {
            Doencas dados = GetById(id);
            this._context.Pessoas.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Pessoas.Remove(this._context.Pessoas.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
