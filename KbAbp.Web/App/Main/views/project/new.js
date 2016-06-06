(function () {

    var controllerId = 'app.views.project.new';
    angular.module('app').controller(controllerId, [
        '$scope', '$location', 'abp.services.app.project',
        function ($scope, $location, projectService) {
            var vm = this;

            vm.project = {
                name : '',
                description: ''
            };

            var localize = abp.localization.getSource('KbAbp');

            vm.saveProject = function () {
                abp.ui.setBusy(
                    null,
                    projectService.createProject(
                        vm.project
                    ).success(function () {
                        abp.notify.info(abp.utils.formatString(localize("TaskCreatedMessage"), vm.project.name));
                        $location.path('/projectlist');
                    })
                );
            };
        }
    ]);
})();