using Microsoft.AspNetCore.Mvc;

namespace didemo.Controllers
{
    public class BusinessController : Controller
    {
        private readonly ICountry _country;

        public BusinessController(ICountry country)
        {
            _country = country;
        }

        // GET: BusinessController
        [HttpGet]
        public IActionResult Index()
        {
            BusinessModel model = new BusinessModel();
            //預設營業金額值為10萬元
            model.Amount = 100000;
            if (TempData["Result"] != null)
            {
                ViewBag.Result = TempData["Result"].ToString();
            }
            ViewBag.CountryName = _country.CountryName;
            ViewBag.TaxRate = $"{_country.TaxRate}%";
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Index(BusinessModel model)
        {
            if (!ModelState.IsValid) return View(model);
            int int_amount = _country.TaxedAmount(model.Amount);
            string str_result = "<hr>";
            str_result += $"<h5>執行結果</h5>";
            // $ 不能省略，dotnet aspnet-codegenerator 在執行 scaffold 的時候，會去掃描控制器裡面跟 Model 綁定的內容，有時候會誤判或是解析不到字串，特別是 Razor 預期的格式。
            str_result += $"國家代號：{_country.CountryNo}<br />";
            str_result += $"國家名稱：{_country.CountryName}<br />";
            str_result += $"營業稅率：{_country.TaxRate}<br />";
            str_result += $"<hr>";
            str_result += $"未稅金額：{model.Amount}<br />";
            str_result += $"含稅金額：{int_amount}";
            TempData["Result"] = str_result;
            return RedirectToAction("Index", "Business", new { area = "" });
        }
    }
}
