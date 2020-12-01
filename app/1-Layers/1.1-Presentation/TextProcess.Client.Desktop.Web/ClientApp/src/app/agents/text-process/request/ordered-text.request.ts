import { OrderedTextParameter } from '../parameter/ordered-text.parameter';

export class OrderedTextRequest {
  public Parameters: OrderedTextParameter;

  constructor() {
    this.Parameters = new OrderedTextParameter();
  }
}
