﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            
            Property(x => x.UserName).HasColumnName("KullaniciIsmi");
            Property(x => x.Password).HasColumnName("Sifre");

            //Birebir iliski tanımlaması
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}
