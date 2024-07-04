

Install Visual Studio and .NET Core
(1) Install Visual Studio
(2) .NET Core
(3) Start Visual Studio.
(4) On the menu bar, choose File, Open, Project/Solution.

Install Nuget package
Right-click on your project and click “Manage NuGet Packages”.
Search for "RestSharp and Newtontonsoft.Json" and install it

Install Selenium
Right-click on your project and click “Manage NuGet Packages”.
Search for "Selenium.Support and Selenium.Webdriver" and install it

The UI tests
TestFeatureUI.feature file contains the 3 UI test scenarios.
TestUISteps.cs- The step definitions for the feature file is added in this file. 

The API tests
APILevelTests.cs - The 3 API level tests are added here
Models - Response model classes for getuser, createuser and update user responses are added. 
TestSteps.cs and Helper.cs - API tests are defined with the help of these 2 files. 

Below packages are needed to run this project:
BoDi.1.5,0
DotNetSeleniumExtras.WaitHelpers.3,11.0
Gherkin.19.0.3
Microsoft.Bcl.AsyncInterfaces.8.0.0
MSTest.TestAdapter.2,1,1
MSTest.TestFramework.2.1.1
Newtonsoft.Json.13.0.3
NUnit.3,13,1
RestSharp.111.3.0
Selenium.Support. A.22.0
Selenium.WebDriver.4.22.0
SpecFlow,3.9.74
SpecFlow.Internal.Json.1.0.8
SpecFlow.NUnit.3,9,74
SpecFlow.Tools.MsBuild.Generation. 3.9.74
System.Buffers.4.5.1
System.Memory,4.5.5
System.Numerics.Vectors.4.5.0
System.Runtime.CompilerServices.Unsafe.6.0.0
System.Text.Encodings.Web.8.0.0
System.Text.Json.8.0.3
System.Ihreading Tasks.Extensions,45.4
System.Valueluple.4.5.0
