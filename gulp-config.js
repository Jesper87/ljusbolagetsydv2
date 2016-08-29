module.exports = function () {
	var instanceRoot = "C:\\inetpub\\wwwroot\\ljusbolagetv2"; 
  var config = {
  	websiteRoot: instanceRoot + "\\Website", //C:\inetpub\wwwroot\ljusbolaget\Website
  	libraries: instanceRoot + "\\Website\\bin",  //C:\inetpub\wwwroot\ljusbolaget\Website\bin
    //licensePath: instanceRoot + "\\Data\\license.xml", //C:\inetpub\wwwroot\ljusbolaget\Data\license.xml
    solutionName: "LjusbolagetSydV2",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}