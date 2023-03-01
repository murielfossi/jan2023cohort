using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMysqlConnection.Models;

namespace FirstMysqlConnection.Controllers;

public class TuneController : Controller
{
    private MyContext db;

    public TuneController(MyContext context)
    {
        db = context;
    }

    //method qui aura le http get==display my form in the tune.cshtml in the web page and post=add the infos enter to the database
}