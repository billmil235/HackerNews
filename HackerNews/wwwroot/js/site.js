var app = angular.module('HackerNewsAPIApp', []);

app.controller('HackerNewsAPIController', function HackerNewsAPIController($scope, $http) {

    SpinnerOff();

    $scope.storyList = [];
    $scope.storyCount = '20';

    $scope.getStories = function () {

        SpinnerOn();

        var url = "/api/NewStories";

        if ($scope.storyCount != '0') {
            url += "/" + $scope.storyCount;
        }

        console.log(url);

        $http.get(url)
            .then(function (stories) {
                $scope.storyList = stories.data;
                return;
            }, function (error) {
                alert("An error has occurred retrieving the stories.");
            })
            .then(function () {
                // Complete
                SpinnerOff();
            });

    };

    $scope.getStories();

});

function SpinnerOn() {
    $('#spinner').html('<span class="spinner-border spinner-border-sm mr-2" role="status" aria-hidden="true"></span>Loading...').addClass('disabled');
}

function SpinnerOff() {
    $('#spinner').html('');
}