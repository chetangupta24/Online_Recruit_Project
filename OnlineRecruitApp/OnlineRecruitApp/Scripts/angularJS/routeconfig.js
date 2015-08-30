//added a js file for routing url in angular js
// have also worked on implementing diff url routing through angular js will share the code 
angular
    .module('MyApp', [
    'ngRoute',
    'MyApp.ctrl.crud',
    ])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider.when('/', {
            templateUrl: '/Applicant/AddApplicant',
            controller: 'loginController'
        });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

    }]);