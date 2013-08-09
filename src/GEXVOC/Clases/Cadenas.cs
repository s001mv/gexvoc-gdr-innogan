﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.UI.Clases
{
    public static class Cadenas
    {
        /// <summary>
        /// Retorna una cadena con su primer caracter en mayúscula.
        /// </summary>
        /// <param name="cadena">cadena inicial.</param>
        /// <returns></returns>
        public static string ToUpperPrimerCaracter(string cadena)
        {
            if (cadena != string.Empty)
            {
                try
                {
                    cadena = cadena.ToLower();

                    string primera = cadena[0].ToString().ToUpper();//Aqui guardo la 1ra letra

                    cadena = primera + cadena.Substring(1, cadena.Length - 1);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error en ToUpperPrimerCaracter");
                }
            }

            return cadena;
        }
        /// <summary>
        /// Comprueba si la sucesion de caracteres de una cadena son letras.
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="startIndex">Comienzo de la extracción de caracteres.</param>
        /// <param name="length">Nº de caracteres que se extraerán a partir del comienzo.</param>
        /// <returns></returns>
        public bool IsLetter(string cadena, int startIndex, int length)
        {
            bool rtno = true;
            try
            {
                this.ComprobarLongitud(cadena, startIndex, length);
            }
            catch (Exception){rtno = false;}

            if (rtno)//Si hemos pasado la comprobación de longitud de la cadena.
            {
                foreach (char item in cadena.Substring(startIndex, length))
                {
                    if (!char.IsLetter)
                    {
                        rtno = false;
                        break;
                    }
                }
                
            }
           
            return rtno;
        }
        /// <summary>
        /// Comprueba si la sucesion de caracteres de una cadena son digitos.
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="startIndex">Comienzo de la extracción de caracteres.</param>
        /// <param name="length">Nº de caracteres que se extraerán a partir del comienzo.</param>
        /// <returns></returns>
        public bool IsDigit(string cadena, int startIndex, int length)
        {
            bool rtno = true;
            try
            {
                this.ComprobarLongitud(cadena, startIndex, length);
            }
            catch (Exception) { rtno = false; }

            if (rtno)//Si hemos pasado la comprobación de longitud de la cadena.
            {
                foreach (char item in cadena.Substring(startIndex, length))
                {
                    if (!char.IsDigit)
                    {
                        rtno = false;
                        break;
                    }
                }

            }

            return rtno;
        }

        /// <summary>
        /// Para una cadena dada comprueba si es es correcta la información startIndex y length.
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        public void ComprobarLongitud(string cadena, int startIndex, int length) 
        {
            if (string.IsNullOrEmpty(cadena))
                throw new ArgumentException("La cadena proporcionada debe contener un valor", "cadena");
            if (startIndex + length >= cadena.Length)
                throw new ArgumentException("La longitud de la cadena no es suficiente para los parátros proporcionados (startIndex y length)", "cadena");
        
        }
    }
}
