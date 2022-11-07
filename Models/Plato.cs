using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TP9_JSON.Models;
public class Plato
{
    private int _IdPlato;
    private string _Nombre;
    private double _PrecioUnitario;
    public Plato(int IdPlato, string Nombre, double PrecioUnitario)
    {
        _IdPlato = IdPlato; _Nombre = Nombre; _PrecioUnitario = PrecioUnitario;
    }
    public Plato() { }
    public int IdPlato
    {
        get { return _IdPlato; }
    }
    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
    public double PrecioUnitario
    {
        get { return _PrecioUnitario; }
        set { _PrecioUnitario = value; }
    }
}