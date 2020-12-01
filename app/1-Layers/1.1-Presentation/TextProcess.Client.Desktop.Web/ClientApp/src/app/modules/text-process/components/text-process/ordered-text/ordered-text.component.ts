import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TextProcessViewModel } from '../../../viewmodels/text-process.view-model';

@Component({
  selector: 'app-ordered-text',
  templateUrl: './ordered-text.component.html',
  styleUrls: ['./ordered-text.component.scss']
})
export class OrderedTextComponent implements OnInit {

  @Input() textProcessVM: TextProcessViewModel;
  @Output() method2 = new EventEmitter();

  public optionForm: FormGroup;

  constructor(private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.optionForm = this.buildForm();
  }

  private buildForm() {
    return this.formBuilder.group({
      textToValidate: [null, [Validators.required]],
    });
  }

  onMethod2() {
    this.textProcessVM.Text = this.optionForm.get('textToValidate').value;
    this.method2.emit();
  }
}
