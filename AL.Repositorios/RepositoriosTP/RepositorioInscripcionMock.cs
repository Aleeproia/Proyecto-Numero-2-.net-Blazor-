using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using System.Collections.Generic;
using AL.Aplicacion.UseCases;


namespace AL.Repositorios.RepositorioTP;

public class RepositorioInscripcionMock:IRepositorioInscripcion{

        public List<Inscripcion> GetAllInscripciones(){
            List<Inscripcion> listaisncripcion = new List<Inscripcion>();
            using(var db = new EntidadContext()){
                foreach(var i in db.inscripciones){
                    listaisncripcion.Add(i);
                }
            }
            return listaisncripcion;
        }

       public void AgregarInscripcion(Inscripcion i){
            using (var db = new EntidadContext()){ 
                    db.inscripciones.Add(i);
                    db.SaveChanges();
                }   

        }
    
    
        public Inscripcion? ConsultarInscripcion(int idc,int ide){
            Inscripcion? ins = null;
            using (var db = new EntidadContext()){
                foreach(var x in db.inscripciones){
                    if((x.Idestudiante == ide)&&(x.Idcurso == idc)){
                        ins = x;
                        return ins;
                    }
                 }
                db.SaveChanges();
            }
            return ins;
        }
 

        public void EliminarInscripcion(int Id){
            using(var db = new EntidadContext()){
            var EliminarInscripcion = db.inscripciones.Where( e => e.Id == Id).SingleOrDefault();
                if (EliminarInscripcion != null){
                    db.inscripciones.Remove(EliminarInscripcion);
                }
            db.SaveChanges();
            }
        }


        public void ModificarInscripcion(int id,Inscripcion inscripcion){
            using (var db = new EntidadContext()){
            foreach(var i in db.inscripciones){
                    if(i.Id == id){
                        i.Idcurso = inscripcion.Idcurso;
                        i.Idestudiante = inscripcion.Idestudiante;
                        i.fechainscripcion =inscripcion.fechainscripcion;
                    }
                }
                db.SaveChanges();
            }
        }
}
