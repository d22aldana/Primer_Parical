using System.ComponentModel.DataAnnotations;

namespace Prim_Parcial.Models
{
    public enum TypeList 
    {
        Colegio,
        Comparsa,
        Plaza,
        Universidad,
        Barrio
    }
    public class Aldana
    {
        [Key]
        public int AldanaId { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string FriendofAldana { get; set; }

        [Required]
        public TypeList Place { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]
        public int Birthdate { get; set; }


    }
}