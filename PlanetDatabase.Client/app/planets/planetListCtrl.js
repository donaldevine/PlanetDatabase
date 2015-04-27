(function() {
    "use strict";
    angular
        .module("planetManagement")
        .controller("PlanetListCtrl", ["planetResource", PlanetListCtrl]);
    
    function PlanetListCtrl(planetResource) {
        var vm = this;
        planetResource.query(function (data) {
            vm.planets = data;
        }, function (errorDetails) {
                console.log(errorDetails);
            }
        );
    }

})();