import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './login/login.component';
import { RegistrosComponent } from './registros/registros.component';
import { service } from './service/service.service';
import { InformacionComponent } from './informacion/informacion.component';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { ActualizarComponent } from './actualizar/actualizar.component';
import { MenuComponent } from './menu/menu.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    RegistrosComponent,
    InformacionComponent,
    UsuariosComponent,
    ActualizarComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'registros', component: RegistrosComponent },
      { path: 'usuarios', component: UsuariosComponent },
      { path: 'actualizar', component: ActualizarComponent },
      { path: 'menu', component: MenuComponent }
      
    ])
  ],
  providers: [service],
  bootstrap: [AppComponent]
})
export class AppModule {
  
 }
