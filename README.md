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
|---|---|---|
|Bok Choy|19.04.2021|19.04.2021|Back|
|Swiss Chard|19.04.2021|19.04.2021|Back|
|Radish|19.04.2021|19.04.2021|Back|
|Cress|19.04.2021|19.04.2021|Windowsill|


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

|Risk|Likelihood|Severity|Control|Update
|---|---|---|---|---|
|Link doesn't work|Medium|High|Testing or divert|N/a
|Update or delete:can't find name in table|High|Medium|Have input control or useful error message|n/a
|Create:Not enough fields are entered|High|Low|Have default entries or required entries with useful error messages|n/a























