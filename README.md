# 1st Project 
**Contents**
---------------

[Brief](#Brief)

[My Idea](#MyIdea)

[Project Management](#ProjMan) 

[App Architecture](#AppArch)

[Risk Assessment](#Risk)

[Testing](#Testing)

[Front-End Design](#FD)

[Known Issues](#Issues)

[Future Improvements](#Future)

[Project Diary](#Diary)

<span id="Brief"></span>
**Brief**
---------------

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


<span id="MyIdea"></span>
**My Idea**
---------------

My idea  is to create an app for household gardening, where the **CRUD** operations are as follows;
* **Create:** Add a plant you've planted that requires the fields:
  * Name
  * Date Planted
  * Date Last Watered
  * Garden
* **Read:** Read which plants you have added and which gardens they are in
* **Delete:** Delete a plant that has died or been dug up
* **Update:** Update the record of the plant with when it was last watered

To further explain my idea, I have written a short description for the user:

"Enter the name of your plant, the garden in which it is planted, the date it was planted and when it was last watered. Click 'plants' in the navigation
    bar to see all the plants in the database and see where they have been planted. Click the 'water' link to update the record when you have watered a plant. 
    If your plant unfortunately dies, click 'dig up' next to the plant record."


<span id="ProjMan"></span>
**Project Management** 
---------------

* I have used azure devops which you can find a link to here: 
[User Stories, Tasks and Epics](https://dev.azure.com/kathrynmcgregor/Project-Plant-App)
* I have also kept a diary with details on what was done and when, in addition to this documentation. You can find this here.
* In regards to **continuous integration**, I aim to produce code on my local computer, push this to github, which should automatically push this code to azure devops. Here, tests and reports should be automatically run, and then the app should be built and deployed using a pipeline.  


<span id="AppArch"></span>
**App Architecture**
---------------

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


<span id="Risk"></span>
**Risk Assessment**
---------------

* The brief also requries a detailed **risk Assessment** which is in the table below.
* The type of risks considered include the technical side of the project, whether the servers and technologies work reliably (external) and also whether there are risks assocaited with the technical implementation of the app (internal). There are other risks associated with the organization and project management which I have also included. 
* Severity is understood to mean the degree of threat to the functionality (the create, update, delete and read) of the app, and also the degree of threat to the security of the web app. 
* The update field is used to indicated whether these risks were actually encountered, when they were encountered and what was done about them. 

|Risk|Likelihood|Severity|Control|Update
|---|---|---|---|---|
|Link doesn't work, or mistyped URL|Low|High|Test the hyperlinks and add in diversions for common mispellings using routing|Yet to be implemented
|Create: Not enough fields are entered|High|High|Have required entries|Added required fields
|Update: User tried to update the name,garden,date planted of a plant (this shouldn't change as once a plant has been created it can only be watered or dug up, in this case, the record should be deleted and remade)|Low|Low|Have read only entries and a proper home page description so that the user knows how to use the app |Added description
|C/U/D:Incorrect format is entered into the form|High|High|Have input control, e.g. a placeholder and/or a drop down selection|Yet to be implemented
|Multiple users of a database at once|Low|High|Would have to check whether migrations are enough to keep c# code and azure database in sync (but haven't been taught this)|Not sure how to do this
|Web server goes down|Low|High|Set up a backup virtual machine|Not sure how to do this
|User enters the same entry twice|High|Low|This would make the database confusing, and lead to mismatches if the another record should have been updated. Have helpful messages such as 'You already have this entry in the database'|Yet to be implemented
|Accidental deletion of important files|Medium|High|Push to github after major changes and work on feature branches|Had a few problems with git (29.04.21) which made this risk very relevent, now I am more careful about where and what im pushing to github

 In the demonstration of my app you will be able to see the CRUD functionality is acheived. I will describe how the app has met the requirements on Azure Devops Boards in this section. **TODO**
 
 
<span id="Testing"></span>
**Testing**
---------------

The test requirements for the project required a high level of test coverage using unit testing; I aimed to acheive **65% coverage** by testing my controllers in my MVC app. 
I used **Xunit** testing for this project, using an **"Arrange", "Act", and "Assert"** structure. Ideally, all methods in all controllers would be tested. This includes testing the method returns a view, and also that it performs the correct alteration of the database in the create, delete and edit methods. To test the app further would require integration, functional and load/stress testing, as unit testing isolates the part of your code from it's dependancies and infrastructure. 


This proved to be a difficult and long process, due to the need to rewrite the code using a repository pattern and mocking. I managed to write a five tests, testing my Home and Garden controllers completely, and generate a **coverage report** (included below). I used XUnit testing, ensuring I kept to best practises by keeping all tests associated with seperate controllers in serparate folders. To generate the report, I used "XPlat Code Coverage" and then generated a html report which you can see screenshots of below.

![Summary](/Summary.png?raw=true)
![Home](/Home.png?raw=true)
![GardenPlant](/GardenPlant.png?raw=true)

Deployment 

Deploying requires creating a pipeline and an Ubuntu 18.04 VM build agent (A build agent is a server that allows pipeline jobs to run on it) with SSH keys configured in an agent pool called plant-pool. 
The steps involved in deploying this app will be:
1.	Restore the dependencies 
2.	Build and compile 
3.	Publish the project to an artefact repository
4.	Run the compiled code

Unfortunately I ran out of time, and couldn't fix my pipeline/deployment process to restore the dependencies in the project. 

<span id="FD"></span>
**Front-End Design**
---------------
![Home](/HomePage.png?raw=true)
![Create](/CreatePage.png?raw=true)
![read](/ReadPage.png?raw=true)
![details](/DetailsPage.png?raw=true)
<span id="Issues"></span>

**Known Issues**
---------------
There are a couple of problems I wasn't able to fix within the time of this project, they include: 
* Need to change the dates into some kind of date type, and the form to request a date type for proper input and data control 
* The list of gardens can contain multiple of the same garden, which isn’t ideal
* If a plant has a unique garden and the plant is deleted, the garden still shows in the database which is misleading 

<span id="Future"></span>
**Future Improvements**
---------------

As well as solving the problems that I stated in the section above, I would like to extend the functionality of the app to:
* Enable CRUD on the gardens table 
* Enable searches to be performed on the database to find out which plants needed to be watered / where in a specific garden
* Enable the user to add a picture or a photo of the plant

<span id="Diary"></span>
**Project Diary**
---------------

















