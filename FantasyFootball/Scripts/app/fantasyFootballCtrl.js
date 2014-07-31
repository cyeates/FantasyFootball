var app = angular.module("fantasy-football", ["kendo.directives"]);

function FantasyFootballCtrl($scope) {
  
  $scope.settings = {
    passYards: 25, //1 point for every 25 yards
    passTds: 4,
    passInt: -2,
    rushYards: 10, //1 point for every 10 yards
    rushTds: 6,
    receptionYards: 10,
    receptionTds: 6,
    twoPoints: 2,
    fumbles: -2
  };
  
  $scope.dataSource = new kendo.data.DataSource({
    transport: {
      read: {
        url: "/api/Players"
      }
    },
    pageSize: 25,
    filter: { field: "position", operator: "eq", value: "0" },
    schema: {
      model: {
        id: "playerId",
        fields: {
          playerId: { type: "number" },
          name: { type: "string" },
          position: { type: "string" },
          passingYards: { type: "number" },
          passingTds: { type: "number" },

        }
      }
    }
  });

  $scope.qbGridOptions = {
    dataSource: $scope.dataSource,
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
        title: "Passing Yards"
      },
      {
        field: "passTds",
        title: "Passing TDs"
      },
      {
        field: "Projection",
        template: function(dataItem) {
          return dataItem.passYards * $scope.settings.passYards + dataItem.passTds;
        }
      }
    ]
  };

  $scope.rbGridOptions = {
    dataSource: $scope.dataSource,
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
          title: "Rushing Yards"
        },
        {
          field: "rushTds",
          title: "Rushing TDs"
        }
    ]
  };

  $scope.refresh = function () {
    $scope.qbGrid.refresh();
  };

  $scope.tabChange = function (e) {
    var position = $(e.item).attr("data-position");
    $scope.dataSource.filter({ field: "position", operator: "eq", value: position });
  };
  //$("#rb-grid").kendoGrid({
  //  dataSource: dataSource,
  //  pageable: true,
  //  columns: [
  //      {
  //        field: "name",
  //        title: "Name"
  //      },
  //      {
  //        field: "teamId",
  //        title: "Team"
  //      },
  //      {
  //        field: "rushYards",
  //        title: "Rushing Yards"
  //      },
  //      {
  //        field: "rushTds",
  //        title: "Rushing TDs"
  //      }
  //  ]
  //});
}