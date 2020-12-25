using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary
{
    public class cCommandBuilder
    {
        List<SqlField> sqlFields = new List<SqlField>();
        SqlDataAdapter da;
        string sqltablename = "";
        SqlConnection con = null;
        public string SqlTableName
        {
            get { return sqltablename; }
            set { sqltablename = value; }
        }
        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }
        public void AddField(string fieldName, SqlDbType sqlDbType, int fieldSize, bool primary = false)
        {
            SqlField field = new SqlField();
            field.fieldName = fieldName;
            field.sqlDbType = sqlDbType;
            field.isPrimaryField = primary;
            field.fieldSize = fieldSize;
            sqlFields.Add(field);
        }
        public void CreateCommands(SqlDataAdapter daAdapter)
        {
            da = daAdapter;
            PrepareInsertCommand();
            PrepareUpdateCommand();
            PrepareDeleteCommand();
        }
        private void PrepareInsertCommand()
        {
            SqlCommand cmmInsert = new SqlCommand();
            cmmInsert.Connection = con;
            string sDbTableFields = "";
            string sValueFields = "";

            foreach (SqlField field in sqlFields)
            {
                if (!field.isPrimaryField)
                {
                    if (sDbTableFields != "")
                    {
                        sDbTableFields += ", ";
                        sValueFields += ", ";
                    }
                    sDbTableFields += field.fieldName;
                    sValueFields += "@" + field.fieldName;
                    cmmInsert.Parameters.Add(field.fieldName, field.sqlDbType, field.fieldSize);
                    cmmInsert.Parameters[field.fieldName].SourceColumn = field.fieldName;
                }
            }
            cmmInsert.CommandText = "insert into " + this.sqltablename + " (" + sDbTableFields + ") values(" + sValueFields + ")";
            this.da.InsertCommand = cmmInsert;
        }
        private void PrepareUpdateCommand()
        {
            SqlCommand cmmUpdate = new SqlCommand();
            cmmUpdate.Connection = con;
            string sDbTableFields = "";
            SqlField primaryField = FindPrimaryField();
            foreach (SqlField field in sqlFields)
            {
                if (!field.isPrimaryField)
                {
                    if (sDbTableFields != "")
                    {
                        sDbTableFields += ", ";
                    }
                    sDbTableFields += field.fieldName + "= @" + field.fieldName;
                    cmmUpdate.Parameters.Add(field.fieldName, field.sqlDbType, field.fieldSize);
                    cmmUpdate.Parameters[field.fieldName].SourceColumn = field.fieldName;
                }
            }
            cmmUpdate.Parameters.Add(primaryField.fieldName, primaryField.sqlDbType, primaryField.fieldSize);
            cmmUpdate.Parameters[primaryField.fieldName].SourceColumn = primaryField.fieldName;

            cmmUpdate.CommandText = "update " + this.sqltablename + " set " + sDbTableFields + " where " +
                primaryField.fieldName + "= @" + primaryField.fieldName;
            this.da.UpdateCommand = cmmUpdate;
        }
        private void PrepareDeleteCommand()
        {
            SqlCommand cmmDelete = new SqlCommand();
            cmmDelete.Connection = con;
            SqlField primaryField = FindPrimaryField();
            cmmDelete.Parameters.Add(primaryField.fieldName, primaryField.sqlDbType, primaryField.fieldSize);
            cmmDelete.Parameters[primaryField.fieldName].SourceColumn = primaryField.fieldName;

            cmmDelete.CommandText = "delete " + this.sqltablename + " where " +
                primaryField.fieldName + " = @" + primaryField.fieldName;
            this.da.DeleteCommand = cmmDelete;
        }
        private SqlField FindPrimaryField()
        {
            if (sqlFields.Exists(x => x.isPrimaryField = true))
            {
                return sqlFields.Find(x => x.isPrimaryField = true);
            }
            else
            {
                System.ArgumentException argEx = new System.ArgumentException("Primary Field Olarak Tanimlanmis Alan Bulunamadi!");
                throw argEx;
            }
        }
    }
    public class SqlField
    {
        public string fieldName = "";
        public SqlDbType sqlDbType;
        public bool isPrimaryField = false;
        public int fieldSize = 4;
    }
}
