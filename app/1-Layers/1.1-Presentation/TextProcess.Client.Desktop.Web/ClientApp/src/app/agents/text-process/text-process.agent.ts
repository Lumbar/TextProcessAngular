import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { NetworkManager, PostParameters } from '../common/networkmanager';
import { OrderedTextRequest } from './request/ordered-text.request';
import { StatisticsRequest } from './request/statistic.request';
import { OrderedOptionsResponse } from './response/order-options.response';
import { OrderedTextResponse } from './response/ordered-text.response';
import { StatisticsResponse } from './response/statistic.response';
import { TextProcessPaths } from './text-process.paths';

@Injectable()
export class TextProcessAgent {
  private readonly url: string;

  constructor(
    private networkManager: NetworkManager) {
    this.url = "http://localhost:6804/api/v1/";
  }

  OrderedOptions(): Observable<OrderedOptionsResponse> {
    const parameters: PostParameters = new PostParameters();
    parameters.PathOperation = this.url + TextProcessPaths.OrderOptions;

    return this.networkManager.post(parameters) as Observable<OrderedOptionsResponse>;
  }

  OrderedText(request: OrderedTextRequest): Observable<OrderedTextResponse> {
    const parameters: PostParameters = new PostParameters();
    parameters.PathOperation = this.url + TextProcessPaths.OrderedText;
    parameters.RequestParameter = request;

    return this.networkManager.post(parameters) as Observable<OrderedTextResponse>;
  }

  Statistics(request: StatisticsRequest): Observable<StatisticsResponse> {
    const parameters: PostParameters = new PostParameters();
    parameters.PathOperation = this.url + TextProcessPaths.Statistics;
    parameters.RequestParameter = request;

    return this.networkManager.post(parameters) as Observable<StatisticsResponse>;
  }
}
