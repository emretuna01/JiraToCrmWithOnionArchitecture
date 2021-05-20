<h2 align="left">WebProjectsWithOnionArchitecture</h2>
<p>
In this project Jira Service Management by Atlassian and CRM Dynamics 365 by Microsoft are integrated. In general Jira is used for software support services whereas Dynamics 365 is used for combining CRM and ERP capabilities or to track business processes and costs.
</p>

<h3> Design Pattern,Libraries, technologies and databases used in this project:</h3>
<ul>
<li>CQRS</li>
<li>MediatR</li>
<li>Restsharp</li>
<li>RateLimit</li>
<li>Automapper</li>
<li>Fluent Validation</li>
<li>Entity Framework Core</li>
<li>SQLlite</li>
</ul>
<h3> Details of the Project:</h3>


<img align="right" src="https://www.gencayyildiz.com/blog/wp-content/uploads/2021/03/Nedir-Bu-Onion-Architecture-1.png" width="400">

<p align="left">
This application is written in ASP.NET core framework. For more details on onion architecture and reference project you can check: 
<a href="https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/">this</a>
<a href="https://codewithmukesh.com/blog/onion-architecture-in-aspnet-core/">or this</a>
</p>
<p align="left">
There are mainly 5 layers in this project which can be listed in 3 main groups:

Group 1: Core;
  
This group includes Domain and Application layers as seen in the Fig.1. Domain layer is the absolute core of the whole application and it is solely in charge of storing entities that will be used by the application. On the other hand, Application layer stores interfaces, DTO objects, and classes that will be used in cqrs pattern.

Group 2: Infrastructure;
  
It contains two layers: infrastructure and persistence. The former stores classes that will be used in the integration of third party applications whereas the latter stores classes that are related to database of the application.

 
Group 3: Presentation;
  
It includes presentation layer in which interfaces that are shown to users are designed.

In onion architectures the direction is from the outside in. The need for a side referencing should be met by creating a common sub layer.
</p>
