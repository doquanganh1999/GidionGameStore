using GidionGameStore.Models;
using GidionGameStore.Models.GameStoreDSTableAdapters;
using System.Web.Mvc;

namespace GidionGameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GameStoreDS gameStoreDS = new GameStoreDS();
            GameInformationTableAdapter gameInformationTableAdapter = new GameInformationTableAdapter();
            gameInformationTableAdapter.Fill(gameStoreDS.GameInformation);
            ViewBag.GameInformation = gameStoreDS.GameInformation;
            ViewBag.ErrorMessage = gameInformationTableAdapter.Connection.State == System.Data.ConnectionState.Open ? null : "Database connection is not open.";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}