# specflow_issue_reproduce
related to https://github.com/SpecFlowOSS/SpecFlow/issues/2078



### works on my machine
dotnet test XUnitTestProject --configuration Release --logger "trx;LogFileName=XUnitTestProject.trx" --results-directory _.testsOutput /property:CollectCoverage=True /property:CoverletOutputFormat=opencover

### not on the azure devops CI
