(function () {
    'use strict';

    angular
        .module('simpleApp')
        .controller('simpleController', simpleController);

    simpleController.$inject = ['$scope']; 

    function simpleController($scope) {
        $scope.createMessage = function () {
            $scope.message = 'Hello ' + $scope.firstName + ' ' + $scope.lastName + '!';
        };
    }
})();
