CREATE TABLE [dbo].[Room]
(
	[Room_num] INT NOT NULL , 
    [Patient_ID] INT NOT NULL, 
    [Staff_ID] INT NOT NULL, 
    [Admission_Date] DATE NOT NULL, 
    PRIMARY KEY ([Room_num]), 
    
)
