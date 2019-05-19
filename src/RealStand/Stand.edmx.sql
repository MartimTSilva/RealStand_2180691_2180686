
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2019 14:50:21
-- Generated from EDMX file: C:\Users\Micael\Documents\GitHub\RealStand_2180691_2180686\src\RealStand\Stand.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RealStand];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_ClienteCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_ParcelaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcelas] DROP CONSTRAINT [FK_ParcelaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguers] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_AluguerCarroAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguers] DROP CONSTRAINT [FK_AluguerCarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servicos] DROP CONSTRAINT [FK_ServicoCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Parcelas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcelas];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Servicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servicos];
GO
IF OBJECT_ID(N'[dbo].[Aluguers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluguers];
GO
IF OBJECT_ID(N'[dbo].[Carros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroVenda];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroAluguer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] int  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Parcelas'
CREATE TABLE [dbo].[Parcelas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoId] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [ClienteId] int  NOT NULL,
    [CarroVenda_Id] int  NOT NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataEntrega] datetime  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DataSaida] datetime  NOT NULL,
    [CarroOficinaId] int  NOT NULL
);
GO

-- Creating table 'Aluguers'
CREATE TABLE [dbo].[Aluguers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Kms] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [CarroAluguerId] int  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] int  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carros_CarroOficina'
CREATE TABLE [dbo].[Carros_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroVenda'
CREATE TABLE [dbo].[Carros_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroAluguer'
CREATE TABLE [dbo].[Carros_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [PK_Parcelas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aluguers'
ALTER TABLE [dbo].[Aluguers]
ADD CONSTRAINT [PK_Aluguers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [PK_Carros_CarroOficina]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [PK_Carros_CarroVenda]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [PK_Carros_CarroAluguer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[Carros_CarroOficina]
    ([ClienteId]);
GO

-- Creating foreign key on [ServicoId] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [FK_ParcelaServico]
    FOREIGN KEY ([ServicoId])
    REFERENCES [dbo].[Servicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParcelaServico'
CREATE INDEX [IX_FK_ParcelaServico]
ON [dbo].[Parcelas]
    ([ServicoId]);
GO

-- Creating foreign key on [ClienteId] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([ClienteId]);
GO

-- Creating foreign key on [CarroVenda_Id] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_Id])
    REFERENCES [dbo].[Carros_CarroVenda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[Vendas]
    ([CarroVenda_Id]);
GO

-- Creating foreign key on [ClienteId] in table 'Aluguers'
ALTER TABLE [dbo].[Aluguers]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[Aluguers]
    ([ClienteId]);
GO

-- Creating foreign key on [CarroAluguerId] in table 'Aluguers'
ALTER TABLE [dbo].[Aluguers]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguerId])
    REFERENCES [dbo].[Carros_CarroAluguer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[Aluguers]
    ([CarroAluguerId]);
GO

-- Creating foreign key on [CarroOficinaId] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_ServicoCarroOficina]
    FOREIGN KEY ([CarroOficinaId])
    REFERENCES [dbo].[Carros_CarroOficina]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoCarroOficina'
CREATE INDEX [IX_FK_ServicoCarroOficina]
ON [dbo].[Servicos]
    ([CarroOficinaId]);
GO

-- Creating foreign key on [Id] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Carros]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Carros]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Carros]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------