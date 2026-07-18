using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Name"] = "Angelica Joyce Leaño";
        ViewData["Course"] = "BS Information Technology Student";
        ViewData["Message"] = "Hello! I'm an aspiring software developer who enjoys creating websites and learning new technologies.";
        ViewData["btnProject"] = "View Projects";
        ViewData["btnContact"] = "Contact Me";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        ViewData["Title"] = "About Me";

        ViewData["Name"] = "Angelica Joyce Leaño";
        ViewData["Course"] = "Bachelor of Science in Information Technology (BSIT)";
        ViewData["Description1"] = "I am passionate about learning programming, web development, and creating user-friendly applications. I enjoy improving my technical skills through school projects and personal practice.";
        ViewData["Description2"] = "My goal is to become a professional software developer who can build modern and responsive web applications. Aside from coding, I enjoy exploring new technologies, working with classmates on projects, and continuously learning.";

        ViewData["Education1"] = "Bachelor of Science in Information Technology (BSIT)";
        ViewData["Education2"] = "Current College Student";

        ViewData["CareerGoals"] = "To become a skilled Full-Stack Web Developer and contribute to innovative software solutions.";

        ViewData["Interest1"] = "Web Development";
        ViewData["Interest2"] = "Programming";
        ViewData["Interest3"] = "Learning New Technologies";
        ViewData["Interest4"] = "Listening to Music";
        return View();
    }
    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact Me";

        ViewData["Email"] = "ajlleano13@gmail.com";
        ViewData["Mobile"] = "09935865995";
        ViewData["Github"] = "https://github.com/ajlleano13-sys";
        ViewData["LinkedIn"] = "https://www.linkedin.com/";
        ViewData["Facebook"] = "https://www.facebook.com/";
        ViewData["Resume"] = "Download Resume";
        return View();
    }
    public IActionResult Project()
    {
        ViewData["Title"] = "My Projects";

        // Project 1
        ViewData["P1Image"] = "~/images/project1.jpg";
        ViewData["P1Title"] = "Student Management System";
        ViewData["P1Desc"] = "A web application for managing student information, grades, and attendance.";
        ViewData["P1Tech"] = "ASP.NET Core MVC, SQL Server, Bootstrap";

        // Project 2
        ViewData["P2Image"] = "~/images/project2.jpg";
        ViewData["P2Title"] = "Loan Calculator";
        ViewData["P2Desc"] = "A desktop application that computes loan payments, interest, and monthly amortization.";
        ViewData["P2Tech"] = "VB.NET, Windows Forms";

        // Project 3
        ViewData["P3Image"] = "~/images/project3.jpg";
        ViewData["P3Title"] = "Personal Portfolio Website";
        ViewData["P3Desc"] = "A responsive portfolio website created using ASP.NET Core MVC and Bootstrap 5.";
        ViewData["P3Tech"] = "ASP.NET Core MVC, Bootstrap, HTML, CSS";

        ViewData["Button"] = "View Details";

        return View();
    }
    public IActionResult Skills()
    {
        ViewData["PL"] = "C#, Java, Python, JavaScript";
        ViewData["WT"] = "HTML5, CSS3, Bootstrap 5, ASP.NET Core MVC";
        ViewData["DATABASE"] = "SQL Server, MySQL, Microsoft Access";
        ViewData["DTOOLS"] = "Visual Studio 2022, VS Code, Git, GitHub, Cisco Packet Tracer";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}