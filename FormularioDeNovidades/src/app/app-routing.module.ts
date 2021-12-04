import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormsComponent } from './forms/forms.component';
import { InicioComponent } from './inicio/inicio.component';
import { SobreNosComponent } from './sobreNos/sobreNos.component';

const routes: Routes = [
  {path:'inicio', component: InicioComponent },
  {path:'sobreNos', component: SobreNosComponent },
  {path:'formulario', component: FormsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
