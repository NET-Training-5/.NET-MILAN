using Microsoft.AspNetCore.Mvc;

public class NumberController : Controller
{
    public IActionResult MTable()
    {
        return View() ; 
    }
    public IActionResult MultiplicationTableFromTo(int from,int to)
    {
        return View((from, to)) ; 
    }
}
