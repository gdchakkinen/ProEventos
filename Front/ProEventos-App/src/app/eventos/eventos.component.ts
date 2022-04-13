import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      Tema: "Angular",
      Local: "Recife"
    },
    {
      Tema: "Core 5",
      Local: "Joao Pessoa"
    },
    {
      Tema: "DataBase",
      Local: "Ceara"
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
