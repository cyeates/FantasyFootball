
var ProjectionCalculator = (function (settings) {

  var getPassingProjection = function(dataItem) {
    return (dataItem.passYards / settings.get("passYards")) + (settings.get("passTds") * dataItem.passTds);
  };

  return {
    
    calculate: function (dataItem) {
      return getPassingProjection(dataItem);
    }
  };
}());
