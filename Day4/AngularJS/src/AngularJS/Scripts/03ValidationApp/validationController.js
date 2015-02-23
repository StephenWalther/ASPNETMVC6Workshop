(function () {
    'use strict';

    angular
        .module('validationApp')
        .controller('validationController', validationController);


    function validationController() {
        this.addProduct = function () {
            alert('Product added!');
        };
    }



})();
