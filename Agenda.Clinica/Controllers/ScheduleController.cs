using Agenda.Clinica.Data;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Clinica.Controllers;


public partial class ScheduleController : Controller
{
    List<AppointmentData> data = new List<AppointmentData>();

    public ScheduleController()
    {
         data = new ScheduleData().GetScheduleData();

    }
    // GET: /<controller>/
    public ActionResult ScheduleFeatures()
    {
        ViewBag.datasource = data;

        return View();
    }
}

