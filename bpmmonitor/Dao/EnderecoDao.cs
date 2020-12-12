using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Dao
{
    public class EnderecoDao
    {
        private readonly TeleMonitorContext _context;
        public EnderecoDao(TeleMonitorContext context)
        {
            this._context = context;
        }
        public List<Endereco> GetData()
        {
            return this._context.Enderecos.ToList();
        }
        public Doencas GetById(int id)
        {
            return this._context.Enderecos
                .Where(x => x.IdMedicao == id)
                .FirstOrDefault();
        }
        public bool SetData(Endereco data)
        {
            this._context.Enderecos.Add(data);
            this._context.SaveChanges();
            return true;
        }
        public bool UpdateData(int id, Endereco infos)
        {
            Doencas dados = GetById(id);
            this._context.Enderecos.Add(dados);
            this._context.SaveChanges();
            return true;
        }
        public bool DeleteData(int id)
        {
            this._context.Enderecos.Remove(this._context.Enderecos.Find(id));
            this._context.SaveChanges();
            return true;
        }
    }
}
