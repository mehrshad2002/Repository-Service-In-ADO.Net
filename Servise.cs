using Repository;
using System.Data;

namespace Services
{
    public class Service : IInfoUser
    {
        public bool Delete(int UserID)
        {
            // Your Query
            throw new NotImplementedException();
        }

        public bool Insert(string Name, string Password, int Age, int UserID)
        {
            // Your Query
            throw new NotImplementedException();
        }

        public DataTable ReadAllData()
        {
            // Your Query
            throw new NotImplementedException();
        }

        public DataTable ReadByID(int UserID)
        {
            // Your Query
            throw new NotImplementedException();
        }

        public bool Update(string Name, string Password, int Age, int UserID)
        {
            // Your Query
            throw new NotImplementedException();
        }
    }
}