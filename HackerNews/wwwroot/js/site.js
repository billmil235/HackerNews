var app = angular.module('HackerNewsAPIApp', []);

app.controller('HackerNewsAPIController', function HackerNewsAPIController($scope) {

    var self = this;
    self.stories = [];

});

app.component('hackerNewsStories', {
    template: "",
    controller: function HackerNewsStoriesController($http) {

        var ctrl = this;
        
        ctrl.getStories = function () {

            var url = "/api/NewStories";

            $http.get(url)
                .then(function (stories) {
                    return;
                }, function (error) {
                    alert("An error has occurred retrieving the stories.");
                })
                .then(function () {
                    // Complete
                });

        };

        ctrl.getStories();

    }
});