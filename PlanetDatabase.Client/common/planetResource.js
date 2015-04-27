(function () {
    "use strict";

    function planetResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/planet");
    }

    angular
        .module("common.services")
        .factory("planetResource",
        [
            "$resource",
            "appSettings",
            planetResource
        ]);

    


}());