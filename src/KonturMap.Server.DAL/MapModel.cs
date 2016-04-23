using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonturMap.Server.DAL
{
    public class MapModel
    {
        public static async Task<List<object>> GetPeoplesInRadius(MapPosition position, float radius)
        {
            return await Task<List<object>>.Factory.StartNew(new Func<List<object>>(() =>
            {
                return new List<object>();
            }));
        }

        public static async Task<MapPosition> GetPosition(long phone)
        {
            return await Task<MapPosition>.Factory.StartNew(new Func<MapPosition>(() =>
            {
                return new MapPosition();
            }));
        }

        public static async void UpdatePosition(long phone, MapPosition position)
        {
            await Task.Factory.StartNew(new Action(() =>
            {

            }));
        }
    }
}
