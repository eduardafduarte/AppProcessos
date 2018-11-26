CREATE TABLE [dbo].[Processos] (
    [Numero]          INT            NOT NULL,
    [Requerente]      NVARCHAR (MAX) NOT NULL,
    [Tel_Requerente]  NCHAR (11)     NULL,
    [cpf]             NCHAR (15)     NOT NULL,
    [Requerido]       NVARCHAR (MAX) NOT NULL,
    [Dt_Abertura]     DATETIME       NOT NULL,
    [Descricao]       NVARCHAR (MAX) NOT NULL,
    [Adv_Requerido]   NVARCHAR (MAX) NULL,
    [Adv_Requerente]  NVARCHAR (MAX) NULL,
    [Dt_Movimentacao] DATETIME           NULL,
    [Movimentacao]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC)
);

