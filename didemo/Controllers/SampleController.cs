using Microsoft.AspNetCore.Mvc;

namespace didemo.Controllers
{
    public class SampleController : Controller
    {
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;
        private readonly SampleService _service;
        public SampleController(ITransient transient, IScoped scoped, ISingleton singleton, SampleService service)
        {
            _transient = transient;
            _singleton = singleton;
            _scoped = scoped;
            _service = service;

        }


        public IActionResult Index()
        {
            var serviceHashCode = _service.GetHashCode();
            var controllerHashCode = $"Transient: {_transient.GetHashCode()},"
                                    + $"Scoped: {_scoped.GetHashCode()},"
                                    + $"Singleton: {_singleton.GetHashCode()}";
            string str_data = $"Service : {serviceHashCode} <br/>";
            str_data += $"Controller : {controllerHashCode}";
            ViewBag.Result = str_data;
            return View();
        }

    }
}
