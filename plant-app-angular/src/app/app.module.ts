import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { GardensComponent } from './gardens/gardens.component';
import { PlantsComponent } from './plants/plants.component';

@NgModule({
  declarations: [
    AppComponent,
    GardensComponent,
    PlantsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
