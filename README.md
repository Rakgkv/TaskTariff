# TaskTariff

* Tariff Comparison Develop a model to build up the following two products and to compare these products based on their annual costs. * * The comparison should accept the following input parameter:
  * Consumption (kWh/year) and create a list of these products with the columns.
  * Tariff name,Annual costs (€/year) The list should be sorted by costs in ascending order.
 
## Getting Started

* All the code required to get started Clone this repo to your local machine using https://github.com/Rakgkv/TaskTariff 
* Build the TaskTariff project and Run ,Pass consumption Parameter.
  * Sample URL: http://localhost:5000/api/tariff/5000
  * Output: ["1. Packaged tariff : 1100 Euros","2. Basic electricity tariff : 1160 Euros"]

### Prerequisites

* Visual studio 2017
* .Net core 2.1 Version.
* Xunit 2 test framwork with LightBdd.

## Technical specification:

* language / runtime selected: C# / .NET Core
* Development model: Behaviour driven development using LightBDD framework
* Design:

  * Three layer architecture:
   * Model - Represents the data model class (eg, ProductModel).
   * DataAccess - DataAccess logic goes here. Used interface pattern to create different implementation of IProduct interface (eg. ProductA and ProductB)
   * Service - This layer consumes domain layer, which makes it a better candidate for Dependency Injection.

## Features:

* Model to build up the two products and to compare these products based on their annual
costs. The comparison should accept the following input parameter: Consumption (kWh/year) .
and create a list of these products with the columns
  * Tariff name
  * Annual costs (€/year)
* The list should be sorted by costs in ascending order. 
   * example: http://localhost:5000/api/tariff/5000
   * output: ["1. Packaged tariff : 1100 Euros","2. Basic electricity tariff : 1160 Euros"]


## Running the tests.
* Build and run the TaskTariff.Spec 
* BDD reports are added into repository, for easy access (see below section).
* BDD Test report URL
   * https://htmlpreview.github.io/?https://github.com/Rakgkv/TaskTariff/blob/master/TaskTariff.spec/Reports/FeaturesReport.html



