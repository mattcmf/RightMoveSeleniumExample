
Feature: SearchForHouseE2E
	In order to buy a house
	As a home buyer with a fixed budget
	I want to view the houses for sale that I can afford 

	Scenario Outline: Search for 300k houses in Milton Keynes
		Given I am on the search page for the area <Location>
		When I have searched for a house with a 'max' budget of <MaxBudget>
		And a min <MinBeds> bedrooms and max <MaxBeds> bedrooms
		And I select find property
		Then I verify a listing with the <ListingProperty> : <PropertyName> is displayed
		Examples:
		| Location      | MinBudget | MaxBudget | MinBeds | MaxBeds | ListingProperty | PropertyName                                    |
		| Milton Keynes | 0         | 300,000   | 2       | 3       | address         | Oakgrove Village                                |
		| Milton Keynes | 0         | 300,000   | 2       | 3       | address         | Shelley Close, Newport Pagnell, Buckinghamshire |  

