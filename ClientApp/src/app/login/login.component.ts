import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { service } from '../service/service.service';
import { MenuComponent } from '../menu/menu.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  @Output() visible: EventEmitter<boolean> = new EventEmitter<boolean>();
  log = false;
  usuario: string = "";
  password: string = "";

  valueChanged(): void { // You can give any function name

    console.log("usuario", this.usuario);
    console.log("password", this.password);
    let flag: any;
    this.service.verificar(this.usuario, this.password).subscribe(
      res => {
        flag = res;
        this.log = flag;
        console.log("contraseña y usuarios correctos", this.log);
        this.visible.emit(this.log);
      },
      err => {
        console.log("contraseña y usuarios incorrectos");
        this.log = false;
      }
    );
    
  };


  constructor(private service: service) { }

  ngOnInit() {
  }

}
