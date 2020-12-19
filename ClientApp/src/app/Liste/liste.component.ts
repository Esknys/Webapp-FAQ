import { Component, OnInit } from '@angular/core';
import { spoersmaal } from './spoersmaal';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

@Component({
  //selector 'app-root'
  templateUrl: './liste.component.html'
})

export class ListeComponent {

  public laster: string;
  public alleSpoersmaal: Array<spoersmaal>;

  constructor(private _http: HttpClient) { }

  hentAlleSpoersmaal() {
    this.laster = "Loading...";
    this._http.get<spoersmaal[]>("api/Spoersmaal/")
      .subscribe(data => {
        this.alleSpoersmaal = data;
        this.laster = "";
      },
        error => alert(error),
        () => console.log("ferdig get-/spoersmaal")
      );
  }

}
