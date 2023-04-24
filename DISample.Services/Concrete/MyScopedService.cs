using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample.Services {
    public class MyScopedService : IMyScopedService {
        private Guid _id;
        private DateTime _dateCreated;

        public DateTime Date {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        public Guid Id {
            get { return _id; }
            set { _id = value; }
        }

        public MyScopedService() {
            Date = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}
