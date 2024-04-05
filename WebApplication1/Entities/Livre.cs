using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Livre
    {
        [Key]
        public int LivreId { get; set; }
        public string Title { get; set; }
        public string Auteur { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey(nameof(CategorieId))]
        public virtual Categorie Categorie { get; set; }
    }
}
