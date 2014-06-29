USE Fitness
GO

INSERT dbo.Recipes (Title, Directions, Ingredients)
	VALUES ('Tilapia Soup', 'Add soup. Add tilapia.', 'tilapia, soup')
GO

INSERT dbo.Recipes (Title, Directions, Ingredients)
	VALUES ('Chicken Salad', 'Put lettuce in bowl.\nShred Chicken.\nApply olive oil.', 'Lettuce, chicken, olive oil')
GO

INSERT dbo.Recipes (Title, Directions, Ingredients)
	VALUES ('Salmon Fillet', 'Cut salmon, apply butter.\nSeason and let it soak in.', 'Salmon, butter, pepper, salt')
GO

INSERT dbo.Recipes (Title, Directions, Ingredients)
	VALUES ('Turkey & Cranberry', 'Bake turkey 2 hours.\nApply cranberry sauce.', 'Turkey, cranberry')
GO

select *
from dbo.Recipes recipes