﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class deklaracija
    {
        public virtual int Id { get; protected set; }
        //treba samo datum
        public virtual DateTime DatumIzdavanja { get; set; }
        public deklaracija() { }
    }
}
