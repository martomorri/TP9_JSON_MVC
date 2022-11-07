using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TP9_JSON.Models;
public class Reseña
{
    private int _IdReseña, _Valoracion, _CantLikes;
    private string _NombreUsuario, _Descripcion;
    public Reseña(int IdReseña, string NombreUsuario, int Valoracion, int CantLikes, string Descripcion)
    {
        _IdReseña = IdReseña; _NombreUsuario = NombreUsuario; _Valoracion = Valoracion; _CantLikes = CantLikes; _Descripcion = Descripcion;
    }
    public Reseña() { }
    public int IdReseña
    {
        get { return IdReseña; }
    }
    public string NombreUsuario
    {
        get { return _NombreUsuario; }
        set { _NombreUsuario = value; }
    }
    public int Valoracion
    {
        get { return _Valoracion; }
        set { _Valoracion = value; }
    }
    public int CantLikes
    {
        get { return _CantLikes; }
        set { _CantLikes = value; }
    }
    public string Descripcion
    {
        get { return _Descripcion; }
        set { _Descripcion = value; }
    }
}