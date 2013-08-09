using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
    public class AnimalTA : AnimalTableAdapter
    {
        public static GexvocDataSet.AnimalDataTable ObtenerAnimalesConRazaYEspecie(int IdExplotacion)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            return animales.ObtenerAnimalesConRazaYespecie(IdExplotacion);
        }
        public static void InsertarAnimalNuevo(int IdRaza, int? IdTalla, int? IdConformacion, string DIB, int IdExplotacion, string Crotal, string Tatuaje, string Nombre, DateTime FechaNacimiento, string Sexo, int IdEstado)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            animales.InsertarAnimales(Convert.ToInt32(CalcularMaxId()), IdRaza, IdTalla, IdConformacion, IdExplotacion, DIB, Crotal, Tatuaje, Nombre, FechaNacimiento, Sexo, IdEstado);
        }
        public static int? CalcularMaxId()
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            int? MaxId = animales.ObtenerMaxId();
            MaxId = MaxId + 1;
            return MaxId;
        }
        public static GexvocDataSet.AnimalDataTable ObtenerAnimalesHembras(int IdExplotacion)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            return animales.ObtenerHembras(IdExplotacion);
        }
        public static GexvocDataSet.AnimalDataTable ObtenerAnimalesMachos(int IdExplotacion)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            return animales.ObtenerMachos(IdExplotacion);
        }
        public static GexvocDataSet.AnimalDataTable EsModificable(int Id)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            return  animales.EsModificable(Id);
            
        }
        public static GexvocDataSet.AnimalDataTable ObtenerEspecie(int IdAnimal)
        {
            AnimalTableAdapter animales = new AnimalTableAdapter();
            return animales.ObtenerEspecieDeAnimal(IdAnimal);
        }
        #region filtrar
        public static GexvocDataSet.AnimalDataTable FiltrarAnimales(string DIB, string Sexo, string Crotal, string Tatuaje, string FechaNac, string Nombre, int IdRaza,int IdEspecie,int IdExplotacion)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                if (!DIB.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND DIB LIKE '{0}%' ", DIB));
                }
                if (!Sexo.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND Sexo LIKE '{0}%' ", Sexo));
                }
                if (!Crotal.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND Crotal LIKE '{0}%' ", Crotal));
                }
                if (!Tatuaje.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND Tatuaje LIKE '{0}%' ", Tatuaje));
                }
                if (!Nombre.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND Nombre LIKE '{0}%' ", Nombre));
                }
                if (!FechaNac.Equals(String.Empty))
                {
                    sql.Append(String.Format(" AND FechaNacimiento = '{0}' ", FechaNac));
                }
                if (IdRaza!=0)
                {
                    sql.Append(String.Format(" AND IdRaza = '{0}' ", IdRaza));
                }
                else if (IdEspecie != 0)
                {
                    sql.Append(String.Format("AND IdRaza IN (Select Id From Raza WHERE IdEspecie = '{0}')", IdEspecie));
                }
               // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));

                GexvocDataSet.AnimalDataTable filtro = new GexvocDataSet.AnimalDataTable();
                AnimalTA animalfiltra = new AnimalTA();
                animalfiltra.FiltroAnimales(filtro, sql.ToString(), IdExplotacion);                
                return filtro;               
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            return null;
        }

        public int FiltroAnimales(GexvocDataSet.AnimalDataTable dataTable, string whereExpression,int IdExplotacion)
        {
            string text1 = this.CommandCollection[0].CommandText;
            
            try
            {
                this.CommandCollection[0].CommandText += " " +
                "WHERE  (Animal.IdExplotacion=" + IdExplotacion + ") AND  (Animal.Id NOT IN" +
                          "(SELECT     IdAnimal " +
                            "FROM          Baja))";
                if (!(whereExpression == ""))
                {
                        this.CommandCollection[0].CommandText += " " + whereExpression;                    
                }
                
                return this.Fill(dataTable);
            }
            finally
            {
                this.CommandCollection[0].CommandText = text1;
            }
        }
        #endregion


    }
}
