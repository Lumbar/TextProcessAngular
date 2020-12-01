import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { TextProcessAgent } from '../../agents';
import { OrderedTextParameter } from '../../agents/text-process/parameter/ordered-text.parameter';
import { StatisticsParameter } from '../../agents/text-process/parameter/statistics.parameter';
import { OrderedTextRequest } from '../../agents/text-process/request/ordered-text.request';
import { StatisticsRequest } from '../../agents/text-process/request/statistic.request';
import { OrderedOptionsResult } from '../../agents/text-process/result/order-options.result';
import { OrderedTextResult } from '../../agents/text-process/result/ordered-text.result';
import { StatisticsResult } from '../../agents/text-process/result/statistic.result';

@Injectable()
export class TextProcessService {

  constructor(private textProcessAgent: TextProcessAgent) {
  }

  OrderedOptions(): Observable<OrderedOptionsResult> {
    return this.textProcessAgent.OrderedOptions().pipe(map(response => response.Result));
  }

  OrderedText(parameters: OrderedTextParameter): Observable<OrderedTextResult> {
    let request = new OrderedTextRequest();
    request.Parameters = parameters;
    return this.textProcessAgent.OrderedText(request).pipe(map(response => response.Result));
  }

  Statistics(parameters: StatisticsParameter): Observable<StatisticsResult> {
    let request = new StatisticsRequest();
    request.Parameters = parameters;
    return this.textProcessAgent.Statistics(request).pipe(map(response => response.Result));
  }
}
