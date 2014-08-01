
app.factory("projectionCalculator", function () {
  
  var getPassingProjection = function(dataItem, settings) {
    return (dataItem.passYards / settings.passYards) + (dataItem.passTds * settings.passTds) - (dataItem.passInt * settings.passInt);
  };

  var getRushingProjection = function(dataItem, settings) {
    return (dataItem.rushYards / settings.rushYards) + (dataItem.rushTds * settings.rushTds);
  };

  var getReceivingProjection = function(dataItem, settings) {
    return (dataItem.receptionYards / settings.receptionYards) + (dataItem.receptionTds * settings.receptionTds) + (dataItem.receptions * settings.receptions);
  };

  var getMiscProjection = function(dataItem, settings) {
    return (dataItem.fumbles * settings.fumbles) + (dataItem.twoPts * settings.twoPts);
  };

  return {
    
    calculate: function (dataItem, settings) {
      return getPassingProjection(dataItem, settings) + getRushingProjection(dataItem, settings) +
             getReceivingProjection(dataItem, settings) + getMiscProjection(dataItem, settings);
    }
  };
});
