import { Component, OnInit, ViewChild } from '@angular/core';
import { TextProcessAdapter } from '../../../../adapters';
import { OrderedTextParameter } from '../../../../agents/text-process/parameter/ordered-text.parameter';
import { StatisticsParameter } from '../../../../agents/text-process/parameter/statistics.parameter';
import { TextProcessService } from '../../../../services';
import { TextProcessViewModel } from '../../viewmodels/text-process.view-model';
import { OrderOptionsComponent } from './order-options/order-options.component';
import { OrderedTextComponent } from './ordered-text/ordered-text.component';
import { StatisticsComponent } from './statistics/statistics.component';

@Component({
  templateUrl: './text-process.component.html',
  styleUrls: ['./text-process.component.scss']
})
export class TextProcessComponent implements OnInit {

  textProcessVM: TextProcessViewModel;

  @ViewChild('orderOptions', { static: true }) orderOptions: OrderOptionsComponent;
  @ViewChild('orderedText', { static: true }) orderedText: OrderedTextComponent;
  @ViewChild('statistics', { static: true }) statistics: StatisticsComponent;

  constructor(private textProcessService: TextProcessService,
    private textProcessAdapter: TextProcessAdapter,
  ) {
    this.textProcessVM = new TextProcessViewModel();
  }

  ngOnInit() {
    this.loadData();
  }

  ngAfterViewInit() {
  }

  loadData() {
    this.textProcessService.OrderedOptions().subscribe(response => {
      this.textProcessVM.Options = this.textProcessAdapter.OrderedOptionsResultToViewModel(response).Rows;

    },
      () => {

      },
      () => {

      }
    );
  }

  method2() {
    if (!this.orderOptions.optionForm.valid) {
      this.orderOptions.optionForm.markAllAsTouched();
      return;
    }

    if (!this.orderedText.optionForm.valid) {
      this.orderedText.optionForm.markAllAsTouched();
      return;
    }

    const parameter: OrderedTextParameter = new OrderedTextParameter();
    parameter.TextToOrder = this.textProcessVM.Text;
    parameter.OrderOption = this.textProcessVM.OrderOption;

    this.textProcessService.OrderedText(parameter).subscribe(response => {
      this.textProcessVM.ResultOrder = this.textProcessAdapter.OrderedTextResultToViewModel(response);
    },
      () => {

      },
      () => {

      }
    );
  }

  method3() {
    if (!this.statistics.optionForm.valid) {
      this.orderOptions.optionForm.markAllAsTouched();
      return;
    }

    const parameter: StatisticsParameter = new StatisticsParameter();
    parameter.TextToAnalyze = this.textProcessVM.TextToAnalyze;

    this.textProcessService.Statistics(parameter).subscribe(response => {
      this.textProcessVM.ResultStat = this.textProcessAdapter.StatisticsResultToViewModel(response);
    },
      () => {

      },
      () => {

      }
    );
  }
}
