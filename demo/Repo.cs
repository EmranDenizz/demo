using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace demo
{
    public interface IDenemeRepo
    {
        Task<IEnumerable<deneme>> GetAllCustomers();  // amk spiker sesi geldi dedim pcye virüs mü yedirdim ses nerden geliyor tribe girdim hahahahhahahah
    }

    public class CustomerRepository : IDenemeRepo
    {
        public void Add(deneme model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<deneme>> GetAllCustomers()
        {

            using var connection = new SqlConnection(GetSettings.ConnectionString);
            return await connection.QueryAsync<deneme>(QueryStrings.deneme, commandType: CommandType.StoredProcedure);
        }

        public Task<deneme> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(deneme model)
        {
            throw new NotImplementedException();
        }
    }
}
