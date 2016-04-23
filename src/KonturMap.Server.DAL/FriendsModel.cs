using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonturMap.Server.DAL
{

    public class FriendsModel
    {
        public static async void SyncContacts(List<long> phones)
        {
            await Task.Factory.StartNew(new Action(() =>
            {

            }));
        }

        public static async Task<List<FriendItem>> GetContacts(long phone)
        {
           return await Task<List<FriendItem>>.Factory.StartNew(new Func<List<FriendItem>>(() =>
           {
               return new List<FriendItem>();
           }));
        }

        public static async void UpdateFriendStatus(long phone, bool status)
        {
            await Task.Factory.StartNew(new Action(() =>
            {
                
            }));
        }
    }
}
