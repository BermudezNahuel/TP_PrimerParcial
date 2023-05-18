﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class ClaseMaestra
    {
        public List<Materia> Materias { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Administrador Admin{ get; set;  }




        public void AgregarUsuario(Alumno usuario)
        {
            //Validar.ValidarDniOrThrow(usuario.Dni,);
            Alumnos.Add(usuario);
        }
        public void AgregarUsuario(Profesor usuario)
        {
            Profesores.Add(usuario);
        }

    }

}