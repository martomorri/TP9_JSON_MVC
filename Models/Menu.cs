using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TP9_JSON.Models;
public class Menu
{
    private int _IdMenu, _IdRestaurante;
    private Plato _PrimerPlato, _PlatoPrincipal, _Postre;
    public Menu(int IdMenu, int IdRestaurante, Plato PrimerPlato, Plato PlatoPrincipal, Plato Postre)
    {
        _IdMenu = IdMenu; _IdRestaurante = IdRestaurante; _PrimerPlato = PrimerPlato; _PlatoPrincipal = PlatoPrincipal; _Postre = Postre;
    }
    public Menu() { }
    public int IdMenu
    {
        get { return _IdMenu; }
    }
    public int IdRestaurante
    {
        get { return _IdRestaurante; }
        set { _IdRestaurante = value; }
    }
    public Plato PrimerPlato
    {
        get { return _PrimerPlato; }
        set { _PrimerPlato = value; }
    }
    public Plato PlatoPrincipal
    {
        get { return _PlatoPrincipal; }
        set { _PlatoPrincipal = value; }
    }
    public Plato Postre
    {
        get { return _Postre; }
        set { _Postre = value; }
    }
}