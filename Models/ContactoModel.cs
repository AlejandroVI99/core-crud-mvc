using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? name { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? phone { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string? email { get; set; }

        //use props + tap to auto complete
    }
}