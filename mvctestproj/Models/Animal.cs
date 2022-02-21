using Controllers;

namespace Models
{
    public class Animal
    {
        public int IdAnim { get; set; }
        public string NameAnim { get; set; }
        public Animal (int IdAnim, string NameAnim)
        {
            this.IdAnim = IdAnim;
            this.NameAnim = NameAnim;

        }
    }
}