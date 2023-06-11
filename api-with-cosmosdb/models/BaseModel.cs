using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_with_cosmosdb.models
{
    public class BaseModel
    {
        public int id { get; set; }

        public DateTime createdAt { get; set; }
    }
}