using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample.Services {
    public interface IMyScopedService {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
    }
}
