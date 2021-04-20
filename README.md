# Project

**Basic Description:**
An app with CRUD functionality for household gardening. 
**Create:** Add a plant you've planted
**Read:** Read what's in your garden, and which gardens are in the list
**Delete:** Delete one that has died
**Update:** Update the record of the plant with when it next needs watering (in days) 

**Database Description:**
The app has 2 databases, one for plants, the other for gardens. The fields are their names, date planted, days till next water. 

Plants:

|Name|Date Planted|Last Watered|Garden|
|---|---|---|---|
|Bok Choy|19/04/2021|19/04/2021|Back|
|Swiss Chard|19/04/2021|19/04/2021|Back|
|Radish|19/04/2021|19/04/2021|Back|
|Cress|19/04/2021|19/04/2021|Windowsill|


Gardens:

|Name|
|---|
|Allotment|
|Front|
|Back|
|Greenhouse|


**Project Management:**
[User Stories, Tasks and Epics](https://dev.azure.com/kathrynmcgregor/Project-Plant-App)

**Risk Assessment**
Severity is understood to mean the degree of threat to the functionality (the create, update, delete and read) of the app.

|Risk|Likelihood|Severity|Control|Update
|---|---|---|---|---|
|Link doesn't work, or mistyped URL|Low|High|Test the hyperlinks and add in diversions for common mispellings|n/a
|U/D:Can't find name in table|High|High|Useful error message, like 'The name/dates/garden doesn't match records'|n/a
|C:Not enough fields are entered|High|High|Have required entries|n/a
|C/U/D:Incorrect format is entered into the form|High|High|Have input control, e.g. a placeholder and/or a drop down selection|n/a























