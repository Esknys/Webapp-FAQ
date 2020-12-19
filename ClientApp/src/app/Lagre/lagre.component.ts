import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { question, InnSpoersmaal } from './question';

@Component({
  //selector 'app-root'
  templateUrl: './lagre.component.html'
})

export class LagreComponent {

  Skjema: FormGroup;

  public spoersmaal: string;
  public navn: string;
  public epost: string;
  
  constructor(private _http: HttpClient, private fb: FormBuilder) {
    this.Skjema = fb.group({
      spoersmaal: ["", Validators.required],
      navn: ["", Validators.pattern("[A-Za-z\s]{0,20}$")],
      epost: ["", Validators.pattern("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$")]
    });
  }

  questions: Array<question> = [];

  sendInnSpoersmaal(): void {
    const spoersmaal = new InnSpoersmaal();
    spoersmaal.Id = 0;
    spoersmaal.Spoersmaalet = this.spoersmaal;
    spoersmaal.Navn = this.navn;
    spoersmaal.Epost = this.epost;

    

    const etSpoersmaal = new question(this.spoersmaal, this.navn, this.epost);
    this.questions.push(etSpoersmaal);
    this.spoersmaal = "";
    this.navn = "";
    this.epost = "";

    this._http.post("api/InnSpoersmaal", spoersmaal)
      .subscribe(retur => {
        console.log(retur)
      },
        error => console.log(error));

  };

}