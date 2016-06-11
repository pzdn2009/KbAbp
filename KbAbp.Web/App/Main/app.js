(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in KbAbpNavigationProvider
                })
                .state('projectlist', {
                    url: '/projectlist',
                    templateUrl: '/App/Main/views/project/list.cshtml',
                    menu: 'ProjectList' //Matches to name of 'TaskList' menu in KbAbpNavigationProvider
                })
                .state('newproject', {
                    url: '/newproject',
                    templateUrl: '/App/Main/views/project/new.cshtml',
                    menu: 'NewProject' //Matches to name of 'NewTask' menu in KbAbpNavigationProvider
                })
                .state('tasklist', {
                    url: '/tasklist',
                    templateUrl: '/App/Main/views/task/list.cshtml',
                    menu: 'TaskList' //Matches to name of 'TaskList' menu in KbAbpNavigationProvider
                })
                .state('newtask', {
                    url: '/newtask',
                    templateUrl: '/App/Main/views/task/new.cshtml',
                    menu: 'NewTask' //Matches to name of 'NewTask' menu in KbAbpNavigationProvider
                })
                .state('edittask', {
                    url: '/edittask/:taskid',
                    templateUrl: '/App/Main/views/task/edit.cshtml',
                    menu: 'EditTask' //Matches to name of 'NewTask' menu in KbAbpNavigationProvider
                })
                .state('newkbcategory', {
                    url: '/newkbcategory',
                    templateUrl: '/App/Main/views/kb/newkbcategory.cshtml',
                    menu: 'NewKbCategory' //Matches to name of 'NewKBCategory' menu in KbAbpNavigationProvider
                })
                .state('newkbcategoryitem', {
                    url: '/newkbcategoryitem',
                    templateUrl: '/App/Main/views/kb/newkbcategoryitem.cshtml',
                    menu: 'NewKbCategoryItem' //Matches to name of 'NewKBCategory' menu in KbAbpNavigationProvider
                })
                .state('kbqueuelist', {
                    url: '/kbqueuelist',
                    templateUrl: '/App/Main/views/kb/kbqueuelist.cshtml',
                    menu: 'KbQueueList' //Matches to name of 'NewKBCategory' menu in KbAbpNavigationProvider
                })
                .state('newkbqueue', {
                    url: '/newkbqueue',
                    templateUrl: '/App/Main/views/kb/newkbqueue.cshtml',
                    menu: 'NewKbQueue'
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in KbAbpNavigationProvider
                });


        }
    ]);
})();