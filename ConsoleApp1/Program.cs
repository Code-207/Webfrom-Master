using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrInts=new List<int>();
            Random r=new Random();
            for (int i = 0; i < 10; i++)
            {
                arrInts.Add(r.Next(100,1000));
            }
            foreach (var val in arrInts)
            {
                new Thread(() =>
                {
                    Thread.Sleep(val);
                    Console.WriteLine(val);
                }).Start();
            }

            Console.ReadKey();
        }

        public static void Add<T>(T t)
        {
            string sql = $"insert into {typeof(T).Name} values(";
            for (int i = 0; i < typeof(T).GetProperties().Length; i++)
            {
                sql += ($" '{typeof(T).GetProperties()[i].GetValue(t, null)}',");
                Console.WriteLine($" {typeof(T).GetProperties()[i].GetValue(t, null)}");
            }
            if (sql[^1] == ',')
                sql.Remove(sql.Length - 1);
            sql += ")";
            Console.WriteLine(sql);
            Console.WriteLine(sql[^1]);
            Console.ReadKey();
        }
    }

    public class admin
    {
        public int id
        {
            get;
            set;
        }

        public admin()
        {
            id = 1;
        }
    }
}
