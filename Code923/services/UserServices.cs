using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace Code923.services
{
    
    public class UserServices
    {
        public static int Add<T>(T t)
        {
            //String sql = $"insert into {typeof(T).Name} values";
            //for(int i = 0; i < typeof(T).GetProperties().Length ;i++)
            //{
            //    sql+=($" '{typeof(T).GetProperties()[i].GetValue(t,null)}',");
            //}

            //sql.Remove(sql.Length-1);
            //sql += ")";
            //Sqlhelp.AnModel(sql);
            String sql = $"insert into {typeof(T).Name} values(";
            foreach (var a in typeof(T).GetProperties())
            {
                sql += $"@{a.Name},";
            }

            sql.Remove(sql.Length - 1);
            sql += ")";
            SqlParameter[] param = new SqlParameter[typeof(T).GetProperties().Length-1];
            for (int i = 0; i < typeof(T).GetProperties().Length; i++)
            {
                param[i] = new SqlParameter($"{typeof(T).GetProperties()[i].Name}",
                    typeof(T).GetProperties()[i].GetValue(t, null));
            }
            return Sqlhelp.AnModel(sql,param);
        }
        public static int Del<T>(int id)
        {
            ////delete from testss.dbo.test1 where id='12';
            //String sql = $"delete from {typeof(T).Name} where";
            //for (int i = 0; i < typeof(T).GetProperties().Length; i++)
            //{
            //    if (typeof(T).GetProperties()[i].GetValue(t, null) != null)
            //        sql += ($"{typeof(T).GetProperties()[i].Name} = '{typeof(T).GetProperties()[i].GetValue(t, null)}',");
            //    continue;
            //}
            //sql.Remove(sql.Length - 1);
            //sql += ")";
            //Sqlhelp.AnModel(sql);
            string sql = $"delete from {typeof(T).Name} where {typeof(T).GetProperties()[0].Name}=@{typeof(T).GetProperties()[0].Name}";
            SqlParameter[] param =
            {
                new SqlParameter($"@{typeof(T).GetProperties()[0].Name}",id)
            };
            return Sqlhelp.AnModel(sql, param);
        }
        public static DataTable Query<T>()
        {
            //select * from admin
            String sql = $"select * from {typeof(T).Name}";
            return Sqlhelp.Query(sql, null);
        }
        public static DataTable Query<T>(int id)
        {
            
            //select * from admin
            String sql = $"select * from {typeof(T).Name} where {typeof(T).GetProperty(id.ToString())} = '{id}'";
            return Sqlhelp.Query(sql,null);
        }
        public static void Query<T>(string name)
        {

            //select * from admin
            String sql = $"select * from {typeof(T).Name} where {typeof(T).GetProperty(name)} like '{name}'";
            Sqlhelp.Query(sql);
        }
        public static void Query<T>(bool l)
        {
            string sql="";
            //select * from admin
            if (l)
            { 
                sql = $"select * from {typeof(T).Name} order by updatetime";
                Sqlhelp.Query(sql);
            }
            else
            {
                sql = $"select * from {typeof(T).Name} order by updatetime desc";
            }
            Sqlhelp.Query(sql);

        }
        public static void Update<T>(int id,T t)
        {
            //UPDATE   Customers SET cust_email = ' kim@qq.com' WHERE cust_id = '10000005';
            String sql = $"update {typeof(T).Name} set ";
            foreach (var item in typeof(T).GetProperties())
            {
                sql += $"{item.Name}={item.GetValue(t, null)},";
            }

            sql.Remove(sql.Length - 1);
            sql += "where id="+id+"";
            Sqlhelp.AnModel(sql);
        }
    }
}