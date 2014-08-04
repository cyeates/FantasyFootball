app.controller('FantasyFootballCtrl', ["$scope", "playersRepository", "projectionCalculator", function ($scope, playersRepository, projectionCalculator) {

  $scope.settings = {
    passYards: 25, //1 point for every 25 yards
    passTds: 4,
    passInt: 2,
    rushYards: 10, //1 point for every 10 yards
    rushTds: 6,
    receptions: 0,
    receptionYards: 10,
    receptionTds: 6,
    twoPts: 2,
    fumbles: -2
  };
  
  var dataSourceSettings = {
    pageSize: 25,
    schema: {
      model: {
        id: "playerId",
        fields: {
          playerId: { type: "number" },
          name: { type: "string" },
          position: { type: "string" },
          passYards: { type: "number" },
          passTds: { type: "number" },
          passInt: {type: "number"},
          rushYards: { type: "number" },
          rushTds: { type: "number" },
          receptions: { type: "number" },
          receptionYards: { type: "number" },
          receptionTds: { type: "number" },
          twoPts: { type: "number" },
          fumbles: { type: "number" },

        }
      }
    }
  };
  
  var qbDataSource = new kendo.data.DataSource(dataSourceSettings);
  var rbDataSource = new kendo.data.DataSource(dataSourceSettings);
  var wrDataSource = new kendo.data.DataSource(dataSourceSettings);
  var teDataSource = new kendo.data.DataSource(dataSourceSettings);

  $scope.qbGridOptions = {
    dataSource: qbDataSource,
    pageable: true,
    columns: [
      {
        field: "name",
        title: "Name"
      },
      {
        field: "teamId",
        title: "Team"
      },
      {
        field: "passYards",
        title: "Passing Yards",
        format: "{0:n1}"
      },
      {
        field: "passTds",
        title: "Passing TDs",
        format: "{0:n1}"
      },
      {
        field: "passInt",
        title: "Interceptions",
        format: "{0:n1}"
      },
      {
        field: "rushYards",
        title: "Rushing Yards",
        format: "{0:n1}"
      },
      {
        field: "rushTds",
        title: "Rushing TDs",
        format: "{0:n1}"
      },
      {
        field: "fumbles",
        title: "Fumbles Lost",
        format: "{0:n1}"
      },
      {
        field: "Projection",
        template: function (dataItem) {
          var projection = projectionCalculator.calculate(dataItem, $scope.settings);
          return kendo.format("{0:n1}", projection);
        }
      }]
  };

  $scope.rbGridOptions = {
    dataSource: rbDataSource,
    pageable: true,
    columns: [
      {
        field: "name",
        title: "Name"
      },
      {
        field: "teamId",
        title: "Team"
      },
      {
        field: "rushYards",
        title: "Rushing Yards",
        format: "{0:n1}"
      },
      {
        field: "rushTds",
        title: "Rushing TDs",
        format: "{0:n1}"
      },
       {
         field: "receptions",
         title: "Receptions",
         format: "{0:n1}"
       },
       {
         field: "receptionYards",
         title: "Receiving Yards",
         format: "{0:n1}"
       },
      {
        field: "receptionTds",
        title: "Receiving TDs",
        format: "{0:n1}"
      },
      {
        field: "fumbles",
        title: "Fumbles Lost",
        format: "{0:n1}"
      },
      {
        field: "Projection",
        template: function(dataItem) {
          var projection = projectionCalculator.calculate(dataItem, $scope.settings);
          return kendo.format("{0:n1}", projection);
        }
      }]
  };

  $scope.wrGridOptions = {
    dataSource: wrDataSource,
    pageable: true,
    columns: [
      {
        field: "name",
        title: "Name"
      },
      {
        field: "teamId",
        title: "Team"
      },
      {
        field: "rushYards",
        title: "Rushing Yards",
        format: "{0:n1}"
      },
      {
        field: "rushTds",
        title: "Rushing TDs",
        format: "{0:n1}"
      },
      {
        field: "receptions",
        title: "Receptions",
        format: "{0:n1}"
      },
      {
        field: "receptionYards",
        title: "Receiving Yards",
        format: "{0:n1}"
      },
      {
        field: "receptionTds",
        title: "Receiving TDs",
        format: "{0:n1}"
      },
      {
        field: "fumbles",
        title: "Fumbles Lost",
        format: "{0:n1}"
      },
      {
        field: "Projection",
        template: function(dataItem) {
          var projection = projectionCalculator.calculate(dataItem, $scope.settings);
          return kendo.format("{0:n1}", projection);
        }
      }
    ]
  };

  $scope.teGridOptions = {
    dataSource: teDataSource,
    pageable: true,
    columns: [
      {
        field: "name",
        title: "Name"
      },
      {
        field: "teamId",
        title: "Team"
      },
      {
        field: "receptions",
        title: "Receptions",
        format: "{0:n1}"
      },
      {
        field: "receptionYards",
        title: "Receiving Yards",
        format: "{0:n1}"
      },
      {
        field: "receptionTds",
        title: "Receiving TDs",
        format: "{0:n1}"
      },
      {
        field: "fumbles",
        title: "Fumbles Lost",
        format: "{0:n1}"
      },
      {
        field: "Projection",
        template: function (dataItem) {
          var projection = projectionCalculator.calculate(dataItem, $scope.settings);
          return kendo.format("{0:n1}", projection);
        }
      }
    ]
  };

  $scope.refresh = function () {
    if ($scope.validator.validate()) {
      $scope.qbGrid.refresh();
      $scope.rbGrid.refresh();
      $scope.wrGrid.refresh();
      $scope.teGrid.refresh();
    }
  };
  
  playersRepository.get().then(function(result) {
    rbDataSource.data(result.runningbacks);
    wrDataSource.data(result.wideReceivers);
    teDataSource.data(result.tightEnds);
    qbDataSource.data(result.quarterbacks);
   });

}]);