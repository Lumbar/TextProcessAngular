import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TextProcessAdapter } from './adapters';
import { TextProcessAgent } from './agents';
import { NetworkManager } from './agents/common/networkmanager';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing.module';
import { OrderOptionsComponent } from './modules/text-process/components/text-process/order-options/order-options.component';
import { OrderedTextComponent } from './modules/text-process/components/text-process/ordered-text/ordered-text.component';
import { StatisticsComponent } from './modules/text-process/components/text-process/statistics/statistics.component';
import { TextProcessComponent } from './modules/text-process/components/text-process/text-process.component';
import { TextProcessService } from './services';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
  declarations: [
    AppComponent,

    TextProcessComponent,
    OrderedTextComponent,
    OrderOptionsComponent,
    StatisticsComponent,
  ],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    MatSnackBarModule,
    MatCardModule,
    MatInputModule,
    MatSelectModule,
    MatListModule,
    MatIconModule,
  ],
  providers: [
    NetworkManager,
    TextProcessService,
    TextProcessAdapter,
    TextProcessAgent,
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule {
}
