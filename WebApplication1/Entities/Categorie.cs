using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        public string libelle { get; set; }
        public string Description { get; set; }
        public ICollection<Livre> Livres { get; set; }

    }
}
