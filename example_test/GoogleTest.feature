Feature: Google Search Example
	In order to search using google
	As a Searcher
	I want to Google Search to open

@mytag
Scenario: Search Selenium in google and goto download page
	Given I am on google page
	And I search for the text Selenium
	When I press search button
	And I click Selenium link
	Then I click Download link
