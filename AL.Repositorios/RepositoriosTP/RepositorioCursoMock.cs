using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using System.Collections.Generic;

namespace AL.Repositorios.RepositorioTP;

public class RepositorioCursoMock:IRepositorioCurso{


     public List<Curso> GetAllCursos(){
            List<Curso> listacursos = new List<Curso>();
            using (var db = new EntidadContext()){
                foreach(var x in db.Curso){
                    listacursos.Add(x);
                }
            }
             return listacursos;
     }


    public void AgregarCurso(Curso curso){
        using (var db = new EntidadContext()){ 
            db.Curso.Add(curso);
            db.SaveChanges();
        }

    }
    public void EliminarCurso(int Id){

        using (var db = new EntidadContext()){
                var eliminarCurso = db.Curso.Where( c => c.Id == Id).SingleOrDefault();
                if (eliminarCurso != null){ 
                   db.Curso.Remove(eliminarCurso);
                }
                db.SaveChanges();
            }

    }
    public void ModificarCurso(int id,Curso curso){

        using (var db = new EntidadContext()){
                foreach(var c in db.Curso){
                        if(c.Id == id){               
                            c.titulo=curso.titulo;
                            c.descripcion=curso.descripcion;
                            c.fechainicio=curso.fechainicio;
                            c.fechafinalizacion=curso.fechafinalizacion;
                        }
                 }
             db.SaveChanges();
        }
    }

    public Curso? ConsultarCurso(string? titulo_cur){

        Curso? curso = null;
            using (var db = new EntidadContext()){
                    foreach(var c in db.Curso){
                        if(c.titulo == titulo_cur){
                            curso = c;
                            return curso;
                        }
                    }
                    db.SaveChanges();
            }
            return curso;
    }

    public Curso? ConsultarIdCurso(int Id){

        Curso? curso = null;
            using (var db = new EntidadContext()){
                    foreach(var c in db.Curso){
                        if(c.Id == Id){
                            curso = c;
                            return curso;
                        }
                    }
                    db.SaveChanges();
            }
            return curso;
    }

}