(function() {
    "use strict";
    angular
        .module("planetManagement")
        .controller("PlanetListCtrl", ["Planet", PlanetListCtrl]);
    
    function PlanetListCtrl(Planet) {
        var vm = this;
        Planet.query(function (data) {
            vm.planets = data;
        }, function (errorDetails) {
                console.log(errorDetails);
            }
        );
    }

})();