import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { HttpHeaders} from '@angular/common/http';
import { UsuariosComponent } from '../usuarios/usuarios.component';
import { Observable } from 'rxjs/Observable';

//import { models} from '../Models/usuarios';

@Injectable()
export class service {
    
    usuarios:Observable<UsuariosComponent[]>;
    newUser:Observable<UsuariosComponent>;
    constructor(private http: HttpClient) { }
   
    getConfig() {
        console.log(this.http.get('https://localhost:5001/api/Usuarios/damedatos'))
        return this.http.get('https://localhost:5001/api/Usuarios/damedatos');
        
    }
    getData(){
        this.http.get('https://localhost:5001/api/Usuarios/damedatos').subscribe(
            (data)=> console.log("mis datos osn los siguiente",data));
            
        
    }
    findData(id: string){
        console.log("el id que voy a buscar es" + id);
        return  this.http.get('https://localhost:5001/api/Usuarios/find/'+ id);
    }
    
    add(id:string,  nombreUsuario:string, nombre:string, apellidos: string, password:string){
      //  console.log("Estoy en el servicio", nombreUsuario);
        var userTemp={
            IdUsuario: id,
            NombreUsuario: nombreUsuario,
            Nombre:nombre,
            Apellidos: apellidos,
            Password:password
        }
        return this.http.post('https://localhost:5001/api/Usuarios/agregar/', userTemp);
        
    }
    verificar( nombreUsuario:string, password:string){
        console.log("EL USER Y PASSWORD QUE VOY A VERIFICAR ES ",nombreUsuario, password, this.http.get('https://localhost:5001/api/Usuarios/verificarUsuario/{'+nombreUsuario+'}/{'+password+'}'));
        
        //return this.http.get('https://localhost:5001/api/Usuarios/verificarUsuario/ss/sss');
           
        
       return this.http.get('https://localhost:5001/api/Usuarios/verificarUsuario/'+nombreUsuario+'/'+password);
    
      // return this.http.get();
    
        
        
    }
   
    
   
    

   
}