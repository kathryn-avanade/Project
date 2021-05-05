# 1st Project 

**Brief**

I have been tasked with creating an app with **CRUD** functionality. 

The implementation of this project aims to cover all the core training modules, and as well as a functioning app, requires the following: 
1. A Trello board (or equivalent Kanban board tech) with full expansion
on user stories, use cases and tasks needed to complete the project.
It could also provide a record of any issues or risks that you faced
creating your project.
2. A relational database used to store data persistently for the
The project, this database needs to have at least 2 tables in it, to
demonstrate your understanding.
3. Clear Documentation from a design phase describing the architecture
you will use for your project as well as a detailed Risk Assessment.
4. A functional CRUD application created in C#, following best
practices and design principles, that meets the requirements set on
your Kanban Board
5. Fully designed test suites for the application you are creating, as well as automated tests for validation of the application. You must
provide high test coverage in your backend and provide consistently
reports and evidence to support a TDD approach.
6. A functioning front-end website and integrated API's, using ASP.NET. As a stretch goal, you can add an Angular based front-end.
7. Code fully integrated into a Version Control System using the
Feature-Branch model which will subsequently be built through a CI
server and deployed to a cloud-based virtual machine.

**My Idea**
My idea  is to create an app for household gardening, where the **CRUD** operations are as follows;
* **Create:** Add a plant you've planted that requires the fields:
  * Name
  * Date Planted
  * Date Last Watered
  * Garden
* **Read:** Read which plants you have added and which gardens they are in
* **Delete:** Delete a plant that has died or been dug up
* **Update:** Update the record of the plant with when it was last watered

**Project Management** 

I have used azure devops which you can find a link to here: 
[User Stories, Tasks and Epics](https://dev.azure.com/kathrynmcgregor/Project-Plant-App)

**App Architecture**

My **two tables** will be one for plants, containing their names, date planted, date last watered and garden, and the other will be for a list of gardens the plants have been planted in. Currently, only the plant table will have CRUD functionality. The garden table will also be created in the database but the app will only display a list of gardens that have been entered via the plant form entry. These both exist running on an azure virtual machine.

Plants:

|ID|Name|Date Planted|Last Watered|Garden|
|---|---|---|---|---|
|1|Bok Choy|19/04/2021|19/04/2021|Allotment|
|2|Swiss Chard|19/04/2021|19/04/2021|Front|
|3|Radish|19/04/2021|19/04/2021|Back|
|4|Cress|19/04/2021|19/04/2021|Greenhouse|

Gardens:

|ID|Name|
|---|---|
|1|Allotment|
|2|Front|
|3|Back|
|4|Greenhouse|

The **ERD** for these tables is shown below. The prority for this app is to have CRUD functionality on the plant table, however this could be extended further, and the relationshp between the plant and gardens table could be properly implemented in the future. A potential one to many (gardens to plants) relationship / one to one (plant to garden) relationship could be implemented.

![ERD Diagram](/ERD.png?raw=true)

**Risk Assessment**

The brief also requries a detailed **risk Assessment** which is as follows:
Severity is understood to mean the degree of threat to the functionality (the create, update, delete and read) of the app, and also the degree of threat to the security of the web app. 

|Risk|Likelihood|Severity|Control|Update
|---|---|---|---|---|
|Link doesn't work, or mistyped URL|Low|High|Test the hyperlinks and add in diversions for common mispellings|n/a
|C:Not enough fields are entered|High|High|Have required entries|n/a
|U:User tried to update the name,garden,date planted of a plant (this shouldn't change as once a plant has been created it can only be watered or dug up, in this case, the record should be deleted and remade)|Low|Low|Have read only entries and a proper home page description so that the user knows how to use the app |n/a
|C/U/D:Incorrect format is entered into the form|High|High|Have input control, e.g. a placeholder and/or a drop down selection|n/a
|Multiple users of a database at once|Low|High|Would have to check whether migrations are enough to keep c# code and azure database in sync (but haven't been taught this)|-
|Web server goes down|Low|High|Set up a backup virtual machine|-
|User enters the same entry twice|High|Low|This would make the database confusing, and lead to mismatches if the another record should have been updated|Have helpful messages such as 'You already have this entry in the database'|Yet to be implemented
|Accidental deletion of important files|Medium|High|Push to github after major changes and work on feature branches|Had a few problems with git (29.04.21) which made this risk very relevent, now I am more careful about where and what im pushing to github

 In the demonstration of my app you will be able to see the CRUD functionality is acheived. I will describe how the app has met the requirements on Azure Devops Boards in this section. **TODO**
 
**TESING**

My front end website has been created using Asp.net using MVCs. 
On my github you can see that I have used the feature branch model **TO DO**. I have deployed my app using an azure web app resource, the link for which is here **TODO ADD LINK**





















