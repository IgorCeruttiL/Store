using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(name, "Name", "Deve ser colocado um nome")
                .HasMinLen(name, 3, "Name", "O nome deve ser maior ou igual a 3 caracteres")
                .HasMaxLen(name, 25, "Name", "O nome deve ser no máximo 25 caracteres")
                );

            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
