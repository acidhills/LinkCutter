var linkCutterApp = angular.module('linkCutterApp', ['ui.router', 'ngCookies']);

linkCutterApp.constant('userCookie', 'myUser');

linkCutterApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $urlRouterProvider.otherwise('/');
    $stateProvider
    .state('link', {
        url: '/',
        templateUrl: '/content/views/addLink.html'
    })
    .state('links', {
        url: '/links',
        templateUrl: '/content/views/links.html'
    });
});