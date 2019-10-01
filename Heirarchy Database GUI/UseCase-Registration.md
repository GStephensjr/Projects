## USE CASE: Authentication

#### Actors:
  - Customer
  - System

#### Trigger:
  - Customer needs an account to access the database for information

#### Precondition:
  - Customer must not have already created a user profile

#### Post-Condition:
  - Customer will have an account access the database

#### Normal Flow:
1. user accesses the gui
2. the system will prompt the user for credentials (username, password)
3. user will input username and password
4. program accepts the inputs and creates a basic profile with the information
5. system redirects user to the home page

##### Alternate Flow:
A: user inputs an existing username
  1. system will inform the user that the account already exists
  2. system will reset to step 2
