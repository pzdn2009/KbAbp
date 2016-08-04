(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        //md
        'hc.marked', 'hljs', 'angular-markdown-editor',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        //md
        'markedProvider', 'hljsServiceProvider',
        function ($stateProvider, $urlRouterProvider,
            markedProvider, hljsServiceProvider) {
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
                .state('newknowledgecategory', {
                    url: '/newknowledgecategory',
                    templateUrl: '/App/Main/views/kb/newknowledgecategory.cshtml',
                    menu: 'NewKnowledgeCategory'
                })
                .state('newknowledge', {
                    url: '/newknowledge',
                    templateUrl: '/App/Main/views/kb/newknowledge.cshtml',
                    menu: 'NewKnowledge'
                })
                .state('knowledgelist', {
                    url: '/knowledgelist',
                    templateUrl: '/App/Main/views/kb/knowledgelist.cshtml',
                    menu: 'KnowledgeList'
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in KbAbpNavigationProvider
                });

            // marked config
            markedProvider.setOptions({
                gfm: true,
                tables: true,
                sanitize: true,
                highlight: function (code, lang) {
                    if (lang) {
                        return hljs.highlight(lang, code, true).value;
                    } else {
                        return hljs.highlightAuto(code).value;
                    }
                }
            });

            // highlight config
            hljsServiceProvider.setOptions({
                // replace tab with 4 spaces
                tabReplace: '    '
            });
        }
    ]);
})();