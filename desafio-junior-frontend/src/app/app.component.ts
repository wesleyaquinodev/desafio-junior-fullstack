import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {FormGroup, FormControl, ReactiveFormsModule} from '@angular/forms';
import { Status } from './interface/status';
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';

@Component({
  selector: 'app-root',
  imports: [MatFormFieldModule, MatInputModule, MatSelectModule, MatIconModule, MatButtonModule, ReactiveFormsModule, MatCardModule, MatChipsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'desafio-junior-frontend';
  status: Status[];

  formTask = new FormGroup({
    titulo: new FormControl(''),
    descricao: new FormControl(''),
    status: new FormControl('')
  });

  longText = `Descrição`;
  
  constructor(){
      this.status = [
        {value: 'Pendente', viewValue: 'Pendente'},
        {value: 'Em Andamento', viewValue: 'Em Andamento'},
        {value: 'Concluída', viewValue: 'Concluída'},
      ];
    
  }

  onSubmit(){

    let obj = {
      titulo: this.formTask.value.titulo,
      descricao: this.formTask.value.descricao,
      status: this.formTask.value.status
    }

    console.log(obj)
  }
}