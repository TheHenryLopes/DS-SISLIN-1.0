using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;

namespace SISLIN_1._0.Models
{
    class EntrDinheiroDAO : IDAO<EntrDinheiro>
    {
        private static Conexao conc;

        public EntrDinheiroDAO()
        {
            conc = new Conexao();
        }

        public void Delete(EntrDinheiro t)
        {
            throw new NotImplementedException();
        }

        public EntrDinheiro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(EntrDinheiro t)
        {
            try 
            {

            } catch (Exception e)
            {
                throw e;
            } finally
            {
                conc.Close();
            }
        }

        public List<EntrDinheiro> List()
        {
            throw new NotImplementedException();
        }

        public void Update(EntrDinheiro t)
        {
            throw new NotImplementedException();
        }
    }
}
