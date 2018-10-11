import { Component, OnInit } from '@angular/core';
import { service } from '../service/service.service';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {

  public usuarios: any;
  public idusuario: any;
  public nombreUsuario: any;
  public nombre: any;
  public apellidos: any;
  public password: any;

  constructor(private service: service) { }
  

  ngOnInit() {
   
  }
  mostrar(){
    this.usuarios = this.service.getConfig().subscribe(
      data => {
        this.usuarios = data;
        console.log("esto es lo que tiene usuarios", this.usuarios);
      });
  }
  find(id:any){
    
    this.usuarios=this.service.findData(id).subscribe(
      data=>{
        this.usuarios=data;
        console.log("este es el usuario que encontre", this.usuarios);

        
      }
    )
    

  }
 
  


}
