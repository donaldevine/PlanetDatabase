(function() {
    "use strict";
    
    angular
        .module("common.services", ["ngResource"])
        .constant("appSettings", {
            //URL of WebAPI Server
            serverPath: "http://localhost:49182/"
    });

}());