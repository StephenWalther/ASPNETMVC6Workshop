(function () {
    'use strict';

    angular
        .module('ajaxApp')
        .controller('ajaxController', ajaxController);

    ajaxController.$inject = ['$http'];

    function ajaxController($http) {
        var vm = this;
        $http.get('/api/products').success(function(products) {
            vm.products = products;
        }).error(function () {
            alert('Could not get products!');
        });
    }


})();
