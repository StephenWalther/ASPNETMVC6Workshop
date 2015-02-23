(function () {
    'use strict';

    angular
        .module('resourceApp')
        .controller('resourceController', resourceController);

    resourceController.$inject = ['$resource']; 

    function resourceController($resource) {
        var vm = this;
  
        // create product resource
        var Product = $resource('/api/products/:id');

        // display products
        vm.products = Product.query();

        // add new product
        vm.newProduct = new Product();
        vm.add = function () {
            vm.newProduct.$save(function(result) {
                vm.products.push(angular.copy(result));
            });
        };
    }
})();
