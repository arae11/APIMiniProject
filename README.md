# ReadMe

## Project Description

We will be using the SpaceX API to create a test framework which tests the API responses and requests using RestSharp. As a team, we used GitHub as our Version Control System and utilised the Kanban board feature in GitHub to organise our sprints.

The aim of the project is to develop our understanding of API's and continue practicing the Agile framework in a team.

Our project definition of done is:

> - All MVP user stories coded
> - All MVP user stories tested
> - All code submitted to the Main branch
> - Product owner has reviewed and accepted the code

## Using the Framework

The framework consists of four service classes. Each class has a MakeRequestAsync method that will take in the object's ID and return a DTO and JSON object with data filled by the API. The Capsule service class also includes a method for returning how many launches the selected capsule has undertaken, which can be run after making the API request.

File view:
> Services
> >  - CapsuleService.cs
> >  - CrewService.cs
> >  - RocketService.cs
> >  - StarlinkSingleSateliteService.cs

## Project Deliverables 

1. A complete test framework for the REST API you have chosen. (This needs to test all the data in the RESPONSE and test at least 3 requests). 
2. A link to personal GitHub Repo with sufficient number of commits and use of Development branches (make your trainer a collaborator). 
3. A project board (GitHub or Trello) with a Scrum framework to help plan out the project. 

> - 6 columns - Product backlog, Sprint backlog, In progress, in Review, Done, Notes 
> - Include your Project Goal and Project DoD in the 'Notes' column 
> - **User stories** should be written from the perspective of the user ("1. As a User, I want to request information about a single postcode from the Postcode.io API, so that I receive data back about that postcode") 
> - Create **test cases** for each user story ("1.1 Given I make a GET request for a valid postcode, when I execute the request, then the status code should be 200") 
> - Create user stories for developing your testing framework ("2. Create Testing framework skeleton", "3.Create Single Postcode Service" etc) 
> - Tasks such as 'Update readme' can be their own **task** 

4. Detailed README.md file that explains how to use the framework. This should include instructions how you would collaborate further with the project if there was a group taking over the groups work. Include a class diagram 

5. Daily stand-up and review with your group should be done every day. 

6. In the README, include a breakdown of your sprint: 

   > - Include screenshot of your project board before you being your sprint and after you've complete your sprint 
   > - Include a summary of your review and retrospective 

7. You will present your work as 5 minutes demo of your API framework 

| **Criterion**                            | **Description**                                              | **Max mark** |
| ---------------------------------------- | ------------------------------------------------------------ | ------------ |
| **Extensiveness of** **API** **Testing** | How many API calls and returned values did you check?        | 10           |
| **Framework Code quality**               | Is your code organised into folders and classes? Have you separated out the HTTP call handling code? Do you have classes to represent the returned data? Are your tests organised into test classes? Do the test names document what they do? | 6            |
| **Process and reflection**               | Did you commit your work regularly with sensible messages? Are your instructions on how to use and improve the framework clear? Have you insightfully explained what you have learned from doing the project and what you would do differently next time? | 4            |
| **Total**                                |                                                              | **20**       |



## Class Diagrams

![image](https://user-images.githubusercontent.com/33132105/133653811-0aacafdd-d9fe-4c0e-8ae4-1ea63fb1f277.png)

## Sprints

### Sprint 1

#### Kanban Board at the start of the sprint
![Kanban board before](https://user-images.githubusercontent.com/60930006/133648472-8de225d4-2aca-4260-9fe1-f2e399f92266.png)

#### Sprint Goals
- Complete MVP
- Test MVP

#### Kanban Board at the end of the sprint
![Kanban board after](https://user-images.githubusercontent.com/60930006/133648619-a2346dc4-cc8b-4eb6-a753-1d0c4b6c172f.png)

#### Sprint Review
- Completed MVP
- Tested MVP
- Met sprint goals
- Met project DOD
- Collaborated well as a team

#### Sprint Retrospective

Positives
- Completed all MVP Stories
- Communication

Negatives
- Time out for other Activities
- Git Merge problems

Hindsight
- Review Git Branching before starting


