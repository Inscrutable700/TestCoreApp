(function () {
    'use strict';

    angular
        .module('app', [])
        .controller('tasks', tasks);

    tasks.$inject = ['$scope']; 

    function tasks($scope) {
        $scope.title = 'tasks';

        activate();

        function activate() { }
    }
})();
