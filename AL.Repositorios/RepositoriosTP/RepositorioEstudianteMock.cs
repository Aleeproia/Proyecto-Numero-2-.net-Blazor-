using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using System.Collections.Generic;

namespace AL.Repositorios.RepositorioTP;

public class RepositorioEstudianteMock:IRepositorioEstudiante{

        
        public List<Estudiante> GetAllEstudiantes(){
                List<Estudiante> listaestudiante = new List<Estudiante>();
                using (var db = new EntidadContext()){
                    foreach(var x in db.Estudiantes){
                        listaestudiante.Add(x);
                    }
                }
                return listaestudiante;
            }

        private Listados Clonar(Listados l) 
        {
            return new Listados() {
                        titulo_curso = l.titulo_curso,
                        nombre_estudiante = l.nombre_estudiante,
                        apellido_estudiante = l.apellido_estudiante
                        };
        }
        private Estudiante Clonar(Estudiante e) 
        {
            return new Estudiante() {
                        Id =e.Id,
                        nombre = e.nombre,
                        apellido = e.apellido
                        };
        }
        private Curso Clonar(Curso c) 
        {
            return new Curso() {
                        titulo = c.titulo,
                        descripcion =c.descripcion,
                        fechainicio = c.fechainicio
                        };
        }

        public void AgregarEstudiante(Estudiante est){
            using (var db = new EntidadContext()){ 
                    db.Estudiantes.Add(est);
                    db.SaveChanges();
                }   

        }
        public void EliminarEstudiante(int Id){

            using (var db = new EntidadContext()){
                    var EliminarEstudiante = db.Estudiantes.Where( e => e.Id == Id).SingleOrDefault();
                    if (EliminarEstudiante != null){
                        db.Estudiantes.Remove(EliminarEstudiante);
                    }
                    db.SaveChanges();
                }

        }
        public void ModificarEstudiante(int Id,Estudiante est){

           using (var db = new EntidadContext()){
                foreach(var e in db.Estudiantes){
                        if(e.Id == Id){
                            e.nombre=est.nombre;
                            e.apellido = est.apellido;
                            e.email = est.email;
                            e.DNI =est.DNI;
                        }
                 }
             db.SaveChanges();
            }
        }
        public Estudiante? ConsultarEstudiante(int DNI){
            Estudiante? est = null;
            using (var db = new EntidadContext()){
                    foreach(var x in db.Estudiantes){
                        if(x.DNI == DNI){
                            est = x;
                            return est;
                        }
                    }
                    db.SaveChanges();
            }
            return est;
        }
        public Estudiante? ConsultarIdEstudiante(int Id){
            Estudiante? est = null;
            using (var db = new EntidadContext()){
                    foreach(var x in db.Estudiantes){
                        if(x.Id == Id){
                            est = x;
                            return est;
                        }
                    }
                    db.SaveChanges();
            }
            return est;
        }
       

       
        public List<Listados> ListadoEstudianteActual(){
            Listados lis = new Listados();
            List<Listados> lista = new List<Listados>();
            DateTime fechaactual = DateTime.Today;
            using (var db = new EntidadContext()){
                var listestudiantes = db.inscripciones.Join(db.Estudiantes, i => i.Idestudiante, e => e.Id,
                (i,e) => new {
                    nombreEstudiante = e.nombre,
                    apellidoEstudiante = e.apellido,
                    idCurso = i.Idcurso
                });
                var listaCurso = db.Curso.Join(listestudiantes, c => c.Id, li => li.idCurso , (c,li) => new{
                    titulo = c.titulo,
                    nombreCursante = li.nombreEstudiante,
                    apellidoCursante = li.apellidoEstudiante,
                    fechaInicioCursada = c.fechainicio,
                    fechaFinDeCursada= c.fechafinalizacion
                } );
                foreach(var obj in listaCurso){
                    if(obj.fechaFinDeCursada > fechaactual && obj.fechaInicioCursada <= fechaactual){
                        lis.titulo_curso=obj.titulo;
                        lis.apellido_estudiante=obj.apellidoCursante;
                        lis.nombre_estudiante=obj.nombreCursante;               
                        lista.Add(Clonar(lis));
                    }
                }
            return lista;
            }
        }

        public List<Listados> ListadoEstudianteCursoFinalizado(){
            DateTime fechaactual = DateTime.Today;
            Listados lis = new Listados();
            List<Listados> l = new List<Listados>();
            using(var db = new EntidadContext()){
            var listaEstudiantes = db.inscripciones.Join(db.Estudiantes, i=> i.Idestudiante, e => e.Id,
            (i,e) => new {
                nombreEstudiante = e.nombre,
                apellidoEstudiante = e.apellido,
                idCurso= i.Idcurso
            });
            var listaConCursos = db.Curso.Join(listaEstudiantes, c => c.Id , le => le.idCurso, (c,le) => new {
                titulo = c.titulo,
                nombreCursante = le.nombreEstudiante,
                apellidoCursante = le.apellidoEstudiante,
                fecha=c.fechafinalizacion
            });
            foreach(var obj in listaConCursos){
                if(obj.fecha < fechaactual ){
                    lis.titulo_curso = obj.titulo;
                    lis.nombre_estudiante = obj.nombreCursante;
                    lis.apellido_estudiante = obj.apellidoCursante;
                    l.Add(Clonar(lis));
                }
            }
            return l;
       }
            

        }

        public List<Estudiante> ListadoEstudianteDadoUnCurso(int Id){
                Estudiante? est = new Estudiante();
                List<Estudiante> e = new List<Estudiante>();
                using(var db = new EntidadContext()){
                var ListarEstudiantes = db.inscripciones.Join(db.Estudiantes, i => i.Idestudiante,e => e.Id, 
                (i,e) =>new {
                    nombreEstudiante = e.nombre,
                    apellidoEstudiante = e.apellido,
                    id_curso = i.Idcurso
                });
                foreach(var obj in ListarEstudiantes){
                    if(obj.id_curso == Id ){
                        est.nombre = obj.nombreEstudiante;
                        est.apellido = obj.apellidoEstudiante;
                        e.Add(Clonar(est));
                    }
                }
             }
             return e;

        }  


        public List<Curso> ListarEstudianteCursoInscripto(int Id){
                Curso cur = new Curso();
                List<Curso> lc = new List<Curso>();
                using(var db = new EntidadContext()){
                var listaCursos = db.inscripciones.Join(db.Curso, i=> i.Idcurso, c => c.Id,
                (i,c) => new {
                    nombreCurso = c.titulo,
                    idestudiante= i.Idestudiante

                });
                foreach(var obj in listaCursos){
                    if(obj.idestudiante == Id ){
                        cur.titulo = obj.nombreCurso ;
                        lc.Add(Clonar(cur));
                    }
                }
                return lc;
            }
        }



}


