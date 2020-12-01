import { BaseResponse } from '../../core/base-response';
import { OrderedTextResult } from '../result/ordered-text.result';

export class OrderedTextResponse extends BaseResponse {
  Result: OrderedTextResult;
}
