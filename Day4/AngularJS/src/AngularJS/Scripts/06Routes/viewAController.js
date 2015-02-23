(function () {
    'use strict';

    angular
        .module('routeApp')
        .controller('viewAController', viewAController);

    viewAController.$inject = ['$location']; 

    function viewAController($location) {
        this.message = "Hello from View A!";

        this.move = function (id) {
            $location.path('viewB/' + id);
        };
    }
})();
