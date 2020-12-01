import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TextProcessViewModel } from '../../../viewmodels/text-process.view-model';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.scss']
})
export class StatisticsComponent implements OnInit {

  @Input() textProcessVM: TextProcessViewModel;
  @Output() method3 = new EventEmitter();

  public optionForm: FormGroup;

  constructor(private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.optionForm = this.buildForm();
  }

  private buildForm() {
    return this.formBuilder.group({
      textToAnalyze: [null, [Validators.required]],
    });
  }

  onMethod3() {
    this.textProcessVM.TextToAnalyze = this.optionForm.get('textToAnalyze').value;
    this.method3.emit();
  }
}
