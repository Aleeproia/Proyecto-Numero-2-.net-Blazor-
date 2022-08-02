using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetAllInscripcionesUseCase{

    private readonly IRepositorioInscripcion _rGetInscripcion;

    public GetAllInscripcionesUseCase(IRepositorioInscripcion _rGetInscripcion){
        this._rGetInscripcion=_rGetInscripcion;
    }

    public List<Inscripcion> Ejecutar(){
        return _rGetInscripcion.GetAllInscripciones();
    }

}