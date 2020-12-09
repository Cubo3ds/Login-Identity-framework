using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuboNetBeta.Models
{
    public class SQLUsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext context;

        public SQLUsuarioRepository(AppDbContext context) 
        {
            this.context = context;
        }
    }
}
