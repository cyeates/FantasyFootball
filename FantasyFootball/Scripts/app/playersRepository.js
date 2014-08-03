app.factory("playersRepository", function($resource) {
  var Players = $resource("/api/Players");
  return {
    get: function() {
      return Players.get().$promise;
    }
  };
});