CREATE TABLE [dbo].[Processos]
(
	[Numero] INT NOT NULL PRIMARY KEY, 
    [Requrente] NVARCHAR(MAX) NOT NULL, 
    [Requerido] NVARCHAR(MAX) NOT NULL, 
    [Dt_Abertura] DATE NOT NULL, 
    [Descricao] NVARCHAR(MAX) NOT NULL, 
    [Adv_Requerido] NVARCHAR(MAX) NULL, 
    [Adv_Requerente] NVARCHAR(MAX) NULL
)
