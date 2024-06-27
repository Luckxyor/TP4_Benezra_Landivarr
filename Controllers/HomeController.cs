using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_Benezra_Landivar.Models;

namespace TP4_Benezra_Landivar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaPaquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete(){
        ViewBag.ListaDestinos=ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles=ORTWorld.ListaHoteles;
        ViewBag.ListaAereos=ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones=ORTWorld.ListaExcursiones;
        return View();
    }

    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion){
        Paquete paq=new Paquete(ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
        bool guardar=ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino], paq);
        if(!guardar){
            ViewBag.MensajeError = "Ya existe el destino del paquete";
            ViewBag.ListaDestinos=ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles=ORTWorld.ListaHoteles;
            ViewBag.ListaAereos=ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones=ORTWorld.ListaExcursiones;
            return View("SelectPaquete");
        }
        ViewBag.ListaPaquetes = ORTWorld.Paquetes;
        return View("Index");
    }
}
