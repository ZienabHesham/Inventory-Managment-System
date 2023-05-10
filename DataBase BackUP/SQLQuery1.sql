INSERT INTO [dbo].[Employees]
           (
		   [Name]
           ,[Phone]
           ,[Email]
           ,[Salary])
     VALUES
           ('John Smith'
           ,'123-456-7890'
           ,'john.smith@email.com'
           ,5500.00)

		   INSERT INTO [dbo].[Employees]
           (
		   [Id],[Name]
           ,[Phone]
           ,[Email]
           ,[Salary])
     VALUES
           (2,'John Smith'
           ,'123-456-7890'
           ,'john.smith@email.com'
           ,50000.00),
           
           (3,'Jane Doe'
           ,'555-555-5555'
           ,'jane.doe@email.com'
           ,75000.00),
           
           (4,'Bob Johnson'
           ,'999-999-9999'
           ,'bob.johnson@email.com'
           ,100000.00);
		   /*//////////////////////////////////////////////// */
INSERT INTO [dbo].[Customers]
    ([Name]
    ,[Phone]
    ,[Fax]
    ,[Mobile]
    ,[Email]
    ,[Website])
VALUES
    ('John Doe'
    ,'555-1234'
    ,'555-5678'
    ,'555-9876'
    ,'johndoe@example.com'
    ,'www.example.com'),
    ('Jane Smith'
    ,'555-2345'
    ,'555-6789'
    ,'555-8765'
    ,'janesmith@example.com'
    ,'www.example.com'),
    ('Bob Johnson'
    ,'555-3456'
    ,'555-7890'
    ,'555-7654'
    ,'bobjohnson@example.com'
    ,'www.example.com')

			   /*//////////////////////////////////////////////// */
INSERT INTO [dbo].[Suppliers]
           ([Name]
           ,[Phone]
           ,[Fax]
           ,[Mobile]
           ,[Email]
           ,[Website])
     VALUES
           ('ABC Supplies'
           ,'555-1234'
           ,'555-5678'
           ,'555-9876'
           ,'info@abcsupplies.com'
           ,'www.abcsupplies.com'),
           ('XYZ Corporation'
           ,'555-2345'
           ,'555-6789'
           ,'555-8765'
           ,'sales@xyzcorp.com'
           ,'www.xyzcorp.com'),
           ('123 Industries'
           ,'555-3456'
           ,'555-7890'
           ,'555-7654'
           ,'contact@123industries.com'
           ,'www.123industries.com')
		   			   /*//////////////////////////////////////////////// */
INSERT INTO [dbo].[Stores] ([Name], [Address], [PersonInCharge_Id])
VALUES
('Store A', '123 Main St.', 1),
('Store B', '456 Elm St.', 2),
('Store C', '789 Oak St.', 3),
('Store D', '321 Maple St.', 4),
('Store E', '654 Pine St.', 4)
		   			   /*//////////////////////////////////////////////// */

INSERT INTO [dbo].[Products]
           ([Name]
           ,[Code]
           ,[MeasuringUnit]
		   ,[Store_Id]
		   )
     VALUES
           ('Apple', 'APL001', 'Kilogram', 1),
           ('Banana', 'BNN001', 'Dozen', 1),
           ('Orange', 'ORG001', 'Kilogram', 2),
           ('Milk', 'MLK001', 'Liter', 2)
		   	   /*//////////////////////////////////////////////// */

INSERT INTO [dbo].[SupplyOrders] 
([OrderNumber], [OrderDate],[StoreId], [SupplierId], [ProductionDate], [ExpiryDate])
VALUES
('1234', '2022-03-01', 1,1, '2022-02-01', '2022-05-01'),
('5678', '2022-03-02', 2,2, '2022-02-02', '2022-05-02'),
('9101', '2022-03-03', 3, 3,'2022-02-03', '2022-05-03'),
('1121', '2022-03-04', 4, 2,'2022-02-04', '2022-05-04'),
('3141', '2022-03-05', 5,1,'2022-02-05', '2022-05-05')

		   	   /*//////////////////////////////////////////////// */

INSERT INTO [dbo].[SupplyOrderItems] ([SupplyOrderId], [ProductId], [Quantity])
VALUES
(1, 1, 10),
(2, 2, 20),
(3, 3, 30)

		   	   /*//////////////////////////////////////////////// */
INSERT INTO [dbo].[IssueOrders]
           ([OrderNumber]
           ,[OrderDate]
           ,[SupplierId]
           ,[StoreId])
     VALUES
           ('EXP001', '2023-04-06', 1, 2),
           ('EXP002', '2023-04-05', 2, 1),
           ('EXP003', '2023-04-04', 3, 1),
           ('EXP004', '2023-04-03', 2, 2)
		   		   	   /*//////////////////////////////////////////////// */

INSERT INTO [dbo].[IssueOrderItems]
           ([IssueOrderId]
           ,[ProductId]
           ,[Quantity])
     VALUES
            (1, 1, 100),
           (1, 2, 50),
           (2, 3, 200),
           (3, 1, 75),
           (3, 3, 100)

	  		   		   	   /*//////////////////////////////////////////////// */

						   
INSERT INTO [dbo].[TransferOrders]
           ([OrderNumber],[OrderDate],
		   [SourceStoreId]
           ,[DestinationStoreId],[SupplierId],[ProductionDate]
           ,[ExpiryDate])
     VALUES
           ('EXP001','2021-05-15',1,2 ,1, '2022-04-07','2022-08-07'),
           ('EXP002','2022-05-15',2,1 ,2, '2022-03-04','2023-05-07'),
           ('EXP003','2021-06-15',3,1 ,3, '2022-01-07','2022-10-07')

		      /*//////////////////////////////////////////////// */

			  						   
INSERT INTO [dbo].[TransferOrders]
           ([OrderNumber],[OrderDate],
		   [SourceStoreId]
           ,[DestinationStoreId],[SupplierId],[ProductionDate]
           ,[ExpiryDate])
     VALUES
           ('EXP001','2021-05-15',1,2 ,1, '2022-04-07','2022-08-07'),
           ('EXP002','2022-05-15',2,1 ,2, '2022-03-04','2023-05-07'),
           ('EXP003','2021-06-15',3,1 ,3, '2022-01-07','2022-10-07')

		   
		      /*//////////////////////////////////////////////// */

INSERT INTO [dbo].[TransferOrderItems]
           ([TransferOrderId],[ProductId],
		   [Quantity] )
     VALUES
           (1,1,10),
		   (2,2,20),
		   (3,3,30)