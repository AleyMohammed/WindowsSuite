CREATE TABLE [dbo].[Patient] (
    [Patient_ID]          INT          NOT NULL,
    [Patient_Fname]       VARCHAR (50) NOT NULL,
    [Patient_Lname]       VARCHAR (50) NOT NULL,
    [Patient_Address]     VARCHAR (50) NOT NULL,
    [Patient_PhoneNumber] VARCHAR (50) NOT NULL,
    [Gender_Patient] VARCHAR(9) NULL, 
    PRIMARY KEY CLUSTERED ([Patient_ID] ASC)
);

