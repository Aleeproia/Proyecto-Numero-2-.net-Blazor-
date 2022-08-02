using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetAllEstudiantesUseCase{

    private readonly IRepositorioEstudiante _rGetEstudiantes;

    public GetAllEstudiantesUseCase(IRepositorioEstudiante _rGetEstudiantes){
        this._rGetEstudiantes=_rGetEstudiantes;
    }

    public List<Estudiante> Ejecutar(){
        return _rGetEstudiantes.GetAllEstudiantes();
    }

}