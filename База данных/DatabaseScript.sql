-- Создаем базу данных только если она не существует
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HomeFinance')
BEGIN
    CREATE DATABASE HomeFinance;
END
GO

USE HomeFinance;
GO

IF OBJECT_ID('Транзакции', 'U') IS NOT NULL
    DROP TABLE Транзакции;
GO

IF OBJECT_ID('Категории', 'U') IS NOT NULL
    DROP TABLE Категории;
GO

CREATE TABLE Категории (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Название NVARCHAR(100) NOT NULL,
    Тип NVARCHAR(10) CHECK (Тип IN ('Доход', 'Расход')) NOT NULL
);
GO

CREATE TABLE Транзакции (
    Id INT PRIMARY KEY IDENTITY(1,1),
    КатегорияId INT NOT NULL FOREIGN KEY REFERENCES Категории(Id),
    Сумма DECIMAL(18,2) NOT NULL,
    Дата DATETIME NOT NULL DEFAULT GETDATE(),
    Описание NVARCHAR(255) NULL
);
GO

INSERT INTO Категории (Название, Тип) VALUES
('Зарплата', 'Доход'),
('Премия', 'Доход'),
('Подарки', 'Доход'),
('Продукты', 'Расход'),
('Коммунальные услуги', 'Расход'),
('Транспорт', 'Расход'),
('Развлечения', 'Расход'),
('Одежда', 'Расход'),
('Здоровье', 'Расход');
GO

INSERT INTO Транзакции (КатегорияId, Сумма, Дата, Описание) VALUES
(1, 50000, '20231001', 'Основная зарплата'),
(4, 15000, '20231005', 'Продукты на неделю'),
(5, 8000, '20231010', 'Квартплата'),
(6, 3000, '20231015', 'Проездной на месяц'),
(2, 10000, '20231020', 'Премия за проект'),
(7, 5000, '20231025', 'Поход в кино');
GO

IF OBJECT_ID('ОтчетПоКатегориям', 'P') IS NOT NULL
    DROP PROCEDURE ОтчетПоКатегориям;
GO

CREATE PROCEDURE ОтчетПоКатегориям
    @НачалоДаты DATE,
    @КонецДаты DATE
AS
BEGIN
    SELECT 
        к.Название AS Категория,
        к.Тип,
        COUNT(т.Id) AS КоличествоТранзакций,
        SUM(т.Сумма) AS ОбщаяСумма,
        CASE 
            WHEN к.Тип = 'Расход' THEN SUM(т.Сумма) * -1 
            ELSE SUM(т.Сумма) 
        END AS СуммаСУчетомТипа
    FROM Категории к
    LEFT JOIN Транзакции т ON к.Id = т.КатегорияId
    WHERE т.Дата BETWEEN @НачалоДаты AND @КонецДаты
    GROUP BY к.Название, к.Тип
    ORDER BY к.Тип, ОбщаяСумма DESC;
END;
GO