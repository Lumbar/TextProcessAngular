import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TextProcessComponent } from './modules/text-process/components/text-process/text-process.component';

const routes: Routes = [
  { path: '', component: TextProcessComponent },
  { path: 'text-process', component: TextProcessComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
