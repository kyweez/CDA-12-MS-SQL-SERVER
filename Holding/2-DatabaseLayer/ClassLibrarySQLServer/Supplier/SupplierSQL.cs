using ClassLibraryInterfaceBusinessDatabase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ClassLibrarySQLServer.Supplier
{
    public class SupplierSQL
    {
        #region ############### PROPERTIES ###############
        private SqlConnection sqlConection;
        #endregion

        #region ############### CONSTRUCTOR ###############
        public SupplierSQL(string _connectionString)
        {
            sqlConection = new SqlConnection();
            sqlConection.ConnectionString = _connectionString;
        }
        #endregion

        #region ############### OPEN/CLOSE ###############
        public bool Close()
        {
            try
            {
                sqlConection.Close();
                Trace.TraceInformation($"{DateTime.Now} : Success closing SupplierSQL connection");
                Trace.Flush();
                return true;
            }
            catch (SqlException ex)
            {
                Trace.TraceInformation($"{DateTime.Now} : Fail closing SupplierSQL connection.\n\tError : {ex.Message}");
                Trace.Flush();
                return false;
            }
        }

        public bool Open()
        {
            try
            {
                sqlConection.Open();
                Trace.TraceInformation($"{DateTime.Now} : Success opening SupplierSQL connection.");
                Trace.Flush();
                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceInformation($"{DateTime.Now} : Fail opening SupplierSQL connection.\nError : {ex.Message}");
                Trace.Flush();
                return false;
            }
        }
        #endregion

        #region ############### CRUD ###############
        public int CreateSupplier(StructSupplier _supplier)
        {
            SqlParameter idSupplierOut = null;
            SqlCommand sqlCommand;

            if (sqlConection.State != ConnectionState.Open)
                Open();

            try
            {
                int numberOfAffectedRows;

                //SQL parameter Id
                idSupplierOut = new SqlParameter("@id_supplier", SqlDbType.Int);
                idSupplierOut.Direction = ParameterDirection.Output;

                //SQL command
                sqlCommand = new SqlCommand("AddSupplierProcedure", sqlConection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@sup_name", _supplier.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_address", _supplier.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_zipcode", _supplier.ZipCode));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_city", _supplier.City));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_contact_name", _supplier.ContactName == null ? (object)DBNull.Value : _supplier.ContactName));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_satisfaction", _supplier.Satisfaction == 0 ? (object)DBNull.Value : _supplier.ContactName));
                sqlCommand.Parameters.Add(idSupplierOut);

                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();

                if (numberOfAffectedRows == 1)
                    Trace.TraceInformation($"{DateTime.Now} : Supplier creation OK :\nName : {_supplier.Name}\nId : {idSupplierOut}");
                else
                {
                    Trace.TraceInformation($"{DateTime.Now} : Supplier creation failed : sqlCommand.ExecuteNonQuery() == {numberOfAffectedRows}");
                    throw new SupplierImpossibleCreationException("Can't create this supplier");
                }
            }
            catch (SqlException ex)
            {
                idSupplierOut.Value = 0;
                Trace.TraceInformation($"{DateTime.Now} : Fail of a SupplierSQL line creation.\nError : {ex.Message}");
                throw new SupplierImpossibleCreationException("Can't create this supplier", ex);
            }
            finally
            {
                if (sqlConection.State != ConnectionState.Closed)
                    Close();
                Trace.Flush();
            }
            return (int)idSupplierOut.Value;
        }

        public StructSupplier ReadSupplier(int _idSupplier)
        {
            StructSupplier supplier;
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            if (sqlConection.State != ConnectionState.Open)
                Open();

            try
            {
                SqlParameter idSupplier = new SqlParameter("@id_supplier", _idSupplier);
                sqlCommand = new SqlCommand("SELECT * FROM t_suppliers WHERE id_supplier=@id_supplier", sqlConection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(idSupplier);
                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read() && (int)sqlDataReader["idSupplier"] == _idSupplier)
                {
                    supplier = new StructSupplier(
                        (int)sqlDataReader["id_supplier"],
                        (string)sqlDataReader["sup_name"],
                        (string)sqlDataReader["sup_address"],
                        (string)sqlDataReader["sup_zipcode"],
                        (string)sqlDataReader["sup_city"],
                        (string)sqlDataReader["sup_contact_name"],
                        (byte)sqlDataReader["sup_satisfaction"]);
                    Trace.TraceInformation($"{DateTime.Now} : Access to supplier succeed\n\tName : {supplier.Name}\n\tId : {supplier.Id}");
                    sqlDataReader.Close();
                }
                else
                {
                    supplier = new StructSupplier(0, "undefined", "undefined", "undefined", "undefined", null, 0);
                    Trace.TraceInformation($"{DateTime.Now} : Access to supplier failure : {_idSupplier} doesn't exist");
                }
            }
            catch (Exception e)
            {
                Trace.TraceInformation($"{DateTime.Now} : Access to supplier failure. Error : {e.Message}");
                throw new SupplierImpossibleReadException("Access to supplier failure", e);
            }
            finally
            {
                if (sqlConection.State != ConnectionState.Closed)
                    Close();
                Trace.Flush();
            }
            return supplier;
        }

        public bool UpdateSupplier(StructSupplier _supplier)
        {
            bool success = false;
            int numberOfAffectedRows;
            SqlCommand sqlCommand;

            if (sqlConection.State != ConnectionState.Open)
                Open();
            try
            {
                sqlCommand = new SqlCommand("UpdateSupplierProcedure", sqlConection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                sqlCommand.Parameters.Add(new SqlParameter("@id_supplier", _supplier.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_name", _supplier.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_address", _supplier.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_zipcode", _supplier.ZipCode));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_city", _supplier.City));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_contact_name", _supplier.ContactName ?? (object)DBNull.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@sup_satisfaction", _supplier.Satisfaction == 0 ? (object)DBNull.Value : _supplier.ContactName));

                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                if (numberOfAffectedRows == 1)
                {
                    success = true;
                    Trace.TraceInformation($"{DateTime.Now} : Supplier update OK :\n\tName : {_supplier.Name}\n\tId : {_supplier.Id}");
                }
                else
                {
                    Trace.TraceInformation($"{DateTime.Now} : Supplier update failed : sqlCommand.ExecuteNonQuery() == {numberOfAffectedRows}");
                    throw new SupplierImpossibleUpdateException("Can't update this supplier");
                }
            }
            catch (Exception e)
            {
                Trace.TraceInformation($"{DateTime.Now} : Fail of a SupplierSQL line update.\nError : {e.Message}");
                throw new SupplierImpossibleCreationException("Can't update this supplier", e);
            }
            finally
            {
                if (sqlConection.State != ConnectionState.Closed)
                    Close();
                Trace.Flush();
            }
            return success;
        }

        public bool DeleteSupplier(StructSupplier _supplier)
        {
            bool success = false;
            int numberOfAffectedRows;

            if (sqlConection.State != ConnectionState.Open)
                Open();

            try
            {
                SqlParameter idToDelete = new SqlParameter("@id_supplier", _supplier.Id);
                SqlCommand sqlCommand = new SqlCommand("DeleteSupplierProcedure", sqlConection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(idToDelete);
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();

                if (numberOfAffectedRows == 1)
                {
                    Trace.TraceInformation($"{DateTime.Now} : Supplier deleted :\nName : {_supplier.Name}\nId : {_supplier.Id}");
                    success = true;
                }
                else
                {
                    success = false;
                    Trace.TraceInformation($"{DateTime.Now} : Supplier deletetion failed : sqlCommand.ExecuteNonQuery() == {numberOfAffectedRows}");
                    throw new SupplierImpossibleDeletionException("Can't delete this supplier");
                }
            }
            catch (Exception e)
            {
                Trace.TraceInformation($"{DateTime.Now} : Supplier deletetion failed.\nError : {e.Message}");
                throw new SupplierImpossibleCreationException("Can't delete this supplier", e);
            }
            finally
            {
                if (sqlConection.State != ConnectionState.Closed)
                    Close();
                Trace.Flush();
            }
            return success;
        }
        #endregion
    }
}