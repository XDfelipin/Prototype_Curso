using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeStudio
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public IdInfo IdInfo;


        public Pessoa ShallowCopy()
        {
            return (Pessoa)this.MemberwiseClone();
        }

        public Pessoa DeepCopy()
        {
            Pessoa clone = (Pessoa)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNum);
            clone.Nome = String.Copy(Nome);
            return clone;
        }
    }

}
