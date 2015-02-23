(function () {
    'use strict';

    angular.module('routeApp', ['ngRoute']).config(config);

    config.$inject = ['$routeProvider', '$locationProvider'];

    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/ngViews/viewA.html',
                controller: 'viewAController as main'
            })
            .when('/viewA', {
                templateUrl: '/ngViews/viewA.html',
                controller: 'viewAController as main'
            })
            .when('/viewB/:id', {
                templateUrl: '/ngViews/viewB.html',
                controller: 'viewBController as main'
            });
        $locationProvider.html5Mode(true);
    }


})();