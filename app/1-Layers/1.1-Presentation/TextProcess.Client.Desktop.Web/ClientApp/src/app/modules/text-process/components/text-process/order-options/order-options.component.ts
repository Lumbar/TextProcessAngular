import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSelectChange } from '@angular/material';
import { TextProcessViewModel } from '../../../viewmodels/text-process.view-model';

@Component({
  selector: 'app-order-options',
  templateUrl: './order-options.component.html',
  styleUrls: ['./order-options.component.scss']
})
export class OrderOptionsComponent implements OnInit {

  @Input() textProcessVM: TextProcessViewModel;
  public optionForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
  ) { }

  ngOnInit() {
    this.optionForm = this.buildForm();
  }

  private buildForm() {
    return this.formBuilder.group({
      optionId: [null, [Validators.required]],
    });
  }

  onOptionChange(option: MatSelectChange) {
    this.textProcessVM.OrderOption = option.value;
  }

}
