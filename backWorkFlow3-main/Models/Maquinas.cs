﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class maquinas
    {

        //solicitud
       public int idMaquina { get; set; }
        public string nombre { get; set; }

        public string area { get; set; }

        

        public maquinas() { }



        //public areas(
//solicitud
//int IdArea,  string Nombre
        //    )
       // {
         //   idArea = IdArea;
            
          //  nombre = Nombre;
            
      //  }


        public maquinas(int IdMaquina,
string Nombre, string Area
            )
        {           
            idMaquina = IdMaquina;
            nombre = Nombre;
            area = Area;
        }

        public maquinas(
string Nombre, string Area
            )
        {
           
            nombre = Nombre;
            area = Area;
        }




    }
}



