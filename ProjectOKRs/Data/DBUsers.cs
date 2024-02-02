using Amazon.SecurityToken.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using MongoDB.Driver;
using ProjectOKRs.Models;

namespace ProjectOKRs.Data
{
    public class DBUsers
    {
        private static string nameDB = "OKRsApp";
        private static string collectionDB = "users";

        public static async Task<Users> Login(string username, string password)
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var user = await collection.Find(u => u.Username == username && u.Password == password).FirstOrDefaultAsync();

            return user;
        }
        // Lấy tất cá user có role là employee và manager
        public static async Task<List<Users>> GetUsersRoleEmPloyeeAndManager()
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var filter = Builders<Users>.Filter.In(x => x.Role, new List<string> { "EMPLOYEE", "MANAGER" });
            var result = await collection.Find(filter).ToListAsync();

            return result;
        }
      
        // Lấy tất cá user có role là admin và manager
        public static async Task<List<Users>> GetUserRoleManagerAndAdmin()
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var filter = Builders<Users>.Filter.In(x => x.Role, new List<string> { "ADMIN", "MANAGER" });
            var result = await collection.Find(filter).ToListAsync();

            return result;
        }
        public static async Task<List<Users>> GetAll()
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var results = await collection.FindAsync(x => x.delete == false).Result.ToListAsync();

            return (from x in results orderby x.fullname select x).ToList();
        }

        public static Users GetMember(List<Users> list, string userId)
        {
            var user = list.SingleOrDefault(x => x.Id == userId);
            if (user != null)
                return user;
            else
                return new Users()
                {
                    Id = userId,
                    fullname = "Tài khoản đã xóa",
                };
        }
        public static async Task<bool> CheckManagerRole(Users user, string manager, List<Users> listUser)
        {
            listUser = await GetAll();
            foreach (var item in listUser)
            {
                // Lấy admin và manager
                var managerList = listUser.Where(x => x.Role == "ADMIN" || x.Role == "MANAGER").ToList();
                // user không phải là admin thì mới xét tiếp
                if (!managerList.Where(x => x.Id == user.Id && x.Role == "ADMIN").Any())
                {
                    // Kiểm tra manager
                    if (managerList.Where(x => x.Id == manager).Any())
                        return true;
                }
            }
            return false;
        }
        public static async Task<Users> GetUserByUsername(string username)
        {
            Console.WriteLine(username);
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var user = await collection.Find(x => x.Username == username).FirstOrDefaultAsync();

            return user;
        }

        public static async Task<Users> Get(string id)
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var user = await collection.Find(x => x.Id == id).FirstOrDefaultAsync();

            return user;
        }

        public static async Task<Users> Update(Users model)
        {
            var connect = MongoDB.ConnectMongoDB(nameDB);
            var collection = connect.GetCollection<Users>(collectionDB);
            var option = new ReplaceOptions { IsUpsert = false };
            var result = await collection.ReplaceOneAsync(x => x.Id.Equals(model.Id), model, option);

            return model;
        }
    }
}