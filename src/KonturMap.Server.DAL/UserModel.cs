using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KonturMap.Server.DAL
{
    public class UserModel
    {
        public static async Task<bool> RegNewUser(long phone, string pass_hash)
        {
            return await Task<bool>.Factory.StartNew(new Func<bool>(() => 
            {
                return true;
            }));
        }

        public static async Task<long> LoginByDeviceID(string deviceId)
        {
            return await Task<long>.Factory.StartNew(new Func<long>( () =>
            {
                return 9081764970;
            }));
        }

        public static async Task<bool> LoginByPhone(long phone, string pass_hash)
        {
            return await Task<bool>.Factory.StartNew(new Func<bool>(() =>
            {
                return true;
            }));
        }
    }

    //public class UserModel
    //{
    //    public int Id { get; set; }
    //    public long Phone { get; set; }
    //    public string Password { get; set; }
        
    //    public async void LoadUser(long phone, string password_hash)
    //    {
    //        var connStr = @"server=127.0.0.1;user id=root;persistsecurityinfo=True;database=kontur_map;allowuservariables=True";
    //        using (var connection = new SqlConnection(connStr))
    //        {
    //            using (var command = new SqlCommand(@"SELECT * FROM `users` WHERE `phone` = @phone", connection))
    //            {
    //                command.Parameters.AddWithValue("@phone", phone);
    //                var reader = await command.ExecuteReaderAsync();
    //                Id = reader.GetInt32(0);
    //                Phone = reader.GetInt64(1);
    //                Password = reader.GetString(2);
    //            }
    //        }
    //    }

    //    public async void SaveUser()
    //    {
    //        var connStr = @"server=127.0.0.1;user id=root;persistsecurityinfo=True;database=kontur_map;allowuservariables=True";
    //        using (var connection = new SqlConnection(connStr))
    //        {
    //            using (var command = new SqlCommand(@"UPDATE `users` SET `phone`= @phone, `password_hash`= @password WHERE `id` = @id", connection))
    //            {
    //                command.Parameters.AddWithValue("@phone", Phone);
    //                command.Parameters.AddWithValue("@password", Password);
    //                command.Parameters.AddWithValue("@id", Id);
    //                var result = await command.ExecuteNonQueryAsync();
    //            }
    //        }
    //    }
    }
}
