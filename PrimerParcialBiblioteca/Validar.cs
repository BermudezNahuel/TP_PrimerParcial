using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Validar
    {
        static public bool ValidarDni(int dni)
        {
            if (dni > 0)
            {
                return true;
            }
            return false;
        }

        static public bool ValidarDni(int dni, List<int> listaDni)
        {
            foreach (int i in listaDni) 
            {
                if (dni == i)
                {
                    return false;
                }
            }
            return true;
        }

       

        //_____________________________________________________________________________________________________________


        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="LoginFallido"></exception>
        public static bool ValidarUsuario(List<Alumno> lista,int usuario, int password)
        {
            foreach (var item in lista)
            {
                if (item.Dni == usuario && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarUsuario(List<Profesor> lista, int usuario, int password)
        {
            foreach (var item in lista)
            {
                if (item.Dni == usuario && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarUsuario(List<Administrador> lista, int usuario, int password)
        {
            foreach (var item in lista)
            {
                if (item.Dni == usuario && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        

        //public static string ValidarTipo()
        //{
        //    Type tipo = dni.GetType();
        //    return tipo;
        //}



        

    }
}
