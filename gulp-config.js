module.exports = function () {
	var instanceRoot = "C:\\inetpub\\wwwroot\\ljusbolagetv2"; 
  var config = {
  	websiteRoot: instanceRoot + "\\Website", 
  	libraries: instanceRoot + "\\Website\\bin", 
    solutionName: "LjusbolagetSydV2",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}