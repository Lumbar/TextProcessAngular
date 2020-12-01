"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.StatisticsResponse = void 0;
var base_response_1 = require("../../core/base-response");
var StatisticsResponse = /** @class */ (function (_super) {
    __extends(StatisticsResponse, _super);
    function StatisticsResponse() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return StatisticsResponse;
}(base_response_1.BaseResponse));
exports.StatisticsResponse = StatisticsResponse;
//# sourceMappingURL=statistic.response.js.map