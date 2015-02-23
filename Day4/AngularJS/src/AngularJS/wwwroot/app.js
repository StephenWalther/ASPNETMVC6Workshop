(function(){"use strict";angular.module("simpleApp",[])})();(function(){"use strict";angular.module("betterApp",[])})();(function(){"use strict";angular.module("validationApp",[])})();(function(){"use strict";angular.module("ajaxApp",[])})();(function(){"use strict";angular.module("resourceApp",["ngResource"])})();(function(){"use strict";angular.module("routeApp",["ngRoute"]).config(config);config.$inject=["$routeProvider","$locationProvider"];function config($routeProvider,$locationProvider){$routeProvider.when("/",{templateUrl:"/ngViews/viewA.html",controller:"viewAController as main"}).when("/viewA",{templateUrl:"/ngViews/viewA.html",controller:"viewAController as main"}).when("/viewB/:id",{templateUrl:"/ngViews/viewB.html",controller:"viewBController as main"});$locationProvider.html5Mode(true)}})();(function(){"use strict";angular.module("simpleApp").controller("simpleController",simpleController);simpleController.$inject=["$scope"];function simpleController($scope){$scope.createMessage=function(){$scope.message="Hello "+$scope.firstName+" "+$scope.lastName+"!"}}})();(function(){"use strict";angular.module("betterApp").controller("betterController",betterController);function betterController(){this.createMessage=function(){this.message="Hello "+this.firstName+" "+this.lastName+"!"}}})();(function(){"use strict";angular.module("validationApp").controller("validationController",validationController);function validationController(){this.addProduct=function(){alert("Product added!")}}})();(function(){"use strict";angular.module("ajaxApp").controller("ajaxController",ajaxController);ajaxController.$inject=["$http"];function ajaxController($http){var vm=this;$http.get("/api/products").success(function(products){vm.products=products}).error(function(){alert("Could not get products!")})}})();(function(){"use strict";angular.module("resourceApp").controller("resourceController",resourceController);resourceController.$inject=["$resource"];function resourceController($resource){var vm=this;// create product resource
var Product=$resource("/api/products/:id");// display products
vm.products=Product.query();// add new product
vm.newProduct=new Product;vm.add=function(){vm.newProduct.$save(function(result){vm.products.push(angular.copy(result))})}}})();(function(){"use strict";angular.module("routeApp").controller("viewAController",viewAController);viewAController.$inject=["$location"];function viewAController($location){this.message="Hello from View A!";this.move=function(id){$location.path("viewB/"+id)}}})();(function(){"use strict";angular.module("routeApp").controller("viewBController",viewBController);viewBController.$inject=["$routeParams"];function viewBController($routeParams){this.message="Hello from View B! You requested id "+$routeParams.id}})();