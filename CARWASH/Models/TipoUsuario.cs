using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
