## USE CASE: Authentication

#### Actors:
  - Customer
  - System

#### Trigger:
  - Customer needs access to the database for information

#### Precondition:
  - Customer must have already created a user profile

#### Post-Condition:
  - Customer will have access to the database through their user profile

#### Normal Flow:
1. user accesses the gui
2. the system will prompt the user for credentials (username, password)
3. user will input username and password
4. program accepts the inputs and identifies user with existing account
5. program logs user in, allowing access to the rest of the database

##### Alternate Flow:
A: user inputs incorrect/mismatching information
  1. system will inform the user that the information is incorrect
  2. system will reset to step 2
