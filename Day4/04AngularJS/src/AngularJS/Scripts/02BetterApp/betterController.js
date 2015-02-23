(function () {
    'use strict';

    angular
        .module('betterApp')
        .controller('betterController', betterController);


    function betterController() {
        this.createMessage = function () {
            this.message = 'Hello ' + this.firstName + ' ' + this.lastName + '!';
        }
    }



})();
