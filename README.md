# InventoryTrackingApp
This application was designed for the Winter 2022 - Shopify Production Engineer/BackendDeveloper Intern Challenge. It is an inventory tracking web application for a logistics company.

# Table of Contents
* [Features](#features)
* [Screenshots](#screenshots)
* [Technologies Used](#technologies-used)
* [BackEnd Functionality](#backend-functionality)
* [Running Application](#running-application)

# Features
Basic CRUD functionality and exporting product data to a CSV file.
## Create
 - The "Create New Item" link will bring the user to a new page to enter the product data.
 - Click on "Create" button and the new item will be displayed in the inventory list.

## Edit 
 - Each product in the inventory list can be edited by clicking on the "Edit" link. 
 - Change the old data and select "Save" to update the product data.

## Delete
 - Each product in the inventory list can be removed by clicking on the "Delete" link.
 - A message to confirm your action will be displayed for the user.
 - Click "Delete" again and the product is permanently removed from the inventory list.
 - 
## List
 - All the inventory items are listed on the main page from the SQL database as the user enters the application. 

# Screenshots

# Technologies Used
- ASP.NET MVC 5 Framework
- C#
- Javascript
- HTML
- CSS
- SQL
- Deployed using Azure DevOps

# BackEnd Functionality
A SQL database is used to store the inventory items from the application.

# Running Application
Open the command line at the preferred location to clone the repository by executing the command below:
- git clone https://github.com/akorcsak/InventoryTrackingApp.git

Once the repository has been succesfully cloned, open the ImageRepo.sln in Visual Studio and run the application.

The application is also publicly deployed and can be accessed through this link: http://alevel23.asuscomm.com/inventorytracking
