import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public filteredEventos: any = [];
  public eventos: any = [];
  private _filterList: string = "";
  widthImg: number = 100;
  marginImg: number = 2;
  showImg: boolean = true;


  constructor(private http: HttpClient) { }



  public get filterList(){
    return this._filterList;
  }
  public set filterList(value: string) {
    this._filterList = value;
    this.filteredEventos = this.filterList ? this.filterEventos(this.filterList) : this.eventos;
  }

  filterEventos(filterBy: string): any{
    filterBy = filterBy.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: { tema: string; local: string }) => evento.tema.toLocaleLowerCase().indexOf(filterBy) !== -1
      || evento.local.toLocaleLowerCase().indexOf(filterBy) !== -1)

  }

  ngOnInit(): void {
    this.getEventos();
   }

  alterImg(){
    this.showImg = !this.showImg;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => {
        this.eventos = response;
        this.filteredEventos = this.eventos;

      },
      error => console.log(error)
    );
  }
}
