using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace MvcMusicStore.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Se requiere el primer nombre")]
        [DisplayName("Nombre")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [DisplayName("Apellido")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La dirección es necesaria")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Se requiere el campo ciudad")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Se requiere el campo estado")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Se requiere código postal")]
        [DisplayName("Codigo postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Se requiere el campo país")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Se requiere numero de telefono")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Se requiere Dirección de correo electrónico")]
        [DisplayName("Correo electronico")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "El correo electrónico no es válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}