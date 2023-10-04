using Loja_de_Games.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Loja_de_Games.Model
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string Descricao { get; set; } = string.Empty;
        

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Console { get; set; } = string.Empty;


        [Column(TypeName = "date")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateTime DataLancamento { get; set; }


        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        
        [Column(TypeName = "varchar")]
        [StringLength(5000)]
        public string Foto { get; set; } = string.Empty;
       public virtual Categoria? Categoria { get; set; }
      //  public virtual User? Usuario { get; set; }
    }
}
