# TestProjects
Intention of this branch is to convert to .NET CORE 3.1.1
Project consists of 4 projects
1) NasaImages (a restfull WebAPI)
2) TestClient (a test client to consume the WebAPI and display the results)
3) NasaImagesWebsite (an MVC website to consume the WebAPI)
4) NasaImages.Tests (Unit test project for the WebAPI)

Project uses Visual Studio 2017. All nuget packages are included. If prompted, you can also download the latest packages or any missing packages
by usubng the Nuget console or command line
HOW TO USE:
1) copy all files in a local folder
3) Create a website (name it NasaImages) in IIS to point to <Root>\Source\WatchGuard\NasaImages
4) make sure you have this appSettings in the web.config -- key="Mars_Photos_URL" value="https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos"
5) app.config in the TestClient should have the correct values for the url. key="API_BaseURL" value="http://localhost/NasaImages/"
6) Make sute NasaImages.Tests project has this config entry. <add key="Mars_Photos_URL" value="https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos" />
7) Run the TestClient.exe from the debug folder.
8) Select a date from dropdown, Then click on the Download images. Wait till the images appear in the Grid on the left bottom.
  select a row to see the image for that row. 
  You can download a simgle image or all images for that day.

Highlights:
1) Uses Unity for Ioc. 
2) Uses repository pattern for web calls. Database calls (if needed in the future would use Entity framework 6.x. EF 6.x has DBcontext.
Visual Studio included IOC, Depedency injection, Unit of work as fist class citizen and they are included in VS 2017)
3) Centralized logging. Usingn NLOG
4) Centralized Error handeling.
5) ExecuteAsync override is used in a derived class to achive item number 3 and 4.
6) If this application is used to be accessed from a DMZ server, we need to create a wrapper service.
7) .NET 4.7.2 is used as per microsoft recommendations. This ensure a smooth transition to .NET CORE.
8) Serverless or API Gateway (AWS/AZURE) need .NET CORE and can be used for high usage functions following the FAAS.

Notes:
1) project should also have - authentication - preferable a third party provide.
2) dirty URL should be handled in all get calls.
3) other security measures like cross scripting should be hendled
4) Call to Webapi typically should be Asyn.
5) Load test is to be deprecated by Microsoft. I prefer using JMeter. This is the most popular open source load test.
6) API documentation is good enough with in-built Microsoft help files. But Swagger can be used to make it better.
7) Machine Learning CNN (Colvolutional Neural Network) can be used with TensorFlow or Python to categorize images with multi class algorithm.

