import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EventosComponent } from "./eventos/eventos.component";
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [
      RouterOutlet,
      EventosComponent,
      PalestrantesComponent, 
      HttpClientModule, 
      CommonModule, 
      //BrowserAnimationsModule
    ]
})
export class AppComponent {
  title = 'ProEventos-App';
}
