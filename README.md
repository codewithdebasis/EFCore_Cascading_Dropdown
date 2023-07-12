# EFCore_Cascading_Dropdown

This repository contains code samples related to  how we can design or develop any dependent or cascading dropdown control in Asp.net Core MVC Application. While developing any application using any language, sometimes we must define dropdown control that populates data from the backend part, i.e., from the database section. So, control directly fetches data from the database by using APIs and displays it in the dropdown control. But, sometimes, we need to implement the dependent dropdown control. It means the value of the dependent dropdown control depends on another. So, as per the selected value of the first dropdown control, we need to pass that value to the database side with the help of a parameter, and then as per that value, it will return the corresponding values to bind the second control. 

## Pre-Requisites
We must create a sample application using Asp.Net Core to demonstrate the functionality. For that purpose, we will use the .Net 7.0 framework. So, we need the below tools as a pre-requisite.
01.	Visual Studio 2022 Community Edition / Visual Studio Code
02.	.Net 7.0 SDK (only required if we use Visual Studio Code as Code Editor).
