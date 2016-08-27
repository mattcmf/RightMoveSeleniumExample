
Feature: SearchForHouse_Budget
	In order to buy a house
	As a home buyer with a fixed budget
	I want to view the houses for sale that I can afford 

	Scenario Outline: Verify the budget can be used to filter property listings
		Given I am on the search page for the area <Location>
		When I have searched for a house with a 'max' budget of <MaxBudget>
		And I select find property
		Then I verify a listing with the <ListingProperty> : <PropertyName> is displayed
		Examples:
		| Location      | MinBudget | MaxBudget  | MinBeds | MaxBeds | ListingProperty | PropertyName                               |
		| Milton Keynes | 0         | 100,000    | 2       | 3       | address         | Harebell Close, Walnut Tree, Milton Keynes |
		| Milton Keynes | 0         | 1,000,000  | 2       | 3       | address         | Dynasty Drive, Bletchley, Milton Keynes    |
		| Milton Keynes | 0         | 10,000,000 | 2       | 3       | address         | Oakgrove Village                           |

	Scenario Outline: Invalid Ratio Selections
		Given I am on the search page for the area <Location>
		When I have searched for a house with a 'max' budget of <MaxBudget>
		And I select find property
		#Descoping line below as part of current work
		#Should show warning invalid selection
		Examples:
		| Location      | MinBudget | MaxBudget |
		| Milton Keynes | 1,000,000 | 50,000    |
		| Milton Keynes | 1,000,000 | 100,000   |
		| Milton Keynes | 5,000,000 | 1,000,000 |
