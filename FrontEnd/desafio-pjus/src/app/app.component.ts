import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cep } from 'src/models/cep';
import { ViaCepService } from 'src/services/via-cep.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  cepForm: FormGroup;
  viaCep: Cep;

  constructor(private formBuilder: FormBuilder, private viaCepService: ViaCepService) {

  }

  ngOnInit(): void {
    this.cepForm = this.formBuilder.group({
      cep: ['', Validators.required]
    });
  }

  pesquisar() {

    if (this.cepForm.invalid) {
      return;
    }

    var cep = this.cepForm.controls.cep.value;

    this.viaCepService.get(cep).subscribe(response => {
      this.viaCep = response;
    })
  }
}
