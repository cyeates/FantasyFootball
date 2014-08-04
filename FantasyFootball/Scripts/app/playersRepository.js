app.factory("playersRepository", ["$resource", function($resource) {
  var Players = $resource("/api/Players");
  return {
    get: function() {
      return Players.get().$promise;
    }
  };
}]);