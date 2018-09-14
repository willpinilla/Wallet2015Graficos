using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletEntidades;

namespace WalletPresentacion.Util
{
    public static class Conversiones
    {
        //Cuentas
        public static DataSet ConvertToDataSetCuentas<T>(IList<T> lista, bool bId)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                if (propInfo.Name == "Id")
                {
                    if (bId)
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
                else
                {
                    t.Columns.Add(propInfo.Name, ColType);
                }
            }

            //go through each property on T and add each value to the table
            foreach (T item in lista)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    if (propInfo.Name == "Id")
                    {
                        if (bId)
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                    else
                    {
                        row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                    }
                }

                t.Rows.Add(row);
            }

            return ds;
        }


        //Categorias
        public static DataSet ConvertToDataSetCategorias<T>(IList<T> lista, bool bId)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                if (propInfo.Name == "Id")
                {
                    if (bId)
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
                else
                {
                    if (propInfo.Name != "TipoMovimientoId")
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
            }

            //go through each property on T and add each value to the table
            foreach (T item in lista)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    if (propInfo.Name == "Id")
                    {
                        if (bId)
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                    else
                    {
                        if (propInfo.Name != "TipoMovimientoId")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                }

                t.Rows.Add(row);
            }

            return ds;
        }

        
        //TipoMovimiento
        public static DataSet ConvertToDataSetTiposMovimiento<T>(IList<T> lista, bool bId)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                if (propInfo.Name == "Id")
                {
                    if (bId)
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
                else
                {
                    t.Columns.Add(propInfo.Name, ColType);
                }
            }

            //go through each property on T and add each value to the table
            foreach (T item in lista)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    if (propInfo.Name == "Id")
                    {
                        if (bId)
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                    else
                    {
                        row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                    }
                }

                t.Rows.Add(row);
            }

            return ds;
        }


        //Movimiento
        public static DataSet ConvertToDataSetMovimientos<T>(IList<T> lista, bool bId)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                if (propInfo.Name == "Id")
                {
                    if (bId)
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
                else
                {
                    if (propInfo.Name != "TipoMovimientoId" && propInfo.Name != "CategoriaId" && propInfo.Name != "CuentaId")
                    {
                        t.Columns.Add(propInfo.Name, ColType);
                    }
                }
            }

            //go through each property on T and add each value to the table
            foreach (T item in lista)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    if (propInfo.Name == "Id")
                    {
                        if (bId)
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                    else
                    {
                        if (propInfo.Name != "TipoMovimientoId" && propInfo.Name != "CategoriaId" && propInfo.Name != "CuentaId")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                }

                t.Rows.Add(row);
            }

            return ds;
        }


        //Reporte
        public static DataSet ConvertToDataSetReportes<T>(IList<T> lista, bool bId)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in lista)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}
