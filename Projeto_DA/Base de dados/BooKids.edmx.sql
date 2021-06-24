
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/24/2021 15:01:56
-- Generated from EDMX file: C:\Users\andre\OneDrive\Documentos\GitHub\ProjetoDesenvolvimento\Projeto_DA\Base de dados\BooKids.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bookies];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EscolaFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_EscolaFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolaParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participacaos] DROP CONSTRAINT [FK_EscolaParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participacaos] DROP CONSTRAINT [FK_EventoParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboracaos] DROP CONSTRAINT [FK_EventoColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadorColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboracaos] DROP CONSTRAINT [FK_AnimadorColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscricaos] DROP CONSTRAINT [FK_EventoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compras] DROP CONSTRAINT [FK_ClienteCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompras] DROP CONSTRAINT [FK_CompraDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompras] DROP CONSTRAINT [FK_ProdutoDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProdutoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtoes] DROP CONSTRAINT [FK_TipoProdutoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_ClienteFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscricaos] DROP CONSTRAINT [FK_FilhoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_Filho_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_Filho_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Animador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Animador] DROP CONSTRAINT [FK_Animador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TipoProdutoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutoes];
GO
IF OBJECT_ID(N'[dbo].[Produtoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtoes];
GO
IF OBJECT_ID(N'[dbo].[DetalheCompras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheCompras];
GO
IF OBJECT_ID(N'[dbo].[Compras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compras];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Inscricaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inscricaos];
GO
IF OBJECT_ID(N'[dbo].[Eventoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eventoes];
GO
IF OBJECT_ID(N'[dbo].[Participacaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Participacaos];
GO
IF OBJECT_ID(N'[dbo].[Colaboracaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Colaboracaos];
GO
IF OBJECT_ID(N'[dbo].[Escolas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Escolas];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Filho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Filho];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Animador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Animador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TipoProdutoes'
CREATE TABLE [dbo].[TipoProdutoes] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produtoes'
CREATE TABLE [dbo].[Produtoes] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] int  NOT NULL,
    [CodTipoProduto] int  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [TipoProduto_CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'DetalheCompras'
CREATE TABLE [dbo].[DetalheCompras] (
    [Quantidade] smallint  NOT NULL,
    [ComprasNrCompra] int  NOT NULL,
    [ProdutosCodProduto] int  NOT NULL,
    [Compras_NrCompra] int  NOT NULL,
    [Produtos_CodProduto] int  NOT NULL,
    [Produtos_CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'Compras'
CREATE TABLE [dbo].[Compras] (
    [Data] datetime  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL,
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [IdCliente] int  NOT NULL,
    [ProdutosCodProduto] int  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Inscricaos'
CREATE TABLE [dbo].[Inscricaos] (
    [Confirmada] bit  NOT NULL,
    [FilhosIdPessoa] int  NOT NULL,
    [EventosNrEvento] int  NOT NULL,
    [Eventos_NrEvento] int  NOT NULL,
    [Filhos_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Eventoes'
CREATE TABLE [dbo].[Eventoes] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] datetime  NOT NULL,
    [LimitePartcipacoes] nvarchar(max)  NOT NULL,
    [IdadeInferior] int  NOT NULL,
    [IdadeSuperior] int  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Participacaos'
CREATE TABLE [dbo].[Participacaos] (
    [IdEscola] int  NOT NULL,
    [NrEvento] int  NOT NULL,
    [Escola_IdEscola] int  NOT NULL,
    [Evento_NrEvento] int  NOT NULL
);
GO

-- Creating table 'Colaboracaos'
CREATE TABLE [dbo].[Colaboracaos] (
    [NrEvento] int  NOT NULL,
    [IdAnimador] int  NOT NULL,
    [Eventos_NrEvento] int  NOT NULL,
    [Animadores_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Escolas'
CREATE TABLE [dbo].[Escolas] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Filho'
CREATE TABLE [dbo].[Pessoas_Filho] (
    [Sexo] int IDENTITY(1,1) NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [IdEscola] nvarchar(max)  NOT NULL,
    [IdProgenitor] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL,
    [Escolas_IdEscola] int  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Animador'
CREATE TABLE [dbo].[Pessoas_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [ValorOferta] nvarchar(max)  NOT NULL,
    [NrCartao] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoes'
ALTER TABLE [dbo].[TipoProdutoes]
ADD CONSTRAINT [PK_TipoProdutoes]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [CodProduto], [CodTipoProduto] in table 'Produtoes'
ALTER TABLE [dbo].[Produtoes]
ADD CONSTRAINT [PK_Produtoes]
    PRIMARY KEY CLUSTERED ([CodProduto], [CodTipoProduto] ASC);
GO

-- Creating primary key on [ComprasNrCompra] in table 'DetalheCompras'
ALTER TABLE [dbo].[DetalheCompras]
ADD CONSTRAINT [PK_DetalheCompras]
    PRIMARY KEY CLUSTERED ([ComprasNrCompra] ASC);
GO

-- Creating primary key on [NrCompra] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [PK_Compras]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [FilhosIdPessoa], [EventosNrEvento] in table 'Inscricaos'
ALTER TABLE [dbo].[Inscricaos]
ADD CONSTRAINT [PK_Inscricaos]
    PRIMARY KEY CLUSTERED ([FilhosIdPessoa], [EventosNrEvento] ASC);
GO

-- Creating primary key on [NrEvento] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [PK_Eventoes]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdEscola], [NrEvento] in table 'Participacaos'
ALTER TABLE [dbo].[Participacaos]
ADD CONSTRAINT [PK_Participacaos]
    PRIMARY KEY CLUSTERED ([IdEscola], [NrEvento] ASC);
GO

-- Creating primary key on [NrEvento], [IdAnimador] in table 'Colaboracaos'
ALTER TABLE [dbo].[Colaboracaos]
ADD CONSTRAINT [PK_Colaboracaos]
    PRIMARY KEY CLUSTERED ([NrEvento], [IdAnimador] ASC);
GO

-- Creating primary key on [IdEscola] in table 'Escolas'
ALTER TABLE [dbo].[Escolas]
ADD CONSTRAINT [PK_Escolas]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [PK_Pessoas_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [PK_Pessoas_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Escolas_IdEscola] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_EscolaFilho]
    FOREIGN KEY ([Escolas_IdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaFilho'
CREATE INDEX [IX_FK_EscolaFilho]
ON [dbo].[Pessoas_Filho]
    ([Escolas_IdEscola]);
GO

-- Creating foreign key on [Escola_IdEscola] in table 'Participacaos'
ALTER TABLE [dbo].[Participacaos]
ADD CONSTRAINT [FK_EscolaParticipacao]
    FOREIGN KEY ([Escola_IdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaParticipacao'
CREATE INDEX [IX_FK_EscolaParticipacao]
ON [dbo].[Participacaos]
    ([Escola_IdEscola]);
GO

-- Creating foreign key on [Evento_NrEvento] in table 'Participacaos'
ALTER TABLE [dbo].[Participacaos]
ADD CONSTRAINT [FK_EventoParticipacao]
    FOREIGN KEY ([Evento_NrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoParticipacao'
CREATE INDEX [IX_FK_EventoParticipacao]
ON [dbo].[Participacaos]
    ([Evento_NrEvento]);
GO

-- Creating foreign key on [Eventos_NrEvento] in table 'Colaboracaos'
ALTER TABLE [dbo].[Colaboracaos]
ADD CONSTRAINT [FK_EventoColaboracao]
    FOREIGN KEY ([Eventos_NrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoColaboracao'
CREATE INDEX [IX_FK_EventoColaboracao]
ON [dbo].[Colaboracaos]
    ([Eventos_NrEvento]);
GO

-- Creating foreign key on [Animadores_IdPessoa] in table 'Colaboracaos'
ALTER TABLE [dbo].[Colaboracaos]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([Animadores_IdPessoa])
    REFERENCES [dbo].[Pessoas_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimadorColaboracao'
CREATE INDEX [IX_FK_AnimadorColaboracao]
ON [dbo].[Colaboracaos]
    ([Animadores_IdPessoa]);
GO

-- Creating foreign key on [Eventos_NrEvento] in table 'Inscricaos'
ALTER TABLE [dbo].[Inscricaos]
ADD CONSTRAINT [FK_EventoInscricao]
    FOREIGN KEY ([Eventos_NrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoInscricao'
CREATE INDEX [IX_FK_EventoInscricao]
ON [dbo].[Inscricaos]
    ([Eventos_NrEvento]);
GO

-- Creating foreign key on [Clientes_IdPessoa] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[Compras]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [Compras_NrCompra] in table 'DetalheCompras'
ALTER TABLE [dbo].[DetalheCompras]
ADD CONSTRAINT [FK_CompraDetalheCompra]
    FOREIGN KEY ([Compras_NrCompra])
    REFERENCES [dbo].[Compras]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraDetalheCompra'
CREATE INDEX [IX_FK_CompraDetalheCompra]
ON [dbo].[DetalheCompras]
    ([Compras_NrCompra]);
GO

-- Creating foreign key on [Produtos_CodProduto], [Produtos_CodTipoProduto] in table 'DetalheCompras'
ALTER TABLE [dbo].[DetalheCompras]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([Produtos_CodProduto], [Produtos_CodTipoProduto])
    REFERENCES [dbo].[Produtoes]
        ([CodProduto], [CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoDetalheCompra'
CREATE INDEX [IX_FK_ProdutoDetalheCompra]
ON [dbo].[DetalheCompras]
    ([Produtos_CodProduto], [Produtos_CodTipoProduto]);
GO

-- Creating foreign key on [TipoProduto_CodTipoProduto] in table 'Produtoes'
ALTER TABLE [dbo].[Produtoes]
ADD CONSTRAINT [FK_TipoProdutoProduto]
    FOREIGN KEY ([TipoProduto_CodTipoProduto])
    REFERENCES [dbo].[TipoProdutoes]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProduto'
CREATE INDEX [IX_FK_TipoProdutoProduto]
ON [dbo].[Produtoes]
    ([TipoProduto_CodTipoProduto]);
GO

-- Creating foreign key on [Clientes_IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[Pessoas_Filho]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [Filhos_IdPessoa] in table 'Inscricaos'
ALTER TABLE [dbo].[Inscricaos]
ADD CONSTRAINT [FK_FilhoInscricao]
    FOREIGN KEY ([Filhos_IdPessoa])
    REFERENCES [dbo].[Pessoas_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilhoInscricao'
CREATE INDEX [IX_FK_FilhoInscricao]
ON [dbo].[Inscricaos]
    ([Filhos_IdPessoa]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------