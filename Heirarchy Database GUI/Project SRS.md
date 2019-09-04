## Title: Software Requirements Specification
## Author: Greg Stephens
## Date: 17 Aug, 2019

#### ID:FR1
**Title:** User Registration

**DESC:** Enable a user to create a profile by selecting a unique name and password. The first profile should be automatically be an admin. subsequent profiles are guests

**RAT:** In order for a user to register an account

**DEP:** None

#### ID:FR2

**Title:** User Logon

**DESC:** users with registered accounts can use their previously selected username and password to gain entry to the database

**RAT:** Log user on and grant access to information

**DEP:** FR1

#### ID:FR3

**Title:** Profile Upgrade

**DESC:** Enable an administrator to upgrade an existing user account, granting administrator privileges.

**RAT:** In order to give admin privileges to other users

**DEP:** FR1, FR2

#### ID:FR4

**Title:** Search Database entries

**DESC:** User must be able to enter keywords for information within the database. User will be able to filter by keywords, Majcom, wing, group, squadron

**RAT:** allow users to access the information

**DEP:** FR1


#### ID:FR5

**Title:** Data Modification

**DESC:** admins will be allowed to add entries as well as remove and modify searched entries in the database via the program. admin accounts will have a separate tab to allow these modifications that general users do not possess

**RAT:** allow administrators to modify data

**DEP:** FR1, FR2, FR3

#### ID:FR6

**Title:** Data Review

**DESC:** administrators who grant admin privileges will be able to see entries made by the accounts they've upgraded and void them if there is unverified/incorrect data entered

**RAT:** allow admins to scrub the database to keep integrity

**DEP:** FR1, FR2, FR4
