import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss',
})
export class EventosComponent {
  
  public eventos: any;

  constructor(private http: HttpClient){ }

  ngOnInit(): void {
    this.GetEventos();
  }

  public GetEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
}
