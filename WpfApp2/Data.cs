using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.DataBase;

namespace WpfApp2
{
    internal class Data
    {
        private readonly ShipShipEntities _context;

        public Data(ShipShipEntities context)
        {
            _context = context;
        }
        public async Task SaveStaff(string name)
        {
            using (var dbContext = new ShipShipEntities())
            {
                var staff = new Staff()
                {
                    Name = name,
                   
                };

                dbContext.Staffs.Add(staff);
            }
        }
       
    }
}
