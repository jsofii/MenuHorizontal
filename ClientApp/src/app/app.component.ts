import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  log=false;
  nombre:any;
  Cambiar(event:boolean):void{
    console.log("Avlor event",event)
    this.log=event;

  }
}
