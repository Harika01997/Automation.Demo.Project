Feature: IxigoFeature

A short summary of the feature

@tag1
Scenario: Search Flights with Autocomplete Suggestions
	Given I am on the ixigo homepage 
	When I type "Delhi" in the departure city input field 
	Then I should see autocomplete suggestions
	When I select a suggestion from the autocomplete 
	Then the departure city input field should be populated correctly
