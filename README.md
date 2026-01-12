Trade & Position REST API – .NET

Overview :
This project implements a RESTful API using ASP.NET Core (.NET) that simulates a trade capture and position calculation system
The service:
	•	Accepts trade details via REST API  
	•	Stores trades in memory  
	•	Calculates positions per instrument  
	•	Exposes endpoints to retrieve trades and positions 
  
Tech Stack:
	•	.NET 8  
	•	ASP.NET Core Web API  
	•	Swagger  
	•	In-Memory Data Store


API Endpoints :
	1	Capture Trade  POST /api/trades  
Request Body: {
  "instrument": "CDSIndex",
  "quantity": 100,
  "price": 150
}
Notes:
	•	quantity > 0 indicates a Buy trade  
	•	quantity < 0 indicates a Sell trade  



	2	Retrieve All Trades  GET /api/trades  
Sample Response: [
  {
    "id": "09667a8a-03cb-49a4-8fc6-bf8e846e1115",
    "instrument": "CDSIndex",
    "quantity": 100,
    "price": 150,
    "tradeDate": "2026-01-12T08:39:25.766722Z"
  }
]




	3	Retrieve Positions GET /api/positions
Sample Response: [
  {
    "instrument": "CDSIndex",
    "netQuantity": 100,
    "averagePrice": 150
  }
]




Position Calculation Logic :
Net Quantity: Sum of quantities for an instrument.
Average Price (Weighted Average): Sum(quantity × price) / Sum(quantity)
Example:
Trade 1: Buy 100 @ 150 Trade 2: Buy 150 @ 300 Trade 3: Sell 50 @ 100
Net Quantity = 100 + 150 − 50 = 200
Average Price = (100×150 + 150×300 − 50×100) / 200 = 237.5



Running the Application :-
Prerequisites:
	•	Install .NET 8 SDK
    Swashbuckle.AspNetCore (Swagger) Nuget Package

Steps to Run:
	1	Navigate to the project root
	2	Run the following commands:
dotnet restore dotnet run --project src/TradePositionApi/TradePositionApi.csproj



Swagger UI :
Open the following URL in your browser:
http://localhost:5250/swagger
Swagger allows:
	•	Posting trades
	•	Retrieving trades
	•	Retrieving positions






