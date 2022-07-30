using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Repository
{
    public interface IInfoUser
    {
        DataTable ReadAllData();
        DataTable ReadByID(int UserID);
        bool Insert(string Name , string Password , int Age , int UserID);
        bool Update(string Name , string Password , int Age , int UserID);
        bool Delete( int UserID );
    }
}
