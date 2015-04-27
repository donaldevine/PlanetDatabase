(function () {
    "use strict";

    var planetServices = angular.module("planetServices", ["ngResource"]);

    planetServices.factory("Planet", ["$resource",
      function ($resource) {
          return $resource("/api/planet");
      }]);

    


}());