# Blazor Application

#### 1) make sure that you executed all the required sql trigger/function procedures in scriptdb.sql file which is included in DbFile folder, since it is necessary for application to function as expected.

#### 2)make sure that connection strings in dbcontext and systemlogs.cs file points to your local sql server instance.

#### 3) make sure that application.server.exe is running in the background while you are running the application. you can find exe file under
..\Application\Server\bin\Debug\net5.0\application.server
if you dont want to use application.server.exe you must start the project as multiple projects. rigth click project solution->properties->Multiple startup projects->select start option for application.client and application.server. in this case dont forget to change Baseurl in Application.Client/program.cs 

![grab-landing-page](https://github.com/Emel212/https://github.com/Emel212/Application/blob/master/captures/gif1.gif)



![grab-landing-page](https://github.com/Emel212/https://github.com/Emel212/Application/blob/master/captures/gif2.gif)



