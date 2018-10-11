import { Component, Inject } from '@angular/core';
import { service } from '../service/service.service';


@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch-data.component.css']
})
export class FetchDataComponent {
  public usuarios: any;
  public idusuario: any;
  public nombreUsuario: any;
  public nombre: any;
  public apellidos: any;
  public password: any;

  constructor(private service: service) { }
  add() {
    this.service.add(this.idusuario,this.nombreUsuario,this.nombre,this.apellidos,this.password).subscribe(
      res=>{
        this.usuarios = res;
      }
    );
  }
  mostrar() {
    this.usuarios = this.service.getConfig().subscribe(
      data => {
        this.usuarios = data;
        console.log("esto es lo que tiene usuarios", this.usuarios);
      });
    //console.log(this.usuarios+"llegue");


  }
  ver(){
      
  }



}


