using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class AtendimentoDao
    {
        private readonly TeleMonitorContext _context;
        public AtendimentoDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Atendimento> GetData()
        {
            return this._context.Atendimentos.ToList();
        }
        public Atendimento GetById(int id)
        {
            return this._context.Atendimentos
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Atendimento data)
        {
            this._context.Atendimentos.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Atendimento infos)
        {
            Telemonitor dados = GetById(id);
            this._context.Atendimentos.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Atendimentos.Remove(this._context.Atendimentos.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
