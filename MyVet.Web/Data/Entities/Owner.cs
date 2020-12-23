﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        //jala todos los datos de usuario, tanto del puro usuario, como los que proporciona el framework, IdentityUser
        public User User { get; set; }

        public ICollection<Pet> Pets{ get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
