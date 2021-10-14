using System;
using System.Collections.Generic;
using System.IO;

namespace MVVM_WPF_SimpleProject.Classes
{
    public class Database
    {
        static string dbFile = Path.Combine(Environment.CurrentDirectory, "MVVM_WPF_SimpleProject-DB.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Insert(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Update(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static bool Remove<T>(T item)
        {
            bool result = false;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Delete(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static List<T> Read<T>() where T : new()
        {
            List<T> items;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                items = connection.Table<T>().ToList();
            }

            return items;
        }

    }
}
