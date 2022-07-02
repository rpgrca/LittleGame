namespace LittleGame.Logic;

public class Combate
{
    private readonly Personaje[] _peleadores;
    private readonly Random _random;
    private const int MaximoDanoProvocable = 50000;
    public Personaje Ganador { get; private set; }
    public Personaje Perdedor { get; private set; }

    public Combate(Personaje primerPeleador, Personaje segundoPeleador)
    {
        _peleadores = new[] { primerPeleador, segundoPeleador };
        _random = new Random();
    }

    public void Pelear()
    {
        int[] orden;
        if (_random.Next(0, 2) == 0)
        {
            orden = new[] { 0, 1 };
        }
        else
        {
            orden = new[] { 1, 0 };
        }

        for (var round = 0; round < 3; round++)
        {
            EjecutarRound(orden[0], orden[1]);
            EjecutarRound(orden[1], orden[0]);
        }

        if (_peleadores[0].Salud > _peleadores[1].Salud)
        {
            Ganador = _peleadores[0];
            Perdedor = _peleadores[1];
        }
        else
        {
            if (_peleadores[0].Salud < _peleadores[1].Salud)
            {
                Ganador = _peleadores[1];
                Perdedor = _peleadores[0];
            }
        }
    }

    private void EjecutarRound(int atacante, int defensor)
    {
        var poder = CalcularPoderDeDisparo(atacante);
        var efectividad = CalcularEfectividadDeDisparo();
        var valorDeAtaque = poder * efectividad;

        var poderDeDefensa = CalcularPoderDeDefensa(defensor);

        var danoProvocado = ((valorDeAtaque * efectividad - poderDeDefensa) / MaximoDanoProvocable) * 100;

        Console.WriteLine($"{_peleadores[atacante].Nombre} golpea a {_peleadores[defensor].Nombre} por {danoProvocado} puntos.");
        _peleadores[defensor].Salud -= danoProvocado;
        Console.WriteLine($"{_peleadores[defensor].Nombre} ahora tiene {_peleadores[defensor].Salud} puntos de salud.");
    }

    private int CalcularPoderDeDisparo(int indice) =>
        _peleadores[indice].Destreza * _peleadores[indice].Fuerza * _peleadores[indice].Nivel;

    private int CalcularEfectividadDeDisparo() => _random.Next(1, 101);

    private int CalcularPoderDeDefensa(int indice) =>
        _peleadores[indice].Armadura * _peleadores[indice].Velocidad;
}