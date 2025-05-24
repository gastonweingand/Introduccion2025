using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    internal static class Settings //static es una palabra reservada que indica a C# que es una clase que no necesita instanciarse
    {
        //Todos los miembros de esta clase son también estáticos (Miembros de clase)

        private static readonly string connString = ConfigurationManager.ConnectionStrings["DBIntroduccion"].ConnectionString;

        private static readonly string dbFilePath = ConfigurationManager.AppSettings["dbFilePath"];

        /// <summary>
        /// 
        /// </summary>
        public static string ConnString
        {
            get
            {
                return connString;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string FilePathDB
        {
            get
            {
                return dbFilePath;
            }
        }
    }
}
