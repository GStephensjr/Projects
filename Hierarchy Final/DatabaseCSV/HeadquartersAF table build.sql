drop table if exists HeadquartersAF;

Create table HeadquartersAF
(
StaffName TEXT PRIMARY KEY,
Location TEXT NULL,
Commander TEXT NULL,
Mission TEXT NULL,
CommanderTitle TEXT NULL
);

insert into HeadquartersAF (StaffName, Location, Commander, Mission, CommanderTitle)
values('Air Staff', 'Pentagon', 'David L Goldfein', 'The Air Staff is primarily composed of uniformed U.S. Air Force officials who assist the Chief of Staff in carrying out his dual-hatted role: as the principal military advisor to the Secretary of the Air Force, and as a member of the Joint Chiefs of Staff.', 'Chief of Staff of the Air Force');

insert into HeadquartersAF (StaffName, Location, Commander, Mission CommanderTitle)
values('Office of the Secretary of the Air Force', 'Washington D.C.', 'Barbara Barnett', 'The Secretary of the Air Force (SecAF, or SAF/OS) is the head of the Department of the Air Force, a military department within the United States Department of Defense. The Secretary of the Air Force is a civilian appointed by the President, by and with the advice and consent of the Senate.The Secretary reports to the Secretary of Defense and/or the Deputy Secretary of Defense, and is by statute responsible for and has the authority to conduct all the affairs of the Department of the Air Force.', 'Secretary of the Air Force');
