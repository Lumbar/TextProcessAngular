import { OptionsGridRowViewModel } from "./options-grid-row.view-model";
import { TextProcessOrderViewModel } from "./text-process-order.view-model";
import { TextProcessStatViewModel } from "./text-process-stat.view-model";

export class TextProcessViewModel {

  Text: string;
  OrderOption: string;
  TextToAnalyze: string;

  ResultOrder: TextProcessOrderViewModel;
  ResultStat: TextProcessStatViewModel;

  Options: OptionsGridRowViewModel[];

  constructor() {
    this.Options = [];
  }
}
