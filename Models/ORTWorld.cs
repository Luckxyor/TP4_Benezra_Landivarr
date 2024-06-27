namespace TP4_Benezra_Landivar.Models;

static class ORTWorld
{
    public static List<string> ListaDestinos {get; private set;} = new List<string>(){"Londres","Manchester","Buenos Aires", "Paris", "Roma", "Madrid", "Rio de Janerio", "Barcelona", "Oslo", "Tokio"};
    public static List<string> ListaHoteles {get; private set;} = new List<string>(){"Hilton", "Alvear", "Howard Johnson", "InterContinental", "BTH"};
    public static List<string> ListaAereos {get; private set;} = new List<string>(){"AerolineasArg.png","AirEuropa.jpg","AmericanAirlines.jpg", "Emirates.jpg", "QatarAirways.jpg"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>(){"Bombonera.jpg","Coliseo.jpg","Disney.jpg", "Obelisco.jpg", "Londres.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}= new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        if(!Paquetes.ContainsKey(destinoSeleccionado)){
            Paquetes.Add(destinoSeleccionado, paquete);
            return true;
        }
        else{
            return false;
        }
    }
}