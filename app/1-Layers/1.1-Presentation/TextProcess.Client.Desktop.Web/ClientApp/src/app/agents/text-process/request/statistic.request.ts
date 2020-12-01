import { StatisticsParameter } from '../parameter/statistics.parameter';

export class StatisticsRequest {
  public Parameters: StatisticsParameter;

  constructor() {
    this.Parameters = new StatisticsParameter();
  }
}
