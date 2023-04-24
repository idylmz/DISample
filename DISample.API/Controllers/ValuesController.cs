using DISample.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DISample.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        private readonly IMyScopedService _myScopedService;
        private readonly IMyTransientService _myTransientService;
        private readonly IMyScopedService _myScopedService2;
        private readonly IMyTransientService _myTransientService2;
        private readonly IMySingletonService _mySingletonService;

        public ValuesController(IMyTransientService myTransientService, IMyScopedService myScopedService, IMyTransientService myTransientService2, IMyScopedService myScopedService2, IMySingletonService mySingletonService) {
            _myTransientService = myTransientService;
            _myScopedService = myScopedService;
            _myTransientService2 = myTransientService2;
            _myScopedService2 = myScopedService2;
            _mySingletonService = mySingletonService;

        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] {
                "SingletonDate", _mySingletonService.Date.ToString()
                , "SingletonId", _mySingletonService.Id.ToString()
                , "TransientDate", _myTransientService.Date.ToString()
                , "TransientId", _myTransientService.Id.ToString()
                , "ScopedDate", _myScopedService.Date.ToString()
                , "ScopedId", _myScopedService.Id.ToString() 
                , "TransientDate2", _myTransientService2.Date.ToString()
                , "TransientId2", _myTransientService2.Id.ToString()
                , "ScopedDate2", _myScopedService2.Date.ToString()
                , "ScopedId2", _myScopedService2.Id.ToString() 
            };
        }

    }
}
