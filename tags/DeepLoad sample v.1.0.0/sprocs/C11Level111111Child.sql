/****** Object:  StoredProcedure [GetC11Level111111Child] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GetC11Level111111Child]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [GetC11Level111111Child]
GO

CREATE PROCEDURE [GetC11Level111111Child]
    @CQarentID1 int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get C11Level111111Child from table */
        SELECT
            [Level_1_1_1_1_1_1_Child].[Level_1_1_1_1_1_1_Child_Name]
        FROM [Level_1_1_1_1_1_1_Child]
        WHERE
            [Level_1_1_1_1_1_1_Child].[CQarentID1] = @CQarentID1

    END
GO

/****** Object:  StoredProcedure [AddC11Level111111Child] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[AddC11Level111111Child]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [AddC11Level111111Child]
GO

CREATE PROCEDURE [AddC11Level111111Child]
    @Level_1_1_1_1_1_ID int,
    @Level_1_1_1_1_1_1_Child_Name varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into Level_1_1_1_1_1_1_Child */
        INSERT INTO [Level_1_1_1_1_1_1_Child]
        (
            [CQarentID1],
            [Level_1_1_1_1_1_1_Child_Name]
        )
        VALUES
        (
            @Level_1_1_1_1_1_ID,
            @Level_1_1_1_1_1_1_Child_Name
        )

    END
GO

/****** Object:  StoredProcedure [UpdateC11Level111111Child] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[UpdateC11Level111111Child]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [UpdateC11Level111111Child]
GO

CREATE PROCEDURE [UpdateC11Level111111Child]
    @Level_1_1_1_1_1_ID int,
    @Level_1_1_1_1_1_1_Child_Name varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [CQarentID1] FROM [Level_1_1_1_1_1_1_Child]
            WHERE
                [CQarentID1] = @Level_1_1_1_1_1_ID
        )
        BEGIN
            RAISERROR ('''C11Level111111Child'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in Level_1_1_1_1_1_1_Child */
        UPDATE [Level_1_1_1_1_1_1_Child]
        SET
            [Level_1_1_1_1_1_1_Child_Name] = @Level_1_1_1_1_1_1_Child_Name
        WHERE
            [CQarentID1] = @Level_1_1_1_1_1_ID

    END
GO

/****** Object:  StoredProcedure [DeleteC11Level111111Child] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DeleteC11Level111111Child]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [DeleteC11Level111111Child]
GO

CREATE PROCEDURE [DeleteC11Level111111Child]
    @Level_1_1_1_1_1_ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [CQarentID1] FROM [Level_1_1_1_1_1_1_Child]
            WHERE
                [CQarentID1] = @Level_1_1_1_1_1_ID
        )
        BEGIN
            RAISERROR ('''C11Level111111Child'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete C11Level111111Child object from Level_1_1_1_1_1_1_Child */
        DELETE
        FROM [Level_1_1_1_1_1_1_Child]
        WHERE
            [Level_1_1_1_1_1_1_Child].[CQarentID1] = @Level_1_1_1_1_1_ID

    END
GO
