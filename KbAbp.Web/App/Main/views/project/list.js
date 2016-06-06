(function() {
    var app = angular.module('app');

    var controllerId = 'sts.views.project.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.project',
        function($scope, projectService) {
            var vm = this;
            console.log(projectService);
            vm.localize = abp.localization.getSource('KbAbp');
            console.log(vm.localize);
            vm.projects = [];

            vm.refreshProjects = function() {
                abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    projectService.getProjects({ //Call application service method directly from javascript
                        keyword: null
                    }).success(function(data) {
                        vm.projects = data.projects;
                    })
                );
            };


            vm.getProjectCountText = function() {
                return abp.utils.formatString(vm.localize('Xprojects'), vm.projects.length);
            };

            if (vm.projects.length == 0) {
                vm.refreshProjects();
            }
        }
    ]);
})();