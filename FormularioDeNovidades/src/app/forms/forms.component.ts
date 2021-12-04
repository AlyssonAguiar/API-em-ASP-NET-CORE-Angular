
import { Component, OnInit, Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { IUsuario } from '../IUsuario';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {

  constructor(
    private service: SharedService
  ) { }

  @Input() usuario: IUsuario;
  Nome: string;
  Sobrenome: string; 
  Email: string;
  Telefone: string;
  
  ngOnInit() {
  }

  addUsuario(){
    var usuario = {
      Nome:this.Nome ,
      Sobrenome:this.Sobrenome,
      Email:this.Email,
      Telefone:this.Telefone,
    };

    this.service.postUsuario(usuario)
    .then(usuario => console.log('adicionado'))
    .catch(error => console.error);

    alert("Usuario salvo com sucesso")
  
  }

}
  

