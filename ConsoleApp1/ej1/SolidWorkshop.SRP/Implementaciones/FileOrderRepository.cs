using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorkshop.SRP.interfaces;

namespace SolidWorkshop.SRP.Implementaciones
{
    public class FileOrderRepository : IOrderRepository 
    {
        private readonly string _dbPath = "orders_db.txt";

        public void Save(Order order)
        {
            // 3) Persistencia en un "archivo DB"
            var line = $"{order.Id}|{order.CustomerEmail}|{order.Total}|{order.CreatedAt:o}";
            File.AppendAllText(_dbPath, line + Environment.NewLine);
        }
    }
}
