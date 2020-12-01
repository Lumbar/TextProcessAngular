import { Injectable } from '@angular/core';
import { OrderedOptionsResult } from '../../agents/text-process/result/order-options.result';
import { OrderedTextResult } from '../../agents/text-process/result/ordered-text.result';
import { StatisticsResult } from '../../agents/text-process/result/statistic.result';
import { OptionsGridRowViewModel } from '../../modules/text-process/viewmodels/options-grid-row.view-model';
import { OptionsGridViewModel } from '../../modules/text-process/viewmodels/options-grid.view-model';
import { TextProcessOrderViewModel } from '../../modules/text-process/viewmodels/text-process-order.view-model';
import { TextProcessStatViewModel } from '../../modules/text-process/viewmodels/text-process-stat.view-model';

@Injectable()
export class TextProcessAdapter {

  OrderedOptionsResultToViewModel(result: OrderedOptionsResult): OptionsGridViewModel {
    const self = this;
    const viewModel = new OptionsGridViewModel();
    result.OrderOptions.Options.forEach(element => {
      viewModel.Rows.push(self.OrderedOptionsItemResultToViewModel(element));
    });
    return viewModel;
  }

  private OrderedOptionsItemResultToViewModel(itemResult: string): OptionsGridRowViewModel {
    const rowViewModel = new OptionsGridRowViewModel();
    rowViewModel.OptionId = itemResult;
    rowViewModel.Description = itemResult;

    return rowViewModel;
  }

  OrderedTextResultToViewModel(result: OrderedTextResult): TextProcessOrderViewModel {
    const viewModel = new TextProcessOrderViewModel();
    result.OrderedText.OrderedWords.forEach(element => {
      viewModel.Options.push(element);
    });
    return viewModel;
  }

  StatisticsResultToViewModel(result: StatisticsResult): TextProcessStatViewModel {
    const viewModel = new TextProcessStatViewModel();

    viewModel.HyphensQuantity = result.TextStatistics.HyphensQuantity;
    viewModel.SpacesQuantity = result.TextStatistics.SpacesQuantity;
    viewModel.WordQuantity = result.TextStatistics.WordQuantity;

    return viewModel;
  }
}
