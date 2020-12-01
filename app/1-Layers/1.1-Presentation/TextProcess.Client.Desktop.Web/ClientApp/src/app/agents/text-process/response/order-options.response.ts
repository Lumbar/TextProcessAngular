import { BaseResponse } from '../../core/base-response';
import { OrderedOptionsResult } from '../result/order-options.result';

export class OrderedOptionsResponse extends BaseResponse {
  Result: OrderedOptionsResult;
}
