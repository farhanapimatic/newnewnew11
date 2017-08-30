# Getting started

WSDL File for HelloService

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (TestingOAuth20.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the TestingOAuth20 library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

### 3. Add reference of the library project

In order to use the TestingOAuth20 library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` TestingOAuth20.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```TestingOAuth20.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Testing%20OAuth2.0-CSharp&workspaceName=TestingOAuth20&projectName=TestingOAuth20.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthClientId | OAuth 2 Client ID |
| oAuthRedirectUri | OAuth 2 Redirection endpoint or Callback Uri |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
string oAuthRedirectUri = "oAuthRedirectUri"; // OAuth 2 Redirection endpoint or Callback Uri

TestingOAuth20Client client = new TestingOAuth20Client(oAuthClientId, oAuthRedirectUri);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [HelloBinding](#hello_binding)

## <a name="hello_binding"></a>![Class: ](https://apidocs.io/img/class.png "TestingOAuth20.PCL.Controllers.HelloBinding") HelloBinding

### Get singleton instance

The singleton instance of the ``` HelloBinding ``` class can be accessed from the API Client.

```csharp
HelloBinding helloBinding = client.HelloBinding;
```

### <a name="say_hello"></a>![Method: ](https://apidocs.io/img/method.png "TestingOAuth20.PCL.Controllers.HelloBinding.SayHello") SayHello

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add a method description


```csharp
Task<Models.SayHelloResponseModel> SayHello(Models.SayHelloRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.SayHelloRequestModel();

Models.SayHelloResponseModel result = await helloBinding.SayHello(body);

```


[Back to List of Controllers](#list_of_controllers)



