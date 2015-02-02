CREATE TABLE [dbo].[Customer_Info] (
    [Id]              INT          IDENTITY (1, 1) NOT NULL,
    [firstName]       VARCHAR (50) NOT NULL,
    [middleName]      VARCHAR (50) NULL,
    [lastName]        VARCHAR (50) NOT NULL,
    [phoneNumber]     VARCHAR (50) NOT NULL,
    [email]           VARCHAR (50) NOT NULL,
    [currentCustomer] NCHAR (10)   NULL,
    [firstContactDate] DATE NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

