(function () {
    'use strict';

    angular
        .module('routeApp')
        .controller('viewBController', viewBController);

    viewBController.$inject = ['$routeParams'];

    function viewBController($routeParams) {
        this.message = 'Hello from View B! You requested id ' + $routeParams.id;
    }

})();
