using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DB
{
    public class DBController
    {

        private static DBController instance;

        private DBController()
        {
            throw new NotImplementedException();
        }

        public static DBController GetInstance()
        {
            if (instance == null)
            {
                instance = new DBController();
            }

            return instance;
        }

        public void Connect(string connectionstring)
        {
            throw new NotImplementedException();
        }
    }
}
