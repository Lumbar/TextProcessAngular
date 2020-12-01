import { BaseResponse } from '../../core/base-response';
import { StatisticsResult } from '../result/statistic.result';

export class StatisticsResponse extends BaseResponse {
  Result: StatisticsResult;
}
