
Feature: SearchForHouse_Location
	In order to buy a house
	As a home buyer with a fixed budget
	I want to view the houses for sale that I can afford 

	Scenario Outline: Search by Location
		Given I am on the search page for the area <Location>
		When I have searched for a house with a 'min' budget of <MinBudget>
		And I have searched for a house with a 'max' budget of <MaxBudget>
		And a min <MinBeds> bedrooms and max <MaxBeds> bedrooms
		And I select find property
		Then I verify a listing with the <ListingProperty> : <PropertyName> is displayed
		Examples:
		| Location      | MinBudget | MaxBudget | MinBeds | MaxBeds | ListingProperty | PropertyName                                            |
		| Milton Keynes | 1,000,000 | No max    | 2       | No max  | address         | Ashford Crescent, Milton Keynes                         |
		| Daventry      | 300,000   | No max    | 2       | No max  | address         | Scythe Road, Daventry, Northamptonshire, NN11           |
		| Northampton   | 1,000,000 | No max    | 2       | No max  | address         | Vyse Road, Boughton, Northampton, Northamptonshire, NN2 |


	Scenario Outline: Search by Location-NegativeScenarios
		Given I am on the search page for the area <Location>
		When I have searched for a house with a 'min' budget of <MinBudget>
		And I have searched for a house with a 'max' budget of <MaxBudget>
		And a min <MinBeds> bedrooms and max <MaxBeds> bedrooms
		And I select find property
		Then I verify a listing with the <ListingProperty> : <PropertyName> is NOT displayed
		Examples:
		| Location      | MinBudget | MaxBudget | MinBeds | MaxBeds | ListingProperty | PropertyName                                            |
		| Northampton   | 1,000,000 | No max    | 2       | No max  | address         | Ashford Crescent, Milton Keynes                         |
		| Milton Keynes | 300,000   | No max    | 2       | No max  | address         | Scythe Road, Daventry, Northamptonshire, NN11           |
		| Daventry      | 1,000,000 | No max    | 2       | No max  | address         | Vyse Road, Boughton, Northampton, Northamptonshire, NN2 |