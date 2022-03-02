using System.Collections.Generic;

namespace Models
{
    public class Especialidade
    {
        public static int ID = 0;
        public int Id { get; set; }
        public string Desc { get; set; }
        public string Detail { get; set; }
        private static List<Especialidade> Especialidades = new List<Especialidade>();
        public Especialidade(
            string Desc,
            string Detail
        ) : this(++ID,Desc,Detail)
        {
        }
        private Especialidade(
            int Id,
            string Desc,
            string Detail
        )
        {
            this.Id = Id;
            this.Desc = Desc;
            this.Detail = Detail;

            Especialidades.Add(this);
        }
        public static List<Especialidade> GetEspecialidades()
        {
            return Especialidades;
        }

        public static void RemoverEspecialidade(Especialidade especialidade)
        {
            Especialidades.Remove(especialidade);
        }
        
        public static string ToString()
        {
            
            return $"\n ---------------------------------------"
                  +$"\n Id: {this.Id}"
                  +$"\n Descrição: {this.Desc}"
                  +$"\n Detalhes: {this.Detail}";
        }
        
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            if (!Especialidade.ReferenceEquals(o, this))
            {
                return false;
            }
            Especialidade e = (Especialidade) o;
            return e.Id == this.Id;
        }
    }
}