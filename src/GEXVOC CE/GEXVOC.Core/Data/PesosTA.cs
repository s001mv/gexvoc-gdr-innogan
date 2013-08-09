using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
    public class PesosTA:PesoTableAdapter
    {
        public static GexvocDataSet.PesoDataTable ObtenerPesos(int IdExplotacion)
        {
            PesoTableAdapter Pesos = new PesoTableAdapter();
            return Pesos.ObtenerPesosSegunExplotacion(IdExplotacion);
        }
        public static void InsertarNueva(int?IdMomento,int IdAnimal,decimal Peso,DateTime Fecha)
        {
            PesoTableAdapter Pesos = new PesoTableAdapter();
            Pesos.Insertar(Convert.ToInt32(ObtenerMaxIdPeso()), IdMomento, IdAnimal, Peso, Fecha, true);
        }
        public static int ObtenerMaxIdPeso()
        {
            int iResult = 1;
            long? lMax;
            PesoTableAdapter Pesos = new PesoTableAdapter();
            lMax = Pesos.ObTenerMaxId();
            if (lMax != null)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
        #region filtrar
        public static GexvocDataSet.PesoDataTable FiltrarPesos(int IdAnimal,int IdMomento,decimal Peso,int IdExplotacion)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
               
                //if (!FechaNac.Equals(String.Empty))
                //{
                //    sql.Append(String.Format(" AND FechaNacimiento = {0} ", FechaNac));
                //}
                if (IdAnimal != 0)
                {
                    sql.Append(String.Format(" AND IdAnimal = '{0}' ", IdAnimal));
                }
                if (IdMomento != 0)
                {
                    sql.Append(String.Format(" AND IdMomento = '{0}' ", IdMomento));
                }
                if (Peso != 0)
                {
                    sql.Append(String.Format(" AND Peso = {0} ", Peso));
                }
                //if (IdEspecie != 0)
                //{
                //    sql.Append(String.Format("AND IdRaza IN (Select Id From Raza WHERE IdEspecie = '{0}')", IdEspecie));
                //}
                // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));
                //sql.Append(String.Format("And Animal.IdExplotacion= '{0}'", IdExplotacion));

                GexvocDataSet.PesoDataTable filtro = new GexvocDataSet.PesoDataTable();
                PesosTA pesoFiltro = new PesosTA();
                pesoFiltro.FiltroPesos(filtro, sql.ToString());
                return filtro;
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            return null;
        }

        public int FiltroPesos(GexvocDataSet.PesoDataTable dataTable, string whereExpression)
        {
            string text1 = this.CommandCollection[0].CommandText;

            try
            {
                if (!(whereExpression == ""))
                {
                    if (this.CommandCollection[0].CommandText.IndexOf("WHERE") == -1)
                    {
                        //quitamos el AND al principio del whereExpression
                        if (whereExpression.IndexOf("AND") > -1)
                            whereExpression = whereExpression.Substring(" AND".Length);
                        this.CommandCollection[0].CommandText += " WHERE " + whereExpression;
                    }
                    else
                    {
                        this.CommandCollection[0].CommandText += " " + whereExpression;
                    }
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
