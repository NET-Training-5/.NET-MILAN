using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult EmpTable()
    {
        return View();
    }
}